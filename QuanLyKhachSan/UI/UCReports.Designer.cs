namespace QuanLyKhachSan.UI
{
    partial class UCReports
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
  titleLabel.Text = "📊 Reports & Analytics";
           titleLabel.Font = new Font("Segoe UI", 24, FontStyle.Bold);
     titleLabel.ForeColor = Color.FromArgb(30, 40, 60);
        titleLabel.Location = new Point(20, 10);
       titleLabel.Size = new Size(600, 40);
        mainPanel.Controls.Add(titleLabel);

         // Subtitle
      Label subtitleLabel = new Label();
     subtitleLabel.Text = "View financial reports and performance metrics";
        subtitleLabel.Font = new Font("Segoe UI", 11);
           subtitleLabel.ForeColor = Color.Gray;
     subtitleLabel.Location = new Point(20, 55);
 subtitleLabel.Size = new Size(600, 25);
      mainPanel.Controls.Add(subtitleLabel);

      // Key Metrics Row
    Panel metricsPanel = new Panel();
       metricsPanel.Height = 140;
        metricsPanel.Dock = DockStyle.Top;
    metricsPanel.Padding = new Padding(0, 0, 0, 20);
    metricsPanel.BackColor = Color.Transparent;
  metricsPanel.AutoSize = true;

metricsPanel.Controls.Add(CreateMetricCard("Monthly Revenue", "1,250,000", "💰", Color.FromArgb(70, 130, 180), 0));
   metricsPanel.Controls.Add(CreateMetricCard("Occupancy %", "78%", "📊", Color.FromArgb(40, 200, 150), 320));
       metricsPanel.Controls.Add(CreateMetricCard("Avg Room Rate", "850,000", "📈", Color.FromArgb(200, 150, 80), 640));

      mainPanel.Controls.Add(metricsPanel);

  // Report Panel
     Panel reportPanel = new Panel();
reportPanel.Height = 350;
     reportPanel.Dock = DockStyle.Top;
   reportPanel.BackColor = Color.White;
  reportPanel.BorderStyle = BorderStyle.FixedSingle;
    reportPanel.Padding = new Padding(20);
reportPanel.AutoSize = true;

    Label reportTitle = new Label();
   reportTitle.Text = "📋 Monthly Performance";
         reportTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
  reportTitle.ForeColor = Color.FromArgb(30, 40, 60);
  reportTitle.Location = new Point(20, 20);
       reportTitle.AutoSize = true;
          reportPanel.Controls.Add(reportTitle);

   // Report Items
    string[] reports = {
     "Jan 2024: Revenue 1,200,000 | Occupancy 75% | Guests 156",
       "Dec 2023: Revenue 1,180,000 | Occupancy 72% | Guests 148",
  "Nov 2023: Revenue 950,000 | Occupancy 68% | Guests 134",
           "Oct 2023: Revenue 1,100,000 | Occupancy 76% | Guests 158",
   "Sep 2023: Revenue 850,000 | Occupancy 62% | Guests 118"
 };

  int reportY = 60;
       foreach (var report in reports)
      {
           Label reportLabel = new Label();
 reportLabel.Text = report;
       reportLabel.Font = new Font("Segoe UI", 10);
      reportLabel.ForeColor = Color.FromArgb(50, 50, 50);
   reportLabel.Location = new Point(20, reportY);
         reportLabel.AutoSize = true;
       reportPanel.Controls.Add(reportLabel);
         reportY += 30;
       }

       mainPanel.Controls.Add(reportPanel);

  this.Controls.Add(mainPanel);
     this.AutoScaleDimensions = new SizeF(7F, 15F);
       this.AutoScaleMode = AutoScaleMode.Font;
       this.Name = "UCReports";
  this.Size = new Size(1234, 803);
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
    }
}
