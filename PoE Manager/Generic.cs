using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

using System.Windows.Forms;


namespace PoE_Manager
{
    public static class Generic
    {
        private static string _utilities_folder = "Tools";
        
        private static readonly string textFont = "Trebuchet MS";
        private static readonly Color titleColor = Color.FromArgb(190, 60, 60);
        private static readonly Color backgroundColor = Color.FromArgb(45, 45, 45);
        public static readonly Color buttonBackColor = Color.FromArgb(90, 90, 90);
        private static readonly Color startColor = Color.FromArgb(30, 170, 30);
        private static readonly Color stopColorDarker = Color.FromArgb(120, 10, 10);
        private static readonly Color stopColor = Color.FromArgb(170, 30, 30);
        private static readonly Color wikiBackColor = Color.FromArgb(201, 205, 179);
        private static readonly Color wikiForeColor = Color.FromArgb(102, 102, 102);
        private static readonly Color genericForeColor = Color.FromArgb(210, 210, 210);
        private static readonly Color genericDarkForeColor = Color.FromArgb(120, 120, 120);
        private static readonly Color mouseDownButtonColor = Color.FromArgb(90, 90, 90);
        private static readonly int buttonFontSize = 13;
        private static readonly int wikiButtonFontSize = 12;
        private static readonly int wikiTextboxFontSize = 13;
        private static readonly int labelFontSize = 10;
        private static readonly int checkboxFontSize = 9;
        private static readonly int autoOnlineButtonFontSize = 7;
        private static readonly int autoOnlineFontSize = 8;
        private static readonly int creditsFontSize = 8;
        private static readonly int shortcutFontSize = 8;
        private static readonly int titleFontSize = 12;
        private static readonly int closeLabelFontSize = 16;
        private static readonly int clearLabelFontSize = 8;

        public static readonly Color mouseEnterButtonColor = Color.FromArgb(105, 105, 105);

        public static readonly string settingsFile = "settings.dat";
        public static readonly string DefaultPoePath = "C:\\Program Files (x86)\\Grinding Gear Games\\Path of Exile";
        public static readonly string Procurement = "PROCUREMENT";
        public static readonly string AutoOnline = "AUTOONLINE";
        public static readonly string Helper = "HELPER";
        public static readonly string Poe = "POE";     
        public static readonly string Credits = "CREDITS";

        public static readonly int ThreadSleep = 100;
        public static readonly int LockSleep = 10;
        //auto-online refreshes every 59 minutes
        public static readonly int PoeTradeTimer = 3000 * 60 * 59;

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

        public static void startStyle(Button btn_start, Button btn_stop, Label lbl_status)
        {
            lbl_status.Invoke(new MethodInvoker(delegate
             {
                 btn_start.Text = "Restart";
                 btn_stop.Enabled = true;
                 lbl_status.ForeColor = startColor;
             }));
        }

        public static void stopStyle(Button btn_start, Button btn_stop, Label lbl_status)
        {
            lbl_status.Invoke(new MethodInvoker(delegate
             {
                 btn_start.Text = "»";
                 btn_stop.Enabled = false;
                 lbl_status.ForeColor = stopColor;
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


            foreach (Button button in buttons)
            {
                button.Font = new Font(textFont, Convert.ToSingle(buttonFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                
                button.BackColor = buttonBackColor;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.MouseOverBackColor = mouseEnterButtonColor;
                button.FlatAppearance.MouseDownBackColor = mouseDownButtonColor;

                if (button.Tag.ToString() == "start")
                {
                    button.ForeColor = startColor;
                    button.Text = "»";
                }
                else if (button.Tag.ToString() == "stop")
                {
                    button.ForeColor = stopColor;
                    button.Text = "×";
                }
                else if (button.Tag.ToString() == "wiki")
                {
                    button.FlatAppearance.BorderSize = 0;
                    button.Font = new Font(textFont, Convert.ToSingle(wikiButtonFontSize), FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                    button.ForeColor = genericForeColor;
                    button.Text = "wiki »";
                }
            
            }

            foreach (Label label in labels)
            {
                label.Font = new Font(textFont, Convert.ToSingle(labelFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

                label.TextAlign = ContentAlignment.MiddleCenter;
                label.FlatStyle = FlatStyle.Flat;

                if (label.Tag.ToString().Equals(Generic.Procurement))
                    label.Text = "Procurement";

                else if (label.Tag.ToString().Equals(Generic.AutoOnline))
                {
                    label.Font = new Font(textFont, Convert.ToSingle(autoOnlineFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    label.Text = "poe.trade autoonline";
                }
                else if (label.Tag.ToString().Equals(Generic.Helper))
                    label.Text = "Helper";

                else if (label.Tag.ToString().Equals(Generic.Poe))
                    label.Text = "Path of Exile";
                else if (label.Tag.ToString().Equals(Generic.Credits))
                {
                    label.Font = new Font(textFont, Convert.ToSingle(creditsFontSize), FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = genericDarkForeColor;
                    label.Text = "version   " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion  + " by Y3k - 2014";
                }
                else if (label.Tag.ToString() == "close")
                {
                    label.Font = new Font(textFont, Convert.ToSingle(closeLabelFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = genericForeColor;
                    label.BackColor = buttonBackColor;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Text = "×";
                }
                else if (label.Tag.ToString() == "clear")
                {
                    label.Font = new Font(textFont, Convert.ToSingle(clearLabelFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = genericForeColor;
                    label.BackColor = buttonBackColor;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Text = "Clear Settings";
                }
                else if (label.Tag.ToString() == "outline")
                {
                    label.BackColor = buttonBackColor;
                }
                else if (label.Tag.ToString() == "shortcut")
                {
                    label.Font = new Font(textFont, Convert.ToSingle(shortcutFontSize), FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = genericDarkForeColor;
                    label.Text = "toggle visibility with ALT+F2";
                }
                else if (label.Tag.ToString() == "title")
                {
                    label.ForeColor = Generic.titleColor;
                    label.Font = new Font(textFont, Convert.ToSingle(titleFontSize), FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    label.Text = "PoE Manager";
                }
           
            }

            foreach (TextBox textbox in textboxes)
            {
                if (textbox.Tag.ToString() == "wiki")
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
                
                if (checkbox.Tag.ToString() == "STARTHIDDEN")
                {
                    checkbox.ForeColor = genericDarkForeColor;
                    checkbox.BackColor = backgroundColor;
                    checkbox.Font = new Font(textFont, Convert.ToSingle(checkboxFontSize), FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
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
