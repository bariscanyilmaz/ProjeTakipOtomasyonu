namespace ProjeTakipOtomasyonu
{
    partial class AddNoteForm
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
            this.rchBoxContentNewNote = new System.Windows.Forms.RichTextBox();
            this.btnSaveNewNote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rchBoxContentNewNote
            // 
            this.rchBoxContentNewNote.Location = new System.Drawing.Point(12, 76);
            this.rchBoxContentNewNote.Name = "rchBoxContentNewNote";
            this.rchBoxContentNewNote.Size = new System.Drawing.Size(338, 341);
            this.rchBoxContentNewNote.TabIndex = 1;
            this.rchBoxContentNewNote.Text = "";
            // 
            // btnSaveNewNote
            // 
            this.btnSaveNewNote.Location = new System.Drawing.Point(127, 423);
            this.btnSaveNewNote.Name = "btnSaveNewNote";
            this.btnSaveNewNote.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNewNote.TabIndex = 2;
            this.btnSaveNewNote.Text = "Kaydet";
            this.btnSaveNewNote.UseVisualStyleBackColor = true;
            this.btnSaveNewNote.Click += new System.EventHandler(this.btnSaveNewNote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğrenci";
            // 
            // txtStudentInfo
            // 
            this.txtStudentInfo.Enabled = false;
            this.txtStudentInfo.Location = new System.Drawing.Point(186, 31);
            this.txtStudentInfo.Name = "txtStudentInfo";
            this.txtStudentInfo.Size = new System.Drawing.Size(164, 20);
            this.txtStudentInfo.TabIndex = 4;
            // 
            // AddNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.txtStudentInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveNewNote);
            this.Controls.Add(this.rchBoxContentNewNote);
            this.Name = "AddNoteForm";
            this.Text = "AddNoteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rchBoxContentNewNote;
        private System.Windows.Forms.Button btnSaveNewNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentInfo;
    }
}