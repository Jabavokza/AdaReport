using AdaReport.Class.Models;
using AdaReport.Class.ST_Class;
using AdaReport.Class.X_Class;
using AdaReport.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AdaReport
{
    public partial class wMain : MetroFramework.Forms.MetroForm
    {
        public wMain()
        {
            InitializeComponent();
        }

        private void wMain_Load(object sender, EventArgs e)
        {
            wPlant oPlant = new wPlant();
            oPlant.ShowDialog();
        }

        private void W_GETxSetting()
        {
            DataTable oSetting = new DataTable();
            try
            {
                oSetting = cCNSP.SP_GEToDbConfigXml();
                otbServer.Text = oSetting.Rows[0]["Server"].ToString();
                otbUserName.Text = oSetting.Rows[0]["UserDb"].ToString();
                otbUserPwd.Text = oSetting.Rows[0]["PwdDb"].ToString();
                ocbDbName.Text = oSetting.Rows[0]["DbName"].ToString();
                //   olaServerName.Text = oSetting.Rows[0]["PlantCode"].ToString();

            }
            catch (Exception oEx)
            {

            }
        }

        private void otoLogin_Click(object sender, EventArgs e)
        {
            wLogin oLogin = new wLogin(this);
            oLogin.ShowDialog();
        }
        private void otoPlantDB_Click(object sender, EventArgs e)
        {
            wPlant oPlant = new wPlant();
            oPlant.ShowDialog();
        }
        private void otoRptAll_Click(object sender, EventArgs e)
        {
            otaTebControl.SelectedTab = otaTabReport;
        }

        private void otoExit_Click(object sender, EventArgs e)
        {
            otoExit.Enabled = false;
            otaTebControl.SelectedTab = otaTebMain;
            
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
                var oConDb= cCNSP.SP_SETtConStr(oDbConfig);
                var oSql = new StringBuilder();
                oSql.AppendLine("SELECT [FTEmpCode],[FTEmpPW] FROM [TCNMEmpMtn] WHERE [FTEmpCode]='"+otbUsrName.Text+ "' AND [FTEmpPW]='"+otbUsrPwd.Text+"'");
                var tUserName = cCNSP.SP_GEToDbTbl(oSql.ToString(), oConDb);
                if (tUserName.Rows.Count >0)
                {
                    otaTebControl.SelectedTab = otaTabReport;
                    otoExit.Enabled = true;
                }
                else
                {
                    MessageBox.Show("UserName or Password InValidate");
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmOk_Click //" + oEx.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void ocmSelectPlant_Click(object sender, EventArgs e)
        {
            try
            {
                wPlant oPlant = new wPlant();
                oPlant.ShowDialog();
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmSelectPlant_Click //" + oEx.Message);
            }

        }
    }
}

