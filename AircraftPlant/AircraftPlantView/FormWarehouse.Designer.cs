
namespace AircraftPlantView
{
	partial class FormWarehouse
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
			this.labelWarhouseName = new System.Windows.Forms.Label();
			this.labelFIO = new System.Windows.Forms.Label();
			this.textBoxWarehouseName = new System.Windows.Forms.TextBox();
			this.textBoxResponsible = new System.Windows.Forms.TextBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ComponentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// labelWarhouseName
			// 
			this.labelWarhouseName.AutoSize = true;
			this.labelWarhouseName.Location = new System.Drawing.Point(13, 13);
			this.labelWarhouseName.Name = "labelWarhouseName";
			this.labelWarhouseName.Size = new System.Drawing.Size(80, 20);
			this.labelWarhouseName.TabIndex = 0;
			this.labelWarhouseName.Text = "Название:";
			// 
			// labelFIO
			// 
			this.labelFIO.AutoSize = true;
			this.labelFIO.Location = new System.Drawing.Point(13, 52);
			this.labelFIO.Name = "labelFIO";
			this.labelFIO.Size = new System.Drawing.Size(157, 20);
			this.labelFIO.TabIndex = 1;
			this.labelFIO.Text = "ФИО ответственного:";
			// 
			// textBoxWarehouseName
			// 
			this.textBoxWarehouseName.Location = new System.Drawing.Point(179, 10);
			this.textBoxWarehouseName.Name = "textBoxWarehouseName";
			this.textBoxWarehouseName.Size = new System.Drawing.Size(288, 27);
			this.textBoxWarehouseName.TabIndex = 2;
			// 
			// textBoxResponsible
			// 
			this.textBoxResponsible.Location = new System.Drawing.Point(179, 49);
			this.textBoxResponsible.Name = "textBoxResponsible";
			this.textBoxResponsible.Size = new System.Drawing.Size(288, 27);
			this.textBoxResponsible.TabIndex = 3;
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ComponentName,
            this.Count});
			this.dataGridView.Location = new System.Drawing.Point(13, 98);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 29;
			this.dataGridView.Size = new System.Drawing.Size(454, 239);
			this.dataGridView.TabIndex = 4;
			// 
			// ID
			// 
			this.ID.HeaderText = "";
			this.ID.MinimumWidth = 6;
			this.ID.Name = "ID";
			this.ID.Visible = false;
			this.ID.Width = 125;
			// 
			// ComponentName
			// 
			this.ComponentName.HeaderText = "Компонент";
			this.ComponentName.MinimumWidth = 6;
			this.ComponentName.Name = "ComponentName";
			this.ComponentName.Width = 200;
			// 
			// Count
			// 
			this.Count.HeaderText = "Количество";
			this.Count.MinimumWidth = 6;
			this.Count.Name = "Count";
			this.Count.Width = 200;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(261, 358);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(95, 34);
			this.buttonSave.TabIndex = 5;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new System.Drawing.Point(372, 358);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(95, 34);
			this.buttonClose.TabIndex = 6;
			this.buttonClose.Text = "Отмена";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// FormWarehouse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 410);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.textBoxResponsible);
			this.Controls.Add(this.textBoxWarehouseName);
			this.Controls.Add(this.labelFIO);
			this.Controls.Add(this.labelWarhouseName);
			this.Name = "FormWarehouse";
			this.Text = "Склад";
			this.Load += new System.EventHandler(this.FormWarehouse_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelWarhouseName;
		private System.Windows.Forms.Label labelFIO;
		private System.Windows.Forms.TextBox textBoxWarehouseName;
		private System.Windows.Forms.TextBox textBoxResponsible;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ComponentName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Count;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonClose;
	}
}