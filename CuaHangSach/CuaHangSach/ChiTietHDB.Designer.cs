namespace CuaHangSach
{
    partial class ChiTietHDB
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
            this.btXoaHD = new System.Windows.Forms.Button();
            this.btLuuHD = new System.Windows.Forms.Button();
            this.btThemHD = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMatHang = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThueVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtThue = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonBan = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.cbMaSach = new System.Windows.Forms.ComboBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbThue = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.lbGiaBanSach = new System.Windows.Forms.Label();
            this.lbMaSach = new System.Windows.Forms.Label();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lbNgayBan = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btXoaHD
            // 
            this.btXoaHD.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btXoaHD.ForeColor = System.Drawing.Color.DarkCyan;
            this.btXoaHD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btXoaHD.Location = new System.Drawing.Point(353, 410);
            this.btXoaHD.Name = "btXoaHD";
            this.btXoaHD.Size = new System.Drawing.Size(75, 23);
            this.btXoaHD.TabIndex = 9;
            this.btXoaHD.Text = "Xóa";
            this.btXoaHD.UseVisualStyleBackColor = false;
            this.btXoaHD.Click += new System.EventHandler(this.btXoaHD_Click);
            // 
            // btLuuHD
            // 
            this.btLuuHD.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btLuuHD.ForeColor = System.Drawing.Color.DarkCyan;
            this.btLuuHD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btLuuHD.Location = new System.Drawing.Point(272, 410);
            this.btLuuHD.Name = "btLuuHD";
            this.btLuuHD.Size = new System.Drawing.Size(75, 23);
            this.btLuuHD.TabIndex = 8;
            this.btLuuHD.Text = "Lưu";
            this.btLuuHD.UseVisualStyleBackColor = false;
            this.btLuuHD.Click += new System.EventHandler(this.btLuuHD_Click);
            // 
            // btThemHD
            // 
            this.btThemHD.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btThemHD.ForeColor = System.Drawing.Color.DarkCyan;
            this.btThemHD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btThemHD.Location = new System.Drawing.Point(191, 410);
            this.btThemHD.Name = "btThemHD";
            this.btThemHD.Size = new System.Drawing.Size(75, 23);
            this.btThemHD.TabIndex = 7;
            this.btThemHD.Text = "Thêm";
            this.btThemHD.UseVisualStyleBackColor = false;
            this.btThemHD.Click += new System.EventHandler(this.btThemHD_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgvMatHang);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.txtThue);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.txtDonBan);
            this.groupBox2.Controls.Add(this.txtTenSach);
            this.groupBox2.Controls.Add(this.cbMaSach);
            this.groupBox2.Controls.Add(this.lbSoLuong);
            this.groupBox2.Controls.Add(this.lbThue);
            this.groupBox2.Controls.Add(this.lbThanhTien);
            this.groupBox2.Controls.Add(this.lbGiaBanSach);
            this.groupBox2.Controls.Add(this.lbMaSach);
            this.groupBox2.Controls.Add(this.lbTenSach);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(10, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 293);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // txtTongTien
            // 
            this.txtTongTien.AcceptsReturn = true;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(468, 263);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(128, 22);
            this.txtTongTien.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(399, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tổng tiền";
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.AllowUserToOrderColumns = true;
            this.dgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.SoLuong,
            this.DonGiaBan,
            this.ThueVAT,
            this.ThanhTien});
            this.dgvMatHang.Location = new System.Drawing.Point(9, 88);
            this.dgvMatHang.Name = "dgvMatHang";
            this.dgvMatHang.Size = new System.Drawing.Size(587, 170);
            this.dgvMatHang.TabIndex = 8;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 84;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 120;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 60;
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            this.DonGiaBan.HeaderText = "Đơn giá";
            this.DonGiaBan.Name = "DonGiaBan";
            // 
            // ThueVAT
            // 
            this.ThueVAT.DataPropertyName = "ThueVAT";
            this.ThueVAT.HeaderText = "Thuế VAT";
            this.ThueVAT.Name = "ThueVAT";
            this.ThueVAT.Width = 80;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(486, 60);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(110, 22);
            this.txtThanhTien.TabIndex = 7;
            // 
            // txtThue
            // 
            this.txtThue.Location = new System.Drawing.Point(485, 26);
            this.txtThue.Name = "txtThue";
            this.txtThue.Size = new System.Drawing.Size(111, 22);
            this.txtThue.TabIndex = 6;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(307, 26);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(98, 22);
            this.txtSoLuong.TabIndex = 5;
            // 
            // txtDonBan
            // 
            this.txtDonBan.Enabled = false;
            this.txtDonBan.Location = new System.Drawing.Point(306, 60);
            this.txtDonBan.Name = "txtDonBan";
            this.txtDonBan.Size = new System.Drawing.Size(98, 22);
            this.txtDonBan.TabIndex = 4;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Enabled = false;
            this.txtTenSach.Location = new System.Drawing.Point(71, 60);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(163, 22);
            this.txtTenSach.TabIndex = 3;
            // 
            // cbMaSach
            // 
            this.cbMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbMaSach.FormattingEnabled = true;
            this.cbMaSach.Location = new System.Drawing.Point(71, 28);
            this.cbMaSach.Name = "cbMaSach";
            this.cbMaSach.Size = new System.Drawing.Size(163, 24);
            this.cbMaSach.TabIndex = 2;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbSoLuong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbSoLuong.Location = new System.Drawing.Point(240, 29);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(61, 16);
            this.lbSoLuong.TabIndex = 1;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // lbThue
            // 
            this.lbThue.AutoSize = true;
            this.lbThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbThue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbThue.Location = new System.Drawing.Point(410, 29);
            this.lbThue.Name = "lbThue";
            this.lbThue.Size = new System.Drawing.Size(69, 16);
            this.lbThue.TabIndex = 1;
            this.lbThue.Text = "Thuế VAT";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbThanhTien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbThanhTien.Location = new System.Drawing.Point(410, 63);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(70, 16);
            this.lbThanhTien.TabIndex = 1;
            this.lbThanhTien.Text = "Thành tiền";
            // 
            // lbGiaBanSach
            // 
            this.lbGiaBanSach.AutoSize = true;
            this.lbGiaBanSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbGiaBanSach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbGiaBanSach.Location = new System.Drawing.Point(240, 63);
            this.lbGiaBanSach.Name = "lbGiaBanSach";
            this.lbGiaBanSach.Size = new System.Drawing.Size(54, 16);
            this.lbGiaBanSach.TabIndex = 0;
            this.lbGiaBanSach.Text = "Đơn giá";
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbMaSach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMaSach.Location = new System.Drawing.Point(6, 29);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(59, 16);
            this.lbMaSach.TabIndex = 0;
            this.lbMaSach.Text = "Mã sách";
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbTenSach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTenSach.Location = new System.Drawing.Point(6, 63);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(64, 16);
            this.lbTenSach.TabIndex = 0;
            this.lbTenSach.Text = "Tên sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.dtpNgayBan);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.lbNgayBan);
            this.groupBox1.Controls.Add(this.lbMaKH);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.lbMaNV);
            this.groupBox1.Controls.Add(this.lbMaHD);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 94);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(424, 54);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(169, 22);
            this.txtMaKH.TabIndex = 21;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.CustomFormat = "";
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(104, 52);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(191, 22);
            this.dtpNgayBan.TabIndex = 20;
            this.dtpNgayBan.Value = new System.DateTime(2017, 10, 25, 0, 0, 0, 0);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(424, 25);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(169, 22);
            this.txtMaNV.TabIndex = 18;
            // 
            // lbNgayBan
            // 
            this.lbNgayBan.AutoSize = true;
            this.lbNgayBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbNgayBan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNgayBan.Location = new System.Drawing.Point(6, 55);
            this.lbNgayBan.Name = "lbNgayBan";
            this.lbNgayBan.Size = new System.Drawing.Size(67, 16);
            this.lbNgayBan.TabIndex = 11;
            this.lbNgayBan.Text = "Ngày bán";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbMaKH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMaKH.Location = new System.Drawing.Point(319, 57);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(99, 16);
            this.lbMaKH.TabIndex = 12;
            this.lbMaKH.Text = "Mã khách hàng";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(104, 25);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(191, 22);
            this.txtMaHD.TabIndex = 5;
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbMaNV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMaNV.Location = new System.Drawing.Point(319, 28);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(87, 16);
            this.lbMaNV.TabIndex = 14;
            this.lbMaNV.Text = "Mã nhân viên";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbMaHD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMaHD.Location = new System.Drawing.Point(6, 28);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(79, 16);
            this.lbMaHD.TabIndex = 14;
            this.lbMaHD.Text = "Mã hóa đơn";
            // 
            // ChiTietHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(623, 444);
            this.Controls.Add(this.btXoaHD);
            this.Controls.Add(this.btLuuHD);
            this.Controls.Add(this.btThemHD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChiTietHDB";
            this.Text = "Chi tiết hóa đơn bán";
            this.Load += new System.EventHandler(this.ChiTietHDB_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btXoaHD;
        private System.Windows.Forms.Button btLuuHD;
        private System.Windows.Forms.Button btThemHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThueVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtThue;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonBan;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.ComboBox cbMaSach;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbThue;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Label lbGiaBanSach;
        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lbNgayBan;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbMaHD;
    }
}