namespace QuanLiQuanAnA
{
    partial class frmPaymentHistory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentHistory));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDonHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhThucThanhToanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThanhToanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhToanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLIQUANANDBDataSet = new QuanLiQuanAnA.QUANLIQUANANDBDataSet();
            this.thanhToanTableAdapter = new QuanLiQuanAnA.QUANLIQUANANDBDataSetTableAdapters.ThanhToanTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.donHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donHangTableAdapter = new QuanLiQuanAnA.QUANLIQUANANDBDataSetTableAdapters.DonHangTableAdapter();
            this.chiTietDonHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietDonHangTableAdapter = new QuanLiQuanAnA.QUANLIQUANANDBDataSetTableAdapters.ChiTietDonHangTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpStart1 = new System.Windows.Forms.DateTimePicker();
            this.dtpStart2 = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd2 = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhToanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLIQUANANDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donHangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idDonHangDataGridViewTextBoxColumn,
            this.hinhThucThanhToanDataGridViewTextBoxColumn,
            this.ngayThanhToanDataGridViewTextBoxColumn,
            this.soTienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.thanhToanBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(612, 626);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDonHangDataGridViewTextBoxColumn
            // 
            this.idDonHangDataGridViewTextBoxColumn.DataPropertyName = "IdDonHang";
            this.idDonHangDataGridViewTextBoxColumn.HeaderText = "IdDonHang";
            this.idDonHangDataGridViewTextBoxColumn.Name = "idDonHangDataGridViewTextBoxColumn";
            this.idDonHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hinhThucThanhToanDataGridViewTextBoxColumn
            // 
            this.hinhThucThanhToanDataGridViewTextBoxColumn.DataPropertyName = "HinhThucThanhToan";
            this.hinhThucThanhToanDataGridViewTextBoxColumn.HeaderText = "HinhThucThanhToan";
            this.hinhThucThanhToanDataGridViewTextBoxColumn.Name = "hinhThucThanhToanDataGridViewTextBoxColumn";
            this.hinhThucThanhToanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayThanhToanDataGridViewTextBoxColumn
            // 
            this.ngayThanhToanDataGridViewTextBoxColumn.DataPropertyName = "NgayThanhToan";
            this.ngayThanhToanDataGridViewTextBoxColumn.HeaderText = "NgayThanhToan";
            this.ngayThanhToanDataGridViewTextBoxColumn.Name = "ngayThanhToanDataGridViewTextBoxColumn";
            this.ngayThanhToanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soTienDataGridViewTextBoxColumn
            // 
            this.soTienDataGridViewTextBoxColumn.DataPropertyName = "SoTien";
            this.soTienDataGridViewTextBoxColumn.HeaderText = "SoTien";
            this.soTienDataGridViewTextBoxColumn.Name = "soTienDataGridViewTextBoxColumn";
            this.soTienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thanhToanBindingSource
            // 
            this.thanhToanBindingSource.DataMember = "ThanhToan";
            this.thanhToanBindingSource.DataSource = this.qUANLIQUANANDBDataSet;
            // 
            // qUANLIQUANANDBDataSet
            // 
            this.qUANLIQUANANDBDataSet.DataSetName = "QUANLIQUANANDBDataSet";
            this.qUANLIQUANANDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thanhToanTableAdapter
            // 
            this.thanhToanTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.idBanDataGridViewTextBoxColumn,
            this.idKhachHangDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.donHangBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(651, 96);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(643, 626);
            this.dataGridView2.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idBanDataGridViewTextBoxColumn
            // 
            this.idBanDataGridViewTextBoxColumn.DataPropertyName = "IdBan";
            this.idBanDataGridViewTextBoxColumn.HeaderText = "IdBan";
            this.idBanDataGridViewTextBoxColumn.Name = "idBanDataGridViewTextBoxColumn";
            this.idBanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idKhachHangDataGridViewTextBoxColumn
            // 
            this.idKhachHangDataGridViewTextBoxColumn.DataPropertyName = "IdKhachHang";
            this.idKhachHangDataGridViewTextBoxColumn.HeaderText = "IdKhachHang";
            this.idKhachHangDataGridViewTextBoxColumn.Name = "idKhachHangDataGridViewTextBoxColumn";
            this.idKhachHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            this.ngayLapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donHangBindingSource1
            // 
            this.donHangBindingSource1.DataMember = "DonHang";
            this.donHangBindingSource1.DataSource = this.qUANLIQUANANDBDataSet;
            // 
            // donHangBindingSource
            // 
            this.donHangBindingSource.DataMember = "DonHang";
            this.donHangBindingSource.DataSource = this.qUANLIQUANANDBDataSet;
            // 
            // donHangTableAdapter
            // 
            this.donHangTableAdapter.ClearBeforeFill = true;
            // 
            // chiTietDonHangBindingSource
            // 
            this.chiTietDonHangBindingSource.DataMember = "ChiTietDonHang";
            this.chiTietDonHangBindingSource.DataSource = this.qUANLIQUANANDBDataSet;
            // 
            // chiTietDonHangTableAdapter
            // 
            this.chiTietDonHangTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SVN-Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lịch sử thanh toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SVN-Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(905, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách đơn hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1253, 681);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dtpStart1
            // 
            this.dtpStart1.Font = new System.Drawing.Font("SVN-Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart1.Location = new System.Drawing.Point(12, 759);
            this.dtpStart1.Name = "dtpStart1";
            this.dtpStart1.Size = new System.Drawing.Size(282, 28);
            this.dtpStart1.TabIndex = 5;
            this.dtpStart1.ValueChanged += new System.EventHandler(this.dtpStart1_ValueChanged);
            // 
            // dtpStart2
            // 
            this.dtpStart2.Font = new System.Drawing.Font("SVN-Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart2.Location = new System.Drawing.Point(651, 759);
            this.dtpStart2.Name = "dtpStart2";
            this.dtpStart2.Size = new System.Drawing.Size(282, 28);
            this.dtpStart2.TabIndex = 6;
            this.dtpStart2.ValueChanged += new System.EventHandler(this.dtpStart2_ValueChanged);
            // 
            // dtpEnd2
            // 
            this.dtpEnd2.Font = new System.Drawing.Font("SVN-Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd2.Location = new System.Drawing.Point(965, 759);
            this.dtpEnd2.Name = "dtpEnd2";
            this.dtpEnd2.Size = new System.Drawing.Size(282, 28);
            this.dtpEnd2.TabIndex = 7;
            this.dtpEnd2.ValueChanged += new System.EventHandler(this.dtpEnd2_ValueChanged);
            // 
            // dtpEnd1
            // 
            this.dtpEnd1.Font = new System.Drawing.Font("SVN-Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd1.Location = new System.Drawing.Point(342, 759);
            this.dtpEnd1.Name = "dtpEnd1";
            this.dtpEnd1.Size = new System.Drawing.Size(282, 28);
            this.dtpEnd1.TabIndex = 8;
            this.dtpEnd1.ValueChanged += new System.EventHandler(this.dtpEnd1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SVN-Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 725);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Từ ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SVN-Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(647, 725);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Từ ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SVN-Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(537, 725);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Đến ngày";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("SVN-Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(1160, 725);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(87, 24);
            this.label54.TabIndex = 12;
            this.label54.Text = "Đến ngày";
            // 
            // frmPaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1497, 969);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpEnd1);
            this.Controls.Add(this.dtpEnd2);
            this.Controls.Add(this.dtpStart2);
            this.Controls.Add(this.dtpStart1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPaymentHistory";
            this.Text = "frmPaymentHistory";
            this.Load += new System.EventHandler(this.frmPaymentHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhToanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLIQUANANDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donHangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QUANLIQUANANDBDataSet qUANLIQUANANDBDataSet;
        private System.Windows.Forms.BindingSource thanhToanBindingSource;
        private QUANLIQUANANDBDataSetTableAdapters.ThanhToanTableAdapter thanhToanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDonHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhThucThanhToanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThanhToanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource donHangBindingSource;
        private QUANLIQUANANDBDataSetTableAdapters.DonHangTableAdapter donHangTableAdapter;
        private System.Windows.Forms.BindingSource chiTietDonHangBindingSource;
        private QUANLIQUANANDBDataSetTableAdapters.ChiTietDonHangTableAdapter chiTietDonHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource donHangBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpStart1;
        private System.Windows.Forms.DateTimePicker dtpStart2;
        private System.Windows.Forms.DateTimePicker dtpEnd2;
        private System.Windows.Forms.DateTimePicker dtpEnd1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label54;
    }
}