using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.UI
{
    public partial class UCRooms : UserControl
    {
   private List<RoomInfo> allRooms = new List<RoomInfo>();
        private readonly IRoomService _roomService;

        public UCRooms()
        {
            InitializeComponent();
 }

    public UCRooms(IRoomService roomService) : this()
        {
         _roomService = roomService;
        }

      private async void UCRoomsCls_Load(object sender, EventArgs e)
{
            try
 {
      await LoadRoomDataFromDatabaseAsync();
          InitializeComboBoxes();
        LoadRoomsToGrid();
             AttachEventHandlers();
  }
        catch (Exception ex)
            {
            MessageBox.Show($"Error loading rooms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        InitializeRoomData();
        InitializeComboBoxes();
                LoadRoomsToGrid();
          AttachEventHandlers();
         }
        }

        private async Task LoadRoomDataFromDatabaseAsync()
        {
      try
       {
  allRooms.Clear();

          if (_roomService == null)
       {
     InitializeRoomData();
  return;
        }

 var dbRooms = await _roomService.GetAllRoomsAsync();

foreach (var dbRoom in dbRooms)
       {
   var roomInfo = new RoomInfo
           {
        RoomNumber = dbRoom.Name,
         Type = GetRoomType(dbRoom.RoomType),
           Floor = int.TryParse(dbRoom.RoomId?.Substring(0, 1), out int f) ? f : 1,
     Status = GetRoomStatus(dbRoom.Status),
     Price = dbRoom.Price,
 Guest = "-",
            CheckIn = "-",
CheckOut = "-"
                };

    allRooms.Add(roomInfo);
         }
         }
      catch (Exception ex)
  {
    MessageBox.Show($"Error loading from database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          InitializeRoomData();
    }
        }

        private string GetRoomType(int roomType)
   {
return roomType switch
       {
    1 => "Single",
        2 => "Double",
     3 => "Deluxe",
    4 => "Suite",
         _ => "Unknown"
            };
        }

        private RoomStatus GetRoomStatus(int dbStatus)
        {
            return dbStatus switch
            {
                0 => RoomStatus.Available,
    1 => RoomStatus.Occupied,
   2 => RoomStatus.Maintenance,
             3 => RoomStatus.Reserved,
           _ => RoomStatus.Available
            };
        }

        private void InitializeComboBoxes()
        {
            ComboBox cbxType = this.Controls.Find("cbxRoomType", true).FirstOrDefault() as ComboBox;
    if (cbxType != null)
            {
           cbxType.Items.Clear();
     cbxType.Items.Add("All");
         cbxType.Items.Add("Single");
          cbxType.Items.Add("Double");
              cbxType.Items.Add("Deluxe");
  cbxType.Items.Add("Suite");
 cbxType.SelectedIndex = 0;
     }

          ComboBox cbxStatus = this.Controls.Find("cbxStatus", true).FirstOrDefault() as ComboBox;
         if (cbxStatus != null)
       {
                cbxStatus.Items.Clear();
          cbxStatus.Items.Add("All");
          cbxStatus.Items.Add("Available");
    cbxStatus.Items.Add("Occupied");
       cbxStatus.Items.Add("Reserved");
 cbxStatus.Items.Add("Maintenance");
    cbxStatus.SelectedIndex = 0;
  }
        }

private void InitializeRoomData()
     {
  allRooms = new List<RoomInfo>
   {
         new RoomInfo { RoomNumber = "101", Type = "Single", Floor = 1, Status = RoomStatus.Available, Price = 500000, Guest = "-", CheckIn = "-", CheckOut = "-" },
       new RoomInfo { RoomNumber = "102", Type = "Double", Floor = 1, Status = RoomStatus.Occupied, Price = 700000, Guest = "Nguyễn Văn A", CheckIn = "2024-01-15", CheckOut = "2024-01-18" },
        new RoomInfo { RoomNumber = "103", Type = "Suite", Floor = 1, Status = RoomStatus.Available, Price = 1000000, Guest = "-", CheckIn = "-", CheckOut = "-" },
      new RoomInfo { RoomNumber = "201", Type = "Double", Floor = 2, Status = RoomStatus.Occupied, Price = 700000, Guest = "Trần Thị B", CheckIn = "2024-01-16", CheckOut = "2024-01-20" },
     new RoomInfo { RoomNumber = "202", Type = "Deluxe", Floor = 2, Status = RoomStatus.Available, Price = 1000000, Guest = "-", CheckIn = "-", CheckOut = "-" }
    };
        }

        private void LoadRoomsToGrid(List<RoomInfo> rooms = null)
        {
   var dataSource = rooms ?? allRooms;

  DataGridView dgv = this.Controls.Find("dgvRooms", true).FirstOrDefault() as DataGridView;
            if (dgv != null)
    {
     dgv.Rows.Clear();
                foreach (var room in dataSource.OrderBy(r => r.RoomNumber))
   {
   dgv.Rows.Add(
            room.RoomNumber,
    room.Type,
       room.Floor,
            GetStatusDisplay(room.Status),
          room.Price.ToString("N0"),
        room.Guest,
     room.CheckIn,
     room.CheckOut,
          "Edit | Delete"
     );

      DataGridViewRow lastRow = dgv.Rows[dgv.Rows.Count - 1];
      lastRow.DefaultCellStyle.BackColor = GetStatusColor(room.Status);
    }
 }
        }

        private string GetStatusDisplay(RoomStatus status)
        {
      return status switch
            {
      RoomStatus.Available => "✅ Available",
             RoomStatus.Occupied => "👥 Occupied",
           RoomStatus.Maintenance => "🔧 Maintenance",
           RoomStatus.Reserved => "📅 Reserved",
    _ => "Unknown"
      };
        }

      private Color GetStatusColor(RoomStatus status)
      {
            return status switch
   {
   RoomStatus.Available => Color.FromArgb(200, 240, 200),
                RoomStatus.Occupied => Color.FromArgb(240, 200, 200),
          RoomStatus.Reserved => Color.FromArgb(200, 220, 240),
          RoomStatus.Maintenance => Color.FromArgb(240, 230, 200),
 _ => Color.White
     };
        }

   private void AttachEventHandlers()
        {
            Button btnSearch = this.Controls.Find("btnSearch", true).FirstOrDefault() as Button;
            Button btnAdd = this.Controls.Find("btnAddRoom", true).FirstOrDefault() as Button;
     Button btnEdit = this.Controls.Find("btnEditRoom", true).FirstOrDefault() as Button;
            Button btnDelete = this.Controls.Find("btnDeleteRoom", true).FirstOrDefault() as Button;
            Button btnRefresh = this.Controls.Find("btnRefresh", true).FirstOrDefault() as Button;
            DataGridView dgv = this.Controls.Find("dgvRooms", true).FirstOrDefault() as DataGridView;

        if (btnSearch != null) btnSearch.Click += BtnSearch_Click;
          if (btnAdd != null) btnAdd.Click += BtnAdd_Click;
    if (btnEdit != null) btnEdit.Click += BtnEdit_Click;
       if (btnDelete != null) btnDelete.Click += BtnDelete_Click;
            if (btnRefresh != null) btnRefresh.Click += BtnRefresh_Click;
      if (dgv != null) dgv.CellClick += Dgv_CellClick;
        }

 private void BtnSearch_Click(object sender, EventArgs e)
        {
        TextBox tbxSearch = this.Controls.Find("tbxSearchRoom", true).FirstOrDefault() as TextBox;
     ComboBox cbxType = this.Controls.Find("cbxRoomType", true).FirstOrDefault() as ComboBox;
        ComboBox cbxStatus = this.Controls.Find("cbxStatus", true).FirstOrDefault() as ComboBox;

     var filtered = allRooms.AsEnumerable();

            if (tbxSearch != null && !string.IsNullOrWhiteSpace(tbxSearch.Text))
  {
          filtered = filtered.Where(r => r.RoomNumber.Contains(tbxSearch.Text));
            }

            if (cbxType != null && cbxType.SelectedItem?.ToString() != "All")
            {
       filtered = filtered.Where(r => r.Type == cbxType.SelectedItem?.ToString());
            }

      if (cbxStatus != null && cbxStatus.SelectedItem?.ToString() != "All")
    {
     var statusStr = cbxStatus.SelectedItem?.ToString();
                RoomStatus? status = statusStr switch
     {
       "Available" => RoomStatus.Available,
          "Occupied" => RoomStatus.Occupied,
   "Maintenance" => RoomStatus.Maintenance,
          "Reserved" => RoomStatus.Reserved,
     _ => null
    };

  if (status.HasValue)
       filtered = filtered.Where(r => r.Status == status.Value);
            }

            LoadRoomsToGrid(filtered.ToList());
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Room Dialog", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
  DataGridView dgv = this.Controls.Find("dgvRooms", true).FirstOrDefault() as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
    string roomNo = dgv.SelectedRows[0].Cells[0].Value?.ToString();
         MessageBox.Show($"Edit Room {roomNo}", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
          {
     MessageBox.Show("Please select a room first!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
     }
      }

        private async void BtnDelete_Click(object sender, EventArgs e)
  {
            DataGridView dgv = this.Controls.Find("dgvRooms", true).FirstOrDefault() as DataGridView;
     if (dgv != null && dgv.SelectedRows.Count > 0)
         {
         string roomNo = dgv.SelectedRows[0].Cells[0].Value?.ToString();
     var selectedRoom = allRooms.FirstOrDefault(r => r.RoomNumber == roomNo);

           DialogResult result = MessageBox.Show($"Delete room {roomNo}?",
        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

     if (result == DialogResult.Yes)
          {
          try
   {
          if (selectedRoom != null)
 {
      allRooms.Remove(selectedRoom);
             LoadRoomsToGrid();
            MessageBox.Show("Room deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
          }
             catch (Exception ex)
        {
    MessageBox.Show($"Error deleting room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
         }
    }
          else
 {
     MessageBox.Show("Please select a room first!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
 }

        private async void BtnRefresh_Click(object sender, EventArgs e)
  {
            try
    {
     await LoadRoomDataFromDatabaseAsync();
                LoadRoomsToGrid();
    MessageBox.Show("Room list refreshed!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
          catch (Exception ex)
       {
              MessageBox.Show($"Error refreshing: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
        }

private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
     if (e.RowIndex >= 0)
      {
          DataGridView dgv = sender as DataGridView;
                if (dgv != null)
        {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(220, 240, 250);
  }
   }
  }

        public Dictionary<string, int> GetRoomStatistics()
        {
    return new Dictionary<string, int>
        {
 { "Total", allRooms.Count },
           { "Available", allRooms.Count(r => r.Status == RoomStatus.Available) },
          { "Occupied", allRooms.Count(r => r.Status == RoomStatus.Occupied) },
        { "Maintenance", allRooms.Count(r => r.Status == RoomStatus.Maintenance) },
          { "Reserved", allRooms.Count(r => r.Status == RoomStatus.Reserved) }
            };
        }

        public decimal GetDailyRevenue()
        {
    return (decimal)allRooms
        .Where(r => r.Status == RoomStatus.Occupied)
  .Sum(r => r.Price);
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
        }
    }

    public enum RoomStatus
    {
        Available,
        Occupied,
     Maintenance,
        Reserved
    }

    public class RoomInfo
    {
        public string RoomNumber { get; set; }
   public string Type { get; set; }
        public int Floor { get; set; }
        public RoomStatus Status { get; set; }
public int Price { get; set; }
        public string Guest { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
    }
}
