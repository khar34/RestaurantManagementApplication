namespace QuanLiQuanAnA
{
    partial class frmBaoCaoDoanhThu
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
            this.lblThang = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.numThang = new System.Windows.Forms.NumericUpDown();
            this.numNam = new System.Windows.Forms.NumericUpDown();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnDisplayReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(45, 48);
            this.lblThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(58, 21);
            this.lblThang.TabIndex = 0;
            this.lblThang.Text = "Tháng:";
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(45, 113);
            this.lblNam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(47, 21);
            this.lblNam.TabIndex = 1;
            this.lblNam.Text = "Năm:";
            // 
            // numThang
            // 
            this.numThang.Location = new System.Drawing.Point(150, 48);
            this.numThang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThang.Name = "numThang";
            this.numThang.Size = new System.Drawing.Size(180, 28);
            this.numThang.TabIndex = 2;
            this.numThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numNam
            // 
            this.numNam.Location = new System.Drawing.Point(150, 113);
            this.numNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numNam.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numNam.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numNam.Name = "numNam";
            this.numNam.Size = new System.Drawing.Size(180, 28);
            this.numNam.TabIndex = 3;
            this.numNam.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(45, 178);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(285, 48);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Tạo Báo Cáo";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnDisplayReport
            // 
            this.btnDisplayReport.Location = new System.Drawing.Point(45, 242);
            this.btnDisplayReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisplayReport.Name = "btnDisplayReport";
            this.btnDisplayReport.Size = new System.Drawing.Size(285, 48);
            this.btnDisplayReport.TabIndex = 5;
            this.btnDisplayReport.Text = "Hiển Thị Báo Cáo";
            this.btnDisplayReport.UseVisualStyleBackColor = true;
            this.btnDisplayReport.Click += new System.EventHandler(this.btnDisplayReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(45, 312);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(285, 48);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(373, 385);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplayReport);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.numNam);
            this.Controls.Add(this.numThang);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.lblThang);
            this.Font = new System.Drawing.Font("SVN-Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBaoCaoDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Doanh Thu";
            ((System.ComponentModel.ISupportInitialize)(this.numThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.NumericUpDown numThang;
        private System.Windows.Forms.NumericUpDown numNam;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnDisplayReport;
        private System.Windows.Forms.Button btnExit;
    }
}