using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.UI.BookingUI
{
    /// <summary>
    /// 🎯 Quick Room Allocation Component
    /// Seamlessly integrated with booking form for smooth workflow
    /// </summary>
    public partial class QuickRoomAllocationPanel : UserControl
    {
        private List<RoomRentalDetail> _selectedRooms = new();
 private DateTime _checkInDate;
        private DateTime _checkOutDate;

   public event EventHandler RoomsSelectionChanged;

     public List<RoomRentalDetail> SelectedRooms => _selectedRooms;

        public QuickRoomAllocationPanel()
   {
     InitializeComponent();
ConfigureUI();
        }

        private void ConfigureUI()
        {
            this.BackColor = Color.FromArgb(245, 245, 245);
    this.Padding = new Padding(15);

   // Header
            var headerPanel = new Panel
         {
         Height = 50,
         Dock = DockStyle.Top,
                BackColor = Color.FromArgb(59, 130, 246),
     Margin = new Padding(0, 0, 0, 10)
            };

         var headerLabel = new Label
            {
       Text = "📋 Phòng Được Chọn",
  Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
        Dock = DockStyle.Left,
                TextAlign = ContentAlignment.MiddleLeft,
       Padding = new Padding(15, 0, 0, 0)
            };
     headerPanel.Controls.Add(headerLabel);

      this.Controls.Add(headerPanel);

            // Summary info
    var summaryPanel = new Panel
            {
        Height = 60,
        Dock = DockStyle.Top,
   BackColor = Color.White,
          BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0, 0, 0, 10)
            };

   var lblSummary = new Label
  {
              Name = "lblSummary",
       Text = "✓ Đã chọn: 0 phòng | Tổng giá: 0 VNĐ | Thời gian: 0 đêm",
           Font = new Font("Segoe UI", 10),
     AutoSize = true,
  Location = new Point(15, 15)
};
            summaryPanel.Controls.Add(lblSummary);

         var btnAllocate = new Button
 {
    Text = "➕ Chọn Phòng",
       Width = 150,
       Height = 35,
             BackColor = Color.FromArgb(34, 197, 94),
                ForeColor = Color.White,
      FlatStyle = FlatStyle.Flat,
         Location = new Point(920, 12),
  Cursor = Cursors.Hand,
      Font = new Font("Segoe UI", 10, FontStyle.Bold)
  };
     btnAllocate.Click += (s, e) => OnAllocateRoomsClick();
     summaryPanel.Controls.Add(btnAllocate);

            this.Controls.Add(summaryPanel);

         // Rooms list
            var roomsPanel = new Panel
    {
    Dock = DockStyle.Fill,
           AutoScroll = true,
    BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
    };

          var roomsContainer = new FlowLayoutPanel
            {
                Name = "roomsContainer",
       AutoSize = true,
             AutoSizeMode = AutoSizeMode.GrowAndShrink,
           FlowDirection = FlowDirection.TopDown,
      WrapContents = false,
         Padding = new Padding(15),
         BackColor = Color.White
          };

   var emptyLabel = new Label
      {
  Name = "lblEmpty",
         Text = "Chưa chọn phòng nào - Nhấn 'Chọn Phòng' để bắt đầu",
   Font = new Font("Segoe UI", 10, FontStyle.Italic),
        ForeColor = Color.FromArgb(150, 150, 150),
  AutoSize = true,
    Margin = new Padding(0, 20, 0, 0)
            };
     roomsContainer.Controls.Add(emptyLabel);

  roomsPanel.Controls.Add(roomsContainer);
         this.Controls.Add(roomsPanel);
        }

      public void SetDateRange(DateTime checkInDate, DateTime checkOutDate)
   {
       _checkInDate = checkInDate;
 _checkOutDate = checkOutDate;
            UpdateSummary();
}

        public void AddRoom(RoomRentalDetail room)
    {
if (!_selectedRooms.Any(r => r.RoomId == room.RoomId))
       {
        _selectedRooms.Add(room);
        RefreshRoomsList();
            }
     }

        public void RemoveRoom(string roomId)
        {
          _selectedRooms.RemoveAll(r => r.RoomId == roomId);
      RefreshRoomsList();
        }

public void ClearAllRooms()
        {
            _selectedRooms.Clear();
RefreshRoomsList();
}

     private void RefreshRoomsList()
        {
 var container = this.Controls.Find("roomsContainer", true).FirstOrDefault() as FlowLayoutPanel;
       if (container == null) return;

            container.Controls.Clear();

            if (_selectedRooms.Count == 0)
      {
      var emptyLabel = new Label
  {
             Name = "lblEmpty",
               Text = "Chưa chọn phòng nào - Nhấn 'Chọn Phòng' để bắt đầu",
        Font = new Font("Segoe UI", 10, FontStyle.Italic),
   ForeColor = Color.FromArgb(150, 150, 150),
     AutoSize = true,
    Margin = new Padding(0, 20, 0, 0)
        };
          container.Controls.Add(emptyLabel);
            }
     else
     {
       int index = 1;
    foreach (var room in _selectedRooms)
{
        var roomCard = CreateRoomListCard(room, index++);
    container.Controls.Add(roomCard);
     }
      }

    UpdateSummary();
            RoomsSelectionChanged?.Invoke(this, EventArgs.Empty);
      }

   private Panel CreateRoomListCard(RoomRentalDetail room, int index)
        {
var nights = (int)(_checkOutDate - _checkInDate).TotalDays;
            var totalPrice = room.RentalPrice * nights;

            var card = new Panel
            {
    Width = 900,
   Height = 80,
          BackColor = Color.FromArgb(250, 250, 250),
        BorderStyle = BorderStyle.FixedSingle,
     Margin = new Padding(0, 5, 0, 5),
       Padding = new Padding(15)
            };

            var lblIndex = new Label
      {
       Text = $"#{index}",
     Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(59, 130, 246),
                AutoSize = true,
                Location = new Point(10, 10)
        };
    card.Controls.Add(lblIndex);

  var lblRoom = new Label
          {
            Text = $"Phòng {room.RoomId}",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
    ForeColor = Color.Black,
     AutoSize = true,
        Location = new Point(50, 10)
        };
        card.Controls.Add(lblRoom);

     var lblDates = new Label
  {
    Text = $"🗓️ {room.RentalDate:dd/MM/yyyy} → {room.ReturnDate:dd/MM/yyyy} ({nights} đêm)",
Font = new Font("Segoe UI", 9),
              ForeColor = Color.FromArgb(100, 100, 100),
AutoSize = true,
                Location = new Point(50, 35)
            };
     card.Controls.Add(lblDates);

       var lblPrice = new Label
     {
                Text = $"💰 Giá: {room.RentalPrice:N0} VNĐ/đêm × {nights} đêm = {totalPrice:N0} VNĐ",
            Font = new Font("Segoe UI", 9, FontStyle.Bold),
   ForeColor = Color.FromArgb(200, 50, 50),
            AutoSize = true,
    Location = new Point(50, 55)
  };
       card.Controls.Add(lblPrice);

   var btnRemove = new Button
            {
      Text = "✕",
      Width = 40,
      Height = 40,
         BackColor = Color.FromArgb(220, 50, 50),
         ForeColor = Color.White,
 FlatStyle = FlatStyle.Flat,
Location = new Point(850, 15),
       Cursor = Cursors.Hand,
       Font = new Font("Segoe UI", 12, FontStyle.Bold)
 };
       btnRemove.Click += (s, e) =>
     {
   RemoveRoom(room.RoomId);
         };
      card.Controls.Add(btnRemove);

            return card;
        }

   private void UpdateSummary()
  {
var lblSummary = this.Controls.Find("lblSummary", true).FirstOrDefault() as Label;
  if (lblSummary == null) return;

            var nights = _checkOutDate > _checkInDate ? (int)(_checkOutDate - _checkInDate).TotalDays : 0;
          var totalPrice = _selectedRooms.Sum(r => r.RentalPrice * nights);

            lblSummary.Text = nights > 0
           ? $"✓ Đã chọn: {_selectedRooms.Count} phòng | Tổng giá: {totalPrice:N0} VNĐ | Thời gian: {nights} đêm"
          : "✓ Đã chọn: 0 phòng | Tổng giá: 0 VNĐ | Thời gian: 0 đêm";
        }

        protected virtual void OnAllocateRoomsClick()
        {
            // Override in derived classes or handle via events
  }
    }
}
