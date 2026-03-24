using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan.UI
{
    partial class UCBooking
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            btnCheckout = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvBooking = new DataGridView();
            colMaPhieu = new DataGridViewTextBoxColumn();
            colKhachHang = new DataGridViewTextBoxColumn();
            colPhong = new DataGridViewTextBoxColumn();
            colCheckIn = new DataGridViewTextBoxColumn();
            colCheckOut = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooking).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.ControlLight;
            panelTop.Controls.Add(btnCheckout);
            panelTop.Controls.Add(btnSearch);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(label1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1103, 80);
            panelTop.TabIndex = 0;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.LightCoral;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCheckout.Location = new Point(544, 23);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(160, 32);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Thanh toán / Trả phòng";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(404, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(155, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(232, 23);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 32);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên / CCCD Khách:";
            // 
            // dgvBooking
            // 
            dgvBooking.AllowUserToAddRows = false;
            dgvBooking.AllowUserToDeleteRows = false;
            dgvBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooking.BackgroundColor = SystemColors.ButtonHighlight;
            dgvBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooking.Columns.AddRange(new DataGridViewColumn[] { colMaPhieu, colKhachHang, colPhong, colCheckIn, colCheckOut, colTrangThai });
            dgvBooking.Dock = DockStyle.Fill;
            dgvBooking.Location = new Point(0, 80);
            dgvBooking.Name = "dgvBooking";
            dgvBooking.ReadOnly = true;
            dgvBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooking.Size = new Size(1103, 641);
            dgvBooking.TabIndex = 1;
            // 
            // colMaPhieu
            // 
            colMaPhieu.HeaderText = "Mã Đặt Phòng";
            colMaPhieu.Name = "colMaPhieu";
            colMaPhieu.ReadOnly = true;
            // 
            // colKhachHang
            // 
            colKhachHang.HeaderText = "Tên Khách Hàng";
            colKhachHang.Name = "colKhachHang";
            colKhachHang.ReadOnly = true;
            // 
            // colPhong
            // 
            colPhong.HeaderText = "Phòng";
            colPhong.Name = "colPhong";
            colPhong.ReadOnly = true;
            // 
            // colCheckIn
            // 
            colCheckIn.HeaderText = "Ngày Check-in";
            colCheckIn.Name = "colCheckIn";
            colCheckIn.ReadOnly = true;
            // 
            // colCheckOut
            // 
            colCheckOut.HeaderText = "Ngày Trả (Dự kiến)";
            colCheckOut.Name = "colCheckOut";
            colCheckOut.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // UCBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvBooking);
            Controls.Add(panelTop);
            Name = "UCBooking";
            Size = new Size(1103, 721);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooking).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}