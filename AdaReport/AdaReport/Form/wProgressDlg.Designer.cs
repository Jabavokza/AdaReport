namespace AdaReport.Form
{
    partial class wProgressDlg
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
            this.opgProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // opgProgressSpinner
            // 
            this.opgProgressSpinner.Location = new System.Drawing.Point(118, 14);
            this.opgProgressSpinner.Maximum = 100;
            this.opgProgressSpinner.Name = "opgProgressSpinner";
            this.opgProgressSpinner.Size = new System.Drawing.Size(69, 71);
            this.opgProgressSpinner.Speed = 10F;
            this.opgProgressSpinner.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(112, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "โปรดรอสักครู่";
            // 
            // wProgressDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 118);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.opgProgressSpinner);
            this.Movable = false;
            this.Name = "wProgressDlg";
            this.Resizable = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner opgProgressSpinner;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}