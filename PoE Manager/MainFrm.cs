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
using System.Runtime.InteropServices;

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

                        autolaunch.Add(Generic.Procurement_TAG, false);
                        autolaunch.Add(Generic.AutoOnline_TAG, false);
                        autolaunch.Add(Generic.Helper_TAG, false);
                        autolaunch.Add(Generic.Poe_TAG, false);

                        SettingsManager.Autolaunch = autolaunch;

                        this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2);
                        SettingsManager.Location = this.Location;

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

                    _apps.Add(Generic.Poe_TAG, (new AppStatus(SettingsManager.PoeExeName, SettingsManager.PoePath, lbl_poe_status, btn_poe_start, btn_poe_stop, btn_poe_minimize)));
                    _apps.Add(Generic.Procurement_TAG, (new AppStatus("Procurement", "Procurement", lbl_procurement_status, btn_procurement_start, btn_procurement_stop, btn_procurement_minimize)));
                    _apps.Add(Generic.Helper_TAG, (new AppStatus("Helper", "Helper", lbl_helper_status, btn_helper_start, btn_helper_stop)));
                    _apps.Add(Generic.AutoOnline_TAG, (new AutoOnlineStatus(btn_autoonline_start, btn_autoonline_stop, lbl_autoonline_status, (AppStatus)_apps[Generic.Poe_TAG])));


                    //autolaunch selected apps
                    foreach (KeyValuePair<string, bool> autolaunch in SettingsManager.Autolaunch)
                    {
                        if (autolaunch.Value == true)
                            ((IStatus)_apps[autolaunch.Key]).startApp();

                    }

                    _mainFrmVisible = !SettingsManager.StartHidden;
                    
                    //apply style / check selected autolaunch check buttons / check start hidden button
                    Generic.initStyle(this);

                    this.Location = SettingsManager.Location;

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

        private void toggleVisibility()
        {
            if (_mainFrmVisible)
            {
                    //I hide the form
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
            _apps[Generic.Procurement_TAG].startApp();
        }

        private void btn_procurement_stop_Click(object sender, EventArgs e)
        {
            _apps[Generic.Procurement_TAG].stopApp();
        }

        private void btn_procurement_minimize_Click(object sender, EventArgs e)
        {
            ((AppStatus) _apps[Generic.Procurement_TAG]).minimizeApp();
        }

        private void btn_autoonline_start_Click(object sender, EventArgs e)
        {
            _apps[Generic.AutoOnline_TAG].startApp();
        }

        private void btn_autoonline_stop_Click(object sender, EventArgs e)
        {
            _apps[Generic.AutoOnline_TAG].stopApp();
        }

        private void btn_helper_start_Click(object sender, EventArgs e)
        {
            _apps[Generic.Helper_TAG].startApp();
        }

        private void btn_helper_stop_Click(object sender, EventArgs e)
        {
            _apps[Generic.Helper_TAG].stopApp();
        }

        private void btn_poe_start_Click(object sender, EventArgs e)
        {
            _apps[Generic.Poe_TAG].startApp();
        }

        private void btn_poe_stop_Click(object sender, EventArgs e)
        {
            _apps[Generic.Poe_TAG].stopApp();
        }

        private void btn_poe_minimize_Click(object sender, EventArgs e)
        {
            ((AppStatus)_apps[Generic.Poe_TAG]).minimizeApp();
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
        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (KeyValuePair<string, IStatus> app in _apps)
            {
                ((IStatus)app.Value).destroy();
            }
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            YesNoFrm yesNoFrm = new YesNoFrm(this, "Quit PoE Manager", "Are you sure?");

            yesNoFrm.ShowDialog();

            if (yesNoFrm.Confirm)
                this.Close();
           
        }

        private void lbl_help_Click(object sender, EventArgs e)
        {
            (new HelpFrm(this)).ShowDialog();

        }

        private void lbl_clear_Click(object sender, EventArgs e)
        {
            YesNoFrm yesNoFrm = new YesNoFrm(this, "Clear settings", "Clear all settings and quit PoE Manager?");

            yesNoFrm.ShowDialog();
            
            if (yesNoFrm.Confirm)
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

        private void btn_poe_trade_search_Click(object sender, EventArgs e)
        {
            Process.Start("http://poe.trade");
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

        private void lbl_help_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Generic.mouseEnterButtonColor;
        }

        private void lbl_help_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Generic.buttonBackColor;
        }

        #region LeftClickResize

        //handles the pressing of right mouse button on the textbox to move the form
        private void lbl_topbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }

        }

        private void MainFrm_Move(object sender, EventArgs e)
        {
            SettingsManager.Location = this.Location;
            SettingsManager.save();
        }

        //modifiers to move the form while holding the left mouse button in the insertion textbox
        public static readonly int WM_NCLBUTTONDOWN = 0xA1;
        public static readonly int HTCAPTION = 0x2;

        //methods required to move the form while holding the left mouse button in the insertion textbox
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        #endregion

    }
}
