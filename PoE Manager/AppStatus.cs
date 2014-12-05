using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Reflection;


namespace PoE_Manager
{
    public class AppStatus : IStatus
    {
        private string _app_name;
        private string _app_folder_name; 
        private Button _btn_start;
        private Button _btn_stop;
        private Label _lbl_status;

        private volatile bool _doWork = false;

        public string Name { get { return _app_name; } }
        public string FolderName { get { return _app_folder_name; } }
        
        
        public AppStatus(string app_name, string app_folder_name, Button btn_start, Button btn_stop, Label lbl_status)
        {
            _app_name = app_name;
            _app_folder_name = app_folder_name;
            _btn_start = btn_start;
            _btn_stop = btn_stop;
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
              
                        Generic.startStyle(_btn_start, _btn_stop, _lbl_status);                              
                    else
                        Generic.stopStyle(_btn_start, _btn_stop, _lbl_status);

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
                    //quit application and restart it
                    
                    foreach (Process p in Process.GetProcessesByName(_app_name))
                    {
                        if (p.MainModule.FileName.Equals(Generic.appFullPath(_app_name, _app_folder_name), StringComparison.InvariantCultureIgnoreCase))
                            p.Kill();
                    }

                    while (Generic.isRunning(_app_name, _app_folder_name))
                        Thread.Sleep(Generic.ThreadSleep);

                    ProcessStartInfo startInfo = new ProcessStartInfo(Generic.appFullPath(_app_name, _app_folder_name));
                    startInfo.WorkingDirectory = Generic.appPath(_app_name, _app_folder_name);
                    Process.Start(startInfo);
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
