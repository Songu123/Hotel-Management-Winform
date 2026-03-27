namespace QuanLyKhachSan.UI.Room_Service
{
    partial class RoomDetailForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnTop = new Panel();
            lblHeader = new Label();
            btnCloseTop = new Button();
            mainLayout = new TableLayoutPanel();
            pnlLeft = new Panel();
            btnNew = new Button();
            cbCurrentState = new ComboBox();
            lblCurrentState = new Label();
            txtStatus = new TextBox();
            lblStatus = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            rbFamily = new RadioButton();
            rbDouble = new RadioButton();
            rbSingle = new RadioButton();
            rbNormal = new RadioButton();
            rbVip = new RadioButton();
            txtRoomName = new TextBox();
            lblRoomName = new Label();
            txtRoomCode = new TextBox();
            lblRoomCode = new Label();
            lblTitle = new Label();
            pnlRight = new Panel();
            rightLayout = new TableLayoutPanel();
            pnlAmenityTop = new Panel();
            btnAddAmenity = new Button();
            numQuantity = new NumericUpDown();
            lblQuantity = new Label();
            dgvAllAmenities = new DataGridView();
            colAllStt = new DataGridViewTextBoxColumn();
            colAllAmenityId = new DataGridViewTextBoxColumn();
            colAllAmenityName = new DataGridViewTextBoxColumn();
            txtSearchAmenity = new TextBox();
            lblAmenitiesTitle = new Label();
            pnlAmenityBottom = new Panel();
            btnDeleteAmenity = new Button();
            btnEditAmenity = new Button();
            numRoomAmenityQuantity = new NumericUpDown();
            lblRoomAmenityQuantity = new Label();
            dgvRoomAmenities = new DataGridView();
            colRoomStt = new DataGridViewTextBoxColumn();
            colRoomAmenityId = new DataGridViewTextBoxColumn();
            colRoomAmenityName = new DataGridViewTextBoxColumn();
            colRoomAmenityQty = new DataGridViewTextBoxColumn();
            txtSearchRoomAmenity = new TextBox();
            lblRoomAmenities = new Label();
            pnlButtons = new Panel();
            btnClose = new Button();
            btnDeleteRoom = new Button();
            btnSaveRoom = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pnTop.SuspendLayout();
            mainLayout.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            rightLayout.SuspendLayout();
            pnlAmenityTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllAmenities).BeginInit();
            pnlAmenityBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRoomAmenityQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomAmenities).BeginInit();
            pnlButtons.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.BackColor = Color.CornflowerBlue;
            pnTop.Controls.Add(lblHeader);
            pnTop.Controls.Add(btnCloseTop);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(0, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(1000, 35);
            pnTop.TabIndex = 2;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(10, 8);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(196, 20);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Thông tin phòng khách sạn";
            // 
            // btnCloseTop
            // 
            btnCloseTop.BackColor = Color.CornflowerBlue;
            btnCloseTop.Dock = DockStyle.Right;
            btnCloseTop.FlatStyle = FlatStyle.Flat;
            btnCloseTop.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnCloseTop.ForeColor = Color.White;
            btnCloseTop.Location = new Point(970, 0);
            btnCloseTop.Name = "btnCloseTop";
            btnCloseTop.Size = new Size(30, 35);
            btnCloseTop.TabIndex = 1;
            btnCloseTop.Text = "✕";
            btnCloseTop.UseVisualStyleBackColor = false;
            btnCloseTop.Click += btnClose_Click;
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
            mainLayout.Controls.Add(pnlLeft, 0, 0);
            mainLayout.Controls.Add(pnlRight, 1, 0);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 35);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(5);
            mainLayout.RowCount = 1;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(1000, 565);
            mainLayout.TabIndex = 0;
            // 
            // pnlLeft
            // 
            pnlLeft.AutoScroll = true;
            pnlLeft.BorderStyle = BorderStyle.FixedSingle;
            pnlLeft.Controls.Add(groupBox2);
            pnlLeft.Controls.Add(groupBox1);
            pnlLeft.Controls.Add(btnNew);
            pnlLeft.Controls.Add(cbCurrentState);
            pnlLeft.Controls.Add(lblCurrentState);
            pnlLeft.Controls.Add(txtStatus);
            pnlLeft.Controls.Add(lblStatus);
            pnlLeft.Controls.Add(txtPrice);
            pnlLeft.Controls.Add(lblPrice);
            pnlLeft.Controls.Add(txtRoomName);
            pnlLeft.Controls.Add(lblRoomName);
            pnlLeft.Controls.Add(txtRoomCode);
            pnlLeft.Controls.Add(lblRoomCode);
            pnlLeft.Controls.Add(lblTitle);
            pnlLeft.Dock = DockStyle.Fill;
            pnlLeft.Location = new Point(8, 8);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(10);
            pnlLeft.Size = new Size(370, 549);
            pnlLeft.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.MediumPurple;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(244, 452);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(100, 35);
            btnNew.TabIndex = 0;
            btnNew.Text = "Làm mới";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // cbCurrentState
            // 
            cbCurrentState.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCurrentState.Items.AddRange(new object[] { "Mới", "Đang sử dụng", "Đang dọn", "Bảo trì" });
            cbCurrentState.Location = new Point(14, 417);
            cbCurrentState.Name = "cbCurrentState";
            cbCurrentState.Size = new Size(330, 23);
            cbCurrentState.TabIndex = 1;
            // 
            // lblCurrentState
            // 
            lblCurrentState.AutoSize = true;
            lblCurrentState.Location = new Point(14, 397);
            lblCurrentState.Name = "lblCurrentState";
            lblCurrentState.Size = new Size(66, 15);
            lblCurrentState.TabIndex = 2;
            lblCurrentState.Text = "Hiện trạng:";
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.FromArgb(240, 240, 240);
            txtStatus.Location = new Point(14, 362);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(330, 23);
            txtStatus.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(14, 342);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(64, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Tình trạng:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(14, 307);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(330, 23);
            txtPrice.TabIndex = 5;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(14, 287);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(65, 15);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Giá phòng:";
            // 
            // rbFamily
            // 
            rbFamily.AutoSize = true;
            rbFamily.Location = new Point(232, 22);
            rbFamily.Name = "rbFamily";
            rbFamily.Size = new Size(79, 19);
            rbFamily.TabIndex = 7;
            rbFamily.Text = "Phòng gia";
            // 
            // rbDouble
            // 
            rbDouble.AutoSize = true;
            rbDouble.Location = new Point(122, 22);
            rbDouble.Name = "rbDouble";
            rbDouble.Size = new Size(80, 19);
            rbDouble.TabIndex = 8;
            rbDouble.Text = "Phòng đôi";
            // 
            // rbSingle
            // 
            rbSingle.AutoSize = true;
            rbSingle.Checked = true;
            rbSingle.Location = new Point(15, 22);
            rbSingle.Name = "rbSingle";
            rbSingle.Size = new Size(84, 19);
            rbSingle.TabIndex = 9;
            rbSingle.TabStop = true;
            rbSingle.Text = "Phòng đơn";
            // 
            // rbNormal
            // 
            rbNormal.AutoSize = true;
            rbNormal.Checked = true;
            rbNormal.Location = new Point(162, 22);
            rbNormal.Name = "rbNormal";
            rbNormal.Size = new Size(102, 19);
            rbNormal.TabIndex = 11;
            rbNormal.TabStop = true;
            rbNormal.Text = "Phòng thường";
            // 
            // rbVip
            // 
            rbVip.AutoSize = true;
            rbVip.Location = new Point(25, 22);
            rbVip.Name = "rbVip";
            rbVip.Size = new Size(80, 19);
            rbVip.TabIndex = 12;
            rbVip.Text = "Phòng Vip";
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new Point(13, 120);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(330, 23);
            txtRoomName.TabIndex = 14;
            // 
            // lblRoomName
            // 
            lblRoomName.AutoSize = true;
            lblRoomName.Location = new Point(13, 100);
            lblRoomName.Name = "lblRoomName";
            lblRoomName.Size = new Size(66, 15);
            lblRoomName.TabIndex = 15;
            lblRoomName.Text = "Tên phòng:";
            // 
            // txtRoomCode
            // 
            txtRoomCode.BackColor = Color.FromArgb(240, 240, 240);
            txtRoomCode.Location = new Point(13, 65);
            txtRoomCode.Name = "txtRoomCode";
            txtRoomCode.ReadOnly = true;
            txtRoomCode.Size = new Size(330, 23);
            txtRoomCode.TabIndex = 16;
            // 
            // lblRoomCode
            // 
            lblRoomCode.AutoSize = true;
            lblRoomCode.Location = new Point(13, 45);
            lblRoomCode.Name = "lblRoomCode";
            lblRoomCode.Size = new Size(65, 15);
            lblRoomCode.TabIndex = 17;
            lblRoomCode.Text = "Mã phòng:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(13, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(186, 21);
            lblTitle.TabIndex = 18;
            lblTitle.Text = "Thông tin chi tiết phòng";
            // 
            // pnlRight
            // 
            pnlRight.BorderStyle = BorderStyle.FixedSingle;
            pnlRight.Controls.Add(rightLayout);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(384, 8);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(5);
            pnlRight.Size = new Size(608, 549);
            pnlRight.TabIndex = 1;
            // 
            // rightLayout
            // 
            rightLayout.ColumnCount = 1;
            rightLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rightLayout.Controls.Add(pnlAmenityTop, 0, 0);
            rightLayout.Controls.Add(pnlAmenityBottom, 0, 1);
            rightLayout.Dock = DockStyle.Fill;
            rightLayout.Location = new Point(5, 5);
            rightLayout.Name = "rightLayout";
            rightLayout.RowCount = 2;
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            rightLayout.Size = new Size(596, 537);
            rightLayout.TabIndex = 0;
            // 
            // pnlAmenityTop
            // 
            pnlAmenityTop.BorderStyle = BorderStyle.FixedSingle;
            pnlAmenityTop.Controls.Add(btnAddAmenity);
            pnlAmenityTop.Controls.Add(numQuantity);
            pnlAmenityTop.Controls.Add(lblQuantity);
            pnlAmenityTop.Controls.Add(dgvAllAmenities);
            pnlAmenityTop.Controls.Add(txtSearchAmenity);
            pnlAmenityTop.Controls.Add(lblAmenitiesTitle);
            pnlAmenityTop.Dock = DockStyle.Fill;
            pnlAmenityTop.Location = new Point(3, 3);
            pnlAmenityTop.Name = "pnlAmenityTop";
            pnlAmenityTop.Padding = new Padding(5);
            pnlAmenityTop.Size = new Size(590, 262);
            pnlAmenityTop.TabIndex = 0;
            // 
            // btnAddAmenity
            // 
            btnAddAmenity.BackColor = Color.ForestGreen;
            btnAddAmenity.FlatStyle = FlatStyle.Flat;
            btnAddAmenity.ForeColor = Color.White;
            btnAddAmenity.Location = new Point(465, 180);
            btnAddAmenity.Name = "btnAddAmenity";
            btnAddAmenity.Size = new Size(120, 30);
            btnAddAmenity.TabIndex = 0;
            btnAddAmenity.Text = "Thêm tiện ích";
            btnAddAmenity.UseVisualStyleBackColor = false;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(70, 183);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(60, 23);
            numQuantity.TabIndex = 1;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(5, 185);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(57, 15);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Số lượng:";
            // 
            // dgvAllAmenities
            // 
            dgvAllAmenities.AllowUserToAddRows = false;
            dgvAllAmenities.AllowUserToDeleteRows = false;
            dgvAllAmenities.BackgroundColor = Color.White;
            dgvAllAmenities.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.BackColor = Color.CornflowerBlue;
            dataGridViewCellStyle3.ForeColor = Color.White;
            dgvAllAmenities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAllAmenities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllAmenities.Columns.AddRange(new DataGridViewColumn[] { colAllStt, colAllAmenityId, colAllAmenityName });
            dgvAllAmenities.Location = new Point(5, 55);
            dgvAllAmenities.Name = "dgvAllAmenities";
            dgvAllAmenities.Size = new Size(580, 120);
            dgvAllAmenities.TabIndex = 3;
            // 
            // colAllStt
            // 
            colAllStt.HeaderText = "STT";
            colAllStt.Name = "colAllStt";
            colAllStt.Width = 50;
            // 
            // colAllAmenityId
            // 
            colAllAmenityId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAllAmenityId.HeaderText = "MÃ TIỆN ÍCH";
            colAllAmenityId.Name = "colAllAmenityId";
            // 
            // colAllAmenityName
            // 
            colAllAmenityName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAllAmenityName.HeaderText = "TÊN TIỆN ÍCH";
            colAllAmenityName.Name = "colAllAmenityName";
            // 
            // txtSearchAmenity
            // 
            txtSearchAmenity.Location = new Point(5, 25);
            txtSearchAmenity.Name = "txtSearchAmenity";
            txtSearchAmenity.PlaceholderText = "Nhập mã/tên tiện ích cần tìm...";
            txtSearchAmenity.Size = new Size(580, 23);
            txtSearchAmenity.TabIndex = 4;
            // 
            // lblAmenitiesTitle
            // 
            lblAmenitiesTitle.AutoSize = true;
            lblAmenitiesTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblAmenitiesTitle.Location = new Point(5, 5);
            lblAmenitiesTitle.Name = "lblAmenitiesTitle";
            lblAmenitiesTitle.Size = new Size(241, 19);
            lblAmenitiesTitle.TabIndex = 5;
            lblAmenitiesTitle.Text = "Danh sách tiện ích khách sạn hiện có";
            // 
            // pnlAmenityBottom
            // 
            pnlAmenityBottom.BorderStyle = BorderStyle.FixedSingle;
            pnlAmenityBottom.Controls.Add(btnDeleteAmenity);
            pnlAmenityBottom.Controls.Add(btnEditAmenity);
            pnlAmenityBottom.Controls.Add(numRoomAmenityQuantity);
            pnlAmenityBottom.Controls.Add(lblRoomAmenityQuantity);
            pnlAmenityBottom.Controls.Add(dgvRoomAmenities);
            pnlAmenityBottom.Controls.Add(txtSearchRoomAmenity);
            pnlAmenityBottom.Controls.Add(lblRoomAmenities);
            pnlAmenityBottom.Dock = DockStyle.Fill;
            pnlAmenityBottom.Location = new Point(3, 271);
            pnlAmenityBottom.Name = "pnlAmenityBottom";
            pnlAmenityBottom.Padding = new Padding(5);
            pnlAmenityBottom.Size = new Size(590, 263);
            pnlAmenityBottom.TabIndex = 1;
            // 
            // btnDeleteAmenity
            // 
            btnDeleteAmenity.BackColor = Color.MediumSlateBlue;
            btnDeleteAmenity.ForeColor = Color.White;
            btnDeleteAmenity.Location = new Point(480, 170);
            btnDeleteAmenity.Name = "btnDeleteAmenity";
            btnDeleteAmenity.Size = new Size(90, 30);
            btnDeleteAmenity.TabIndex = 0;
            btnDeleteAmenity.Text = "Xóa tiện ích";
            btnDeleteAmenity.UseVisualStyleBackColor = false;
            // 
            // btnEditAmenity
            // 
            btnEditAmenity.BackColor = Color.MediumSlateBlue;
            btnEditAmenity.ForeColor = Color.White;
            btnEditAmenity.Location = new Point(380, 170);
            btnEditAmenity.Name = "btnEditAmenity";
            btnEditAmenity.Size = new Size(90, 30);
            btnEditAmenity.TabIndex = 1;
            btnEditAmenity.Text = "Sửa tiện ích";
            btnEditAmenity.UseVisualStyleBackColor = false;
            // 
            // numRoomAmenityQuantity
            // 
            numRoomAmenityQuantity.Location = new Point(70, 173);
            numRoomAmenityQuantity.Name = "numRoomAmenityQuantity";
            numRoomAmenityQuantity.Size = new Size(60, 23);
            numRoomAmenityQuantity.TabIndex = 2;
            // 
            // lblRoomAmenityQuantity
            // 
            lblRoomAmenityQuantity.AutoSize = true;
            lblRoomAmenityQuantity.Location = new Point(5, 175);
            lblRoomAmenityQuantity.Name = "lblRoomAmenityQuantity";
            lblRoomAmenityQuantity.Size = new Size(57, 15);
            lblRoomAmenityQuantity.TabIndex = 3;
            lblRoomAmenityQuantity.Text = "Số lượng:";
            // 
            // dgvRoomAmenities
            // 
            dgvRoomAmenities.AllowUserToAddRows = false;
            dgvRoomAmenities.AllowUserToDeleteRows = false;
            dgvRoomAmenities.BackgroundColor = Color.White;
            dgvRoomAmenities.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.BackColor = Color.CornflowerBlue;
            dataGridViewCellStyle4.ForeColor = Color.White;
            dgvRoomAmenities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvRoomAmenities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomAmenities.Columns.AddRange(new DataGridViewColumn[] { colRoomStt, colRoomAmenityId, colRoomAmenityName, colRoomAmenityQty });
            dgvRoomAmenities.Location = new Point(5, 55);
            dgvRoomAmenities.Name = "dgvRoomAmenities";
            dgvRoomAmenities.Size = new Size(580, 110);
            dgvRoomAmenities.TabIndex = 4;
            // 
            // colRoomStt
            // 
            colRoomStt.HeaderText = "STT";
            colRoomStt.Name = "colRoomStt";
            colRoomStt.Width = 50;
            // 
            // colRoomAmenityId
            // 
            colRoomAmenityId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colRoomAmenityId.HeaderText = "MÃ TIỆN ÍCH";
            colRoomAmenityId.Name = "colRoomAmenityId";
            // 
            // colRoomAmenityName
            // 
            colRoomAmenityName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colRoomAmenityName.HeaderText = "TÊN TIỆN ÍCH";
            colRoomAmenityName.Name = "colRoomAmenityName";
            // 
            // colRoomAmenityQty
            // 
            colRoomAmenityQty.HeaderText = "SỐ LƯỢNG";
            colRoomAmenityQty.Name = "colRoomAmenityQty";
            colRoomAmenityQty.Width = 80;
            // 
            // txtSearchRoomAmenity
            // 
            txtSearchRoomAmenity.Location = new Point(5, 25);
            txtSearchRoomAmenity.Name = "txtSearchRoomAmenity";
            txtSearchRoomAmenity.PlaceholderText = "Nhập mã/tên tiện ích cần tìm...";
            txtSearchRoomAmenity.Size = new Size(580, 23);
            txtSearchRoomAmenity.TabIndex = 5;
            // 
            // lblRoomAmenities
            // 
            lblRoomAmenities.AutoSize = true;
            lblRoomAmenities.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblRoomAmenities.Location = new Point(5, 5);
            lblRoomAmenities.Name = "lblRoomAmenities";
            lblRoomAmenities.Size = new Size(169, 19);
            lblRoomAmenities.TabIndex = 6;
            lblRoomAmenities.Text = "Danh sách tiện ích phòng";
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.WhiteSmoke;
            pnlButtons.BorderStyle = BorderStyle.FixedSingle;
            pnlButtons.Controls.Add(btnClose);
            pnlButtons.Controls.Add(btnDeleteRoom);
            pnlButtons.Controls.Add(btnSaveRoom);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 600);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(10);
            pnlButtons.Size = new Size(1000, 60);
            pnlButtons.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gray;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 10F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(890, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 40);
            btnClose.TabIndex = 0;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.BackColor = Color.OrangeRed;
            btnDeleteRoom.FlatStyle = FlatStyle.Flat;
            btnDeleteRoom.Font = new Font("Segoe UI Semibold", 10F);
            btnDeleteRoom.ForeColor = Color.White;
            btnDeleteRoom.Location = new Point(770, 10);
            btnDeleteRoom.Name = "btnDeleteRoom";
            btnDeleteRoom.Size = new Size(110, 40);
            btnDeleteRoom.TabIndex = 1;
            btnDeleteRoom.Text = "Xóa phòng";
            btnDeleteRoom.UseVisualStyleBackColor = false;
            // 
            // btnSaveRoom
            // 
            btnSaveRoom.BackColor = Color.Orange;
            btnSaveRoom.FlatStyle = FlatStyle.Flat;
            btnSaveRoom.Font = new Font("Segoe UI Semibold", 10F);
            btnSaveRoom.ForeColor = Color.White;
            btnSaveRoom.Location = new Point(650, 10);
            btnSaveRoom.Name = "btnSaveRoom";
            btnSaveRoom.Size = new Size(110, 40);
            btnSaveRoom.TabIndex = 2;
            btnSaveRoom.Text = "Sửa phòng";
            btnSaveRoom.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbNormal);
            groupBox1.Controls.Add(rbVip);
            groupBox1.Location = new Point(13, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 45);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại phòng:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbFamily);
            groupBox2.Controls.Add(rbSingle);
            groupBox2.Controls.Add(rbDouble);
            groupBox2.Location = new Point(13, 212);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(327, 58);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết loại phòng";
            // 
            // RoomDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 660);
            Controls.Add(mainLayout);
            Controls.Add(pnlButtons);
            Controls.Add(pnTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RoomDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin phòng khách sạn";
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            mainLayout.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlRight.ResumeLayout(false);
            rightLayout.ResumeLayout(false);
            pnlAmenityTop.ResumeLayout(false);
            pnlAmenityTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllAmenities).EndInit();
            pnlAmenityBottom.ResumeLayout(false);
            pnlAmenityBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRoomAmenityQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomAmenities).EndInit();
            pnlButtons.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnCloseTop;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRoomCode;
        private System.Windows.Forms.TextBox txtRoomCode;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.RadioButton rbVip;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.Label lblRoomDetail;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.RadioButton rbDouble;
        private System.Windows.Forms.RadioButton rbFamily;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblCurrentState;
        private System.Windows.Forms.ComboBox cbCurrentState;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.TableLayoutPanel rightLayout;
        private System.Windows.Forms.Panel pnlAmenityTop;
        private System.Windows.Forms.Label lblAmenitiesTitle;
        private System.Windows.Forms.TextBox txtSearchAmenity;
        private System.Windows.Forms.DataGridView dgvAllAmenities;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllAmenityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllAmenityName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAddAmenity;
        private System.Windows.Forms.Panel pnlAmenityBottom;
        private System.Windows.Forms.Label lblRoomAmenities;
        private System.Windows.Forms.TextBox txtSearchRoomAmenity;
        private System.Windows.Forms.DataGridView dgvRoomAmenities;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomAmenityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomAmenityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomAmenityQty;
        private System.Windows.Forms.Label lblRoomAmenityQuantity;
        private System.Windows.Forms.NumericUpDown numRoomAmenityQuantity;
        private System.Windows.Forms.Button btnEditAmenity;
        private System.Windows.Forms.Button btnDeleteAmenity;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnSaveRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnClose;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
