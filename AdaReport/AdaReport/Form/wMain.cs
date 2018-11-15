using AdaReport.Class.Models;
using AdaReport.Class.ST_Class;
using MetroFramework.Forms;
using System;
using System.Data;
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
                ostDbNameDT.Text = oSetting.Rows[0]["DbName"].ToString();
                ostPlantDT.Text = oSetting.Rows[0]["PlantCode"].ToString();

            }
            catch (Exception oEx)
            {
                log.Error(oEx.Message);
            }
        }

        private void otoLogin_Click(object sender, EventArgs e)
        {
            //wLogin oLogin = new wLogin(this);
            //oLogin.ShowDialog();
        }
        private void otoPlantDB_Click(object sender, EventArgs e)
        {
            wPlant oPlant = new wPlant(this);
            oPlant.ShowDialog();
        }
        private void otoRptAll_Click(object sender, EventArgs e)
        {
            otaTebControl.SelectedTab = otaTabReport;
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
                var oDbConfig = new mlDbConfig();
                var oXmlDb = cCNSP.SP_GEToDbConfigXml();
                oDbConfig.tML_Server = oXmlDb.Rows[0]["Server"].ToString();
                oDbConfig.tML_DbName = oXmlDb.Rows[0]["DbName"].ToString();
                oDbConfig.tML_UserName = oXmlDb.Rows[0]["UserDb"].ToString();
                oDbConfig.tML_UserPwd = oXmlDb.Rows[0]["PwdDb"].ToString();
                var oConDb = cCNSP.SP_SETtConStr(oDbConfig);

                var oSql = new StringBuilder();
                oSql.AppendLine("SELECT [FTEmpCode] FROM [TCNMEmpMtn] WHERE [FTEmpCode]='" + otbUsrName.Text + "' AND [FTEmpPW]='" + otbUsrPwd.Text + "'");
                var oEmpFCode = cCNSP.SP_GEToDbTbl(oSql.ToString(), oConDb);
                if (oEmpFCode.Rows.Count > 0)
                {
                    otaTebControl.SelectedTab = otaTabReport;
                    otoLogout.Enabled = true;
                    ostUserDT.Text = oEmpFCode.Rows[0]["FTEmpCode"].ToString();
                    otoRptPreview.Visible = true;
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
            olaDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}

