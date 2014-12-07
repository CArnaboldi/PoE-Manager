using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

namespace PoE_Manager
{
    public static class Generic
    {
        
        #region UI_Tags

        public static readonly string Procurement_TAG = "PROCUREMENT";
        public static readonly string AutoOnline_TAG = "AUTOONLINE";
        public static readonly string Helper_TAG = "HELPER";
        public static readonly string Poe_TAG = "POE";
        
        private static readonly string Start_TAG = "START";
        private static readonly string Stop_TAG = "STOP";
        private static readonly string Minimize_TAG = "MINIMIZE";
        private static readonly string Wiki_TAG = "WIKI";
        private static readonly string Search_Wiki_TAG = "SEARCH_WIKI";
        private static readonly string Search_Poetrade_TAG = "SEARCH_POETRADE";
        private static readonly string Start_Hidden_TAG = "STARTHIDDEN";
        private static readonly string Credits_TAG = "CREDITS";
        private static readonly string Close_TAG = "CLOSE";
        private static readonly string Help_TAG = "HELP";
        private static readonly string Clear_TAG = "CLEAR";
        private static readonly string Topbar_TAG = "TOPBAR";
        private static readonly string Topbar_Long_TAG = "TOPBAR_LONG";
        private static readonly string Bottombar_TAG = "BOTTOMBAR";
        private static readonly string Yes_TAG = "YES";
        private static readonly string No_TAG = "NO";
        private static readonly string Dialog_TAG = "DIALOG";
        private static readonly string Title_TAG = "TITLE";
        private static readonly string Poemanager_Hotkey_TAG = "POEMANAGER_HOTKEY";
        private static readonly string Helper_Hotkeys_TAG = "HELPER_HOTKEYS";
        private static readonly string Helper_Quit_Hotkey_TAG = "HELPER_QUIT_HOTKEY";
        private static readonly string Helper_Remaining_Hotkey_TAG = "HELPER_REMAINING_HOTKEY";
        private static readonly string Helper_Itemlevel_Hotkey_TAG = "HELPER_ITEMLEVEL_HOTKEY";
        private static readonly string Helper_Oos_Hotkey_TAG = "HELPER_OOS_HOTKEY";

        #endregion


        public static readonly string settingsFile = "settings.dat";
        public static readonly string DefaultPoePath = "C:\\Program Files (x86)\\Grinding Gear Games\\Path of Exile";

        private static string _utilities_folder = "Tools";

        public static readonly int ThreadSleep = 300;
        public static readonly int LockSleep = 10;

        //auto-online refreshes every 59 minutes
        public static readonly int PoeTradeTimer = 3000 * 60 * 59;
        
        private static readonly string textFont = "Trebuchet MS";

        public static readonly Color buttonBackColor = Color.FromArgb(90, 90, 90);
        public static readonly Color mouseEnterButtonColor = Color.FromArgb(105, 105, 105);

        private static readonly Color backgroundColor = Color.FromArgb(45, 45, 45);
        private static readonly Color startColor = Color.FromArgb(79, 211, 41);
        private static readonly Color stopColorDarker = Color.FromArgb(120, 10, 10);
        private static readonly Color stopColor = Color.FromArgb(211, 4, 41);
        private static readonly Color minimizeColor = Color.FromArgb(248, 176, 80);
        private static readonly Color wikiBackColor = Color.FromArgb(201, 205, 179);
        private static readonly Color wikiForeColor = Color.FromArgb(102, 102, 102);
        private static readonly Color genericForeColor = Color.FromArgb(210, 210, 210);
        private static readonly Color titleForeColor = Color.FromArgb(79, 211, 41);
        private static readonly Color creditsColor = Color.FromArgb(211, 4, 41);
        private static readonly Color startHiddenCheckboxColor = Color.FromArgb(79, 211, 41);
        private static readonly Color mouseDownButtonColor = Color.FromArgb(90, 90, 90);
        private static readonly int buttonFontSize = 13;
        private static readonly int buttonStartedFontSize = 9;
        private static readonly int standardButtonFontSize = 12;
        private static readonly int wikiTextboxFontSize = 13;
        private static readonly int labelFontSize = 10;
        private static readonly int titleFontSize = 10;
        private static readonly int checkboxFontSize = 9;
        private static readonly int autoOnlineButtonFontSize = 7;
        private static readonly int autoOnlineFontSize = 8;
        private static readonly int creditsFontSize = 8;
        private static readonly int closeButtonLabelFontSize = 16;
        private static readonly int menuLabelFontSize = 8;

        public static bool isRunning(string app_name, string app_folder_name)
        {
            try
            {
                string app_full_path = appFullPath(app_name, app_folder_name);

                Process app = Process.GetProcessesByName(app_name).FirstOrDefault(p => p.MainModule.FileName.Equals(app_full_path, StringComparison.InvariantCultureIgnoreCase));

                if (app != null)

                    return true;
                else
                    return false;
            }

            catch { return false; }
        }

