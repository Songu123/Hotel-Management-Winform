namespace QuanLyKhachSan.UI.BookingUI
{
    partial class RoomAllocationDetailPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomAllocationDetailPanel));

 // Main container
            tableLayoutPanel1 = new TableLayoutPanel();
      
          // Available Rooms Section
      panelAvailable = new Panel();
 lblAvailableRooms = new Label();
            dgvAvailableRooms = new DataGridView();
            
         // Selected Rooms Section
            panelSelected = new Panel();
            lblSelectedRooms = new Label();
  dgvSelectedRooms = new DataGridView();
  
        // Summary Section
            panelSummary = new Panel();
            lblTotalRooms = new Label();
            lblTotalNights = new Label();
            lblTotalPrice = new Label();

          // Setup main layout
        tableLayoutPanel1.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)dgvAvailableRooms).BeginInit();
       ((System.ComponentModel.ISupportInitialize)dgvSelectedRooms).BeginInit();
     panelAvailable.SuspendLayout();
            panelSelected.SuspendLayout();
 panelSummary.SuspendLayout();
      SuspendLayout();

     // tableLayoutPanel1
          tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
          tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
    tableLayoutPanel1.Controls.Add(panelAvailable, 0, 0);
     tableLayoutPanel1.Controls.Add(panelSelected, 1, 0);
       tableLayoutPanel1.Controls.Add(panelSummary, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
    tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
          tableLayoutPanel1.Name = "tableLayoutPanel1";
    tableLayoutPanel1.TabIndex = 0;

            // panelAvailable
    panelAvailable.Controls.Add(lblAvailableRooms);
      panelAvailable.Controls.Add(dgvAvailableRooms);
    panelAvailable.Dock = DockStyle.Fill;
       panelAvailable.Padding = new Padding(10);
            panelAvailable.BackColor = System.Drawing.Color.White;
            panelAvailable.Name = "panelAvailable";
      panelAvailable.TabIndex = 0;

  // lblAvailableRooms
            lblAvailableRooms.AutoSize = true;
          lblAvailableRooms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
       lblAvailableRooms.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
  lblAvailableRooms.Location = new System.Drawing.Point(10, 10);
lblAvailableRooms.Name = "lblAvailableRooms";
            lblAvailableRooms.Size = new System.Drawing.Size(120, 21);
       lblAvailableRooms.TabIndex = 0;
 lblAvailableRooms.Text = "📋 Danh sách phòng";

     // dgvAvailableRooms
   dgvAvailableRooms.AllowUserToAddRows = false;
          dgvAvailableRooms.AllowUserToDeleteRows = false;
            dgvAvailableRooms.AllowUserToResizeRows = false;
            dgvAvailableRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
       dgvAvailableRooms.BackgroundColor = System.Drawing.Color.White;
 dgvAvailableRooms.BorderStyle = BorderStyle.None;
          dgvAvailableRooms.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAvailableRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
       dgvAvailableRooms.Dock = DockStyle.Fill;
 dgvAvailableRooms.Location = new System.Drawing.Point(10, 35);
        dgvAvailableRooms.Margin = new Padding(3, 25, 3, 3);
         dgvAvailableRooms.Name = "dgvAvailableRooms";
   dgvAvailableRooms.ReadOnly = true;
    dgvAvailableRooms.RowHeadersVisible = false;
            dgvAvailableRooms.TabIndex = 1;
 dgvAvailableRooms.CellDoubleClick += DgvAvailableRooms_CellDoubleClick;

       // Setup columns for dgvAvailableRooms
         dgvAvailableRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã Phòng", Name = "RoomId", Width = 80 });
 dgvAvailableRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên Phòng", Name = "RoomName", Width = 100 });
dgvAvailableRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Loại", Name = "RoomType", Width = 100 });
        dgvAvailableRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giá/Đêm", Name = "Price", Width = 80 });
      dgvAvailableRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tình Trạng", Name = "Availability", Width = 80 });
          dgvAvailableRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Chọn", Name = "Status", Width = 80 });

      // panelSelected
   panelSelected.Controls.Add(lblSelectedRooms);
    panelSelected.Controls.Add(dgvSelectedRooms);
        panelSelected.Dock = DockStyle.Fill;
   panelSelected.Padding = new Padding(10);
       panelSelected.BackColor = System.Drawing.Color.White;
            panelSelected.Name = "panelSelected";
       panelSelected.TabIndex = 1;

            // lblSelectedRooms
    lblSelectedRooms.AutoSize = true;
  lblSelectedRooms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblSelectedRooms.ForeColor = System.Drawing.Color.FromArgb(0, 153, 76);
       lblSelectedRooms.Location = new System.Drawing.Point(10, 10);
          lblSelectedRooms.Name = "lblSelectedRooms";
         lblSelectedRooms.Size = new System.Drawing.Size(130, 21);
   lblSelectedRooms.TabIndex = 0;
   lblSelectedRooms.Text = "✅ Phòng đã chọn";

 // dgvSelectedRooms
          dgvSelectedRooms.AllowUserToAddRows = false;
         dgvSelectedRooms.AllowUserToDeleteRows = false;
  dgvSelectedRooms.AllowUserToResizeRows = false;
            dgvSelectedRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
         dgvSelectedRooms.BackgroundColor = System.Drawing.Color.White;
        dgvSelectedRooms.BorderStyle = BorderStyle.None;
   dgvSelectedRooms.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
    dgvSelectedRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSelectedRooms.Dock = DockStyle.Fill;
         dgvSelectedRooms.Location = new System.Drawing.Point(10, 35);
     dgvSelectedRooms.Margin = new Padding(3, 25, 3, 3);
            dgvSelectedRooms.Name = "dgvSelectedRooms";
     dgvSelectedRooms.ReadOnly = true;
            dgvSelectedRooms.RowHeadersVisible = false;
         dgvSelectedRooms.TabIndex = 1;
            dgvSelectedRooms.CellClick += DgvSelectedRooms_CellClick;

          // Setup columns for dgvSelectedRooms
 dgvSelectedRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", Name = "STT", Width = 40 });
  dgvSelectedRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã Phòng", Name = "SelectedRoomId", Width = 80 });
          dgvSelectedRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên", Name = "SelectedRoomName", Width = 80 });
 dgvSelectedRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Loại", Name = "SelectedRoomType", Width = 70 });
  dgvSelectedRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giá/Đêm", Name = "PricePerNight", Width = 80 });
 dgvSelectedRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Đêm", Name = "Nights", Width = 40 });
            dgvSelectedRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tổng", Name = "TotalPrice", Width = 80 });
            dgvSelectedRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Check-in", Name = "CheckIn", Width = 80 });
       dgvSelectedRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Check-out", Name = "CheckOut", Width = 80 });
dgvSelectedRooms.Columns.Add(new DataGridViewButtonColumn { HeaderText = "Xóa", Name = "Remove", Width = 50, Text = "❌", UseColumnTextForButtonValue = true });

            // panelSummary
      panelSummary.Controls.Add(lblTotalRooms);
   panelSummary.Controls.Add(lblTotalNights);
    panelSummary.Controls.Add(lblTotalPrice);
      panelSummary.Dock = DockStyle.Fill;
       panelSummary.Padding = new Padding(15);
        panelSummary.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            panelSummary.Name = "panelSummary";
      panelSummary.TabIndex = 2;
         tableLayoutPanel1.SetColumnSpan(panelSummary, 2);

        // lblTotalRooms
            lblTotalRooms.AutoSize = true;
            lblTotalRooms.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
      lblTotalRooms.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            lblTotalRooms.Location = new System.Drawing.Point(15, 15);
   lblTotalRooms.Name = "lblTotalRooms";
  lblTotalRooms.Size = new System.Drawing.Size(80, 20);
  lblTotalRooms.TabIndex = 0;
            lblTotalRooms.Text = "0 phòng";

       // lblTotalNights
            lblTotalNights.AutoSize = true;
lblTotalNights.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
   lblTotalNights.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
         lblTotalNights.Location = new System.Drawing.Point(200, 15);
    lblTotalNights.Name = "lblTotalNights";
         lblTotalNights.Size = new System.Drawing.Size(80, 20);
    lblTotalNights.TabIndex = 1;
            lblTotalNights.Text = "0 đêm";

      // lblTotalPrice
      lblTotalPrice.AutoSize = true;
         lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(220, 20, 60);
  lblTotalPrice.Location = new System.Drawing.Point(500, 10);
  lblTotalPrice.Name = "lblTotalPrice";
     lblTotalPrice.Size = new System.Drawing.Size(140, 25);
       lblTotalPrice.TabIndex = 2;
    lblTotalPrice.Text = "💰 0 VNĐ";

 // RoomAllocationDetailPanel
       Controls.Add(tableLayoutPanel1);
   Name = "RoomAllocationDetailPanel";
            Size = new System.Drawing.Size(800, 600);
      tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvAvailableRooms).EndInit();
         ((System.ComponentModel.ISupportInitialize)dgvSelectedRooms).EndInit();
  panelAvailable.ResumeLayout(false);
  panelAvailable.PerformLayout();
            panelSelected.ResumeLayout(false);
          panelSelected.PerformLayout();
            panelSummary.ResumeLayout(false);
    panelSummary.PerformLayout();
         ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelAvailable;
        private Label lblAvailableRooms;
        private DataGridView dgvAvailableRooms;
        private Panel panelSelected;
      private Label lblSelectedRooms;
        private DataGridView dgvSelectedRooms;
        private Panel panelSummary;
        private Label lblTotalRooms;
     private Label lblTotalNights;
     private Label lblTotalPrice;
    }
}
