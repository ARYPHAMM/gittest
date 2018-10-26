namespace QLCuaHangSuaGUI
{
    partial class frmSanPhamSua
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNSX = new System.Windows.Forms.TextBox();
            this.cboLoaiSua = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenSua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pboHAnh = new System.Windows.Forms.PictureBox();
            this.rtbMoTa = new System.Windows.Forms.RichTextBox();
            this.txtMaSua = new System.Windows.Forms.TextBox();
            this.dgvSua = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ColHinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.colMaSua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboHAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSua)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNSX
            // 
            this.txtNSX.Location = new System.Drawing.Point(89, 118);
            this.txtNSX.Margin = new System.Windows.Forms.Padding(4);
            this.txtNSX.Name = "txtNSX";
            this.txtNSX.Size = new System.Drawing.Size(187, 22);
            this.txtNSX.TabIndex = 22;
            // 
            // cboLoaiSua
            // 
            this.cboLoaiSua.FormattingEnabled = true;
            this.cboLoaiSua.Location = new System.Drawing.Point(496, 69);
            this.cboLoaiSua.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiSua.Name = "cboLoaiSua";
            this.cboLoaiSua.Size = new System.Drawing.Size(177, 24);
            this.cboLoaiSua.TabIndex = 21;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(89, 70);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(187, 22);
            this.txtGia.TabIndex = 20;
            // 
            // txtTenSua
            // 
            this.txtTenSua.Location = new System.Drawing.Point(496, 23);
            this.txtTenSua.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSua.Name = "txtTenSua";
            this.txtTenSua.Size = new System.Drawing.Size(177, 22);
            this.txtTenSua.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã SP:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pboHAnh);
            this.groupBox1.Controls.Add(this.rtbMoTa);
            this.groupBox1.Controls.Add(this.txtNSX);
            this.groupBox1.Controls.Add(this.cboLoaiSua);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtTenSua);
            this.groupBox1.Controls.Add(this.txtMaSua);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(25, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(969, 244);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // button1
            // 
            this.button1.Image = global::QLCuaHangSuaGUI.Properties.Resources.refresh;
            this.button1.Location = new System.Drawing.Point(805, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 34;
            this.button1.Text = "Làm mới";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QLCuaHangSuaGUI.Properties.Resources.minus;
            this.btnXoa.Location = new System.Drawing.Point(652, 186);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 50);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QLCuaHangSuaGUI.Properties.Resources.edit;
            this.btnSua.Location = new System.Drawing.Point(499, 186);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 50);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QLCuaHangSuaGUI.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(345, 186);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 50);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Mô tả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nhà SX:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Loại Sữa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Giá Bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên SP:";
            // 
            // pboHAnh
            // 
            this.pboHAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboHAnh.Image = global::QLCuaHangSuaGUI.Properties.Resources.s22;
            this.pboHAnh.Location = new System.Drawing.Point(773, 17);
            this.pboHAnh.Margin = new System.Windows.Forms.Padding(4);
            this.pboHAnh.Name = "pboHAnh";
            this.pboHAnh.Size = new System.Drawing.Size(133, 125);
            this.pboHAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboHAnh.TabIndex = 24;
            this.pboHAnh.TabStop = false;
            this.pboHAnh.Click += new System.EventHandler(this.pboHAnh_Click);
            // 
            // rtbMoTa
            // 
            this.rtbMoTa.Location = new System.Drawing.Point(496, 118);
            this.rtbMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMoTa.Name = "rtbMoTa";
            this.rtbMoTa.Size = new System.Drawing.Size(177, 47);
            this.rtbMoTa.TabIndex = 23;
            this.rtbMoTa.Text = "";
            // 
            // txtMaSua
            // 
            this.txtMaSua.Location = new System.Drawing.Point(89, 27);
            this.txtMaSua.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSua.Name = "txtMaSua";
            this.txtMaSua.Size = new System.Drawing.Size(187, 22);
            this.txtMaSua.TabIndex = 17;
            // 
            // dgvSua
            // 
            this.dgvSua.AllowUserToAddRows = false;
            this.dgvSua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColHinhAnh,
            this.colMaSua,
            this.colTenSua,
            this.colGiaBan,
            this.colLoai,
            this.colNSX,
            this.colMoTa});
            this.dgvSua.Location = new System.Drawing.Point(25, 327);
            this.dgvSua.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSua.Name = "dgvSua";
            this.dgvSua.ReadOnly = true;
            this.dgvSua.RowHeadersVisible = false;
            this.dgvSua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSua.Size = new System.Drawing.Size(969, 277);
            this.dgvSua.TabIndex = 9;
            this.dgvSua.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSua_CellFormatting);
            this.dgvSua.SelectionChanged += new System.EventHandler(this.dgvSua_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(364, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "QUẢN LÝ SẢN PHẨM SỮA";
            // 
            // ColHinhAnh
            // 
            this.ColHinhAnh.DataPropertyName = "HinhAnh";
            this.ColHinhAnh.HeaderText = "Hinh Anh";
            this.ColHinhAnh.Name = "ColHinhAnh";
            this.ColHinhAnh.ReadOnly = true;
            // 
            // colMaSua
            // 
            this.colMaSua.DataPropertyName = "MaSua";
            this.colMaSua.HeaderText = "Mã Sữa";
            this.colMaSua.Name = "colMaSua";
            this.colMaSua.ReadOnly = true;
            // 
            // colTenSua
            // 
            this.colTenSua.DataPropertyName = "TenSua";
            this.colTenSua.HeaderText = "Nhãn Hiệu";
            this.colTenSua.Name = "colTenSua";
            this.colTenSua.ReadOnly = true;
            // 
            // colGiaBan
            // 
            this.colGiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = "0";
            this.colGiaBan.DefaultCellStyle = dataGridViewCellStyle4;
            this.colGiaBan.HeaderText = "Giá Bán";
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.ReadOnly = true;
            // 
            // colLoai
            // 
            this.colLoai.DataPropertyName = "MaLoai";
            this.colLoai.HeaderText = "Loại Sữa";
            this.colLoai.Name = "colLoai";
            this.colLoai.ReadOnly = true;
            this.colLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colNSX
            // 
            this.colNSX.DataPropertyName = "NhaSanXuat";
            this.colNSX.HeaderText = "Nhà Sản Xuất";
            this.colNSX.Name = "colNSX";
            this.colNSX.ReadOnly = true;
            this.colNSX.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNSX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMoTa
            // 
            this.colMoTa.DataPropertyName = "MoTa";
            this.colMoTa.HeaderText = "Mô Tả";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.ReadOnly = true;
            this.colMoTa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMoTa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmSanPhamSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 618);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSua);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSanPhamSua";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSanPhamSua_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboHAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNSX;
        private System.Windows.Forms.ComboBox cboLoaiSua;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenSua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pboHAnh;
        private System.Windows.Forms.RichTextBox rtbMoTa;
        private System.Windows.Forms.TextBox txtMaSua;
        private System.Windows.Forms.DataGridView dgvSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn ColHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
    }
}

