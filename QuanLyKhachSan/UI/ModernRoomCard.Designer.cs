namespace QuanLyKhachSan.UI
{
    partial class ModernRoomCard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ContextMenuStrip contextMenuRoom;
        private System.Windows.Forms.ToolStripMenuItem menuViewInfo;
        private System.Windows.Forms.ToolStripMenuItem menuBook;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuClean;

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
            this.components = new System.ComponentModel.Container();
            this.contextMenuRoom = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuViewInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuClean = new System.Windows.Forms.ToolStripMenuItem();

            this.contextMenuRoom.SuspendLayout();
            this.SuspendLayout();

            // 
            // contextMenuRoom
            // 
            this.contextMenuRoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewInfo,
            this.menuBook,
            this.toolStripSeparator1,
            this.menuClean});
            this.contextMenuRoom.Name = "contextMenuRoom";
            this.contextMenuRoom.Size = new System.Drawing.Size(236, 76);

            // 
            // menuViewInfo
            // 
            this.menuViewInfo.Name = "menuViewInfo";
            this.menuViewInfo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuViewInfo.Size = new System.Drawing.Size(235, 22);
            this.menuViewInfo.Text = "📋 Xem thông tin phòng";

            // 
            // menuBook
            // 
            this.menuBook.Name = "menuBook";
            this.menuBook.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menuBook.Size = new System.Drawing.Size(235, 22);
            this.menuBook.Text = "🔑 Đặt phòng";

            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);

            // 
            // menuClean
            // 
            this.menuClean.Name = "menuClean";
            this.menuClean.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuClean.Size = new System.Drawing.Size(235, 22);
            this.menuClean.Text = "🧹 Dọn dẹp phòng";

            // 
            // ModernRoomCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.contextMenuRoom;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "ModernRoomCard";
            this.Size = new System.Drawing.Size(250, 240);

            this.contextMenuRoom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}