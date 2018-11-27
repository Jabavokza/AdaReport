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
            this.olaHeader = new MetroFramework.Controls.MetroLabel();
            this.ocrCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
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
            // ocrCrystalReportViewer
            // 
            this.ocrCrystalReportViewer.ActiveViewIndex = -1;
            this.ocrCrystalReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ocrCrystalReportViewer.AutoSize = true;
            this.ocrCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ocrCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ocrCrystalReportViewer.Location = new System.Drawing.Point(23, 63);
            this.ocrCrystalReportViewer.Name = "ocrCrystalReportViewer";
            this.ocrCrystalReportViewer.Size = new System.Drawing.Size(978, 488);
            this.ocrCrystalReportViewer.TabIndex = 2;
            // 
            // wReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.ocrCrystalReportViewer);
            this.Controls.Add(this.olaHeader);
            this.Name = "wReportView";
            this.Text = "ReportView";
            this.Load += new System.EventHandler(this.wReportView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroLabel olaHeader;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer ocrCrystalReportViewer;
    }
}