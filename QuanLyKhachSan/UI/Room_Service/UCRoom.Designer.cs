namespace QuanLyKhachSan.UI.Room_Service
{
    partial class UCRoom
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
 System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();

            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabRoom = new System.Windows.Forms.TabPage();
     this.tabAmenity = new System.Windows.Forms.TabPage();
        this.pnlRoomContainer = new System.Windows.Forms.Panel();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblFilterTitle = new System.Windows.Forms.Label();
    this.lblFilterDesc = new System.Windows.Forms.Label();
            this.lblRoomId = new System.Windows.Forms.Label();
       this.tbRoomId = new System.Windows.Forms.TextBox();
          this.lblRoomName = new System.Windows.Forms.Label();
            this.tbRoomName = new System.Windows.Forms.TextBox();
      this.lblRoomType = new System.Windows.Forms.Label();
          this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomTypeDetails = new System.Windows.Forms.Label();
       this.cbRoomTypeDetails = new System.Windows.Forms.ComboBox();
        this.lblPrice = new System.Windows.Forms.Label();
            this.cbPrice = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
  this.lblCondition = new System.Windows.Forms.Label();
        this.cbCurrentCondition = new System.Windows.Forms.ComboBox();
     this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
        this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.colStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.colRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomTypeDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
 this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlButtons = new System.Windows.Forms.Panel();
this.btnAddRoom = new System.Windows.Forms.Button();
          this.btnViewDetails = new System.Windows.Forms.Button();

            this.pnlAmenityContainer = new System.Windows.Forms.Panel();
    this.pnlAmenityList = new System.Windows.Forms.Panel();
       this.lblAmenityListTitle = new System.Windows.Forms.Label();
          this.tbAmenitySearch = new System.Windows.Forms.TextBox();
     this.dgvAmenities = new System.Windows.Forms.DataGridView();
this.colAmenityStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
  this.colAmenityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
       this.colAmenityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.pnlAmenityDetail = new System.Windows.Forms.Panel();
            this.grpAmenityInfo = new System.Windows.Forms.GroupBox();
         this.lblAmenityId = new System.Windows.Forms.Label();
this.tbAmenityId = new System.Windows.Forms.TextBox();
       this.lblAmenityName = new System.Windows.Forms.Label();
       this.tbAmenityName = new System.Windows.Forms.TextBox();
       this.grpAmenityActions = new System.Windows.Forms.GroupBox();
     this.btnAmenityAdd = new System.Windows.Forms.Button();
  this.btnAmenityEdit = new System.Windows.Forms.Button();
         this.btnAmenityDelete = new System.Windows.Forms.Button();
            this.btnAmenitySave = new System.Windows.Forms.Button();
            this.btnAmenityCancel = new System.Windows.Forms.Button();

          this.tabMain.SuspendLayout();
 this.tabRoom.SuspendLayout();
    this.tabAmenity.SuspendLayout();
 this.pnlRoomContainer.SuspendLayout();
this.pnlFilter.SuspendLayout();
       ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
   this.pnlButtons.SuspendLayout();
  this.pnlAmenityContainer.SuspendLayout();
     this.pnlAmenityList.SuspendLayout();
  ((System.ComponentModel.ISupportInitialize)(this.dgvAmenities)).BeginInit();
   this.pnlAmenityDetail.SuspendLayout();
  this.grpAmenityInfo.SuspendLayout();
     this.grpAmenityActions.SuspendLayout();
            this.SuspendLayout();

    this.tabMain.Controls.Add(this.tabRoom);
        this.tabMain.Controls.Add(this.tabAmenity);
       this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 10F);
         this.tabMain.Location = new System.Drawing.Point(0, 0);
     this.tabMain.Name = "tabMain";
      this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1126, 650);

      this.tabRoom.Controls.Add(this.pnlRoomContainer);
