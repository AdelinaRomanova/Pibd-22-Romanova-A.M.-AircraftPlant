﻿
namespace AircraftPlantView
{
	partial class FormCreateOrder
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
			this.labelCount = new System.Windows.Forms.Label();
			this.labelSum = new System.Windows.Forms.Label();
			this.textBoxCount = new System.Windows.Forms.TextBox();
			this.comboBoxPlane = new System.Windows.Forms.ComboBox();
			this.textBoxSum = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.labelClient = new System.Windows.Forms.Label();
			this.comboBoxClient = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(23, 56);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(71, 20);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Изделие:";
			// 
			// labelCount
			// 
			this.labelCount.AutoSize = true;
			this.labelCount.Location = new System.Drawing.Point(23, 96);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(93, 20);
			this.labelCount.TabIndex = 1;
			this.labelCount.Text = "Количество:";
			// 
			// labelSum
			// 
			this.labelSum.AutoSize = true;
			this.labelSum.Location = new System.Drawing.Point(23, 133);
			this.labelSum.Name = "labelSum";
			this.labelSum.Size = new System.Drawing.Size(55, 20);
			this.labelSum.TabIndex = 2;
			this.labelSum.Text = "Сумма";
			// 
			// textBoxCount
			// 
			this.textBoxCount.Location = new System.Drawing.Point(122, 93);
			this.textBoxCount.Name = "textBoxCount";
			this.textBoxCount.Size = new System.Drawing.Size(332, 27);
			this.textBoxCount.TabIndex = 4;
			this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
			// 
			// comboBoxPlane
			// 
			this.comboBoxPlane.FormattingEnabled = true;
			this.comboBoxPlane.Location = new System.Drawing.Point(122, 53);
			this.comboBoxPlane.Name = "comboBoxPlane";
			this.comboBoxPlane.Size = new System.Drawing.Size(332, 28);
			this.comboBoxPlane.TabIndex = 5;
			this.comboBoxPlane.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlane_SelectedIndexChanged);
			// 
			// textBoxSum
			// 
			this.textBoxSum.Location = new System.Drawing.Point(122, 130);
			this.textBoxSum.Name = "textBoxSum";
			this.textBoxSum.Size = new System.Drawing.Size(332, 27);
			this.textBoxSum.TabIndex = 6;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(260, 163);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(94, 29);
			this.buttonSave.TabIndex = 7;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(360, 163);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(94, 29);
			this.buttonCancel.TabIndex = 8;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// labelClient
			// 
			this.labelClient.AutoSize = true;
			this.labelClient.Location = new System.Drawing.Point(27, 16);
			this.labelClient.Name = "labelClient";
			this.labelClient.Size = new System.Drawing.Size(58, 20);
			this.labelClient.TabIndex = 9;
			this.labelClient.Text = "Клиент";
			// 
			// comboBoxClient
			// 
			this.comboBoxClient.FormattingEnabled = true;
			this.comboBoxClient.Location = new System.Drawing.Point(123, 17);
			this.comboBoxClient.Name = "comboBoxClient";
			this.comboBoxClient.Size = new System.Drawing.Size(331, 28);
			this.comboBoxClient.TabIndex = 10;
			// 
			// FormCreateOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(498, 212);
			this.Controls.Add(this.comboBoxClient);
			this.Controls.Add(this.labelClient);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.textBoxSum);
			this.Controls.Add(this.comboBoxPlane);
			this.Controls.Add(this.textBoxCount);
			this.Controls.Add(this.labelSum);
			this.Controls.Add(this.labelCount);
			this.Controls.Add(this.labelName);
			this.Name = "FormCreateOrder";
			this.Text = "Заказ";
			this.Load += new System.EventHandler(this.FormCreateOrder_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelCount;
		private System.Windows.Forms.Label labelSum;
		private System.Windows.Forms.TextBox textBoxCount;
		private System.Windows.Forms.ComboBox comboBoxPlane;
		private System.Windows.Forms.TextBox textBoxSum;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label labelClient;
		private System.Windows.Forms.ComboBox comboBoxClient;
	}
}