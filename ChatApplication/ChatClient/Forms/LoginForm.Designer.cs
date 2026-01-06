//namespace ChatClient.Forms
//{
//    partial class LoginForm
//    {
//        private System.ComponentModel.IContainer components = null;
//        private System.Windows.Forms.Label lblTitle;
//        private System.Windows.Forms.Label lblUsername;
//        private System.Windows.Forms.TextBox txtUsername;
//        private System.Windows.Forms.Label lblPassword;
//        private System.Windows.Forms.TextBox txtPassword;
//        private System.Windows.Forms.Label lblCaptcha;
//        private System.Windows.Forms.TextBox txtCaptcha;
//        private System.Windows.Forms.Button btnRefreshCaptcha;
//        private System.Windows.Forms.PictureBox picCaptcha;
//        private System.Windows.Forms.Button btnLogin;
//        private System.Windows.Forms.Label lblStatus;
//        private System.Windows.Forms.Panel pnlMain;
//        private System.Windows.Forms.Button btnRegister;
//        private System.Windows.Forms.Button btnForgotPassword;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            if (disposing && picCaptcha.Image != null)
//            {
//                picCaptcha.Image.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        private void InitializeComponent()
//        {
//            pnlMain = new Panel();
//            btnForgotPassword = new Button();
//            btnRegister = new Button();
//            lblStatus = new Label();
//            btnLogin = new Button();
//            picCaptcha = new PictureBox();
//            btnRefreshCaptcha = new Button();
//            txtCaptcha = new TextBox();
//            lblCaptcha = new Label();
//            lblPassword = new Label();
//            txtPassword = new TextBox();
//            lblUsername = new Label();
//            txtUsername = new TextBox();
//            lblTitle = new Label();
//            pnlMain.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)picCaptcha).BeginInit();
//            SuspendLayout();
//            // 
//            // pnlMain
//            // 
//            pnlMain.BackColor = Color.FromArgb(245, 247, 250);
//            pnlMain.Controls.Add(btnForgotPassword);
//            pnlMain.Controls.Add(btnRegister);
//            pnlMain.Controls.Add(lblStatus);
//            pnlMain.Controls.Add(btnLogin);
//            pnlMain.Controls.Add(picCaptcha);
//            pnlMain.Controls.Add(btnRefreshCaptcha);
//            pnlMain.Controls.Add(txtCaptcha);
//            pnlMain.Controls.Add(lblCaptcha);
//            pnlMain.Controls.Add(lblPassword);
//            pnlMain.Controls.Add(txtPassword);
//            pnlMain.Controls.Add(lblUsername);
//            pnlMain.Controls.Add(txtUsername);
//            pnlMain.Controls.Add(lblTitle);
//            pnlMain.Dock = DockStyle.Fill;
//            pnlMain.Location = new Point(0, 0);
//            pnlMain.Margin = new Padding(5, 6, 5, 6);
//            pnlMain.Name = "pnlMain";
//            pnlMain.Size = new Size(857, 900);
//            pnlMain.TabIndex = 0;
//            // 
//            // btnForgotPassword
//            // 
//            btnForgotPassword.BackColor = Color.FromArgb(108, 117, 125);
//            btnForgotPassword.Cursor = Cursors.Hand;
//            btnForgotPassword.FlatAppearance.BorderSize = 0;
//            btnForgotPassword.FlatStyle = FlatStyle.Flat;
//            btnForgotPassword.Font = new Font("Segoe UI", 10F);
//            btnForgotPassword.ForeColor = Color.White;
//            btnForgotPassword.Location = new Point(447, 764);
//            btnForgotPassword.Margin = new Padding(5, 6, 5, 6);
//            btnForgotPassword.Name = "btnForgotPassword";
//            btnForgotPassword.Size = new Size(240, 70);
//            btnForgotPassword.TabIndex = 11;
//            btnForgotPassword.Text = "🔑 Quên mật khẩu";
//            btnForgotPassword.UseVisualStyleBackColor = false;
//            // 
//            // btnRegister
//            // 
//            btnRegister.BackColor = Color.FromArgb(40, 167, 69);
//            btnRegister.Cursor = Cursors.Hand;
//            btnRegister.FlatAppearance.BorderSize = 0;
//            btnRegister.FlatStyle = FlatStyle.Flat;
//            btnRegister.Font = new Font("Segoe UI", 10F);
//            btnRegister.ForeColor = Color.White;
//            btnRegister.Location = new Point(172, 764);
//            btnRegister.Margin = new Padding(5, 6, 5, 6);
//            btnRegister.Name = "btnRegister";
//            btnRegister.Size = new Size(240, 70);
//            btnRegister.TabIndex = 10;
//            btnRegister.Text = "📝 Đăng ký";
//            btnRegister.UseVisualStyleBackColor = false;
//            // 
//            // lblStatus
//            // 
//            lblStatus.AutoSize = true;
//            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
//            lblStatus.ForeColor = Color.FromArgb(220, 53, 69);
//            lblStatus.Location = new Point(172, 636);
//            lblStatus.Margin = new Padding(5, 0, 5, 0);
//            lblStatus.Name = "lblStatus";
//            lblStatus.Size = new Size(0, 25);
//            lblStatus.TabIndex = 9;
//            // 
//            // btnLogin
//            // 
//            btnLogin.BackColor = Color.FromArgb(0, 132, 255);
//            btnLogin.Cursor = Cursors.Hand;
//            btnLogin.FlatAppearance.BorderSize = 0;
//            btnLogin.FlatStyle = FlatStyle.Flat;
//            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
//            btnLogin.ForeColor = Color.White;
//            btnLogin.Location = new Point(172, 534);
//            btnLogin.Margin = new Padding(5, 6, 5, 6);
//            btnLogin.Name = "btnLogin";
//            btnLogin.Size = new Size(515, 90);
//            btnLogin.TabIndex = 8;
//            btnLogin.Text = "🔐 ĐĂNG NHẬP";
//            btnLogin.UseVisualStyleBackColor = false;
//            // 
//            // picCaptcha
//            // 
//            picCaptcha.BorderStyle = BorderStyle.FixedSingle;
//            picCaptcha.Location = new Point(473, 408);
//            picCaptcha.Margin = new Padding(5, 6, 5, 6);
//            picCaptcha.Name = "picCaptcha";
//            picCaptcha.Size = new Size(212, 69);
//            picCaptcha.SizeMode = PictureBoxSizeMode.StretchImage;
//            picCaptcha.TabIndex = 7;
//            picCaptcha.TabStop = false;
//            // 
//            // btnRefreshCaptcha
//            // 
//            btnRefreshCaptcha.BackColor = Color.FromArgb(255, 193, 7);
//            btnRefreshCaptcha.Cursor = Cursors.Hand;
//            btnRefreshCaptcha.FlatAppearance.BorderSize = 0;
//            btnRefreshCaptcha.FlatStyle = FlatStyle.Flat;
//            btnRefreshCaptcha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
//            btnRefreshCaptcha.ForeColor = Color.Black;
//            btnRefreshCaptcha.Location = new Point(695, 408);
//            btnRefreshCaptcha.Margin = new Padding(5, 6, 5, 6);
//            btnRefreshCaptcha.Name = "btnRefreshCaptcha";
//            btnRefreshCaptcha.Size = new Size(73, 70);
//            btnRefreshCaptcha.TabIndex = 6;
//            btnRefreshCaptcha.Text = "🔄";
//            btnRefreshCaptcha.UseVisualStyleBackColor = false;
//            // 
//            // txtCaptcha
//            // 
//            txtCaptcha.BorderStyle = BorderStyle.FixedSingle;
//            txtCaptcha.Font = new Font("Arial", 11F);
//            txtCaptcha.Location = new Point(172, 420);
//            txtCaptcha.Margin = new Padding(5, 6, 5, 6);
//            txtCaptcha.Name = "txtCaptcha";
//            txtCaptcha.Size = new Size(219, 33);
//            txtCaptcha.TabIndex = 5;
//            // 
//            // lblCaptcha
//            // 
//            lblCaptcha.AutoSize = true;
//            lblCaptcha.Font = new Font("Arial", 10F);
//            lblCaptcha.ForeColor = Color.Gray;
//            lblCaptcha.Location = new Point(172, 380);
//            lblCaptcha.Margin = new Padding(5, 0, 5, 0);
//            lblCaptcha.Name = "lblCaptcha";
//            lblCaptcha.Size = new Size(197, 23);
//            lblCaptcha.TabIndex = 4;
//            lblCaptcha.Text = "🔐 Nhập mã captcha:";
//            // 
//            // lblPassword
//            // 
//            lblPassword.AutoSize = true;
//            lblPassword.Font = new Font("Segoe UI", 10F);
//            lblPassword.ForeColor = Color.FromArgb(60, 60, 60);
//            lblPassword.Location = new Point(172, 252);
//            lblPassword.Margin = new Padding(4, 0, 4, 0);
//            lblPassword.Name = "lblPassword";
//            lblPassword.Size = new Size(126, 28);
//            lblPassword.TabIndex = 12;
//            lblPassword.Text = "🔒 Mật khẩu";
//            // 
//            // txtPassword
//            // 
//            txtPassword.BorderStyle = BorderStyle.FixedSingle;
//            txtPassword.Font = new Font("Segoe UI", 11F);
//            txtPassword.Location = new Point(172, 288);
//            txtPassword.Margin = new Padding(5, 6, 5, 6);
//            txtPassword.Name = "txtPassword";
//            txtPassword.PasswordChar = '●';
//            txtPassword.Size = new Size(513, 37);
//            txtPassword.TabIndex = 2;
//            // 
//            // lblUsername
//            // 
//            lblUsername.AutoSize = true;
//            lblUsername.Font = new Font("Segoe UI", 10F);
//            lblUsername.ForeColor = Color.FromArgb(60, 60, 60);
//            lblUsername.Location = new Point(172, 162);
//            lblUsername.Margin = new Padding(4, 0, 4, 0);
//            lblUsername.Name = "lblUsername";
//            lblUsername.Size = new Size(172, 28);
//            lblUsername.TabIndex = 13;
//            lblUsername.Text = "👤 Tên đăng nhập";
//            // 
//            // txtUsername
//            // 
//            txtUsername.BorderStyle = BorderStyle.FixedSingle;
//            txtUsername.Font = new Font("Segoe UI", 11F);
//            txtUsername.Location = new Point(172, 198);
//            txtUsername.Margin = new Padding(5, 6, 5, 6);
//            txtUsername.Name = "txtUsername";
//            txtUsername.Size = new Size(513, 37);
//            txtUsername.TabIndex = 1;
//            // 
//            // lblTitle
//            // 
//            lblTitle.AutoSize = true;
//            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
//            lblTitle.ForeColor = Color.FromArgb(0, 102, 204);
//            lblTitle.Location = new Point(182, 79);
//            lblTitle.Margin = new Padding(5, 0, 5, 0);
//            lblTitle.Name = "lblTitle";
//            lblTitle.Size = new Size(379, 37);
//            lblTitle.TabIndex = 0;
//            lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
//            // 
//            // LoginForm
//            // 
//            AutoScaleDimensions = new SizeF(144F, 144F);
//            AutoScaleMode = AutoScaleMode.Dpi;
//            ClientSize = new Size(857, 900);
//            Controls.Add(pnlMain);
//            FormBorderStyle = FormBorderStyle.FixedDialog;
//            Margin = new Padding(5, 6, 5, 6);
//            MaximizeBox = false;
//            Name = "LoginForm";
//            StartPosition = FormStartPosition.CenterScreen;
//            Text = "Đăng nhập hệ thống";
//            pnlMain.ResumeLayout(false);
//            pnlMain.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)picCaptcha).EndInit();
//            ResumeLayout(false);
//        }

