//namespace ChatClient.Forms
//{
//    partial class ResetPasswordForm
//    {
//        private System.ComponentModel.IContainer components = null;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        private void InitializeComponent()
//        {
//            this.panelHeader = new System.Windows.Forms.Panel();
//            this.lblTitle = new System.Windows.Forms.Label();
//            this.lblSubtitle = new System.Windows.Forms.Label();
//            this.panelMain = new System.Windows.Forms.Panel();
//            this.picIcon = new System.Windows.Forms.PictureBox();
//            this.lblUser = new System.Windows.Forms.Label();
//            this.lblDescription = new System.Windows.Forms.Label();
//            this.lblOtp = new System.Windows.Forms.Label();
//            this.txtOtp = new System.Windows.Forms.TextBox();
//            this.lblOtpHint = new System.Windows.Forms.Label();
//            this.lblNewPassword = new System.Windows.Forms.Label();
//            this.panelNewPassword = new System.Windows.Forms.Panel();
//            this.txtNewPassword = new System.Windows.Forms.TextBox();
//            this.btnTogglePassword = new System.Windows.Forms.Button();
//            this.lblConfirmPassword = new System.Windows.Forms.Label();
//            this.panelConfirmPassword = new System.Windows.Forms.Panel();
//            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
//            this.btnToggleConfirm = new System.Windows.Forms.Button();
//            this.lblPasswordMatch = new System.Windows.Forms.Label();
//            this.btnReset = new System.Windows.Forms.Button();
//            this.btnCancel = new System.Windows.Forms.Button();
//            this.progressBar = new System.Windows.Forms.ProgressBar();
//            this.lblStatus = new System.Windows.Forms.Label();
//            this.panelDivider = new System.Windows.Forms.Panel();
//            this.lblPasswordRules = new System.Windows.Forms.Label();
//            this.panelHeader.SuspendLayout();
//            this.panelMain.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
//            this.panelNewPassword.SuspendLayout();
//            this.panelConfirmPassword.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // panelHeader
//            // 
//            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
//            this.panelHeader.Controls.Add(this.lblSubtitle);
//            this.panelHeader.Controls.Add(this.lblTitle);
//            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
//            this.panelHeader.Location = new System.Drawing.Point(0, 0);
//            this.panelHeader.Name = "panelHeader";
//            this.panelHeader.Size = new System.Drawing.Size(550, 100);
//            this.panelHeader.TabIndex = 0;
//            // 
//            // lblTitle
//            // 
//            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
//            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
//            this.lblTitle.ForeColor = System.Drawing.Color.White;
//            this.lblTitle.Location = new System.Drawing.Point(0, 0);
//            this.lblTitle.Name = "lblTitle";
//            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
//            this.lblTitle.Size = new System.Drawing.Size(550, 60);
//            this.lblTitle.TabIndex = 0;
//            this.lblTitle.Text = "🔐 Đặt Lại Mật Khẩu";
//            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            // 
//            // lblSubtitle
//            // 
//            this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Bottom;
//            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
//            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(230, 240, 255);
//            this.lblSubtitle.Location = new System.Drawing.Point(0, 60);
//            this.lblSubtitle.Name = "lblSubtitle";
//            this.lblSubtitle.Size = new System.Drawing.Size(550, 40);
//            this.lblSubtitle.TabIndex = 1;
//            this.lblSubtitle.Text = "Nhập mã OTP và mật khẩu mới";
//            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            // 
//            // panelMain
//            // 
//            this.panelMain.AutoScroll = true;
//            this.panelMain.BackColor = System.Drawing.Color.White;
//            this.panelMain.Controls.Add(this.lblPasswordRules);
//            this.panelMain.Controls.Add(this.panelDivider);
//            this.panelMain.Controls.Add(this.lblStatus);
//            this.panelMain.Controls.Add(this.progressBar);
//            this.panelMain.Controls.Add(this.btnCancel);
//            this.panelMain.Controls.Add(this.btnReset);
//            this.panelMain.Controls.Add(this.lblPasswordMatch);
//            this.panelMain.Controls.Add(this.panelConfirmPassword);
//            this.panelMain.Controls.Add(this.lblConfirmPassword);
//            this.panelMain.Controls.Add(this.panelNewPassword);
//            this.panelMain.Controls.Add(this.lblNewPassword);
//            this.panelMain.Controls.Add(this.lblOtpHint);
//            this.panelMain.Controls.Add(this.txtOtp);
//            this.panelMain.Controls.Add(this.lblOtp);
//            this.panelMain.Controls.Add(this.lblDescription);
//            this.panelMain.Controls.Add(this.lblUser);
//            this.panelMain.Controls.Add(this.picIcon);
//            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.panelMain.Location = new System.Drawing.Point(0, 100);
//            this.panelMain.Name = "panelMain";
//            this.panelMain.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
//            this.panelMain.Size = new System.Drawing.Size(550, 600);
//            this.panelMain.TabIndex = 1;
//            // 
//            // picIcon
//            // 
//            this.picIcon.Location = new System.Drawing.Point(225, 20);
//            this.picIcon.Name = "picIcon";
//            this.picIcon.Size = new System.Drawing.Size(100, 100);
//            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.picIcon.TabIndex = 0;
//            this.picIcon.TabStop = false;
//            // 
//            // lblUser
//            // 
//            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
//            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
//            this.lblUser.Location = new System.Drawing.Point(40, 130);
//            this.lblUser.Name = "lblUser";
//            this.lblUser.Size = new System.Drawing.Size(470, 25);
//            this.lblUser.TabIndex = 1;
//            this.lblUser.Text = "👤 Tài khoản: username";
//            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            // 
//            // lblDescription
//            // 
//            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
//            this.lblDescription.Location = new System.Drawing.Point(40, 160);
//            this.lblDescription.Name = "lblDescription";
//            this.lblDescription.Size = new System.Drawing.Size(470, 20);
//            this.lblDescription.TabIndex = 2;
//            this.lblDescription.Text = "Vui lòng nhập mã OTP từ email và đặt mật khẩu mới";
//            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            // 
//            // lblOtp
//            // 
//            this.lblOtp.AutoSize = true;
//            this.lblOtp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
//            this.lblOtp.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
//            this.lblOtp.Location = new System.Drawing.Point(40, 195);
//            this.lblOtp.Name = "lblOtp";
//            this.lblOtp.Size = new System.Drawing.Size(161, 19);
//            this.lblOtp.TabIndex = 3;
//            this.lblOtp.Text = "📧 Mã OTP (6 chữ số) *";
//            // 
//            // txtOtp
//            // 
//            this.txtOtp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.txtOtp.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
//            this.txtOtp.Location = new System.Drawing.Point(40, 220);
//            this.txtOtp.MaxLength = 6;
//            this.txtOtp.Name = "txtOtp";
//            this.txtOtp.Size = new System.Drawing.Size(470, 29);
//            this.txtOtp.TabIndex = 4;
//            this.txtOtp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
//            // 
//            // lblOtpHint
//            // 
//            this.lblOtpHint.AutoSize = true;
//            this.lblOtpHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
//            this.lblOtpHint.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
//            this.lblOtpHint.Location = new System.Drawing.Point(40, 252);
//            this.lblOtpHint.Name = "lblOtpHint";
//            this.lblOtpHint.Size = new System.Drawing.Size(183, 13);
//            this.lblOtpHint.TabIndex = 5;
//            this.lblOtpHint.Text = "💡 Kiểm tra email để lấy mã OTP";
//            // 
//            // lblNewPassword
//            // 
//            this.lblNewPassword.AutoSize = true;
//            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
//            this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
//            this.lblNewPassword.Location = new System.Drawing.Point(40, 280);
//            this.lblNewPassword.Name = "lblNewPassword";
//            this.lblNewPassword.Size = new System.Drawing.Size(124, 19);
//            this.lblNewPassword.TabIndex = 6;
//            this.lblNewPassword.Text = "🔒 Mật khẩu mới *";
//            // 
//            // panelNewPassword
//            // 
//            this.panelNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.panelNewPassword.Controls.Add(this.btnTogglePassword);
//            this.panelNewPassword.Controls.Add(this.txtNewPassword);
//            this.panelNewPassword.Location = new System.Drawing.Point(40, 305);
//            this.panelNewPassword.Name = "panelNewPassword";
//            this.panelNewPassword.Size = new System.Drawing.Size(470, 32);
//            this.panelNewPassword.TabIndex = 7;
//            // 
//            // txtNewPassword
//            // 
//            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
//            this.txtNewPassword.Location = new System.Drawing.Point(5, 6);
//            this.txtNewPassword.Name = "txtNewPassword";
//            this.txtNewPassword.PasswordChar = '●';
//            this.txtNewPassword.Size = new System.Drawing.Size(420, 20);
//            this.txtNewPassword.TabIndex = 0;
//            // 
//            // btnTogglePassword
//            // 
//            this.btnTogglePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnTogglePassword.Font = new System.Drawing.Font("Segoe UI", 10F);
//            this.btnTogglePassword.Location = new System.Drawing.Point(430, 0);
//            this.btnTogglePassword.Name = "btnTogglePassword";
//            this.btnTogglePassword.Size = new System.Drawing.Size(38, 30);
//            this.btnTogglePassword.TabIndex = 1;
//            this.btnTogglePassword.Text = "👁️";
//            this.btnTogglePassword.UseVisualStyleBackColor = true;
//            // 
//            // lblConfirmPassword
//            // 
//            this.lblConfirmPassword.AutoSize = true;
//            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
//            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
//            this.lblConfirmPassword.Location = new System.Drawing.Point(40, 350);
//            this.lblConfirmPassword.Name = "lblConfirmPassword";
//            this.lblConfirmPassword.Size = new System.Drawing.Size(182, 19);
//            this.lblConfirmPassword.TabIndex = 8;
//            this.lblConfirmPassword.Text = "🔐 Xác nhận mật khẩu mới *";
//            // 
//            // panelConfirmPassword
//            // 
//            this.panelConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.panelConfirmPassword.Controls.Add(this.btnToggleConfirm);
//            this.panelConfirmPassword.Controls.Add(this.txtConfirmPassword);
//            this.panelConfirmPassword.Location = new System.Drawing.Point(40, 375);
//            this.panelConfirmPassword.Name = "panelConfirmPassword";
//            this.panelConfirmPassword.Size = new System.Drawing.Size(470, 32);
//            this.panelConfirmPassword.TabIndex = 9;
//            // 
//            // txtConfirmPassword
//            // 
//            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
//            this.txtConfirmPassword.Location = new System.Drawing.Point(5, 6);
//            this.txtConfirmPassword.Name = "txtConfirmPassword";
//            this.txtConfirmPassword.PasswordChar = '●';
//            this.txtConfirmPassword.Size = new System.Drawing.Size(420, 20);
//            this.txtConfirmPassword.TabIndex = 0;
//            // 
//            // btnToggleConfirm
//            // 
//            this.btnToggleConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnToggleConfirm.Font = new System.Drawing.Font("Segoe UI", 10F);
//            this.btnToggleConfirm.Location = new System.Drawing.Point(430, 0);
//            this.btnToggleConfirm.Name = "btnToggleConfirm";
//            this.btnToggleConfirm.Size = new System.Drawing.Size(38, 30);
//            this.btnToggleConfirm.TabIndex = 1;
//            this.btnToggleConfirm.Text = "👁️";
//            this.btnToggleConfirm.UseVisualStyleBackColor = true;
//            // 
//            // lblPasswordMatch
//            // 
//            this.lblPasswordMatch.AutoSize = true;
//            this.lblPasswordMatch.Font = new System.Drawing.Font("Segoe UI", 8.5F);
//            this.lblPasswordMatch.Location = new System.Drawing.Point(40, 410);
//            this.lblPasswordMatch.Name = "lblPasswordMatch";
//            this.lblPasswordMatch.Size = new System.Drawing.Size(0, 15);
//            this.lblPasswordMatch.TabIndex = 10;
//            // 
//            // btnReset
//            // 
//            this.btnReset.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
//            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
//            this.btnReset.ForeColor = System.Drawing.Color.White;
//            this.btnReset.Location = new System.Drawing.Point(40, 440);
//            this.btnReset.Name = "btnReset";
//            this.btnReset.Size = new System.Drawing.Size(220, 45);
//            this.btnReset.TabIndex = 11;
//            this.btnReset.Text = "🔐 Đặt lại mật khẩu";
//            this.btnReset.UseVisualStyleBackColor = false;
//            // 
//            // btnCancel
//            // 
//            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
//            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
//            this.btnCancel.ForeColor = System.Drawing.Color.White;
//            this.btnCancel.Location = new System.Drawing.Point(290, 440);
//            this.btnCancel.Name = "btnCancel";
//            this.btnCancel.Size = new System.Drawing.Size(220, 45);
//            this.btnCancel.TabIndex = 12;
//            this.btnCancel.Text = "❌ Hủy";
//            this.btnCancel.UseVisualStyleBackColor = false;
//            // 
//            // progressBar
//            // 
//            this.progressBar.Location = new System.Drawing.Point(40, 495);
//            this.progressBar.Name = "progressBar";
//            this.progressBar.Size = new System.Drawing.Size(470, 3);
//            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
//            this.progressBar.TabIndex = 13;
//            this.progressBar.Visible = false;
//            // 
//            // lblStatus
//            // 
//            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblStatus.Location = new System.Drawing.Point(40, 503);
//            this.lblStatus.Name = "lblStatus";
//            this.lblStatus.Size = new System.Drawing.Size(470, 20);
//            this.lblStatus.TabIndex = 14;
//            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            // 
//            // panelDivider
//            // 
//            this.panelDivider.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
//            this.panelDivider.Location = new System.Drawing.Point(40, 533);
//            this.panelDivider.Name = "panelDivider";
//            this.panelDivider.Size = new System.Drawing.Size(470, 1);
//            this.panelDivider.TabIndex = 15;
//            // 
//            // lblPasswordRules
//            // 
//            this.lblPasswordRules.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
//            this.lblPasswordRules.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
//            this.lblPasswordRules.Location = new System.Drawing.Point(40, 540);
//            this.lblPasswordRules.Name = "lblPasswordRules";
//            this.lblPasswordRules.Size = new System.Drawing.Size(470, 40);
//            this.lblPasswordRules.TabIndex = 16;
//            this.lblPasswordRules.Text = "ℹ️ Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường và số";
//            this.lblPasswordRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            // 
//            // ResetPasswordForm
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
//            this.ClientSize = new System.Drawing.Size(550, 700);
//            this.Controls.Add(this.panelMain);
//            this.Controls.Add(this.panelHeader);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
//            this.MaximizeBox = false;
//            this.MinimizeBox = false;
//            this.Name = "ResetPasswordForm";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Đặt Lại Mật Khẩu - Chat Nội Bộ";
//            this.panelHeader.ResumeLayout(false);
//            this.panelMain.ResumeLayout(false);
//            this.panelMain.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
//            this.panelNewPassword.ResumeLayout(false);
//            this.panelNewPassword.PerformLayout();
//            this.panelConfirmPassword.ResumeLayout(false);
//            this.panelConfirmPassword.PerformLayout();
//            this.ResumeLayout(false);
//        }

