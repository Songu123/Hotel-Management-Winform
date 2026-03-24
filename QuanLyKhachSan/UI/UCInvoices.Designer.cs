namespace QuanLyKhachSan.UI
{
    partial class UCInvoices
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
            titleLabel.Text = "💰 Invoices & Billing";
            titleLabel.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(30, 40, 60);
            titleLabel.Location = new Point(20, 10);
            titleLabel.Size = new Size(600, 40);
            mainPanel.Controls.Add(titleLabel);

            // Subtitle
            Label subtitleLabel = new Label();
            subtitleLabel.Text = "View and manage guest invoices and payments";
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

            statsPanel.Controls.Add(CreateStatCard("Pending Payment", "15,500", "⏳", Color.FromArgb(200, 120, 80), 0));
            statsPanel.Controls.Add(CreateStatCard("Paid Today", "42,250", "✓", Color.FromArgb(40, 200, 150), 320));
            statsPanel.Controls.Add(CreateStatCard("Total This Month", "257,890", "💰", Color.FromArgb(70, 130, 180), 640));

            mainPanel.Controls.Add(statsPanel);

            // Invoice Table Panel
            Panel tablePanel = new Panel();
            tablePanel.Height = 350;
            tablePanel.Dock = DockStyle.Top;
            tablePanel.BackColor = Color.White;
            tablePanel.BorderStyle = BorderStyle.FixedSingle;
            tablePanel.Padding = new Padding(20);
            tablePanel.AutoSize = true;

            Label tableTitle = new Label();
            tableTitle.Text = "📊 Recent Invoices";
            tableTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tableTitle.ForeColor = Color.FromArgb(30, 40, 60);
            tableTitle.Location = new Point(20, 20);
            tableTitle.AutoSize = true;
            tablePanel.Controls.Add(tableTitle);

            // Invoice Items
            string[] invoices = {
  "INV-001 | Nguyễn Văn A | 2,500,000 | Paid | 2024-01-15",
       "INV-002 | Trần Thị B | 1,850,000 | Pending | 2024-01-16",
      "INV-003 | Hoàng Văn C | 3,200,000 | Paid | 2024-01-16",
     "INV-004 | Lê Thị D | 2,100,000 | Pending | 2024-01-17",
    "INV-005 | Phạm Văn E | 950,000 | Paid | 2024-01-17"
     };

            int invoiceY = 60;
            foreach (var invoice in invoices)
            {
                Label invoiceLabel = new Label();
                invoiceLabel.Text = invoice;
                invoiceLabel.Font = new Font("Segoe UI", 10);
                invoiceLabel.ForeColor = Color.FromArgb(50, 50, 50);
                invoiceLabel.Location = new Point(20, invoiceY);
                invoiceLabel.AutoSize = true;
                tablePanel.Controls.Add(invoiceLabel);
                invoiceY += 30;
            }

            mainPanel.Controls.Add(tablePanel);

            this.Controls.Add(mainPanel);
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Name = "UCInvoices";
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
