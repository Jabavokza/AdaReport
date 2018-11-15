using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;

namespace AdaReport.Class.X_Class
{
   public class cReadFileINI
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(cReadFileINI));
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
          string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
          string key, string def, StringBuilder retVal,
          int size, string filePath);

        private string tC_Path;
        public cReadFileINI(string ptIniPath)
        {
            tC_Path = ptIniPath;
        }

        public void C_SETxIniWriteValue(string ptSection, string ptKey, string ptValue)
        {
            WritePrivateProfileString(ptSection, ptKey, ptValue, this.tC_Path);
        }

        public string C_GETtIniReadValue(string ptSection, string ptKey)
        {
            StringBuilder oTemp = new StringBuilder(255);
            GetPrivateProfileString(ptSection, ptKey, "", oTemp, 255, this.tC_Path);
            return oTemp.ToString();
        }

    }
}
