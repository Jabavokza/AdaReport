using AdaReport.Class.Models;
using AdaReport.Class.X_Class;
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
    public partial class wPlant : MetroFramework.Forms.MetroForm
    {
        public wPlant()
        {
            InitializeComponent();
        }

        private void wPlant_Load(object sender, EventArgs e)
        {
            DataTable oResult = new DataTable();
            try
            {
                cReadFileMdb oReadFileMdb = new cReadFileMdb();
                var tSql = "SELECT * FROM TConfigPlant WHERE FTCfgCode = 'POSSDB_SAP'";
                oResult = oReadFileMdb.C_GEToReadFileMdb(tSql);
                ogdPlant.DataSource = oResult;
                W_SETxPlantDataGrid();

            }
            catch (Exception oEx)
            {
                MessageBox.Show("ocmRead_Click : ocmLoadPlant_Click //" + oEx.Message);
            }

        }

        public void W_SETxPlantDataGrid()
        {
            try
            {
                ogdPlant.Columns[0].HeaderText = "Plant Code";
                ogdPlant.Columns[0].Width = 90;
                ogdPlant.Columns[1].HeaderText = "Plant Name";
                ogdPlant.Columns[1].Width = 90;
                ogdPlant.Columns[2].HeaderText = "Data Base";
                ogdPlant.Columns[2].Width = 100;
                ogdPlant.Columns[3].HeaderText = "Open Store";
                ogdPlant.Columns[3].Width = 90;
                ogdPlant.Columns[4].HeaderText = "Close Store";
                ogdPlant.Columns[4].Width = 90;
                ogdPlant.Columns[5].Visible = false;
                ogdPlant.Columns[6].Visible = false;
                ogdPlant.Columns[7].Visible = false;
                ogdPlant.Columns[8].Visible = false;
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wPlant : W_SETxPlantDataGrid // " + oEx.Message);
            }
        }

        private void ogdPlant_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mlPlant oPlant = new mlPlant();
            try
            {
                oPlant.tML_PlantCode = ogdPlant.CurrentRow.Cells[0].Value.ToString();
                oPlant.tML_DbName = ogdPlant.CurrentRow.Cells[2].Value.ToString();
                oPlant.tML_UserName = ogdPlant.CurrentRow.Cells[4].Value.ToString();
                oPlant.tML_UserPwd = ogdPlant.CurrentRow.Cells[5].Value.ToString();
                oPlant.tML_Server = ogdPlant.CurrentRow.Cells[6].Value.ToString();
                W_SETxSetting(oPlant);
                Close();

            }
            catch (Exception oEx)
            {
                MessageBox.Show("wPlant : ogdPlant_CellDoubleClick // " + oEx.Message);
            }
        }
        private void W_SETxSetting(mlPlant poPlant)
        {
            XmlDocument oXmlDoc = new XmlDocument();
            try
            {
                var tSavePath = "AdaDbSetting.xml";
                var oRootNode = oXmlDoc.CreateElement("Setting"); //ส่วน root node
                oXmlDoc.AppendChild(oRootNode);

                var oServer = oXmlDoc.CreateElement("Server"); // child node
                oServer.InnerText = poPlant.tML_Server; //ข้อมูลใน child node
                oRootNode.AppendChild(oServer);

                var oUserDb = oXmlDoc.CreateElement("UserDb"); // child node
                oUserDb.InnerText = poPlant.tML_UserName; //ข้อมูลใน child node
                oRootNode.AppendChild(oUserDb);

                var oPwdDb = oXmlDoc.CreateElement("PwdDb"); // child node
                oPwdDb.InnerText = poPlant.tML_UserPwd; //ข้อมูลใน child node
                oRootNode.AppendChild(oPwdDb);

                var oDbName = oXmlDoc.CreateElement("DbName"); // child node
                oDbName.InnerText = poPlant.tML_DbName; //ข้อมูลใน child node
                oRootNode.AppendChild(oDbName);

                var oPlantCode = oXmlDoc.CreateElement("PlantCode"); // child node
                oPlantCode.InnerText = poPlant.tML_PlantCode; //ข้อมูลใน child node
                oRootNode.AppendChild(oPlantCode);

                oXmlDoc.Save(tSavePath);



                //Settings.Default.Server= otbServer.Text;
                //Settings.Default.UserDb = otbUserName.Text;
                //Settings.Default.PwdDb = otbUserPwd.Text;
                //Settings.Default.DbName = ocbDbName.Text;
                //Settings.Default.Save();
                //Settings.Default.Reload();
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wPlant : W_SETxSetting //" + oEx.Message);
            }
        }
    }
}
