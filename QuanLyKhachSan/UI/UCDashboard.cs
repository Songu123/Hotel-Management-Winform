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
    public partial class UCDashboard : UserControl
    {
        /// <summary>
        /// Room data model for dashboard
        /// </summary>
        private List<DashboardRoom> allRooms = new List<DashboardRoom>();
        private UCRoomCards roomCardsControl = null;

        public UCDashboard()
        {
            InitializeComponent();
        }

        private void UCDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
            UpdateRoomStatus();
        }

        /// <summary>
        /// Initialize sample room data for dashboard
        /// </summary>
        private void LoadDashboardData()
        {
            allRooms = new List<DashboardRoom>
            {
                // Available Rooms
                new DashboardRoom { RoomNumber = "101", Type = "Single", Floor = 1, Status = "Available", Guest = "-", CheckIn = "-", CheckOut = "-", Price = 50 },
                new DashboardRoom { RoomNumber = "103", Type = "Suite", Floor = 1, Status = "Available", Guest = "-", CheckIn = "-", CheckOut = "-", Price = 150 },
                new DashboardRoom { RoomNumber = "105", Type = "Double", Floor = 1, Status = "Available", Guest = "-", CheckIn = "-", CheckOut = "-", Price = 80 },
                new DashboardRoom { RoomNumber = "202", Type = "Deluxe", Floor = 2, Status = "Available", Guest = "-", CheckIn = "-", CheckOut = "-", Price = 200 },
                new DashboardRoom { RoomNumber = "204", Type = "Single", Floor = 2, Status = "Available", Guest = "-", CheckIn = "-", CheckOut = "-", Price = 50 },

                // Occupied Rooms
                new DashboardRoom { RoomNumber = "102", Type = "Double", Floor = 1, Status = "Occupied", Guest = "Nguyễn Văn A", CheckIn = "2024-01-15", CheckOut = "2024-01-18", Price = 80 },
                new DashboardRoom { RoomNumber = "104", Type = "Double", Floor = 1, Status = "Occupied", Guest = "Trần Thị B", CheckIn = "2024-01-16", CheckOut = "2024-01-20", Price = 80 },
                new DashboardRoom { RoomNumber = "201", Type = "Suite", Floor = 2, Status = "Occupied", Guest = "Hoàng Văn C", CheckIn = "2024-01-14", CheckOut = "2024-01-25", Price = 150 },
                new DashboardRoom { RoomNumber = "203", Type = "Deluxe", Floor = 2, Status = "Occupied", Guest = "Lê Thị D", CheckIn = "2024-01-17", CheckOut = "2024-01-19", Price = 200 },

                // Reserved Rooms
                new DashboardRoom { RoomNumber = "205", Type = "Double", Floor = 2, Status = "Reserved", Guest = "Phạm Văn E", CheckIn = "2024-02-01", CheckOut = "2024-02-05", Price = 80 },

                // Maintenance Rooms
                new DashboardRoom { RoomNumber = "106", Type = "Single", Floor = 1, Status = "Maintenance", Guest = "-", CheckIn = "-", CheckOut = "-", Price = 50 },
                new DashboardRoom { RoomNumber = "206", Type = "Double", Floor = 2, Status = "Maintenance", Guest = "-", CheckIn = "-", CheckOut = "-", Price = 80 },
            };
        }

        /// <summary>
        /// Update room status display in DataGridView and calculate statistics
        /// </summary>
        private void UpdateRoomStatus()
        {
            // Update statistics cards
            UpdateRoomStatistics();

            // Update room list grid
            UpdateRoomGrid();
        }

        /// <summary>
        /// Update the room statistics display
        /// </summary>
        private void UpdateRoomStatistics()
        {
            try
            {
                // Count rooms by status
                int availableCount = allRooms.Count(r => r.Status == "Available");
                int occupiedCount = allRooms.Count(r => r.Status == "Occupied");
                int reservedCount = allRooms.Count(r => r.Status == "Reserved");
                int maintenanceCount = allRooms.Count(r => r.Status == "Maintenance");

                // Update room status cards (if they exist in the panel)
                // This would be done through a more sophisticated binding mechanism in production
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating room statistics: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Update room list grid with current room data
        /// </summary>
        private void UpdateRoomGrid()
        {
            try
            {
                // Find DataGridView
                DataGridView dgv = this.Controls.Find("dgvRoomStatus", true).FirstOrDefault() as DataGridView;

                if (dgv != null)
                {
                    dgv.Rows.Clear();

                    foreach (var room in allRooms.OrderBy(r => r.RoomNumber))
                    {
                        string statusIcon = room.Status switch
                        {
                            "Available" => "✅ Available",
                            "Occupied" => "👥 Occupied",
                            "Reserved" => "📅 Reserved",
                            "Maintenance" => "🔧 Maintenance",
                            _ => room.Status
                        };

                        dgv.Rows.Add(
                            room.RoomNumber,
                            room.Type,
                            room.Floor,
                            statusIcon,
                            room.Guest,
                            room.CheckIn,
                            room.CheckOut,
                            "$" + room.Price
                        );

                        // Color code the rows based on status
                        DataGridViewRow lastRow = dgv.Rows[dgv.Rows.Count - 1];
                        lastRow.DefaultCellStyle.BackColor = GetStatusColor(room.Status);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating room grid: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Get color based on room status
        /// </summary>
        private Color GetStatusColor(string status)
        {
            return status switch
            {
                "Available" => Color.FromArgb(200, 240, 200),    // Light green
                "Occupied" => Color.FromArgb(240, 200, 200),   // Light red
                "Reserved" => Color.FromArgb(200, 220, 240),     // Light blue
                "Maintenance" => Color.FromArgb(240, 230, 200),  // Light orange
                _ => Color.White
            };
        }

        /// <summary>
        /// Get room statistics summary
        /// </summary>
        public RoomStatusSummary GetRoomSummary()
        {
            return new RoomStatusSummary
            {
                Total = allRooms.Count,
                Available = allRooms.Count(r => r.Status == "Available"),
                Occupied = allRooms.Count(r => r.Status == "Occupied"),
                Reserved = allRooms.Count(r => r.Status == "Reserved"),
                Maintenance = allRooms.Count(r => r.Status == "Maintenance"),
                OccupancyRate = allRooms.Count > 0
                    ? Math.Round((decimal)(allRooms.Count(r => r.Status == "Occupied") + allRooms.Count(r => r.Status == "Reserved")) / allRooms.Count * 100, 2)
                    : 0,
                DailyRevenue = (decimal)allRooms.Where(r => r.Status == "Occupied").Sum(r => r.Price)
            };
        }

        /// <summary>
        /// Get available rooms by type
        /// </summary>
        public Dictionary<string, int> GetAvailableRoomsByType()
        {
            return allRooms
                .Where(r => r.Status == "Available")
                .GroupBy(r => r.Type)
                .ToDictionary(g => g.Key, g => g.Count());
        }

        /// <summary>
        /// Get occupied rooms details
        /// </summary>
        public List<DashboardRoom> GetOccupiedRooms()
        {
            return allRooms.Where(r => r.Status == "Occupied").ToList();
        }

        /// <summary>
        /// Get maintenance rooms details
        /// </summary>
        public List<DashboardRoom> GetMaintenanceRooms()
        {
            return allRooms.Where(r => r.Status == "Maintenance").ToList();
        }

        private void dgvRoomStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void row1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    /// <summary>
    /// Dashboard Room Model
    /// </summary>
    public class DashboardRoom
    {
        public string RoomNumber { get; set; }
        public string Type { get; set; }
        public int Floor { get; set; }
        public string Status { get; set; }
        public string Guest { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public double Price { get; set; }
    }

    /// <summary>
    /// Room Status Summary
    /// </summary>
    public class RoomStatusSummary
    {
        public int Total { get; set; }
        public int Available { get; set; }
        public int Occupied { get; set; }
        public int Reserved { get; set; }
        public int Maintenance { get; set; }
        public decimal OccupancyRate { get; set; }
        public decimal DailyRevenue { get; set; }
    }
}
