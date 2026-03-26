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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnTop = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCloseTop = new System.Windows.Forms.Button();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRoomCode = new System.Windows.Forms.Label();
            this.txtRoomCode = new System.Windows.Forms.TextBox();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.rbVip = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.lblRoomDetail = new System.Windows.Forms.Label();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.rbDouble = new System.Windows.Forms.RadioButton();
            this.rbFamily = new System.Windows.Forms.RadioButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblCurrentState = new System.Windows.Forms.Label();
            this.cbCurrentState = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.rightLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAmenityTop = new System.Windows.Forms.Panel();
            this.lblAmenitiesTitle = new System.Windows.Forms.Label();
            this.txtSearchAmenity = new System.Windows.Forms.TextBox();
            this.dgvAllAmenities = new System.Windows.Forms.DataGridView();
            this.colAllStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllAmenityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllAmenityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddAmenity = new System.Windows.Forms.Button();
            this.pnlAmenityBottom = new System.Windows.Forms.Panel();
            this.lblRoomAmenities = new System.Windows.Forms.Label();
            this.txtSearchRoomAmenity = new System.Windows.Forms.TextBox();
            this.dgvRoomAmenities = new System.Windows.Forms.DataGridView();
            this.colRoomStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomAmenityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomAmenityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomAmenityQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRoomAmenityQuantity = new System.Windows.Forms.Label();
            this.numRoomAmenityQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnEditAmenity = new System.Windows.Forms.Button();
            this.btnDeleteAmenity = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnSaveRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.pnTop.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.rightLayout.SuspendLayout();
            this.pnlAmenityTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAmenities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.pnlAmenityBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomAmenities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomAmenityQuantity)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();

            // pnTop
            this.pnTop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnTop.Controls.Add(this.lblHeader);
            this.pnTop.Controls.Add(this.btnCloseTop);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1000, 35);

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(10, 8);
            this.lblHeader.Text = "Thông tin phòng khách sạn";

            // btnCloseTop
            this.btnCloseTop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCloseTop.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCloseTop.ForeColor = System.Drawing.Color.White;
            this.btnCloseTop.Size = new System.Drawing.Size(30, 35);
            this.btnCloseTop.Text = "✕";
            this.btnCloseTop.UseVisualStyleBackColor = false;
            this.btnCloseTop.Click += new System.EventHandler(this.btnClose_Click);

            // mainLayout
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.mainLayout.Controls.Add(this.pnlLeft, 0, 0);
            this.mainLayout.Controls.Add(this.pnlRight, 1, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 35);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Padding = new System.Windows.Forms.Padding(5);
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(1000, 565);

            // pnlLeft
            this.pnlLeft.AutoScroll = true;
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.btnNew);
            this.pnlLeft.Controls.Add(this.cbCurrentState);
            this.pnlLeft.Controls.Add(this.lblCurrentState);
            this.pnlLeft.Controls.Add(this.txtStatus);
            this.pnlLeft.Controls.Add(this.lblStatus);
            this.pnlLeft.Controls.Add(this.txtPrice);
            this.pnlLeft.Controls.Add(this.lblPrice);
            this.pnlLeft.Controls.Add(this.rbFamily);
            this.pnlLeft.Controls.Add(this.rbDouble);
            this.pnlLeft.Controls.Add(this.rbSingle);
            this.pnlLeft.Controls.Add(this.lblRoomDetail);
            this.pnlLeft.Controls.Add(this.rbNormal);
            this.pnlLeft.Controls.Add(this.rbVip);
            this.pnlLeft.Controls.Add(this.lblRoomType);
            this.pnlLeft.Controls.Add(this.txtRoomName);
            this.pnlLeft.Controls.Add(this.lblRoomName);
            this.pnlLeft.Controls.Add(this.txtRoomCode);
            this.pnlLeft.Controls.Add(this.lblRoomCode);
            this.pnlLeft.Controls.Add(this.lblTitle);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(8, 8);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(3);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(10);
            this.pnlLeft.Size = new System.Drawing.Size(364, 549);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Text = "Thông tin chi tiết phòng";

            // lblRoomCode
            this.lblRoomCode.AutoSize = true;
            this.lblRoomCode.Location = new System.Drawing.Point(13, 45);
            this.lblRoomCode.Text = "Mã phòng:";

            // txtRoomCode
            this.txtRoomCode.Location = new System.Drawing.Point(13, 65);
            this.txtRoomCode.ReadOnly = true;
            this.txtRoomCode.Size = new System.Drawing.Size(330, 23);
            this.txtRoomCode.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // lblRoomName
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(13, 100);
            this.lblRoomName.Text = "Tên phòng:";

            // txtRoomName
            this.txtRoomName.Location = new System.Drawing.Point(13, 120);
            this.txtRoomName.Size = new System.Drawing.Size(330, 23);

            // lblRoomType
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(13, 155);
            this.lblRoomType.Text = "Loại phòng:";

            // rbVip
            this.rbVip.AutoSize = true;
            this.rbVip.Location = new System.Drawing.Point(13, 175);
            this.rbVip.Text = "Phòng Vip";

            // rbNormal
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(150, 175);
            this.rbNormal.Text = "Phòng thường";
            this.rbNormal.Checked = true;

            // lblRoomDetail
            this.lblRoomDetail.AutoSize = true;
            this.lblRoomDetail.Location = new System.Drawing.Point(13, 205);
            this.lblRoomDetail.Text = "Chi tiết loại phòng";

            // rbSingle
            this.rbSingle.AutoSize = true;
            this.rbSingle.Location = new System.Drawing.Point(13, 225);
            this.rbSingle.Text = "Phòng đơn";
            this.rbSingle.Checked = true;

            // rbDouble
            this.rbDouble.AutoSize = true;
            this.rbDouble.Location = new System.Drawing.Point(120, 225);
            this.rbDouble.Text = "Phòng đôi";

            // rbFamily
            this.rbFamily.AutoSize = true;
            this.rbFamily.Location = new System.Drawing.Point(230, 225);
            this.rbFamily.Text = "Phòng gia";

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(13, 260);
            this.lblPrice.Text = "Giá phòng:";

            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point(13, 280);
            this.txtPrice.Size = new System.Drawing.Size(330, 23);

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 315);
            this.lblStatus.Text = "Tình trạng:";

            // txtStatus
            this.txtStatus.Location = new System.Drawing.Point(13, 335);
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(330, 23);
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // lblCurrentState
            this.lblCurrentState.AutoSize = true;
            this.lblCurrentState.Location = new System.Drawing.Point(13, 370);
            this.lblCurrentState.Text = "Hiện trạng:";

            // cbCurrentState
            this.cbCurrentState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrentState.Location = new System.Drawing.Point(13, 390);
            this.cbCurrentState.Size = new System.Drawing.Size(330, 23);
            this.cbCurrentState.Items.AddRange(new object[] { "Mới", "Đang sử dụng", "Đang dọn", "Bảo trì" });

            // btnNew
            this.btnNew.BackColor = System.Drawing.Color.MediumPurple;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(243, 425);
            this.btnNew.Size = new System.Drawing.Size(100, 35);
            this.btnNew.Text = "Làm mới";

            // pnlRight
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Controls.Add(this.rightLayout);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(379, 8);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(3);
            this.pnlRight.Padding = new System.Windows.Forms.Padding(5);
            this.pnlRight.Size = new System.Drawing.Size(614, 549);

            // rightLayout
            this.rightLayout.ColumnCount = 1;
            this.rightLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightLayout.Controls.Add(this.pnlAmenityTop, 0, 0);
            this.rightLayout.Controls.Add(this.pnlAmenityBottom, 0, 1);
            this.rightLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightLayout.RowCount = 2;
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));

            // pnlAmenityTop
            this.pnlAmenityTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAmenityTop.Controls.Add(this.btnAddAmenity);
            this.pnlAmenityTop.Controls.Add(this.numQuantity);
            this.pnlAmenityTop.Controls.Add(this.lblQuantity);
            this.pnlAmenityTop.Controls.Add(this.dgvAllAmenities);
            this.pnlAmenityTop.Controls.Add(this.txtSearchAmenity);
            this.pnlAmenityTop.Controls.Add(this.lblAmenitiesTitle);
            this.pnlAmenityTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAmenityTop.Padding = new System.Windows.Forms.Padding(5);

            // lblAmenitiesTitle
            this.lblAmenitiesTitle.AutoSize = true;
            this.lblAmenitiesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblAmenitiesTitle.Location = new System.Drawing.Point(5, 5);
            this.lblAmenitiesTitle.Text = "Danh sách tiện ích khách sạn hiện có";

            // txtSearchAmenity
            this.txtSearchAmenity.Location = new System.Drawing.Point(5, 25);
            this.txtSearchAmenity.Size = new System.Drawing.Size(580, 23);
            this.txtSearchAmenity.PlaceholderText = "Nhập mã/tên tiện ích cần tìm...";

            // dgvAllAmenities
            this.dgvAllAmenities.AllowUserToAddRows = false;
            this.dgvAllAmenities.AllowUserToDeleteRows = false;
            this.dgvAllAmenities.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllAmenities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllAmenities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAmenities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colAllStt, this.colAllAmenityId, this.colAllAmenityName });
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvAllAmenities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllAmenities.Location = new System.Drawing.Point(5, 55);
            this.dgvAllAmenities.Size = new System.Drawing.Size(580, 120);

            this.colAllStt.HeaderText = "STT";
            this.colAllStt.Width = 50;
            this.colAllAmenityId.HeaderText = "MÃ TIỆN ÍCH";
            this.colAllAmenityId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAllAmenityName.HeaderText = "TÊN TIỆN ÍCH";
            this.colAllAmenityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            // lblQuantity
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(5, 185);
            this.lblQuantity.Text = "Số lượng:";

            // numQuantity
            this.numQuantity.Location = new System.Drawing.Point(70, 183);
            this.numQuantity.Size = new System.Drawing.Size(60, 23);

            // btnAddAmenity
            this.btnAddAmenity.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddAmenity.ForeColor = System.Drawing.Color.White;
            this.btnAddAmenity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAmenity.Location = new System.Drawing.Point(465, 180);
            this.btnAddAmenity.Size = new System.Drawing.Size(120, 30);
            this.btnAddAmenity.Text = "Thêm tiện ích";

            // pnlAmenityBottom
            this.pnlAmenityBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAmenityBottom.Controls.Add(this.btnDeleteAmenity);
            this.pnlAmenityBottom.Controls.Add(this.btnEditAmenity);
            this.pnlAmenityBottom.Controls.Add(this.numRoomAmenityQuantity);
            this.pnlAmenityBottom.Controls.Add(this.lblRoomAmenityQuantity);
            this.pnlAmenityBottom.Controls.Add(this.dgvRoomAmenities);
            this.pnlAmenityBottom.Controls.Add(this.txtSearchRoomAmenity);
            this.pnlAmenityBottom.Controls.Add(this.lblRoomAmenities);
            this.pnlAmenityBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAmenityBottom.Padding = new System.Windows.Forms.Padding(5);

            // lblRoomAmenities
            this.lblRoomAmenities.AutoSize = true;
            this.lblRoomAmenities.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRoomAmenities.Location = new System.Drawing.Point(5, 5);
            this.lblRoomAmenities.Text = "Danh sách tiện ích phòng";

            // txtSearchRoomAmenity
            this.txtSearchRoomAmenity.Location = new System.Drawing.Point(5, 25);
            this.txtSearchRoomAmenity.Size = new System.Drawing.Size(580, 23);
            this.txtSearchRoomAmenity.PlaceholderText = "Nhập mã/tên tiện ích cần tìm...";

            // dgvRoomAmenities
            this.dgvRoomAmenities.AllowUserToAddRows = false;
            this.dgvRoomAmenities.AllowUserToDeleteRows = false;
            this.dgvRoomAmenities.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomAmenities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoomAmenities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomAmenities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colRoomStt, this.colRoomAmenityId, this.colRoomAmenityName, this.colRoomAmenityQty });
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvRoomAmenities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoomAmenities.Location = new System.Drawing.Point(5, 55);
            this.dgvRoomAmenities.Size = new System.Drawing.Size(580, 110);

            this.colRoomStt.HeaderText = "STT";
            this.colRoomStt.Width = 50;
            this.colRoomAmenityId.HeaderText = "MÃ TIỆN ÍCH";
            this.colRoomAmenityId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRoomAmenityName.HeaderText = "TÊN TIỆN ÍCH";
            this.colRoomAmenityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRoomAmenityQty.HeaderText = "SỐ LƯỢNG";
            this.colRoomAmenityQty.Width = 80;

            // lblRoomAmenityQuantity
            this.lblRoomAmenityQuantity.AutoSize = true;
            this.lblRoomAmenityQuantity.Location = new System.Drawing.Point(5, 175);
            this.lblRoomAmenityQuantity.Text = "Số lượng:";

            // numRoomAmenityQuantity
            this.numRoomAmenityQuantity.Location = new System.Drawing.Point(70, 173);
            this.numRoomAmenityQuantity.Size = new System.Drawing.Size(60, 23);

            // btnEditAmenity
            this.btnEditAmenity.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEditAmenity.ForeColor = System.Drawing.Color.White;
            this.btnEditAmenity.Location = new System.Drawing.Point(380, 170);
            this.btnEditAmenity.Size = new System.Drawing.Size(90, 30);
            this.btnEditAmenity.Text = "Sửa tiện ích";

            // btnDeleteAmenity
            this.btnDeleteAmenity.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDeleteAmenity.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAmenity.Location = new System.Drawing.Point(480, 170);
            this.btnDeleteAmenity.Size = new System.Drawing.Size(90, 30);
            this.btnDeleteAmenity.Text = "Xóa tiện ích";

            // pnlButtons
            this.pnlButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Controls.Add(this.btnDeleteRoom);
            this.pnlButtons.Controls.Add(this.btnSaveRoom);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 600);
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(10);
            this.pnlButtons.Size = new System.Drawing.Size(1000, 60);

            // btnSaveRoom
            this.btnSaveRoom.BackColor = System.Drawing.Color.Orange;
            this.btnSaveRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnSaveRoom.ForeColor = System.Drawing.Color.White;
            this.btnSaveRoom.Location = new System.Drawing.Point(650, 10);
            this.btnSaveRoom.Size = new System.Drawing.Size(110, 40);
            this.btnSaveRoom.Text = "Sửa phòng";

            // btnDeleteRoom
            this.btnDeleteRoom.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoom.Location = new System.Drawing.Point(770, 10);
            this.btnDeleteRoom.Size = new System.Drawing.Size(110, 40);
            this.btnDeleteRoom.Text = "Xóa phòng";

            // btnClose
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(890, 10);
            this.btnClose.Size = new System.Drawing.Size(90, 40);
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // Form settings
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin phòng khách sạn";

            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.rightLayout.ResumeLayout(false);
            this.pnlAmenityTop.ResumeLayout(false);
            this.pnlAmenityTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAmenities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.pnlAmenityBottom.ResumeLayout(false);
            this.pnlAmenityBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomAmenities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomAmenityQuantity)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
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
    }
}
