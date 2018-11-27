using AdaReport.Class.ST_Class;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdaReport.Form
{
    public partial class wReportView : MetroForm
    {
        private string tW_SqlQuery;
        public wReportView(string ptSqlQuery)
        {
            tW_SqlQuery = ptSqlQuery;
            InitializeComponent();
        }
        public wReportView()
        {
            InitializeComponent();
        }

        private void wReportView_Load(object sender, EventArgs e)
        {
            try
            {
                W_GEToReport();

            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
        private void W_GEToReport()
        {
            DataTable oDbCon = new DataTable();
            try
            {
                oDbCon = cCNSP.SP_GEToDbConfigXml();
                ReportDocument oCryRpt = new ReportDocument();
                TableLogOnInfos oCrtableLogoninfos = new TableLogOnInfos();
                TableLogOnInfo oCrtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo oCrConnectionInfo = new ConnectionInfo();
                Tables oCrTables;
                var tFileName = "CrystalReport.rpt";
                var tPathApp = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.LastIndexOf('\\'));
                var tPath = Path.Combine(tPathApp, @"Report\ServiceDoc\", tFileName);
                // oCryRpt.Load(tPath);
                oCryRpt.Load("D:\\Project\\2018\\AdaReport\\AdaReport\\AdaReport\\CrystalReport.rpt");
                oCrConnectionInfo.ServerName = oDbCon.Rows[0]["Server"].ToString();
                oCrConnectionInfo.DatabaseName = oDbCon.Rows[0]["DbName"].ToString();
                oCrConnectionInfo.UserID = oDbCon.Rows[0]["UserDb"].ToString();
                oCrConnectionInfo.Password = oDbCon.Rows[0]["PwdDb"].ToString();

                oCrTables = oCryRpt.Database.Tables;
                foreach (Table CrTable in oCrTables)
                {
                    oCrtableLogoninfo = CrTable.LogOnInfo;
                    oCrtableLogoninfo.ConnectionInfo = oCrConnectionInfo;
                    CrTable.ApplyLogOnInfo(oCrtableLogoninfo);
                }
                var oDt = cCNSP.SP_GEToDbTbl(tW_SqlQuery);
                oCryRpt.SetDataSource(oDt);      
                ocrCrystalReportViewer.ReportSource = null;
                ocrCrystalReportViewer.ReportSource = oCryRpt;
                ocrCrystalReportViewer.Refresh();
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
    }
}
