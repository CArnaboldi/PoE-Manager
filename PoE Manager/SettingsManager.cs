using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace PoE_Manager
{
    [Serializable]
    public static class SettingsManager
    {
        public static string PoeFullPath { get { return _poeFullPath; } 
            set { 
                _poeFullPath = value;

                //from now on these should return correct values
                _poePath = poeFolder(_poeFullPath);
                _poeExeName = poeExeName(_poeFullPath);
            } }

        public static string PoeExeName { get { return _poeExeName; } }
        public static string PoePath { get { return _poePath; } }

        public static string PoeTradePath { get { return _poeTradePath; } set { _poeTradePath = value; } }
        public static Dictionary<string, bool> Autolaunch { get { return _autolaunch; } set { _autolaunch = value; } }

        public static bool StartHidden { get { return _startHidden; } set { _startHidden = value; } }

        private static string _poeFullPath = "";
        private static string _poePath = "";
        private static string _poeExeName = "";
        private static string _poeTradePath = "";
        private static Dictionary<string,bool> _autolaunch = new Dictionary<string,bool>();
        private static bool _startHidden = false;

        public static void save()
        {
            try
            {
                using (FileStream file = new FileStream(Generic.settingsFile, FileMode.Create, FileAccess.Write))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    Tuple<string, string, Dictionary<string, bool>, bool> managerInfo = new Tuple<string, string, Dictionary<string, bool>, bool>(_poeFullPath, _poeTradePath, _autolaunch, _startHidden);

                    formatter.Serialize(file, managerInfo);
                }
            }
            catch { }
        }

        public static bool load()
        {
            try
            {
                using (FileStream file = new FileStream(Generic.settingsFile, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Tuple<string, string, Dictionary<string, bool>, bool> managerInfo = (Tuple<string, string, Dictionary<string, bool>, bool>)formatter.Deserialize(file);

                    _poeFullPath = managerInfo.Item1;

                    //PoePath and PoeExeName public properties should also be filled from now on
                    _poePath = poeFolder(_poeFullPath);
                    _poeExeName = poeExeName(_poeFullPath);

                    _poeTradePath = managerInfo.Item2;
                    _autolaunch = managerInfo.Item3;
                    _startHidden = managerInfo.Item4;

                    if (_poeFullPath != null && _autolaunch != null) return true;
                }
            }
            catch 
            { 
                delete();
                return false;
            } //maybe file isn't valid

            return false;
        }

        private static string poeFolder(string poeFullPath)
        {
            int i = 0;          
            for (i=PoeFullPath.Length-1;i>=0;i--)
            {
                if (PoeFullPath[i]=='\\')
                    break;           
            }

            return PoeFullPath.Substring(0, i + 1);
        }

        //return exe name without .exe extension
        private static string poeExeName(string poeFullPath)
        {
            int i = 0;
            for (i = PoeFullPath.Length - 1; i >= 0; i--)
            {
                if (PoeFullPath[i] == '\\')
                    break;
            }

            return PoeFullPath.Substring(i+1).Replace(".exe","");
        }

        public static void toggleAutolaunch(string application, bool isChecked)
        {
            _autolaunch[application] = isChecked;

            save();
        }

        public static void toggleStartHidden(bool isChecked)
        {
            _startHidden = isChecked;

            save();
        }

        public static bool getAutolaunch(string application)
        {
            return _autolaunch[application];
        }

        public static void delete()
        {
            File.Delete(Generic.settingsFile);
        }

    }
}