this.tabRoom.Location = new System.Drawing.Point(4, 26);
 this.tabRoom.Name = "tabRoom";
    this.tabRoom.Padding = new System.Windows.Forms.Padding(3);
       this.tabRoom.Size = new System.Drawing.Size(1118, 620);
  this.tabRoom.Text = "Quan ly phong";
            this.tabRoom.UseVisualStyleBackColor = true;

          this.tabAmenity.Controls.Add(this.pnlAmenityContainer);
 this.tabAmenity.Location = new System.Drawing.Point(4, 26);
            this.tabAmenity.Name = "tabAmenity";
     this.tabAmenity.Padding = new System.Windows.Forms.Padding(3);
            this.tabAmenity.Size = new System.Drawing.Size(1118, 620);
 this.tabAmenity.Text = "Quan ly tien ich";
     this.tabAmenity.UseVisualStyleBackColor = true;

     this.pnlRoomContainer.Controls.Add(this.dgvRooms);
      this.pnlRoomContainer.Controls.Add(this.pnlButtons);
          this.pnlRoomContainer.Controls.Add(this.pnlFilter);
            this.pnlRoomContainer.Dock = System.Windows.Forms.DockStyle.Fill;
     this.pnlRoomContainer.Location = new System.Drawing.Point(3, 3);
 this.pnlRoomContainer.Name = "pnlRoomContainer";
            this.pnlRoomContainer.Size = new System.Drawing.Size(1112, 614);

