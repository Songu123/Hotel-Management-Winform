namespace QuanLyKhachSan.UI
{
    partial class UCCustomers
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
            components = new System.ComponentModel.Container();

            // Main Panel
            Panel mainPanel = new Panel();
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.BackColor = Color.FromArgb(245, 247, 250);
            mainPanel.AutoScroll = true;
            mainPanel.Padding = new Padding(20);

            // Title
            Label titleLabel = new Label();
            titleLabel.Text = "👥 Customer Management";
            titleLabel.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(30, 40, 60);
            titleLabel.Location = new Point(20, 10);
            titleLabel.Size = new Size(600, 40);
            mainPanel.Controls.Add(titleLabel);

            // Subtitle
            Label subtitleLabel = new Label();
            subtitleLabel.Text = "Manage guest profiles and track customer information";
            subtitleLabel.Font = new Font("Segoe UI", 11);
            subtitleLabel.ForeColor = Color.Gray;
            subtitleLabel.Location = new Point(20, 55);
            subtitleLabel.Size = new Size(600, 25);
            mainPanel.Controls.Add(subtitleLabel);

            // Stats Row
            Panel statsPanel = new Panel();
            statsPanel.Height = 140;
            statsPanel.Dock = DockStyle.Top;
            statsPanel.Padding = new Padding(0, 0, 0, 20);
            statsPanel.BackColor = Color.Transparent;
            statsPanel.AutoSize = true;

            statsPanel.Controls.Add(CreateStatCard("Total Customers", "342", "👥", Color.FromArgb(70, 130, 180), 0));
            statsPanel.Controls.Add(CreateStatCard("New This Month", "28", "📈", Color.FromArgb(40, 200, 150), 320));
            statsPanel.Controls.Add(CreateStatCard("VIP Members", "12", "⭐", Color.FromArgb(200, 150, 80), 640));

            mainPanel.Controls.Add(statsPanel);

            // Customer List Panel
            Panel listPanel = new Panel();
            listPanel.Height = 350;
            listPanel.Dock = DockStyle.Top;
            listPanel.BackColor = Color.White;
            listPanel.BorderStyle = BorderStyle.FixedSingle;
            listPanel.Padding = new Padding(20);
            listPanel.AutoSize = true;

            Label listTitle = new Label();
            listTitle.Text = "📋 Recent Customers";
            listTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            listTitle.ForeColor = Color.FromArgb(30, 40, 60);
            listTitle.Location = new Point(20, 20);
            listTitle.AutoSize = true;
            listPanel.Controls.Add(listTitle);

            // Customer Items
            string[] customers = {
      "Nguyễn Văn A - Room 101 - Corporate",
            "Trần Thị B - Room 205 - Individual",
       "Hoàng Văn C - Room 302 - VIP",
       "Lê Thị D - Room 108 - Corporate",
      "Phạm Văn E - Room 401 - Individual"
   };

            int customerY = 60;
            foreach (var customer in customers)
            {
                Label customerLabel = new Label();
                customerLabel.Text = customer;
                customerLabel.Font = new Font("Segoe UI", 10);
                customerLabel.ForeColor = Color.FromArgb(50, 50, 50);
                customerLabel.Location = new Point(20, customerY);
                customerLabel.AutoSize = true;
                listPanel.Controls.Add(customerLabel);
                customerY += 30;
            }

            mainPanel.Controls.Add(listPanel);

            this.Controls.Add(mainPanel);
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Name = "UCCustomers";
            this.Size = new Size(1234, 803);
        }

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
    }
}
