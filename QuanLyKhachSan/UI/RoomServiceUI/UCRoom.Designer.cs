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
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle33 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
            tabMain = new TabControl();
            tabRoom = new TabPage();
            pnlRoomContainer = new Panel();
            dgvRooms = new DataGridView();
            colStt = new DataGridViewTextBoxColumn();
            colRoomId = new DataGridViewTextBoxColumn();
            colRoomName = new DataGridViewTextBoxColumn();
            colRoomType = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colRoomTypeDetails = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colCondition = new DataGridViewTextBoxColumn();
            pnlButtons = new Panel();
            btnAddRoom = new Button();
            btnViewDetails = new Button();
            pnlFilter = new Panel();
            lblFilterTitle = new Label();
            lblFilterDesc = new Label();
            lblRoomId = new Label();
            tbRoomId = new TextBox();
            lblRoomName = new Label();
            tbRoomName = new TextBox();
            lblRoomType = new Label();
            cbRoomType = new ComboBox();
            lblRoomTypeDetails = new Label();
            cbRoomTypeDetails = new ComboBox();
            lblPrice = new Label();
            cbPrice = new ComboBox();
            lblStatus = new Label();
            cbStatus = new ComboBox();
            lblCondition = new Label();
            cbCurrentCondition = new ComboBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            tabAmenity = new TabPage();
            pnlAmenityContainer = new Panel();
            pnlAmenityList = new Panel();
            dgvAmenities = new DataGridView();
            colAmenityStt = new DataGridViewTextBoxColumn();
            colAmenityId = new DataGridViewTextBoxColumn();
            colAmenityName = new DataGridViewTextBoxColumn();
            tbAmenitySearch = new TextBox();
            lblAmenityListTitle = new Label();
            pnlAmenityDetail = new Panel();
            grpAmenityActions = new GroupBox();
            btnAmenityAdd = new Button();
            btnAmenityEdit = new Button();
            btnAmenityDelete = new Button();
            btnAmenitySave = new Button();
            btnAmenityCancel = new Button();
            grpAmenityInfo = new GroupBox();
            lblAmenityId = new Label();
            tbAmenityId = new TextBox();
            lblAmenityName = new Label();
            tbAmenityName = new TextBox();
            tabMain.SuspendLayout();
            tabRoom.SuspendLayout();
            pnlRoomContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            pnlButtons.SuspendLayout();
            pnlFilter.SuspendLayout();
            tabAmenity.SuspendLayout();
            pnlAmenityContainer.SuspendLayout();
            pnlAmenityList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAmenities).BeginInit();
            pnlAmenityDetail.SuspendLayout();
            grpAmenityActions.SuspendLayout();
            grpAmenityInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabRoom);
            tabMain.Controls.Add(tabAmenity);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Font = new Font("Segoe UI", 10F);
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1126, 650);
            tabMain.TabIndex = 0;
            // 
            // tabRoom
            // 
            tabRoom.Controls.Add(pnlRoomContainer);
            tabRoom.Location = new Point(4, 26);
            tabRoom.Name = "tabRoom";
            tabRoom.Padding = new Padding(3);
            tabRoom.Size = new Size(1118, 620);
            tabRoom.TabIndex = 0;
            tabRoom.Text = "Quản lý phòng";
            tabRoom.UseVisualStyleBackColor = true;
            // 
            // pnlRoomContainer
            // 
            pnlRoomContainer.Controls.Add(dgvRooms);
            pnlRoomContainer.Controls.Add(pnlButtons);
            pnlRoomContainer.Controls.Add(pnlFilter);
            pnlRoomContainer.Dock = DockStyle.Fill;
            pnlRoomContainer.Location = new Point(3, 3);
            pnlRoomContainer.Name = "pnlRoomContainer";
            pnlRoomContainer.Size = new Size(1112, 614);
            pnlRoomContainer.TabIndex = 0;
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AllowUserToDeleteRows = false;
            dataGridViewCellStyle23.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle23.SelectionBackColor = Color.FromArgb(230, 240, 250);
            dgvRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            dgvRooms.BackgroundColor = Color.White;
            dgvRooms.BorderStyle = BorderStyle.None;
            dgvRooms.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRooms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle24.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle24.ForeColor = Color.White;
            dataGridViewCellStyle24.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle24.SelectionForeColor = Color.White;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            dgvRooms.ColumnHeadersHeight = 45;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRooms.Columns.AddRange(new DataGridViewColumn[] { colStt, colRoomId, colRoomName, colRoomType, colPrice, colRoomTypeDetails, colStatus, colCondition });
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = Color.White;
            dataGridViewCellStyle29.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle29.ForeColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle29.Padding = new Padding(10, 5, 5, 5);
            dataGridViewCellStyle29.SelectionBackColor = Color.FromArgb(230, 240, 250);
            dataGridViewCellStyle29.SelectionForeColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle29.WrapMode = DataGridViewTriState.False;
            dgvRooms.DefaultCellStyle = dataGridViewCellStyle29;
            dgvRooms.Dock = DockStyle.Fill;
            dgvRooms.EnableHeadersVisualStyles = false;
            dgvRooms.GridColor = Color.FromArgb(231, 231, 231);
            dgvRooms.Location = new Point(0, 150);
            dgvRooms.MultiSelect = false;
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersVisible = false;
            dgvRooms.RowTemplate.Height = 40;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(1112, 414);
            dgvRooms.TabIndex = 0;
            dgvRooms.CellContentClick += dgvRooms_CellContentClick;
            // 
            // colStt
            // 
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colStt.DefaultCellStyle = dataGridViewCellStyle25;
            colStt.HeaderText = "STT";
            colStt.Name = "colStt";
            colStt.ReadOnly = true;
            colStt.Width = 60;
            // 
            // colRoomId
            // 
            colRoomId.HeaderText = "MÃ PHÒNG";
            colRoomId.Name = "colRoomId";
            colRoomId.ReadOnly = true;
            colRoomId.Width = 120;
            // 
            // colRoomName
            // 
            colRoomName.HeaderText = "TÊN PHÒNG";
            colRoomName.Name = "colRoomName";
            colRoomName.ReadOnly = true;
            colRoomName.Width = 180;
            // 
            // colRoomType
            // 
            colRoomType.HeaderText = "LOẠI PHÒNG";
            colRoomType.Name = "colRoomType";
            colRoomType.ReadOnly = true;
            colRoomType.Width = 130;
            // 
            // colPrice
            // 
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "N0";
            colPrice.DefaultCellStyle = dataGridViewCellStyle26;
            colPrice.HeaderText = "GIÁ PHÒNG";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Width = 130;
            // 
            // colRoomTypeDetails
            // 
            colRoomTypeDetails.HeaderText = "CHI TIẾT LOẠI PHÒNG";
            colRoomTypeDetails.Name = "colRoomTypeDetails";
            colRoomTypeDetails.ReadOnly = true;
            colRoomTypeDetails.Width = 180;
            // 
            // colStatus
            // 
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colStatus.DefaultCellStyle = dataGridViewCellStyle27;
            colStatus.HeaderText = "TÌNH TRẠNG";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 120;
            // 
            // colCondition
            // 
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCondition.DefaultCellStyle = dataGridViewCellStyle28;
            colCondition.HeaderText = "HIỆN TRẠNG";
            colCondition.Name = "colCondition";
            colCondition.ReadOnly = true;
            colCondition.Width = 120;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(240, 240, 240);
            pnlButtons.Controls.Add(btnAddRoom);
            pnlButtons.Controls.Add(btnViewDetails);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 564);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(15);
            pnlButtons.Size = new Size(1112, 50);
            pnlButtons.TabIndex = 1;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.FromArgb(39, 174, 96);
            btnAddRoom.Cursor = Cursors.Hand;
            btnAddRoom.FlatAppearance.BorderSize = 0;
            btnAddRoom.FlatStyle = FlatStyle.Flat;
            btnAddRoom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Location = new Point(780, 10);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(130, 35);
            btnAddRoom.TabIndex = 0;
            btnAddRoom.Text = "Thêm phòng mới";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.FromArgb(183, 149, 11);
            btnViewDetails.Cursor = Cursors.Hand;
            btnViewDetails.FlatAppearance.BorderSize = 0;
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnViewDetails.ForeColor = Color.White;
            btnViewDetails.Location = new Point(920, 10);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(110, 35);
            btnViewDetails.TabIndex = 1;
            btnViewDetails.Text = "Xem chi tiết";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.FromArgb(240, 240, 240);
            pnlFilter.Controls.Add(lblFilterTitle);
            pnlFilter.Controls.Add(lblFilterDesc);
            pnlFilter.Controls.Add(lblRoomId);
            pnlFilter.Controls.Add(tbRoomId);
            pnlFilter.Controls.Add(lblRoomName);
            pnlFilter.Controls.Add(tbRoomName);
            pnlFilter.Controls.Add(lblRoomType);
            pnlFilter.Controls.Add(cbRoomType);
            pnlFilter.Controls.Add(lblRoomTypeDetails);
            pnlFilter.Controls.Add(cbRoomTypeDetails);
            pnlFilter.Controls.Add(lblPrice);
            pnlFilter.Controls.Add(cbPrice);
            pnlFilter.Controls.Add(lblStatus);
            pnlFilter.Controls.Add(cbStatus);
            pnlFilter.Controls.Add(lblCondition);
            pnlFilter.Controls.Add(cbCurrentCondition);
            pnlFilter.Controls.Add(btnSearch);
            pnlFilter.Controls.Add(btnRefresh);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 0);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(15);
            pnlFilter.Size = new Size(1112, 150);
            pnlFilter.TabIndex = 2;
            // 
            // lblFilterTitle
            // 
            lblFilterTitle.AutoSize = true;
            lblFilterTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFilterTitle.ForeColor = Color.FromArgb(52, 73, 94);
            lblFilterTitle.Location = new Point(20, 10);
            lblFilterTitle.Name = "lblFilterTitle";
            lblFilterTitle.Size = new Size(141, 21);
            lblFilterTitle.TabIndex = 0;
            lblFilterTitle.Text = "QUẢN LÝ PHÒNG";
            // 
            // lblFilterDesc
            // 
            lblFilterDesc.AutoSize = true;
            lblFilterDesc.Font = new Font("Segoe UI", 9F);
            lblFilterDesc.ForeColor = Color.FromArgb(149, 165, 166);
            lblFilterDesc.Location = new Point(20, 33);
            lblFilterDesc.Name = "lblFilterDesc";
            lblFilterDesc.Size = new Size(295, 15);
            lblFilterDesc.TabIndex = 1;
            lblFilterDesc.Text = "Vui lòng bấm vào bảng danh sách phòng để chỉnh sửa";
            // 
            // lblRoomId
            // 
            lblRoomId.AutoSize = true;
            lblRoomId.Location = new Point(4, 60);
            lblRoomId.Name = "lblRoomId";
            lblRoomId.Size = new Size(76, 19);
            lblRoomId.TabIndex = 2;
            lblRoomId.Text = "Mã phòng:";
            // 
            // tbRoomId
            // 
            tbRoomId.BorderStyle = BorderStyle.FixedSingle;
            tbRoomId.Location = new Point(85, 57);
            tbRoomId.Name = "tbRoomId";
            tbRoomId.Size = new Size(120, 25);
            tbRoomId.TabIndex = 3;
            tbRoomId.TextChanged += tbRoomId_TextChanged;
            // 
            // lblRoomName
            // 
            lblRoomName.AutoSize = true;
            lblRoomName.Location = new Point(211, 60);
            lblRoomName.Name = "lblRoomName";
            lblRoomName.Size = new Size(77, 19);
            lblRoomName.TabIndex = 4;
            lblRoomName.Text = "Tên phòng:";
            // 
            // tbRoomName
            // 
            tbRoomName.BorderStyle = BorderStyle.FixedSingle;
            tbRoomName.Location = new Point(294, 57);
            tbRoomName.Name = "tbRoomName";
            tbRoomName.Size = new Size(140, 25);
            tbRoomName.TabIndex = 5;
            tbRoomName.TextChanged += tbRoomName_TextChanged;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Location = new Point(440, 60);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(81, 19);
            lblRoomType.TabIndex = 6;
            lblRoomType.Text = "Loại phòng:";
            // 
            // cbRoomType
            // 
            cbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoomType.FlatStyle = FlatStyle.Flat;
            cbRoomType.Location = new Point(527, 56);
            cbRoomType.Name = "cbRoomType";
            cbRoomType.Size = new Size(140, 25);
            cbRoomType.TabIndex = 7;
            cbRoomType.SelectedIndexChanged += cbRoomType_SelectedIndexChanged;
            // 
            // lblRoomTypeDetails
            // 
            lblRoomTypeDetails.AutoSize = true;
            lblRoomTypeDetails.Location = new Point(676, 59);
            lblRoomTypeDetails.Name = "lblRoomTypeDetails";
            lblRoomTypeDetails.Size = new Size(125, 19);
            lblRoomTypeDetails.TabIndex = 8;
            lblRoomTypeDetails.Text = "Chi tiết loại phòng:";
            // 
            // cbRoomTypeDetails
            // 
            cbRoomTypeDetails.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoomTypeDetails.FlatStyle = FlatStyle.Flat;
            cbRoomTypeDetails.Location = new Point(807, 56);
            cbRoomTypeDetails.Name = "cbRoomTypeDetails";
            cbRoomTypeDetails.Size = new Size(140, 25);
            cbRoomTypeDetails.TabIndex = 9;
            cbRoomTypeDetails.SelectedIndexChanged += cbRoomTypeDetails_SelectedIndexChanged;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(486, 92);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(76, 19);
            lblPrice.TabIndex = 10;
            lblPrice.Text = "Giá phòng:";
            // 
            // cbPrice
            // 
            cbPrice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrice.FlatStyle = FlatStyle.Flat;
            cbPrice.Location = new Point(582, 89);
            cbPrice.Name = "cbPrice";
            cbPrice.Size = new Size(90, 25);
            cbPrice.TabIndex = 11;
            cbPrice.SelectedIndexChanged += cbPrice_SelectedIndexChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(4, 95);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(75, 19);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Tình trạng:";
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FlatStyle = FlatStyle.Flat;
            cbStatus.Location = new Point(85, 92);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(140, 25);
            cbStatus.TabIndex = 13;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Location = new Point(240, 95);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(77, 19);
            lblCondition.TabIndex = 14;
            lblCondition.Text = "Hiện trạng:";
            // 
            // cbCurrentCondition
            // 
            cbCurrentCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCurrentCondition.FlatStyle = FlatStyle.Flat;
            cbCurrentCondition.Location = new Point(323, 92);
            cbCurrentCondition.Name = "cbCurrentCondition";
            cbCurrentCondition.Size = new Size(140, 25);
            cbCurrentCondition.TabIndex = 15;
            cbCurrentCondition.SelectedIndexChanged += cbCurrentCondition_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(52, 152, 219);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(820, 97);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 35);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(149, 165, 166);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(930, 97);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 35);
            btnRefresh.TabIndex = 17;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // tabAmenity
            // 
            tabAmenity.Controls.Add(pnlAmenityContainer);
            tabAmenity.Location = new Point(4, 26);
            tabAmenity.Name = "tabAmenity";
            tabAmenity.Padding = new Padding(3);
            tabAmenity.Size = new Size(1118, 620);
            tabAmenity.TabIndex = 1;
            tabAmenity.Text = "Quản lý tiện ích";
            tabAmenity.UseVisualStyleBackColor = true;
            // 
            // pnlAmenityContainer
            // 
            pnlAmenityContainer.Controls.Add(pnlAmenityList);
            pnlAmenityContainer.Controls.Add(pnlAmenityDetail);
            pnlAmenityContainer.Dock = DockStyle.Fill;
            pnlAmenityContainer.Location = new Point(3, 3);
            pnlAmenityContainer.Name = "pnlAmenityContainer";
            pnlAmenityContainer.Padding = new Padding(10);
            pnlAmenityContainer.Size = new Size(1112, 614);
            pnlAmenityContainer.TabIndex = 0;
            // 
            // pnlAmenityList
            // 
            pnlAmenityList.BackColor = Color.White;
            pnlAmenityList.BorderStyle = BorderStyle.FixedSingle;
            pnlAmenityList.Controls.Add(dgvAmenities);
            pnlAmenityList.Controls.Add(tbAmenitySearch);
            pnlAmenityList.Controls.Add(lblAmenityListTitle);
            pnlAmenityList.Dock = DockStyle.Fill;
            pnlAmenityList.Location = new Point(10, 10);
            pnlAmenityList.Name = "pnlAmenityList";
            pnlAmenityList.Padding = new Padding(10);
            pnlAmenityList.Size = new Size(812, 594);
            pnlAmenityList.TabIndex = 0;
            // 
            // dgvAmenities
            // 
            dgvAmenities.AllowUserToAddRows = false;
            dgvAmenities.AllowUserToDeleteRows = false;
            dataGridViewCellStyle30.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle30.SelectionBackColor = Color.FromArgb(230, 240, 250);
            dgvAmenities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle30;
            dgvAmenities.BackgroundColor = Color.White;
            dgvAmenities.BorderStyle = BorderStyle.None;
            dgvAmenities.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAmenities.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle31.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle31.ForeColor = Color.White;
            dataGridViewCellStyle31.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle31.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle31.SelectionForeColor = Color.White;
            dgvAmenities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            dgvAmenities.ColumnHeadersHeight = 40;
            dgvAmenities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAmenities.Columns.AddRange(new DataGridViewColumn[] { colAmenityStt, colAmenityId, colAmenityName });
            dataGridViewCellStyle33.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = Color.White;
            dataGridViewCellStyle33.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle33.ForeColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle33.Padding = new Padding(10, 5, 5, 5);
            dataGridViewCellStyle33.SelectionBackColor = Color.FromArgb(230, 240, 250);
            dataGridViewCellStyle33.SelectionForeColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle33.WrapMode = DataGridViewTriState.False;
            dgvAmenities.DefaultCellStyle = dataGridViewCellStyle33;
            dgvAmenities.EnableHeadersVisualStyles = false;
            dgvAmenities.GridColor = Color.FromArgb(231, 231, 231);
            dgvAmenities.Location = new Point(10, 45);
            dgvAmenities.MultiSelect = false;
            dgvAmenities.Name = "dgvAmenities";
            dgvAmenities.ReadOnly = true;
            dgvAmenities.RowHeadersVisible = false;
            dgvAmenities.RowTemplate.Height = 38;
            dgvAmenities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAmenities.Size = new Size(780, 535);
            dgvAmenities.TabIndex = 0;
            // 
            // colAmenityStt
            // 
            dataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colAmenityStt.DefaultCellStyle = dataGridViewCellStyle32;
            colAmenityStt.HeaderText = "STT";
            colAmenityStt.Name = "colAmenityStt";
            colAmenityStt.ReadOnly = true;
            colAmenityStt.Width = 60;
            // 
            // colAmenityId
            // 
            colAmenityId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAmenityId.FillWeight = 40F;
            colAmenityId.HeaderText = "MÃ TIỆN ÍCH";
            colAmenityId.Name = "colAmenityId";
            colAmenityId.ReadOnly = true;
            // 
            // colAmenityName
            // 
            colAmenityName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAmenityName.FillWeight = 60F;
            colAmenityName.HeaderText = "TÊN TIỆN ÍCH";
            colAmenityName.Name = "colAmenityName";
            colAmenityName.ReadOnly = true;
            // 
            // tbAmenitySearch
            // 
            tbAmenitySearch.BorderStyle = BorderStyle.FixedSingle;
            tbAmenitySearch.Font = new Font("Segoe UI", 10F);
            tbAmenitySearch.Location = new Point(260, 8);
            tbAmenitySearch.Name = "tbAmenitySearch";
            tbAmenitySearch.Size = new Size(520, 25);
            tbAmenitySearch.TabIndex = 1;
            // 
            // lblAmenityListTitle
            // 
            lblAmenityListTitle.AutoSize = true;
            lblAmenityListTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAmenityListTitle.ForeColor = Color.FromArgb(52, 73, 94);
            lblAmenityListTitle.Location = new Point(10, 10);
            lblAmenityListTitle.Name = "lblAmenityListTitle";
            lblAmenityListTitle.Size = new Size(155, 19);
            lblAmenityListTitle.TabIndex = 2;
            lblAmenityListTitle.Text = "DANH SÁCH TIỆN ÍCH";
            // 
            // pnlAmenityDetail
            // 
            pnlAmenityDetail.BackColor = Color.White;
            pnlAmenityDetail.BorderStyle = BorderStyle.FixedSingle;
            pnlAmenityDetail.Controls.Add(grpAmenityActions);
            pnlAmenityDetail.Controls.Add(grpAmenityInfo);
            pnlAmenityDetail.Dock = DockStyle.Right;
            pnlAmenityDetail.Location = new Point(822, 10);
            pnlAmenityDetail.Name = "pnlAmenityDetail";
            pnlAmenityDetail.Padding = new Padding(10);
            pnlAmenityDetail.Size = new Size(280, 594);
            pnlAmenityDetail.TabIndex = 1;
            // 
            // grpAmenityActions
            // 
            grpAmenityActions.Controls.Add(btnAmenityAdd);
            grpAmenityActions.Controls.Add(btnAmenityEdit);
            grpAmenityActions.Controls.Add(btnAmenityDelete);
            grpAmenityActions.Controls.Add(btnAmenitySave);
            grpAmenityActions.Controls.Add(btnAmenityCancel);
            grpAmenityActions.Dock = DockStyle.Fill;
            grpAmenityActions.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpAmenityActions.ForeColor = Color.FromArgb(52, 73, 94);
            grpAmenityActions.Location = new Point(10, 170);
            grpAmenityActions.Name = "grpAmenityActions";
            grpAmenityActions.Size = new Size(258, 412);
            grpAmenityActions.TabIndex = 0;
            grpAmenityActions.TabStop = false;
            grpAmenityActions.Text = "Chức năng";
            // 
            // btnAmenityAdd
            // 
            btnAmenityAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAmenityAdd.Cursor = Cursors.Hand;
            btnAmenityAdd.FlatAppearance.BorderSize = 0;
            btnAmenityAdd.FlatStyle = FlatStyle.Flat;
            btnAmenityAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAmenityAdd.ForeColor = Color.White;
            btnAmenityAdd.Location = new Point(10, 30);
            btnAmenityAdd.Name = "btnAmenityAdd";
            btnAmenityAdd.Size = new Size(70, 32);
            btnAmenityAdd.TabIndex = 0;
            btnAmenityAdd.Text = "Thêm";
            btnAmenityAdd.UseVisualStyleBackColor = false;
            // 
            // btnAmenityEdit
            // 
            btnAmenityEdit.BackColor = Color.FromArgb(243, 156, 18);
            btnAmenityEdit.Cursor = Cursors.Hand;
            btnAmenityEdit.FlatAppearance.BorderSize = 0;
            btnAmenityEdit.FlatStyle = FlatStyle.Flat;
            btnAmenityEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAmenityEdit.ForeColor = Color.White;
            btnAmenityEdit.Location = new Point(90, 30);
            btnAmenityEdit.Name = "btnAmenityEdit";
            btnAmenityEdit.Size = new Size(70, 32);
            btnAmenityEdit.TabIndex = 1;
            btnAmenityEdit.Text = "Sửa";
            btnAmenityEdit.UseVisualStyleBackColor = false;
            // 
            // btnAmenityDelete
            // 
            btnAmenityDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnAmenityDelete.Cursor = Cursors.Hand;
            btnAmenityDelete.FlatAppearance.BorderSize = 0;
            btnAmenityDelete.FlatStyle = FlatStyle.Flat;
            btnAmenityDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAmenityDelete.ForeColor = Color.White;
            btnAmenityDelete.Location = new Point(170, 30);
            btnAmenityDelete.Name = "btnAmenityDelete";
            btnAmenityDelete.Size = new Size(70, 32);
            btnAmenityDelete.TabIndex = 2;
            btnAmenityDelete.Text = "Xóa";
            btnAmenityDelete.UseVisualStyleBackColor = false;
            // 
            // btnAmenitySave
            // 
            btnAmenitySave.BackColor = Color.FromArgb(52, 152, 219);
            btnAmenitySave.Cursor = Cursors.Hand;
            btnAmenitySave.FlatAppearance.BorderSize = 0;
            btnAmenitySave.FlatStyle = FlatStyle.Flat;
            btnAmenitySave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAmenitySave.ForeColor = Color.White;
            btnAmenitySave.Location = new Point(10, 75);
            btnAmenitySave.Name = "btnAmenitySave";
            btnAmenitySave.Size = new Size(70, 32);
            btnAmenitySave.TabIndex = 3;
            btnAmenitySave.Text = "Lưu";
            btnAmenitySave.UseVisualStyleBackColor = false;
            // 
            // btnAmenityCancel
            // 
            btnAmenityCancel.BackColor = Color.FromArgb(149, 165, 166);
            btnAmenityCancel.Cursor = Cursors.Hand;
            btnAmenityCancel.FlatAppearance.BorderSize = 0;
            btnAmenityCancel.FlatStyle = FlatStyle.Flat;
            btnAmenityCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAmenityCancel.ForeColor = Color.White;
            btnAmenityCancel.Location = new Point(90, 75);
            btnAmenityCancel.Name = "btnAmenityCancel";
            btnAmenityCancel.Size = new Size(70, 32);
            btnAmenityCancel.TabIndex = 4;
            btnAmenityCancel.Text = "Hủy";
            btnAmenityCancel.UseVisualStyleBackColor = false;
            // 
            // grpAmenityInfo
            // 
            grpAmenityInfo.Controls.Add(lblAmenityId);
            grpAmenityInfo.Controls.Add(tbAmenityId);
            grpAmenityInfo.Controls.Add(lblAmenityName);
            grpAmenityInfo.Controls.Add(tbAmenityName);
            grpAmenityInfo.Dock = DockStyle.Top;
            grpAmenityInfo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpAmenityInfo.ForeColor = Color.FromArgb(52, 73, 94);
            grpAmenityInfo.Location = new Point(10, 10);
            grpAmenityInfo.Name = "grpAmenityInfo";
            grpAmenityInfo.Size = new Size(258, 160);
            grpAmenityInfo.TabIndex = 1;
            grpAmenityInfo.TabStop = false;
            grpAmenityInfo.Text = "Thông tin chi tiết";
            // 
            // lblAmenityId
            // 
            lblAmenityId.AutoSize = true;
            lblAmenityId.Font = new Font("Segoe UI", 9F);
            lblAmenityId.ForeColor = Color.FromArgb(52, 73, 94);
            lblAmenityId.Location = new Point(10, 30);
            lblAmenityId.Name = "lblAmenityId";
            lblAmenityId.Size = new Size(69, 15);
            lblAmenityId.TabIndex = 0;
            lblAmenityId.Text = "Mã tiện ích:";
            // 
            // tbAmenityId
            // 
            tbAmenityId.BorderStyle = BorderStyle.FixedSingle;
            tbAmenityId.Location = new Point(10, 50);
            tbAmenityId.Name = "tbAmenityId";
            tbAmenityId.Size = new Size(240, 24);
            tbAmenityId.TabIndex = 1;
            // 
            // lblAmenityName
            // 
            lblAmenityName.AutoSize = true;
            lblAmenityName.Font = new Font("Segoe UI", 9F);
            lblAmenityName.ForeColor = Color.FromArgb(52, 73, 94);
            lblAmenityName.Location = new Point(10, 85);
            lblAmenityName.Name = "lblAmenityName";
            lblAmenityName.Size = new Size(70, 15);
            lblAmenityName.TabIndex = 2;
            lblAmenityName.Text = "Tên tiện ích:";
            // 
            // tbAmenityName
            // 
            tbAmenityName.BorderStyle = BorderStyle.FixedSingle;
            tbAmenityName.Location = new Point(10, 105);
            tbAmenityName.Name = "tbAmenityName";
            tbAmenityName.Size = new Size(240, 24);
            tbAmenityName.TabIndex = 3;
            // 
            // UCRoom
            // 
            Controls.Add(tabMain);
            Font = new Font("Segoe UI", 9F);
            Name = "UCRoom";
            Size = new Size(1126, 650);
            Load += UCRoom_Load;
            tabMain.ResumeLayout(false);
            tabRoom.ResumeLayout(false);
            pnlRoomContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            pnlButtons.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            tabAmenity.ResumeLayout(false);
            pnlAmenityContainer.ResumeLayout(false);
            pnlAmenityList.ResumeLayout(false);
            pnlAmenityList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAmenities).EndInit();
            pnlAmenityDetail.ResumeLayout(false);
            grpAmenityActions.ResumeLayout(false);
            grpAmenityInfo.ResumeLayout(false);
            grpAmenityInfo.PerformLayout();
            ResumeLayout(false);
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