//        #endregion

//        private System.Windows.Forms.Panel panelHeader;
//        private System.Windows.Forms.Label lblTitle;
//        private System.Windows.Forms.Label lblSubtitle;
//        private System.Windows.Forms.Panel panelMain;
//        private System.Windows.Forms.PictureBox picIcon;
//        private System.Windows.Forms.Label lblUser;
//        private System.Windows.Forms.Label lblDescription;
//        private System.Windows.Forms.Label lblOtp;
//        private System.Windows.Forms.TextBox txtOtp;
//        private System.Windows.Forms.Label lblOtpHint;
//        private System.Windows.Forms.Label lblNewPassword;
//        private System.Windows.Forms.Panel panelNewPassword;
//        private System.Windows.Forms.TextBox txtNewPassword;
//        private System.Windows.Forms.Button btnTogglePassword;
//        private System.Windows.Forms.Label lblConfirmPassword;
//        private System.Windows.Forms.Panel panelConfirmPassword;
//        private System.Windows.Forms.TextBox txtConfirmPassword;
//        private System.Windows.Forms.Button btnToggleConfirm;
//        private System.Windows.Forms.Label lblPasswordMatch;
//        private System.Windows.Forms.Button btnReset;
//        private System.Windows.Forms.Button btnCancel;
//        private System.Windows.Forms.ProgressBar progressBar;
//        private System.Windows.Forms.Label lblStatus;
//        private System.Windows.Forms.Panel panelDivider;
//        private System.Windows.Forms.Label lblPasswordRules;
//    }
//}

