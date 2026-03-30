namespace QuanLyKhachSan.UI.BookingUI
{
    partial class RoomAllocationDialog
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
 this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Name = "RoomAllocationDialog";
            this.Text = "Phân Đặt Phòng";
  this.Load += new System.EventHandler(this.RoomAllocationDialog_Load);
    }
    }
}
