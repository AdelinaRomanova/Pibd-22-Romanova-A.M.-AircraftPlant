namespace AircraftPlantView
{
    partial class FormMessageInfo
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
            this.labelSenderName = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelDateDelivery = new System.Windows.Forms.Label();
            this.labelBody = new System.Windows.Forms.Label();
            this.labelReplySubject = new System.Windows.Forms.Label();
            this.textBoxReplySubject = new System.Windows.Forms.TextBox();
            this.buttonReply = new System.Windows.Forms.Button();
            this.textBoxReply = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSenderName
            // 
            this.labelSenderName.AutoSize = true;
            this.labelSenderName.Location = new System.Drawing.Point(29, 29);
            this.labelSenderName.Name = "labelSenderName";
            this.labelSenderName.Size = new System.Drawing.Size(99, 20);
            this.labelSenderName.TabIndex = 0;
            this.labelSenderName.Text = "Отправитель";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(29, 65);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(81, 20);
            this.labelSubject.TabIndex = 1;
            this.labelSubject.Text = "Заголовок";
            // 
            // labelDateDelivery
            // 
            this.labelDateDelivery.AutoSize = true;
            this.labelDateDelivery.Location = new System.Drawing.Point(29, 99);
            this.labelDateDelivery.Name = "labelDateDelivery";
            this.labelDateDelivery.Size = new System.Drawing.Size(91, 20);
            this.labelDateDelivery.TabIndex = 6;
            this.labelDateDelivery.Text = "Доставлено";
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.Location = new System.Drawing.Point(95, 138);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(45, 20);
            this.labelBody.TabIndex = 7;
            this.labelBody.Text = "Текст";
            // 
            // labelReplySubject
            // 
            this.labelReplySubject.AutoSize = true;
            this.labelReplySubject.Location = new System.Drawing.Point(29, 194);
            this.labelReplySubject.Name = "labelReplySubject";
            this.labelReplySubject.Size = new System.Drawing.Size(81, 20);
            this.labelReplySubject.TabIndex = 11;
            this.labelReplySubject.Text = "Заголовок";
            // 
            // textBoxReplySubject
            // 
            this.textBoxReplySubject.Location = new System.Drawing.Point(137, 191);
            this.textBoxReplySubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxReplySubject.Name = "textBoxReplySubject";
            this.textBoxReplySubject.Size = new System.Drawing.Size(385, 27);
            this.textBoxReplySubject.TabIndex = 10;
            // 
            // buttonReply
            // 
            this.buttonReply.Location = new System.Drawing.Point(215, 458);
            this.buttonReply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReply.Name = "buttonReply";
            this.buttonReply.Size = new System.Drawing.Size(146, 41);
            this.buttonReply.TabIndex = 9;
            this.buttonReply.Text = "Отправить ответ";
            this.buttonReply.UseVisualStyleBackColor = true;
            this.buttonReply.Click += new System.EventHandler(this.buttonReply_Click);
            // 
            // textBoxReply
            // 
            this.textBoxReply.Location = new System.Drawing.Point(29, 243);
            this.textBoxReply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxReply.Multiline = true;
            this.textBoxReply.Name = "textBoxReply";
            this.textBoxReply.Size = new System.Drawing.Size(504, 194);
            this.textBoxReply.TabIndex = 8;
            // 
            // FormMessageInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 506);
            this.Controls.Add(this.labelReplySubject);
            this.Controls.Add(this.textBoxReplySubject);
            this.Controls.Add(this.buttonReply);
            this.Controls.Add(this.textBoxReply);
            this.Controls.Add(this.labelBody);
            this.Controls.Add(this.labelDateDelivery);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelSenderName);
            this.Name = "FormMessageInfo";
            this.Text = "Письмо";
            this.Load += new System.EventHandler(this.FormMessageInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSenderName;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelDateDelivery;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.Label labelReplySubject;
        private System.Windows.Forms.TextBox textBoxReplySubject;
        private System.Windows.Forms.Button buttonReply;
        private System.Windows.Forms.TextBox textBoxReply;
    }
}