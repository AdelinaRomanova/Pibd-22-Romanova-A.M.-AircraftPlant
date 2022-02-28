
namespace AircraftPlantView
{
	partial class FormPlane
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
			this.labelName = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.groupBoxComponent = new System.Windows.Forms.GroupBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.IDComponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NameComponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CountCompanent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonRef = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonUpd = new System.Windows.Forms.Button();
			this.buttonDel = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBoxComponent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(21, 19);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(80, 20);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Название:";
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(21, 58);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(48, 20);
			this.labelPrice.TabIndex = 1;
			this.labelPrice.Text = "Цена:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(117, 16);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(276, 27);
			this.textBoxName.TabIndex = 2;
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(117, 55);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(276, 27);
			this.textBoxPrice.TabIndex = 3;
			// 
			// groupBoxComponent
			// 
			this.groupBoxComponent.Controls.Add(this.dataGridView);
			this.groupBoxComponent.Controls.Add(this.buttonRef);
			this.groupBoxComponent.Controls.Add(this.buttonAdd);
			this.groupBoxComponent.Controls.Add(this.buttonUpd);
			this.groupBoxComponent.Controls.Add(this.buttonDel);
			this.groupBoxComponent.Location = new System.Drawing.Point(21, 114);
			this.groupBoxComponent.Name = "groupBoxComponent";
			this.groupBoxComponent.Size = new System.Drawing.Size(569, 278);
			this.groupBoxComponent.TabIndex = 4;
			this.groupBoxComponent.TabStop = false;
			this.groupBoxComponent.Text = "Компоненты";
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDComponent,
            this.NameComponent,
            this.CountCompanent});
			this.dataGridView.Location = new System.Drawing.Point(17, 27);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 29;
			this.dataGridView.Size = new System.Drawing.Size(400, 232);
			this.dataGridView.TabIndex = 0;
			// 
			// IDComponent
			// 
			this.IDComponent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.IDComponent.HeaderText = "ID";
			this.IDComponent.MinimumWidth = 6;
			this.IDComponent.Name = "IDComponent";
			this.IDComponent.Visible = false;
			this.IDComponent.Width = 6;
			// 
			// NameComponent
			// 
			this.NameComponent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NameComponent.HeaderText = "Название";
			this.NameComponent.MinimumWidth = 6;
			this.NameComponent.Name = "NameComponent";
			// 
			// CountCompanent
			// 
			this.CountCompanent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.CountCompanent.HeaderText = "Количество";
			this.CountCompanent.MinimumWidth = 6;
			this.CountCompanent.Name = "CountCompanent";
			// 
			// buttonRef
			// 
			this.buttonRef.Location = new System.Drawing.Point(446, 181);
			this.buttonRef.Name = "buttonRef";
			this.buttonRef.Size = new System.Drawing.Size(94, 29);
			this.buttonRef.TabIndex = 8;
			this.buttonRef.Text = "Обновить";
			this.buttonRef.UseVisualStyleBackColor = true;
			this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(446, 44);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(94, 29);
			this.buttonAdd.TabIndex = 5;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonUpd
			// 
			this.buttonUpd.Location = new System.Drawing.Point(446, 90);
			this.buttonUpd.Name = "buttonUpd";
			this.buttonUpd.Size = new System.Drawing.Size(94, 29);
			this.buttonUpd.TabIndex = 6;
			this.buttonUpd.Text = "Изменить";
			this.buttonUpd.UseVisualStyleBackColor = true;
			this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
			// 
			// buttonDel
			// 
			this.buttonDel.Location = new System.Drawing.Point(446, 135);
			this.buttonDel.Name = "buttonDel";
			this.buttonDel.Size = new System.Drawing.Size(94, 29);
			this.buttonDel.TabIndex = 7;
			this.buttonDel.Text = "Удалить";
			this.buttonDel.UseVisualStyleBackColor = true;
			this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(367, 409);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(94, 29);
			this.buttonSave.TabIndex = 9;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(478, 409);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(94, 29);
			this.buttonCancel.TabIndex = 10;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// FormPlane
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 450);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.groupBoxComponent);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelName);
			this.Name = "FormPlane";
			this.Text = "Изделие";
			this.Load += new System.EventHandler(this.FormPlane_Load);
			this.groupBoxComponent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.GroupBox groupBoxComponent;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonUpd;
		private System.Windows.Forms.Button buttonDel;
		private System.Windows.Forms.Button buttonRef;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDComponent;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameComponent;
		private System.Windows.Forms.DataGridViewTextBoxColumn CountCompanent;
	}
}