namespace QuanLyKhachSan.UI.BookingUI
{
    partial class UCBookingModern
    {
    private System.ComponentModel.IContainer components = null;

        // Designer controls
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblChiTietLoaiPhong;
        private System.Windows.Forms.ComboBox cboChiTietLoaiPhong;
      private System.Windows.Forms.Label lblLoaiPhong;
private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label lblTinhTrangPhong;
        private System.Windows.Forms.ComboBox cboTinhTrangPhong;
        private System.Windows.Forms.Label lblGiaPhong;
        private System.Windows.Forms.ComboBox cboGiaPhong;
   private System.Windows.Forms.Label lblHienTrang;
        private System.Windows.Forms.ComboBox cboHienTrang;
    private System.Windows.Forms.GroupBox gbTinhTrangThue;
        private System.Windows.Forms.RadioButton rdoTheoNgay;
     private System.Windows.Forms.RadioButton rdoKhac;
        private System.Windows.Forms.RadioButton rdoTheoGio;
  private System.Windows.Forms.GroupBox gbThoiGianThue;
        private System.Windows.Forms.Label lblNgayThue;
   private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.Label lblNgayTra;
 private System.Windows.Forms.DateTimePicker dtpNgayTra;
 private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblSoDoPhong;
        private System.Windows.Forms.FlowLayoutPanel flpRooms;

