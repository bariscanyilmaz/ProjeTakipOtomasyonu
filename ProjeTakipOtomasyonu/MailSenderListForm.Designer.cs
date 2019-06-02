namespace ProjeTakipOtomasyonu
{
    partial class MailSenderListForm
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
            this.btnFilterStudentsOntbPageControl = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEducationYearOntbPageControl = new System.Windows.Forms.ComboBox();
            this.cmbOgretimDurumuOntbPageControl = new System.Windows.Forms.ComboBox();
            this.btnAddStudentToMailSendList = new System.Windows.Forms.Button();
            this.btnRemoveStudentFromMailSendList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveMailSendList = new System.Windows.Forms.Button();
            this.btnGetAllStudents = new System.Windows.Forms.Button();
            this.chcBoxStudentListBox = new System.Windows.Forms.CheckedListBox();
            this.chcBoxMailSendList = new System.Windows.Forms.CheckedListBox();
            this.btnClearMailSendList = new System.Windows.Forms.Button();
            this.btnAddAlltoMailSendList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFilterStudentsOntbPageControl
            // 
            this.btnFilterStudentsOntbPageControl.Location = new System.Drawing.Point(395, 175);
            this.btnFilterStudentsOntbPageControl.Name = "btnFilterStudentsOntbPageControl";
            this.btnFilterStudentsOntbPageControl.Size = new System.Drawing.Size(75, 23);
            this.btnFilterStudentsOntbPageControl.TabIndex = 29;
            this.btnFilterStudentsOntbPageControl.Text = "Filtrele";
            this.btnFilterStudentsOntbPageControl.UseVisualStyleBackColor = true;
            this.btnFilterStudentsOntbPageControl.Click += new System.EventHandler(this.btnFilterStudentsOntbPageControl_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(248, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Dönem Yılı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Öğretim Durumu";
            // 
            // cmbEducationYearOntbPageControl
            // 
            this.cmbEducationYearOntbPageControl.FormattingEnabled = true;
            this.cmbEducationYearOntbPageControl.Location = new System.Drawing.Point(349, 121);
            this.cmbEducationYearOntbPageControl.Name = "cmbEducationYearOntbPageControl";
            this.cmbEducationYearOntbPageControl.Size = new System.Drawing.Size(121, 21);
            this.cmbEducationYearOntbPageControl.TabIndex = 26;
            // 
            // cmbOgretimDurumuOntbPageControl
            // 
            this.cmbOgretimDurumuOntbPageControl.FormattingEnabled = true;
            this.cmbOgretimDurumuOntbPageControl.Items.AddRange(new object[] {
            "1.Öğretim",
            "2.Öğretim"});
            this.cmbOgretimDurumuOntbPageControl.Location = new System.Drawing.Point(349, 79);
            this.cmbOgretimDurumuOntbPageControl.Name = "cmbOgretimDurumuOntbPageControl";
            this.cmbOgretimDurumuOntbPageControl.Size = new System.Drawing.Size(121, 21);
            this.cmbOgretimDurumuOntbPageControl.TabIndex = 25;
            // 
            // btnAddStudentToMailSendList
            // 
            this.btnAddStudentToMailSendList.Location = new System.Drawing.Point(256, 269);
            this.btnAddStudentToMailSendList.Name = "btnAddStudentToMailSendList";
            this.btnAddStudentToMailSendList.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudentToMailSendList.TabIndex = 30;
            this.btnAddStudentToMailSendList.Text = "Listeye Ekle";
            this.btnAddStudentToMailSendList.UseVisualStyleBackColor = true;
            this.btnAddStudentToMailSendList.Click += new System.EventHandler(this.btnAddStudentToMailSendList_Click);
            // 
            // btnRemoveStudentFromMailSendList
            // 
            this.btnRemoveStudentFromMailSendList.Location = new System.Drawing.Point(379, 269);
            this.btnRemoveStudentFromMailSendList.Name = "btnRemoveStudentFromMailSendList";
            this.btnRemoveStudentFromMailSendList.Size = new System.Drawing.Size(91, 23);
            this.btnRemoveStudentFromMailSendList.TabIndex = 31;
            this.btnRemoveStudentFromMailSendList.Text = "Listeden Çıkar";
            this.btnRemoveStudentFromMailSendList.UseVisualStyleBackColor = true;
            this.btnRemoveStudentFromMailSendList.Click += new System.EventHandler(this.btnRemoveStudentFromMailSendList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Öğrenciler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Gönderilen Listesi";
            // 
            // btnSaveMailSendList
            // 
            this.btnSaveMailSendList.Location = new System.Drawing.Point(395, 320);
            this.btnSaveMailSendList.Name = "btnSaveMailSendList";
            this.btnSaveMailSendList.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMailSendList.TabIndex = 36;
            this.btnSaveMailSendList.Text = "Kaydet";
            this.btnSaveMailSendList.UseVisualStyleBackColor = true;
            this.btnSaveMailSendList.Click += new System.EventHandler(this.btnSaveMailSendList_Click);
            // 
            // btnGetAllStudents
            // 
            this.btnGetAllStudents.Location = new System.Drawing.Point(256, 175);
            this.btnGetAllStudents.Name = "btnGetAllStudents";
            this.btnGetAllStudents.Size = new System.Drawing.Size(75, 23);
            this.btnGetAllStudents.TabIndex = 37;
            this.btnGetAllStudents.Text = "Hepsini Getir";
            this.btnGetAllStudents.UseVisualStyleBackColor = true;
            this.btnGetAllStudents.Click += new System.EventHandler(this.btnGetAllStudents_Click);
            // 
            // chcBoxStudentListBox
            // 
            this.chcBoxStudentListBox.FormattingEnabled = true;
            this.chcBoxStudentListBox.Location = new System.Drawing.Point(10, 79);
            this.chcBoxStudentListBox.Name = "chcBoxStudentListBox";
            this.chcBoxStudentListBox.Size = new System.Drawing.Size(230, 364);
            this.chcBoxStudentListBox.TabIndex = 38;
            // 
            // chcBoxMailSendList
            // 
            this.chcBoxMailSendList.FormattingEnabled = true;
            this.chcBoxMailSendList.Location = new System.Drawing.Point(508, 79);
            this.chcBoxMailSendList.Name = "chcBoxMailSendList";
            this.chcBoxMailSendList.Size = new System.Drawing.Size(245, 364);
            this.chcBoxMailSendList.TabIndex = 39;
            // 
            // btnClearMailSendList
            // 
            this.btnClearMailSendList.Location = new System.Drawing.Point(375, 219);
            this.btnClearMailSendList.Name = "btnClearMailSendList";
            this.btnClearMailSendList.Size = new System.Drawing.Size(95, 23);
            this.btnClearMailSendList.TabIndex = 40;
            this.btnClearMailSendList.Text = "Listeyi Temizle";
            this.btnClearMailSendList.UseVisualStyleBackColor = true;
            this.btnClearMailSendList.Click += new System.EventHandler(this.btnClearMailSendList_Click);
            // 
            // btnAddAlltoMailSendList
            // 
            this.btnAddAlltoMailSendList.Location = new System.Drawing.Point(256, 219);
            this.btnAddAlltoMailSendList.Name = "btnAddAlltoMailSendList";
            this.btnAddAlltoMailSendList.Size = new System.Drawing.Size(75, 23);
            this.btnAddAlltoMailSendList.TabIndex = 41;
            this.btnAddAlltoMailSendList.Text = "Hepsini Ekle";
            this.btnAddAlltoMailSendList.UseVisualStyleBackColor = true;
            this.btnAddAlltoMailSendList.Click += new System.EventHandler(this.btnAddAlltoMailSendList_Click);
            // 
            // MailSenderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.btnAddAlltoMailSendList);
            this.Controls.Add(this.btnClearMailSendList);
            this.Controls.Add(this.chcBoxMailSendList);
            this.Controls.Add(this.chcBoxStudentListBox);
            this.Controls.Add(this.btnGetAllStudents);
            this.Controls.Add(this.btnSaveMailSendList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemoveStudentFromMailSendList);
            this.Controls.Add(this.btnAddStudentToMailSendList);
            this.Controls.Add(this.btnFilterStudentsOntbPageControl);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEducationYearOntbPageControl);
            this.Controls.Add(this.cmbOgretimDurumuOntbPageControl);
            this.Name = "MailSenderListForm";
            this.Text = "MailSenderListForm";
            this.Load += new System.EventHandler(this.MailSenderListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFilterStudentsOntbPageControl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEducationYearOntbPageControl;
        private System.Windows.Forms.ComboBox cmbOgretimDurumuOntbPageControl;
        private System.Windows.Forms.Button btnAddStudentToMailSendList;
        private System.Windows.Forms.Button btnRemoveStudentFromMailSendList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveMailSendList;
        private System.Windows.Forms.Button btnGetAllStudents;
        private System.Windows.Forms.CheckedListBox chcBoxStudentListBox;
        private System.Windows.Forms.CheckedListBox chcBoxMailSendList;
        private System.Windows.Forms.Button btnClearMailSendList;
        private System.Windows.Forms.Button btnAddAlltoMailSendList;
    }
}