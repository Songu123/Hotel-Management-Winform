namespace QuanLyKhachSan.UI
{
    partial class UCServices
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
       titleLabel.Text = "⚙️ Services Management";
       titleLabel.Font = new Font("Segoe UI", 24, FontStyle.Bold);
 titleLabel.ForeColor = Color.FromArgb(30, 40, 60);
   titleLabel.Location = new Point(20, 10);
 titleLabel.Size = new Size(600, 40);
mainPanel.Controls.Add(titleLabel);

   // Subtitle
        Label subtitleLabel = new Label();
       subtitleLabel.Text = "Manage premium amenities and additional services";
  subtitleLabel.Font = new Font("Segoe UI", 11);
         subtitleLabel.ForeColor = Color.Gray;
         subtitleLabel.Location = new Point(20, 55);
      subtitleLabel.Size = new Size(600, 25);
 mainPanel.Controls.Add(subtitleLabel);

   // Services Row
        Panel servicesPanel = new Panel();
   servicesPanel.Height = 140;
   servicesPanel.Dock = DockStyle.Top;
   servicesPanel.Padding = new Padding(0, 0, 0, 20);
      servicesPanel.BackColor = Color.Transparent;
         servicesPanel.AutoSize = true;

     servicesPanel.Controls.Add(CreateServiceCard("Active Services", "45", "✓", Color.FromArgb(40, 200, 150), 0));
        servicesPanel.Controls.Add(CreateServiceCard("Pending Orders", "8", "⏳", Color.FromArgb(200, 120, 80), 320));
 servicesPanel.Controls.Add(CreateServiceCard("Total Revenue", "125,500", "💰", Color.FromArgb(70, 130, 180), 640));

       mainPanel.Controls.Add(servicesPanel);

  // Services List Panel
           Panel listPanel = new Panel();
        listPanel.Height = 350;
         listPanel.Dock = DockStyle.Top;
     listPanel.BackColor = Color.White;
            listPanel.BorderStyle = BorderStyle.FixedSingle;
      listPanel.Padding = new Padding(20);
     listPanel.AutoSize = true;

    Label listTitle = new Label();
    listTitle.Text = "📋 Available Services";
      listTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
  listTitle.ForeColor = Color.FromArgb(30, 40, 60);
     listTitle.Location = new Point(20, 20);
listTitle.AutoSize = true;
   listPanel.Controls.Add(listTitle);

       // Service Items
            string[] services = {
           "🛁 Spa & Massage - 500,000đ/session",
          "🍽️ Room Service Dining - 200,000đ/meal",
    "🧺 Laundry Service - 50,000đ/load",
    "🚕 Airport Transfer - 300,000đ/trip",
       "📚 Tour & Excursion - 1,000,000đ/package"
    };

     int serviceY = 60;
    foreach (var service in services)
       {
           Label serviceLabel = new Label();
          serviceLabel.Text = service;
  serviceLabel.Font = new Font("Segoe UI", 10);
     serviceLabel.ForeColor = Color.FromArgb(50, 50, 50);
   serviceLabel.Location = new Point(20, serviceY);
         serviceLabel.AutoSize = true;
     listPanel.Controls.Add(serviceLabel);
   serviceY += 30;
   }

    mainPanel.Controls.Add(listPanel);

     this.Controls.Add(mainPanel);
this.AutoScaleDimensions = new SizeF(7F, 15F);
     this.AutoScaleMode = AutoScaleMode.Font;
  this.Name = "UCServices";
          this.Size = new Size(1234, 803);
 }

  private Panel CreateServiceCard(string title, string value, string icon, Color accentColor, int xPosition)
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
