using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace PoE_Manager
{
    public class AutoOnlineStatus : IStatus
    {

        private volatile bool _engineStarted = false;
        private volatile bool _timerStarted = false;
        private volatile bool _autoOnlineStarted = false;

        private int _timeToGo = 0;
        private object _timeToGoLock = new object();

        private bool? _doUpdate = null;
        

        private Button _btn_start;
        private Button _btn_stop;
        private Label _lbl_status;
        private AppStatus _poe_status;
        
        public AutoOnlineStatus(Button btn_start, Button btn_stop, Label lbl_status, AppStatus poe_status)
        {
            _btn_start = btn_start;
            _btn_stop = btn_stop;
            _lbl_status = lbl_status;
            _poe_status = poe_status;

            _engineStarted = true;

            (new Thread(new ThreadStart(updateStatus))).Start();
        }

        private void updateStatus()
        {
            bool success = false;

            while (_engineStarted)
            {
                try
                {

                    if (_autoOnlineStarted)
                    {
                        if (_poe_status.isRunning())
                        {

                            if (_doUpdate == null || _doUpdate == true)
                            {
                                _doUpdate = false;

                                success = sendUpdateToPoeTrade();

                                Generic.updateAutoOnlineStyle(_btn_start, _btn_stop, _lbl_status, _timeToGo, success);

                                _timerStarted = true;

                                (new Thread(new ThreadStart(timer))).Start();
                            }

                            else
                                Generic.updateAutoOnlineStyle(_btn_start, _btn_stop, _lbl_status, _timeToGo, success);
                        }
                        else
                            Generic.pauseAutoOnlineStyle(_btn_start, _btn_stop, _lbl_status);

                    }

                    else
                        Generic.stopAutoOnlineStyle(_btn_start, _btn_stop, _lbl_status);
                }
                catch { }

                Thread.Sleep(Generic.ThreadSleep);
            }
        }

        private void timer()
        {
            _timeToGo = Generic.PoeTradeTimer;

            while (_timerStarted && _timeToGo>0)
            {             
                try
                {
                    while (!Monitor.TryEnter(_timeToGoLock))
                        Thread.Sleep(Generic.LockSleep);
                    
                    _timeToGo = _timeToGo - Generic.ThreadSleep;
                    Thread.Sleep(Generic.ThreadSleep);
                }

                finally
                {
                   Monitor.Exit(_timeToGoLock);
                }
                            
            }

            _doUpdate = true;
        }

        void IStatus.startApp()
        {
            //if auto_online was already active (in failed state) I'll restart it
            //(If update is succesfull I can't restart this)
            if (_autoOnlineStarted == true)
            {
                _timerStarted = false;

                try
                {
                    while (!Monitor.TryEnter(_timeToGoLock))
                        Thread.Sleep(Generic.LockSleep);
                        
                    _timeToGo = 0;
                    _doUpdate = true;

                }

                finally
                {
                    Monitor.Exit(_timeToGoLock);
                }
       
            }
            else
                _autoOnlineStarted = true;
        }

        void IStatus.stopApp()
        {

            _timerStarted = false;
            _autoOnlineStarted = false;
        }

        void IStatus.destroy()
        {
            _autoOnlineStarted = false;
            _engineStarted = false;
            _timerStarted = false;
        }
        
        
        private bool sendUpdateToPoeTrade()
        {
            try
            {
                var url = new Uri(SettingsManager.PoeTradePath);
                var req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "POST";
                req.AllowAutoRedirect = false;
                HttpWebResponse response = null;
                try
                {
                    response = (HttpWebResponse)req.GetResponse();
                }
                catch (WebException ex)
                {
                    return false;
                }

                if (response.Headers["Location"].ToLower() != url.ToString().ToLower())
                {
                    return false;
                }
                req.Abort(); // Abort to be sure requests don't hang

                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