namespace ChatClient.Forms
{
    partial class ResetPasswordForm
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
            panelHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelMain = new Panel();
            lblPasswordRules = new Label();
            panelDivider = new Panel();
            lblStatus = new Label();
            progressBar = new ProgressBar();
            panelButtons = new Panel();
            btnCancel = new Button();
            btnReset = new Button();
            panelConfirmPassword = new Panel();
            btnToggleConfirm = new Button();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            panelNewPassword = new Panel();
            btnTogglePassword = new Button();
            txtNewPassword = new TextBox();
            lblNewPassword = new Label();
            lblOtpHint = new Label();
            txtOtp = new TextBox();
            lblOtp = new Label();
            lblDescription = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            panelConfirmPassword.SuspendLayout();
            panelNewPassword.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(52, 152, 219);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(600, 125);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.FromArgb(41, 128, 185);
            lblSubtitle.Dock = DockStyle.Bottom;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(230, 240, 255);
            lblSubtitle.Location = new Point(0, 75);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Padding = new Padding(0, 0, 0, 6);
            lblSubtitle.Size = new Size(600, 50);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Nhập mã OTP và mật khẩu mới";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(41, 128, 185);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(0, 19, 0, 6);
            lblTitle.Size = new Size(600, 75);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🔐 Đặt Lại Mật Khẩu";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(lblPasswordRules);
            panelMain.Controls.Add(panelDivider);
            panelMain.Controls.Add(lblStatus);
            panelMain.Controls.Add(progressBar);
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(panelConfirmPassword);
            panelMain.Controls.Add(lblConfirmPassword);
            panelMain.Controls.Add(panelNewPassword);
            panelMain.Controls.Add(lblNewPassword);
            panelMain.Controls.Add(lblOtpHint);
            panelMain.Controls.Add(txtOtp);
            panelMain.Controls.Add(lblOtp);
            panelMain.Controls.Add(lblDescription);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 125);
            panelMain.Margin = new Padding(4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(38, 25, 38, 25);
            panelMain.Size = new Size(600, 490);
            panelMain.TabIndex = 1;
            // 
            // lblPasswordRules
            // 
            lblPasswordRules.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblPasswordRules.ForeColor = Color.FromArgb(127, 140, 141);
            lblPasswordRules.Location = new Point(43, 415);
            lblPasswordRules.Margin = new Padding(4, 0, 4, 0);
            lblPasswordRules.Name = "lblPasswordRules";
            lblPasswordRules.Size = new Size(525, 50);
            lblPasswordRules.TabIndex = 16;
            lblPasswordRules.Text = "ℹ️ Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường và số";
            lblPasswordRules.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDivider
            // 
            panelDivider.BackColor = Color.FromArgb(220, 220, 220);
            panelDivider.Location = new Point(41, 475);
            panelDivider.Margin = new Padding(4);
            panelDivider.Name = "panelDivider";
            panelDivider.Size = new Size(525, 1);
            panelDivider.TabIndex = 15;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.FromArgb(231, 76, 60);
            lblStatus.Location = new Point(38, 475);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(525, 25);
            lblStatus.TabIndex = 14;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(43, 384);
            progressBar.Margin = new Padding(4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(525, 4);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 13;
            progressBar.Visible = false;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Controls.Add(btnReset);
            panelButtons.Location = new Point(42, 314);
            panelButtons.Margin = new Padding(4);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(525, 62);
            panelButtons.TabIndex = 17;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(149, 165, 166);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(127, 140, 141);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 184, 185);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(275, 6);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(250, 50);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "❌ Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(52, 152, 219);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 172, 239);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(0, 6);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(250, 50);
            btnReset.TabIndex = 11;
            btnReset.Text = "🔐 Đặt lại mật khẩu";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // panelConfirmPassword
            // 
            panelConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            panelConfirmPassword.Controls.Add(btnToggleConfirm);
            panelConfirmPassword.Controls.Add(txtConfirmPassword);
            panelConfirmPassword.Location = new Point(42, 250);
            panelConfirmPassword.Margin = new Padding(4);
            panelConfirmPassword.Name = "panelConfirmPassword";
            panelConfirmPassword.Size = new Size(524, 40);
            panelConfirmPassword.TabIndex = 9;
            // 
            // btnToggleConfirm
            // 
            btnToggleConfirm.BackColor = Color.White;
            btnToggleConfirm.Cursor = Cursors.Hand;
            btnToggleConfirm.FlatAppearance.BorderSize = 0;
            btnToggleConfirm.FlatStyle = FlatStyle.Flat;
            btnToggleConfirm.Font = new Font("Segoe UI", 10F);
            btnToggleConfirm.Location = new Point(475, 0);
            btnToggleConfirm.Margin = new Padding(4);
            btnToggleConfirm.Name = "btnToggleConfirm";
            btnToggleConfirm.Size = new Size(48, 38);
            btnToggleConfirm.TabIndex = 1;
            btnToggleConfirm.Text = "👁️";
            btnToggleConfirm.UseVisualStyleBackColor = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("Segoe UI", 11F);
            txtConfirmPassword.Location = new Point(4, 6);
            txtConfirmPassword.Margin = new Padding(4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.PlaceholderText = "Nhập lại mật khẩu mới";
            txtConfirmPassword.Size = new Size(456, 25);
            txtConfirmPassword.TabIndex = 0;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(52, 73, 94);
            lblConfirmPassword.Location = new Point(46, 224);
            lblConfirmPassword.Margin = new Padding(4, 0, 4, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(242, 23);
            lblConfirmPassword.TabIndex = 8;
            lblConfirmPassword.Text = "🔐 Xác nhận mật khẩu mới *";
            // 
            // panelNewPassword
            // 
            panelNewPassword.BorderStyle = BorderStyle.FixedSingle;
            panelNewPassword.Controls.Add(btnTogglePassword);
            panelNewPassword.Controls.Add(txtNewPassword);
            panelNewPassword.Location = new Point(43, 163);
            panelNewPassword.Margin = new Padding(4);
            panelNewPassword.Name = "panelNewPassword";
            panelNewPassword.Size = new Size(524, 40);
            panelNewPassword.TabIndex = 7;
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.BackColor = Color.White;
            btnTogglePassword.Cursor = Cursors.Hand;
            btnTogglePassword.FlatAppearance.BorderSize = 0;
            btnTogglePassword.FlatStyle = FlatStyle.Flat;
            btnTogglePassword.Font = new Font("Segoe UI", 10F);
            btnTogglePassword.Location = new Point(475, 0);
            btnTogglePassword.Margin = new Padding(4);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(48, 38);
            btnTogglePassword.TabIndex = 1;
            btnTogglePassword.Text = "👁️";
            btnTogglePassword.UseVisualStyleBackColor = false;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderStyle = BorderStyle.None;
            txtNewPassword.Font = new Font("Segoe UI", 11F);
            txtNewPassword.Location = new Point(7, 6);
            txtNewPassword.Margin = new Padding(4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '●';
            txtNewPassword.PlaceholderText = "Nhập mật khẩu mới";
            txtNewPassword.Size = new Size(456, 25);
            txtNewPassword.TabIndex = 0;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNewPassword.ForeColor = Color.FromArgb(52, 73, 94);
            lblNewPassword.Location = new Point(51, 140);
            lblNewPassword.Margin = new Padding(4, 0, 4, 0);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(165, 23);
            lblNewPassword.TabIndex = 6;
            lblNewPassword.Text = "🔒 Mật khẩu mới *";
            // 
            // lblOtpHint
            // 
            lblOtpHint.AutoSize = true;
            lblOtpHint.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblOtpHint.ForeColor = Color.FromArgb(127, 140, 141);
            lblOtpHint.Location = new Point(51, 107);
            lblOtpHint.Margin = new Padding(4, 0, 4, 0);
            lblOtpHint.Name = "lblOtpHint";
            lblOtpHint.Size = new Size(220, 19);
            lblOtpHint.TabIndex = 5;
            lblOtpHint.Text = "💡 Kiểm tra email để lấy mã OTP";
            // 
            // txtOtp
            // 
            txtOtp.BorderStyle = BorderStyle.FixedSingle;
            txtOtp.Font = new Font("Consolas", 14F, FontStyle.Bold);
            txtOtp.Location = new Point(43, 77);
            txtOtp.Margin = new Padding(4);
            txtOtp.MaxLength = 6;
            txtOtp.Name = "txtOtp";
            txtOtp.PlaceholderText = "123456";
            txtOtp.Size = new Size(524, 35);
            txtOtp.TabIndex = 4;
            txtOtp.TextAlign = HorizontalAlignment.Center;
            // 
            // lblOtp
            // 
            lblOtp.AutoSize = true;
            lblOtp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOtp.ForeColor = Color.FromArgb(52, 73, 94);
            lblOtp.Location = new Point(42, 50);
            lblOtp.Margin = new Padding(4, 0, 4, 0);
            lblOtp.Name = "lblOtp";
            lblOtp.Size = new Size(197, 23);
            lblOtp.TabIndex = 3;
            lblOtp.Text = "📧 Mã OTP (6 chữ số) *";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 9F);
            lblDescription.ForeColor = Color.FromArgb(127, 140, 141);
            lblDescription.Location = new Point(42, 25);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(525, 25);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Vui lòng nhập mã OTP từ email và đặt mật khẩu mới";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(600, 615);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResetPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt Lại Mật Khẩu";
            panelHeader.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelConfirmPassword.ResumeLayout(false);
            panelConfirmPassword.PerformLayout();
            panelNewPassword.ResumeLayout(false);
            panelNewPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblOtp;
        private System.Windows.Forms.TextBox txtOtp;
        private System.Windows.Forms.Label lblOtpHint;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Panel panelNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnTogglePassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Panel panelConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnToggleConfirm;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panelDivider;
        private System.Windows.Forms.Label lblPasswordRules;
        private System.Windows.Forms.Panel panelButtons;
    }
}