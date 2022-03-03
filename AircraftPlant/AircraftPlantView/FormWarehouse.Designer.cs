
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxWarehouseName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxFIO = new System.Windows.Forms.TextBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.IDWarhouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ComponentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ComponentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Название:";
			// 
			// textBoxWarehouseName
			// 
			this.textBoxWarehouseName.Location = new System.Drawing.Point(187, 13);
			this.textBoxWarehouseName.Name = "textBoxWarehouseName";
			this.textBoxWarehouseName.Size = new System.Drawing.Size(339, 27);
			this.textBoxWarehouseName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "ФИО ответственного:";
			// 
			// textBoxFIO
			// 
			this.textBoxFIO.Location = new System.Drawing.Point(187, 66);
			this.textBoxFIO.Name = "textBoxFIO";
			this.textBoxFIO.Size = new System.Drawing.Size(339, 27);
			this.textBoxFIO.TabIndex = 3;
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDWarhouse,
            this.ComponentName,
            this.ComponentCount});
			this.dataGridView.Location = new System.Drawing.Point(23, 121);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 29;
			this.dataGridView.Size = new System.Drawing.Size(503, 188);
			this.dataGridView.TabIndex = 4;
			// 
			// IDWarhouse
			// 
			this.IDWarhouse.HeaderText = "";
			this.IDWarhouse.MinimumWidth = 6;
			this.IDWarhouse.Name = "IDWarhouse";
			this.IDWarhouse.Visible = false;
			this.IDWarhouse.Width = 125;
			// 
			// ComponentName
			// 
			this.ComponentName.HeaderText = "Компонент";
			this.ComponentName.MinimumWidth = 6;
			this.ComponentName.Name = "ComponentName";
			this.ComponentName.Width = 250;
			// 
			// ComponentCount
			// 
			this.ComponentCount.HeaderText = "Количество";
			this.ComponentCount.MinimumWidth = 6;
			this.ComponentCount.Name = "ComponentCount";
			this.ComponentCount.Width = 200;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(278, 330);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(94, 29);
			this.buttonSave.TabIndex = 5;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new System.Drawing.Point(432, 330);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(94, 29);
			this.buttonClose.TabIndex = 6;
			this.buttonClose.Text = "Отмена";
			this.buttonClose.UseVisualStyleBackColor = true;
			// 
			// FormWarehouse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(572, 383);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.textBoxFIO);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxWarehouseName);
			this.Controls.Add(this.label1);
			this.Name = "FormWarehouse";
			this.Text = "Склад";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxWarehouseName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxFIO;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDWarhouse;
		private System.Windows.Forms.DataGridViewTextBoxColumn ComponentName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ComponentCount;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonClose;
	}
}