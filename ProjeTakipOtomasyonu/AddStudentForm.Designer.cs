namespace ProjeTakipOtomasyonu
{
    partial class AddStudentForm
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
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentSchoolNumber = new System.Windows.Forms.TextBox();
            this.txtStudentProjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.cmbBoxPeriodYear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBoxOgretimDurumu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxProgrammingLanguage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(22, 54);
            this.txtStudentName.MinimumSize = new System.Drawing.Size(200, 30);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(200, 20);
            this.txtStudentName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Okul Numarası";
            // 
            // txtStudentSchoolNumber
            // 
            this.txtStudentSchoolNumber.Location = new System.Drawing.Point(279, 54);
            this.txtStudentSchoolNumber.MinimumSize = new System.Drawing.Size(200, 30);
            this.txtStudentSchoolNumber.Name = "txtStudentSchoolNumber";
            this.txtStudentSchoolNumber.Size = new System.Drawing.Size(200, 20);
            this.txtStudentSchoolNumber.TabIndex = 2;
            // 
            // txtStudentProjectName
            // 
            this.txtStudentProjectName.Location = new System.Drawing.Point(22, 147);
            this.txtStudentProjectName.MinimumSize = new System.Drawing.Size(200, 30);
            this.txtStudentProjectName.Name = "txtStudentProjectName";
            this.txtStudentProjectName.Size = new System.Drawing.Size(200, 20);
            this.txtStudentProjectName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Proje Adı";
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaveStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveStudent.Location = new System.Drawing.Point(259, 326);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(132, 29);
            this.btnSaveStudent.TabIndex = 7;
            this.btnSaveStudent.Text = "Kaydet";
            this.btnSaveStudent.UseVisualStyleBackColor = true;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email Adresi";
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Location = new System.Drawing.Point(22, 326);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(197, 20);
            this.txtStudentEmail.TabIndex = 9;
            this.txtStudentEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // cmbBoxPeriodYear
            // 
            this.cmbBoxPeriodYear.FormattingEnabled = true;
            this.cmbBoxPeriodYear.Location = new System.Drawing.Point(22, 233);
            this.cmbBoxPeriodYear.Name = "cmbBoxPeriodYear";
            this.cmbBoxPeriodYear.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxPeriodYear.TabIndex = 10;
            this.cmbBoxPeriodYear.SelectedIndexChanged += new System.EventHandler(this.cmbBoxPeriodYear_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Öğretim Yılı";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Öğretim Durumu";
            // 
            // cmbBoxOgretimDurumu
            // 
            this.cmbBoxOgretimDurumu.FormattingEnabled = true;
            this.cmbBoxOgretimDurumu.Items.AddRange(new object[] {
            "1.Öğretim",
            "2.Öğretim"});
            this.cmbBoxOgretimDurumu.Location = new System.Drawing.Point(279, 233);
            this.cmbBoxOgretimDurumu.Name = "cmbBoxOgretimDurumu";
            this.cmbBoxOgretimDurumu.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxOgretimDurumu.TabIndex = 13;
            this.cmbBoxOgretimDurumu.SelectedIndexChanged += new System.EventHandler(this.cmbBoxOgretimDurumu_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Programlama Dili";
            // 
            // txtBoxProgrammingLanguage
            // 
            this.txtBoxProgrammingLanguage.Location = new System.Drawing.Point(279, 147);
            this.txtBoxProgrammingLanguage.MinimumSize = new System.Drawing.Size(200, 30);
            this.txtBoxProgrammingLanguage.Name = "txtBoxProgrammingLanguage";
            this.txtBoxProgrammingLanguage.Size = new System.Drawing.Size(200, 20);
            this.txtBoxProgrammingLanguage.TabIndex = 14;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 506);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxProgrammingLanguage);
            this.Controls.Add(this.cmbBoxOgretimDurumu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBoxPeriodYear);
            this.Controls.Add(this.txtStudentEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSaveStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStudentProjectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudentSchoolNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentName);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentSchoolNumber;
        private System.Windows.Forms.TextBox txtStudentProjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.ComboBox cmbBoxPeriodYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBoxOgretimDurumu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxProgrammingLanguage;
    }
}