//        #endregion
//    }
//}


namespace ChatClient.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblCaptcha;
        private System.Windows.Forms.TextBox txtCaptcha;
        private System.Windows.Forms.Button btnRefreshCaptcha;
        private System.Windows.Forms.PictureBox picCaptcha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFormContainer;
        private System.Windows.Forms.Panel panelFooter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (disposing && picCaptcha.Image != null)
            {
                picCaptcha.Image.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlMain = new Panel();
            panelFormContainer = new Panel();
            panelFooter = new Panel();
            btnForgotPassword = new Button();
            btnRegister = new Button();
            lblStatus = new Label();
            btnLogin = new Button();
            picCaptcha = new PictureBox();
            btnRefreshCaptcha = new Button();
            txtCaptcha = new TextBox();
            lblCaptcha = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            panelHeader = new Panel();
            lblTitle = new Label();
            pnlMain.SuspendLayout();
            panelFormContainer.SuspendLayout();
            panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCaptcha).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(248, 250, 252);
            pnlMain.Controls.Add(panelFormContainer);
            pnlMain.Controls.Add(panelHeader);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(5, 6, 5, 6);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(600, 700);
            pnlMain.TabIndex = 0;
            // 
            // panelFormContainer
            // 
            panelFormContainer.Anchor = AnchorStyles.None;
            panelFormContainer.BackColor = Color.LightGray;
            panelFormContainer.BorderStyle = BorderStyle.FixedSingle;
            panelFormContainer.Controls.Add(panelFooter);
            panelFormContainer.Controls.Add(lblStatus);
            panelFormContainer.Controls.Add(btnLogin);
            panelFormContainer.Controls.Add(picCaptcha);
            panelFormContainer.Controls.Add(btnRefreshCaptcha);
            panelFormContainer.Controls.Add(txtCaptcha);
            panelFormContainer.Controls.Add(lblCaptcha);
            panelFormContainer.Controls.Add(lblPassword);
            panelFormContainer.Controls.Add(txtPassword);
            panelFormContainer.Controls.Add(lblUsername);
            panelFormContainer.Controls.Add(txtUsername);
            panelFormContainer.Location = new Point(25, 120);
            panelFormContainer.Margin = new Padding(4, 5, 4, 5);
            panelFormContainer.Name = "panelFormContainer";
            panelFormContainer.Size = new Size(550, 520);
            panelFormContainer.TabIndex = 1;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.Silver;
            panelFooter.Controls.Add(btnForgotPassword);
            panelFooter.Controls.Add(btnRegister);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 420);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(548, 98);
            panelFooter.TabIndex = 14;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.BackColor = Color.FromArgb(52, 152, 219);
            btnForgotPassword.Cursor = Cursors.Hand;
            btnForgotPassword.FlatAppearance.BorderSize = 0;
            btnForgotPassword.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 62, 80);
            btnForgotPassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 101, 115);
            btnForgotPassword.FlatStyle = FlatStyle.Flat;
            btnForgotPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnForgotPassword.ForeColor = Color.White;
            btnForgotPassword.Location = new Point(290, 20);
            btnForgotPassword.Margin = new Padding(4, 5, 4, 5);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(220, 60);
            btnForgotPassword.TabIndex = 11;
            btnForgotPassword.Text = "🔑 Quên mật khẩu";
            btnForgotPassword.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(52, 152, 219);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 163, 228);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(40, 20);
            btnRegister.Margin = new Padding(4, 5, 4, 5);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(220, 60);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "📝 Đăng ký tài khoản";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(231, 76, 60);
            lblStatus.Location = new Point(40, 360);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 21);
            lblStatus.TabIndex = 9;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(52, 152, 219);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 132, 73);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 202, 106);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(40, 280);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(470, 60);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "🔐 ĐĂNG NHẬP";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // picCaptcha
            // 
            picCaptcha.BackColor = Color.White;
            picCaptcha.BorderStyle = BorderStyle.FixedSingle;
            picCaptcha.Location = new Point(295, 185);
            picCaptcha.Margin = new Padding(4, 5, 4, 5);
            picCaptcha.Name = "picCaptcha";
            picCaptcha.Size = new Size(140, 50);
            picCaptcha.SizeMode = PictureBoxSizeMode.StretchImage;
            picCaptcha.TabIndex = 7;
            picCaptcha.TabStop = false;
            // 
            // btnRefreshCaptcha
            // 
            btnRefreshCaptcha.BackColor = Color.HotPink;
            btnRefreshCaptcha.Cursor = Cursors.Hand;
            btnRefreshCaptcha.FlatAppearance.BorderSize = 0;
            btnRefreshCaptcha.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 156, 18);
            btnRefreshCaptcha.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 176, 65);
            btnRefreshCaptcha.FlatStyle = FlatStyle.Flat;
            btnRefreshCaptcha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshCaptcha.ForeColor = Color.Black;
            btnRefreshCaptcha.Location = new Point(440, 185);
            btnRefreshCaptcha.Margin = new Padding(4, 5, 4, 5);
            btnRefreshCaptcha.Name = "btnRefreshCaptcha";
            btnRefreshCaptcha.Size = new Size(70, 50);
            btnRefreshCaptcha.TabIndex = 6;
            btnRefreshCaptcha.Text = "🔄";
            btnRefreshCaptcha.UseVisualStyleBackColor = false;
            // 
            // txtCaptcha
            // 
            txtCaptcha.BorderStyle = BorderStyle.FixedSingle;
            txtCaptcha.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCaptcha.Location = new Point(40, 195);
            txtCaptcha.Margin = new Padding(4, 5, 4, 5);
            txtCaptcha.Name = "txtCaptcha";
            txtCaptcha.Size = new Size(220, 32);
            txtCaptcha.TabIndex = 5;
            // 
            // lblCaptcha
            // 
            lblCaptcha.AutoSize = true;
            lblCaptcha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCaptcha.ForeColor = Color.FromArgb(52, 73, 94);
            lblCaptcha.Location = new Point(40, 155);
            lblCaptcha.Margin = new Padding(4, 0, 4, 0);
            lblCaptcha.Name = "lblCaptcha";
            lblCaptcha.Size = new Size(182, 23);
            lblCaptcha.TabIndex = 4;
            lblCaptcha.Text = "🔐 Nhập mã xác thực:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(52, 73, 94);
            lblPassword.Location = new Point(40, 85);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(120, 23);
            lblPassword.TabIndex = 12;
            lblPassword.Text = "🔒 Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(40, 115);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(470, 32);
            txtPassword.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(52, 73, 94);
            lblUsername.Location = new Point(40, 15);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(162, 23);
            lblUsername.TabIndex = 13;
            lblUsername.Text = "👤 Tên đăng nhập:";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(40, 45);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(470, 32);
            txtUsername.TabIndex = 1;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 5, 4, 5);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(600, 100);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(600, 100);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🔐 ĐĂNG NHẬP HỆ THỐNG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(600, 700);
            Controls.Add(pnlMain);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập hệ thống";
            pnlMain.ResumeLayout(false);
            panelFormContainer.ResumeLayout(false);
            panelFormContainer.PerformLayout();
            panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCaptcha).EndInit();
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}