        protected override void Dispose(bool disposing)
        {
      if (disposing && (components != null))
      {
  components.Dispose();
          }
      base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
this.components = new System.ComponentModel.Container();

            // Top panel
            this.pnlTop = new System.Windows.Forms.Panel();
      this.pnlTop.BackColor = System.Drawing.Color.White;
       this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
 this.pnlTop.Location = new System.Drawing.Point(0, 0);
this.pnlTop.Name = "pnlTop";
    this.pnlTop.Size = new System.Drawing.Size(1050, 160);
      this.pnlTop.TabIndex = 0;

// Title
            this.lblTitle = new System.Windows.Forms.Label();
        this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
    this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
   this.lblTitle.Location = new System.Drawing.Point(16, 7);
          this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(300, 21);
            this.lblTitle.Text = "TẠO PHIẾU ĐẶT PHÒNG - SƠ ĐỒ PHÒNG";

        // Subtitle
         this.lblSubtitle = new System.Windows.Forms.Label();
    this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
        this.lblSubtitle.Location = new System.Drawing.Point(17, 28);
     this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(350, 17);
      this.lblSubtitle.Text = "Chọn phòng từ danh sách dưới đây - Nhấp chuột phải để xem chi tiết";

      // Room Type
       this.lblLoaiPhong = new System.Windows.Forms.Label();
        this.lblLoaiPhong.AutoSize = true;
      this.lblLoaiPhong.Location = new System.Drawing.Point(213, 56);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(68, 15);
      this.lblLoaiPhong.Text = "Loại phòng:";

            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
      this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
       this.cboLoaiPhong.Location = new System.Drawing.Point(286, 53);
  this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(107, 23);
     this.cboLoaiPhong.TabIndex = 5;

 // Room Status
            this.lblTinhTrangPhong = new System.Windows.Forms.Label();
            this.lblTinhTrangPhong.AutoSize = true;
 this.lblTinhTrangPhong.Location = new System.Drawing.Point(402, 56);
            this.lblTinhTrangPhong.Name = "lblTinhTrangPhong";
         this.lblTinhTrangPhong.Size = new System.Drawing.Size(101, 15);
            this.lblTinhTrangPhong.Text = "Tình trạng phòng:";

  this.cboTinhTrangPhong = new System.Windows.Forms.ComboBox();
            this.cboTinhTrangPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
          this.cboTinhTrangPhong.Location = new System.Drawing.Point(509, 53);
            this.cboTinhTrangPhong.Name = "cboTinhTrangPhong";
            this.cboTinhTrangPhong.Size = new System.Drawing.Size(121, 23);
      this.cboTinhTrangPhong.TabIndex = 7;

 // Price
     this.lblGiaPhong = new System.Windows.Forms.Label();
            this.lblGiaPhong.AutoSize = true;
            this.lblGiaPhong.Location = new System.Drawing.Point(636, 56);
            this.lblGiaPhong.Name = "lblGiaPhong";
          this.lblGiaPhong.Size = new System.Drawing.Size(65, 15);
            this.lblGiaPhong.Text = "Giá phòng:";

this.cboGiaPhong = new System.Windows.Forms.ComboBox();
            this.cboGiaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboGiaPhong.Location = new System.Drawing.Point(704, 53);
 this.cboGiaPhong.Name = "cboGiaPhong";
     this.cboGiaPhong.Size = new System.Drawing.Size(121, 23);
      this.cboGiaPhong.TabIndex = 9;

 // Rental type
 this.lblHienTrang = new System.Windows.Forms.Label();
            this.lblHienTrang.AutoSize = true;
    this.lblHienTrang.Location = new System.Drawing.Point(836, 56);
      this.lblHienTrang.Name = "lblHienTrang";
   this.lblHienTrang.Size = new System.Drawing.Size(67, 15);
  this.lblHienTrang.Text = "Loại thuê:";

            this.cboHienTrang = new System.Windows.Forms.ComboBox();
            this.cboHienTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cboHienTrang.Location = new System.Drawing.Point(909, 53);
       this.cboHienTrang.Name = "cboHienTrang";
    this.cboHienTrang.Size = new System.Drawing.Size(65, 23);
  this.cboHienTrang.TabIndex = 11;

         // Rental type group
  this.gbTinhTrangThue = new System.Windows.Forms.GroupBox();
      this.gbTinhTrangThue.Location = new System.Drawing.Point(20, 88);
    this.gbTinhTrangThue.Name = "gbTinhTrangThue";
        this.gbTinhTrangThue.Size = new System.Drawing.Size(238, 55);
   this.gbTinhTrangThue.Text = "Loại thuê";

          this.rdoTheoNgay = new System.Windows.Forms.RadioButton();
  this.rdoTheoNgay.AutoSize = true;
      this.rdoTheoNgay.Location = new System.Drawing.Point(10, 22);
            this.rdoTheoNgay.Name = "rdoTheoNgay";
            this.rdoTheoNgay.Text = "Theo ngày";
     this.rdoTheoNgay.Checked = true;
     this.gbTinhTrangThue.Controls.Add(this.rdoTheoNgay);

         this.rdoTheoGio = new System.Windows.Forms.RadioButton();
      this.rdoTheoGio.AutoSize = true;
            this.rdoTheoGio.Location = new System.Drawing.Point(98, 22);
            this.rdoTheoGio.Name = "rdoTheoGio";
     this.rdoTheoGio.Text = "Theo giờ";
            this.gbTinhTrangThue.Controls.Add(this.rdoTheoGio);

            this.rdoKhac = new System.Windows.Forms.RadioButton();
      this.rdoKhac.AutoSize = true;
  this.rdoKhac.Location = new System.Drawing.Point(176, 22);
      this.rdoKhac.Name = "rdoKhac";
     this.rdoKhac.Text = "Khác";
            this.gbTinhTrangThue.Controls.Add(this.rdoKhac);

      // Time group
   this.gbThoiGianThue = new System.Windows.Forms.GroupBox();
     this.gbThoiGianThue.Location = new System.Drawing.Point(264, 88);
            this.gbThoiGianThue.Name = "gbThoiGianThue";
            this.gbThoiGianThue.Size = new System.Drawing.Size(518, 55);
            this.gbThoiGianThue.Text = "Thời gian thuê";

            this.lblNgayThue = new System.Windows.Forms.Label();
  this.lblNgayThue.AutoSize = true;
            this.lblNgayThue.Location = new System.Drawing.Point(11, 24);
            this.lblNgayThue.Name = "lblNgayThue";
          this.lblNgayThue.Size = new System.Drawing.Size(65, 15);
            this.lblNgayThue.Text = "Ngày thuê:";
     this.gbThoiGianThue.Controls.Add(this.lblNgayThue);

     this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayThue.CustomFormat = "dd/MM/yyyy HH:mm:ss";
     this.dtpNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
          this.dtpNgayThue.Location = new System.Drawing.Point(82, 20);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(165, 23);
            this.gbThoiGianThue.Controls.Add(this.dtpNgayThue);

     this.lblNgayTra = new System.Windows.Forms.Label();
            this.lblNgayTra.AutoSize = true;
    this.lblNgayTra.Location = new System.Drawing.Point(275, 24);
        this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(55, 15);
      this.lblNgayTra.Text = "Ngày trả:";
   this.gbThoiGianThue.Controls.Add(this.lblNgayTra);

     this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy HH:mm:ss";
    this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
          this.dtpNgayTra.Location = new System.Drawing.Point(336, 20);
   this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(165, 23);
          this.gbThoiGianThue.Controls.Add(this.dtpNgayTra);

            // Search buttons
    this.btnTimKiem = new System.Windows.Forms.Button();
  this.btnTimKiem.BackColor = System.Drawing.Color.CornflowerBlue;
       this.btnTimKiem.FlatAppearance.BorderSize = 0;
       this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
      this.btnTimKiem.ForeColor = System.Drawing.Color.White;
         this.btnTimKiem.Location = new System.Drawing.Point(788, 101);
       this.btnTimKiem.Name = "btnTimKiem";
 this.btnTimKiem.Size = new System.Drawing.Size(90, 35);
      this.btnTimKiem.Text = "Tìm kiếm";

            this.btnLamMoi = new System.Windows.Forms.Button();
          this.btnLamMoi.BackColor = System.Drawing.Color.DimGray;
  this.btnLamMoi.FlatAppearance.BorderSize = 0;
     this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
          this.btnLamMoi.ForeColor = System.Drawing.Color.White;
          this.btnLamMoi.Location = new System.Drawing.Point(884, 101);
    this.btnLamMoi.Name = "btnLamMoi";
      this.btnLamMoi.Size = new System.Drawing.Size(90, 35);
  this.btnLamMoi.Text = "Làm mới";

            // Add controls to top panel
            this.pnlTop.Controls.Add(this.btnLamMoi);
   this.pnlTop.Controls.Add(this.btnTimKiem);
        this.pnlTop.Controls.Add(this.gbThoiGianThue);
        this.pnlTop.Controls.Add(this.gbTinhTrangThue);
         this.pnlTop.Controls.Add(this.cboHienTrang);
      this.pnlTop.Controls.Add(this.lblHienTrang);
            this.pnlTop.Controls.Add(this.cboGiaPhong);
          this.pnlTop.Controls.Add(this.lblGiaPhong);
            this.pnlTop.Controls.Add(this.cboTinhTrangPhong);
     this.pnlTop.Controls.Add(this.lblTinhTrangPhong);
this.pnlTop.Controls.Add(this.cboLoaiPhong);
            this.pnlTop.Controls.Add(this.lblLoaiPhong);
            this.pnlTop.Controls.Add(this.lblSubtitle);
     this.pnlTop.Controls.Add(this.lblTitle);

       // Bottom panel
       this.pnlBottom = new System.Windows.Forms.Panel();
    this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(240, 241, 245);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
  this.pnlBottom.Location = new System.Drawing.Point(0, 160);
       this.pnlBottom.Name = "pnlBottom";
       this.pnlBottom.Padding = new System.Windows.Forms.Padding(10);
      this.pnlBottom.Size = new System.Drawing.Size(1050, 440);

 this.lblSoDoPhong = new System.Windows.Forms.Label();
            this.lblSoDoPhong.Dock = System.Windows.Forms.DockStyle.Top;
  this.lblSoDoPhong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSoDoPhong.Location = new System.Drawing.Point(10, 10);
  this.lblSoDoPhong.Name = "lblSoDoPhong";
            this.lblSoDoPhong.Size = new System.Drawing.Size(1030, 30);
    this.lblSoDoPhong.Text = "SƠ ĐỒ PHÒNG (Nhấp chuột phải để xem chi tiết)";
   this.lblSoDoPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

     this.flpRooms = new System.Windows.Forms.FlowLayoutPanel();
 this.flpRooms.AutoScroll = true;
            this.flpRooms.BackColor = System.Drawing.Color.FromArgb(240, 241, 245);
        this.flpRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpRooms.Location = new System.Drawing.Point(10, 40);
            this.flpRooms.Name = "flpRooms";
          this.flpRooms.Size = new System.Drawing.Size(1030, 390);

     this.pnlBottom.Controls.Add(this.flpRooms);
            this.pnlBottom.Controls.Add(this.lblSoDoPhong);

    // UCBookingModern
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.Controls.Add(this.pnlBottom);
  this.Controls.Add(this.pnlTop);
            this.Name = "UCBookingModern";
            this.Size = new System.Drawing.Size(1050, 600);
        }
    }
}
