
namespace AircraftPlantView
{
	partial class FormReportPlaneComponents
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
			this.buttonSaveToExcel = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Plane = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonSaveToExcel
			// 
			this.buttonSaveToExcel.Location = new System.Drawing.Point(13, 13);
			this.buttonSaveToExcel.Name = "buttonSaveToExcel";
			this.buttonSaveToExcel.Size = new System.Drawing.Size(173, 35);
			this.buttonSaveToExcel.TabIndex = 0;
			this.buttonSaveToExcel.Text = "Сохранить в Excel";
			this.buttonSaveToExcel.UseVisualStyleBackColor = true;
			this.buttonSaveToExcel.Click += new System.EventHandler(this.buttonSaveToExcel_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Component,
            this.Plane,
            this.Count});
			this.dataGridView.Location = new System.Drawing.Point(13, 67);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 29;
			this.dataGridView.Size = new System.Drawing.Size(585, 298);
			this.dataGridView.TabIndex = 1;
			// 
			// Component
			// 
			this.Component.HeaderText = "Компонент";
			this.Component.MinimumWidth = 6;
			this.Component.Name = "Component";
			this.Component.Width = 190;
			// 
			// Plane
			// 
			this.Plane.HeaderText = "Изделие";
			this.Plane.MinimumWidth = 6;
			this.Plane.Name = "Plane";
			this.Plane.Width = 190;
			// 
			// Count
			// 
			this.Count.HeaderText = "Количество ";
			this.Count.MinimumWidth = 6;
			this.Count.Name = "Count";
			this.Count.Width = 150;
			// 
			// FormReportPlaneComponents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 401);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.buttonSaveToExcel);
			this.Name = "FormReportPlaneComponents";
			this.Text = "Компоненты по изделиям";
			this.Load += new System.EventHandler(this.FormReportPlaneComponents_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonSaveToExcel;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn Component;
		private System.Windows.Forms.DataGridViewTextBoxColumn Plane;
		private System.Windows.Forms.DataGridViewTextBoxColumn Count;
	}
}