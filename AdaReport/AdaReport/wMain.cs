using AdaReport.Class.Models;
using AdaReport.Class.ST_Class;
using AdaReport.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            W_GETxSetting();
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
                olaServerName.Text = oSetting.Rows[0]["Server"].ToString();
                olaDbName.Text = oSetting.Rows[0]["DbName"].ToString();
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
            Application.Exit();
        }

        private void otoSetting_Click(object sender, EventArgs e)
        {
            otaTebControl.SelectedTab = otaTebSetting;
        }

        private void opbReload_Click(object sender, EventArgs e)
        {
            StringBuilder oSql = new StringBuilder();
            mlDbConfig oDbConfig = new mlDbConfig();
            try
            {
                if (otbServer.Text.Equals(""))
                {
                    otbServer.Focus();
                    return;
                }
                if (otbUserName.Text.Equals(""))
                {
                    otbUserName.Focus();
                    return;
                }
                if (otbUserPwd.Text.Equals(""))
                {
                    otbUserPwd.Focus();
                    return;
                }
                oDbConfig.tML_Server = otbServer.Text;
                oDbConfig.tML_UserName = otbUserName.Text;
                oDbConfig.tML_UserPwd = otbUserPwd.Text;
                var tConfig = cCNSP.SP_SETtConStr(oDbConfig);
                oSql.AppendLine("SELECT NAME");
                oSql.AppendLine("FROM sys.databases");
                var tDbName = cCNSP.SP_GEToDbTbl(oSql.ToString(), tConfig);
                ocbDbName.DataSource = tDbName;
                ocbDbName.DisplayMember = "NAME";
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : opbReload_Click //" + oEx.Message);
            }

        }

        private void ocmSave_Click(object sender, EventArgs e)
        {
            XmlDocument oXmlDoc = new XmlDocument();
            XmlNode oRootNode;
            XmlNode oServer;
            XmlNode oDbName;
            XmlNode oUserDb;
            XmlNode oPwdDb;
            try
            {
                var tSavePath = "AdaDbSetting.xml";
                oRootNode = oXmlDoc.CreateElement("Setting"); //ส่วน root node
                oXmlDoc.AppendChild(oRootNode);

                oServer = oXmlDoc.CreateElement("Server"); // child node
                oServer.InnerText = otbServer.Text; //ข้อมูลใน child node
                oRootNode.AppendChild(oServer);

                oUserDb = oXmlDoc.CreateElement("UserDb"); // child node
                oUserDb.InnerText = otbUserName.Text; //ข้อมูลใน child node
                oRootNode.AppendChild(oUserDb);

                oPwdDb = oXmlDoc.CreateElement("PwdDb"); // child node
                oPwdDb.InnerText = otbUserPwd.Text; //ข้อมูลใน child node
                oRootNode.AppendChild(oPwdDb);

                oDbName = oXmlDoc.CreateElement("DbName"); // child node
                oDbName.InnerText = ocbDbName.Text; //ข้อมูลใน child node
                oRootNode.AppendChild(oDbName);

                oXmlDoc.Save(tSavePath);

                olaServerName.Text = otbServer.Text;
                olaDbName.Text = ocbDbName.Text;

                //Settings.Default.Server= otbServer.Text;
                //Settings.Default.UserDb = otbUserName.Text;
                //Settings.Default.PwdDb = otbUserPwd.Text;
                //Settings.Default.DbName = ocbDbName.Text;
                //Settings.Default.Save();
                //Settings.Default.Reload();
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmSave_Click //" + oEx.Message);
            }
        }

        private void ocmLoadPlant_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder oSql = new StringBuilder();
                oSql.AppendLine("SELECT [FTShdPlantCode] FORM ");
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmLoadPlant_Click //" + oEx.Message);
            }
        }
    }
}
