namespace ProjeTakipOtomasyonu
{
    partial class StudentListForm
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnStudentSrc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxPeriodYear = new System.Windows.Forms.ComboBox();
            this.btnSaveStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(363, 158);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(102, 40);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Öğrencileri Ekle";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(2, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(352, 420);
            this.listBox1.TabIndex = 6;
            // 
            // btnStudentSrc
            // 
            this.btnStudentSrc.Location = new System.Drawing.Point(506, 17);
            this.btnStudentSrc.Name = "btnStudentSrc";
            this.btnStudentSrc.Size = new System.Drawing.Size(130, 23);
            this.btnStudentSrc.TabIndex = 7;
            this.btnStudentSrc.Text = "Öğrenci Kaynağı Seç";
            this.btnStudentSrc.UseVisualStyleBackColor = true;
            this.btnStudentSrc.Click += new System.EventHandler(this.btnStudentSrc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "___________________";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1. Öğretim",
            "2. Öğretim"});
            this.comboBox1.Location = new System.Drawing.Point(515, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Öğretim Durumu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Öğrenim Yılı";
            // 
            // cmbBoxPeriodYear
            // 
            this.cmbBoxPeriodYear.FormattingEnabled = true;
            this.cmbBoxPeriodYear.Location = new System.Drawing.Point(515, 106);
            this.cmbBoxPeriodYear.Name = "cmbBoxPeriodYear";
            this.cmbBoxPeriodYear.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxPeriodYear.TabIndex = 12;
            // 
            // btnSaveStudents
            // 
            this.btnSaveStudents.Enabled = false;
            this.btnSaveStudents.Location = new System.Drawing.Point(524, 158);
            this.btnSaveStudents.Name = "btnSaveStudents";
            this.btnSaveStudents.Size = new System.Drawing.Size(112, 40);
            this.btnSaveStudents.TabIndex = 13;
            this.btnSaveStudents.Text = "Kaydet";
            this.btnSaveStudents.UseVisualStyleBackColor = true;
            this.btnSaveStudents.Click += new System.EventHandler(this.btnSaveStudents_Click);
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.btnSaveStudents);
            this.Controls.Add(this.cmbBoxPeriodYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStudentSrc);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "StudentListForm";
            this.Text = "Öğrenci Listesi";
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnStudentSrc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBoxPeriodYear;
        private System.Windows.Forms.Button btnSaveStudents;
    }
}