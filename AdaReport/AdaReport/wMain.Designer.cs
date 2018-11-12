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
            this.otaTabReport = new System.Windows.Forms.TabPage();
            this.ocmPrint = new System.Windows.Forms.Button();
            this.ocmPreview = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.otaTebMain = new System.Windows.Forms.TabPage();
            this.ogbDateTime = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.olaTimeDT = new System.Windows.Forms.Label();
            this.olaDateDT = new System.Windows.Forms.Label();
            this.olaTimeHD = new System.Windows.Forms.Label();
            this.olaDateHD = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.olaOprDate = new System.Windows.Forms.Label();
            this.olaOperationDate = new System.Windows.Forms.Label();
            this.ogbStatus = new System.Windows.Forms.GroupBox();
            this.ocmSelectPlant = new System.Windows.Forms.Button();
            this.olaSaleExp = new System.Windows.Forms.Label();
            this.olaClsStore = new System.Windows.Forms.Label();
            this.olaOpnStore = new System.Windows.Forms.Label();
            this.olaTbUp = new System.Windows.Forms.Label();
            this.olaDailyProcessStatus = new System.Windows.Forms.Label();
            this.ogbLogin = new System.Windows.Forms.GroupBox();
            this.opbLogin = new System.Windows.Forms.PictureBox();
            this.ocmOk = new System.Windows.Forms.Button();
            this.ocmCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.otbUsrPwd = new System.Windows.Forms.TextBox();
            this.olaPwd = new System.Windows.Forms.Label();
            this.otbUsrName = new System.Windows.Forms.TextBox();
            this.otaTebControl = new System.Windows.Forms.TabControl();
            this.otoMainControl.SuspendLayout();
            this.otaTebSetting.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opbReload)).BeginInit();
            this.otaTabReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.otaTebMain.SuspendLayout();
            this.ogbDateTime.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.ogbStatus.SuspendLayout();
            this.ogbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opbLogin)).BeginInit();
            this.otaTebControl.SuspendLayout();
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
            this.otoLogin.Visible = false;
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
            this.otoPlantDB.Visible = false;
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
            this.otoSetting.Visible = false;
            // 
            // otoExit
            // 
            this.otoExit.AutoSize = false;
            this.otoExit.AutoToolTip = false;
            this.otoExit.Enabled = false;
            this.otoExit.Image = ((System.Drawing.Image)(resources.GetObject("otoExit.Image")));
            this.otoExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.otoExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otoExit.Name = "otoExit";
            this.otoExit.Size = new System.Drawing.Size(55, 65);
            this.otoExit.Text = "Exit";
            this.otoExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.otoExit.Click += new System.EventHandler(this.otoExit_Click);
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
            // otaTebMain
            // 
            this.otaTebMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("otaTebMain.BackgroundImage")));
            this.otaTebMain.Controls.Add(this.ogbDateTime);
            this.otaTebMain.Controls.Add(this.ogbStatus);
            this.otaTebMain.Controls.Add(this.ogbLogin);
            this.otaTebMain.Location = new System.Drawing.Point(4, 6);
            this.otaTebMain.Name = "otaTebMain";
            this.otaTebMain.Padding = new System.Windows.Forms.Padding(3);
            this.otaTebMain.Size = new System.Drawing.Size(852, 442);
            this.otaTebMain.TabIndex = 0;
            this.otaTebMain.UseVisualStyleBackColor = true;
            // 
            // ogbDateTime
            // 
            this.ogbDateTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ogbDateTime.BackgroundImage")));
            this.ogbDateTime.Controls.Add(this.groupBox6);
            this.ogbDateTime.Controls.Add(this.groupBox5);
            this.ogbDateTime.Location = new System.Drawing.Point(130, 301);
            this.ogbDateTime.Name = "ogbDateTime";
            this.ogbDateTime.Size = new System.Drawing.Size(597, 76);
            this.ogbDateTime.TabIndex = 28;
            this.ogbDateTime.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.olaTimeDT);
            this.groupBox6.Controls.Add(this.olaDateDT);
            this.groupBox6.Controls.Add(this.olaTimeHD);
            this.groupBox6.Controls.Add(this.olaDateHD);
            this.groupBox6.Location = new System.Drawing.Point(397, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(180, 55);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // olaTimeDT
            // 
            this.olaTimeDT.AutoSize = true;
            this.olaTimeDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaTimeDT.Location = new System.Drawing.Point(64, 34);
            this.olaTimeDT.Name = "olaTimeDT";
            this.olaTimeDT.Size = new System.Drawing.Size(49, 13);
            this.olaTimeDT.TabIndex = 4;
            this.olaTimeDT.Text = "17:30:33";
            // 
            // olaDateDT
            // 
            this.olaDateDT.AutoSize = true;
            this.olaDateDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaDateDT.Location = new System.Drawing.Point(64, 14);
            this.olaDateDT.Name = "olaDateDT";
            this.olaDateDT.Size = new System.Drawing.Size(65, 13);
            this.olaDateDT.TabIndex = 3;
            this.olaDateDT.Text = "12/11/2018";
            // 
            // olaTimeHD
            // 
            this.olaTimeHD.AutoSize = true;
            this.olaTimeHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaTimeHD.Location = new System.Drawing.Point(6, 34);
            this.olaTimeHD.Name = "olaTimeHD";
            this.olaTimeHD.Size = new System.Drawing.Size(51, 16);
            this.olaTimeHD.TabIndex = 2;
            this.olaTimeHD.Text = "Time :";
            // 
            // olaDateHD
            // 
            this.olaDateHD.AutoSize = true;
            this.olaDateHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaDateHD.Location = new System.Drawing.Point(6, 14);
            this.olaDateHD.Name = "olaDateHD";
            this.olaDateHD.Size = new System.Drawing.Size(49, 16);
            this.olaDateHD.TabIndex = 1;
            this.olaDateHD.Text = "Date :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.olaOprDate);
            this.groupBox5.Controls.Add(this.olaOperationDate);
            this.groupBox5.Location = new System.Drawing.Point(19, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(180, 55);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // olaOprDate
            // 
            this.olaOprDate.AutoSize = true;
            this.olaOprDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaOprDate.Location = new System.Drawing.Point(48, 36);
            this.olaOprDate.Name = "olaOprDate";
            this.olaOprDate.Size = new System.Drawing.Size(65, 13);
            this.olaOprDate.TabIndex = 1;
            this.olaOprDate.Text = "12/11/2018";
            // 
            // olaOperationDate
            // 
            this.olaOperationDate.AutoSize = true;
            this.olaOperationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaOperationDate.Location = new System.Drawing.Point(29, 13);
            this.olaOperationDate.Name = "olaOperationDate";
            this.olaOperationDate.Size = new System.Drawing.Size(113, 16);
            this.olaOperationDate.TabIndex = 0;
            this.olaOperationDate.Text = "Operation Date";
            // 
            // ogbStatus
            // 
            this.ogbStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ogbStatus.BackgroundImage")));
            this.ogbStatus.Controls.Add(this.ocmSelectPlant);
            this.ogbStatus.Controls.Add(this.olaSaleExp);
            this.ogbStatus.Controls.Add(this.olaClsStore);
            this.ogbStatus.Controls.Add(this.olaOpnStore);
            this.ogbStatus.Controls.Add(this.olaTbUp);
            this.ogbStatus.Controls.Add(this.olaDailyProcessStatus);
            this.ogbStatus.Location = new System.Drawing.Point(130, 86);
            this.ogbStatus.Name = "ogbStatus";
            this.ogbStatus.Size = new System.Drawing.Size(268, 215);
            this.ogbStatus.TabIndex = 27;
            this.ogbStatus.TabStop = false;
            // 
            // ocmSelectPlant
            // 
            this.ocmSelectPlant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ocmSelectPlant.Location = new System.Drawing.Point(92, 165);
            this.ocmSelectPlant.Name = "ocmSelectPlant";
            this.ocmSelectPlant.Size = new System.Drawing.Size(100, 30);
            this.ocmSelectPlant.TabIndex = 5;
            this.ocmSelectPlant.Text = "Select Plant";
            this.ocmSelectPlant.UseVisualStyleBackColor = true;
            this.ocmSelectPlant.Click += new System.EventHandler(this.ocmSelectPlant_Click);
            // 
            // olaSaleExp
            // 
            this.olaSaleExp.AutoSize = true;
            this.olaSaleExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaSaleExp.Location = new System.Drawing.Point(124, 132);
            this.olaSaleExp.Name = "olaSaleExp";
            this.olaSaleExp.Size = new System.Drawing.Size(87, 15);
            this.olaSaleExp.TabIndex = 4;
            this.olaSaleExp.Text = "Sale Exporting";
            // 
            // olaClsStore
            // 
            this.olaClsStore.AutoSize = true;
            this.olaClsStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaClsStore.Location = new System.Drawing.Point(124, 109);
            this.olaClsStore.Name = "olaClsStore";
            this.olaClsStore.Size = new System.Drawing.Size(70, 15);
            this.olaClsStore.TabIndex = 3;
            this.olaClsStore.Text = "Close Store";
            // 
            // olaOpnStore
            // 
            this.olaOpnStore.AutoSize = true;
            this.olaOpnStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaOpnStore.Location = new System.Drawing.Point(124, 87);
            this.olaOpnStore.Name = "olaOpnStore";
            this.olaOpnStore.Size = new System.Drawing.Size(69, 15);
            this.olaOpnStore.TabIndex = 2;
            this.olaOpnStore.Text = "Open Store";
            // 
            // olaTbUp
            // 
            this.olaTbUp.AutoSize = true;
            this.olaTbUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaTbUp.Location = new System.Drawing.Point(123, 65);
            this.olaTbUp.Name = "olaTbUp";
            this.olaTbUp.Size = new System.Drawing.Size(81, 15);
            this.olaTbUp.TabIndex = 1;
            this.olaTbUp.Text = "Table Update";
            // 
            // olaDailyProcessStatus
            // 
            this.olaDailyProcessStatus.AutoSize = true;
            this.olaDailyProcessStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaDailyProcessStatus.Location = new System.Drawing.Point(46, 27);
            this.olaDailyProcessStatus.Name = "olaDailyProcessStatus";
            this.olaDailyProcessStatus.Size = new System.Drawing.Size(175, 20);
            this.olaDailyProcessStatus.TabIndex = 0;
            this.olaDailyProcessStatus.Text = "Daily Process Status";
            // 
            // ogbLogin
            // 
            this.ogbLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ogbLogin.BackgroundImage")));
            this.ogbLogin.Controls.Add(this.opbLogin);
            this.ogbLogin.Controls.Add(this.ocmOk);
            this.ogbLogin.Controls.Add(this.ocmCancel);
            this.ogbLogin.Controls.Add(this.label1);
            this.ogbLogin.Controls.Add(this.otbUsrPwd);
            this.ogbLogin.Controls.Add(this.olaPwd);
            this.ogbLogin.Controls.Add(this.otbUsrName);
            this.ogbLogin.Location = new System.Drawing.Point(398, 86);
            this.ogbLogin.Name = "ogbLogin";
            this.ogbLogin.Size = new System.Drawing.Size(329, 215);
            this.ogbLogin.TabIndex = 26;
            this.ogbLogin.TabStop = false;
            // 
            // opbLogin
            // 
            this.opbLogin.Image = ((System.Drawing.Image)(resources.GetObject("opbLogin.Image")));
            this.opbLogin.Location = new System.Drawing.Point(22, 63);
            this.opbLogin.Name = "opbLogin";
            this.opbLogin.Size = new System.Drawing.Size(65, 64);
            this.opbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opbLogin.TabIndex = 19;
            this.opbLogin.TabStop = false;
            // 
            // ocmOk
            // 
            this.ocmOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ocmOk.Image = ((System.Drawing.Image)(resources.GetObject("ocmOk.Image")));
            this.ocmOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ocmOk.Location = new System.Drawing.Point(105, 133);
            this.ocmOk.Name = "ocmOk";
            this.ocmOk.Size = new System.Drawing.Size(100, 30);
            this.ocmOk.TabIndex = 22;
            this.ocmOk.Tag = "2;ตกลง;Ok";
            this.ocmOk.Text = "Ok";
            this.ocmOk.UseVisualStyleBackColor = true;
            this.ocmOk.Click += new System.EventHandler(this.ocmOk_Click);
            // 
            // ocmCancel
            // 
            this.ocmCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ocmCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ocmCancel.Image = ((System.Drawing.Image)(resources.GetObject("ocmCancel.Image")));
            this.ocmCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ocmCancel.Location = new System.Drawing.Point(210, 133);
            this.ocmCancel.Name = "ocmCancel";
            this.ocmCancel.Size = new System.Drawing.Size(100, 30);
            this.ocmCancel.TabIndex = 24;
            this.ocmCancel.Tag = "2;ปิด;Close";
            this.ocmCancel.Text = "Cancel";
            this.ocmCancel.UseVisualStyleBackColor = true;
            this.ocmCancel.Click += new System.EventHandler(this.ocmCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(102, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 23;
            this.label1.Tag = "2;รหัสผู้ใช้;User Code";
            this.label1.Text = "UserName";
            // 
            // otbUsrPwd
            // 
            this.otbUsrPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbUsrPwd.Location = new System.Drawing.Point(192, 93);
            this.otbUsrPwd.MaxLength = 20;
            this.otbUsrPwd.Name = "otbUsrPwd";
            this.otbUsrPwd.PasswordChar = '*';
            this.otbUsrPwd.Size = new System.Drawing.Size(118, 22);
            this.otbUsrPwd.TabIndex = 21;
            // 
            // olaPwd
            // 
            this.olaPwd.AutoSize = true;
            this.olaPwd.BackColor = System.Drawing.Color.Transparent;
            this.olaPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaPwd.Location = new System.Drawing.Point(102, 96);
            this.olaPwd.Name = "olaPwd";
            this.olaPwd.Size = new System.Drawing.Size(68, 16);
            this.olaPwd.TabIndex = 25;
            this.olaPwd.Tag = "2;รหัสผ่าน;Password";
            this.olaPwd.Text = "Password";
            // 
            // otbUsrName
            // 
            this.otbUsrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbUsrName.Location = new System.Drawing.Point(192, 63);
            this.otbUsrName.MaxLength = 20;
            this.otbUsrName.Name = "otbUsrName";
            this.otbUsrName.Size = new System.Drawing.Size(118, 22);
            this.otbUsrName.TabIndex = 20;
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
            // wMain
            // 
            this.AcceptButton = this.ocmOk;
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
            this.otaTebSetting.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opbReload)).EndInit();
            this.otaTabReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.otaTebMain.ResumeLayout(false);
            this.ogbDateTime.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ogbStatus.ResumeLayout(false);
            this.ogbStatus.PerformLayout();
            this.ogbLogin.ResumeLayout(false);
            this.ogbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opbLogin)).EndInit();
            this.otaTebControl.ResumeLayout(false);
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
        public System.Windows.Forms.ToolStripButton otoSetting;
        private System.Windows.Forms.TabPage otaTebSetting;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label olaDbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label olaServerName;
        private System.Windows.Forms.Label olalbel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ocmLoadPlant;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ocbDbName;
        private System.Windows.Forms.PictureBox opbReload;
        private System.Windows.Forms.Label olaDbNm;
        private System.Windows.Forms.TextBox otbServer;
        private System.Windows.Forms.Label olaServer;
        private System.Windows.Forms.Label olaPassword;
        private System.Windows.Forms.Button ocmSave;
        private System.Windows.Forms.TextBox otbUserPwd;
        private System.Windows.Forms.TextBox otbUserName;
        private System.Windows.Forms.Label olaUserName;
        private System.Windows.Forms.TabPage otaTabReport;
        private System.Windows.Forms.Button ocmPrint;
        private System.Windows.Forms.Button ocmPreview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage otaTebMain;
        private System.Windows.Forms.TabControl otaTebControl;
        private System.Windows.Forms.GroupBox ogbLogin;
        internal System.Windows.Forms.PictureBox opbLogin;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox otbUsrPwd;
        internal System.Windows.Forms.Label olaPwd;
        internal System.Windows.Forms.TextBox otbUsrName;
        private System.Windows.Forms.GroupBox ogbStatus;
        private System.Windows.Forms.Label olaDailyProcessStatus;
        private System.Windows.Forms.Label olaSaleExp;
        private System.Windows.Forms.Label olaClsStore;
        private System.Windows.Forms.Label olaOpnStore;
        private System.Windows.Forms.Label olaTbUp;
        private System.Windows.Forms.Button ocmSelectPlant;
        private System.Windows.Forms.GroupBox ogbDateTime;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label olaDateHD;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label olaOprDate;
        private System.Windows.Forms.Label olaOperationDate;
        private System.Windows.Forms.Label olaTimeHD;
        private System.Windows.Forms.Label olaTimeDT;
        private System.Windows.Forms.Label olaDateDT;
        private System.Windows.Forms.Button ocmOk;
        private System.Windows.Forms.Button ocmCancel;
    }
}

