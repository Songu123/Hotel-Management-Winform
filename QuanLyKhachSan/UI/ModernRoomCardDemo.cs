using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.UI
{
    /// <summary>
  /// Example form demonstrating ModernRoomCardContainer usage
    /// </summary>
    public partial class ModernRoomCardDemo : Form
    {
        private ModernRoomCardContainer _roomCardContainer;

   public ModernRoomCardDemo()
      {
      InitializeComponent();
          SetupUI();
        }

 private void SetupUI()
  {
   this.Text = "Modern Room Card Demo";
      this.Size = new System.Drawing.Size(1200, 700);
  this.StartPosition = FormStartPosition.CenterScreen;

          // Create container
         _roomCardContainer = new ModernRoomCardContainer();
        _roomCardContainer.Dock = DockStyle.Fill;
        _roomCardContainer.SetColumnCount(3);

   // Subscribe to events
      _roomCardContainer.ViewDetailsClicked += (s, room) => ShowRoomDetails(room);
      _roomCardContainer.BookingClicked += (s, room) => ShowBookingForm(room);
 _roomCardContainer.CleaningClicked += (s, room) => ShowCleaningForm(room);

   this.Controls.Add(_roomCardContainer);

       // Load sample data
       LoadSampleRooms();
   }

   private void LoadSampleRooms()
        {
   var rooms = new List<Room>
    {
 new Room { RoomId = "R001", Name = "Phòng 101", RoomType = 1, Price = 200000, Status = 0 },
         new Room { RoomId = "R002", Name = "Phòng 102", RoomType = 2, Price = 300000, Status = 1 },
     new Room { RoomId = "R003", Name = "Phòng 103", RoomType = 3, Price = 400000, Status = 0 },
      new Room { RoomId = "R004", Name = "Phòng 201", RoomType = 1, Price = 200000, Status = 2 },
  new Room { RoomId = "R005", Name = "Phòng 202", RoomType = 4, Price = 600000, Status = 0 },
  new Room { RoomId = "R006", Name = "Phòng 203", RoomType = 5, Price = 1000000, Status = 3 },
    };

     // Add rooms with different statuses
  _roomCardContainer.AddRoom(rooms[0], RoomStatusType.Available);
     _roomCardContainer.AddRoom(rooms[1], RoomStatusType.Occupied);
     _roomCardContainer.AddRoom(rooms[2], RoomStatusType.Available);
    _roomCardContainer.AddRoom(rooms[3], RoomStatusType.Cleaning);
        _roomCardContainer.AddRoom(rooms[4], RoomStatusType.Available);
  _roomCardContainer.AddRoom(rooms[5], RoomStatusType.Maintenance);
   }

  private void ShowRoomDetails(Room room)
       {
     MessageBox.Show($"Xem chi tiết phòng {room.Name}", "Chi tiết phòng",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

   private void ShowBookingForm(Room room)
       {
   MessageBox.Show($"Đặt phòng {room.Name} với giá {room.Price:N0} VNĐ", "Đặt phòng",
 MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

  private void ShowCleaningForm(Room room)
  {
     MessageBox.Show($"Dọn dẹp phòng {room.Name}", "Dọn dẹp phòng",
 MessageBoxButtons.OK, MessageBoxIcon.Information);
     }
    }
}