this.pnlFilter.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.pnlFilter.Controls.Add(this.lblFilterTitle);
            this.pnlFilter.Controls.Add(this.lblFilterDesc);
            this.pnlFilter.Controls.Add(this.lblRoomId);
     this.pnlFilter.Controls.Add(this.tbRoomId);
         this.pnlFilter.Controls.Add(this.lblRoomName);
 this.pnlFilter.Controls.Add(this.tbRoomName);
      this.pnlFilter.Controls.Add(this.lblRoomType);
 this.pnlFilter.Controls.Add(this.cbRoomType);
            this.pnlFilter.Controls.Add(this.lblRoomTypeDetails);
      this.pnlFilter.Controls.Add(this.cbRoomTypeDetails);
            this.pnlFilter.Controls.Add(this.lblPrice);
    this.pnlFilter.Controls.Add(this.cbPrice);
            this.pnlFilter.Controls.Add(this.lblStatus);
  this.pnlFilter.Controls.Add(this.cbStatus);
            this.pnlFilter.Controls.Add(this.lblCondition);
            this.pnlFilter.Controls.Add(this.cbCurrentCondition);
            this.pnlFilter.Controls.Add(this.btnSearch);
        this.pnlFilter.Controls.Add(this.btnRefresh);
       this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
    this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
          this.pnlFilter.Padding = new System.Windows.Forms.Padding(15);
            this.pnlFilter.Size = new System.Drawing.Size(1112, 150);

            this.lblFilterTitle.AutoSize = true;
       this.lblFilterTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.lblFilterTitle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
    this.lblFilterTitle.Location = new System.Drawing.Point(20, 10);
  this.lblFilterTitle.Text = "QUAN LY PHONG";

   this.lblFilterDesc.AutoSize = true;
 this.lblFilterDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
 this.lblFilterDesc.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
          this.lblFilterDesc.Location = new System.Drawing.Point(20, 33);
   this.lblFilterDesc.Text = "Vui long bam vao bang danh sach phong de chinh sua";

            this.lblRoomId.AutoSize = true;
 this.lblRoomId.Location = new System.Drawing.Point(20, 60);
 this.lblRoomId.Text = "Ma phong:";

            this.tbRoomId.Location = new System.Drawing.Point(85, 57);
  this.tbRoomId.Size = new System.Drawing.Size(120, 23);
       this.tbRoomId.TextChanged += new System.EventHandler(this.tbRoomId_TextChanged);

          this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(220, 60);
   this.lblRoomName.Text = "Ten phong:";

    this.tbRoomName.Location = new System.Drawing.Point(290, 57);
            this.tbRoomName.Size = new System.Drawing.Size(140, 23);
       this.tbRoomName.TextChanged += new System.EventHandler(this.tbRoomName_TextChanged);

    this.lblRoomType.AutoSize = true;
     this.lblRoomType.Location = new System.Drawing.Point(440, 60);
            this.lblRoomType.Text = "Loai phong:";

     this.cbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    this.cbRoomType.Location = new System.Drawing.Point(510, 57);
            this.cbRoomType.Size = new System.Drawing.Size(140, 23);
          this.cbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged);

        this.lblRoomTypeDetails.AutoSize = true;
            this.lblRoomTypeDetails.Location = new System.Drawing.Point(660, 60);
      this.lblRoomTypeDetails.Text = "Chi tiet loai phong:";

    this.cbRoomTypeDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
  this.cbRoomTypeDetails.Location = new System.Drawing.Point(780, 57);
            this.cbRoomTypeDetails.Size = new System.Drawing.Size(140, 23);
            this.cbRoomTypeDetails.SelectedIndexChanged += new System.EventHandler(this.cbRoomTypeDetails_SelectedIndexChanged);

 this.lblPrice.AutoSize = true;
         this.lblPrice.Location = new System.Drawing.Point(930, 60);
     this.lblPrice.Text = "Gia phong:";

            this.cbPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrice.Location = new System.Drawing.Point(995, 57);
  this.cbPrice.Size = new System.Drawing.Size(90, 23);
   this.cbPrice.SelectedIndexChanged += new System.EventHandler(this.cbPrice_SelectedIndexChanged);

     this.lblStatus.AutoSize = true;
      this.lblStatus.Location = new System.Drawing.Point(20, 95);
  this.lblStatus.Text = "Tinh trang:";

   this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cbStatus.Location = new System.Drawing.Point(85, 92);
            this.cbStatus.Size = new System.Drawing.Size(140, 23);
    this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);

            this.lblCondition.AutoSize = true;
       this.lblCondition.Location = new System.Drawing.Point(240, 95);
        this.lblCondition.Text = "Hien trang:";

  this.cbCurrentCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrentCondition.Location = new System.Drawing.Point(310, 92);
      this.cbCurrentCondition.Size = new System.Drawing.Size(140, 23);
            this.cbCurrentCondition.SelectedIndexChanged += new System.EventHandler(this.cbCurrentCondition_SelectedIndexChanged);

          this.btnSearch.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
   this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
    this.btnSearch.ForeColor = System.Drawing.Color.White;
        this.btnSearch.Location = new System.Drawing.Point(860, 100);
      this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.Text = "Tim kiem";
      this.btnSearch.UseVisualStyleBackColor = false;
       this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
      this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
       this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
  this.btnRefresh.ForeColor = System.Drawing.Color.White;
      this.btnRefresh.Location = new System.Drawing.Point(970, 100);
  this.btnRefresh.Size = new System.Drawing.Size(100, 30);
          this.btnRefresh.Text = "Lam moi";
      this.btnRefresh.UseVisualStyleBackColor = false;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.dgvRooms.AllowUserToAddRows = false;
    this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
    this.colStt, this.colRoomId, this.colRoomName, this.colRoomType,
       this.colPrice, this.colRoomTypeDetails, this.colStatus, this.colCondition
   });
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(100, 149, 237);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
   this.dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRooms.Location = new System.Drawing.Point(0, 150);
            this.dgvRooms.Name = "dgvRooms";
    this.dgvRooms.ReadOnly = true;
          this.dgvRooms.Size = new System.Drawing.Size(1112, 414);

            this.colStt.HeaderText = "STT";
      this.colStt.Width = 50;
            this.colRoomId.HeaderText = "MA PHONG";
    this.colRoomId.Width = 120;
            this.colRoomName.HeaderText = "TEN PHONG";
       this.colRoomName.Width = 150;
      this.colRoomType.HeaderText = "LOAI PHONG";
         this.colRoomType.Width = 100;
     this.colPrice.HeaderText = "GIA PHONG";
            this.colPrice.Width = 110;
          this.colRoomTypeDetails.HeaderText = "CHI TIET LOAI PHONG";
            this.colRoomTypeDetails.Width = 150;
  this.colStatus.HeaderText = "TINH TRANG";
        this.colStatus.Width = 100;
            this.colCondition.HeaderText = "HIEN TRANG";
   this.colCondition.Width = 100;

            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
        this.pnlButtons.Controls.Add(this.btnAddRoom);
        this.pnlButtons.Controls.Add(this.btnViewDetails);
   this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlButtons.Location = new System.Drawing.Point(0, 564);
 this.pnlButtons.Name = "pnlButtons";
    this.pnlButtons.Padding = new System.Windows.Forms.Padding(15);
            this.pnlButtons.Size = new System.Drawing.Size(1112, 50);

            this.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
 this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
  this.btnAddRoom.Location = new System.Drawing.Point(780, 10);
            this.btnAddRoom.Size = new System.Drawing.Size(130, 35);
      this.btnAddRoom.Text = "Them phong moi";
   this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);

            this.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(183, 149, 11);
          this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
       this.btnViewDetails.Location = new System.Drawing.Point(920, 10);
     this.btnViewDetails.Size = new System.Drawing.Size(110, 35);
            this.btnViewDetails.Text = "Xem chi tiet";
 this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);

            this.pnlAmenityContainer.Dock = System.Windows.Forms.DockStyle.Fill;
   this.pnlAmenityContainer.Controls.Add(this.pnlAmenityList);
            this.pnlAmenityContainer.Controls.Add(this.pnlAmenityDetail);
            this.pnlAmenityContainer.Padding = new System.Windows.Forms.Padding(10);

    this.pnlAmenityList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAmenityList.BackColor = System.Drawing.Color.White;
    this.pnlAmenityList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlAmenityList.Controls.Add(this.dgvAmenities);
            this.pnlAmenityList.Controls.Add(this.tbAmenitySearch);
      this.pnlAmenityList.Controls.Add(this.lblAmenityListTitle);
            this.pnlAmenityList.Padding = new System.Windows.Forms.Padding(10);

       this.lblAmenityListTitle.AutoSize = true;
            this.lblAmenityListTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
