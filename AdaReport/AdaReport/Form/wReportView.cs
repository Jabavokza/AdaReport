using AdaReport.Class.Models;
using AdaReport.Class.ST_Class;
using CrystalDecisions.CrystalReports.Engine;
using MetroFramework.Forms;
using System;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace AdaReport.Form
{
    public partial class wReportView : MetroForm
    {
        private string tW_SqlQuery;
        private string tW_StaStickerOnOFF;
        private wMain oW_Main;
        private wProgressDlg oW_ProgressDlg;
        ReportDocument oCryRpt = new ReportDocument();
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
                if (oBackgroundWorker.IsBusy != true)
                {
                    oBackgroundWorker.RunWorkerAsync();
                    oW_ProgressDlg = new wProgressDlg();
                    oW_ProgressDlg.ShowDialog();
                }
                ocrCrystalReportViewer.ReportSource = oCryRpt;
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
                //oDbCon = cCNSP.SP_GEToDbSettingXml();
                //string tServerName = oDbCon.Rows[0]["Server"].ToString();
                //string tDatabaseName = oDbCon.Rows[0]["DbName"].ToString();
                //string tUserID = oDbCon.Rows[0]["UserDb"].ToString();
                //string tPassword = oDbCon.Rows[0]["PwdDb"].ToString();

                //กำหนดพาท
                string tPathApp = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.LastIndexOf('\\')); 
                string tPath = Path.Combine(tPathApp, @"Report\ServiceDoc\", tFileName);
              // oCryRpt.Load(tPath);
               oCryRpt.Load("D:\\Project\\2018\\AdaReport\\AdaReport\\AdaReport\\Reports\\Frm_Svd_170_PermissionDelivery.rpt");
                //oCryRpt.SetDatabaseLogon(tUserID, tPassword, tServerName, tPassword);//ใช้ในกรณีที่Cystall ต่อกับฐานข้อมูลโดยตรง ถ้าในกรณีที่ใช้Dataset ไม่ต้องใช้คำสั่งนี้
                oCryRpt.SetDataSource(oDt);
                oCryRpt.SetParameterValue("Sticker", tPathSticker);
                oCryRpt.SetParameterValue("User", oW_Main.ostUserDT.Text);
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }

        private void oBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {            
            try
            {
                W_GEToReport();
                Thread.Sleep(500);
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wReportView : oBackgroundWorker_DoWork //" + oEx.Message);
            }
        }
        private void oBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            oW_ProgressDlg.Close();
        }
    }
}
