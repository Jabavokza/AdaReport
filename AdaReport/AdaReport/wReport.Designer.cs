namespace AdaReport
{
    partial class wReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wReport));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.otoMainControl = new System.Windows.Forms.ToolStrip();
            this.otoLogin = new System.Windows.Forms.ToolStripButton();
            this.otoPlantDB = new System.Windows.Forms.ToolStripButton();
            this.otoRptAll = new System.Windows.Forms.ToolStripButton();
            this.otoLang = new System.Windows.Forms.ToolStripButton();
            this.otoExit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.otoMainControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(475, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(309, 445);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(51, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(37, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // otoMainControl
            // 
            this.otoMainControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otoLogin,
            this.otoPlantDB,
            this.otoRptAll,
            this.otoLang,
            this.otoExit});
            this.otoMainControl.Location = new System.Drawing.Point(20, 60);
            this.otoMainControl.Name = "otoMainControl";
            this.otoMainControl.Size = new System.Drawing.Size(860, 68);
            this.otoMainControl.TabIndex = 2;
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
            // 
            // otoPlantDB
            // 
            this.otoPlantDB.AutoSize = false;
            this.otoPlantDB.AutoToolTip = false;
            this.otoPlantDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.otoPlantDB.Enabled = false;
            this.otoPlantDB.Image = ((System.Drawing.Image)(resources.GetObject("otoPlantDB.Image")));
            this.otoPlantDB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.otoPlantDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otoPlantDB.Name = "otoPlantDB";
            this.otoPlantDB.Size = new System.Drawing.Size(55, 65);
            this.otoPlantDB.Text = "PlantDB";
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
            // 
            // wReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.otoMainControl);
            this.Controls.Add(this.groupBox1);
            this.Name = "wReport";
            this.Text = "wReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.otoMainControl.ResumeLayout(false);
            this.otoMainControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip otoMainControl;
        public System.Windows.Forms.ToolStripButton otoLogin;
        public System.Windows.Forms.ToolStripButton otoPlantDB;
        public System.Windows.Forms.ToolStripButton otoRptAll;
        public System.Windows.Forms.ToolStripButton otoLang;
        private System.Windows.Forms.ToolStripButton otoExit;
    }
}