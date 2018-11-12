using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace AdaReport.Class.X_Class
{
    public class cReadFileMdb
    {
        public DataTable C_GEToReadFileMdb(string ptSql)
        {
            try
            {
                string tPath = "AdaIni.ada";
                string tConDb = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + tPath;
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
                throw oEx;
            }  
        }
    }
}
