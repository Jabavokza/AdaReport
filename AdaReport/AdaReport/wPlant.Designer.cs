namespace AdaReport
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
            this.components = new System.ComponentModel.Container();
            this.ogdPlant = new System.Windows.Forms.DataGridView();
            this.wPlantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ogdPlant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wPlantBindingSource)).BeginInit();
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
            this.ogdPlant.Size = new System.Drawing.Size(520, 150);
            this.ogdPlant.TabIndex = 0;
            this.ogdPlant.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ogdPlant_CellDoubleClick);
            // 
            // wPlantBindingSource
            // 
            this.wPlantBindingSource.DataSource = typeof(AdaReport.wPlant);
            // 
            // wPlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 223);
            this.ControlBox = false;
            this.Controls.Add(this.ogdPlant);
            this.Name = "wPlant";
            this.Resizable = false;
            this.Text = "Select Plant DB";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.wPlant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogdPlant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wPlantBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource wPlantBindingSource;
        private System.Windows.Forms.DataGridView ogdPlant;
    }
}