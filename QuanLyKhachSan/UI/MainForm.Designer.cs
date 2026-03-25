namespace QuanLyKhachSan.UI
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            button6 = new Button();
            btnInvoice = new Button();
            btnCustomers = new Button();
            btnBooking = new Button();
            btnFloorView = new Button();
            btnRooms = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panelMain = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(btnInvoice);
            panel1.Controls.Add(btnCustomers);
            panel1.Controls.Add(btnBooking);
            panel1.Controls.Add(btnFloorView);
            panel1.Controls.Add(btnRooms);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 833);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.Location = new Point(0, 289);
            button6.Name = "button6";
            button6.Size = new Size(274, 65);
            button6.TabIndex = 6;
            button6.Text = "SERVICE";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btnInvoice
            // 
            btnInvoice.Location = new Point(2, 606);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(274, 65);
            btnInvoice.TabIndex = 5;
            btnInvoice.Text = "INVOICES";
            btnInvoice.UseVisualStyleBackColor = true;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(2, 525);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(274, 65);
            btnCustomers.TabIndex = 4;
            btnCustomers.Text = "CUSTOMER MANAGEMENT";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnBooking
            // 
            btnBooking.Location = new Point(0, 444);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(274, 65);
            btnBooking.TabIndex = 3;
            btnBooking.Text = "BOOKING MANAGEMENT";
            btnBooking.UseVisualStyleBackColor = true;
            btnBooking.Click += btnBooking_Click;
            // 
            // btnFloorView
            // 
            btnFloorView.Location = new Point(2, 372);
            btnFloorView.Name = "btnFloorView";
            btnFloorView.Size = new Size(274, 65);
            btnFloorView.TabIndex = 7;
            btnFloorView.Text = "ROOM FLOOR VIEW";
            btnFloorView.UseVisualStyleBackColor = true;
            btnFloorView.Click += btnFloorView_Click;
            // 
            // btnRooms
            // 
            btnRooms.Location = new Point(0, 208);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(274, 65);
            btnRooms.TabIndex = 2;
            btnRooms.Text = "ROOM MANAGEMENT";
            btnRooms.UseVisualStyleBackColor = true;
            btnRooms.Click += btnRooms_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(-2, 128);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(274, 65);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 107);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 42);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "ADMIN";
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.ActiveCaption;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(274, 57);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1054, 776);
            panelMain.TabIndex = 2;
            panelMain.MouseClick += panelMain_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 33);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 2;
            label2.Text = "XIN CHÀO ADMIN";
            label2.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(274, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1054, 57);
            panel3.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 833);
            Controls.Add(panelMain);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
   private Label label1;
     private Button button6;
        private Button button5;
        private Button button4;
  private Button button3;
      private Button button2;
 private Panel panel3;
        private Label label2;
        private Panel panelMain;
        private Button btnInvoice;
        private Button btnCustomers;
    private Button btnBooking;
        private Button btnFloorView;
        private Button btnRooms;
      private Button btnDashboard;
    }
}