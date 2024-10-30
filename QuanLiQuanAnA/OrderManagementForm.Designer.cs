namespace QuanLiQuanAnA
{
    partial class OrderManagementForm
    {
        private System.Windows.Forms.ComboBox cbFoodItems;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalText;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManagementForm));
            this.cbFoodItems = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.cbFoodCategories = new System.Windows.Forms.ComboBox();
            this.flpTables = new System.Windows.Forms.FlowLayoutPanel();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtKhachHangId = new System.Windows.Forms.TextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbMomo = new System.Windows.Forms.RadioButton();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.txtNhapMaDonHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFoodItems
            // 
            this.cbFoodItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoodItems.Font = new System.Drawing.Font("SVN-Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFoodItems.FormattingEnabled = true;
            this.cbFoodItems.Location = new System.Drawing.Point(1162, 96);
            this.cbFoodItems.Margin = new System.Windows.Forms.Padding(2);
            this.cbFoodItems.Name = "cbFoodItems";
            this.cbFoodItems.Size = new System.Drawing.Size(236, 29);
            this.cbFoodItems.TabIndex = 1;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("SVN-Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(8, 93);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(45, 32);
            this.nudQuantity.TabIndex = 2;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetails.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Location = new System.Drawing.Point(665, 60);
            this.dgvOrderDetails.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.ReadOnly = true;
            this.dgvOrderDetails.RowTemplate.Height = 24;
            this.dgvOrderDetails.Size = new System.Drawing.Size(472, 449);
            this.dgvOrderDetails.TabIndex = 3;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAddToOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddToOrder.FlatAppearance.BorderSize = 0;
            this.btnAddToOrder.Font = new System.Drawing.Font("SVN-Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.Location = new System.Drawing.Point(1306, 139);
            this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(92, 58);
            this.btnAddToOrder.TabIndex = 4;
            this.btnAddToOrder.Text = "Thêm Món";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSaveOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveOrder.FlatAppearance.BorderSize = 0;
            this.btnSaveOrder.Font = new System.Drawing.Font("SVN-Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrder.Location = new System.Drawing.Point(1016, 519);
            this.btnSaveOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(121, 56);
            this.btnSaveOrder.TabIndex = 5;
            this.btnSaveOrder.Text = "Lưu Đơn";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("SVN-Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(664, 560);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(72, 27);
            this.lblTotalAmount.TabIndex = 7;
            this.lblTotalAmount.Text = "0 VND";
            // 
            // lblTotalText
            // 
            this.lblTotalText.AutoSize = true;
            this.lblTotalText.Font = new System.Drawing.Font("SVN-Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalText.Location = new System.Drawing.Point(661, 526);
            this.lblTotalText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(89, 24);
            this.lblTotalText.TabIndex = 6;
            this.lblTotalText.Text = "Tổng tiền:";
            // 
            // cbFoodCategories
            // 
            this.cbFoodCategories.Font = new System.Drawing.Font("SVN-Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFoodCategories.FormattingEnabled = true;
            this.cbFoodCategories.Location = new System.Drawing.Point(1162, 60);
            this.cbFoodCategories.Name = "cbFoodCategories";
            this.cbFoodCategories.Size = new System.Drawing.Size(236, 29);
            this.cbFoodCategories.TabIndex = 8;
            // 
            // flpTables
            // 
            this.flpTables.BackColor = System.Drawing.Color.Linen;
            this.flpTables.Location = new System.Drawing.Point(24, 30);
            this.flpTables.Name = "flpTables";
            this.flpTables.Size = new System.Drawing.Size(609, 724);
            this.flpTables.TabIndex = 10;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Font = new System.Drawing.Font("SVN-Product Sans", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderId.Location = new System.Drawing.Point(1037, 30);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(100, 24);
            this.txtOrderId.TabIndex = 11;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("SVN-Product Sans", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(746, 30);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(197, 24);
            this.txtCustomerName.TabIndex = 12;
            // 
            // txtKhachHangId
            // 
            this.txtKhachHangId.Location = new System.Drawing.Point(-2, -2);
            this.txtKhachHangId.Name = "txtKhachHangId";
            this.txtKhachHangId.Size = new System.Drawing.Size(17, 20);
            this.txtKhachHangId.TabIndex = 13;
            this.txtKhachHangId.Visible = false;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.Font = new System.Drawing.Font("SVN-Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(1323, 258);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 80);
            this.btnPayment.TabIndex = 14;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.BackColor = System.Drawing.Color.OldLace;
            this.rbCash.Font = new System.Drawing.Font("SVN-Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCash.Location = new System.Drawing.Point(1162, 292);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(98, 28);
            this.rbCash.TabIndex = 15;
            this.rbCash.Text = "Tiền mặt";
            this.rbCash.UseVisualStyleBackColor = false;
            // 
            // rbMomo
            // 
            this.rbMomo.AutoSize = true;
            this.rbMomo.BackColor = System.Drawing.Color.OldLace;
            this.rbMomo.Checked = true;
            this.rbMomo.Font = new System.Drawing.Font("SVN-Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMomo.Location = new System.Drawing.Point(1162, 258);
            this.rbMomo.Name = "rbMomo";
            this.rbMomo.Size = new System.Drawing.Size(145, 28);
            this.rbMomo.TabIndex = 16;
            this.rbMomo.TabStop = true;
            this.rbMomo.Text = "Chuyển khoản";
            this.rbMomo.UseVisualStyleBackColor = false;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnPrintReceipt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPrintReceipt.FlatAppearance.BorderSize = 0;
            this.btnPrintReceipt.Font = new System.Drawing.Font("SVN-Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReceipt.Location = new System.Drawing.Point(1323, 394);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(75, 75);
            this.btnPrintReceipt.TabIndex = 17;
            this.btnPrintReceipt.Text = "In hóa đơn";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click_1);
            // 
            // txtNhapMaDonHang
            // 
            this.txtNhapMaDonHang.Font = new System.Drawing.Font("SVN-Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapMaDonHang.Location = new System.Drawing.Point(8, 34);
            this.txtNhapMaDonHang.Name = "txtNhapMaDonHang";
            this.txtNhapMaDonHang.Size = new System.Drawing.Size(145, 32);
            this.txtNhapMaDonHang.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SVN-Product Sans", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(665, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SVN-Product Sans", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1000, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Đơn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.nudQuantity);
            this.panel1.Location = new System.Drawing.Point(1154, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 170);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Location = new System.Drawing.Point(1154, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 125);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtNhapMaDonHang);
            this.panel3.Location = new System.Drawing.Point(1154, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 125);
            this.panel3.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SVN-Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nhập số hóa đơn";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(1241, 609);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(177, 151);
            this.panel4.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OrderManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1430, 772);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.rbMomo);
            this.Controls.Add(this.rbCash);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.txtKhachHangId);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.flpTables);
            this.Controls.Add(this.cbFoodCategories);
            this.Controls.Add(this.cbFoodItems);
            this.Controls.Add(this.dgvOrderDetails);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.lblTotalText);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderManagementForm";
            this.Text = "Quản Lý Đơn Hàng";
            this.Load += new System.EventHandler(this.OrderManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFoodCategories;
        private System.Windows.Forms.FlowLayoutPanel flpTables;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtKhachHangId;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbMomo;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.TextBox txtNhapMaDonHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}