        public static string appFullPath(string app_name, string app_folder_name)
        {
            if (app_name != SettingsManager.PoeExeName)
                return managerPath() + _utilities_folder + "\\" + app_folder_name + "\\" + app_name + ".exe";
            else
                return SettingsManager.PoeFullPath;
        }

        public static string appPath(string app_name, string app_folder_name)
        {
            if (app_name != SettingsManager.PoeExeName)
                return managerPath() + _utilities_folder + "\\" + app_folder_name + "\\";
            else
                return SettingsManager.PoePath;
        }

        public static void startStyle(Button btn_start, Button btn_stop, Button btn_minimize, Label lbl_status)
        {
            lbl_status.Invoke(new MethodInvoker(delegate
             {
                 btn_start.Font = new Font(textFont, Convert.ToSingle(buttonStartedFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

                 if (lbl_status.Tag.ToString().Equals(Helper_TAG))
                 {
                     btn_start.Text = "enabled";
                     btn_start.Enabled = false;                    
                 }
                 else 
                 {
                     btn_start.Text = "get focus";
                 }

                 //show minimize button while resizing close button
                 if (btn_minimize != null && btn_minimize.Enabled == false)
                 {
                     btn_minimize.Enabled = true;
                     btn_minimize.Visible = true;
                     btn_stop.Width = btn_stop.Width / 2;
                     btn_stop.Location = new Point(btn_stop.Location.X + btn_stop.Width, btn_stop.Location.Y);
                 }
                     
                 btn_stop.Enabled = true;
                 lbl_status.ForeColor = startColor;
             }));
        }


        public static void stopStyle(Button btn_start, Button btn_stop, Button btn_minimize, Label lbl_status)
        {
            lbl_status.Invoke(new MethodInvoker(delegate
             {
                 btn_start.Font = new Font(textFont, Convert.ToSingle(buttonFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                 btn_start.Text = "»";

                 if (lbl_status.Tag.ToString().Equals(Helper_TAG))
                     btn_start.Enabled = true;
                 
                 btn_stop.Enabled = false;
                 lbl_status.ForeColor = stopColor;

                 //hide minimize button while resizing close button
                 if (btn_minimize != null && btn_minimize.Enabled == true)
                 {
                     btn_minimize.Enabled = false;
                     btn_minimize.Visible = false;
                     btn_stop.Location = new Point(btn_stop.Location.X - btn_stop.Width, btn_stop.Location.Y);
                     btn_stop.Width = btn_stop.Width * 2;
                 }

             }));
        }

        public static void updateAutoOnlineStyle(Button btn_start, Button btn_stop, Label lbl_status, int timeBeforeNext, bool success)
        {
            btn_start.Invoke(new MethodInvoker(delegate
                {
                    TimeSpan t = TimeSpan.FromMilliseconds(timeBeforeNext);
                    string time = string.Format("{0:D2}m:{1:D2}s", t.Minutes, t.Seconds);
                    
                    btn_stop.Enabled = true;

                    lbl_status.ForeColor = startColor;
                    
                    btn_start.Font = new Font(textFont, Convert.ToSingle(autoOnlineButtonFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    
                    if (success)
                    {
                        btn_start.ForeColor = startColor;
                        btn_start.Enabled = false;
                        btn_start.Text = "Updated, next in " + time;
                        
                    }
                    else
                    {
                        btn_start.ForeColor = stopColorDarker;
                        btn_start.Enabled = true;
                        btn_start.Text = "Failed, retry in " + time;
                    }
                }));
        }

        public static void pauseAutoOnlineStyle(Button btn_start, Button btn_stop, Label lbl_status)
        {
            btn_start.Invoke(new MethodInvoker(delegate
                {
                    btn_start.Font = new Font(textFont, Convert.ToSingle(autoOnlineButtonFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    btn_start.Enabled = false;
                    btn_start.ForeColor = stopColorDarker;
                    btn_start.Text = "PoE not running.";

                    btn_stop.Enabled = true;

                    lbl_status.ForeColor = startColor;
                }));
        }

        public static void stopAutoOnlineStyle(Button btn_start, Button btn_stop, Label lbl_status)
        {
            lbl_status.Invoke(new MethodInvoker(delegate
             {
                 //these 2 could have been changed by updateAutoOnlineStyle
                 btn_start.ForeColor = startColor;
                 btn_start.Font = new Font(textFont, Convert.ToSingle(buttonFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                 
                 btn_start.Text = "»";
                 btn_stop.Enabled = false;
                 btn_start.Enabled = true;
                 lbl_status.ForeColor = stopColor;

                 
             }));
        }

        public static void initStyle(Form baseForm)
        {
            baseForm.BackColor = backgroundColor;
            
            IEnumerable<Control> buttons = GetAll(baseForm, typeof(Button));
            IEnumerable<Control> labels = GetAll(baseForm, typeof(Label));
            IEnumerable<Control> checkboxes = GetAll(baseForm, typeof(CheckBox));
            IEnumerable<Control> textboxes = GetAll(baseForm, typeof(TextBox));
            IEnumerable<Control> panels = GetAll(baseForm, typeof(Panel));


            foreach (Button button in buttons)
            {
                button.Font = new Font(textFont, Convert.ToSingle(buttonFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                
                button.BackColor = buttonBackColor;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.MouseOverBackColor = mouseEnterButtonColor;
                button.FlatAppearance.MouseDownBackColor = mouseDownButtonColor;

                if (button.Tag.ToString().Equals(Start_TAG))
                {
                    button.ForeColor = startColor;
                    button.Text = "»";
                }
                else if (button.Tag.ToString().Equals(Stop_TAG))
                {
                    button.ForeColor = stopColor;
                    button.Text = "×";
                }
                else if (button.Tag.ToString().Equals(Minimize_TAG))
                {
                    button.Enabled = false;
                    button.Visible = false;
                    button.ForeColor = minimizeColor;
                    button.Text = "_";
                }
                else if (button.Tag.ToString().Equals(Search_Wiki_TAG))
                {
                    button.FlatAppearance.BorderSize = 0;
                    button.Font = new Font(textFont, Convert.ToSingle(standardButtonFontSize), FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                    button.ForeColor = genericForeColor;
                    button.Text = "&wiki »";
                }
                else if (button.Tag.ToString().Equals(Search_Poetrade_TAG))
                {
                    button.FlatAppearance.BorderSize = 0;
                    button.Font = new Font(textFont, Convert.ToSingle(standardButtonFontSize), FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                    button.ForeColor = genericForeColor;
                    button.Text = "&poe.trade";
                }
                else if (button.Tag.ToString().Equals(Yes_TAG))
                {
                    button.FlatAppearance.BorderSize = 0;
                    button.Font = new Font(textFont, Convert.ToSingle(standardButtonFontSize), FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                    button.ForeColor = genericForeColor;
                    button.Text = "&Yes";
                }
                else if (button.Tag.ToString().Equals(No_TAG))
                {
                    button.FlatAppearance.BorderSize = 0;
                    button.Font = new Font(textFont, Convert.ToSingle(standardButtonFontSize), FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                    button.ForeColor = genericForeColor;
                    button.Text = "&No";
                }
            
            }

            foreach (Label label in labels)
            {
                label.Font = new Font(textFont, Convert.ToSingle(labelFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

                label.TextAlign = ContentAlignment.MiddleCenter;
                label.FlatStyle = FlatStyle.Flat;

                if (label.Tag.ToString().Equals(Procurement_TAG))
                    label.Text = "Procurement";

                else if (label.Tag.ToString().Equals(AutoOnline_TAG))
                {
                    label.Font = new Font(textFont, Convert.ToSingle(autoOnlineFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    label.Text = "poe.trade autoonline";
                }
                else if (label.Tag.ToString().Equals(Helper_TAG))
                    label.Text = "Helper";

                else if (label.Tag.ToString().Equals(Poe_TAG))
                    label.Text = "Path of Exile";
                else if (label.Tag.ToString().Equals(Credits_TAG))
                {
                    label.Font = new Font(textFont, Convert.ToSingle(creditsFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = creditsColor;
                    label.BackColor = Color.Transparent;
                    label.Text = "version  " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion  + " by Y3k - 2014";
                }
                else if (label.Tag.ToString().Equals(Close_TAG))
                {
                    label.Font = new Font(textFont, Convert.ToSingle(closeButtonLabelFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = genericForeColor;
                    label.BackColor = buttonBackColor;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Text = "×";
                }
                else if (label.Tag.ToString().Equals(Help_TAG))
                {
                    label.Font = new Font(textFont, Convert.ToSingle(menuLabelFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = genericForeColor;
                    label.BackColor = buttonBackColor;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Text = "&Help";
                }
                else if (label.Tag.ToString().Equals(Clear_TAG))
                {
                    label.Font = new Font(textFont, Convert.ToSingle(menuLabelFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = genericForeColor;
                    label.BackColor = buttonBackColor;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Text = "&Clear Settings";
                }
                else if (label.Tag.ToString().Equals(Topbar_TAG))
                {
                    label.Image = PoE_Manager.Properties.Resources.topbar;
                }
                else if (label.Tag.ToString().Equals(Dialog_TAG))
                {
                    label.Font = new Font(textFont, Convert.ToSingle(labelFontSize), FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = genericForeColor;
                }
                else if (label.Tag.ToString().Equals(Title_TAG))
                {
                    label.Font = new Font(textFont, Convert.ToSingle(titleFontSize), FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                    label.BackColor = Color.Transparent;
                    label.ForeColor = titleForeColor;
                }
                else if (label.Tag.ToString().Equals(Poemanager_Hotkey_TAG))
                {
                    label.Font = new Font(textFont, Convert.ToSingle(labelFontSize) - 1, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = genericForeColor;
                    label.Text = "Toggle PoE Manager visibility: ALT + F2";
                }
                else if (label.Tag.ToString().Equals(Helper_Hotkeys_TAG))
                {
                    label.Font = new Font(textFont, Convert.ToSingle(labelFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = genericForeColor;
                    label.Text = "Helper Hotkeys";
                }
                else if (label.Tag.ToString().Equals(Helper_Quit_Hotkey_TAG))
                {
                    label.Font = new Font(textFont, Convert.ToSingle(labelFontSize) - 1, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = genericForeColor;
                    label.Text = "Quit to login screen: F3";
                }
                else if (label.Tag.ToString().Equals(Helper_Remaining_Hotkey_TAG))
                {
                    label.Font = new Font(textFont, Convert.ToSingle(labelFontSize) - 1, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = genericForeColor;
                    label.Text = "Remaining monsters: CTRL + A";
                }
                else if (label.Tag.ToString().Equals(Helper_Itemlevel_Hotkey_TAG))
                {
                    label.Font = new Font(textFont, Convert.ToSingle(labelFontSize) - 1, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = genericForeColor;
                    label.Text = "Itemlevel: ALT + C";
                }
                else if (label.Tag.ToString().Equals(Helper_Oos_Hotkey_TAG))
                {
                    label.Font = new Font(textFont, Convert.ToSingle(labelFontSize) - 1, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = genericForeColor;
                    label.Text = "Oos (force resync): CTRL + X";
                }
                        
            }

            foreach (Panel panel in panels)
            {
                if (panel.Tag.ToString().Equals(Bottombar_TAG))
                {
                    panel.BackgroundImage = PoE_Manager.Properties.Resources.bottombar;  
                }
                else if (panel.Tag.ToString().Equals(Topbar_Long_TAG))
                {
                    panel.BackgroundImage = PoE_Manager.Properties.Resources.topbar_long;
                }
            }

            foreach (TextBox textbox in textboxes)
            {
                if (textbox.Tag.ToString().Equals(Wiki_TAG))
                {
                    textbox.Font = new Font(textFont, Convert.ToSingle(wikiTextboxFontSize), FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                    textbox.ForeColor = wikiForeColor;
                    textbox.BackColor = wikiBackColor;
                    textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                }
            }

            foreach (CheckBox checkbox in checkboxes)
            { 
                checkbox.FlatStyle = FlatStyle.Flat;
                checkbox.Appearance = Appearance.Normal;

                if (checkbox.Tag.ToString().Equals(Start_Hidden_TAG))
                {
                    checkbox.ForeColor = startHiddenCheckboxColor;
                    checkbox.BackColor = Color.Transparent;
                    checkbox.Font = new Font(textFont, Convert.ToSingle(checkboxFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    checkbox.TextAlign = ContentAlignment.MiddleLeft;
                    checkbox.Text = "start hidden";
                    checkbox.Checked = SettingsManager.StartHidden;                    
                }
                else
                {
                    checkbox.ForeColor = genericForeColor;
                    checkbox.Font = new Font(textFont, Convert.ToSingle(checkboxFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    checkbox.TextAlign = ContentAlignment.MiddleCenter;
                    checkbox.Text = "autostart";
                    checkbox.Checked = SettingsManager.getAutolaunch(checkbox.Tag.ToString());
                }
            }
        }

        private static string managerPath()
        {
            string toReturn = Assembly.GetExecutingAssembly().Location;

            string managerExeName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

            toReturn = toReturn.Replace(managerExeName + ".exe", "");

            return toReturn;
        }

        private static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        #region GlobalHotKey

        //unused modifiers for global hotkeys (to swap with toggleVisibilityModifier in Shortcuts)
        private static readonly int NOMOD = 0x0000;
        private static readonly int CTRL = 0x0002;
        private static readonly int SHIFT = 0x0004;
        private static readonly int WIN = 0x0008;

        //windows message id for hotkey
        public static readonly int WM_HOTKEY_MSG_ID = 0x0312;

        #endregion


        #region Shortcuts

        public static Keys toggleVisibility = Keys.F2;
        public static readonly int toggleVisibilityModifier = 0x0001;   //alt

        #endregion
        

    }
}
