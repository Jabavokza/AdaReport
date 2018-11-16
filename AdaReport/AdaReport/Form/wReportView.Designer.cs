namespace AdaReport.Form
{
    partial class wReportView
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
            this.ocrReportView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.olaHeader = new MetroFramework.Controls.MetroLabel();
            this.CrystalReport1 = new AdaReport.CrystalReport();
            this.CrystalReport2 = new AdaReport.CrystalReport();
            this.SuspendLayout();
            // 
            // ocrReportView
            // 
            this.ocrReportView.ActiveViewIndex = -1;
            this.ocrReportView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ocrReportView.AutoSize = true;
            this.ocrReportView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ocrReportView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ocrReportView.Location = new System.Drawing.Point(23, 63);
            this.ocrReportView.Name = "ocrReportView";
            this.ocrReportView.Size = new System.Drawing.Size(978, 514);
            this.ocrReportView.TabIndex = 0;
            // 
            // olaHeader
            // 
            this.olaHeader.AutoSize = true;
            this.olaHeader.Location = new System.Drawing.Point(169, 30);
            this.olaHeader.Name = "olaHeader";
            this.olaHeader.Size = new System.Drawing.Size(27, 19);
            this.olaHeader.TabIndex = 1;
            this.olaHeader.Text = "HD";
            this.olaHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.olaHeader);
            this.Controls.Add(this.ocrReportView);
            this.Name = "wReportView";
            this.Text = "ReportView";
            this.Load += new System.EventHandler(this.wReportView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public CrystalDecisions.Windows.Forms.CrystalReportViewer ocrReportView;
        public MetroFramework.Controls.MetroLabel olaHeader;
        private CrystalReport CrystalReport1;
        private CrystalReport CrystalReport2;
    }
}