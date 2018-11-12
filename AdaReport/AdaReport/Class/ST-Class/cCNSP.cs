using AdaReport.Class.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Xml;
using System.IO;
using System.Reflection;

namespace AdaReport.Class.ST_Class
{
    public static class cCNSP
    {
        public static DataTable SP_GEToDbTbl(string ptSql,string ptConStr)
        {
            try
            {
                var oDbTbl = new DataTable();
                var oDbCon = new SqlConnection(ptConStr);
                oDbCon.Open();
                var  oDbAdt = new SqlDataAdapter(ptSql,oDbCon);
                oDbAdt.Fill(oDbTbl);
                oDbCon.Close();
                return oDbTbl;
            }
            catch (SqlException oEx)
            {
                throw oEx;
            }

        }

        public static string SP_SETtConStr(mlDbConfig poDbConfig)
        {
            StringBuilder oSql = new StringBuilder();
            try
            { 
                oSql.AppendLine("Data Source = '"+poDbConfig.tML_Server+"'");
                oSql.AppendLine(";Initial Catalog = '" + poDbConfig.tML_DbName + "'");
                oSql.AppendLine(";User ID = '" + poDbConfig.tML_UserName + "'");
                oSql.AppendLine(";Password = '" + poDbConfig.tML_UserPwd + "'");
                return oSql.ToString();
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }

        public static DataTable SP_GEToDbConfigXml()
        {
            XmlReader oXmlFile;
            DataSet oDs = new DataSet();
            DataTable oDbTbl = new DataTable();
            try
            {
                oXmlFile = XmlReader.Create(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\AdaDbSetting.xml", new XmlReaderSettings());
                oDs.ReadXml(oXmlFile);
                oDbTbl = oDs.Tables[0];
                oXmlFile.Close();
                return oDbTbl;
            }
            catch (Exception oEx)
            {
                return null;
            }
            finally
            {
                oXmlFile = null;
                oDs = null;
                oDbTbl = null;
            }
        }
    }
}
