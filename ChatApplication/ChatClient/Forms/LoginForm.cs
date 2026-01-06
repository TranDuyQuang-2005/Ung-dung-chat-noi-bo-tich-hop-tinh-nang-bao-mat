using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using ChatClient.Models;
using ChatClient.Services;
using ChatClient.Utils;

namespace ChatClient.Forms
{
    /// <summary>
    /// Form đăng nhập hoàn chỉnh.
    /// - Kết nối server qua TCP.
    /// - Gửi request Login với username/password.
    /// - Nếu thành công, mở ChatForm.
    /// - Có nút mở RegisterForm và ForgotPasswordForm.
    /// </summary>
    public partial class LoginForm : Form
    {
        private string _currentCaptcha = string.Empty;
        private CheckBox? chkRememberMe;
        private CheckBox? chkShowPassword;
        private string _loginStorePath = string.Empty;

        public LoginForm()
        {
            InitializeComponent();
            SetupModernUI();
            SetupEventHandlers();
            InitializeExtraControls();
            LoadRememberedCredentials();
            LoadCaptcha();
        }

        private void SetupModernUI()
        {
            // Các style đã được set trong Designer.cs
            // Method này chỉ để set các thuộc tính runtime nếu cần
            if (this.Text == "LoginForm")
                this.Text = "Đăng nhập - Chat Application";
        }

        private void SetupEventHandlers()
        {
            btnLogin.Click += async (_, _) => await BtnLogin_Click();
            btnRegister.Click += BtnRegister_Click;
            btnForgotPassword.Click += BtnForgotPassword_Click;
            btnRefreshCaptcha.Click += (_, _) => LoadCaptcha();

            txtPassword.KeyPress += (s, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    btnLogin.PerformClick();
                }
            };

