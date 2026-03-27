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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

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

            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabRoom);
            this.tabMain.Controls.Add(this.tabAmenity);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1126, 650);

            // 
            // tabRoom
            // 
            this.tabRoom.Controls.Add(this.pnlRoomContainer);
            this.tabRoom.Location = new System.Drawing.Point(4, 26);
            this.tabRoom.Name = "tabRoom";
            this.tabRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoom.Size = new System.Drawing.Size(1118, 620);
            this.tabRoom.Text = "Quản lý phòng";
            this.tabRoom.UseVisualStyleBackColor = true;

            // 
            // tabAmenity
            // 
            this.tabAmenity.Controls.Add(this.pnlAmenityContainer);
            this.tabAmenity.Location = new System.Drawing.Point(4, 26);
            this.tabAmenity.Name = "tabAmenity";
            this.tabAmenity.Padding = new System.Windows.Forms.Padding(3);
            this.tabAmenity.Size = new System.Drawing.Size(1118, 620);
            this.tabAmenity.Text = "Quản lý tiện ích";
            this.tabAmenity.UseVisualStyleBackColor = true;

            // 
            // pnlRoomContainer
            // 
            this.pnlRoomContainer.Controls.Add(this.dgvRooms);
            this.pnlRoomContainer.Controls.Add(this.pnlButtons);
            this.pnlRoomContainer.Controls.Add(this.pnlFilter);
            this.pnlRoomContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoomContainer.Location = new System.Drawing.Point(3, 3);
            this.pnlRoomContainer.Name = "pnlRoomContainer";
            this.pnlRoomContainer.Size = new System.Drawing.Size(1112, 614);

            // 
            // pnlFilter
            // 
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

            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFilterTitle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblFilterTitle.Location = new System.Drawing.Point(20, 10);
            this.lblFilterTitle.Text = "QUẢN LÝ PHÒNG";

            // 
            // lblFilterDesc
            // 
            this.lblFilterDesc.AutoSize = true;
            this.lblFilterDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterDesc.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblFilterDesc.Location = new System.Drawing.Point(20, 33);
            this.lblFilterDesc.Text = "Vui lòng bấm vào bảng danh sách phòng để chỉnh sửa";

            // 
            // lblRoomId
            // 
            this.lblRoomId.AutoSize = true;
            this.lblRoomId.Location = new System.Drawing.Point(20, 60);
            this.lblRoomId.Text = "Mã phòng:";

            // 
            // tbRoomId
            // 
            this.tbRoomId.Location = new System.Drawing.Point(85, 57);
            this.tbRoomId.Size = new System.Drawing.Size(120, 25);
            this.tbRoomId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRoomId.TextChanged += new System.EventHandler(this.tbRoomId_TextChanged);

            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(220, 60);
            this.lblRoomName.Text = "Tên phòng:";

            // 
            // tbRoomName
            // 
            this.tbRoomName.Location = new System.Drawing.Point(290, 57);
            this.tbRoomName.Size = new System.Drawing.Size(140, 25);
            this.tbRoomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRoomName.TextChanged += new System.EventHandler(this.tbRoomName_TextChanged);

            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(440, 60);
            this.lblRoomType.Text = "Loại phòng:";

            // 
            // cbRoomType
            // 
            this.cbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoomType.Location = new System.Drawing.Point(510, 57);
            this.cbRoomType.Size = new System.Drawing.Size(140, 25);
            this.cbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged);

            // 
            // lblRoomTypeDetails
            // 
            this.lblRoomTypeDetails.AutoSize = true;
            this.lblRoomTypeDetails.Location = new System.Drawing.Point(660, 60);
            this.lblRoomTypeDetails.Text = "Chi tiết loại phòng:";

            // 
            // cbRoomTypeDetails
            // 
            this.cbRoomTypeDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomTypeDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoomTypeDetails.Location = new System.Drawing.Point(780, 57);
            this.cbRoomTypeDetails.Size = new System.Drawing.Size(140, 25);
            this.cbRoomTypeDetails.SelectedIndexChanged += new System.EventHandler(this.cbRoomTypeDetails_SelectedIndexChanged);

            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(930, 60);
            this.lblPrice.Text = "Giá phòng:";

            // 
            // cbPrice
            // 
            this.cbPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPrice.Location = new System.Drawing.Point(995, 57);
            this.cbPrice.Size = new System.Drawing.Size(90, 25);
            this.cbPrice.SelectedIndexChanged += new System.EventHandler(this.cbPrice_SelectedIndexChanged);

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 95);
            this.lblStatus.Text = "Tình trạng:";

            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatus.Location = new System.Drawing.Point(85, 92);
            this.cbStatus.Size = new System.Drawing.Size(140, 25);
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);

            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(240, 95);
            this.lblCondition.Text = "Hiện trạng:";

            // 
            // cbCurrentCondition
            // 
            this.cbCurrentCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrentCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCurrentCondition.Location = new System.Drawing.Point(310, 92);
            this.cbCurrentCondition.Size = new System.Drawing.Size(140, 25);
            this.cbCurrentCondition.SelectedIndexChanged += new System.EventHandler(this.cbCurrentCondition_SelectedIndexChanged);

            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(860, 100);
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(970, 100);
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // 
            // dgvRooms - MODERN PROFESSIONAL DESIGN
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRooms.ColumnHeadersHeight = 45;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colStt, this.colRoomId, this.colRoomName, this.colRoomType,
                this.colPrice, this.colRoomTypeDetails, this.colStatus, this.colCondition
            });

            // Column Header Style - Modern Material Design
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;

            this.dgvRooms.EnableHeadersVisualStyles = false;
            this.dgvRooms.GridColor = System.Drawing.Color.FromArgb(231, 231, 231);
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.RowTemplate.Height = 40;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.MultiSelect = false;

            // Default Cell Style - Clean and readable
            this.dgvRooms.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvRooms.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.dgvRooms.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvRooms.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(230, 240, 250);
            this.dgvRooms.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.dgvRooms.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.dgvRooms.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

            // Alternating Row Style - Subtle difference
            this.dgvRooms.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.dgvRooms.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(230, 240, 250);

            this.dgvRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRooms.Location = new System.Drawing.Point(0, 150);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.Size = new System.Drawing.Size(1112, 414);
            this.dgvRooms.TabIndex = 0;
            //this.dgvRooms.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellMouseEnter);
            //this.dgvRooms.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellMouseLeave);

            // 
            // Columns configuration
            // 
            this.colStt.HeaderText = "STT";
            this.colStt.Width = 60;
            this.colStt.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            this.colRoomId.HeaderText = "MÃ PHÒNG";
            this.colRoomId.Width = 120;

            this.colRoomName.HeaderText = "TÊN PHÒNG";
            this.colRoomName.Width = 180;

            this.colRoomType.HeaderText = "LOẠI PHÒNG";
            this.colRoomType.Width = 130;

            this.colPrice.HeaderText = "GIÁ PHÒNG";
            this.colPrice.Width = 130;
            this.colPrice.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPrice.DefaultCellStyle.Format = "N0";

            this.colRoomTypeDetails.HeaderText = "CHI TIẾT LOẠI PHÒNG";
            this.colRoomTypeDetails.Width = 180;

            this.colStatus.HeaderText = "TÌNH TRẠNG";
            this.colStatus.Width = 120;
            this.colStatus.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            this.colCondition.HeaderText = "HIỆN TRẠNG";
            this.colCondition.Width = 120;
            this.colCondition.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.pnlButtons.Controls.Add(this.btnAddRoom);
            this.pnlButtons.Controls.Add(this.btnViewDetails);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 564);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(15);
            this.pnlButtons.Size = new System.Drawing.Size(1112, 50);

            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.FlatAppearance.BorderSize = 0;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(780, 10);
            this.btnAddRoom.Size = new System.Drawing.Size(130, 35);
            this.btnAddRoom.Text = "Thêm phòng mới";
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);

            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(183, 149, 11);
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(920, 10);
            this.btnViewDetails.Size = new System.Drawing.Size(110, 35);
            this.btnViewDetails.Text = "Xem chi tiết";
            this.btnViewDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);

            // 
            // pnlAmenityContainer
            // 
            this.pnlAmenityContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAmenityContainer.Controls.Add(this.pnlAmenityList);
            this.pnlAmenityContainer.Controls.Add(this.pnlAmenityDetail);
            this.pnlAmenityContainer.Padding = new System.Windows.Forms.Padding(10);

            // 
            // pnlAmenityList
            // 
            this.pnlAmenityList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAmenityList.BackColor = System.Drawing.Color.White;
            this.pnlAmenityList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAmenityList.Controls.Add(this.dgvAmenities);
            this.pnlAmenityList.Controls.Add(this.tbAmenitySearch);
            this.pnlAmenityList.Controls.Add(this.lblAmenityListTitle);
            this.pnlAmenityList.Padding = new System.Windows.Forms.Padding(10);

            // 
            // lblAmenityListTitle
            // 
            this.lblAmenityListTitle.AutoSize = true;
            this.lblAmenityListTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAmenityListTitle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblAmenityListTitle.Location = new System.Drawing.Point(10, 10);
            this.lblAmenityListTitle.Text = "DANH SÁCH TIỆN ÍCH";

            // 
            // tbAmenitySearch
            // 
            this.tbAmenitySearch.Location = new System.Drawing.Point(260, 8);
            this.tbAmenitySearch.Size = new System.Drawing.Size(520, 25);
            this.tbAmenitySearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAmenitySearch.Font = new System.Drawing.Font("Segoe UI", 10F);

            // 
            // dgvAmenities - MODERN DESIGN
            // 
            this.dgvAmenities.AllowUserToAddRows = false;
            this.dgvAmenities.AllowUserToDeleteRows = false;
            this.dgvAmenities.BackgroundColor = System.Drawing.Color.White;
            this.dgvAmenities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAmenities.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAmenities.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAmenities.ColumnHeadersHeight = 40;
            this.dgvAmenities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAmenities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colAmenityStt, this.colAmenityId, this.colAmenityName
            });

            // Column Header Style
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvAmenities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;

            this.dgvAmenities.EnableHeadersVisualStyles = false;
            this.dgvAmenities.GridColor = System.Drawing.Color.FromArgb(231, 231, 231);
            this.dgvAmenities.RowHeadersVisible = false;
            this.dgvAmenities.RowTemplate.Height = 38;
            this.dgvAmenities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAmenities.MultiSelect = false;

            this.dgvAmenities.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvAmenities.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.dgvAmenities.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvAmenities.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(230, 240, 250);
            this.dgvAmenities.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.dgvAmenities.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);

            this.dgvAmenities.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.dgvAmenities.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(230, 240, 250);

            this.dgvAmenities.Location = new System.Drawing.Point(10, 45);
            this.dgvAmenities.Size = new System.Drawing.Size(780, 535);
            this.dgvAmenities.ReadOnly = true;

            // 
            // Amenity Columns
            // 
            this.colAmenityStt.HeaderText = "STT";
            this.colAmenityStt.Width = 60;
            this.colAmenityStt.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            this.colAmenityId.HeaderText = "MÃ TIỆN ÍCH";
            this.colAmenityId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAmenityId.FillWeight = 40;

            this.colAmenityName.HeaderText = "TÊN TIỆN ÍCH";
            this.colAmenityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAmenityName.FillWeight = 60;

            // 
            // pnlAmenityDetail
            // 
            this.pnlAmenityDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAmenityDetail.Width = 280;
            this.pnlAmenityDetail.BackColor = System.Drawing.Color.White;
            this.pnlAmenityDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAmenityDetail.Padding = new System.Windows.Forms.Padding(10);
            this.pnlAmenityDetail.Controls.Add(this.grpAmenityActions);
            this.pnlAmenityDetail.Controls.Add(this.grpAmenityInfo);

            // 
            // grpAmenityInfo
            // 
            this.grpAmenityInfo.Text = "Thông tin chi tiết";
            this.grpAmenityInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpAmenityInfo.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.grpAmenityInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAmenityInfo.Height = 160;
            this.grpAmenityInfo.Controls.Add(this.lblAmenityId);
            this.grpAmenityInfo.Controls.Add(this.tbAmenityId);
            this.grpAmenityInfo.Controls.Add(this.lblAmenityName);
            this.grpAmenityInfo.Controls.Add(this.tbAmenityName);

            // 
            // lblAmenityId
            // 
            this.lblAmenityId.AutoSize = true;
            this.lblAmenityId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAmenityId.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblAmenityId.Location = new System.Drawing.Point(10, 30);
            this.lblAmenityId.Text = "Mã tiện ích:";

            // 
            // tbAmenityId
            // 
            this.tbAmenityId.Location = new System.Drawing.Point(10, 50);
            this.tbAmenityId.Size = new System.Drawing.Size(240, 23);
            this.tbAmenityId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // lblAmenityName
            // 
            this.lblAmenityName.AutoSize = true;
            this.lblAmenityName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAmenityName.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblAmenityName.Location = new System.Drawing.Point(10, 85);
            this.lblAmenityName.Text = "Tên tiện ích:";

            // 
            // tbAmenityName
            // 
            this.tbAmenityName.Location = new System.Drawing.Point(10, 105);
            this.tbAmenityName.Size = new System.Drawing.Size(240, 23);
            this.tbAmenityName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // grpAmenityActions
            // 
            this.grpAmenityActions.Text = "Chức năng";
            this.grpAmenityActions.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpAmenityActions.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.grpAmenityActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAmenityActions.Controls.Add(this.btnAmenityAdd);
            this.grpAmenityActions.Controls.Add(this.btnAmenityEdit);
            this.grpAmenityActions.Controls.Add(this.btnAmenityDelete);
            this.grpAmenityActions.Controls.Add(this.btnAmenitySave);
            this.grpAmenityActions.Controls.Add(this.btnAmenityCancel);

            // 
            // btnAmenityAdd
            // 
            this.btnAmenityAdd.Text = "Thêm";
            this.btnAmenityAdd.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnAmenityAdd.ForeColor = System.Drawing.Color.White;
            this.btnAmenityAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmenityAdd.FlatAppearance.BorderSize = 0;
            this.btnAmenityAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAmenityAdd.Location = new System.Drawing.Point(10, 30);
            this.btnAmenityAdd.Size = new System.Drawing.Size(70, 32);
            this.btnAmenityAdd.Cursor = System.Windows.Forms.Cursors.Hand;

            // 
            // btnAmenityEdit
            // 
            this.btnAmenityEdit.Text = "Sửa";
            this.btnAmenityEdit.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            this.btnAmenityEdit.ForeColor = System.Drawing.Color.White;
            this.btnAmenityEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmenityEdit.FlatAppearance.BorderSize = 0;
            this.btnAmenityEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAmenityEdit.Location = new System.Drawing.Point(90, 30);
            this.btnAmenityEdit.Size = new System.Drawing.Size(70, 32);
            this.btnAmenityEdit.Cursor = System.Windows.Forms.Cursors.Hand;

            // 
            // btnAmenityDelete
            // 
            this.btnAmenityDelete.Text = "Xóa";
            this.btnAmenityDelete.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnAmenityDelete.ForeColor = System.Drawing.Color.White;
            this.btnAmenityDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmenityDelete.FlatAppearance.BorderSize = 0;
            this.btnAmenityDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAmenityDelete.Location = new System.Drawing.Point(170, 30);
            this.btnAmenityDelete.Size = new System.Drawing.Size(70, 32);
            this.btnAmenityDelete.Cursor = System.Windows.Forms.Cursors.Hand;

            // 
            // btnAmenitySave
            // 
            this.btnAmenitySave.Text = "Lưu";
            this.btnAmenitySave.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnAmenitySave.ForeColor = System.Drawing.Color.White;
            this.btnAmenitySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmenitySave.FlatAppearance.BorderSize = 0;
            this.btnAmenitySave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAmenitySave.Location = new System.Drawing.Point(10, 75);
            this.btnAmenitySave.Size = new System.Drawing.Size(70, 32);
            this.btnAmenitySave.Cursor = System.Windows.Forms.Cursors.Hand;

            // 
            // btnAmenityCancel
            // 
            this.btnAmenityCancel.Text = "Hủy";
            this.btnAmenityCancel.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnAmenityCancel.ForeColor = System.Drawing.Color.White;
            this.btnAmenityCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmenityCancel.FlatAppearance.BorderSize = 0;
            this.btnAmenityCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAmenityCancel.Location = new System.Drawing.Point(90, 75);
            this.btnAmenityCancel.Size = new System.Drawing.Size(70, 32);
            this.btnAmenityCancel.Cursor = System.Windows.Forms.Cursors.Hand;

            // 
            // UCRoom
            // 
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