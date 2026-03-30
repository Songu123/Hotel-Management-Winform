using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.UI.BookingUI
{
    /// <summary>
    /// 💳 PAYMENT FORM - Professional Hotel Payment Processing
    /// Modern, clean interface for payment processing
    /// </summary>
    public partial class PaymentForm : Form
    {
        #region ==================== MODERN COLOR PALETTE ====================

        private static class ModernColors
        {
            // Primary Colors
            public static readonly Color Primary = Color.FromArgb(99, 102, 241);        // Indigo
            public static readonly Color PrimaryDark = Color.FromArgb(79, 70, 229);
            public static readonly Color Secondary = Color.FromArgb(139, 92, 246);      // Purple

            // Accent Colors
            public static readonly Color Success = Color.FromArgb(34, 197, 94);         // Green
            public static readonly Color SuccessLight = Color.FromArgb(220, 252, 231);
            public static readonly Color Danger = Color.FromArgb(239, 68, 68);          // Red
            public static readonly Color Warning = Color.FromArgb(245, 158, 11);        // Orange
            public static readonly Color Info = Color.FromArgb(14, 165, 233);           // Sky Blue

            // Neutrals
            public static readonly Color Background = Color.FromArgb(248, 250, 252);
            public static readonly Color Card = Color.White;
            public static readonly Color CardHover = Color.FromArgb(249, 250, 251);
            public static readonly Color Border = Color.FromArgb(226, 232, 240);
            public static readonly Color BorderLight = Color.FromArgb(241, 245, 249);

            // Text Colors
            public static readonly Color TextPrimary = Color.FromArgb(15, 23, 42);
            public static readonly Color TextSecondary = Color.FromArgb(100, 116, 139);
            public static readonly Color TextMuted = Color.FromArgb(148, 163, 184);
        }

        #endregion

        #region ==================== FIELDS ====================

        private IRentalDetailService _rentalDetailService;
        private IInvoiceService _invoiceService;

        private RentalDetail _rentalDetail;
        private Invoice _invoice;
        private int _totalAmount;
        private int _depositAmount;
        private int _remainingAmount;

        // UI Controls
        private Label lblRentalId;
        private Label lblCustomerName;
        private Label lblIdNumber;
        private Label lblInvoiceNumber;
        private DataGridView dgvRooms;
        private DataGridView dgvServices;
        private Label lblTotalRoomCost;
        private Label lblTotalServiceCost;
        private Label lblDepositPaid;
        private Label lblRemaining;
        private Label lblGrandTotal;
        private NumericUpDown nudPaymentAmount;
        private ComboBox cboPaymentMethod;
        private Button btnPay;
        private Button btnCancel;
        private Panel pnlQRCode;

        #endregion

        #region ==================== CONSTRUCTOR ====================

        public PaymentForm()
        {
            InitializeComponent();
        }

        public PaymentForm(
            RentalDetail rentalDetail,
            Invoice invoice,
            int totalAmount,
            int depositAmount,
            IRentalDetailService rentalDetailService,
            IInvoiceService invoiceService) : this()
        {
            _rentalDetail = rentalDetail;
            _invoice = invoice;
            _totalAmount = totalAmount;
            _depositAmount = depositAmount;
            _remainingAmount = totalAmount - depositAmount;
            _rentalDetailService = rentalDetailService;
            _invoiceService = invoiceService;
        }

        #endregion

        #region ==================== FORM LOAD ====================

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            try
            {
                SetupModernForm();
                CreateModernUI();
                PopulateData();
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Lỗi khởi tạo form: {ex.Message}");
            }
        }

        #endregion

        #region ==================== MODERN SETUP ====================

        private void SetupModernForm()
        {
            this.Text = "💳 THANH TOÁN - Payment Processing";
            this.Width = 1450;
            this.Height = 820;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = ModernColors.Background;
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        }

        #endregion

        #region ==================== MODERN UI CREATION ====================

        private void CreateModernUI()
        {
            // Modern Header with Gradient
            var headerPanel = CreateModernHeader();
            Controls.Add(headerPanel);

            // Main Content Container
            var contentPanel = new Panel
            {
                Location = new Point(0, 90),
                Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 170),
                BackColor = Color.Transparent,
                Padding = new Padding(20, 0, 20, 0)
            };

            // Two-Column Layout
            var leftPanel = CreateModernLeftPanel();
            leftPanel.Location = new Point(20, 10);
            leftPanel.Size = new Size(880, contentPanel.Height - 20);
            contentPanel.Controls.Add(leftPanel);

            var rightPanel = CreateModernRightPanel();
            rightPanel.Location = new Point(920, 10);
            rightPanel.Size = new Size(490, contentPanel.Height - 20);
            contentPanel.Controls.Add(rightPanel);

            Controls.Add(contentPanel);

            // Modern Footer
            var footerPanel = CreateModernFooter();
            Controls.Add(footerPanel);
        }

        private Panel CreateModernHeader()
        {
            var panel = new Panel
            {
                Height = 90,
                Dock = DockStyle.Top,
                BackColor = ModernColors.Card
            };

            // Gradient background
            panel.Paint += (s, e) =>
            {
                using (var brush = new LinearGradientBrush(
                    panel.ClientRectangle,
                    ModernColors.Primary,
                    ModernColors.Secondary,
                    LinearGradientMode.Horizontal))
                {
                    e.Graphics.FillRectangle(brush, panel.ClientRectangle);
                }

                // Bottom shadow
                using (var shadowBrush = new SolidBrush(Color.FromArgb(20, 0, 0, 0)))
                {
                    e.Graphics.FillRectangle(shadowBrush, 0, panel.Height - 3, panel.Width, 3);
                }
            };

            // Icon
            var iconLabel = new Label
            {
                Text = "💳",
                Font = new Font("Segoe UI", 28F),
                ForeColor = Color.White,
                Location = new Point(25, 20),
                AutoSize = true
            };
            panel.Controls.Add(iconLabel);

            // Title
            var lblTitle = new Label
            {
                Text = "Thanh Toán Hoá Đơn",
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(85, 18),
                AutoSize = true
            };
            panel.Controls.Add(lblTitle);

            // Subtitle
            var lblSubtitle = new Label
            {
                Text = "Vui lòng kiểm tra kỹ thông tin trước khi xác nhận thanh toán",
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(240, 240, 255),
                Location = new Point(85, 50),
                AutoSize = true
            };
            panel.Controls.Add(lblSubtitle);

            return panel;
        }

        private Panel CreateModernLeftPanel()
        {
            var panel = new Panel
            {
                BackColor = Color.Transparent,
                AutoScroll = true
            };

            int yPos = 0;

            // Customer Info Card
            var customerCard = CreateInfoCard("Thông Tin Khách Hàng", ModernColors.Info);
            customerCard.Location = new Point(0, yPos);
            customerCard.Width = panel.Width - 20;

            int cardY = 50;
            AddModernInfoRow(customerCard, "Mã chi tiết thuê:", ref lblRentalId, cardY); cardY += 35;
            AddModernInfoRow(customerCard, "Tên khách hàng:", ref lblCustomerName, cardY); cardY += 35;
            AddModernInfoRow(customerCard, "CMND/CCCD:", ref lblIdNumber, cardY);

            customerCard.Height = 160;
            panel.Controls.Add(customerCard);
            yPos += 170;

            // Rooms Card
            var roomsCard = CreateDataCard("Danh Sách Phòng Thuê", ModernColors.Primary);
            roomsCard.Location = new Point(0, yPos);
            roomsCard.Width = panel.Width - 20;
            roomsCard.Height = 250;

            dgvRooms = CreateModernDataGridView(ModernColors.Primary);
            dgvRooms.Location = new Point(15, 50);
            dgvRooms.Size = new Size(roomsCard.Width - 30, 185);

            dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", Width = 50, Name = "colStt" });
            dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên Phòng", Width = 130, Name = "colRoom" });
            dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Loại Thuê", Width = 120, Name = "colType" });
            dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày Thuê", Width = 140, Name = "colCheckIn" });
            dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày Trả", Width = 140, Name = "colCheckOut" });
            dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giá Phòng", Width = 130, Name = "colPrice" });

            roomsCard.Controls.Add(dgvRooms);
            panel.Controls.Add(roomsCard);
            yPos += 260;

            // Services Card
            var servicesCard = CreateDataCard("Danh Sách Dịch Vụ", ModernColors.Warning);
            servicesCard.Location = new Point(0, yPos);
            servicesCard.Width = panel.Width - 20;
            servicesCard.Height = 230;

            dgvServices = CreateModernDataGridView(ModernColors.Warning);
            dgvServices.Location = new Point(15, 50);
            dgvServices.Size = new Size(servicesCard.Width - 30, 165);

            dgvServices.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", Width = 50, Name = "colStt2" });
            dgvServices.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Dịch Vụ", Width = 180, Name = "colService" });
            dgvServices.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Loại", Width = 120, Name = "colServiceType" });
            dgvServices.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày SD", Width = 130, Name = "colDate" });
            dgvServices.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "SL", Width = 70, Name = "colQty" });
            dgvServices.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Đơn Giá", Width = 130, Name = "colUnitPrice" });

            servicesCard.Controls.Add(dgvServices);
            panel.Controls.Add(servicesCard);

            return panel;
        }

        private Panel CreateModernRightPanel()
        {
            var panel = new Panel
            {
                BackColor = Color.Transparent
            };

            int yPos = 0;

            // Payment Summary Card
            var summaryCard = CreateSummaryCard();
            summaryCard.Location = new Point(0, yPos);
            summaryCard.Width = panel.Width - 5;
            summaryCard.Height = 240;
            panel.Controls.Add(summaryCard);
            yPos += 250;

            // Payment Method Card
            var methodCard = CreatePaymentMethodCard();
            methodCard.Location = new Point(0, yPos);
            methodCard.Width = panel.Width - 5;
            methodCard.Height = 180;
            panel.Controls.Add(methodCard);
            yPos += 190;

            // Total Card
            var totalCard = CreateTotalCard();
            totalCard.Location = new Point(0, yPos);
            totalCard.Width = panel.Width - 5;
            totalCard.Height = 120;
            panel.Controls.Add(totalCard);
            yPos += 130;

            // Action Buttons
            var buttonPanel = CreateActionButtons();
            buttonPanel.Location = new Point(0, yPos);
            buttonPanel.Width = panel.Width - 5;
            buttonPanel.Height = 80;
            panel.Controls.Add(buttonPanel);

            return panel;
        }

        private Panel CreateInfoCard(string title, Color accentColor)
        {
            var card = new Panel
            {
                BackColor = ModernColors.Card,
                BorderStyle = BorderStyle.None
            };

            ApplyCardStyle(card);

            // Header with accent
            var header = new Panel
            {
                Height = 45,
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(248, 250, 252)
            };

            header.Paint += (s, e) =>
            {
                // Left accent bar
                using (var brush = new SolidBrush(accentColor))
                {
                    e.Graphics.FillRectangle(brush, 0, 0, 5, header.Height);
                }
            };

            var lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = ModernColors.TextPrimary,
                Location = new Point(20, 12),
                AutoSize = true
            };
            header.Controls.Add(lblTitle);

            card.Controls.Add(header);
            return card;
        }

        private Panel CreateDataCard(string title, Color accentColor)
        {
            var card = new Panel
            {
                BackColor = ModernColors.Card,
                BorderStyle = BorderStyle.None
            };

            ApplyCardStyle(card);

            // Header
            var header = new Panel
            {
                Height = 45,
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(248, 250, 252)
            };

            header.Paint += (s, e) =>
            {
                using (var brush = new SolidBrush(accentColor))
                {
                    e.Graphics.FillRectangle(brush, 0, 0, 5, header.Height);
                }
            };

            var lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = ModernColors.TextPrimary,
                Location = new Point(20, 12),
                AutoSize = true
            };
            header.Controls.Add(lblTitle);

            card.Controls.Add(header);
            return card;
        }

        private Panel CreateSummaryCard()
        {
            var card = CreateInfoCard("Chi Tiết Thanh Toán", ModernColors.Success);
            card.Height = 240;

            int yPos = 60;
            AddAmountRow(card, "💰 Tổng tiền phòng:", ref lblTotalRoomCost, yPos, ModernColors.Primary);
            yPos += 45;
            AddAmountRow(card, "🛎️ Tổng tiền dịch vụ:", ref lblTotalServiceCost, yPos, ModernColors.Warning);
            yPos += 45;
            AddAmountRow(card, "💵 Tiền đặt cọc:", ref lblDepositPaid, yPos, ModernColors.Info);
            yPos += 45;

            // Divider
            var divider = new Panel
            {
                Height = 2,
                Width = card.Width - 40,
                Location = new Point(20, yPos - 10),
                BackColor = ModernColors.BorderLight
            };
            card.Controls.Add(divider);

            return card;
        }

        private Panel CreatePaymentMethodCard()
        {
            var card = CreateInfoCard("Phương Thức Thanh Toán", ModernColors.Secondary);

            var lblMethod = new Label
            {
                Text = "Chọn phương thức:",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ModernColors.TextSecondary,
                Location = new Point(20, 60),
                AutoSize = true
            };
            card.Controls.Add(lblMethod);

            cboPaymentMethod = new ComboBox
            {
                Location = new Point(20, 85),
                Width = card.Width - 40,
                Height = 35,
                Font = new Font("Segoe UI", 10F),
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat
            };
            cboPaymentMethod.Items.AddRange(new string[] {
                "💵 Tiền mặt",
                "🏦 Chuyển khoản",
                "💳 Thẻ tín dụng",
                "📱 Ví điện tử",
                "🔄 Khác"
            });
            cboPaymentMethod.SelectedIndex = 0;
            StyleComboBox(cboPaymentMethod);
            card.Controls.Add(cboPaymentMethod);

            var lblAmount = new Label
            {
                Text = "Số tiền thanh toán:",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ModernColors.TextSecondary,
                Location = new Point(20, 130),
                AutoSize = true
            };
            card.Controls.Add(lblAmount);

            nudPaymentAmount = new NumericUpDown
            {
                Location = new Point(20, 155),
                Width = card.Width - 40,
                Height = 35,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Maximum = 1000000000,
                DecimalPlaces = 0,
                ThousandsSeparator = true,
                BorderStyle = BorderStyle.FixedSingle
            };
            StyleNumericUpDown(nudPaymentAmount);
            card.Controls.Add(nudPaymentAmount);

            return card;
        }

        private Panel CreateTotalCard()
        {
            var card = new Panel
            {
                BackColor = ModernColors.SuccessLight,
                BorderStyle = BorderStyle.None
            };

            ApplyCardStyle(card);

            card.Paint += (s, e) =>
            {
                // Left success bar
                using (var brush = new SolidBrush(ModernColors.Success))
                {
                    e.Graphics.FillRectangle(brush, 0, 0, 8, card.Height);
                }
            };

            var lblLabel = new Label
            {
                Text = "TỔNG THANH TOÁN",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = ModernColors.TextSecondary,
                Location = new Point(25, 20),
                AutoSize = true
            };
            card.Controls.Add(lblLabel);

            lblGrandTotal = new Label
            {
                Text = "0 VNĐ",
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                ForeColor = ModernColors.Success,
                Location = new Point(25, 50),
                AutoSize = true
            };
            card.Controls.Add(lblGrandTotal);

            return card;
        }

        private Panel CreateActionButtons()
        {
            var panel = new Panel
            {
                BackColor = Color.Transparent
            };

            btnPay = new Button
            {
                Text = "✓ Xác Nhận Thanh Toán",
                Size = new Size(panel.Width - 5, 50),
                Location = new Point(0, 0),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            ApplyPrimaryButton(btnPay);
            btnPay.Click += BtnPay_Click;
            panel.Controls.Add(btnPay);

            btnCancel = new Button
            {
                Text = "✕ Huỷ Bỏ",
                Size = new Size(panel.Width - 5, 40),
                Location = new Point(0, 60),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            ApplySecondaryButton(btnCancel);
            btnCancel.Click += (s, e) => this.Close();
            panel.Controls.Add(btnCancel);

            return panel;
        }

        private Panel CreateModernFooter()
        {
            var panel = new Panel
            {
                Height = 70,
                Dock = DockStyle.Bottom,
                BackColor = ModernColors.Card,
                Padding = new Padding(25, 20, 25, 20)
            };

            panel.Paint += (s, e) =>
            {
                // Top border
                using (var pen = new Pen(ModernColors.Border, 1))
                {
                    e.Graphics.DrawLine(pen, 0, 0, panel.Width, 0);
                }
            };

            var iconLabel = new Label
            {
                Text = "ℹ️",
                Font = new Font("Segoe UI", 14F),
                Location = new Point(25, 23),
                AutoSize = true
            };
            panel.Controls.Add(iconLabel);

            var lblInfo = new Label
            {
                Text = "Vui lòng kiểm tra kỹ thông tin trước khi xác nhận. Giao dịch sẽ được ghi nhận ngay lập tức.",
                Font = new Font("Segoe UI", 9F),
                ForeColor = ModernColors.TextSecondary,
                Location = new Point(55, 25),
                AutoSize = true
            };
            panel.Controls.Add(lblInfo);

            return panel;
        }

        private DataGridView CreateModernDataGridView(Color headerColor)
        {
            var dgv = new DataGridView
            {
                AutoGenerateColumns = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                BackgroundColor = ModernColors.Card,
                BorderStyle = BorderStyle.None,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                GridColor = ModernColors.BorderLight,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowTemplate = { Height = 40 },
                EnableHeadersVisualStyles = false
            };

            // Header style
            dgv.ColumnHeadersHeight = 42;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Row styles
            dgv.DefaultCellStyle.BackColor = ModernColors.Card;
            dgv.DefaultCellStyle.ForeColor = ModernColors.TextPrimary;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(238, 242, 255);
            dgv.DefaultCellStyle.SelectionForeColor = ModernColors.Primary;
            dgv.DefaultCellStyle.Padding = new Padding(8, 5, 5, 5);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 251);

            return dgv;
        }

        #endregion

        #region ==================== STYLING HELPERS ====================

        private void ApplyCardStyle(Panel card)
        {
            card.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                var rect = card.ClientRectangle;
                using (var path = RoundedRect(rect, 10))
                {
                    // Fill
                    using (var brush = new SolidBrush(card.BackColor))
                    {
                        e.Graphics.FillPath(brush, path);
                    }

                    // Border
                    using (var pen = new Pen(ModernColors.Border, 1))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }

                // Subtle shadow
                using (var shadowBrush = new SolidBrush(Color.FromArgb(8, 0, 0, 0)))
                {
                    e.Graphics.FillRectangle(shadowBrush, 3, card.Height - 2, card.Width - 6, 2);
                }
            };
        }

        private void ApplyPrimaryButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = ModernColors.Success;
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderSize = 0;

            btn.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var path = RoundedRect(btn.ClientRectangle, 8))
                {
                    btn.Region = new Region(path);
                }
            };

            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(22, 163, 74);
            btn.MouseLeave += (s, e) => btn.BackColor = ModernColors.Success;
        }

        private void ApplySecondaryButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = ModernColors.Card;
            btn.ForeColor = ModernColors.TextSecondary;
            btn.FlatAppearance.BorderColor = ModernColors.Border;
            btn.FlatAppearance.BorderSize = 2;

            btn.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var path = RoundedRect(btn.ClientRectangle, 8))
                {
                    btn.Region = new Region(path);
                }
            };

            btn.MouseEnter += (s, e) => btn.BackColor = ModernColors.CardHover;
            btn.MouseLeave += (s, e) => btn.BackColor = ModernColors.Card;
        }

        private void StyleComboBox(ComboBox cbo)
        {
            cbo.BackColor = Color.FromArgb(249, 250, 251);
            cbo.ForeColor = ModernColors.TextPrimary;
        }

        private void StyleNumericUpDown(NumericUpDown nud)
        {
            nud.BackColor = Color.FromArgb(249, 250, 251);
            nud.ForeColor = ModernColors.TextPrimary;
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();

            return path;
        }

        #endregion

        #region ==================== DATA POPULATION ====================

        private void PopulateData()
        {
            try
            {
                if (_rentalDetail == null) return;

                lblRentalId.Text = _rentalDetail.RentalDetailId ?? "N/A";
                lblCustomerName.Text = _rentalDetail.Customer?.Name ?? "N/A";
                lblIdNumber.Text = _rentalDetail.Customer?.IdNumber ?? "N/A";

                int roomCost = _rentalDetail.RoomRentalDetails?.Sum(r =>
                    r.RentalPrice * (int)(r.ReturnDate - r.RentalDate).TotalDays) ?? 0;
                int serviceCost = _rentalDetail.ServiceRentalDetails?.Sum(s =>
                    s.Price * s.Quantity) ?? 0;

                lblTotalRoomCost.Text = FormatCurrency(roomCost);
                lblTotalServiceCost.Text = FormatCurrency(serviceCost);
                lblDepositPaid.Text = FormatCurrency(_depositAmount);
                lblGrandTotal.Text = FormatCurrency(_totalAmount);

                nudPaymentAmount.Value = _remainingAmount;

                PopulateRoomsGrid();
                PopulateServicesGrid();
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Lỗi tải dữ liệu: {ex.Message}");
            }
        }

        private void PopulateRoomsGrid()
        {
            if (dgvRooms == null || _rentalDetail?.RoomRentalDetails == null) return;

            dgvRooms.Rows.Clear();
            int stt = 1;
            foreach (var room in _rentalDetail.RoomRentalDetails)
            {
                dgvRooms.Rows.Add(
                    stt++,
                    room.RoomId,
                    "Theo Ngày",
                    room.RentalDate.ToString("dd/MM/yyyy HH:mm"),
                    room.ReturnDate.ToString("dd/MM/yyyy HH:mm"),
                    FormatCurrency(room.RentalPrice)
                );
            }
        }

        private void PopulateServicesGrid()
        {
            if (dgvServices == null || _rentalDetail?.ServiceRentalDetails == null) return;

            dgvServices.Rows.Clear();
            int stt = 1;
            foreach (var service in _rentalDetail.ServiceRentalDetails)
            {
                dgvServices.Rows.Add(
                    stt++,
                    service.ServiceId,
                    "Dịch Vụ",
                    service.UsageDate.ToString("dd/MM/yyyy"),
                    service.Quantity,
                    FormatCurrency(service.Price)
                );
            }
        }

        #endregion

        #region ==================== EVENT HANDLERS ====================

        private async void BtnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (nudPaymentAmount.Value <= 0)
                {
                    ShowWarningMessage("Vui lòng nhập số tiền thanh toán hợp lệ");
                    return;
                }

                var result = MessageBox.Show(
                    $"Xác nhận thanh toán {FormatCurrency((int)nudPaymentAmount.Value)}?\n\n" +
                    $"Phương thức: {cboPaymentMethod.SelectedItem}\n" +
                    $"Số tiền: {FormatCurrency((int)nudPaymentAmount.Value)}",
                    "Xác Nhận Thanh Toán",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (_invoice != null && _invoiceService != null)
                    {
                        _invoice.PaymentMethod = cboPaymentMethod.SelectedIndex;
                        _invoice.PaymentDate = DateTime.Now;
                        await _invoiceService.UpdateInvoiceAsync(_invoice);
                    }

                    ShowSuccessMessage("Thanh toán thành công!\n\nGiao dịch đã được ghi nhận.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Lỗi thanh toán: {ex.Message}");
            }
        }

        #endregion

        #region ==================== HELPER METHODS ====================

        private void AddModernInfoRow(Panel panel, string label, ref Label valueControl, int yPos)
        {
            var lblLabel = new Label
            {
                Text = label,
                Font = new Font("Segoe UI", 9F),
                ForeColor = ModernColors.TextSecondary,
                Location = new Point(20, yPos),
                AutoSize = true
            };
            panel.Controls.Add(lblLabel);

            valueControl = new Label
            {
                Text = "N/A",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = ModernColors.TextPrimary,
                Location = new Point(180, yPos - 2),
                AutoSize = true
            };
            panel.Controls.Add(valueControl);
        }

        private void AddAmountRow(Panel panel, string label, ref Label valueControl, int yPos, Color accentColor)
        {
            var lblLabel = new Label
            {
                Text = label,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ModernColors.TextSecondary,
                Location = new Point(20, yPos),
                AutoSize = true
            };
            panel.Controls.Add(lblLabel);

            valueControl = new Label
            {
                Text = "0 VNĐ",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = accentColor,
                Location = new Point(panel.Width - 180, yPos - 2),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleRight
            };
            panel.Controls.Add(valueControl);
        }

        private string FormatCurrency(int amount)
        {
            return amount.ToString("N0") + " VNĐ";
        }

        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "✓ Thành Công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "⚠ Cảnh Báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "✕ Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}