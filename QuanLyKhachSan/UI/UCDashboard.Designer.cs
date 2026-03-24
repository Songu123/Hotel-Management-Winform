namespace QuanLyKhachSan.UI
{
    partial class UCDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            mainPanel = new Panel();
            subtitleLabel = new Label();
            dgvRoomStatus = new DataGridView();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            gridTitle = new Label();
            titleLabel = new Label();
            row3 = new Panel();
            row2 = new Panel();
            row1 = new Panel();
            infoPanel = new Panel();
            info4 = new Label();
            info3 = new Label();
            info2 = new Label();
            info1 = new Label();
            infoTitle = new Label();
            row4 = new Panel();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomStatus).BeginInit();
            row3.SuspendLayout();
            infoPanel.SuspendLayout();
            row4.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.BackColor = Color.FromArgb(245, 247, 250);
            mainPanel.Controls.Add(titleLabel);
            mainPanel.Controls.Add(subtitleLabel);
            mainPanel.Controls.Add(row1);
            mainPanel.Controls.Add(row2);
            mainPanel.Controls.Add(row3);
            mainPanel.Controls.Add(row4);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(20);
            mainPanel.Size = new Size(1234, 803);
            mainPanel.TabIndex = 0;
            // 
            // subtitleLabel
            // 
            subtitleLabel.Font = new Font("Segoe UI", 11F);
            subtitleLabel.ForeColor = Color.Gray;
            subtitleLabel.Location = new Point(20, 55);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(400, 25);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "Today's Overview & Key Metrics";
            // 
            // dgvRoomStatus
            // 
            dgvRoomStatus.AllowUserToAddRows = false;
            dgvRoomStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRoomStatus.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(70, 130, 180);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRoomStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRoomStatus.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dgvRoomStatus.Location = new Point(20, 50);
            dgvRoomStatus.Name = "dgvRoomStatus";
            dgvRoomStatus.ReadOnly = true;
            dgvRoomStatus.Size = new Size(1160, 280);
            dgvRoomStatus.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Price/Night";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 111;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Check-Out";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 103;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Check-In";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 91;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Guest Name";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 115;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Status";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 74;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Floor";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 69;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Room Type";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Room No.";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 102;
            // 
            // gridTitle
            // 
            gridTitle.AutoSize = true;
            gridTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            gridTitle.ForeColor = Color.FromArgb(30, 40, 60);
            gridTitle.Location = new Point(20, 15);
            gridTitle.Name = "gridTitle";
            gridTitle.Size = new Size(216, 25);
            gridTitle.TabIndex = 0;
            gridTitle.Text = "📋 Room Status Details";
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(30, 40, 60);
            titleLabel.Location = new Point(20, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(400, 40);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "📊 Dashboard";
            // 
            // row3
            // 
            row3.AutoSize = true;
            row3.BackColor = Color.White;
            row3.BorderStyle = BorderStyle.FixedSingle;
            row3.Controls.Add(gridTitle);
            row3.Controls.Add(dgvRoomStatus);
            row3.Dock = DockStyle.Top;
            row3.Location = new Point(20, 40);
            row3.Name = "row3";
            row3.Padding = new Padding(20);
            row3.Size = new Size(1194, 355);
            row3.TabIndex = 4;
            // 
            // row2
            // 
            row2.AutoSize = true;
            row2.BackColor = Color.Transparent;
            row2.Dock = DockStyle.Top;
            row2.Location = new Point(20, 395);
            row2.Name = "row2";
            row2.Padding = new Padding(0, 0, 0, 20);
            row2.Size = new Size(1194, 20);
            row2.TabIndex = 3;
            // 
            // row1
            // 
            row1.AutoSize = true;
            row1.BackColor = Color.Transparent;
            row1.Dock = DockStyle.Top;
            row1.Location = new Point(20, 415);
            row1.Name = "row1";
            row1.Padding = new Padding(0, 0, 0, 20);
            row1.Size = new Size(1194, 20);
            row1.TabIndex = 2;
            // 
            // infoPanel
            // 
            infoPanel.BackColor = Color.White;
            infoPanel.BorderStyle = BorderStyle.FixedSingle;
            infoPanel.Controls.Add(infoTitle);
            infoPanel.Controls.Add(info1);
            infoPanel.Controls.Add(info2);
            infoPanel.Controls.Add(info3);
            infoPanel.Controls.Add(info4);
            infoPanel.Dock = DockStyle.Fill;
            infoPanel.Location = new Point(0, 0);
            infoPanel.Name = "infoPanel";
            infoPanel.Padding = new Padding(20);
            infoPanel.Size = new Size(1194, 0);
            infoPanel.TabIndex = 0;
            // 
            // info4
            // 
            info4.AutoSize = true;
            info4.Font = new Font("Segoe UI", 10F);
            info4.ForeColor = Color.Gray;
            info4.Location = new Point(20, 135);
            info4.Name = "info4";
            info4.Size = new Size(306, 19);
            info4.TabIndex = 4;
            info4.Text = "✓ Revenue Target: 85% achieved (Target: 50,000)";
            // 
            // info3
            // 
            info3.AutoSize = true;
            info3.Font = new Font("Segoe UI", 10F);
            info3.ForeColor = Color.Gray;
            info3.Location = new Point(20, 110);
            info3.Name = "info3";
            info3.Size = new Size(248, 19);
            info3.TabIndex = 3;
            info3.Text = "✓ Maintenance: 2 rooms (ETA: 2 hours)";
            // 
            // info2
            // 
            info2.AutoSize = true;
            info2.Font = new Font("Segoe UI", 10F);
            info2.ForeColor = Color.Gray;
            info2.Location = new Point(20, 85);
            info2.Name = "info2";
            info2.Size = new Size(306, 19);
            info2.TabIndex = 2;
            info2.Text = "✓ Available Rooms: 6 Standard, 3 Deluxe, 1 Suite";
            // 
            // info1
            // 
            info1.AutoSize = true;
            info1.Font = new Font("Segoe UI", 10F);
            info1.ForeColor = Color.Gray;
            info1.Location = new Point(20, 60);
            info1.Name = "info1";
            info1.Size = new Size(303, 19);
            info1.TabIndex = 1;
            info1.Text = "✓ Total Guests: 25 (15 individuals, 10 corporate)";
            // 
            // infoTitle
            // 
            infoTitle.AutoSize = true;
            infoTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            infoTitle.ForeColor = Color.FromArgb(30, 40, 60);
            infoTitle.Location = new Point(20, 20);
            infoTitle.Name = "infoTitle";
            infoTitle.Size = new Size(196, 25);
            infoTitle.TabIndex = 0;
            infoTitle.Text = "📈 Today's Summary";
            // 
            // row4
            // 
            row4.AutoSize = true;
            row4.BackColor = Color.Transparent;
            row4.Controls.Add(infoPanel);
            row4.Dock = DockStyle.Top;
            row4.Location = new Point(20, 20);
            row4.Name = "row4";
            row4.Padding = new Padding(0, 0, 0, 20);
            row4.Size = new Size(1194, 20);
            row4.TabIndex = 5;
            // 
            // UCDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainPanel);
            Name = "UCDashboard";
            Size = new Size(1234, 803);
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomStatus).EndInit();
            row3.ResumeLayout(false);
            row3.PerformLayout();
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            row4.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel CreateMetricCard(string title, string value, string icon, Color accentColor, int xPosition)
        {
       Panel card = new Panel();
   card.Width = 280;
  card.Height = 140;
        card.Location = new Point(xPosition, 0);
 card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;
    card.Padding = new Padding(20);

   Panel accentBar = new Panel();
  accentBar.Height = 4;
         accentBar.Dock = DockStyle.Top;
     accentBar.BackColor = accentColor;
card.Controls.Add(accentBar);

          Label titleLabel = new Label();
  titleLabel.Text = title;
     titleLabel.Font = new Font("Segoe UI", 9);
    titleLabel.ForeColor = Color.Gray;
      titleLabel.Location = new Point(20, 12);
            titleLabel.AutoSize = true;
            card.Controls.Add(titleLabel);

         Label iconLabel = new Label();
    iconLabel.Text = icon;
   iconLabel.Font = new Font("Segoe UI", 16);
        iconLabel.Location = new Point(230, 10);
  iconLabel.AutoSize = true;
       card.Controls.Add(iconLabel);

 Label valueLabel = new Label();
            valueLabel.Text = value;
 valueLabel.Font = new Font("Segoe UI", 28, FontStyle.Bold);
     valueLabel.ForeColor = accentColor;
     valueLabel.Location = new Point(20, 40);
    valueLabel.AutoSize = true;
       card.Controls.Add(valueLabel);

        return card;
 }

  private Panel CreateRoomStatusCard(string title, string count, Color accentColor, int xPosition)
        {
 Panel card = new Panel();
  card.Width = 260;
            card.Height = 140;
          card.Location = new Point(xPosition, 0);
         card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;
 card.Padding = new Padding(20);

        Panel accentBar = new Panel();
     accentBar.Height = 4;
     accentBar.Dock = DockStyle.Top;
     accentBar.BackColor = accentColor;
card.Controls.Add(accentBar);

Label titleLabel = new Label();
            titleLabel.Text = title;
            titleLabel.Font = new Font("Segoe UI", 11, FontStyle.Bold);
   titleLabel.ForeColor = Color.FromArgb(30, 40, 60);
  titleLabel.Location = new Point(20, 15);
    titleLabel.AutoSize = true;
            card.Controls.Add(titleLabel);

    Label countLabel = new Label();
  countLabel.Text = count;
   countLabel.Font = new Font("Segoe UI", 36, FontStyle.Bold);
   countLabel.ForeColor = accentColor;
      countLabel.Location = new Point(20, 50);
    countLabel.AutoSize = true;
card.Controls.Add(countLabel);

          Label unitLabel = new Label();
            unitLabel.Text = "rooms";
  unitLabel.Font = new Font("Segoe UI", 9);
          unitLabel.ForeColor = Color.Gray;
   unitLabel.Location = new Point(20, 110);
   unitLabel.AutoSize = true;
  card.Controls.Add(unitLabel);

   return card;
        }
        private Panel mainPanel;
        private Label titleLabel;
        private Label subtitleLabel;
        private Panel row1;
        private Panel row2;
        private Panel row3;
        private Label gridTitle;
        private DataGridView dgvRoomStatus;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Panel row4;
        private Panel infoPanel;
        private Label infoTitle;
        private Label info1;
        private Label info2;
        private Label info3;
        private Label info4;
    }
}
