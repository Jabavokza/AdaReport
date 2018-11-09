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
            this.ogdPlant = new System.Windows.Forms.DataGridView();
            this.PlantCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenStore = new System.Windows.Forms.DataGridViewImageColumn();
            this.CloseStore = new System.Windows.Forms.DataGridViewImageColumn();
            this.SaleExport = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ogdPlant)).BeginInit();
            this.SuspendLayout();
            // 
            // ogdPlant
            // 
            this.ogdPlant.AllowUserToAddRows = false;
            this.ogdPlant.AllowUserToDeleteRows = false;
            this.ogdPlant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogdPlant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlantCode,
            this.PlantName,
            this.DataBase,
            this.OpenStore,
            this.CloseStore,
            this.SaleExport});
            this.ogdPlant.Location = new System.Drawing.Point(12, 59);
            this.ogdPlant.Name = "ogdPlant";
            this.ogdPlant.ReadOnly = true;
            this.ogdPlant.Size = new System.Drawing.Size(530, 150);
            this.ogdPlant.TabIndex = 0;
            // 
            // PlantCode
            // 
            this.PlantCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PlantCode.HeaderText = "PlantCode";
            this.PlantCode.Name = "PlantCode";
            this.PlantCode.ReadOnly = true;
            this.PlantCode.Width = 81;
            // 
            // PlantName
            // 
            this.PlantName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PlantName.HeaderText = "PlantName";
            this.PlantName.Name = "PlantName";
            this.PlantName.ReadOnly = true;
            this.PlantName.Width = 84;
            // 
            // DataBase
            // 
            this.DataBase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DataBase.HeaderText = "Data Base";
            this.DataBase.Name = "DataBase";
            this.DataBase.ReadOnly = true;
            this.DataBase.Width = 82;
            // 
            // OpenStore
            // 
            this.OpenStore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.OpenStore.HeaderText = "Open Store";
            this.OpenStore.Name = "OpenStore";
            this.OpenStore.ReadOnly = true;
            this.OpenStore.Width = 67;
            // 
            // CloseStore
            // 
            this.CloseStore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CloseStore.HeaderText = "Close Store";
            this.CloseStore.Name = "CloseStore";
            this.CloseStore.ReadOnly = true;
            this.CloseStore.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CloseStore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CloseStore.Width = 86;
            // 
            // SaleExport
            // 
            this.SaleExport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SaleExport.HeaderText = "Sale Export";
            this.SaleExport.Name = "SaleExport";
            this.SaleExport.ReadOnly = true;
            this.SaleExport.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SaleExport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SaleExport.Width = 86;
            // 
            // wPlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 231);
            this.Controls.Add(this.ogdPlant);
            this.Name = "wPlant";
            this.Resizable = false;
            this.Text = "Select Plant DB";
            ((System.ComponentModel.ISupportInitialize)(this.ogdPlant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ogdPlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlantCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataBase;
        private System.Windows.Forms.DataGridViewImageColumn OpenStore;
        private System.Windows.Forms.DataGridViewImageColumn CloseStore;
        private System.Windows.Forms.DataGridViewImageColumn SaleExport;
    }
}