﻿using AdaReport.Class.Models;
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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(cCNSP));
        public static DataTable SP_GEToDbTbl(string ptSql)
        {
            try
            {
                var oDbTbl = new DataTable();
                var oDbCon = new SqlConnection(SP_SETtConStr());
                oDbCon.Open();
                var  oDbAdt = new SqlDataAdapter(ptSql,oDbCon);
                oDbAdt.Fill(oDbTbl);
                oDbCon.Close();
                return oDbTbl;
            }
            catch (SqlException oEx)
            {
                log.Error(oEx.Message);
                throw oEx; 
            }
        }
        public static DataSet SP_GEToDbSet(string ptSql)
        {
            try
            {
                var oDbSet = new DataSet();
                var oDbCont = new SqlConnection(SP_SETtConStr());
                oDbCont.Open();
                var oDbAdt = new SqlDataAdapter(ptSql, oDbCont);
                oDbAdt.Fill(oDbSet);
                oDbCont.Close();
                return oDbSet;
            }
            catch (SqlException oEx)
            {
                log.Error(oEx.Message);
                throw oEx;
            }
        }

        public static string SP_SETtConStr()
        {
            StringBuilder oSql = new StringBuilder();
            try
            {
                  var oXmlDb = SP_GEToDbSettingXml();
                oSql.AppendLine("Data Source = '" + oXmlDb.Rows[0]["Server"].ToString() + "'");
                oSql.AppendLine(";Initial Catalog = '" + oXmlDb.Rows[0]["DbName"].ToString() + "'");
                oSql.AppendLine(";User ID = '" + oXmlDb.Rows[0]["UserDb"].ToString() + "'");
                oSql.AppendLine(";Password = '" + oXmlDb.Rows[0]["PwdDb"].ToString() + "'");
                return oSql.ToString();

                //oSql.AppendLine("Data Source = '172.16.30.151'");
                //oSql.AppendLine(";Initial Catalog = 'POSSDB_Test'");
                //oSql.AppendLine(";User ID = 'sa'");
                //oSql.AppendLine(";Password = 'P@ssw0rd'");
                //return oSql.ToString();
            }
            catch (Exception oEx)
            {
                log.Error(oEx.Message);
                throw oEx;
            }
        }

        public static DataTable SP_GEToDbSettingXml()
        {
            XmlReader oXmlFile;
            DataSet oDs = new DataSet();
            DataTable oDbTbl = new DataTable();
            try
            {
                var tPath = "\\AdaDbSetting.xml";
                oXmlFile = XmlReader.Create(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + tPath, new XmlReaderSettings());
                oDs.ReadXml(oXmlFile);
                oDbTbl = oDs.Tables["Setting"];
                oXmlFile.Close();
                return oDbTbl;
            }
            catch (Exception oEx)
            {
                log.Error(oEx.Message);
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
