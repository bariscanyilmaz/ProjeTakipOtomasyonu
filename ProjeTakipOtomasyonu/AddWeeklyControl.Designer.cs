namespace ProjeTakipOtomasyonu
{
    partial class AddWeeklyControl
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
            this.txtWeekName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveWeek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWeekName
            // 
            this.txtWeekName.Location = new System.Drawing.Point(69, 71);
            this.txtWeekName.MinimumSize = new System.Drawing.Size(200, 30);
            this.txtWeekName.Name = "txtWeekName";
            this.txtWeekName.Size = new System.Drawing.Size(200, 30);
            this.txtWeekName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hafta Adı Giriniz";
            // 
            // btnSaveWeek
            // 
            this.btnSaveWeek.Location = new System.Drawing.Point(69, 123);
            this.btnSaveWeek.Name = "btnSaveWeek";
            this.btnSaveWeek.Size = new System.Drawing.Size(98, 36);
            this.btnSaveWeek.TabIndex = 2;
            this.btnSaveWeek.Text = "Kaydet";
            this.btnSaveWeek.UseVisualStyleBackColor = true;
            this.btnSaveWeek.Click += new System.EventHandler(this.btnSaveWeek_Click);
            // 
            // AddWeeklyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 263);
            this.Controls.Add(this.btnSaveWeek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWeekName);
            this.Name = "AddWeeklyControl";
            this.Text = "AddWeeklyControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWeekName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveWeek;
    }
}