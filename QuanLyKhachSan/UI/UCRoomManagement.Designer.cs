namespace QuanLyKhachSan.UI
{
    partial class UCRoomManagement
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
  this.components = new System.ComponentModel.Container();
     this.tabMainControl = new System.Windows.Forms.TabControl();
          this.tabRoom = new System.Windows.Forms.TabPage();
         this.tabAmenity = new System.Windows.Forms.TabPage();
            this.pnlGrid = new System.Windows.Forms.Panel();
 this.pnlForm = new System.Windows.Forms.Panel();
          this.dgvRooms = new System.Windows.Forms.DataGridView();
     this.dgvAmenities = new System.Windows.Forms.DataGridView();
     this.pnlFilter = new System.Windows.Forms.Panel();
        this.tbRoomId = new System.Windows.Forms.TextBox();
          this.tbRoomName = new System.Windows.Forms.TextBox();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.cbRoomTypeDetails = new System.Windows.Forms.ComboBox();
            this.cbPrice = new System.Windows.Forms.ComboBox();
      this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbCurrentCondition = new System.Windows.Forms.ComboBox();
         this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAddRoom = new System.Windows.Forms.Button();
   this.btnEditRoom = new System.Windows.Forms.Button();
      this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.gbRoomInfo = new System.Windows.Forms.GroupBox();
  this.tbFormRoomId = new System.Windows.Forms.TextBox();
     this.tbFormRoomName = new System.Windows.Forms.TextBox();
   this.cbFormRoomType = new System.Windows.Forms.ComboBox();
            this.cbFormRoomTypeDetails = new System.Windows.Forms.ComboBox();
   this.tbFormPrice = new System.Windows.Forms.TextBox();
        this.cbFormStatus = new System.Windows.Forms.ComboBox();
      this.cbFormCurrentCondition = new System.Windows.Forms.ComboBox();
    this.btnSaveRoom = new System.Windows.Forms.Button();
          this.btnCancelForm = new System.Windows.Forms.Button();
            this.pnlAmenityMain = new System.Windows.Forms.Panel();
            this.pnlAmenityForm = new System.Windows.Forms.Panel();
            this.pnlAmenityButtons = new System.Windows.Forms.Panel();
            this.btnAddAmenity = new System.Windows.Forms.Button();
    this.btnEditAmenity = new System.Windows.Forms.Button();
this.btnDeleteAmenity = new System.Windows.Forms.Button();
    this.gbAmenityInfo = new System.Windows.Forms.GroupBox();
            this.tbAmenityId = new System.Windows.Forms.TextBox();
            this.tbAmenityName = new System.Windows.Forms.TextBox();
     this.btnSaveAmenity = new System.Windows.Forms.Button();
          this.btnCancelAmenity = new System.Windows.Forms.Button();

       this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
  this.colRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
       this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomTypeDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
  this.colCurrentCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
       this.colAmenityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
 this.colAmenityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
       this.colAmenityActions = new System.Windows.Forms.DataGridViewTextBoxColumn();

   this.tabMainControl.TabPages.AddRange(new System.Windows.Forms.TabPage[] { this.tabRoom, this.tabAmenity });
       this.tabMainControl.Dock = System.Windows.Forms.DockStyle.Fill;

            this.tabRoom.Controls.Add(this.pnlGrid);
      this.tabRoom.Controls.Add(this.pnlForm);
    this.tabRoom.Text = "Quản Lý Phòng";

   this.tabAmenity.Controls.Add(this.pnlAmenityMain);
         this.tabAmenity.Controls.Add(this.pnlAmenityForm);
      this.tabAmenity.Text = "Quản Lý Tiện Ích";

            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
          this.pnlGrid.Controls.Add(this.dgvRooms);
        this.pnlGrid.Controls.Add(this.pnlButtons);
            this.pnlGrid.Controls.Add(this.pnlFilter);

            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Controls.Add(this.gbRoomInfo);
            this.pnlForm.Visible = false;

            this.pnlAmenityMain.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlAmenityMain.Controls.Add(this.dgvAmenities);
            this.pnlAmenityMain.Controls.Add(this.pnlAmenityButtons);

   this.pnlAmenityForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAmenityForm.Controls.Add(this.gbAmenityInfo);
       this.pnlAmenityForm.Visible = false;

     this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
     this.colSTT, this.colRoomId, this.colRoomName, this.colRoomType, 
 this.colPrice, this.colRoomTypeDetails, this.colStatus, this.colCurrentCondition });
    this.dgvRooms.Dock = System.Windows.Forms.DockStyle.Fill;

            this.dgvAmenities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
      this.colAmenityId, this.colAmenityName, this.colAmenityActions });
            this.dgvAmenities.Dock = System.Windows.Forms.DockStyle.Fill;

            this.Controls.Add(this.tabMainControl);
            this.Name = "UCRoomManagement";
         this.Size = new System.Drawing.Size(1126, 650);
            this.Load += new System.EventHandler(this.UCRoomManagement_Load);
    }

        private System.Windows.Forms.TabControl tabMainControl;
    private System.Windows.Forms.TabPage tabRoom;
      private System.Windows.Forms.TabPage tabAmenity;
        private System.Windows.Forms.Panel pnlGrid;
    private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlAmenityMain;
 private System.Windows.Forms.Panel pnlAmenityForm;
        private System.Windows.Forms.Panel pnlAmenityButtons;

        private System.Windows.Forms.DataGridView dgvRooms;
     private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomId;
  private System.Windows.Forms.DataGridViewTextBoxColumn colRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn colRoomTypeDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentCondition;

     private System.Windows.Forms.DataGridView dgvAmenities;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmenityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmenityName;
   private System.Windows.Forms.DataGridViewTextBoxColumn colAmenityActions;

   private System.Windows.Forms.TextBox tbRoomId;
        private System.Windows.Forms.TextBox tbRoomName;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.ComboBox cbRoomTypeDetails;
      private System.Windows.Forms.ComboBox cbPrice;
  private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbCurrentCondition;
     private System.Windows.Forms.Button btnSearch;
      private System.Windows.Forms.Button btnRefresh;

private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.Button btnDeleteRoom;

   private System.Windows.Forms.GroupBox gbRoomInfo;
   private System.Windows.Forms.TextBox tbFormRoomId;
        private System.Windows.Forms.TextBox tbFormRoomName;
      private System.Windows.Forms.ComboBox cbFormRoomType;
        private System.Windows.Forms.ComboBox cbFormRoomTypeDetails;
        private System.Windows.Forms.TextBox tbFormPrice;
        private System.Windows.Forms.ComboBox cbFormStatus;
     private System.Windows.Forms.ComboBox cbFormCurrentCondition;
        private System.Windows.Forms.Button btnSaveRoom;
     private System.Windows.Forms.Button btnCancelForm;

      private System.Windows.Forms.Button btnAddAmenity;
        private System.Windows.Forms.Button btnEditAmenity;
        private System.Windows.Forms.Button btnDeleteAmenity;

    private System.Windows.Forms.GroupBox gbAmenityInfo;
     private System.Windows.Forms.TextBox tbAmenityId;
        private System.Windows.Forms.TextBox tbAmenityName;
        private System.Windows.Forms.Button btnSaveAmenity;
  private System.Windows.Forms.Button btnCancelAmenity;
    }
}
