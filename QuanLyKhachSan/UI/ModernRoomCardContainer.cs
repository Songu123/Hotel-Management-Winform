using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.UI
{
    /// <summary>
    /// Container for displaying modern room cards in a grid layout
    /// </summary>
    public partial class ModernRoomCardContainer : UserControl
    {
        private List<ModernRoomCard> _roomCards = new();
        private int _columnCount = 3;
        private int _cardWidth = 250;
        private int _cardHeight = 240;
        private int _horizontalSpacing = 12;
        private int _verticalSpacing = 12;

        public ModernRoomCardContainer()
        {
            InitializeComponent();
            SetupStyles();
        }

        private void SetupStyles()
        {
            this.DoubleBuffered = true;
            this.AutoScroll = true;
            this.BackColor = Color.FromArgb(240, 241, 245);
        }

        /// <summary>
        /// Clear all room cards
        /// </summary>
        public void ClearRooms()
        {
            foreach (var card in _roomCards)
            {
                card.Dispose();
            }
            _roomCards.Clear();
            this.Controls.Clear();
        }

        /// <summary>
        /// Add room to display
        /// </summary>
        public void AddRoom(Room room, RoomStatusType status = RoomStatusType.Available)
        {
            if (room == null) return;

            var card = new ModernRoomCard();
            card.SetRoomData(room, status);
            card.Width = _cardWidth;
            card.Height = _cardHeight;

            // Subscribe to card events
            card.ViewDetailsClicked += (s, e) => OnViewDetailsClicked(e.Room);
            card.BookingClicked += (s, e) => OnBookingClicked(e.Room);
            card.CleaningClicked += (s, e) => OnCleaningClicked(e.Room);

            _roomCards.Add(card);
            this.Controls.Add(card);

            LayoutCards();
        }

        /// <summary>
        /// Add multiple rooms
        /// </summary>
        public void AddRooms(IEnumerable<Room> rooms, RoomStatusType status = RoomStatusType.Available)
        {
            foreach (var room in rooms)
            {
                AddRoom(room, status);
            }
        }

        /// <summary>
        /// Update room status
        /// </summary>
        public void UpdateRoomStatus(string roomId, RoomStatusType status)
        {
            var card = _roomCards.FirstOrDefault(c => c.GetRoomData()?.RoomId == roomId);
            if (card != null)
            {
                var room = card.GetRoomData();
                card.SetRoomData(room, status);
            }
        }

        /// <summary>
        /// Layout cards in grid
        /// </summary>
        private void LayoutCards()
        {
            int x = _horizontalSpacing;
            int y = _verticalSpacing;
            int column = 0;

            foreach (var card in _roomCards)
            {
                card.Location = new Point(x, y);
                column++;

                if (column >= _columnCount)
                {
                    x = _horizontalSpacing;
                    y += _cardHeight + _verticalSpacing;
                    column = 0;
                }
                else
                {
                    x += _cardWidth + _horizontalSpacing;
                }
            }

            // Set scroll area size
            int totalWidth = this.Width;
            int totalHeight = y + _cardHeight + _verticalSpacing;
            this.AutoScrollMinSize = new Size(totalWidth, totalHeight);
        }

        /// <summary>
        /// Set column count for grid layout
        /// </summary>
        public void SetColumnCount(int count)
        {
            if (count > 0)
            {
                _columnCount = count;
                LayoutCards();
            }
        }

        /// <summary>
        /// Set card size
        /// </summary>
        public void SetCardSize(int width, int height)
        {
            _cardWidth = width;
            _cardHeight = height;
            foreach (var card in _roomCards)
            {
                card.Width = width;
                card.Height = height;
            }
            LayoutCards();
        }

        // Events
        public event EventHandler<Room> ViewDetailsClicked;
        public event EventHandler<Room> BookingClicked;
        public event EventHandler<Room> CleaningClicked;

        protected virtual void OnViewDetailsClicked(Room room)
        {
            ViewDetailsClicked?.Invoke(this, room);
        }

        protected virtual void OnBookingClicked(Room room)
        {
            BookingClicked?.Invoke(this, room);
        }

        protected virtual void OnCleaningClicked(Room room)
        {
            CleaningClicked?.Invoke(this, room);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            LayoutCards();
        }
    }
}
