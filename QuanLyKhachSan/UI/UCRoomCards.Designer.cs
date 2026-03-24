namespace QuanLyKhachSan.UI
{
    partial class UCRoomCards
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

            // Main Panel with scroll
            Panel mainPanel = new Panel();
     mainPanel.Dock = DockStyle.Fill;
            mainPanel.BackColor = Color.FromArgb(245, 247, 250);
        mainPanel.AutoScroll = true;
  mainPanel.Padding = new Padding(20);

        // Title
            Label titleLabel = new Label();
            titleLabel.Text = "🏠 Room Status Overview";
          titleLabel.Font = new Font("Segoe UI", 24, FontStyle.Bold);
  titleLabel.ForeColor = Color.FromArgb(30, 40, 60);
  titleLabel.Location = new Point(20, 10);
 titleLabel.Size = new Size(600, 40);
mainPanel.Controls.Add(titleLabel);

   // Subtitle
         Label subtitleLabel = new Label();
       subtitleLabel.Text = "Interactive room cards showing guest information, check-in/out dates, and availability";
   subtitleLabel.Font = new Font("Segoe UI", 11);
   subtitleLabel.ForeColor = Color.Gray;
            subtitleLabel.Location = new Point(20, 55);
            subtitleLabel.Size = new Size(800, 25);
       mainPanel.Controls.Add(subtitleLabel);

   // Stats Row
        Panel statsPanel = new Panel();
   statsPanel.Height = 140;
       statsPanel.Dock = DockStyle.Top;
      statsPanel.Padding = new Padding(0, 0, 0, 20);
       statsPanel.BackColor = Color.Transparent;
     statsPanel.AutoSize = true;

            statsPanel.Controls.Add(CreateStatCard("Total Rooms", "12", "🔑", Color.FromArgb(100, 100, 100), 0));
    statsPanel.Controls.Add(CreateStatCard("Available", "5", "✅", Color.FromArgb(40, 200, 150), 280));
      statsPanel.Controls.Add(CreateStatCard("Occupied", "5", "👥", Color.FromArgb(220, 100, 100), 560));
         statsPanel.Controls.Add(CreateStatCard("Reserved", "1", "📅", Color.FromArgb(70, 180, 200), 840));
     statsPanel.Controls.Add(CreateStatCard("Maintenance", "1", "🔧", Color.FromArgb(200, 150, 80), 1120));

      mainPanel.Controls.Add(statsPanel);

            // Room Container Panel (scrollable area for cards)
            Panel containerPanel = new Panel();
 containerPanel.Name = "pnlRoomContainer";
    containerPanel.Dock = DockStyle.Fill;
            containerPanel.BackColor = Color.FromArgb(245, 247, 250);
   containerPanel.AutoScroll = true;
            containerPanel.Padding = new Padding(10);
      mainPanel.Controls.Add(containerPanel);

    this.Controls.Add(mainPanel);
    this.AutoScaleDimensions = new SizeF(7F, 15F);
      this.AutoScaleMode = AutoScaleMode.Font;
            this.Name = "UCRoomCards";
 this.Size = new Size(1234, 803);
this.Load += UCRoomCards_Load;
        }

  private Panel CreateStatCard(string title, string value, string icon, Color accentColor, int xPosition)
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
            titleLabel.Font = new Font("Segoe UI", 9);
            titleLabel.ForeColor = Color.Gray;
          titleLabel.Location = new Point(20, 12);
            titleLabel.AutoSize = true;
            card.Controls.Add(titleLabel);

         Label iconLabel = new Label();
    iconLabel.Text = icon;
            iconLabel.Font = new Font("Segoe UI", 16);
        iconLabel.Location = new Point(210, 10);
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
