namespace AdaReport.Form
{
    partial class wPlant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wPlant));
            this.ogdPlant = new System.Windows.Forms.DataGridView();
            this.ocmExit = new System.Windows.Forms.Button();
            this.oBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ogdPlant)).BeginInit();
            this.SuspendLayout();
            // 
            // ogdPlant
            // 
            this.ogdPlant.AllowUserToAddRows = false;
            this.ogdPlant.AllowUserToDeleteRows = false;
            this.ogdPlant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogdPlant.Location = new System.Drawing.Point(23, 61);
            this.ogdPlant.Name = "ogdPlant";
            this.ogdPlant.ReadOnly = true;
            this.ogdPlant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ogdPlant.Size = new System.Drawing.Size(520, 150);
            this.ogdPlant.TabIndex = 0;
            this.ogdPlant.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ogdPlant_CellDoubleClick);
            // 
            // ocmExit
            // 
            this.ocmExit.BackColor = System.Drawing.Color.White;
            this.ocmExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ocmExit.BackgroundImage")));
            this.ocmExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ocmExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ocmExit.Location = new System.Drawing.Point(551, 4);
            this.ocmExit.Name = "ocmExit";
            this.ocmExit.Size = new System.Drawing.Size(15, 15);
            this.ocmExit.TabIndex = 1;
            this.ocmExit.UseVisualStyleBackColor = false;
            this.ocmExit.Click += new System.EventHandler(this.ocmExit_Click);
            // 
            // oBackgroundWorker
            // 
            this.oBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.oBackgroundWorker_DoWork);
            this.oBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.oBackgroundWorker_ProgressChanged);
            this.oBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.oBackgroundWorker_RunWorkerCompleted);
            // 
            // wPlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 223);
            this.ControlBox = false;
            this.Controls.Add(this.ocmExit);
            this.Controls.Add(this.ogdPlant);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wPlant";
            this.Resizable = false;
            this.Text = "Select Plant DB";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.wPlant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogdPlant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ogdPlant;
        private System.Windows.Forms.Button ocmExit;
        private System.ComponentModel.BackgroundWorker oBackgroundWorker;
    }
}