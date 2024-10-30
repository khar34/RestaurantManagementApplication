namespace QuanLiQuanAnA
{
    partial class TableManagementForm
    {
        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label lblTableName;
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
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTables
            // 
            this.dgvTables.AllowUserToAddRows = false;
            this.dgvTables.AllowUserToDeleteRows = false;
            this.dgvTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTables.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Location = new System.Drawing.Point(22, 57);
            this.dgvTables.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.ReadOnly = true;
            this.dgvTables.Size = new System.Drawing.Size(679, 492);
            this.dgvTables.TabIndex = 0;
            this.dgvTables.SelectionChanged += new System.EventHandler(this.dgvTables_SelectionChanged);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Font = new System.Drawing.Font("SVN-Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTable.Location = new System.Drawing.Point(42, 132);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(75, 62);
            this.btnAddTable.TabIndex = 1;
            this.btnAddTable.Text = "Thêm Bàn";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // btnEditTable
            // 
            this.btnEditTable.Font = new System.Drawing.Font("SVN-Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTable.Location = new System.Drawing.Point(156, 132);
            this.btnEditTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(75, 62);
            this.btnEditTable.TabIndex = 2;
            this.btnEditTable.Text = "Sửa Bàn";
            this.btnEditTable.UseVisualStyleBackColor = true;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Font = new System.Drawing.Font("SVN-Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTable.Location = new System.Drawing.Point(42, 220);
            this.btnDeleteTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(75, 60);
            this.btnDeleteTable.TabIndex = 3;
            this.btnDeleteTable.Text = "Xóa Bàn";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // txtTableName
            // 
            this.txtTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableName.Location = new System.Drawing.Point(44, 81);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(2);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(133, 29);
            this.txtTableName.TabIndex = 4;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("SVN-Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(40, 55);
            this.lblTableName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(77, 24);
            this.lblTableName.TabIndex = 5;
            this.lblTableName.Text = "Tên Bàn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTableName);
            this.groupBox1.Controls.Add(this.lblTableName);
            this.groupBox1.Controls.Add(this.btnEditTable);
            this.groupBox1.Controls.Add(this.btnDeleteTable);
            this.groupBox1.Controls.Add(this.btnAddTable);
            this.groupBox1.Location = new System.Drawing.Point(722, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 308);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("SVN-Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(932, 530);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SVN-Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản lí bàn";
            // 
            // TableManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1019, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TableManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bàn";
            this.Load += new System.EventHandler(this.TableManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}