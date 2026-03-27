namespace QuanLyKhachSan.UI.Room_Service
{
    partial class AddRoomForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblMaPhong = new Label();
            txtMaPhong = new TextBox();
            lblTenPhong = new Label();
            txtTenPhong = new TextBox();
            rbPhongVip = new RadioButton();
            rbPhongThuong = new RadioButton();
            rbPhongDon = new RadioButton();
            rbPhongDoi = new RadioButton();
            rbPhongGia = new RadioButton();
            lblGiaPhong = new Label();
            txtGiaPhong = new TextBox();
            lblTinhTrang = new Label();
            txtTinhTrang = new TextBox();
            lblHienTrang = new Label();
            cboHienTrang = new ComboBox();
            btnLamMoi = new Button();
            lblDanhSachTienIch = new Label();
            txtTimTienIch = new TextBox();
            dgvTienIchKhachSan = new DataGridView();
            colSTT1 = new DataGridViewTextBoxColumn();
            colMaTienIch1 = new DataGridViewTextBoxColumn();
            colTenTienIch1 = new DataGridViewTextBoxColumn();
            lblSoLuong1 = new Label();
            nudSoLuong1 = new NumericUpDown();
            btnThemTienIch = new Button();
            lblDanhSachTienIchPhong = new Label();
            txtTimTienIchPhong = new TextBox();
            dgvTienIchPhong = new DataGridView();
            colSTT2 = new DataGridViewTextBoxColumn();
            colMaTienIch2 = new DataGridViewTextBoxColumn();
            colTenTienIch2 = new DataGridViewTextBoxColumn();
            colSoLuong2 = new DataGridViewTextBoxColumn();
            lblSoLuong2 = new Label();
            nudSoLuong2 = new NumericUpDown();
            btnSuaTienIch = new Button();
            btnXoaTienIch = new Button();
            btnThemPhong = new Button();
            btnDong = new Button();
            pnlHeader = new Panel();
            pnlLeft = new Panel();
            pnlRight = new Panel();
            pnlBottom = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvTienIchKhachSan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTienIchPhong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong2).BeginInit();
            pnlHeader.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlBottom.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(360, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(185, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÊM PHÒNG MỚI";
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Font = new Font("Segoe UI", 9F);
            lblMaPhong.Location = new Point(15, 15);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new Size(65, 15);
            lblMaPhong.TabIndex = 0;
            lblMaPhong.Text = "Mã phòng:";
            // 
            // txtMaPhong
            // 
            txtMaPhong.BorderStyle = BorderStyle.FixedSingle;
            txtMaPhong.Location = new Point(15, 35);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(355, 23);
            txtMaPhong.TabIndex = 1;
            // 
            // lblTenPhong
            // 
            lblTenPhong.AutoSize = true;
            lblTenPhong.Location = new Point(15, 75);
            lblTenPhong.Name = "lblTenPhong";
            lblTenPhong.Size = new Size(66, 15);
            lblTenPhong.TabIndex = 2;
            lblTenPhong.Text = "Tên phòng:";
            // 
            // txtTenPhong
            // 
            txtTenPhong.BorderStyle = BorderStyle.FixedSingle;
            txtTenPhong.Location = new Point(15, 95);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(355, 23);
            txtTenPhong.TabIndex = 3;
            // 
            // rbPhongVip
            // 
            rbPhongVip.AutoSize = true;
            rbPhongVip.Checked = true;
            rbPhongVip.Location = new Point(25, 22);
            rbPhongVip.Name = "rbPhongVip";
            rbPhongVip.Size = new Size(80, 19);
            rbPhongVip.TabIndex = 5;
            rbPhongVip.TabStop = true;
            rbPhongVip.Text = "Phòng Vip";
            // 
            // rbPhongThuong
            // 
            rbPhongThuong.AutoSize = true;
            rbPhongThuong.Location = new Point(187, 22);
            rbPhongThuong.Name = "rbPhongThuong";
            rbPhongThuong.Size = new Size(102, 19);
            rbPhongThuong.TabIndex = 6;
            rbPhongThuong.Text = "Phòng thường";
            // 
            // rbPhongDon
            // 
            rbPhongDon.AutoSize = true;
            rbPhongDon.Checked = true;
            rbPhongDon.Location = new Point(10, 23);
            rbPhongDon.Name = "rbPhongDon";
            rbPhongDon.Size = new Size(84, 19);
            rbPhongDon.TabIndex = 8;
            rbPhongDon.TabStop = true;
            rbPhongDon.Text = "Phòng đơn";
            // 
            // rbPhongDoi
            // 
            rbPhongDoi.AutoSize = true;
            rbPhongDoi.Location = new Point(115, 23);
            rbPhongDoi.Name = "rbPhongDoi";
            rbPhongDoi.Size = new Size(80, 19);
            rbPhongDoi.TabIndex = 9;
            rbPhongDoi.Text = "Phòng đôi";
            // 
            // rbPhongGia
            // 
            rbPhongGia.AutoSize = true;
            rbPhongGia.Location = new Point(220, 23);
            rbPhongGia.Name = "rbPhongGia";
            rbPhongGia.Size = new Size(106, 19);
            rbPhongGia.TabIndex = 10;
            rbPhongGia.Text = "Phòng gia đình";
            // 
            // lblGiaPhong
            // 
            lblGiaPhong.AutoSize = true;
            lblGiaPhong.Location = new Point(15, 262);
            lblGiaPhong.Name = "lblGiaPhong";
            lblGiaPhong.Size = new Size(65, 15);
            lblGiaPhong.TabIndex = 11;
            lblGiaPhong.Text = "Giá phòng:";
            // 
            // txtGiaPhong
            // 
            txtGiaPhong.BorderStyle = BorderStyle.FixedSingle;
            txtGiaPhong.Location = new Point(15, 282);
            txtGiaPhong.Name = "txtGiaPhong";
            txtGiaPhong.Size = new Size(355, 23);
            txtGiaPhong.TabIndex = 12;
            // 
            // lblTinhTrang
            // 
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.Location = new Point(15, 322);
            lblTinhTrang.Name = "lblTinhTrang";
            lblTinhTrang.Size = new Size(64, 15);
            lblTinhTrang.TabIndex = 13;
            lblTinhTrang.Text = "Tình trạng:";
            // 
            // txtTinhTrang
            // 
            txtTinhTrang.BackColor = Color.White;
            txtTinhTrang.BorderStyle = BorderStyle.FixedSingle;
            txtTinhTrang.Location = new Point(15, 342);
            txtTinhTrang.Name = "txtTinhTrang";
            txtTinhTrang.ReadOnly = true;
            txtTinhTrang.Size = new Size(355, 23);
            txtTinhTrang.TabIndex = 14;
            txtTinhTrang.Text = "Trống";
            // 
            // lblHienTrang
            // 
            lblHienTrang.AutoSize = true;
            lblHienTrang.Location = new Point(15, 382);
            lblHienTrang.Name = "lblHienTrang";
            lblHienTrang.Size = new Size(66, 15);
            lblHienTrang.TabIndex = 15;
            lblHienTrang.Text = "Hiện trạng:";
            // 
            // cboHienTrang
            // 
            cboHienTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHienTrang.FlatStyle = FlatStyle.Flat;
            cboHienTrang.Items.AddRange(new object[] { "Mới", "Đã sử dụng", "Cần bảo trì" });
            cboHienTrang.Location = new Point(15, 402);
            cboHienTrang.Name = "cboHienTrang";
            cboHienTrang.Size = new Size(355, 23);
            cboHienTrang.TabIndex = 16;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(147, 112, 219);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(240, 450);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(130, 35);
            btnLamMoi.TabIndex = 17;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // lblDanhSachTienIch
            // 
            lblDanhSachTienIch.AutoSize = true;
            lblDanhSachTienIch.Location = new Point(10, 10);
            lblDanhSachTienIch.Name = "lblDanhSachTienIch";
            lblDanhSachTienIch.Size = new Size(202, 15);
            lblDanhSachTienIch.TabIndex = 0;
            lblDanhSachTienIch.Text = "Danh sách tiện ích khách sạn hiện có";
            // 
            // txtTimTienIch
            // 
            txtTimTienIch.BorderStyle = BorderStyle.FixedSingle;
            txtTimTienIch.Location = new Point(10, 30);
            txtTimTienIch.Name = "txtTimTienIch";
            txtTimTienIch.PlaceholderText = "Nhập mã/tên tiện ích cần tìm...";
            txtTimTienIch.Size = new Size(550, 23);
            txtTimTienIch.TabIndex = 1;
            // 
            // dgvTienIchKhachSan
            // 
            dgvTienIchKhachSan.AllowUserToAddRows = false;
            dgvTienIchKhachSan.AllowUserToDeleteRows = false;
            dgvTienIchKhachSan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTienIchKhachSan.BackgroundColor = Color.White;
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = Color.FromArgb(100, 149, 237);
            dataGridViewCellStyle26.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = Color.White;
            dataGridViewCellStyle26.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = DataGridViewTriState.True;
            dgvTienIchKhachSan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            dgvTienIchKhachSan.ColumnHeadersHeight = 30;
            dgvTienIchKhachSan.Columns.AddRange(new DataGridViewColumn[] { colSTT1, colMaTienIch1, colTenTienIch1 });
            dgvTienIchKhachSan.EnableHeadersVisualStyles = false;
            dgvTienIchKhachSan.Location = new Point(10, 58);
            dgvTienIchKhachSan.Name = "dgvTienIchKhachSan";
            dgvTienIchKhachSan.ReadOnly = true;
            dgvTienIchKhachSan.RowHeadersVisible = false;
            dgvTienIchKhachSan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTienIchKhachSan.Size = new Size(550, 150);
            dgvTienIchKhachSan.TabIndex = 2;
            // 
            // colSTT1
            // 
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSTT1.DefaultCellStyle = dataGridViewCellStyle27;
            colSTT1.FillWeight = 10F;
            colSTT1.HeaderText = "STT";
            colSTT1.Name = "colSTT1";
            colSTT1.ReadOnly = true;
            // 
            // colMaTienIch1
            // 
            colMaTienIch1.FillWeight = 35F;
            colMaTienIch1.HeaderText = "MÃ TIỆN ÍCH";
            colMaTienIch1.Name = "colMaTienIch1";
            colMaTienIch1.ReadOnly = true;
            // 
            // colTenTienIch1
            // 
            colTenTienIch1.FillWeight = 55F;
            colTenTienIch1.HeaderText = "TÊN TIỆN ÍCH";
            colTenTienIch1.Name = "colTenTienIch1";
            colTenTienIch1.ReadOnly = true;
            // 
            // lblSoLuong1
            // 
            lblSoLuong1.AutoSize = true;
            lblSoLuong1.Location = new Point(10, 218);
            lblSoLuong1.Name = "lblSoLuong1";
            lblSoLuong1.Size = new Size(57, 15);
            lblSoLuong1.TabIndex = 3;
            lblSoLuong1.Text = "Số lượng:";
            // 
            // nudSoLuong1
            // 
            nudSoLuong1.Location = new Point(75, 215);
            nudSoLuong1.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudSoLuong1.Name = "nudSoLuong1";
            nudSoLuong1.Size = new Size(80, 23);
            nudSoLuong1.TabIndex = 4;
            // 
            // btnThemTienIch
            // 
            btnThemTienIch.BackColor = Color.FromArgb(34, 139, 34);
            btnThemTienIch.Cursor = Cursors.Hand;
            btnThemTienIch.FlatAppearance.BorderSize = 0;
            btnThemTienIch.FlatStyle = FlatStyle.Flat;
            btnThemTienIch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThemTienIch.ForeColor = Color.White;
            btnThemTienIch.Location = new Point(430, 212);
            btnThemTienIch.Name = "btnThemTienIch";
            btnThemTienIch.Size = new Size(130, 30);
            btnThemTienIch.TabIndex = 5;
            btnThemTienIch.Text = "Thêm tiện ích";
            btnThemTienIch.UseVisualStyleBackColor = false;
            // 
            // lblDanhSachTienIchPhong
            // 
            lblDanhSachTienIchPhong.AutoSize = true;
            lblDanhSachTienIchPhong.Location = new Point(10, 255);
            lblDanhSachTienIchPhong.Name = "lblDanhSachTienIchPhong";
            lblDanhSachTienIchPhong.Size = new Size(142, 15);
            lblDanhSachTienIchPhong.TabIndex = 6;
            lblDanhSachTienIchPhong.Text = "Danh sách tiện ích phòng";
            // 
            // txtTimTienIchPhong
            // 
            txtTimTienIchPhong.BorderStyle = BorderStyle.FixedSingle;
            txtTimTienIchPhong.Location = new Point(10, 275);
            txtTimTienIchPhong.Name = "txtTimTienIchPhong";
            txtTimTienIchPhong.PlaceholderText = "Nhập mã/tên tiện ích cần tìm...";
            txtTimTienIchPhong.Size = new Size(550, 23);
            txtTimTienIchPhong.TabIndex = 7;
            // 
            // dgvTienIchPhong
            // 
            dgvTienIchPhong.AllowUserToAddRows = false;
            dgvTienIchPhong.AllowUserToDeleteRows = false;
            dgvTienIchPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTienIchPhong.BackgroundColor = Color.White;
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = Color.FromArgb(100, 149, 237);
            dataGridViewCellStyle28.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle28.ForeColor = Color.White;
            dataGridViewCellStyle28.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = DataGridViewTriState.True;
            dgvTienIchPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            dgvTienIchPhong.ColumnHeadersHeight = 30;
            dgvTienIchPhong.Columns.AddRange(new DataGridViewColumn[] { colSTT2, colMaTienIch2, colTenTienIch2, colSoLuong2 });
            dgvTienIchPhong.EnableHeadersVisualStyles = false;
            dgvTienIchPhong.Location = new Point(10, 303);
            dgvTienIchPhong.Name = "dgvTienIchPhong";
            dgvTienIchPhong.ReadOnly = true;
            dgvTienIchPhong.RowHeadersVisible = false;
            dgvTienIchPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTienIchPhong.Size = new Size(550, 150);
            dgvTienIchPhong.TabIndex = 8;
            // 
            // colSTT2
            // 
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSTT2.DefaultCellStyle = dataGridViewCellStyle29;
            colSTT2.FillWeight = 10F;
            colSTT2.HeaderText = "STT";
            colSTT2.Name = "colSTT2";
            colSTT2.ReadOnly = true;
            // 
            // colMaTienIch2
            // 
            colMaTienIch2.FillWeight = 30F;
            colMaTienIch2.HeaderText = "MÃ TIỆN ÍCH";
            colMaTienIch2.Name = "colMaTienIch2";
            colMaTienIch2.ReadOnly = true;
            // 
            // colTenTienIch2
            // 
            colTenTienIch2.FillWeight = 40F;
            colTenTienIch2.HeaderText = "TÊN TIỆN ÍCH";
            colTenTienIch2.Name = "colTenTienIch2";
            colTenTienIch2.ReadOnly = true;
            // 
            // colSoLuong2
            // 
            dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSoLuong2.DefaultCellStyle = dataGridViewCellStyle30;
            colSoLuong2.FillWeight = 20F;
            colSoLuong2.HeaderText = "SỐ LƯỢNG";
            colSoLuong2.Name = "colSoLuong2";
            colSoLuong2.ReadOnly = true;
            // 
            // lblSoLuong2
            // 
            lblSoLuong2.AutoSize = true;
            lblSoLuong2.Location = new Point(10, 462);
            lblSoLuong2.Name = "lblSoLuong2";
            lblSoLuong2.Size = new Size(57, 15);
            lblSoLuong2.TabIndex = 9;
            lblSoLuong2.Text = "Số lượng:";
            // 
            // nudSoLuong2
            // 
            nudSoLuong2.Location = new Point(75, 460);
            nudSoLuong2.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudSoLuong2.Name = "nudSoLuong2";
            nudSoLuong2.Size = new Size(80, 23);
            nudSoLuong2.TabIndex = 10;
            // 
            // btnSuaTienIch
            // 
            btnSuaTienIch.BackColor = Color.FromArgb(70, 130, 180);
            btnSuaTienIch.Cursor = Cursors.Hand;
            btnSuaTienIch.FlatAppearance.BorderSize = 0;
            btnSuaTienIch.FlatStyle = FlatStyle.Flat;
            btnSuaTienIch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSuaTienIch.ForeColor = Color.White;
            btnSuaTienIch.Location = new Point(295, 458);
            btnSuaTienIch.Name = "btnSuaTienIch";
            btnSuaTienIch.Size = new Size(125, 30);
            btnSuaTienIch.TabIndex = 11;
            btnSuaTienIch.Text = "Sửa tiện ích";
            btnSuaTienIch.UseVisualStyleBackColor = false;
            // 
            // btnXoaTienIch
            // 
            btnXoaTienIch.BackColor = Color.FromArgb(205, 92, 92);
            btnXoaTienIch.Cursor = Cursors.Hand;
            btnXoaTienIch.FlatAppearance.BorderSize = 0;
            btnXoaTienIch.FlatStyle = FlatStyle.Flat;
            btnXoaTienIch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaTienIch.ForeColor = Color.White;
            btnXoaTienIch.Location = new Point(430, 458);
            btnXoaTienIch.Name = "btnXoaTienIch";
            btnXoaTienIch.Size = new Size(130, 30);
            btnXoaTienIch.TabIndex = 12;
            btnXoaTienIch.Text = "Xóa tiện ích";
            btnXoaTienIch.UseVisualStyleBackColor = false;
            // 
            // btnThemPhong
            // 
            btnThemPhong.BackColor = Color.FromArgb(34, 139, 34);
            btnThemPhong.Cursor = Cursors.Hand;
            btnThemPhong.FlatAppearance.BorderSize = 0;
            btnThemPhong.FlatStyle = FlatStyle.Flat;
            btnThemPhong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThemPhong.ForeColor = Color.White;
            btnThemPhong.Location = new Point(720, 8);
            btnThemPhong.Name = "btnThemPhong";
            btnThemPhong.Size = new Size(120, 35);
            btnThemPhong.TabIndex = 0;
            btnThemPhong.Text = "Thêm phòng";
            btnThemPhong.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            btnDong.BackColor = Color.FromArgb(105, 105, 105);
            btnDong.Cursor = Cursors.Hand;
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(850, 8);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(100, 35);
            btnDong.TabIndex = 1;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(100, 149, 237);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(968, 50);
            pnlHeader.TabIndex = 0;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.White;
            pnlLeft.Controls.Add(groupBox2);
            pnlLeft.Controls.Add(groupBox1);
            pnlLeft.Controls.Add(lblMaPhong);
            pnlLeft.Controls.Add(txtMaPhong);
            pnlLeft.Controls.Add(lblTenPhong);
            pnlLeft.Controls.Add(txtTenPhong);
            pnlLeft.Controls.Add(lblGiaPhong);
            pnlLeft.Controls.Add(txtGiaPhong);
            pnlLeft.Controls.Add(lblTinhTrang);
            pnlLeft.Controls.Add(txtTinhTrang);
            pnlLeft.Controls.Add(lblHienTrang);
            pnlLeft.Controls.Add(cboHienTrang);
            pnlLeft.Controls.Add(btnLamMoi);
            pnlLeft.Location = new Point(0, 50);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(390, 520);
            pnlLeft.TabIndex = 1;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(lblDanhSachTienIch);
            pnlRight.Controls.Add(txtTimTienIch);
            pnlRight.Controls.Add(dgvTienIchKhachSan);
            pnlRight.Controls.Add(lblSoLuong1);
            pnlRight.Controls.Add(nudSoLuong1);
            pnlRight.Controls.Add(btnThemTienIch);
            pnlRight.Controls.Add(lblDanhSachTienIchPhong);
            pnlRight.Controls.Add(txtTimTienIchPhong);
            pnlRight.Controls.Add(dgvTienIchPhong);
            pnlRight.Controls.Add(lblSoLuong2);
            pnlRight.Controls.Add(nudSoLuong2);
            pnlRight.Controls.Add(btnSuaTienIch);
            pnlRight.Controls.Add(btnXoaTienIch);
            pnlRight.Location = new Point(390, 50);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(10);
            pnlRight.Size = new Size(578, 520);
            pnlRight.TabIndex = 2;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.WhiteSmoke;
            pnlBottom.Controls.Add(btnThemPhong);
            pnlBottom.Controls.Add(btnDong);
            pnlBottom.Location = new Point(0, 570);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(968, 50);
            pnlBottom.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbPhongVip);
            groupBox1.Controls.Add(rbPhongThuong);
            groupBox1.Location = new Point(15, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 63);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại phòng:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbPhongGia);
            groupBox2.Controls.Add(rbPhongDoi);
            groupBox2.Controls.Add(rbPhongDon);
            groupBox2.Location = new Point(15, 193);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(327, 58);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết loại phòng";
            // 
            // AddRoomForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(968, 620);
            Controls.Add(pnlHeader);
            Controls.Add(pnlLeft);
            Controls.Add(pnlRight);
            Controls.Add(pnlBottom);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddRoomForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THÊM PHÒNG MỚI";
            ((System.ComponentModel.ISupportInitialize)dgvTienIchKhachSan).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTienIchPhong).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong2).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            pnlBottom.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Header
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        // Left Panel
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.RadioButton rbPhongVip;
        private System.Windows.Forms.RadioButton rbPhongThuong;
        private System.Windows.Forms.RadioButton rbPhongDon;
        private System.Windows.Forms.RadioButton rbPhongDoi;
        private System.Windows.Forms.RadioButton rbPhongGia;
        private System.Windows.Forms.Label lblGiaPhong;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label lblHienTrang;
        private System.Windows.Forms.ComboBox cboHienTrang;
        private System.Windows.Forms.Button btnLamMoi;

        // Right Panel
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblDanhSachTienIch;
        private System.Windows.Forms.TextBox txtTimTienIch;
        private System.Windows.Forms.DataGridView dgvTienIchKhachSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTienIch1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTienIch1;
        private System.Windows.Forms.Label lblSoLuong1;
        private System.Windows.Forms.NumericUpDown nudSoLuong1;
        private System.Windows.Forms.Button btnThemTienIch;
        private System.Windows.Forms.Label lblDanhSachTienIchPhong;
        private System.Windows.Forms.TextBox txtTimTienIchPhong;
        private System.Windows.Forms.DataGridView dgvTienIchPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTienIch2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTienIch2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong2;
        private System.Windows.Forms.Label lblSoLuong2;
        private System.Windows.Forms.NumericUpDown nudSoLuong2;
        private System.Windows.Forms.Button btnSuaTienIch;
        private System.Windows.Forms.Button btnXoaTienIch;

        // Bottom Panel
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Button btnDong;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}