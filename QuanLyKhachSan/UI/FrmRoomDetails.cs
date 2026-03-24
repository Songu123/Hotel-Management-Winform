using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.UI
{
    public partial class FrmRoomDetails : Form
    {
        private Room _room;
        private HotelDbContext _dbContext;
        private List<RoomAmenity> _roomAmenities = new();

    // Controls
        private TextBox tbRoomId;
   private TextBox tbRoomName;
        private ComboBox cbRoomType;
        private ComboBox cbRoomTypeDetails;
 private TextBox tbPrice;
     private ComboBox cbStatus;
        private ComboBox cbCurrentCondition;
        private DataGridView dgvAvailableAmenities;
    private DataGridView dgvRoomAmenities;
        private ComboBox cbAmenity;
        private NumericUpDown numQuantity;
    private Button btnAddAmenity;

        public FrmRoomDetails(Room room, HotelDbContext dbContext)
        {
  _room = room;
       _dbContext = dbContext;
   InitializeComponent();
        LoadRoomDetails();
        }

        private void InitializeComponent()
    {
      this.Text = "Thông Tin Chi Tiết Phòng";
       this.Width = 1100;
            this.Height = 800;
  this.StartPosition = FormStartPosition.CenterScreen;
         this.BackColor = Color.White;
     this.FormBorderStyle = FormBorderStyle.FixedDialog;
     this.MaximizeBox = false;
            this.MinimizeBox = false;

      // Main container with scroll
        var pnlContainer = new Panel { Dock = DockStyle.Fill, AutoScroll = true };

 // Header
          var pnlHeader = new Panel
            {
    Dock = DockStyle.Top,
 Height = 60,
    BackColor = Color.FromArgb(70, 130, 180)
         };
    var lblHeader = new Label
      {
 Text = "THÔNG TIN CHI TIẾT PHÒNG",
          Dock = DockStyle.Fill,
    Font = new Font("Segoe UI", 14F, FontStyle.Bold),
       ForeColor = Color.White,
       TextAlign = ContentAlignment.MiddleLeft,
        Padding = new Padding(20, 0, 0, 0)
            };
            pnlHeader.Controls.Add(lblHeader);
     pnlContainer.Controls.Add(pnlHeader);

 // Room Info Section
          var gbRoomInfo = new GroupBox
       {
Text = "THÔNG TIN PHÒNG",
            Dock = DockStyle.Top,
        Height = 200,
                Padding = new Padding(15),
                BackColor = Color.White,
      Margin = new Padding(0, 0, 0, 0),
              Font = new Font("Segoe UI", 10F, FontStyle.Bold)
     };

   tbRoomId = new TextBox { Location = new Point(120, 30), Width = 250, ReadOnly = true, Font = new Font("Segoe UI", 9F) };
            gbRoomInfo.Controls.Add(new Label { Text = "Mã phòng:", Location = new Point(15, 33), AutoSize = true });
         gbRoomInfo.Controls.Add(tbRoomId);

            tbRoomName = new TextBox { Location = new Point(650, 30), Width = 250, ReadOnly = true, Font = new Font("Segoe UI", 9F) };
     gbRoomInfo.Controls.Add(new Label { Text = "Tên phòng:", Location = new Point(545, 33), AutoSize = true });
            gbRoomInfo.Controls.Add(tbRoomName);

    cbRoomType = new ComboBox { Location = new Point(120, 70), Width = 250, DropDownStyle = ComboBoxStyle.DropDownList, Enabled = false };
            cbRoomType.Items.AddRange(new[] { "Thường", "VIP", "Deluxe", "Suite" });
     gbRoomInfo.Controls.Add(new Label { Text = "Loại phòng:", Location = new Point(15, 73), AutoSize = true });
     gbRoomInfo.Controls.Add(cbRoomType);

      cbRoomTypeDetails = new ComboBox { Location = new Point(650, 70), Width = 250, DropDownStyle = ComboBoxStyle.DropDownList, Enabled = false };
 cbRoomTypeDetails.Items.AddRange(new[] { "Phòng đơn", "Phòng đôi", "Phòng gia đình" });
          gbRoomInfo.Controls.Add(new Label { Text = "Chi tiết loại phòng:", Location = new Point(545, 73), AutoSize = true });
      gbRoomInfo.Controls.Add(cbRoomTypeDetails);

        tbPrice = new TextBox { Location = new Point(120, 110), Width = 250, ReadOnly = true, Font = new Font("Segoe UI", 9F) };
  gbRoomInfo.Controls.Add(new Label { Text = "Giá phòng:", Location = new Point(15, 113), AutoSize = true });
        gbRoomInfo.Controls.Add(tbPrice);

          cbStatus = new ComboBox { Location = new Point(650, 110), Width = 250, DropDownStyle = ComboBoxStyle.DropDownList, Enabled = false };
  cbStatus.Items.AddRange(new[] { "Chưa dọn phòng", "Trống", "Đã đặt" });
            gbRoomInfo.Controls.Add(new Label { Text = "Tình trạng:", Location = new Point(545, 113), AutoSize = true });
   gbRoomInfo.Controls.Add(cbStatus);

    cbCurrentCondition = new ComboBox { Location = new Point(120, 150), Width = 250, DropDownStyle = ComboBoxStyle.DropDownList, Enabled = false };
            cbCurrentCondition.Items.AddRange(new[] { "Mới", "Tốt", "Cần sửa chữa" });
 gbRoomInfo.Controls.Add(new Label { Text = "Hiện trạng:", Location = new Point(15, 153), AutoSize = true });
            gbRoomInfo.Controls.Add(cbCurrentCondition);

          pnlContainer.Controls.Add(gbRoomInfo);

            // Available Amenities Section
     var gbAvailableAmenities = new GroupBox
          {
  Text = "DANH SÁCH TIỆN ÍCH KHÁCH SẠN CÓ",
    Dock = DockStyle.Top,
    Height = 250,
           Padding = new Padding(15),
       Margin = new Padding(0, 10, 0, 0),
      Font = new Font("Segoe UI", 10F, FontStyle.Bold)
         };

            dgvAvailableAmenities = new DataGridView
            {
             Dock = DockStyle.Fill,
      AllowUserToAddRows = false,
    AllowUserToDeleteRows = false,
     BackgroundColor = Color.White,
      RowTemplate = { Height = 25 },
      AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
           SelectionMode = DataGridViewSelectionMode.FullRowSelect
  };
            dgvAvailableAmenities.Columns.AddRange(
              new DataGridViewTextBoxColumn { HeaderText = "STT", Name = "colSTT", Width = 40 },
      new DataGridViewTextBoxColumn { HeaderText = "MÃ TIỆN ÍCH", Name = "colAmenityId" },
      new DataGridViewTextBoxColumn { HeaderText = "TÊN TIỆN ÍCH", Name = "colAmenityName" }
 );

            gbAvailableAmenities.Controls.Add(dgvAvailableAmenities);
       pnlContainer.Controls.Add(gbAvailableAmenities);

       // Add Amenity to Room Section
var gbAddAmenity = new GroupBox
      {
     Text = "THÊM TIỆN ÍCH CHO PHÒNG",
            Dock = DockStyle.Top,
        Height = 120,
            Padding = new Padding(15),
        Margin = new Padding(0, 10, 0, 0),
       Font = new Font("Segoe UI", 10F, FontStyle.Bold)
    };

            gbAddAmenity.Controls.Add(new Label { Text = "Nhập mã/tên tiện ích cần tìm...", Location = new Point(15, 30), AutoSize = true, Font = new Font("Segoe UI", 9F) });

            cbAmenity = new ComboBox { Location = new Point(15, 55), Width = 350, DropDownStyle = ComboBoxStyle.DropDownList, Font = new Font("Segoe UI", 9F) };
   gbAddAmenity.Controls.Add(cbAmenity);

            gbAddAmenity.Controls.Add(new Label { Text = "Số lượng:", Location = new Point(400, 58), AutoSize = true, Font = new Font("Segoe UI", 9F) });
            numQuantity = new NumericUpDown { Location = new Point(480, 55), Width = 80, Value = 1, Minimum = 1, Maximum = 100, Font = new Font("Segoe UI", 9F) };
        gbAddAmenity.Controls.Add(numQuantity);

    btnAddAmenity = new Button
        {
       Text = "Thêm tiện ích",
            Location = new Point(600, 53),
          Width = 120,
      Height = 30,
           BackColor = Color.SeaGreen,
            ForeColor = Color.White,
        Font = new Font("Segoe UI", 9F, FontStyle.Bold),
         FlatStyle = FlatStyle.Flat
            };
   btnAddAmenity.Click += (s, e) => AddAmenityToRoom();
  gbAddAmenity.Controls.Add(btnAddAmenity);

            pnlContainer.Controls.Add(gbAddAmenity);

        // Room Amenities Section (already added)
     var gbRoomAmenities = new GroupBox
     {
   Text = "DANH SÁCH TIỆN ÍCH CÓ TRONG PHÒNG",
   Dock = DockStyle.Top,
           Height = 300,
         Padding = new Padding(15),
    Margin = new Padding(0, 10, 0, 0),
            Font = new Font("Segoe UI", 10F, FontStyle.Bold)
        };

            dgvRoomAmenities = new DataGridView
            {
  Dock = DockStyle.Fill,
              AllowUserToAddRows = false,
           AllowUserToDeleteRows = false,
     BackgroundColor = Color.White,
            RowTemplate = { Height = 25 },
    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
     SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            dgvRoomAmenities.Columns.AddRange(
         new DataGridViewTextBoxColumn { HeaderText = "STT", Name = "colSTT", Width = 40 },
    new DataGridViewTextBoxColumn { HeaderText = "MÃ TIỆN ÍCH", Name = "colAmenityId" },
                new DataGridViewTextBoxColumn { HeaderText = "TÊN TIỆN ÍCH", Name = "colAmenityName" },
         new DataGridViewTextBoxColumn { HeaderText = "SỐ LƯỢNG", Name = "colQuantity", Width = 80 },
      new DataGridViewLinkColumn { HeaderText = "HÀNH ĐỘNG", Name = "colAction", Text = "Xóa", UseColumnTextForLinkValue = true, Width = 80 }
     );
    dgvRoomAmenities.CellClick += DgvRoomAmenities_CellClick;

   gbRoomAmenities.Controls.Add(dgvRoomAmenities);
     pnlContainer.Controls.Add(gbRoomAmenities);

       // Footer buttons
         var pnlButtons = new Panel
    {
    Dock = DockStyle.Bottom,
     Height = 60,
         BackColor = Color.WhiteSmoke
            };

            var btnSave = new Button
      {
          Text = "Sửa phòng",
           Location = new Point(750, 15),
           Width = 100,
    Height = 30,
                BackColor = Color.DodgerBlue,
       ForeColor = Color.White,
  Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            FlatStyle = FlatStyle.Flat
        };
            btnSave.Click += (s, e) => MessageBox.Show("Tính năng sửa phòng sẽ được cập nhật", "Thông báo");
        pnlButtons.Controls.Add(btnSave);

            var btnDelete = new Button
 {
    Text = "Xóa phòng",
        Location = new Point(860, 15),
    Width = 100,
   Height = 30,
            BackColor = Color.Tomato,
         ForeColor = Color.White,
    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
         FlatStyle = FlatStyle.Flat
         };
            btnDelete.Click += (s, e) => MessageBox.Show("Tính năng xóa phòng sẽ được cập nhật", "Thông báo");
            pnlButtons.Controls.Add(btnDelete);

            var btnClose = new Button
  {
          Text = "Đóng",
      Location = new Point(970, 15),
 Width = 100,
        Height = 30,
        BackColor = Color.Gray,
              ForeColor = Color.White,
    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
  FlatStyle = FlatStyle.Flat,
   DialogResult = DialogResult.OK
            };
            btnClose.Click += (s, e) => this.Close();
pnlButtons.Controls.Add(btnClose);

     this.Controls.Add(pnlContainer);
            this.Controls.Add(pnlButtons);
        }

        private void LoadRoomDetails()
        {
            try
     {
    // Load thông tin phòng
     tbRoomId.Text = _room.RoomId;
      tbRoomName.Text = _room.Name;
   cbRoomType.SelectedIndex = _room.RoomType - 1;
   cbRoomTypeDetails.SelectedIndex = _room.RoomTypeDetails - 1;
         tbPrice.Text = _room.Price.ToString("N0") + " VND";
        cbStatus.SelectedIndex = _room.Status;
       cbCurrentCondition.SelectedIndex = _room.CurrentCondition;

      // Load available amenities
        LoadAvailableAmenities();

         // Load room amenities
 LoadRoomAmenities();
  }
        catch (Exception ex)
         {
   MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
 }
        }

        private void LoadAvailableAmenities()
        {
            try
            {
    var allAmenities = _dbContext.Amenities.Where(a => a.IsDeleted == 0).ToList();

           // Bind to DataGridView
       dgvAvailableAmenities.Rows.Clear();
    int stt = 1;
           foreach (var amenity in allAmenities)
          {
             dgvAvailableAmenities.Rows.Add(stt++, amenity.AmenityId, amenity.Name);
      }

  // Bind to ComboBox
                cbAmenity.Items.Clear();
                cbAmenity.Items.Add("-- Chọn tiện ích --");
            foreach (var amenity in allAmenities)
     {
          cbAmenity.Items.Add(amenity);
       }
              cbAmenity.DisplayMember = "Name";
     cbAmenity.ValueMember = "AmenityId";
             cbAmenity.SelectedIndex = 0;
       }
            catch (Exception ex)
            {
           MessageBox.Show($"Lỗi tải danh sách tiện ích: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
   }

        private void LoadRoomAmenities()
     {
       try
      {
      _roomAmenities = _dbContext.RoomAmenities
 .Where(ra => ra.RoomId == _room.RoomId)
 .ToList();

      dgvRoomAmenities.Rows.Clear();
     int stt = 1;
    foreach (var ra in _roomAmenities)
         {
 var amenity = _dbContext.Amenities.FirstOrDefault(a => a.AmenityId == ra.AmenityId);
        if (amenity != null)
          {
       dgvRoomAmenities.Rows.Add(stt++, amenity.AmenityId, amenity.Name, ra.Quantity, "Xóa");
           }
                }
            }
        catch (Exception ex)
    {
    MessageBox.Show($"Lỗi tải tiện ích phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
   }
      }

        private void DgvRoomAmenities_CellClick(object sender, DataGridViewCellEventArgs e)
    {
     if (e.ColumnIndex == 4 && e.RowIndex >= 0)
        {
         if (MessageBox.Show("Bạn có chắc muốn xóa tiện ích này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
         {
           RemoveAmenityFromRoom(e.RowIndex);
         }
  }
        }

        private void AddAmenityToRoom()
        {
         try
  {
           if (cbAmenity.SelectedIndex <= 0)
    {
        MessageBox.Show("Vui lòng chọn tiện ích", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           return;
          }

        var selectedAmenity = cbAmenity.SelectedItem as Amenity;
    if (selectedAmenity == null) return;

       // Check if already exists
         var existing = _roomAmenities.FirstOrDefault(ra => ra.AmenityId == selectedAmenity.AmenityId);
       if (existing != null)
     {
  MessageBox.Show("Tiện ích này đã có trong phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
     return;
        }

   var roomAmenity = new RoomAmenity
                {
          RoomId = _room.RoomId,
      AmenityId = selectedAmenity.AmenityId,
       Quantity = (int)numQuantity.Value
                };

                _dbContext.RoomAmenities.Add(roomAmenity);
    _dbContext.SaveChanges();

        MessageBox.Show("Thêm tiện ích thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
    LoadRoomAmenities();
    LoadAvailableAmenities();
        numQuantity.Value = 1;
            }
   catch (Exception ex)
    {
         MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
 }

        private void RemoveAmenityFromRoom(int rowIndex)
        {
       try
   {
         var amenityId = dgvRoomAmenities.Rows[rowIndex].Cells[1].Value?.ToString();
      var roomAmenity = _roomAmenities.FirstOrDefault(ra => ra.AmenityId == amenityId);

     if (roomAmenity != null)
            {
         _dbContext.RoomAmenities.Remove(roomAmenity);
 _dbContext.SaveChanges();

          MessageBox.Show("Xóa tiện ích thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        LoadRoomAmenities();
    }
            }
         catch (Exception ex)
     {
       MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
     }
        }
    }
}
