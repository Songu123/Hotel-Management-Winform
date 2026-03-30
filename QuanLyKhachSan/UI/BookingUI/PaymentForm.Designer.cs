namespace QuanLyKhachSan.UI.BookingUI
{
    partial class PaymentForm
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
          this.ClientSize = new System.Drawing.Size(1400, 750);
  this.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.Name = "PaymentForm";
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "💳 THANH TOÁN";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
 
            this.ResumeLayout(false);
        }
    }
}