this.lblAmenityListTitle.Location = new System.Drawing.Point(10, 10);
            this.lblAmenityListTitle.Text = "DANH SACH TIEN ICH";

   this.tbAmenitySearch.Location = new System.Drawing.Point(260, 8);
            this.tbAmenitySearch.Size = new System.Drawing.Size(520, 23);
            this.tbAmenitySearch.PlaceholderText = "Nhap ma/ten tien ich can tim...";

  this.dgvAmenities.AllowUserToAddRows = false;
       this.dgvAmenities.AllowUserToDeleteRows = false;
      this.dgvAmenities.BackgroundColor = System.Drawing.Color.White;
   this.dgvAmenities.BorderStyle = System.Windows.Forms.BorderStyle.None;
    this.dgvAmenities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
  this.dgvAmenities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colAmenityStt, this.colAmenityId, this.colAmenityName });
  this.dgvAmenities.Location = new System.Drawing.Point(10, 45);
        this.dgvAmenities.Size = new System.Drawing.Size(780, 535);

     this.colAmenityStt.HeaderText = "STT";
    this.colAmenityStt.Width = 50;
     this.colAmenityId.HeaderText = "MA TIEN ICH";
            this.colAmenityId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
    this.colAmenityName.HeaderText = "TEN TIEN ICH";
     this.colAmenityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

    this.pnlAmenityDetail.Dock = System.Windows.Forms.DockStyle.Right;
        this.pnlAmenityDetail.Width = 280;
            this.pnlAmenityDetail.BackColor = System.Drawing.Color.White;
       this.pnlAmenityDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    this.pnlAmenityDetail.Padding = new System.Windows.Forms.Padding(10);
   this.pnlAmenityDetail.Controls.Add(this.grpAmenityActions);
     this.pnlAmenityDetail.Controls.Add(this.grpAmenityInfo);

            this.grpAmenityInfo.Text = "Thong tin chi tiet";
            this.grpAmenityInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAmenityInfo.Height = 160;
    this.grpAmenityInfo.Controls.Add(this.lblAmenityId);
          this.grpAmenityInfo.Controls.Add(this.tbAmenityId);
 this.grpAmenityInfo.Controls.Add(this.lblAmenityName);
  this.grpAmenityInfo.Controls.Add(this.tbAmenityName);

          this.lblAmenityId.AutoSize = true;
     this.lblAmenityId.Location = new System.Drawing.Point(10, 30);
            this.lblAmenityId.Text = "Ma tien ich:";
       this.tbAmenityId.Location = new System.Drawing.Point(10, 50);
  this.tbAmenityId.Size = new System.Drawing.Size(240, 23);

       this.lblAmenityName.AutoSize = true;
    this.lblAmenityName.Location = new System.Drawing.Point(10, 85);
            this.lblAmenityName.Text = "Ten tien ich:";
         this.tbAmenityName.Location = new System.Drawing.Point(10, 105);
 this.tbAmenityName.Size = new System.Drawing.Size(240, 23);

  this.grpAmenityActions.Text = "Chuc nang";
            this.grpAmenityActions.Dock = System.Windows.Forms.DockStyle.Fill;
  this.grpAmenityActions.Controls.Add(this.btnAmenityAdd);
       this.grpAmenityActions.Controls.Add(this.btnAmenityEdit);
      this.grpAmenityActions.Controls.Add(this.btnAmenityDelete);
         this.grpAmenityActions.Controls.Add(this.btnAmenitySave);
      this.grpAmenityActions.Controls.Add(this.btnAmenityCancel);

  this.btnAmenityAdd.Text = "Them";
  this.btnAmenityAdd.BackColor = System.Drawing.Color.Green;
 this.btnAmenityAdd.ForeColor = System.Drawing.Color.White;
            this.btnAmenityAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmenityAdd.Location = new System.Drawing.Point(10, 30);
 this.btnAmenityAdd.Size = new System.Drawing.Size(60, 30);

    this.btnAmenityEdit.Text = "Sua";
        this.btnAmenityEdit.BackColor = System.Drawing.Color.Orange;
       this.btnAmenityEdit.ForeColor = System.Drawing.Color.White;
     this.btnAmenityEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
       this.btnAmenityEdit.Location = new System.Drawing.Point(80, 30);
         this.btnAmenityEdit.Size = new System.Drawing.Size(60, 30);

            this.btnAmenityDelete.Text = "Xoa";
       this.btnAmenityDelete.BackColor = System.Drawing.Color.Red;
            this.btnAmenityDelete.ForeColor = System.Drawing.Color.White;
            this.btnAmenityDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmenityDelete.Location = new System.Drawing.Point(150, 30);
  this.btnAmenityDelete.Size = new System.Drawing.Size(60, 30);

    this.btnAmenitySave.Text = "Luu";
            this.btnAmenitySave.BackColor = System.Drawing.Color.LightGray;
            this.btnAmenitySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
