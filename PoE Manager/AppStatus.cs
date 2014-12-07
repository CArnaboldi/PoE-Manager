using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;


namespace PoE_Manager
{
       
    public class AppStatus : IStatus
    {
        private string _app_name;
        private string _app_folder_name; 
        private Button _btn_start;
        private Button _btn_stop;
        private Button _btn_minimize;
        private Label _lbl_status;
        private volatile bool _doWork = false;

        public string Name { get { return _app_name; } }
        public string FolderName { get { return _app_folder_name; } }

        [DllImport("user32.dll")]
        public static extern void SwitchToThisWindow(IntPtr hWnd);

        //[DllImport("user32.dll")]
        //public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        
        public AppStatus(string app_name, string app_folder_name, Label lbl_status, Button btn_start, Button btn_stop, Button btn_minimize=null)
        {
            _app_name = app_name;
            _app_folder_name = app_folder_name;
            _btn_start = btn_start;
            _btn_stop = btn_stop;
            _btn_minimize = btn_minimize;
            _lbl_status = lbl_status;

            _doWork = true;

            (new Thread(new ThreadStart(updateStatus))).Start();
        }

        void IStatus.destroy()
        {
            _doWork = false;
        }
        
        private void updateStatus()
        {
            while (_doWork)
            {
                try
                {
                    if (Generic.isRunning(_app_name, _app_folder_name))
              
                        Generic.startStyle(_btn_start, _btn_stop, _btn_minimize, _lbl_status);                              
                    else
                        Generic.stopStyle(_btn_start, _btn_stop, _btn_minimize, _lbl_status);

                }
                catch { }

                Thread.Sleep(Generic.ThreadSleep);
            }

        }

        public bool isRunning()
        {
            if (Generic.isRunning(_app_name, _app_folder_name))
                return true;

            return false;
        }

        public void minimizeApp()
        {
            foreach (Process p in Process.GetProcessesByName(_app_name))
            {
                if (p.MainModule.FileName.Equals(Generic.appFullPath(_app_name, _app_folder_name), StringComparison.InvariantCultureIgnoreCase))
                    ShowWindow(p.MainWindowHandle,2);
            }
        }

        void IStatus.startApp()
        {
            try
            {
                if (!Generic.isRunning(_app_name, _app_folder_name))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo(Generic.appFullPath(_app_name, _app_folder_name));
                    startInfo.WorkingDirectory = Generic.appPath(_app_name, _app_folder_name);
                    Process.Start(startInfo);
                }

                else
                {
                    //the app is already running, only bring it to foreground      
                    foreach (Process p in Process.GetProcessesByName(_app_name))
                    {
                        if (p.MainModule.FileName.Equals(Generic.appFullPath(_app_name, _app_folder_name), StringComparison.InvariantCultureIgnoreCase))
                            SwitchToThisWindow(p.MainWindowHandle);
                    }

                }
            }
            catch { }
        }

        void IStatus.stopApp()
        {
            try
            {
                foreach (Process p in Process.GetProcessesByName(_app_name))
                {
                    if (p.MainModule.FileName.Equals(Generic.appFullPath(_app_name, _app_folder_name), StringComparison.InvariantCultureIgnoreCase))
                        p.Kill();
                }

            }
            catch { }
        }

        
    }
}
