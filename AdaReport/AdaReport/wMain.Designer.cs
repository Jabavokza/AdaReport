namespace AdaReport
{
    partial class wMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wMain));
            this.otoMainControl = new System.Windows.Forms.ToolStrip();
            this.otoLogin = new System.Windows.Forms.ToolStripButton();
            this.otoPlantDB = new System.Windows.Forms.ToolStripButton();
            this.otoRptAll = new System.Windows.Forms.ToolStripButton();
            this.otoLang = new System.Windows.Forms.ToolStripButton();
            this.otoSetting = new System.Windows.Forms.ToolStripButton();
            this.otoExit = new System.Windows.Forms.ToolStripButton();
            this.otaTebControl = new System.Windows.Forms.TabControl();
            this.otaTebMain = new System.Windows.Forms.TabPage();
            this.otaTabReport = new System.Windows.Forms.TabPage();
            this.ocmPrint = new System.Windows.Forms.Button();
            this.ocmPreview = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.otaTebSetting = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.olaDbName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.olaServerName = new System.Windows.Forms.Label();
            this.olalbel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ocmLoadPlant = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ocbDbName = new System.Windows.Forms.ComboBox();
            this.opbReload = new System.Windows.Forms.PictureBox();
            this.olaDbNm = new System.Windows.Forms.Label();
            this.otbServer = new System.Windows.Forms.TextBox();
            this.olaServer = new System.Windows.Forms.Label();
            this.olaPassword = new System.Windows.Forms.Label();
            this.ocmSave = new System.Windows.Forms.Button();
            this.otbUserPwd = new System.Windows.Forms.TextBox();
            this.otbUserName = new System.Windows.Forms.TextBox();
            this.olaUserName = new System.Windows.Forms.Label();
            this.otoMainControl.SuspendLayout();
            this.otaTebControl.SuspendLayout();
            this.otaTabReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.otaTebSetting.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opbReload)).BeginInit();
            this.SuspendLayout();
            // 
            // otoMainControl
            // 
            this.otoMainControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otoLogin,
            this.otoPlantDB,
            this.otoRptAll,
            this.otoLang,
            this.otoSetting,
            this.otoExit});
            this.otoMainControl.Location = new System.Drawing.Point(20, 60);
            this.otoMainControl.Name = "otoMainControl";
            this.otoMainControl.Size = new System.Drawing.Size(860, 68);
            this.otoMainControl.TabIndex = 0;
            // 
            // otoLogin
            // 
            this.otoLogin.AutoSize = false;
            this.otoLogin.AutoToolTip = false;
            this.otoLogin.Image = ((System.Drawing.Image)(resources.GetObject("otoLogin.Image")));
            this.otoLogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.otoLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otoLogin.Name = "otoLogin";
            this.otoLogin.Size = new System.Drawing.Size(55, 65);
            this.otoLogin.Text = "Login";
            this.otoLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.otoLogin.Click += new System.EventHandler(this.otoLogin_Click);
            // 
            // otoPlantDB
            // 
            this.otoPlantDB.AutoSize = false;
            this.otoPlantDB.AutoToolTip = false;
            this.otoPlantDB.Enabled = false;
            this.otoPlantDB.Image = ((System.Drawing.Image)(resources.GetObject("otoPlantDB.Image")));
            this.otoPlantDB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.otoPlantDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otoPlantDB.Name = "otoPlantDB";
            this.otoPlantDB.Size = new System.Drawing.Size(55, 65);
            this.otoPlantDB.Text = "PlantDB";
            this.otoPlantDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.otoPlantDB.Click += new System.EventHandler(this.otoPlantDB_Click);
            // 
            // otoRptAll
            // 
            this.otoRptAll.AutoSize = false;
            this.otoRptAll.AutoToolTip = false;
            this.otoRptAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.otoRptAll.Enabled = false;
            this.otoRptAll.Image = ((System.Drawing.Image)(resources.GetObject("otoRptAll.Image")));
            this.otoRptAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.otoRptAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otoRptAll.Name = "otoRptAll";
            this.otoRptAll.Size = new System.Drawing.Size(55, 65);
            this.otoRptAll.Text = "Report";
            this.otoRptAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.otoRptAll.Click += new System.EventHandler(this.otoRptAll_Click);
            // 
            // otoLang
            // 
            this.otoLang.AutoSize = false;
            this.otoLang.AutoToolTip = false;
            this.otoLang.Enabled = false;
            this.otoLang.Image = ((System.Drawing.Image)(resources.GetObject("otoLang.Image")));
            this.otoLang.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.otoLang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otoLang.Name = "otoLang";
            this.otoLang.Size = new System.Drawing.Size(55, 65);
            this.otoLang.Text = "Language";
            this.otoLang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // otoSetting
            // 
            this.otoSetting.AutoSize = false;
            this.otoSetting.Enabled = false;
            this.otoSetting.Image = ((System.Drawing.Image)(resources.GetObject("otoSetting.Image")));
            this.otoSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.otoSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otoSetting.Name = "otoSetting";
            this.otoSetting.Size = new System.Drawing.Size(55, 65);
            this.otoSetting.Text = "Setting";
            this.otoSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.otoSetting.Click += new System.EventHandler(this.otoSetting_Click);
            // 
            // otoExit
            // 
            this.otoExit.AutoSize = false;
            this.otoExit.AutoToolTip = false;
            this.otoExit.Image = ((System.Drawing.Image)(resources.GetObject("otoExit.Image")));
            this.otoExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.otoExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otoExit.Name = "otoExit";
            this.otoExit.Size = new System.Drawing.Size(55, 65);
            this.otoExit.Text = "Exit";
            this.otoExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.otoExit.Click += new System.EventHandler(this.otoExit_Click);
            // 
            // otaTebControl
            // 
            this.otaTebControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.otaTebControl.Controls.Add(this.otaTebMain);
            this.otaTebControl.Controls.Add(this.otaTabReport);
            this.otaTebControl.Controls.Add(this.otaTebSetting);
            this.otaTebControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otaTebControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.otaTebControl.ItemSize = new System.Drawing.Size(20, 2);
            this.otaTebControl.Location = new System.Drawing.Point(20, 128);
            this.otaTebControl.Name = "otaTebControl";
            this.otaTebControl.SelectedIndex = 0;
            this.otaTebControl.Size = new System.Drawing.Size(860, 452);
            this.otaTebControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.otaTebControl.TabIndex = 1;
            // 
            // otaTebMain
            // 
            this.otaTebMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("otaTebMain.BackgroundImage")));
            this.otaTebMain.Location = new System.Drawing.Point(4, 6);
            this.otaTebMain.Name = "otaTebMain";
            this.otaTebMain.Padding = new System.Windows.Forms.Padding(3);
            this.otaTebMain.Size = new System.Drawing.Size(852, 442);
            this.otaTebMain.TabIndex = 0;
            this.otaTebMain.UseVisualStyleBackColor = true;
            // 
            // otaTabReport
            // 
            this.otaTabReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("otaTabReport.BackgroundImage")));
            this.otaTabReport.Controls.Add(this.ocmPrint);
            this.otaTabReport.Controls.Add(this.ocmPreview);
            this.otaTabReport.Controls.Add(this.groupBox2);
            this.otaTabReport.Controls.Add(this.dataGridView1);
            this.otaTabReport.Location = new System.Drawing.Point(4, 6);
            this.otaTabReport.Name = "otaTabReport";
            this.otaTabReport.Padding = new System.Windows.Forms.Padding(3);
            this.otaTabReport.Size = new System.Drawing.Size(852, 442);
            this.otaTabReport.TabIndex = 1;
            this.otaTabReport.UseVisualStyleBackColor = true;
            // 
            // ocmPrint
            // 
            this.ocmPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ocmPrint.Image = ((System.Drawing.Image)(resources.GetObject("ocmPrint.Image")));
            this.ocmPrint.Location = new System.Drawing.Point(407, 103);
            this.ocmPrint.Name = "ocmPrint";
            this.ocmPrint.Size = new System.Drawing.Size(67, 61);
            this.ocmPrint.TabIndex = 9;
            this.ocmPrint.Text = "Print";
            this.ocmPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ocmPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ocmPrint.UseVisualStyleBackColor = true;
            // 
            // ocmPreview
            // 
            this.ocmPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ocmPreview.Image = ((System.Drawing.Image)(resources.GetObject("ocmPreview.Image")));
            this.ocmPreview.Location = new System.Drawing.Point(407, 20);
            this.ocmPreview.Name = "ocmPreview";
            this.ocmPreview.Size = new System.Drawing.Size(67, 61);
            this.ocmPreview.TabIndex = 8;
            this.ocmPreview.Text = "Preview";
            this.ocmPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ocmPreview.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(23, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 223);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(521, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(309, 407);
            this.dataGridView1.TabIndex = 6;
            // 
            // otaTebSetting
            // 
            this.otaTebSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("otaTebSetting.BackgroundImage")));
            this.otaTebSetting.Controls.Add(this.groupBox4);
            this.otaTebSetting.Controls.Add(this.groupBox3);
            this.otaTebSetting.Controls.Add(this.groupBox1);
            this.otaTebSetting.Location = new System.Drawing.Point(4, 6);
            this.otaTebSetting.Name = "otaTebSetting";
            this.otaTebSetting.Size = new System.Drawing.Size(852, 442);
            this.otaTebSetting.TabIndex = 2;
            this.otaTebSetting.Text = "Setting";
            this.otaTebSetting.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.olaDbName);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.olaServerName);
            this.groupBox4.Controls.Add(this.olalbel);
            this.groupBox4.Location = new System.Drawing.Point(456, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 61);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
            // olaDbName
            // 
            this.olaDbName.AutoSize = true;
            this.olaDbName.Location = new System.Drawing.Point(72, 35);
            this.olaDbName.Name = "olaDbName";
            this.olaDbName.Size = new System.Drawing.Size(22, 13);
            this.olaDbName.TabIndex = 3;
            this.olaDbName.Text = "xxx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Base :";
            // 
            // olaServerName
            // 
            this.olaServerName.AutoSize = true;
            this.olaServerName.Location = new System.Drawing.Point(47, 16);
            this.olaServerName.Name = "olaServerName";
            this.olaServerName.Size = new System.Drawing.Size(22, 13);
            this.olaServerName.TabIndex = 1;
            this.olaServerName.Text = "xxx";
            // 
            // olalbel
            // 
            this.olalbel.AutoSize = true;
            this.olalbel.Location = new System.Drawing.Point(6, 16);
            this.olalbel.Name = "olalbel";
            this.olalbel.Size = new System.Drawing.Size(44, 13);
            this.olalbel.TabIndex = 0;
            this.olalbel.Text = "Server :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ocmLoadPlant);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(456, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 333);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SelectPlant";
            // 
            // ocmLoadPlant
            // 
            this.ocmLoadPlant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ocmLoadPlant.Image = ((System.Drawing.Image)(resources.GetObject("ocmLoadPlant.Image")));
            this.ocmLoadPlant.Location = new System.Drawing.Point(234, 279);
            this.ocmLoadPlant.Name = "ocmLoadPlant";
            this.ocmLoadPlant.Size = new System.Drawing.Size(89, 43);
            this.ocmLoadPlant.TabIndex = 9;
            this.ocmLoadPlant.Text = "Load";
            this.ocmLoadPlant.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ocmLoadPlant.UseVisualStyleBackColor = true;
            this.ocmLoadPlant.Click += new System.EventHandler(this.ocmLoadPlant_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(317, 252);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ocbDbName);
            this.groupBox1.Controls.Add(this.opbReload);
            this.groupBox1.Controls.Add(this.olaDbNm);
            this.groupBox1.Controls.Add(this.otbServer);
            this.groupBox1.Controls.Add(this.olaServer);
            this.groupBox1.Controls.Add(this.olaPassword);
            this.groupBox1.Controls.Add(this.ocmSave);
            this.groupBox1.Controls.Add(this.otbUserPwd);
            this.groupBox1.Controls.Add(this.otbUserName);
            this.groupBox1.Controls.Add(this.olaUserName);
            this.groupBox1.Location = new System.Drawing.Point(68, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 365);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SettingDatabase";
            // 
            // ocbDbName
            // 
            this.ocbDbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ocbDbName.FormattingEnabled = true;
            this.ocbDbName.Location = new System.Drawing.Point(103, 144);
            this.ocbDbName.Name = "ocbDbName";
            this.ocbDbName.Size = new System.Drawing.Size(173, 24);
            this.ocbDbName.TabIndex = 10;
            // 
            // opbReload
            // 
            this.opbReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.opbReload.Image = ((System.Drawing.Image)(resources.GetObject("opbReload.Image")));
            this.opbReload.Location = new System.Drawing.Point(282, 140);
            this.opbReload.Name = "opbReload";
            this.opbReload.Size = new System.Drawing.Size(32, 32);
            this.opbReload.TabIndex = 9;
            this.opbReload.TabStop = false;
            this.opbReload.Click += new System.EventHandler(this.opbReload_Click);
            // 
            // olaDbNm
            // 
            this.olaDbNm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaDbNm.Location = new System.Drawing.Point(20, 145);
            this.olaDbNm.Name = "olaDbNm";
            this.olaDbNm.Size = new System.Drawing.Size(77, 23);
            this.olaDbNm.TabIndex = 8;
            this.olaDbNm.Text = "DataBase";
            this.olaDbNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // otbServer
            // 
            this.otbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbServer.Location = new System.Drawing.Point(103, 33);
            this.otbServer.Name = "otbServer";
            this.otbServer.Size = new System.Drawing.Size(173, 22);
            this.otbServer.TabIndex = 0;
            // 
            // olaServer
            // 
            this.olaServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaServer.Location = new System.Drawing.Point(20, 33);
            this.olaServer.Name = "olaServer";
            this.olaServer.Size = new System.Drawing.Size(77, 23);
            this.olaServer.TabIndex = 1;
            this.olaServer.Text = "Server";
            this.olaServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // olaPassword
            // 
            this.olaPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaPassword.Location = new System.Drawing.Point(20, 107);
            this.olaPassword.Name = "olaPassword";
            this.olaPassword.Size = new System.Drawing.Size(77, 23);
            this.olaPassword.TabIndex = 6;
            this.olaPassword.Text = "Password";
            this.olaPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ocmSave
            // 
            this.ocmSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ocmSave.Image = ((System.Drawing.Image)(resources.GetObject("ocmSave.Image")));
            this.ocmSave.Location = new System.Drawing.Point(189, 188);
            this.ocmSave.Name = "ocmSave";
            this.ocmSave.Size = new System.Drawing.Size(89, 43);
            this.ocmSave.TabIndex = 2;
            this.ocmSave.Text = "Save";
            this.ocmSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ocmSave.UseVisualStyleBackColor = true;
            this.ocmSave.Click += new System.EventHandler(this.ocmSave_Click);
            // 
            // otbUserPwd
            // 
            this.otbUserPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbUserPwd.Location = new System.Drawing.Point(103, 107);
            this.otbUserPwd.Name = "otbUserPwd";
            this.otbUserPwd.Size = new System.Drawing.Size(173, 22);
            this.otbUserPwd.TabIndex = 5;
            // 
            // otbUserName
            // 
            this.otbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbUserName.Location = new System.Drawing.Point(103, 70);
            this.otbUserName.Name = "otbUserName";
            this.otbUserName.Size = new System.Drawing.Size(173, 22);
            this.otbUserName.TabIndex = 3;
            // 
            // olaUserName
            // 
            this.olaUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaUserName.Location = new System.Drawing.Point(20, 70);
            this.olaUserName.Name = "olaUserName";
            this.olaUserName.Size = new System.Drawing.Size(77, 23);
            this.olaUserName.TabIndex = 4;
            this.olaUserName.Text = "UserName";
            this.olaUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.otaTebControl);
            this.Controls.Add(this.otoMainControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "wMain";
            this.Text = "AdaReport";
            this.Load += new System.EventHandler(this.wMain_Load);
            this.otoMainControl.ResumeLayout(false);
            this.otoMainControl.PerformLayout();
            this.otaTebControl.ResumeLayout(false);
            this.otaTabReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.otaTebSetting.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opbReload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip otoMainControl;
        private System.Windows.Forms.ToolStripButton otoExit;
        public System.Windows.Forms.ToolStripButton otoRptAll;
        public System.Windows.Forms.ToolStripButton otoLang;
        public System.Windows.Forms.ToolStripButton otoLogin;
        public System.Windows.Forms.ToolStripButton otoPlantDB;
        private System.Windows.Forms.TabControl otaTebControl;
        private System.Windows.Forms.TabPage otaTebMain;
        private System.Windows.Forms.TabPage otaTabReport;
        private System.Windows.Forms.Button ocmPrint;
        private System.Windows.Forms.Button ocmPreview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ToolStripButton otoSetting;
        private System.Windows.Forms.TabPage otaTebSetting;
        private System.Windows.Forms.Button ocmSave;
        private System.Windows.Forms.Label olaServer;
        private System.Windows.Forms.TextBox otbServer;
        private System.Windows.Forms.Label olaPassword;
        private System.Windows.Forms.TextBox otbUserPwd;
        private System.Windows.Forms.Label olaUserName;
        private System.Windows.Forms.TextBox otbUserName;
        private System.Windows.Forms.Label olaDbNm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ocmLoadPlant;
        private System.Windows.Forms.PictureBox opbReload;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label olaDbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label olaServerName;
        private System.Windows.Forms.Label olalbel;
        private System.Windows.Forms.ComboBox ocbDbName;
    }
}

