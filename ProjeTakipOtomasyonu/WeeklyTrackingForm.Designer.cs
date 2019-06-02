namespace ProjeTakipOtomasyonu
{
    partial class WeeklyTrackingForm
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
            this.listBoxWeek = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chcListBoxSubItems = new System.Windows.Forms.CheckedListBox();
            this.btnAddKontrolHafta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxWeek
            // 
            this.listBoxWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxWeek.FormattingEnabled = true;
            this.listBoxWeek.ItemHeight = 20;
            this.listBoxWeek.Location = new System.Drawing.Point(1, 52);
            this.listBoxWeek.Name = "listBoxWeek";
            this.listBoxWeek.Size = new System.Drawing.Size(177, 384);
            this.listBoxWeek.TabIndex = 0;
            this.listBoxWeek.SelectedValueChanged += new System.EventHandler(this.listBoxWeek_SelectedValueChanged);
            this.listBoxWeek.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxWeek_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kontrol Edilecek Haftalar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kontrol Edilen Öğrenciler";
            // 
            // chcListBoxSubItems
            // 
            this.chcListBoxSubItems.FormattingEnabled = true;
            this.chcListBoxSubItems.Location = new System.Drawing.Point(473, 52);
            this.chcListBoxSubItems.Name = "chcListBoxSubItems";
            this.chcListBoxSubItems.Size = new System.Drawing.Size(315, 379);
            this.chcListBoxSubItems.TabIndex = 7;
            // 
            // btnAddKontrolHafta
            // 
            this.btnAddKontrolHafta.Location = new System.Drawing.Point(205, 174);
            this.btnAddKontrolHafta.Name = "btnAddKontrolHafta";
            this.btnAddKontrolHafta.Size = new System.Drawing.Size(181, 23);
            this.btnAddKontrolHafta.TabIndex = 8;
            this.btnAddKontrolHafta.Text = "Kontorl Edilen Hafta Ekle";
            this.btnAddKontrolHafta.UseVisualStyleBackColor = true;
            this.btnAddKontrolHafta.Click += new System.EventHandler(this.btnAddKontrolHafta_Click);
            // 
            // WeeklyTrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddKontrolHafta);
            this.Controls.Add(this.chcListBoxSubItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxWeek);
            this.Name = "WeeklyTrackingForm";
            this.Text = "WeeklyTrackingForm";
            this.Load += new System.EventHandler(this.WeeklyTrackingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWeek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chcListBoxSubItems;
        private System.Windows.Forms.Button btnAddKontrolHafta;
    }
}