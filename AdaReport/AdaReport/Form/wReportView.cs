using AdaReport.Class.ST_Class;
using CrystalDecisions.CrystalReports.Engine;
using MetroFramework.Forms;
using System;
using System.Data;
using System.IO;

namespace AdaReport.Form
{
    public partial class wReportView : MetroForm
    {
        private string tW_SqlQuery;
        private string tW_StaStickerOnOFF;
        private wMain oW_Main;
        public wReportView(wMain poMain, string ptSqlQuery, string ptStaStickerOnOFF)
        {
            tW_SqlQuery = ptSqlQuery;
            tW_StaStickerOnOFF = ptStaStickerOnOFF;
            oW_Main = poMain;
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
            DataTable oDt = new DataTable();
            ReportDocument oCryRpt = new ReportDocument();
            string tPathSticker = "";
            string tFileName = "Frm_Svd_170_PermissionDelivery.rpt";
            try
            {
                if (tW_SqlQuery != "")
                {
                    oDt = cCNSP.SP_GEToDbTbl(tW_SqlQuery);
                }
                else
                {
                    oDt = null;
                }
                if (tW_StaStickerOnOFF == "True")
                {
                    tPathSticker = "\\Sticker\\Power-mall.png";
                    tPathSticker = Environment.CurrentDirectory + tPathSticker;
                }
                oDbCon = cCNSP.SP_GEToDbConfigXml();
                string tServerName = oDbCon.Rows[0]["Server"].ToString();
                string tDatabaseName = oDbCon.Rows[0]["DbName"].ToString();
                string tUserID = oDbCon.Rows[0]["UserDb"].ToString();
                string tPassword = oDbCon.Rows[0]["PwdDb"].ToString();

                string tPathApp = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.LastIndexOf('\\'));
                string tPath = Path.Combine(tPathApp, @"Report\ServiceDoc\", tFileName);
                oCryRpt.Load(tPath);
                //oCryRpt.Load("D:\\Project\\2018\\AdaReport\\AdaReport\\AdaReport\\Frm_Svd_170_PermissionDelivery.rpt");
                //oCryRpt.Load("H:\\GitHub\\AdaReport\\AdaReport\\AdaReport\\Frm_Svd_170_PermissionDelivery.rpt");
                oCryRpt.SetDatabaseLogon(tUserID, tPassword, tServerName, tDatabaseName);
                oCryRpt.SetDataSource(oDt);
                oCryRpt.SetParameterValue("Sticker", tPathSticker);
                oCryRpt.SetParameterValue("User", oW_Main.ostUserDT.Text);
                ocrCrystalReportViewer.ReportSource = oCryRpt;
                // ocrCrystalReportViewer.RefreshReport();
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
    }
}
