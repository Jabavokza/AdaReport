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
            this.otoRptAll = new System.Windows.Forms.ToolStripButton();
            this.otoLang = new System.Windows.Forms.ToolStripButton();
            this.otoExit = new System.Windows.Forms.ToolStripButton();
            this.otoMainControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // otoMainControl
            // 
            this.otoMainControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otoRptAll,
            this.otoLang,
            this.otoExit});
            this.otoMainControl.Location = new System.Drawing.Point(0, 0);
            this.otoMainControl.Name = "otoMainControl";
            this.otoMainControl.Size = new System.Drawing.Size(800, 78);
            this.otoMainControl.TabIndex = 0;
            this.otoMainControl.Text = "toolStrip1";
            // 
            // otoRptAll
            // 
            this.otoRptAll.AutoSize = false;
            this.otoRptAll.AutoToolTip = false;
            this.otoRptAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.otoRptAll.Image = ((System.Drawing.Image)(resources.GetObject("otoRptAll.Image")));
            this.otoRptAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.otoRptAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otoRptAll.Name = "otoRptAll";
            this.otoRptAll.Size = new System.Drawing.Size(65, 75);
            this.otoRptAll.Text = "Report";
            this.otoRptAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // otoLang
            // 
            this.otoLang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.otoLang.Image = ((System.Drawing.Image)(resources.GetObject("otoLang.Image")));
            this.otoLang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otoLang.Name = "otoLang";
            this.otoLang.Size = new System.Drawing.Size(23, 75);
            this.otoLang.Text = "Language";
            // 
            // otoExit
            // 
            this.otoExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.otoExit.Image = ((System.Drawing.Image)(resources.GetObject("otoExit.Image")));
            this.otoExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otoExit.Name = "otoExit";
            this.otoExit.Size = new System.Drawing.Size(23, 75);
            this.otoExit.Text = "Exit";
            // 
            // wMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.otoMainControl);
            this.Name = "wMain";
            this.Text = "AdaReport";
            this.otoMainControl.ResumeLayout(false);
            this.otoMainControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip otoMainControl;
        private System.Windows.Forms.ToolStripButton otoRptAll;
        private System.Windows.Forms.ToolStripButton otoLang;
        private System.Windows.Forms.ToolStripButton otoExit;
    }
}