            txtCaptcha.KeyPress += (s, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    btnLogin.PerformClick();
                }
            };
        }

        private void InitializeExtraControls()
        {
            var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dir = Path.Combine(appData, "ChatApplication");
            try { Directory.CreateDirectory(dir); } catch { }
            _loginStorePath = Path.Combine(dir, "login.json");

            chkRememberMe = new CheckBox
            {
                Text = "Ghi nhớ tôi",
                AutoSize = true
            };

            chkShowPassword = new CheckBox
            {
                Text = "Hiển thị mật khẩu",
                AutoSize = true
            };

            try
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            catch { }

            chkShowPassword.CheckedChanged += (_, _) =>
            {
                try { txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked; } catch { }
            };

            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    btnLogin.PerformClick();
                }
            };

            try
            {
                if (txtPassword != null)
                {
                    chkShowPassword.Location = new System.Drawing.Point(txtPassword.Right - 140, txtPassword.Top + 3);
                    chkShowPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                    this.Controls.Add(chkShowPassword);
                }

                if (btnLogin != null)
                {
                    chkRememberMe.Location = new System.Drawing.Point(btnLogin.Left, btnLogin.Bottom + 8);
                    chkRememberMe.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    this.Controls.Add(chkRememberMe);
                }
            }
            catch { }
        }

        private void LoadRememberedCredentials()
        {
            try
            {
                if (File.Exists(_loginStorePath))
                {
                    var json = File.ReadAllText(_loginStorePath);
                    var data = JsonSerializer.Deserialize<LoginData>(json);
                    if (data != null && !string.IsNullOrWhiteSpace(data.Username))
                    {
                        txtUsername.Text = data.Username;
                        if (chkRememberMe != null) chkRememberMe.Checked = true;
                    }
                }
            }
            catch { }
        }

        private void SaveOrClearRemembered(string username)
        {
            try
            {
                if (chkRememberMe != null && chkRememberMe.Checked)
                {
                    var json = JsonSerializer.Serialize(new LoginData { Username = username });
                    File.WriteAllText(_loginStorePath, json);
                }
                else
                {
                    if (File.Exists(_loginStorePath)) File.Delete(_loginStorePath);
                }
            }
            catch { }
        }

        private void LoadCaptcha()
        {
            _currentCaptcha = CaptchaHelper.GenerateCaptcha();
            var captchaImage = CaptchaHelper.GenerateCaptchaImage(_currentCaptcha);
            picCaptcha.Image?.Dispose();
            picCaptcha.Image = captchaImage;
            txtCaptcha.Clear();
        }

        private async Task BtnLogin_Click()
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();
            var captcha = txtCaptcha.Text.Trim();

            // --- VALIDATION ---
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblStatus.Text = "Vui lòng nhập đủ tên đăng nhập và mật khẩu.";
                return;
            }
            if (string.IsNullOrWhiteSpace(captcha))
            {
                lblStatus.Text = "Vui lòng nhập mã captcha.";
                return;
            }
            if (!CaptchaHelper.ValidateCaptcha(captcha))
            {
                lblStatus.Text = "Mã captcha không đúng. Vui lòng thử lại.";
                LoadCaptcha();
                return;
            }

            btnLogin.Enabled = false;
            lblStatus.Text = "Đang kết nối...";

            try
            {
                // ==== GIỮ SOCKET SAU LOGIN ====
                //var socketClient = new SocketClientService("127.0.0.1", 9000);
                //await socketClient.ConnectAsync();

                //var response = await socketClient.LoginAsync(username, password);
                AppState.Socket = new SocketClientService("127.0.0.1", 9000);
                await AppState.Socket.ConnectAsync();

                var response = await AppState.Socket.LoginAsync(username, password);


                if (response == null || !response.Success)
                {
                    var errorMessage = response?.Message ?? "Lỗi kết nối server.";

                    // --- BANNED BY ADMIN ---
                    if (errorMessage.Contains("banned") || errorMessage.Contains("has been banned"))
                    {
                        lblStatus.Text = "❌ Tài khoản đã bị cấm bởi Admin!";
                        MessageBox.Show(
                            "Tài khoản của bạn đã bị quản trị viên cấm.\nVui lòng liên hệ admin để biết thêm chi tiết.",
                            "Tài khoản bị cấm",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                        );
                        btnLogin.Enabled = true;
                        return;
                    }

                    // --- LOCKOUT 30 MIN ---
                    if (errorMessage.Contains("Tài khoản bị khóa") || errorMessage.Contains("khóa tạm thời"))
                    {
                        lblStatus.Text = "🔒 Tài khoản bị khóa tạm thời!";
                        MessageBox.Show(errorMessage, "Khóa tạm thời", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnLogin.Enabled = true;
                        return;
                    }

                    // --- OTP NOT VERIFIED ---
                    lblStatus.Text = errorMessage;

                    if (errorMessage.Contains("OTP") || errorMessage.Contains("verify") || errorMessage.Contains("xác minh"))
                    {
                        var result = MessageBox.Show(
                            $"{errorMessage}\n\nBạn có muốn xác minh OTP ngay bây giờ không?",
                            "Chưa xác minh OTP",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (result == DialogResult.Yes)
                        {
                            var verifyForm = new VerifyOtpForm(username);
                            verifyForm.ShowDialog();
                            btnLogin.Enabled = true;
                        }
                        return;
                    }

                    btnLogin.Enabled = true;
                    return;
                }

                // --- LOGIN SUCCESS ---
                lblStatus.Text = "✓ Đăng nhập thành công!";
                lblStatus.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69);

                var user = new User
                {
                    Matk = response.Matk ?? username,
                    Username = response.Username ?? username,
                    Password = password,
                    ClearanceLevel = response.ClearanceLevel,
                    Mavaitro = response.Mavaitro ?? "",
                    IsBannedGlobal = response.IsBannedGlobal,
                    IsOtpVerified = response.IsOtpVerified,
                    NgayTao = response.NgayTao,
                    LastLogin = response.LastLogin,
                    Email = response.Email ?? "",
                    Hovaten = response.Hovaten ?? "",
                    Sdt = response.Sdt ?? "",
                    PublicKey = response.PublicKey ?? ""
                };

                SaveOrClearRemembered(username);
                await Task.Delay(300);

                // === CHUYỂN SOCKET VÀ USER SANG CHAT FORM ===
                var chatForm = new ChatFormNew(user, AppState.Socket);

                chatForm.FormClosed += (s, args) =>
                {
                    if (chatForm.DialogResult == DialogResult.Cancel)
                    {
                        ResetLoginFormState();
                        this.Show();
                        txtUsername.Focus();
                    }
                    else
                    {
                        Close(); // exit app
                    }
                };

                chatForm.Show();
                Hide();
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Lỗi: {ex.Message}";
                btnLogin.Enabled = true;
            }
        }

        private void BtnRegister_Click(object? sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void BtnForgotPassword_Click(object? sender, EventArgs e)
        {
            var forgotForm = new ForgotPasswordForm();
            forgotForm.ShowDialog();
        }

        /// <summary>
        /// Reset toàn bộ trạng thái LoginForm sau khi đăng xuất
        /// </summary>
        private void ResetLoginFormState()
        {
            // Reset controls
            btnLogin.Enabled = true;
            txtPassword.Text = string.Empty;
            txtCaptcha.Text = string.Empty;
            lblStatus.Text = string.Empty;
            lblStatus.ForeColor = System.Drawing.Color.Red;
            
            // Reload captcha mới
            LoadCaptcha();
        }

        private class LoginData
        {
            public string Username { get; set; } = string.Empty;
        }
    }
}
