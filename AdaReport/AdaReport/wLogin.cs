using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdaReport
{
    public partial class wLogin :MetroFramework.Forms.MetroForm
    {
        wMain oMain;
        public wLogin(wMain poMain)
        {
            oMain = poMain;
            InitializeComponent();
        }

        private void ocmCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ocmOk_Click(object sender, EventArgs e)
        {
            try
            {
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
                if (otbUserName.Text == Properties.Settings.Default.UserNameLogin && otbUserPwd.Text == Properties.Settings.Default.UserPwdLogin)
                {
                    oMain.otoLogin.Enabled = false;
                    oMain.otoPlantDB.Enabled = true;
                    oMain.otoLang.Enabled = true;
                    oMain.otoRptAll.Enabled = true;
                    oMain.otoSetting.Enabled = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("UserName or Password InValidate");
                }
            }
            catch(Exception oEx)
            {
                MessageBox.Show("wLogin : ocmOk_Click //"+ oEx.Message, "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }
    }
}
