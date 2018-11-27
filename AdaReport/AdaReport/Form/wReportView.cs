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
            ReportDocument oCryRpt = new ReportDocument();
            try
            {
                var oDt = cCNSP.SP_GEToDbTbl(tW_SqlQuery);
                oDbCon = cCNSP.SP_GEToDbConfigXml(); 
                var tServerName = oDbCon.Rows[0]["Server"].ToString();
                var tDatabaseName = oDbCon.Rows[0]["DbName"].ToString();
                var tUserID = oDbCon.Rows[0]["UserDb"].ToString();
                var tPassword = oDbCon.Rows[0]["PwdDb"].ToString();

                var tFileName = "CrystalReport.rpt";
                var tPathApp = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.LastIndexOf('\\'));
                var tPath = Path.Combine(tPathApp, @"Report\ServiceDoc\", tFileName);
                // oCryRpt.Load(tPath);
               // oCryRpt.Load("D:\\Project\\2018\\AdaReport\\AdaReport\\AdaReport\\CrystalReport.rpt");
                oCryRpt.Load("H:\\GitHub\\AdaReport\\AdaReport\\AdaReport\\CrystalReport.rpt");
                
                oCryRpt.DataSourceConnections.Clear();
                oCryRpt.SetDatabaseLogon(tUserID, tPassword, tServerName, tDatabaseName);
                oCryRpt.SetDataSource(oDt);
                oCryRpt.VerifyDatabase();
                ocrCrystalReportViewer.ReportSource = null; 
                ocrCrystalReportViewer.ReportSource = oCryRpt;

                ocrCrystalReportViewer.RefreshReport();
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
    }
}
