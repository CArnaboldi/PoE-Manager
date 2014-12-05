using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PoE_Manager
{
    public partial class MainFrm : Form
    {
        private Dictionary<string, IStatus> _apps;

        //this bool tells us if mainFrm is visible
        private bool _mainFrmVisible = true;

        private InputPoeTradeAddressFrm _poeTradeAddressFrm;

        //object for the global hotkey
        private GlobalHotkey _hotKey;

        //here we link hotkey press to method toggleVisibility
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == Generic.WM_HOTKEY_MSG_ID)
                toggleVisibility();
            base.WndProc(ref m);
        }

        //form should start hidden, this method ovveride assigns to SetVisibleCore
        //the value of setVisibleCore no matter what the value of bool "value" is
        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(_mainFrmVisible ? value : _mainFrmVisible);
        }

        //We don't want any topbar in our window
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~0xC00000; //WS_CAPTION;  
                return cp;
            }
        }
        
        public MainFrm()
        {
            InitializeComponent();

            try
            {

                this.Icon = PoE_Manager.Properties.Resources.poe_icon;

                bool settingsLoaded = false;

                settingsLoaded = SettingsManager.load();

                if (!settingsLoaded)
                {
                    dlg_poe_path.InitialDirectory = Generic.DefaultPoePath;
                    dlg_poe_path.FileName = "PoE executable";
                    dlg_poe_path.Title = "Select your Path of Exile executable";
                    dlg_poe_path.Filter ="exe files |*.exe";
                    dlg_poe_path.ShowDialog();

                    _poeTradeAddressFrm = new InputPoeTradeAddressFrm();
                    //necessary to show _poeTradeAddressFrm on top of other forms
                    this.AddOwnedForm(_poeTradeAddressFrm);

                    _poeTradeAddressFrm.ShowDialog();
        
                    string poeTradePath = _poeTradeAddressFrm.PoeTradeAddress;

                    //add http:// prefix if missing
                    if (!poeTradePath.StartsWith("http://"))
                        poeTradePath = "http://"+poeTradePath;

                    if (File.Exists(dlg_poe_path.FileName) && Uri.IsWellFormedUriString(poeTradePath, UriKind.Absolute))
                    {
                        SettingsManager.PoeFullPath = dlg_poe_path.FileName;
                        SettingsManager.PoeTradePath = poeTradePath;

                        Dictionary<string, bool> autolaunch = new Dictionary<string, bool>();

                        autolaunch.Add(Generic.Procurement, false);
                        autolaunch.Add(Generic.AutoOnline, false);
                        autolaunch.Add(Generic.Helper, false);
                        autolaunch.Add(Generic.Poe, false);

                        SettingsManager.Autolaunch = autolaunch;

                        SettingsManager.save();

                        settingsLoaded = true;
                        
                    }
                    else
                    {
                        MessageBox.Show("Unable to find Path of Exile executable at the specified path or poe.trade URL isn't valid. Closing.", "Error");

                        Environment.Exit(-1);
                    }
                }

                if (settingsLoaded)
                {

                    _apps = new Dictionary<string, IStatus>();

                    _apps.Add(Generic.Poe, (new AppStatus(SettingsManager.PoeExeName, SettingsManager.PoePath, btn_poe_start, btn_poe_stop, lbl_poe_status)));
                    _apps.Add(Generic.Procurement, (new AppStatus("Procurement", "Procurement", btn_procurement_start, btn_procurement_stop, lbl_procurement_status)));
                    _apps.Add(Generic.Helper, (new AppStatus("Helper", "Helper", btn_helper_start, btn_helper_stop, lbl_helper_status)));
                    _apps.Add(Generic.AutoOnline, (new AutoOnlineStatus(btn_autoonline_start, btn_autoonline_stop, lbl_autoonline_status, (AppStatus)_apps[Generic.Poe])));


                    //autolaunch selected apps
                    foreach (KeyValuePair<string, bool> autolaunch in SettingsManager.Autolaunch)
                    {
                        if (autolaunch.Value == true)
                            ((IStatus)_apps[autolaunch.Key]).startApp();

                    }

                    _mainFrmVisible = !SettingsManager.StartHidden;

                    //apply style / check selected autolaunch check buttons / check start hidden button
                    Generic.initStyle(this);

                    try
                    {
                        //our global hotkey (to show/hide the form) is ALT+F1
                        _hotKey = new GlobalHotkey(Generic.toggleVisibilityModifier, Generic.toggleVisibility, this);
                        //hotkey should be enabled just after user successfully authenticates
                        _hotKey.Register();
                    }
                    catch { }
                }

            }
            catch
            {
                SettingsManager.delete();

                MessageBox.Show("Something went wrong. Settings deleted to allow a fresh start. Please restart the program.");

                Environment.Exit(-1);
            }
        }

        private void inputPoeTradeAddress()
        {
            
        }

        private void toggleVisibility()
        {
            if (_mainFrmVisible)
            {
                //hide the form
                _mainFrmVisible = false;

                //I refresh visibility
                this.Visible = true;
            }
            else
            {
                //I show the form
                _mainFrmVisible = true;

                //I refresh visibility
                this.Visible = true;
            }
        }


        private void btn_procurement_start_Click(object sender, EventArgs e)
        {
            _apps[Generic.Procurement].startApp();
        }

        private void btn_procurement_stop_Click(object sender, EventArgs e)
        {
            _apps[Generic.Procurement].stopApp();
        }

        private void btn_autoonline_start_Click(object sender, EventArgs e)
        {
            _apps[Generic.AutoOnline].startApp();
        }

        private void btn_autoonline_stop_Click(object sender, EventArgs e)
        {
            _apps[Generic.AutoOnline].stopApp();
        }

        private void btn_helper_start_Click(object sender, EventArgs e)
        {
            _apps[Generic.Helper].startApp();
        }

        private void btn_helper_stop_Click(object sender, EventArgs e)
        {
            _apps[Generic.Helper].stopApp();
        }

        private void btn_poe_start_Click(object sender, EventArgs e)
        {
            _apps[Generic.Poe].startApp();
        }

        private void btn_poe_stop_Click(object sender, EventArgs e)
        {
            _apps[Generic.Poe].stopApp();
        }

        private void chk_procurement_autolaunch_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.toggleAutolaunch(((CheckBox)sender).Tag.ToString(), ((CheckBox)sender).Checked);
        }

        private void chk_autoonline_autolaunch_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.toggleAutolaunch(((CheckBox)sender).Tag.ToString(), ((CheckBox)sender).Checked);
        }

        private void chk_helper_autolaunch_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.toggleAutolaunch(((CheckBox)sender).Tag.ToString(), ((CheckBox)sender).Checked);
        }

        private void chk_poe_autolaunch_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.toggleAutolaunch(((CheckBox)sender).Tag.ToString(), ((CheckBox)sender).Checked);
        }

        private void chk_starthidden_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.toggleStartHidden(((CheckBox)sender).Checked);
        }

        //terminate all status update checker threads when app is closed
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (KeyValuePair<string, IStatus> app in _apps)
            {
                ((IStatus) app.Value).destroy();
            }
        }

        private void lbl_close_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Generic.mouseEnterButtonColor;
        }

        private void lbl_close_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Generic.buttonBackColor;
        }

        private void lbl_clear_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Generic.mouseEnterButtonColor;
        }

        private void lbl_clear_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Generic.buttonBackColor;
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear all settings and quit PoE Manager?", "Clear all settings and quit PoE Manager?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SettingsManager.delete();
                this.Close();
            }
        }

        private void txt_poe_wiki_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
        }

        private void btn_poe_wiki_search_Click(object sender, EventArgs e)
        {
            if (txt_poe_wiki.Text != "")
                Process.Start("http://pathofexile.gamepedia.com/index.php?search="+txt_poe_wiki.Text);
        }

        private void txt_poe_wiki_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
                btn_poe_wiki_search.PerformClick();
        }

    }
}
