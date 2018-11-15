using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace AdaReport.Class.X_Class
{
    public class cReadFileMdb
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(cReadFileMdb));
        public DataTable C_GEToReadFileMdb(string ptSql)
        {
            try
            {
                var tFileName = "AdaIni.ada";
                var tPathApp = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.LastIndexOf('\\'));
                var tPath = Path.Combine(tPathApp, @"ISSTools\", tFileName);
                var tConDb = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + tPath;
                var oDbTbl = new DataTable();
                var oDbAdt = new OleDbDataAdapter();
                using (var oConDb = new OleDbConnection(tConDb))
                {
                    oConDb.Open();
                    oDbAdt = new OleDbDataAdapter(ptSql, oConDb);
                    oDbAdt.Fill(oDbTbl);
                    return oDbTbl;
                }
            }
            catch (Exception oEx)
            {
                log.Error(oEx.Message);
                throw oEx;
            }
        }
    }
}
