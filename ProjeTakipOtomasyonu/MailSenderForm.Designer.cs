namespace ProjeTakipOtomasyonu
{
    partial class MailSenderForm
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
            this.cmbBoxMailTo = new System.Windows.Forms.ComboBox();
            this.rchTxtMailContent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMailObject = new System.Windows.Forms.TextBox();
            this.btnMailSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kime";
            // 
            // cmbBoxMailTo
            // 
            this.cmbBoxMailTo.FormattingEnabled = true;
            this.cmbBoxMailTo.Location = new System.Drawing.Point(108, 36);
            this.cmbBoxMailTo.Name = "cmbBoxMailTo";
            this.cmbBoxMailTo.Size = new System.Drawing.Size(152, 21);
            this.cmbBoxMailTo.TabIndex = 1;
            // 
            // rchTxtMailContent
            // 
            this.rchTxtMailContent.Location = new System.Drawing.Point(42, 134);
            this.rchTxtMailContent.Name = "rchTxtMailContent";
            this.rchTxtMailContent.Size = new System.Drawing.Size(725, 258);
            this.rchTxtMailContent.TabIndex = 2;
            this.rchTxtMailContent.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "İçerik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Konu:";
            // 
            // txtMailObject
            // 
            this.txtMailObject.Location = new System.Drawing.Point(391, 36);
            this.txtMailObject.Name = "txtMailObject";
            this.txtMailObject.Size = new System.Drawing.Size(218, 20);
            this.txtMailObject.TabIndex = 5;
            // 
            // btnMailSend
            // 
            this.btnMailSend.Location = new System.Drawing.Point(391, 415);
            this.btnMailSend.Name = "btnMailSend";
            this.btnMailSend.Size = new System.Drawing.Size(75, 23);
            this.btnMailSend.TabIndex = 6;
            this.btnMailSend.Text = "Gönder";
            this.btnMailSend.UseVisualStyleBackColor = true;
            this.btnMailSend.Click += new System.EventHandler(this.btnMailSend_Click);
            // 
            // MailSenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMailSend);
            this.Controls.Add(this.txtMailObject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rchTxtMailContent);
            this.Controls.Add(this.cmbBoxMailTo);
            this.Controls.Add(this.label1);
            this.Name = "MailSenderForm";
            this.Text = "MailSenderForm";
            this.Load += new System.EventHandler(this.MailSenderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxMailTo;
        private System.Windows.Forms.RichTextBox rchTxtMailContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMailObject;
        private System.Windows.Forms.Button btnMailSend;
    }
}