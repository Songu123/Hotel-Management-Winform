using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.UI.BookingUI
{
    /// <summary>
    /// Form đơn giản để xử lý dọn dẹp phòng
    /// </summary>
    public class SimpleRoomCleaningForm : Form
    {
        private Room _room;
        private Label lblRoomName;
        private Label lblStatus;
        private Label lblNotes;
        private TextBox txtNotes;
        private ComboBox cboCondition;
        private Label lblCondition;
        private Button btnClean;
        private Button btnCancel;

        public SimpleRoomCleaningForm(Room room)
        {
            _room = room ?? throw new ArgumentNullException(nameof(room));
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = $"Dọn phòng {_room.Name}";
            this.Width = 400;
            this.Height = 350;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.FromArgb(245, 245, 245);

            // Title
            var lblTitle = new Label
            {
                Text = $"🧹 DỌN DẸP PHÒNG {_room.Name}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(33, 150, 243),
                Location = new Point(20, 20),
                AutoSize = true
            };
            this.Controls.Add(lblTitle);

            // Room info panel
            var pnlInfo = new Panel
            {
                Location = new Point(20, 50),
                Width = this.Width - 40,
                Height = 80,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(pnlInfo);

            lblRoomName = new Label
            {
                Text = $"Phòng: {_room.RoomId} - {_room.Name}",
                Font = new Font("Segoe UI", 10),
                Location = new Point(15, 15),
                AutoSize = true,
                Parent = pnlInfo
            };

            lblStatus = new Label
            {
                Text = $"Giá phòng: {_room.Price:N0} VNĐ",
                Font = new Font("Segoe UI", 10),
                Location = new Point(15, 40),
                AutoSize = true,
                Parent = pnlInfo
            };

            // Condition selection
            var pnlCondition = new Panel
            {
                Location = new Point(20, 140),
                Width = this.Width - 40,
                Height = 70,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(pnlCondition);

            lblCondition = new Label
            {
                Text = "Tình trạng phòng sau dọn:",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(15, 15),
                AutoSize = true,
                Parent = pnlCondition
            };

            cboCondition = new ComboBox
            {
                Location = new Point(15, 40),
                Width = this.Width - 50,
                Height = 28,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10),
                Parent = pnlCondition
            };
            cboCondition.Items.AddRange(new[] { "Tốt", "Cần sửa chữa", "Cần vệ sinh" });
            cboCondition.SelectedIndex = 0; // Default: Tốt

            // Notes
            var pnlNotes = new Panel
            {
                Location = new Point(20, 220),
                Width = this.Width - 40,
                Height = 80,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(pnlNotes);

            lblNotes = new Label
            {
                Text = "Ghi chú:",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(15, 10),
                AutoSize = true,
                Parent = pnlNotes
            };

            txtNotes = new TextBox
            {
                Location = new Point(15, 35),
                Width = this.Width - 50,
                Height = 35,
                Font = new Font("Segoe UI", 9),
                Multiline = true,
                BorderStyle = BorderStyle.FixedSingle,
                PlaceholderText = "Nhập ghi chú về tình trạng phòng...",
                Parent = pnlNotes
            };

            // Buttons
            btnClean = new Button
            {
                Text = "✓ Dọn phòng",
                Width = 120,
                Height = 40,
                Location = new Point(this.Width - 260, 310),
                BackColor = Color.FromArgb(76, 175, 80),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.OK
            };
            btnClean.FlatAppearance.BorderSize = 0;
            btnClean.Click += BtnClean_Click;
            this.Controls.Add(btnClean);

            btnCancel = new Button
            {
                Text = "Hủy",
                Width = 120,
                Height = 40,
                Location = new Point(this.Width - 130, 310),
                BackColor = Color.FromArgb(244, 67, 54),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.Cancel
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            this.Controls.Add(btnCancel);
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            if (cboCondition.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn tình trạng phòng!", "Thông báo",
           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public string GetCondition()
        {
            return cboCondition.SelectedItem?.ToString() ?? "Tốt";
        }

        public string GetNotes()
        {
            return txtNotes.Text;
        }
    }
}