this.btnAmenitySave.Location = new System.Drawing.Point(10, 70);
            this.btnAmenitySave.Size = new System.Drawing.Size(60, 30);

   this.btnAmenityCancel.Text = "Huy";
  this.btnAmenityCancel.BackColor = System.Drawing.Color.LightGray;
       this.btnAmenityCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmenityCancel.Location = new System.Drawing.Point(80, 70);
         this.btnAmenityCancel.Size = new System.Drawing.Size(60, 30);

     this.Controls.Add(this.tabMain);
        this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "UCRoom";
      this.Size = new System.Drawing.Size(1126, 650);
    this.Load += new System.EventHandler(this.UCRoom_Load);

            this.tabMain.ResumeLayout(false);
        this.tabRoom.ResumeLayout(false);
            this.tabAmenity.ResumeLayout(false);
     this.pnlRoomContainer.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.pnlButtons.ResumeLayout(false);
   this.pnlAmenityContainer.ResumeLayout(false);
     this.pnlAmenityList.ResumeLayout(false);
   this.pnlAmenityList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvAmenities)).EndInit();
        this.pnlAmenityDetail.ResumeLayout(false);
       this.grpAmenityInfo.ResumeLayout(false);
            this.grpAmenityInfo.PerformLayout();
   this.grpAmenityActions.ResumeLayout(false);
         this.ResumeLayout(false);
        }

private System.Windows.Forms.TabControl tabMain;
      private System.Windows.Forms.TabPage tabRoom;
        private System.Windows.Forms.TabPage tabAmenity;
    private System.Windows.Forms.Panel pnlRoomContainer;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Label lblFilterDesc;
        private System.Windows.Forms.Label lblRoomId;
   private System.Windows.Forms.TextBox tbRoomId;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.TextBox tbRoomName;
        private System.Windows.Forms.Label lblRoomType;
      private System.Windows.Forms.ComboBox cbRoomType;
    private System.Windows.Forms.Label lblRoomTypeDetails;
        private System.Windows.Forms.ComboBox cbRoomTypeDetails;
      private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cbPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.ComboBox cbCurrentCondition;
private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvRooms;
  private System.Windows.Forms.DataGridViewTextBoxColumn colStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomTypeDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
private System.Windows.Forms.DataGridViewTextBoxColumn colCondition;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Panel pnlAmenityContainer;
        private System.Windows.Forms.Panel pnlAmenityList;
     private System.Windows.Forms.Label lblAmenityListTitle;
        private System.Windows.Forms.TextBox tbAmenitySearch;
        private System.Windows.Forms.DataGridView dgvAmenities;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmenityStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmenityId;
private System.Windows.Forms.DataGridViewTextBoxColumn colAmenityName;
        private System.Windows.Forms.Panel pnlAmenityDetail;
        private System.Windows.Forms.GroupBox grpAmenityInfo;
        private System.Windows.Forms.Label lblAmenityId;
        private System.Windows.Forms.TextBox tbAmenityId;
    private System.Windows.Forms.Label lblAmenityName;
        private System.Windows.Forms.TextBox tbAmenityName;
    private System.Windows.Forms.GroupBox grpAmenityActions;
        private System.Windows.Forms.Button btnAmenityAdd;
        private System.Windows.Forms.Button btnAmenityEdit;
     private System.Windows.Forms.Button btnAmenityDelete;
        private System.Windows.Forms.Button btnAmenitySave;
        private System.Windows.Forms.Button btnAmenityCancel;
  }
}
