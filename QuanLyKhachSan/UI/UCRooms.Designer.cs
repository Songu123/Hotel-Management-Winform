namespace QuanLyKhachSan.UI
{
    partial class UCRooms
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
            statsPanel = new Panel();
            filterPanel = new Panel();
            filterLabel = new Label();
            searchLbl = new Label();
            searchBox = new TextBox();
            typeLbl = new Label();
            typeFilter = new ComboBox();
            statusLbl = new Label();
            statusFilter = new ComboBox();
            btnSearch = new Button();
            listPanel = new Panel();
            listTitle = new Label();
            actionPanel = new Panel();
            subtitleLabel = new Label();
            titleLabel = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dgvRooms = new DataGridView();
            mainPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            listPanel.SuspendLayout();
            actionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.BackColor = Color.FromArgb(245, 247, 250);
            mainPanel.Controls.Add(statsPanel);
            mainPanel.Controls.Add(filterPanel);
            mainPanel.Controls.Add(listPanel);
            mainPanel.Controls.Add(actionPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(20);
            mainPanel.Size = new Size(1234, 803);
            mainPanel.TabIndex = 0;
            // 
            // statsPanel
            // 
            statsPanel.AutoSize = true;
            statsPanel.BackColor = Color.Transparent;
            statsPanel.Dock = DockStyle.Top;
            statsPanel.Location = new Point(20, 627);
            statsPanel.Name = "statsPanel";
            statsPanel.Padding = new Padding(0, 0, 0, 20);
            statsPanel.Size = new Size(1194, 20);
            statsPanel.TabIndex = 2;
            // 
            // filterPanel
            // 
            filterPanel.AutoSize = true;
            filterPanel.BackColor = Color.White;
            filterPanel.BorderStyle = BorderStyle.FixedSingle;
            filterPanel.Controls.Add(filterLabel);
            filterPanel.Controls.Add(searchLbl);
            filterPanel.Controls.Add(searchBox);
            filterPanel.Controls.Add(typeLbl);
            filterPanel.Controls.Add(typeFilter);
            filterPanel.Controls.Add(statusLbl);
            filterPanel.Controls.Add(statusFilter);
            filterPanel.Controls.Add(btnSearch);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(20, 537);
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new Padding(20);
            filterPanel.Size = new Size(1194, 90);
            filterPanel.TabIndex = 3;
            // 
            // filterLabel
            // 
            filterLabel.AutoSize = true;
            filterLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            filterLabel.ForeColor = Color.FromArgb(30, 40, 60);
            filterLabel.Location = new Point(20, 10);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(125, 20);
            filterLabel.TabIndex = 0;
            filterLabel.Text = "🔍 Search & Filter";
            // 
            // searchLbl
            // 
            searchLbl.AutoSize = true;
            searchLbl.Location = new Point(20, 40);
            searchLbl.Name = "searchLbl";
            searchLbl.Size = new Size(89, 15);
            searchLbl.TabIndex = 1;
            searchLbl.Text = "Room Number:";
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Segoe UI", 10F);
            searchBox.Location = new Point(130, 40);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(180, 25);
            searchBox.TabIndex = 2;
            // 
            // typeLbl
            // 
            typeLbl.AutoSize = true;
            typeLbl.Location = new Point(330, 40);
            typeLbl.Name = "typeLbl";
            typeLbl.Size = new Size(69, 15);
            typeLbl.TabIndex = 3;
            typeLbl.Text = "Room Type:";
            // 
            // typeFilter
            // 
            typeFilter.Items.AddRange(new object[] { "All", "Single", "Double", "Suite", "Deluxe" });
            typeFilter.Location = new Point(420, 40);
            typeFilter.Name = "typeFilter";
            typeFilter.Size = new Size(150, 23);
            typeFilter.TabIndex = 4;
            // 
            // statusLbl
            // 
            statusLbl.AutoSize = true;
            statusLbl.Location = new Point(590, 40);
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(42, 15);
            statusLbl.TabIndex = 5;
            statusLbl.Text = "Status:";
            // 
            // statusFilter
            // 
            statusFilter.Items.AddRange(new object[] { "All", "Available", "Occupied", "Maintenance", "Reserved" });
            statusFilter.Location = new Point(660, 40);
            statusFilter.Name = "statusFilter";
            statusFilter.Size = new Size(150, 23);
            statusFilter.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(70, 130, 180);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(820, 40);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 25);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // listPanel
            // 
            listPanel.AutoSize = true;
            listPanel.BackColor = Color.White;
            listPanel.BorderStyle = BorderStyle.FixedSingle;
            listPanel.Controls.Add(listTitle);
            listPanel.Controls.Add(dgvRooms);
            listPanel.Dock = DockStyle.Top;
            listPanel.Location = new Point(20, 147);
            listPanel.Name = "listPanel";
            listPanel.Padding = new Padding(20);
            listPanel.Size = new Size(1194, 390);
            listPanel.TabIndex = 4;
            // 
            // listTitle
            // 
            listTitle.AutoSize = true;
            listTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            listTitle.ForeColor = Color.FromArgb(30, 40, 60);
            listTitle.Location = new Point(20, 10);
            listTitle.Name = "listTitle";
            listTitle.Size = new Size(127, 25);
            listTitle.TabIndex = 0;
            listTitle.Text = "📋 Room List";
            // 
            // actionPanel
            // 
            actionPanel.BackColor = Color.White;
            actionPanel.BorderStyle = BorderStyle.FixedSingle;
            actionPanel.Controls.Add(subtitleLabel);
            actionPanel.Controls.Add(titleLabel);
            actionPanel.Controls.Add(btnAdd);
            actionPanel.Controls.Add(btnEdit);
            actionPanel.Controls.Add(btnDelete);
            actionPanel.Controls.Add(btnRefresh);
            actionPanel.Dock = DockStyle.Top;
            actionPanel.Location = new Point(20, 20);
            actionPanel.Name = "actionPanel";
            actionPanel.Padding = new Padding(20);
            actionPanel.Size = new Size(1194, 127);
            actionPanel.TabIndex = 5;
            // 
            // subtitleLabel
            // 
            subtitleLabel.Font = new Font("Segoe UI", 11F);
            subtitleLabel.ForeColor = Color.Gray;
            subtitleLabel.Location = new Point(384, 19);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(600, 25);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "Manage and monitor all hotel rooms";
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(30, 40, 60);
            titleLabel.Location = new Point(-1, -1);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(600, 40);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "🏨 Room Management";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(40, 200, 150);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(20, 67);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 35);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "➕ Add Room";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(70, 130, 180);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(150, 67);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 35);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "✏️ Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 100, 100);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(260, 67);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "🗑️ Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(100, 150, 200);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(370, 67);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 35);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Actions";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 83;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Check-Out";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 103;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Check-In";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 91;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Current Guest";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Price/Night";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 111;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Status";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 74;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Floor";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 69;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Type";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 66;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Room No.";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 102;
            // 
            // dgvRooms
            // 
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRooms.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(70, 130, 180);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRooms.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dgvRooms.Location = new Point(20, 45);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.Size = new Size(1160, 320);
            dgvRooms.TabIndex = 1;
            // 
            // UCRooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainPanel);
            Name = "UCRooms";
            Size = new Size(1234, 803);
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            listPanel.ResumeLayout(false);
            listPanel.PerformLayout();
            actionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;

        private Panel CreateStatCard(string title, string value, string icon, Color accentColor, int xPosition)
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
        private Panel mainPanel;
        private Panel statsPanel;
        private Panel filterPanel;
        private Label filterLabel;
        private Label searchLbl;
        private TextBox searchBox;
        private Label typeLbl;
        private ComboBox typeFilter;
        private Label statusLbl;
        private ComboBox statusFilter;
        private Button btnSearch;
        private Panel listPanel;
        private Label listTitle;
        private Panel actionPanel;
        private Label subtitleLabel;
        private Label titleLabel;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private DataGridView dgvRooms;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}
