namespace AdaReport
{
    partial class wLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wLogin));
            this.ocmOk = new System.Windows.Forms.Button();
            this.opbLogin = new System.Windows.Forms.PictureBox();
            this.otbUserPwd = new System.Windows.Forms.TextBox();
            this.otbUserName = new System.Windows.Forms.TextBox();
            this.olaPwd = new System.Windows.Forms.Label();
            this.olaUserName = new System.Windows.Forms.Label();
            this.ocmCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.opbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // ocmOk
            // 
            this.ocmOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ocmOk.Image = ((System.Drawing.Image)(resources.GetObject("ocmOk.Image")));
            this.ocmOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ocmOk.Location = new System.Drawing.Point(105, 104);
            this.ocmOk.Name = "ocmOk";
            this.ocmOk.Size = new System.Drawing.Size(100, 30);
            this.ocmOk.TabIndex = 15;
            this.ocmOk.Tag = "2;ตกลง;Ok";
            this.ocmOk.Text = "Ok";
            this.ocmOk.UseVisualStyleBackColor = true;
            this.ocmOk.Click += new System.EventHandler(this.ocmOk_Click);
            // 
            // opbLogin
            // 
            this.opbLogin.Image = ((System.Drawing.Image)(resources.GetObject("opbLogin.Image")));
            this.opbLogin.Location = new System.Drawing.Point(22, 34);
            this.opbLogin.Name = "opbLogin";
            this.opbLogin.Size = new System.Drawing.Size(65, 64);
            this.opbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opbLogin.TabIndex = 12;
            this.opbLogin.TabStop = false;
            // 
            // otbUserPwd
            // 
            this.otbUserPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbUserPwd.Location = new System.Drawing.Point(192, 64);
            this.otbUserPwd.MaxLength = 20;
            this.otbUserPwd.Name = "otbUserPwd";
            this.otbUserPwd.PasswordChar = '*';
            this.otbUserPwd.Size = new System.Drawing.Size(118, 22);
            this.otbUserPwd.TabIndex = 14;
            // 
            // otbUserName
            // 
            this.otbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbUserName.Location = new System.Drawing.Point(192, 34);
            this.otbUserName.MaxLength = 20;
            this.otbUserName.Name = "otbUserName";
            this.otbUserName.Size = new System.Drawing.Size(118, 22);
            this.otbUserName.TabIndex = 13;
            // 
            // olaPwd
            // 
            this.olaPwd.AutoSize = true;
            this.olaPwd.BackColor = System.Drawing.Color.Transparent;
            this.olaPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaPwd.Location = new System.Drawing.Point(102, 67);
            this.olaPwd.Name = "olaPwd";
            this.olaPwd.Size = new System.Drawing.Size(68, 16);
            this.olaPwd.TabIndex = 18;
            this.olaPwd.Tag = "2;รหัสผ่าน;Password";
            this.olaPwd.Text = "Password";
            // 
            // olaUserName
            // 
            this.olaUserName.AutoSize = true;
            this.olaUserName.BackColor = System.Drawing.Color.Transparent;
            this.olaUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaUserName.Location = new System.Drawing.Point(102, 37);
            this.olaUserName.Name = "olaUserName";
            this.olaUserName.Size = new System.Drawing.Size(74, 16);
            this.olaUserName.TabIndex = 16;
            this.olaUserName.Tag = "2;รหัสผู้ใช้;User Code";
            this.olaUserName.Text = "UserName";
            // 
            // ocmCancel
            // 
            this.ocmCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ocmCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ocmCancel.Image = ((System.Drawing.Image)(resources.GetObject("ocmCancel.Image")));
            this.ocmCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ocmCancel.Location = new System.Drawing.Point(210, 104);
            this.ocmCancel.Name = "ocmCancel";
            this.ocmCancel.Size = new System.Drawing.Size(100, 30);
            this.ocmCancel.TabIndex = 17;
            this.ocmCancel.Tag = "2;ปิด;Close";
            this.ocmCancel.Text = "Close";
            this.ocmCancel.UseVisualStyleBackColor = true;
            this.ocmCancel.Click += new System.EventHandler(this.ocmCancel_Click);
            // 
            // wLogin
            // 
            this.AcceptButton = this.ocmOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ocmCancel;
            this.ClientSize = new System.Drawing.Size(339, 168);
            this.ControlBox = false;
            this.Controls.Add(this.ocmOk);
            this.Controls.Add(this.opbLogin);
            this.Controls.Add(this.otbUserPwd);
            this.Controls.Add(this.otbUserName);
            this.Controls.Add(this.olaPwd);
            this.Controls.Add(this.olaUserName);
            this.Controls.Add(this.ocmCancel);
            this.Name = "wLogin";
            this.Resizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.opbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ocmOk;
        internal System.Windows.Forms.PictureBox opbLogin;
        internal System.Windows.Forms.TextBox otbUserPwd;
        internal System.Windows.Forms.TextBox otbUserName;
        internal System.Windows.Forms.Label olaPwd;
        internal System.Windows.Forms.Label olaUserName;
        internal System.Windows.Forms.Button ocmCancel;
    }
}