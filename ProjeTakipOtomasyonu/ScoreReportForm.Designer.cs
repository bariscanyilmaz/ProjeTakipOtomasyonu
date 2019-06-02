namespace ProjeTakipOtomasyonu
{
    partial class ScoreReportForm
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
            this.grdViewScoreReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewScoreReport)).BeginInit();
            this.SuspendLayout();
            // 
            // grdViewScoreReport
            // 
            this.grdViewScoreReport.AllowUserToAddRows = false;
            this.grdViewScoreReport.AllowUserToDeleteRows = false;
            this.grdViewScoreReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewScoreReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewScoreReport.Location = new System.Drawing.Point(0, 0);
            this.grdViewScoreReport.Name = "grdViewScoreReport";
            this.grdViewScoreReport.ReadOnly = true;
            this.grdViewScoreReport.Size = new System.Drawing.Size(800, 450);
            this.grdViewScoreReport.TabIndex = 0;
            // 
            // ScoreReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdViewScoreReport);
            this.Name = "ScoreReportForm";
            this.Text = "ScoreReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.grdViewScoreReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdViewScoreReport;
    }
}