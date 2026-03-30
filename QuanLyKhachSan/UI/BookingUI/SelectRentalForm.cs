using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.UI.BookingUI
{
    /// <summary>
    /// Form for selecting rental detail to pay
    /// </summary>
    public partial class SelectRentalForm : Form
    {
        private IRentalDetailService _rentalDetailService;
        public string SelectedRentalId { get; private set; }
        private DataGridView dgvRentals;

        public SelectRentalForm(IRentalDetailService rentalDetailService)
        {
            InitializeComponent();
    _rentalDetailService = rentalDetailService;
        }

      private async void SelectRentalForm_Load(object sender, EventArgs e)
        {
     try
          {
       SetupForm();
     await LoadRentals();
 }
            catch (Exception ex)
       {
 MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      }

        private void SetupForm()
{
         this.Text = "Chọn Đơn Đặt Phòng Để Thanh Toán";
          this.Width = 900;
      this.Height = 500;
this.StartPosition = FormStartPosition.CenterParent;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
            this.MinimizeBox = false;

   // Header
      var lblTitle = new Label
            {
     Text = "Chọn một đơn đặt phòng cần thanh toán",
     Font = new Font("Segoe UI", 12, FontStyle.Bold),
    Location = new Point(20, 20),
     AutoSize = true
    };
        Controls.Add(lblTitle);

      // DataGridView
            dgvRentals = new DataGridView
    {
 Name = "dgvRentals",
            AutoGenerateColumns = false,
        AllowUserToAddRows = false,
       ReadOnly = true,
    BackgroundColor = Color.White,
             BorderStyle = BorderStyle.FixedSingle,
                RowHeadersVisible = false,
      Location = new Point(20, 60),
            Width = Width - 60,
         Height = Height - 150,
       SelectionMode = DataGridViewSelectionMode.FullRowSelect,
          MultiSelect = false
            };

     dgvRentals.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã Chi Tiết", Width = 100 });
          dgvRentals.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Khách Hàng", Width = 150 });
      dgvRentals.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày Lập", Width = 130 });
         dgvRentals.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tính Trạng", Width = 100 });
            dgvRentals.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tiền Cọc", Width = 100 });

   dgvRentals.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(59, 130, 246);
      dgvRentals.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
   dgvRentals.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

     Controls.Add(dgvRentals);

     // Buttons
            var btnSelect = new Button
  {
Text = "Chọn",
      Width = 100,
 Height = 35,
     Location = new Point(Width - 250, Height - 70),
           BackColor = Color.FromArgb(34, 197, 94),
       ForeColor = Color.White,
         Font = new Font("Segoe UI", 10, FontStyle.Bold),
    FlatStyle = FlatStyle.Flat
       };
            btnSelect.Click += (s, e) =>
     {
         if (dgvRentals.SelectedRows.Count > 0)
        {
              SelectedRentalId = dgvRentals.SelectedRows[0].Cells[0].Value?.ToString();
        this.DialogResult = DialogResult.OK;
        this.Close();
       }
       else
  {
             MessageBox.Show("Vui lòng chọn một đơn đặt phòng", "Cảnh báo",
             MessageBoxButtons.OK, MessageBoxIcon.Warning);
     }
            };
  Controls.Add(btnSelect);

   var btnCancel = new Button
  {
        Text = "Hủy",
          Width = 100,
        Height = 35,
 Location = new Point(Width - 140, Height - 70),
                BackColor = Color.FromArgb(239, 68, 68),
     ForeColor = Color.White,
     Font = new Font("Segoe UI", 10, FontStyle.Bold),
              FlatStyle = FlatStyle.Flat,
          DialogResult = DialogResult.Cancel
       };
         Controls.Add(btnCancel);
      }

      private async Task LoadRentals()
        {
     try
  {
       dgvRentals.Rows.Clear();

         var rentals = await _rentalDetailService.GetAllRentalDetailsAsync();
     if (rentals == null) return;

      foreach (var rental in rentals.Where(r => r.IsDeleted == 0))
                {
     dgvRentals.Rows.Add(
  rental.RentalDetailId,
          rental.Customer?.Name ?? "N/A",
       rental.CreatedDate.ToString("dd/MM/yyyy HH:mm"),
        GetStatusName(rental.ProcessingStatus),
      rental.DepositAmount.ToString("N0")
         );
          }
            }
   catch (Exception ex)
    {
      MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi",
     MessageBoxButtons.OK, MessageBoxIcon.Error);
  }
   }

        private string GetStatusName(int status)
        {
       return status switch
      {
    0 => "Đang Xử Lý",
              1 => "Đã Xác Nhận",
      2 => "Đã Hủy",
          _ => "Không Xác Định"
 };
        }
    }

    partial class SelectRentalForm
    {
     private System.ComponentModel.IContainer components = null;

   protected override void Dispose(bool disposing)
     {
            if (disposing && (components != null))
            {
                components.Dispose();
     }
     base.Dispose(disposing);
 }

      private void InitializeComponent()
   {
            this.SuspendLayout();

     this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(900, 500);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "SelectRentalForm";
       this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
    this.Text = "Chọn Đơn Đặt Phòng";
       this.Load += new System.EventHandler(this.SelectRentalForm_Load);

    this.ResumeLayout(false);
        }
    }
}
