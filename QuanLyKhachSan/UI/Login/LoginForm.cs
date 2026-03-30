using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.UI.Login
{
    /// <summary>
    /// 🔐 SIMPLE LOGIN FORM - Giao diện đơn giản, dễ sử dụng
    /// </summary>
    public partial class LoginForm : Form
    {
        // UI Controls
        private Panel pnlBackground;
        private Panel pnlLeftIllustration;
        private Panel pnlRightForm;
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnForgotPassword;
        private Button btnResetPassword;
        private Button btnTogglePassword;
        private CheckBox chkRememberMe;
        private Label lblError;
        private bool isPasswordVisible = false;

        // Authentication service
        private readonly IAuthenticationService _authService;

        public LoginForm(IAuthenticationService authService = null)
        {
            InitializeComponent();
            _authService = authService;
            this.DoubleBuffered = true;
            BuildUI();
            LoadRememberedCredentials();
        }

        private void BuildUI()
        {
            // ===== FORM SETUP =====
            this.Text = "ĐĂNG NHẬP HỆ THỐNG KHÁCH SẠN";
            this.Width = 1000;
            this.Height = 650;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.White;

            // Main background
            pnlBackground = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            this.Controls.Add(pnlBackground);

            // ===== LEFT ILLUSTRATION PANEL =====
            CreateLeftIllustrationPanel();

            // ===== RIGHT FORM PANEL =====
            CreateRightFormPanel();

            // Handle ESC key
            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
         {
             if (e.KeyCode == Keys.Escape)
             {
                 this.DialogResult = DialogResult.Cancel;
                 this.Close();
             }
         };
        }

        /// <summary>
        /// Create LEFT PANEL with illustration
        /// </summary>
        private void CreateLeftIllustrationPanel()
        {
            pnlLeftIllustration = new Panel
            {
                Dock = DockStyle.Left,
                Width = 450,
                BackColor = Color.FromArgb(230, 240, 255)
            };

            // Draw illustration background
            pnlLeftIllustration.Paint += (s, e) =>
            {
                // Light blue background
                using (var brush = new SolidBrush(Color.FromArgb(230, 240, 255)))
                {
                    e.Graphics.FillRectangle(brush, e.ClipRectangle);
                }

                // Draw some decorative circles/shapes
                using (var circleBrush = new SolidBrush(Color.FromArgb(150, 200, 255)))
                {
                    e.Graphics.FillEllipse(circleBrush, 50, 100, 150, 150);
                    e.Graphics.FillEllipse(circleBrush, 200, 250, 200, 200);
                }

                // Draw simple illustration elements
                DrawIllustration(e.Graphics);
            };

            pnlBackground.Controls.Add(pnlLeftIllustration);
        }

        /// <summary>
        /// Draw simple illustration on the left panel
        /// </summary>
        private void DrawIllustration(Graphics g)
        {
            // This draws a simple illustration representation
            // In a real app, you might use an image file instead

            using (var pen = new Pen(Color.FromArgb(100, 150, 220), 2))
            {
                // Draw simple decorative elements
                g.DrawEllipse(pen, 80, 150, 100, 100); // Circle 1
                g.DrawEllipse(pen, 200, 200, 120, 120); // Circle 2
                g.DrawRectangle(pen, 120, 350, 150, 120); // Rectangle
            }

            // Draw text on illustration
            using (var font = new Font("Segoe UI", 16, FontStyle.Bold))
            {
                using (var brush = new SolidBrush(Color.FromArgb(60, 120, 200)))
                {
                    g.DrawString("Quản Lý Khách Sạn", font, brush, new Point(60, 500));
                }
            }
        }

        /// <summary>
        /// Create RIGHT PANEL with login form
        /// </summary>
        private void CreateRightFormPanel()
        {
            pnlRightForm = new Panel
      {
        Location = new Point(450, 0),
          Width = 550,
                Height = 650,
      BackColor = Color.White,
              Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom
   };

          // Create a container for form controls to center them
var pnlFormContainer = new Panel
  {
     Location = new Point(50, 60),
           Width = 450,
        Height = 530,
            BackColor = Color.Transparent,
           Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
      };

    int yPos = 0;

            // ===== TITLE =====
            lblTitle = new Label
        {
      Text = "Thông tin đăng nhập",
     Font = new Font("Segoe UI", 24, FontStyle.Bold),
      ForeColor = Color.FromArgb(40, 40, 40),
                AutoSize = true,
     Location = new Point(0, yPos),
        BackColor = Color.Transparent
      };
   pnlFormContainer.Controls.Add(lblTitle);
            yPos += 70;

 // ===== USERNAME FIELD =====
       lblUsername = new Label
  {
        Text = "Tên tài khoản",
        Font = new Font("Segoe UI", 11),
      ForeColor = Color.FromArgb(60, 60, 60),
    AutoSize = true,
     Location = new Point(0, yPos),
    BackColor = Color.Transparent
            };
         pnlFormContainer.Controls.Add(lblUsername);
            yPos += 30;

     txtUsername = new TextBox
          {
          Location = new Point(0, yPos),
      Width = 400,
        Height = 40,
 Font = new Font("Segoe UI", 12),
    BorderStyle = BorderStyle.FixedSingle,
        BackColor = Color.White,
     ForeColor = Color.FromArgb(40, 40, 40)
            };
 txtUsername.PlaceholderText = "Nhập tên tài khoản";
      pnlFormContainer.Controls.Add(txtUsername);
  yPos += 55;

         // ===== PASSWORD FIELD =====
            lblPassword = new Label
            {
            Text = "Mật khẩu",
        Font = new Font("Segoe UI", 11),
      ForeColor = Color.FromArgb(60, 60, 60),
    AutoSize = true,
        Location = new Point(0, yPos),
      BackColor = Color.Transparent
   };
            pnlFormContainer.Controls.Add(lblPassword);
        yPos += 30;

     // Password container panel with toggle button
      var pnlPasswordContainer = new Panel
    {
                Location = new Point(0, yPos),
     Width = 400,
       Height = 40,
          BackColor = Color.White,
       BorderStyle = BorderStyle.FixedSingle
  };

         txtPassword = new TextBox
{
           Location = new Point(10, 5),
      Width = 345,
            Height = 30,
              Font = new Font("Segoe UI", 12),
BorderStyle = BorderStyle.None,
     UseSystemPasswordChar = true,
        ForeColor = Color.FromArgb(40, 40, 40),
     BackColor = Color.White
   };
   txtPassword.PlaceholderText = "Nhập mật khẩu";
            txtPassword.KeyDown += (s, e) =>
    {
        if (e.KeyCode == Keys.Return)
                {
             e.SuppressKeyPress = true;
   BtnLogin_Click(null, null);
        }
    };
            pnlPasswordContainer.Controls.Add(txtPassword);

    btnTogglePassword = new Button
 {
      Location = new Point(355, 5),
             Width = 40,
             Height = 30,
       Text = "👁️",
  Font = new Font("Segoe UI", 14),
        BackColor = Color.White,
         ForeColor = Color.FromArgb(100, 100, 100),
       FlatStyle = FlatStyle.Flat,
         Cursor = Cursors.Hand
            };
            btnTogglePassword.FlatAppearance.BorderSize = 0;
         btnTogglePassword.Click += BtnTogglePassword_Click;
     pnlPasswordContainer.Controls.Add(btnTogglePassword);

 pnlFormContainer.Controls.Add(pnlPasswordContainer);
            yPos += 55;

            // ===== REMEMBER ME =====
   chkRememberMe = new CheckBox
            {
        Text = "Ghi nhớ tôi",
  Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(80, 80, 80),
                Location = new Point(0, yPos),
   AutoSize = true,
    Cursor = Cursors.Hand,
        BackColor = Color.Transparent
            };
       pnlFormContainer.Controls.Add(chkRememberMe);
     yPos += 40;

          // ===== ERROR MESSAGE =====
            lblError = new Label
        {
            Text = "Sai tài khoản hoặc mật khẩu!",
       Font = new Font("Segoe UI", 10),
   ForeColor = Color.FromArgb(200, 50, 50),
      Location = new Point(0, yPos),
        Width = 400,
  Height = 35,
        AutoSize = false,
          Visible = false,
         TextAlign = ContentAlignment.MiddleLeft,
      BackColor = Color.Transparent
      };
            pnlFormContainer.Controls.Add(lblError);
yPos += 45;

            // ===== LOGIN BUTTON =====
         btnLogin = new Button
       {
            Location = new Point(0, yPos),
                Width = 400,
       Height = 45,
      Text = "Đăng nhập",
         Font = new Font("Segoe UI", 12, FontStyle.Bold),
          BackColor = Color.FromArgb(0, 150, 140),
          ForeColor = Color.White,
     FlatStyle = FlatStyle.Flat,
        Cursor = Cursors.Hand
  };
         btnLogin.FlatAppearance.BorderSize = 0;
     btnLogin.Click += BtnLogin_Click;
            btnLogin.MouseEnter += (s, e) => btnLogin.BackColor = Color.FromArgb(0, 130, 120);
      btnLogin.MouseLeave += (s, e) => btnLogin.BackColor = Color.FromArgb(0, 150, 140);
            pnlFormContainer.Controls.Add(btnLogin);
         yPos += 55;

            // ===== FORGOT PASSWORD AND RESET PASSWORD BUTTONS =====
            var pnlButtonContainer = new Panel
       {
       Location = new Point(0, yPos),
       Width = 400,
      Height = 45,
   BackColor = Color.Transparent
        };

            btnForgotPassword = new Button
       {
Location = new Point(0, 0),
          Width = 195,
        Height = 45,
          Text = "Đổi mật khẩu",
         Font = new Font("Segoe UI", 11, FontStyle.Bold),
           BackColor = Color.FromArgb(255, 200, 30),
     ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
       Cursor = Cursors.Hand
     };
          btnForgotPassword.FlatAppearance.BorderSize = 0;
     btnForgotPassword.Click += (s, e) => ShowMessage("Chức năng đổi mật khẩu sẽ được cập nhật");
         btnForgotPassword.MouseEnter += (s, e) => btnForgotPassword.BackColor = Color.FromArgb(245, 190, 20);
        btnForgotPassword.MouseLeave += (s, e) => btnForgotPassword.BackColor = Color.FromArgb(255, 200, 30);
            pnlButtonContainer.Controls.Add(btnForgotPassword);

 btnResetPassword = new Button
  {
          Location = new Point(205, 0),
          Width = 195,
 Height = 45,
       Text = "Quên mật khẩu",
          Font = new Font("Segoe UI", 11, FontStyle.Bold),
      BackColor = Color.FromArgb(255, 120, 120),
          ForeColor = Color.White,
       FlatStyle = FlatStyle.Flat,
     Cursor = Cursors.Hand
  };
            btnResetPassword.FlatAppearance.BorderSize = 0;
       btnResetPassword.Click += (s, e) => ShowMessage("Vui lòng liên hệ quản trị viên để đặt lại mật khẩu");
        btnResetPassword.MouseEnter += (s, e) => btnResetPassword.BackColor = Color.FromArgb(245, 100, 100);
     btnResetPassword.MouseLeave += (s, e) => btnResetPassword.BackColor = Color.FromArgb(255, 120, 120);
    pnlButtonContainer.Controls.Add(btnResetPassword);

            pnlFormContainer.Controls.Add(pnlButtonContainer);

   pnlRightForm.Controls.Add(pnlFormContainer);
            pnlBackground.Controls.Add(pnlRightForm);
        }

        /// <summary>
        /// Toggle password visibility
        /// </summary>
        private void BtnTogglePassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtPassword.UseSystemPasswordChar = !isPasswordVisible;
            btnTogglePassword.Text = isPasswordVisible ? "🙈" : "👁️";
        }

        /// <summary>
        /// Handle login button click
        /// </summary>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            // Validate
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                ShowError("Vui lòng nhập tên đăng nhập!");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowError("Vui lòng nhập mật khẩu!");
                txtPassword.Focus();
                return;
            }

            // Perform authentication
            if (_authService != null)
            {
                PerformDatabaseAuthentication();
            }
            else
            {
                PerformBasicAuthentication();
            }
        }

        /// <summary>
        /// Database authentication
        /// </summary>
        private async void PerformDatabaseAuthentication()
        {
            try
            {
                btnLogin.Enabled = false;
                btnLogin.Text = "Đang kiểm tra...";

                var account = await _authService.AuthenticateAsync(txtUsername.Text, txtPassword.Text);

                if (account != null)
                {
                    if (chkRememberMe.Checked)
                        SaveCredentials(txtUsername.Text);
                    else
                        ClearSavedCredentials();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    ShowError("Tên đăng nhập hoặc mật khẩu không đúng!");
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                ShowError($"Lỗi: {ex.Message}");
                txtPassword.Clear();
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "Đăng nhập";
            }
        }

        /// <summary>
        /// Basic authentication
        /// </summary>
        private void PerformBasicAuthentication()
        {
            const string DEFAULT_USERNAME = "admin";
            const string DEFAULT_PASSWORD = "123456";

            if (txtUsername.Text.Length < 3)
            {
                ShowError("Tên đăng nhập phải >= 3 ký tự!");
                txtUsername.Focus();
                return;
            }

            if (txtPassword.Text.Length < 6)
            {
                ShowError("Mật khẩu phải >= 6 ký tự!");
                txtPassword.Focus();
                return;
            }

            if (txtUsername.Text == DEFAULT_USERNAME && txtPassword.Text == DEFAULT_PASSWORD)
            {
                if (chkRememberMe.Checked)
                    SaveCredentials(txtUsername.Text);
                else
                    ClearSavedCredentials();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ShowError("Tên đăng nhập hoặc mật khẩu không đúng!");
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        /// <summary>
        /// Show error message
        /// </summary>
        private void ShowError(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
        }

        /// <summary>
        /// Show message dialog
        /// </summary>
        private void ShowMessage(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Load remembered credentials
        /// </summary>
        private void LoadRememberedCredentials()
        {
            try
            {
                var regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\QuanLyKhachSan");
                if (regKey != null)
                {
                    string username = regKey.GetValue("Username")?.ToString() ?? "";
                    if (!string.IsNullOrEmpty(username))
                    {
                        txtUsername.Text = username;
                        chkRememberMe.Checked = true;
                        txtPassword.Focus();
                    }
                    regKey.Close();
                }
            }
            catch { }
        }

        /// <summary>
        /// Save credentials
        /// </summary>
        private void SaveCredentials(string username)
        {
            try
            {
                var regKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\QuanLyKhachSan");
                regKey.SetValue("Username", username);
                regKey.Close();
            }
            catch { }
        }

        /// <summary>
        /// Clear saved credentials
        /// </summary>
        private void ClearSavedCredentials()
        {
            try
            {
                var regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\QuanLyKhachSan", true);
                if (regKey != null)
                {
                    regKey.DeleteValue("Username", false);
                    regKey.Close();
                }
            }
            catch { }
        }
    }
}
