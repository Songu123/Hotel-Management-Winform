using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.UI.Room_Service
{
    public partial class UCRoom : UserControl
    {
        private readonly IRoomService _roomService;
        private readonly HotelDbContext _dbContext;
    private List<Room> _allRooms = new();
    private List<Amenity> _allAmenities = new();
        private Amenity _selectedAmenity;
        private AmenityEditMode _amenityMode = AmenityEditMode.View;

      private enum AmenityEditMode
        {
    View,
   Add,
            Edit
        }

     public UCRoom()
        {
        InitializeComponent();
        }

        public UCRoom(IRoomService roomService, HotelDbContext dbContext) : this()
   {
            _roomService = roomService;
        _dbContext = dbContext;
        }

        private async void UCRoom_Load(object sender, EventArgs e)
     {
            try
    {
       await LoadRoomDataAsync();
        InitializeComboBoxes();
      InitializeAmenityHandlers();
         LoadAmenityData();
            }
  catch (Exception ex)
 {
          MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadRoomDataAsync()
        {
         try
            {
        if (_roomService == null) return;

     var rooms = await _roomService.GetAllRoomsAsync();
  _allRooms = rooms.Where(r => r.IsDeleted == 0).ToList();
   BindRoomDataToGrid(_allRooms);
  }
  catch (Exception ex)
 {
       MessageBox.Show($"Lỗi tải phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
     }
        }

        private void BindRoomDataToGrid(List<Room> rooms)
        {
     if (dgvRooms == null) return;

     dgvRooms.Rows.Clear();
            int stt = 1;
        foreach (var room in rooms)
  {
  dgvRooms.Rows.Add(
  stt++,
           room.RoomId,
             room.Name,
   GetRoomType(room.RoomType),
 room.Price.ToString("N0") + " VND",
     GetRoomTypeDetails(room.RoomTypeDetails),
   GetStatusDisplay(room.Status),
      GetCurrentConditionDisplay(room.CurrentCondition)
 );
     }
        }

        private void InitializeComboBoxes()
        {
 cbRoomType.Items.Clear();
cbRoomType.Items.Add("Tất cả loại phòng");
     cbRoomType.Items.Add("Thường");
 cbRoomType.Items.Add("VIP");
            cbRoomType.Items.Add("Deluxe");
     cbRoomType.Items.Add("Suite");
   cbRoomType.SelectedIndex = 0;

            cbRoomTypeDetails.Items.Clear();
     cbRoomTypeDetails.Items.Add("Tất cả");
 cbRoomTypeDetails.Items.Add("Phòng đơn");
       cbRoomTypeDetails.Items.Add("Phòng đôi");
            cbRoomTypeDetails.Items.Add("Phòng gia đình");
  cbRoomTypeDetails.SelectedIndex = 0;

         cbPrice.Items.Clear();
    cbPrice.Items.Add("Tất cả giá");
            cbPrice.Items.Add("Dưới 100,000 VND");
     cbPrice.Items.Add("100,000 - 200,000 VND");
     cbPrice.Items.Add("200,000 - 300,000 VND");
  cbPrice.Items.Add("Trên 300,000 VND");
  cbPrice.SelectedIndex = 0;

cbStatus.Items.Clear();
      cbStatus.Items.Add("Tất cả tình trạng");
 cbStatus.Items.Add("Chưa dọn phòng");
            cbStatus.Items.Add("Trống");
          cbStatus.Items.Add("Đã đặt");
      cbStatus.SelectedIndex = 0;

            cbCurrentCondition.Items.Clear();
            cbCurrentCondition.Items.Add("Tất cả hiện trạng");
 cbCurrentCondition.Items.Add("Mới");
    cbCurrentCondition.Items.Add("Tốt");
      cbCurrentCondition.Items.Add("Cần sửa chữa");
        cbCurrentCondition.SelectedIndex = 0;
        }

        private string GetRoomType(int roomType) => roomType switch
        {
            1 => "Thường",
   2 => "VIP",
     3 => "Deluxe",
     4 => "Suite",
            _ => "Không xác định"
     };

 private string GetRoomTypeDetails(int details) => details switch
        {
 1 => "Phòng đơn",
    2 => "Phòng đôi",
            3 => "Phòng gia đình",
            _ => "Không xác định"
        };

    private string GetStatusDisplay(int status) => status switch
      {
        0 => "Chưa dọn phòng",
            1 => "Trống",
  2 => "Đã đặt",
       _ => "Không xác định"
  };

        private string GetCurrentConditionDisplay(int condition) => condition switch
{
        0 => "Mới",
         1 => "Tốt",
2 => "Cần sửa chữa",
            _ => "Không xác định"
        };

        private async void tbRoomId_TextChanged(object sender, EventArgs e) => await ApplyFiltersAsync();
        private async void tbRoomName_TextChanged(object sender, EventArgs e) => await ApplyFiltersAsync();
        private async void cbRoomType_SelectedIndexChanged(object sender, EventArgs e) => await ApplyFiltersAsync();
 private async void cbRoomTypeDetails_SelectedIndexChanged(object sender, EventArgs e) => await ApplyFiltersAsync();
        private async void cbPrice_SelectedIndexChanged(object sender, EventArgs e) => await ApplyFiltersAsync();
        private async void cbStatus_SelectedIndexChanged(object sender, EventArgs e) => await ApplyFiltersAsync();
        private async void cbCurrentCondition_SelectedIndexChanged(object sender, EventArgs e) => await ApplyFiltersAsync();

  private async Task ApplyFiltersAsync()
        {
            try
     {
       var filteredRooms = _allRooms.AsEnumerable();

      var roomId = tbRoomId?.Text?.Trim() ?? string.Empty;
                if (!string.IsNullOrEmpty(roomId))
        filteredRooms = filteredRooms.Where(r => r.RoomId.Contains(roomId, StringComparison.OrdinalIgnoreCase));

        var roomName = tbRoomName?.Text?.Trim() ?? string.Empty;
           if (!string.IsNullOrEmpty(roomName))
    filteredRooms = filteredRooms.Where(r => r.Name.Contains(roomName, StringComparison.OrdinalIgnoreCase));

     int roomTypeIndex = cbRoomType?.SelectedIndex ?? 0;
         if (roomTypeIndex > 0)
          filteredRooms = filteredRooms.Where(r => r.RoomType == roomTypeIndex);

      int detailsIndex = cbRoomTypeDetails?.SelectedIndex ?? 0;
        if (detailsIndex > 0)
                    filteredRooms = filteredRooms.Where(r => r.RoomTypeDetails == detailsIndex);

  int priceIndex = cbPrice?.SelectedIndex ?? 0;
          filteredRooms = priceIndex switch
          {
         1 => filteredRooms.Where(r => r.Price < 100000),
         2 => filteredRooms.Where(r => r.Price >= 100000 && r.Price < 200000),
     3 => filteredRooms.Where(r => r.Price >= 200000 && r.Price < 300000),
       4 => filteredRooms.Where(r => r.Price >= 300000),
      _ => filteredRooms
     };

     int statusIndex = cbStatus?.SelectedIndex ?? 0;
     if (statusIndex > 0)
   filteredRooms = filteredRooms.Where(r => r.Status == statusIndex - 1);

      int conditionIndex = cbCurrentCondition?.SelectedIndex ?? 0;
     if (conditionIndex > 0)
      filteredRooms = filteredRooms.Where(r => r.CurrentCondition == conditionIndex - 1);

       BindRoomDataToGrid(filteredRooms.ToList());
   }
   catch (Exception ex)
  {
        MessageBox.Show($"Lỗi lọc dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
        }

    private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kết quả tìm kiếm đã được cập nhật", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadRoomDataAsync();
            ResetFilters();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
        if (_roomService == null || _dbContext == null)
         {
     MessageBox.Show("Thiếu dữ liệu cấu hình", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
      return;
            }

          using var form = new AddRoomForm(_dbContext);
      if (form.ShowDialog() == DialogResult.OK)
  {
   _ = LoadRoomDataAsync();
    }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
     {
 if (dgvRooms.SelectedRows.Count == 0)
     {
        MessageBox.Show("Vui lòng chọn phòng cần xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
      return;
    }

            var roomId = dgvRooms.SelectedRows[0].Cells[1].Value?.ToString();
 var room = _allRooms.FirstOrDefault(r => r.RoomId == roomId);

            if (room != null)
            {
  using var detail = new RoomDetailForm(roomId, _dbContext);
      if (detail.ShowDialog() == DialogResult.OK)
      {
             _ = LoadRoomDataAsync();
            }
            }
        }

     private void ResetFilters()
        {
            tbRoomId.Clear();
tbRoomName.Clear();
    cbRoomType.SelectedIndex = 0;
          cbRoomTypeDetails.SelectedIndex = 0;
   cbPrice.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
  cbCurrentCondition.SelectedIndex = 0;
        }

        private void InitializeAmenityHandlers()
  {
       if (tbAmenitySearch != null)
 tbAmenitySearch.TextChanged += (s, e) => ApplyAmenityFilter();

    if (dgvAmenities != null)
                dgvAmenities.SelectionChanged += DgvAmenities_SelectionChanged;

            if (btnAmenityAdd != null)
              btnAmenityAdd.Click += BtnAmenityAdd_Click;

     if (btnAmenityEdit != null)
             btnAmenityEdit.Click += BtnAmenityEdit_Click;

            if (btnAmenityDelete != null)
        btnAmenityDelete.Click += BtnAmenityDelete_Click;

     if (btnAmenitySave != null)
   btnAmenitySave.Click += BtnAmenitySave_Click;

            if (btnAmenityCancel != null)
         btnAmenityCancel.Click += BtnAmenityCancel_Click;
        }

        private void LoadAmenityData()
     {
            if (_dbContext == null) return;

       _allAmenities = _dbContext.Amenities.Where(a => a.IsDeleted == 0).ToList();
        BindAmenityGrid(_allAmenities);
  SetAmenityMode(AmenityEditMode.View);
        }

        private void BindAmenityGrid(List<Amenity> amenities)
      {
if (dgvAmenities == null) return;

    dgvAmenities.Rows.Clear();
    int stt = 1;
            foreach (var amenity in amenities)
     {
        dgvAmenities.Rows.Add(stt++, amenity.AmenityId, amenity.Name);
      }
     dgvAmenities.ClearSelection();
        }

 private void ApplyAmenityFilter()
        {
            var search = tbAmenitySearch?.Text?.Trim() ?? string.Empty;
     var filtered = _allAmenities.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(search))
            {
  filtered = filtered.Where(a =>
   a.AmenityId.Contains(search, StringComparison.OrdinalIgnoreCase) ||
a.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
            }

 BindAmenityGrid(filtered.ToList());
        }

        private void DgvAmenities_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAmenities.SelectedRows.Count == 0)
            {
                _selectedAmenity = null;
       ClearAmenityForm();
       return;
            }

var amenityId = dgvAmenities.SelectedRows[0].Cells[1].Value?.ToString();
        _selectedAmenity = _allAmenities.FirstOrDefault(a => a.AmenityId == amenityId);

            if (_selectedAmenity != null)
            {
           tbAmenityId.Text = _selectedAmenity.AmenityId;
            tbAmenityName.Text = _selectedAmenity.Name;
     SetAmenityMode(AmenityEditMode.View);
            }
        }

     private void BtnAmenityAdd_Click(object sender, EventArgs e)
   {
     ClearAmenityForm();
   SetAmenityMode(AmenityEditMode.Add);
  tbAmenityId.Focus();
        }

      private void BtnAmenityEdit_Click(object sender, EventArgs e)
     {
          if (_selectedAmenity == null)
            {
              MessageBox.Show("Vui lòng chọn tiện ích cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
         return;
            }

          SetAmenityMode(AmenityEditMode.Edit);
    tbAmenityName.Focus();
        }

      private void BtnAmenityDelete_Click(object sender, EventArgs e)
        {
  if (_selectedAmenity == null)
       {
      MessageBox.Show("Vui lòng chọn tiện ích cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
       return;
      }

   var result = MessageBox.Show("Bạn có chắc muốn xóa tiện ích này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
 if (result != DialogResult.Yes) return;

       try
         {
          _selectedAmenity.IsDeleted = 1;
    _dbContext.Amenities.Update(_selectedAmenity);
       _dbContext.SaveChanges();
          LoadAmenityData();
        }
       catch (Exception ex)
       {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
  }
     }

        private void BtnAmenitySave_Click(object sender, EventArgs e)
  {
            var id = tbAmenityId.Text.Trim();
            var name = tbAmenityName.Text.Trim();

       if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name))
            {
          MessageBox.Show("Vui lòng nhập đầy đủ thông tin tiện ích", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
       return;
      }

            try
         {
 if (_amenityMode == AmenityEditMode.Add)
             {
   if (_dbContext.Amenities.Any(a => a.AmenityId == id))
        {
            MessageBox.Show("Mã tiện ích đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
           }

             var amenity = new Amenity { AmenityId = id, Name = name, IsDeleted = 0 };
         _dbContext.Amenities.Add(amenity);
  }
                else if (_amenityMode == AmenityEditMode.Edit && _selectedAmenity != null)
 {
  _selectedAmenity.Name = name;
   _dbContext.Amenities.Update(_selectedAmenity);
    }

    _dbContext.SaveChanges();
    LoadAmenityData();
    }
            catch (Exception ex)
            {
MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
        }

        private void BtnAmenityCancel_Click(object sender, EventArgs e)
        {
     if (_selectedAmenity != null)
  {
    tbAmenityId.Text = _selectedAmenity.AmenityId;
        tbAmenityName.Text = _selectedAmenity.Name;
  }
            else
            {
     ClearAmenityForm();
       }

         SetAmenityMode(AmenityEditMode.View);
        }

        private void SetAmenityMode(AmenityEditMode mode)
        {
            _amenityMode = mode;

          bool isEdit = mode == AmenityEditMode.Edit;
            bool isAdd = mode == AmenityEditMode.Add;

   tbAmenityId.ReadOnly = !isAdd;
      tbAmenityName.ReadOnly = !(isAdd || isEdit);

            btnAmenityAdd.Enabled = mode == AmenityEditMode.View;
            btnAmenityEdit.Enabled = mode == AmenityEditMode.View && _selectedAmenity != null;
            btnAmenityDelete.Enabled = mode == AmenityEditMode.View && _selectedAmenity != null;
            btnAmenitySave.Enabled = isAdd || isEdit;
         btnAmenityCancel.Enabled = isAdd || isEdit;
        }

        private void ClearAmenityForm()
        {
          tbAmenityId.Text = string.Empty;
   tbAmenityName.Text = string.Empty;
 }
    }
}
