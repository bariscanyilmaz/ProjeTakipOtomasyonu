namespace ProjeTakipOtomasyonu
{
    partial class AddWeeklyControlSubItem
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
            this.txtWeeklyControlName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.chcBoxFirstTeaching = new System.Windows.Forms.CheckBox();
            this.btnSaveWeeklyControl = new System.Windows.Forms.Button();
            this.dtPickerCurrentNotesTime = new System.Windows.Forms.DateTimePicker();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnWeeklyTracking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWeeklyControlName
            // 
            this.txtWeeklyControlName.Location = new System.Drawing.Point(53, 26);
            this.txtWeeklyControlName.MinimumSize = new System.Drawing.Size(200, 30);
            this.txtWeeklyControlName.Name = "txtWeeklyControlName";
            this.txtWeeklyControlName.Size = new System.Drawing.Size(200, 20);
            this.txtWeeklyControlName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kontrol Edilen Haftayı Giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kontrol Edilecek Öğrenciler";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(53, 104);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(253, 319);
            this.checkedListBox1.TabIndex = 3;
            // 
            // chcBoxFirstTeaching
            // 
            this.chcBoxFirstTeaching.AutoSize = true;
            this.chcBoxFirstTeaching.Checked = true;
            this.chcBoxFirstTeaching.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcBoxFirstTeaching.Location = new System.Drawing.Point(206, 76);
            this.chcBoxFirstTeaching.Name = "chcBoxFirstTeaching";
            this.chcBoxFirstTeaching.Size = new System.Drawing.Size(112, 17);
            this.chcBoxFirstTeaching.TabIndex = 4;
            this.chcBoxFirstTeaching.Text = "Birinci Öğretim mi?";
            this.chcBoxFirstTeaching.UseVisualStyleBackColor = true;
            // 
            // btnSaveWeeklyControl
            // 
            this.btnSaveWeeklyControl.Location = new System.Drawing.Point(129, 450);
            this.btnSaveWeeklyControl.Name = "btnSaveWeeklyControl";
            this.btnSaveWeeklyControl.Size = new System.Drawing.Size(75, 23);
            this.btnSaveWeeklyControl.TabIndex = 5;
            this.btnSaveWeeklyControl.Text = "Kaydet";
            this.btnSaveWeeklyControl.UseVisualStyleBackColor = true;
            this.btnSaveWeeklyControl.Click += new System.EventHandler(this.btnSaveWeeklyControl_Click);
            // 
            // dtPickerCurrentNotesTime
            // 
            this.dtPickerCurrentNotesTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerCurrentNotesTime.Location = new System.Drawing.Point(388, 105);
            this.dtPickerCurrentNotesTime.Name = "dtPickerCurrentNotesTime";
            this.dtPickerCurrentNotesTime.Size = new System.Drawing.Size(200, 20);
            this.dtPickerCurrentNotesTime.TabIndex = 14;
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(495, 283);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(75, 23);
            this.btnAddNote.TabIndex = 15;
            this.btnAddNote.Text = "Not Ekle";
            this.btnAddNote.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Notlar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNote
            // 
            this.txtNote.Enabled = false;
            this.txtNote.Location = new System.Drawing.Point(388, 135);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(271, 133);
            this.txtNote.TabIndex = 16;
            // 
            // btnWeeklyTracking
            // 
            this.btnWeeklyTracking.Location = new System.Drawing.Point(546, 338);
            this.btnWeeklyTracking.Name = "btnWeeklyTracking";
            this.btnWeeklyTracking.Size = new System.Drawing.Size(113, 63);
            this.btnWeeklyTracking.TabIndex = 12;
            this.btnWeeklyTracking.Text = "Haftalık Takip";
            this.btnWeeklyTracking.UseVisualStyleBackColor = true;
            // 
            // AddWeeklyControlSubItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.dtPickerCurrentNotesTime);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnWeeklyTracking);
            this.Controls.Add(this.btnSaveWeeklyControl);
            this.Controls.Add(this.chcBoxFirstTeaching);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWeeklyControlName);
            this.Name = "AddWeeklyControlSubItem";
            this.Text = "AddWeeklyControl";
            this.Load += new System.EventHandler(this.AddWeeklyControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWeeklyControlName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox chcBoxFirstTeaching;
        private System.Windows.Forms.Button btnSaveWeeklyControl;
        private System.Windows.Forms.DateTimePicker dtPickerCurrentNotesTime;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnWeeklyTracking;
    }
}