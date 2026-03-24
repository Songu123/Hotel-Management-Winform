using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.UI
{
    public partial class UCRoomCards : UserControl
    {
  /// <summary>
        /// Room card data model
        /// </summary>
        private List<RoomCardInfo> roomList = new List<RoomCardInfo>();

 public UCRoomCards()
        {
            InitializeComponent();
        }

        private void UCRoomCards_Load(object sender, EventArgs e)
        {
         LoadRoomData();
            DisplayRoomCards();
   }

        /// <summary>
        /// Initialize sample room data
        /// </summary>
        private void LoadRoomData()
        {
 roomList = new List<RoomCardInfo>
        {
       // Available Rooms
    new RoomCardInfo { RoomNumber = "101", Type = "Single", Floor = 1, Status = "Available", Guest = "-", CheckInDate = "-", CheckOutDate = "-", Price = 50, DaysRemaining = 0 },
                new RoomCardInfo { RoomNumber = "103", Type = "Suite", Floor = 1, Status = "Available", Guest = "-", CheckInDate = "-", CheckOutDate = "-", Price = 150, DaysRemaining = 0 },
          new RoomCardInfo { RoomNumber = "105", Type = "Double", Floor = 1, Status = "Available", Guest = "-", CheckInDate = "-", CheckOutDate = "-", Price = 80, DaysRemaining = 0 },

      // Occupied Rooms
        new RoomCardInfo { RoomNumber = "102", Type = "Double", Floor = 1, Status = "Occupied", Guest = "Nguyễn Văn A", CheckInDate = "2024-01-15", CheckOutDate = "2024-01-18", Price = 80, DaysRemaining = 3 },
             new RoomCardInfo { RoomNumber = "104", Type = "Double", Floor = 1, Status = "Occupied", Guest = "Trần Thị B", CheckInDate = "2024-01-16", CheckOutDate = "2024-01-20", Price = 80, DaysRemaining = 4 },

    // Reserved Rooms
                new RoomCardInfo { RoomNumber = "106", Type = "Single", Floor = 1, Status = "Reserved", Guest = "Hoàng Văn C", CheckInDate = "2024-02-01", CheckOutDate = "2024-02-05", Price = 50, DaysRemaining = 11 },

        // Maintenance Rooms
     new RoomCardInfo { RoomNumber = "107", Type = "Double", Floor = 1, Status = "Maintenance", Guest = "-", CheckInDate = "-", CheckOutDate = "-", Price = 80, DaysRemaining = 0 },

        new RoomCardInfo { RoomNumber = "201", Type = "Suite", Floor = 2, Status = "Occupied", Guest = "Lê Thị D", CheckInDate = "2024-01-14", CheckOutDate = "2024-01-25", Price = 150, DaysRemaining = 11 },
              new RoomCardInfo { RoomNumber = "202", Type = "Deluxe", Floor = 2, Status = "Available", Guest = "-", CheckInDate = "-", CheckOutDate = "-", Price = 200, DaysRemaining = 0 },
   new RoomCardInfo { RoomNumber = "203", Type = "Double", Floor = 2, Status = "Occupied", Guest = "Phạm Văn E", CheckInDate = "2024-01-17", CheckOutDate = "2024-01-19", Price = 80, DaysRemaining = 2 },
     new RoomCardInfo { RoomNumber = "204", Type = "Deluxe", Floor = 2, Status = "Available", Guest = "-", CheckInDate = "-", CheckOutDate = "-", Price = 200, DaysRemaining = 0 },
           new RoomCardInfo { RoomNumber = "205", Type = "Single", Floor = 2, Status = "Available", Guest = "-", CheckInDate = "-", CheckOutDate = "-", Price = 50, DaysRemaining = 0 },
      new RoomCardInfo { RoomNumber = "206", Type = "Double", Floor = 2, Status = "Maintenance", Guest = "-", CheckInDate = "-", CheckOutDate = "-", Price = 80, DaysRemaining = 0 },
            };
        }

        /// <summary>
        /// Display room cards in the container
 /// </summary>
        private void DisplayRoomCards()
        {
   try
 {
       Panel containerPanel = this.Controls.Find("pnlRoomContainer", true).FirstOrDefault() as Panel;
           if (containerPanel != null)
       {
       containerPanel.Controls.Clear();
        int x = 10;
          int y = 10;
   int cardWidth = 280;
  int cardHeight = 280;
   int spacing = 10;
              int cardsPerRow = (containerPanel.Width - 20) / (cardWidth + spacing);

      if (cardsPerRow < 1) cardsPerRow = 1;

          int col = 0;
 foreach (var room in roomList.OrderBy(r => r.RoomNumber))
        {
    Panel roomCard = CreateRoomCard(room);
    roomCard.Location = new Point(x, y);
        containerPanel.Controls.Add(roomCard);

         col++;
    if (col >= cardsPerRow)
                 {
       col = 0;
                    y += cardHeight + spacing;
          x = 10;
          }
 else
     {
         x += cardWidth + spacing;
       }
    }
      }
    }
            catch (Exception ex)
   {
                MessageBox.Show("Error displaying room cards: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
        }

      /// <summary>
  /// Create a room card panel
     /// </summary>
        private Panel CreateRoomCard(RoomCardInfo room)
        {
       Panel card = new Panel();
            card.Width = 280;
            card.Height = 280;
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;
 card.Padding = new Padding(15);

     // Status color bar at top
            Panel statusBar = new Panel();
   statusBar.Height = 4;
  statusBar.Dock = DockStyle.Top;
   statusBar.BackColor = GetStatusColor(room.Status);
 card.Controls.Add(statusBar);

       // Room number (large, prominent)
   Label lblRoomNumber = new Label();
    lblRoomNumber.Text = $"Room {room.RoomNumber}";
        lblRoomNumber.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblRoomNumber.ForeColor = Color.FromArgb(30, 40, 60);
            lblRoomNumber.Location = new Point(15, 12);
    lblRoomNumber.AutoSize = true;
  card.Controls.Add(lblRoomNumber);

// Room type and floor
            Label lblType = new Label();
      lblType.Text = $"{room.Type} • Floor {room.Floor}";
lblType.Font = new Font("Segoe UI", 9);
            lblType.ForeColor = Color.Gray;
   lblType.Location = new Point(15, 35);
  lblType.AutoSize = true;
    card.Controls.Add(lblType);

            // Status badge
            Label lblStatus = new Label();
        lblStatus.Text = GetStatusBadge(room.Status);
  lblStatus.Font = new Font("Segoe UI", 10, FontStyle.Bold);
  lblStatus.ForeColor = GetStatusBadgeColor(room.Status);
            lblStatus.Location = new Point(15, 55);
      lblStatus.AutoSize = true;
            card.Controls.Add(lblStatus);

            // Separator line
     Panel separatorLine = new Panel();
            separatorLine.Height = 1;
            separatorLine.Width = 250;
         separatorLine.BackColor = Color.FromArgb(230, 230, 230);
separatorLine.Location = new Point(15, 80);
            card.Controls.Add(separatorLine);

       // Guest information (shown only if occupied or reserved)
            if (room.Status == "Occupied" || room.Status == "Reserved")
         {
     // Guest name
     Label lblGuestLabel = new Label();
 lblGuestLabel.Text = "Guest:";
    lblGuestLabel.Font = new Font("Segoe UI", 9, FontStyle.Bold);
    lblGuestLabel.ForeColor = Color.FromArgb(100, 100, 100);
        lblGuestLabel.Location = new Point(15, 95);
                lblGuestLabel.AutoSize = true;
       card.Controls.Add(lblGuestLabel);

      Label lblGuestName = new Label();
      lblGuestName.Text = room.Guest;
lblGuestName.Font = new Font("Segoe UI", 11, FontStyle.Bold);
       lblGuestName.ForeColor = Color.FromArgb(30, 40, 60);
           lblGuestName.Location = new Point(15, 115);
       lblGuestName.AutoSize = true;
      card.Controls.Add(lblGuestName);

      // Check-in date
         Label lblCheckInLabel = new Label();
                lblCheckInLabel.Text = "Check-In:";
  lblCheckInLabel.Font = new Font("Segoe UI", 8);
    lblCheckInLabel.ForeColor = Color.Gray;
      lblCheckInLabel.Location = new Point(15, 140);
         lblCheckInLabel.AutoSize = true;
    card.Controls.Add(lblCheckInLabel);

             Label lblCheckIn = new Label();
   lblCheckIn.Text = room.CheckInDate;
lblCheckIn.Font = new Font("Segoe UI", 9);
  lblCheckIn.ForeColor = Color.FromArgb(50, 50, 50);
           lblCheckIn.Location = new Point(15, 158);
        lblCheckIn.AutoSize = true;
    card.Controls.Add(lblCheckIn);

    // Check-out date
                Label lblCheckOutLabel = new Label();
                lblCheckOutLabel.Text = "Check-Out:";
             lblCheckOutLabel.Font = new Font("Segoe UI", 8);
      lblCheckOutLabel.ForeColor = Color.Gray;
      lblCheckOutLabel.Location = new Point(15, 180);
         lblCheckOutLabel.AutoSize = true;
    card.Controls.Add(lblCheckOutLabel);

     Label lblCheckOut = new Label();
     lblCheckOut.Text = room.CheckOutDate;
        lblCheckOut.Font = new Font("Segoe UI", 9);
                lblCheckOut.ForeColor = Color.FromArgb(50, 50, 50);
              lblCheckOut.Location = new Point(15, 198);
 lblCheckOut.AutoSize = true;
      card.Controls.Add(lblCheckOut);

   // Days remaining
     if (room.DaysRemaining > 0)
   {
             Label lblDaysLabel = new Label();
   lblDaysLabel.Text = "Duration:";
   lblDaysLabel.Font = new Font("Segoe UI", 8, FontStyle.Bold);
 lblDaysLabel.ForeColor = Color.FromArgb(70, 130, 180);
 lblDaysLabel.Location = new Point(15, 220);
     lblDaysLabel.AutoSize = true;
        card.Controls.Add(lblDaysLabel);

              Label lblDays = new Label();
    lblDays.Text = $"{room.DaysRemaining} days remaining";
        lblDays.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblDays.ForeColor = Color.FromArgb(70, 130, 180);
  lblDays.Location = new Point(15, 238);
       lblDays.AutoSize = true;
   card.Controls.Add(lblDays);
      }
  }
            else if (room.Status == "Available")
         {
    // Available room - show price
         Label lblPriceLabel = new Label();
         lblPriceLabel.Text = "Price per night:";
           lblPriceLabel.Font = new Font("Segoe UI", 9);
           lblPriceLabel.ForeColor = Color.Gray;
        lblPriceLabel.Location = new Point(15, 100);
           lblPriceLabel.AutoSize = true;
         card.Controls.Add(lblPriceLabel);

   Label lblPrice = new Label();
                lblPrice.Text = $"${room.Price}";
    lblPrice.Font = new Font("Segoe UI", 24, FontStyle.Bold);
    lblPrice.ForeColor = Color.FromArgb(40, 200, 150);
     lblPrice.Location = new Point(15, 120);
         lblPrice.AutoSize = true;
                card.Controls.Add(lblPrice);

    // Available button
         Button btnBook = new Button();
     btnBook.Text = "📅 Book Now";
 btnBook.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btnBook.ForeColor = Color.White;
          btnBook.BackColor = Color.FromArgb(70, 130, 180);
        btnBook.FlatStyle = FlatStyle.Flat;
 btnBook.Size = new Size(250, 35);
      btnBook.Location = new Point(15, 230);
btnBook.Tag = room.RoomNumber;
           btnBook.Click += BtnBook_Click;
         card.Controls.Add(btnBook);
   }
            else if (room.Status == "Maintenance")
  {
        // Maintenance room - show message
           Label lblMaintenanceMsg = new Label();
lblMaintenanceMsg.Text = "Under Maintenance";
        lblMaintenanceMsg.Font = new Font("Segoe UI", 11, FontStyle.Italic);
     lblMaintenanceMsg.ForeColor = Color.Gray;
          lblMaintenanceMsg.Location = new Point(15, 130);
       lblMaintenanceMsg.AutoSize = true;
   card.Controls.Add(lblMaintenanceMsg);

  Label lblETA = new Label();
       lblETA.Text = "ETA: 2-3 hours";
    lblETA.Font = new Font("Segoe UI", 9);
    lblETA.ForeColor = Color.FromArgb(200, 150, 80);
 lblETA.Location = new Point(15, 155);
      lblETA.AutoSize = true;
     card.Controls.Add(lblETA);
            }

   return card;
   }

        /// <summary>
  /// Get color based on room status
      /// </summary>
        private Color GetStatusColor(string status)
        {
            return status switch
       {
    "Available" => Color.FromArgb(40, 200, 150),      // Green
  "Occupied" => Color.FromArgb(220, 100, 100),// Red
       "Reserved" => Color.FromArgb(70, 180, 200),     // Blue
        "Maintenance" => Color.FromArgb(200, 150, 80),    // Orange
        _ => Color.Gray
            };
        }

        /// <summary>
        /// Get status badge text with icon
  /// </summary>
        private string GetStatusBadge(string status)
        {
          return status switch
     {
 "Available" => "✅ Available",
    "Occupied" => "👥 Occupied",
           "Reserved" => "📅 Reserved",
        "Maintenance" => "🔧 Maintenance",
     _ => status
      };
        }

      /// <summary>
   /// Get status badge color
        /// </summary>
        private Color GetStatusBadgeColor(string status)
  {
            return status switch
    {
         "Available" => Color.FromArgb(40, 200, 150),
           "Occupied" => Color.FromArgb(220, 100, 100),
    "Reserved" => Color.FromArgb(70, 180, 200),
           "Maintenance" => Color.FromArgb(200, 150, 80),
              _ => Color.Gray
            };
  }

    /// <summary>
        /// Handle book button click
        /// </summary>
        private void BtnBook_Click(object sender, EventArgs e)
      {
   Button btn = sender as Button;
            if (btn != null && btn.Tag is string roomNumber)
        {
        MessageBox.Show($"Opening booking form for Room {roomNumber}...", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
        }

        /// <summary>
/// Get room statistics
        /// </summary>
        public Dictionary<string, int> GetRoomStatistics()
  {
            return new Dictionary<string, int>
      {
{ "Total", roomList.Count },
           { "Available", roomList.Count(r => r.Status == "Available") },
      { "Occupied", roomList.Count(r => r.Status == "Occupied") },
     { "Reserved", roomList.Count(r => r.Status == "Reserved") },
      { "Maintenance", roomList.Count(r => r.Status == "Maintenance") }
 };
        }

        /// <summary>
        /// Get occupied rooms with guest details
      /// </summary>
        public List<RoomCardInfo> GetOccupiedRooms()
        {
       return roomList.Where(r => r.Status == "Occupied").ToList();
        }

     /// <summary>
        /// Get available rooms for booking
        /// </summary>
      public List<RoomCardInfo> GetAvailableRooms()
  {
     return roomList.Where(r => r.Status == "Available").ToList();
        }

        /// <summary>
  /// Refresh room cards display
        /// </summary>
        public void RefreshRoomCards()
        {
     DisplayRoomCards();
      }
    }

    /// <summary>
    /// Room Card Information Model
    /// </summary>
    public class RoomCardInfo
    {
  public string RoomNumber { get; set; }
        public string Type { get; set; }
        public int Floor { get; set; }
        public string Status { get; set; }
        public string Guest { get; set; }
      public string CheckInDate { get; set; }
        public string CheckOutDate { get; set; }
      public double Price { get; set; }
    public int DaysRemaining { get; set; }
    }
}
