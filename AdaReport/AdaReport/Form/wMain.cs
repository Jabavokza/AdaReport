using AdaReport.Class.ST_Class;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace AdaReport.Form
{
    public partial class wMain : MetroForm
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(wMain));
        public wMain()
        {
            InitializeComponent();
        }

        private void wMain_Load(object sender, EventArgs e)
        {
            try
            {
                otmOpenPlant.Start();
                olaVersion.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
            catch (Exception oEx)
            {
                log.Error(oEx.Message);
            }
        }

        public void W_GETxStatusBar()
        {
            DataTable oSetting = new DataTable();
            try
            {
                oSetting = cCNSP.SP_GEToDbConfigXml();
                ostServerDT.Text = oSetting.Rows[0]["Server"].ToString();
                ostDbNameDT.Text = oSetting.Rows[0]["DbName"].ToString();
                ostPlantDT.Text = oSetting.Rows[0]["PlantCode"].ToString();
                otbOperationDate.Text = W_GETxOperationDate();
            }
            catch (Exception oEx)
            {
                log.Error(oEx.Message);
            }
        }

        private void otoPlantDB_Click(object sender, EventArgs e)
        {
            wPlant oPlant = new wPlant(this);
            oPlant.ShowDialog();
        }
        private void otoRptAll_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception oEx)
            {
                MessageBox.Show(oEx.Message);
            }

        }
        private void otoLogout_Click(object sender, EventArgs e)
        {
            try
            {
                otoLogout.Enabled = false;
                ostUserDT.Text = "";
                otaTebControl.SelectedTab = otaTebMain;
                otoPlantDB.Visible = true;
                otbUsrName.Clear();
                otbUsrPwd.Clear();
                otoRptPreview.Visible = false;
            }
            catch (Exception oEx)
            {
                log.Error(oEx.Message);
            }
        }
        private void ocmOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (otbUsrName.Text.Equals(""))
                {
                    otbUsrName.Focus();
                    return;
                }
                if (otbUsrPwd.Text.Equals(""))
                {
                    otbUsrPwd.Focus();
                    return;
                }

                var oSql = new StringBuilder();
                oSql.AppendLine("SELECT [FTEmpCode] FROM [TCNMEmpMtn]");
                oSql.AppendLine("WHERE [FTEmpCode]='" + otbUsrName.Text + "' AND [FTEmpPW]='" + otbUsrPwd.Text + "'");
                var oEmpFCode = cCNSP.SP_GEToDbTbl(oSql.ToString());
                if (oEmpFCode.Rows.Count > 0)
                {
                    otaTebControl.SelectedTab = otaTabReport;
                    otoLogout.Enabled = true;
                    ostUserDT.Text = oEmpFCode.Rows[0]["FTEmpCode"].ToString();
                    //  otoRptPreview.Visible = true;
                    otoPlantDB.Visible = false;
                    log.Info(ostUserDT.Text + ": Login Successful");
                }
                else
                {
                    MessageBox.Show("UserName or Password InValidate", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    log.Info("UserName or Password InValidate");
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("ไม่พบข้อมูล[กรุณาเลือกPlantให้ถุกต้อง]", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                log.Error("ไม่พบข้อมูล[กรุณาเลือกPlantให้ถุกต้อง]" + oEx.Message);
            }
        }

        private void ocmCancel_Click(object sender, EventArgs e)
        {
            try
            {
                otbUsrName.Clear();
                otbUsrPwd.Clear();
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmCancel_Click //" + oEx.Message);
            }
        }
        private void otmOpenPlant_Tick(object sender, EventArgs e)
        {
            wPlant oPlant = new wPlant(this);
            oPlant.ShowDialog();
        }
        private void otmDateTime_Tick(object sender, EventArgs e)
        {
            otbDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        //private void olbReportList_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    wReportView oReportView = new wReportView();
        //    oReportView.olaHeader.Text = olbReportList.Text;
        //    oReportView.Show();
        //}

        private void otoExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string W_GETxOperationDate()
        {
            try
            {
                var tSql = "SELECT [FDCdtDate] FROM [TSysChgDateTime]";
                var tOperationDate = cCNSP.SP_GEToDbTbl(tSql);
                return tOperationDate.Rows[0]["FDCdtDate"].ToString();
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }

        private void otoSetting_Click(object sender, EventArgs e)
        {
            otaTebControl.SelectedTab = otaTebSetting;
        }

        private void ocmPreview_Click(object sender, EventArgs e)
        {
            StringBuilder oSql = new StringBuilder();
            string tStaStickerOnOFF;
            try
            {
                DateTime DateNow = Convert.ToDateTime(odtTransDate.Value.ToString());
                oSql.AppendLine("SELECT ");
                oSql.AppendLine("TPSTSalVatHD.FTTmnNum");
                oSql.AppendLine(",TPSTSalVatHD.FTShdTransNo");
                oSql.AppendLine(",GETDATE() AS FDDateNow");
                oSql.AppendLine(",TPSTSalVatHD.FTSpnCode");
                oSql.AppendLine(",RIGHT(TPSTSalVatHD.FTXihDocRun, 6)AS FTXihDocRun");
                oSql.AppendLine(",CONVERT(varchar(10),TPSTSalVatDT.FNSdtSeqNo)AS FNSdtSeqNo");
                oSql.AppendLine(",TPSTSalVatDT.FTSkuAbbNameSndSrvDoc");
                oSql.AppendLine(",TPSTSalVatDT.FTSdtBarCode");
                oSql.AppendLine(",TPSTSalVatDT.FCSdtSalePrice");
                oSql.AppendLine(",TPSTSalVatDT.FTSdtDisChgTxt");
                oSql.AppendLine(",TPSTSalVatDT.FTSkuCode");
                //oSql.AppendLine(",TCNMEmpMtn.FTEmpFName");
                oSql.AppendLine(" FROM ((TCNMTerminalMtn");
                oSql.AppendLine(" INNER JOIN TPSTSalVatHD");
                oSql.AppendLine(" ON(TCNMTerminalMtn.FTEmpCode= TPSTSalVatHD.FTEmpCode)");
                oSql.AppendLine(" AND(TCNMTerminalMtn.FTTmnNum = TPSTSalVatHD.FTTmnNum))");
                oSql.AppendLine(" INNER JOIN TPSTSalVatDT");
                oSql.AppendLine(" ON TCNMTerminalMtn.FTTmnNum = TPSTSalVatDT.FTTmnNum)");
                //oSql.AppendLine(" INNER JOIN TCNMEmpMtn");
                //oSql.AppendLine(" ON TCNMTerminalMtn.FTEmpCode = TCNMEmpMtn.FTEmpCode");
                oSql.AppendLine(" WHERE RIGHT(TPSTSalVatHD.FTTmnNum,5) ='" + otbTmnNum.Text + "'");
                oSql.AppendLine(" AND (TPSTSalVatHD.FTShdTransNo='" + otbTransNo.Text + "') ");
                oSql.AppendLine(" AND (TPSTSalVatHD.FDShdTransDate='" + DateNow.ToString("yyyy-MM-dd", new CultureInfo("en-US")) + "')");
                oSql.AppendLine(" AND (TPSTSalVatHD.FTXihDocNo='" + otbRFCode.Text + "')");

                if (ocbPrintSticker.Checked == true)
                {
                    tStaStickerOnOFF = "True";
                }
                else
                {
                    tStaStickerOnOFF = "False";
                }
                wReportView oReportView = new wReportView(this, oSql.ToString(), tStaStickerOnOFF);
                oReportView.olaHeader.Text = olbReportList.Text;
                oReportView.Show();
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
        private void olbReportList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (olbReportList.SelectedItem.ToString() == "Report - PermissionDelivery")
                {
                    //  olaTmnNum.Visible = true;
                    ////  olaEx.Visible = true;
                    //  otbTmnNum.Visible = true;
                    //  ocmPreview.Visible = true;
                }
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }

    }
}

