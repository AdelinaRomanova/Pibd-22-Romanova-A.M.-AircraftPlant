
namespace AircraftPlantView
{
	partial class FormReportOrders
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
			this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
			this.buttonMake = new System.Windows.Forms.Button();
			this.buttonToPdf = new System.Windows.Forms.Button();
			this.panel = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "С";
			// 
			// dateTimePickerFrom
			// 
			this.dateTimePickerFrom.Location = new System.Drawing.Point(28, 9);
			this.dateTimePickerFrom.Name = "dateTimePickerFrom";
			this.dateTimePickerFrom.Size = new System.Drawing.Size(165, 27);
			this.dateTimePickerFrom.TabIndex = 1;
			// 
			// dateTimePickerTo
			// 
			this.dateTimePickerTo.Location = new System.Drawing.Point(232, 9);
			this.dateTimePickerTo.Name = "dateTimePickerTo";
			this.dateTimePickerTo.Size = new System.Drawing.Size(170, 27);
			this.dateTimePickerTo.TabIndex = 3;
			// 
			// buttonMake
			// 
			this.buttonMake.Location = new System.Drawing.Point(421, 9);
			this.buttonMake.Name = "buttonMake";
			this.buttonMake.Size = new System.Drawing.Size(143, 29);
			this.buttonMake.TabIndex = 4;
			this.buttonMake.Text = "Сформировать ";
			this.buttonMake.UseVisualStyleBackColor = true;
			this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
			// 
			// buttonToPdf
			// 
			this.buttonToPdf.Location = new System.Drawing.Point(590, 9);
			this.buttonToPdf.Name = "buttonToPdf";
			this.buttonToPdf.Size = new System.Drawing.Size(117, 29);
			this.buttonToPdf.TabIndex = 5;
			this.buttonToPdf.Text = "В PDF";
			this.buttonToPdf.UseVisualStyleBackColor = true;
			this.buttonToPdf.Click += new System.EventHandler(this.buttonToPdf_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.label3);
			this.panel.Controls.Add(this.buttonToPdf);
			this.panel.Controls.Add(this.label1);
			this.panel.Controls.Add(this.buttonMake);
			this.panel.Controls.Add(this.dateTimePickerFrom);
			this.panel.Controls.Add(this.dateTimePickerTo);
			this.panel.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(800, 44);
			this.panel.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(199, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "по";
			// 
			// FormReportOrders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel);
			this.Name = "FormReportOrders";
			this.Text = "Заказы";
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
		private System.Windows.Forms.DateTimePicker dateTimePickerTo;
		private System.Windows.Forms.Button buttonMake;
		private System.Windows.Forms.Button buttonToPdf;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Label label3;
	}
}