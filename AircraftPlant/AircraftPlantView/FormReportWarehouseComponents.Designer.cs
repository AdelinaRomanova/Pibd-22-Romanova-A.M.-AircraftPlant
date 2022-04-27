namespace AircraftPlantView
{
    partial class FormReportWarehouseComponents
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
            this.dataGridViewWarehouses = new System.Windows.Forms.DataGridView();
            this.ColumnWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSaveExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWarehouses
            // 
            this.dataGridViewWarehouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWarehouses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewWarehouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWarehouses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnWarehouse,
            this.ColumnComponent,
            this.ColumnCount});
            this.dataGridViewWarehouses.Location = new System.Drawing.Point(12, 13);
            this.dataGridViewWarehouses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewWarehouses.Name = "dataGridViewWarehouses";
            this.dataGridViewWarehouses.ReadOnly = true;
            this.dataGridViewWarehouses.RowHeadersWidth = 51;
            this.dataGridViewWarehouses.RowTemplate.Height = 25;
            this.dataGridViewWarehouses.Size = new System.Drawing.Size(616, 302);
            this.dataGridViewWarehouses.TabIndex = 3;
            // 
            // ColumnWarehouse
            // 
            this.ColumnWarehouse.HeaderText = "Склад";
            this.ColumnWarehouse.MinimumWidth = 6;
            this.ColumnWarehouse.Name = "ColumnWarehouse";
            this.ColumnWarehouse.ReadOnly = true;
            // 
            // ColumnComponent
            // 
            this.ColumnComponent.HeaderText = "Компонент";
            this.ColumnComponent.MinimumWidth = 6;
            this.ColumnComponent.Name = "ColumnComponent";
            this.ColumnComponent.ReadOnly = true;
            // 
            // ColumnCount
            // 
            this.ColumnCount.HeaderText = "Количество";
            this.ColumnCount.MinimumWidth = 6;
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.ReadOnly = true;
            // 
            // buttonSaveExcel
            // 
            this.buttonSaveExcel.Location = new System.Drawing.Point(240, 341);
            this.buttonSaveExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSaveExcel.Name = "buttonSaveExcel";
            this.buttonSaveExcel.Size = new System.Drawing.Size(155, 43);
            this.buttonSaveExcel.TabIndex = 2;
            this.buttonSaveExcel.Text = "Сохранить в Excel";
            this.buttonSaveExcel.UseVisualStyleBackColor = true;
            this.buttonSaveExcel.Click += new System.EventHandler(this.buttonSaveExcel_Click);
            // 
            // FormReportWarehouseComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 408);
            this.Controls.Add(this.dataGridViewWarehouses);
            this.Controls.Add(this.buttonSaveExcel);
            this.Name = "FormReportWarehouseComponent";
            this.Text = "Компоненты на складах";
            this.Load += new System.EventHandler(this.FormReportWarehouseComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWarehouses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
        private System.Windows.Forms.Button buttonSaveExcel;
    }
}