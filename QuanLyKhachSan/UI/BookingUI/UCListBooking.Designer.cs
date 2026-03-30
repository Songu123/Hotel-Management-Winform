namespace QuanLyKhachSan.UI.BookingUI
{
    partial class UCListBooking
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTop = new Panel();
            btnLamMoi = new Button();
            btnTimKiem = new Button();
            gbThoiGian = new GroupBox();
            dtpNgayTra = new DateTimePicker();
            lblNgayTra = new Label();
            dtpNgayThue = new DateTimePicker();
            lblNgayThue = new Label();
            lblTitle = new Label();
            pnlFilter = new Panel();
            cboLoaiThue = new ComboBox();
            lblLoaiThue = new Label();
            cboTrangThai = new ComboBox();
            lblTrangThai = new Label();
            cboNhanVien = new ComboBox();
            lblNhanVien = new Label();
            cboKhachHang = new ComboBox();
            lblKhachHang = new Label();
            txtMaChiTiet = new TextBox();
            lblMaChiTiet = new Label();
            pnlBottom = new Panel();
            dgvChiTietThue = new DataGridView();
            lblDanhSach = new Label();
            pnlTop.SuspendLayout();
            gbThoiGian.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietThue).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(btnLamMoi);
            pnlTop.Controls.Add(btnTimKiem);
            pnlTop.Controls.Add(gbThoiGian);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Controls.Add(pnlFilter);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1048, 250);
            pnlTop.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(107, 114, 128);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(900, 210);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(120, 35);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "🔄  Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(59, 130, 246);
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(760, 210);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(120, 35);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "🔍  Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // gbThoiGian
            // 
            gbThoiGian.Controls.Add(dtpNgayTra);
            gbThoiGian.Controls.Add(lblNgayTra);
            gbThoiGian.Controls.Add(dtpNgayThue);
            gbThoiGian.Controls.Add(lblNgayThue);
            gbThoiGian.Font = new Font("Segoe UI", 9F);
            gbThoiGian.ForeColor = Color.FromArgb(31, 41, 55);
            gbThoiGian.Location = new Point(15, 150);
            gbThoiGian.Name = "gbThoiGian";
            gbThoiGian.Size = new Size(730, 80);
            gbThoiGian.TabIndex = 2;
            gbThoiGian.TabStop = false;
            gbThoiGian.Text = "Thời Gian Lập Phiếu";
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            dtpNgayTra.Format = DateTimePickerFormat.Custom;
            dtpNgayTra.Location = new Point(520, 35);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(180, 23);
            dtpNgayTra.TabIndex = 3;
            // 
            // lblNgayTra
            // 
            lblNgayTra.AutoSize = true;
            lblNgayTra.Location = new Point(450, 40);
            lblNgayTra.Name = "lblNgayTra";
            lblNgayTra.Size = new Size(62, 15);
            lblNgayTra.TabIndex = 2;
            lblNgayTra.Text = "Đến Ngày:";
            // 
            // dtpNgayThue
            // 
            dtpNgayThue.CustomFormat = "dd/MM/yyyy";
            dtpNgayThue.Format = DateTimePickerFormat.Custom;
            dtpNgayThue.Location = new Point(230, 35);
            dtpNgayThue.Name = "dtpNgayThue";
            dtpNgayThue.Size = new Size(180, 23);
            dtpNgayThue.TabIndex = 1;
            // 
            // lblNgayThue
            // 
            lblNgayThue.AutoSize = true;
            lblNgayThue.Location = new Point(115, 40);
            lblNgayThue.Name = "lblNgayThue";
            lblNgayThue.Size = new Size(54, 15);
            lblNgayThue.TabIndex = 0;
            lblNgayThue.Text = "Từ Ngày:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitle.Location = new Point(15, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(293, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "📋  DANH SÁCH CHI TIẾT THUÊ";
            // 
            // pnlFilter
            // 
            pnlFilter.BorderStyle = BorderStyle.FixedSingle;
            pnlFilter.Controls.Add(cboLoaiThue);
            pnlFilter.Controls.Add(lblLoaiThue);
            pnlFilter.Controls.Add(cboTrangThai);
            pnlFilter.Controls.Add(lblTrangThai);
            pnlFilter.Controls.Add(cboNhanVien);
            pnlFilter.Controls.Add(lblNhanVien);
            pnlFilter.Controls.Add(cboKhachHang);
            pnlFilter.Controls.Add(lblKhachHang);
            pnlFilter.Controls.Add(txtMaChiTiet);
            pnlFilter.Controls.Add(lblMaChiTiet);
            pnlFilter.Location = new Point(15, 50);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1020, 95);
            pnlFilter.TabIndex = 0;
            // 
            // cboLoaiThue
            // 
            cboLoaiThue.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiThue.Font = new Font("Segoe UI", 8.25F);
            cboLoaiThue.FormattingEnabled = true;
            cboLoaiThue.Items.AddRange(new object[] { "Theo Ngày", "Theo Giờ", "Khác" });
            cboLoaiThue.Location = new Point(850, 55);
            cboLoaiThue.Name = "cboLoaiThue";
            cboLoaiThue.Size = new Size(150, 21);
            cboLoaiThue.TabIndex = 9;
            // 
            // lblLoaiThue
            // 
            lblLoaiThue.AutoSize = true;
            lblLoaiThue.Font = new Font("Segoe UI", 8.25F);
            lblLoaiThue.Location = new Point(769, 55);
            lblLoaiThue.Name = "lblLoaiThue";
            lblLoaiThue.Size = new Size(60, 13);
            lblLoaiThue.TabIndex = 8;
            lblLoaiThue.Text = "Loại Thuê:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Segoe UI", 8.25F);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Đang Xử Lý", "Đã Xác Nhận", "Đã Hủy" });
            cboTrangThai.Location = new Point(850, 25);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(150, 21);
            cboTrangThai.TabIndex = 7;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 8.25F);
            lblTrangThai.Location = new Point(769, 30);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(65, 13);
            lblTrangThai.TabIndex = 6;
            lblTrangThai.Text = "Tình Trạng:";
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.Font = new Font("Segoe UI", 8.25F);
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(489, 52);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(200, 21);
            cboNhanVien.TabIndex = 5;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Segoe UI", 8.25F);
            lblNhanVien.Location = new Point(386, 55);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(89, 13);
            lblNhanVien.TabIndex = 4;
            lblNhanVien.Text = "Nhân Viên (Mã):";
            // 
            // cboKhachHang
            // 
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.Font = new Font("Segoe UI", 8.25F);
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(489, 25);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(200, 21);
            cboKhachHang.TabIndex = 3;
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Segoe UI", 8.25F);
            lblKhachHang.Location = new Point(386, 30);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(97, 13);
            lblKhachHang.TabIndex = 2;
            lblKhachHang.Text = "Khách Hàng (Mã):";
            // 
            // txtMaChiTiet
            // 
            txtMaChiTiet.Font = new Font("Segoe UI", 8.25F);
            txtMaChiTiet.Location = new Point(100, 30);
            txtMaChiTiet.Name = "txtMaChiTiet";
            txtMaChiTiet.Size = new Size(262, 22);
            txtMaChiTiet.TabIndex = 1;
            // 
            // lblMaChiTiet
            // 
            lblMaChiTiet.AutoSize = true;
            lblMaChiTiet.Font = new Font("Segoe UI", 8.25F);
            lblMaChiTiet.Location = new Point(20, 33);
            lblMaChiTiet.Name = "lblMaChiTiet";
            lblMaChiTiet.Size = new Size(79, 13);
            lblMaChiTiet.TabIndex = 0;
            lblMaChiTiet.Text = "Mã Chi Tiết (*)";
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(dgvChiTietThue);
            pnlBottom.Controls.Add(lblDanhSach);
            pnlBottom.Dock = DockStyle.Fill;
            pnlBottom.Location = new Point(0, 250);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(15);
            pnlBottom.Size = new Size(1048, 513);
            pnlBottom.TabIndex = 1;
            // 
            // dgvChiTietThue
            // 
            dgvChiTietThue.AllowUserToAddRows = false;
            dgvChiTietThue.AllowUserToDeleteRows = false;
            dgvChiTietThue.BackgroundColor = Color.White;
            dgvChiTietThue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietThue.Dock = DockStyle.Fill;
            dgvChiTietThue.Location = new Point(15, 45);
            dgvChiTietThue.MultiSelect = false;
            dgvChiTietThue.Name = "dgvChiTietThue";
            dgvChiTietThue.ReadOnly = true;
            dgvChiTietThue.RowHeadersVisible = false;
            dgvChiTietThue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietThue.Size = new Size(1018, 453);
            dgvChiTietThue.TabIndex = 1;
            // 
            // lblDanhSach
            // 
            lblDanhSach.BackColor = Color.FromArgb(243, 244, 246);
            lblDanhSach.Dock = DockStyle.Top;
            lblDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDanhSach.ForeColor = Color.FromArgb(31, 41, 55);
            lblDanhSach.Location = new Point(15, 15);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(1018, 30);
            lblDanhSach.TabIndex = 0;
            lblDanhSach.Text = "Danh Sách Chi Tiết Thuê";
            lblDanhSach.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UCListBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
            Name = "UCListBooking";
            Size = new Size(1048, 763);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            gbThoiGian.ResumeLayout(false);
            gbThoiGian.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTietThue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Panel pnlFilter;
        private Label lblTitle;
        private TextBox txtMaChiTiet;
        private Label lblMaChiTiet;
        private ComboBox cboKhachHang;
        private Label lblKhachHang;
        private ComboBox cboNhanVien;
        private Label lblNhanVien;
        private ComboBox cboTrangThai;
        private Label lblTrangThai;
        private ComboBox cboLoaiThue;
        private Label lblLoaiThue;
        private GroupBox gbThoiGian;
        private DateTimePicker dtpNgayTra;
        private Label lblNgayTra;
        private DateTimePicker dtpNgayThue;
        private Label lblNgayThue;
        private Button btnTimKiem;
        private Button btnLamMoi;
        private Panel pnlBottom;
        private Label lblDanhSach;
        private DataGridView dgvChiTietThue;
    }
}
