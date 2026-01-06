//namespace ChatClient.Forms
//{
//    partial class ForgotPasswordForm
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
//            this.lblDescription = new System.Windows.Forms.Label();
//            this.lblUser = new System.Windows.Forms.Label();
//            this.txtUsername = new System.Windows.Forms.TextBox();
//            this.lblEmail = new System.Windows.Forms.Label();
//            this.txtEmail = new System.Windows.Forms.TextBox();
//            this.btnSubmit = new System.Windows.Forms.Button();
//            this.btnCancel = new System.Windows.Forms.Button();
//            this.progressBar = new System.Windows.Forms.ProgressBar();
//            this.lblStatus = new System.Windows.Forms.Label();
//            this.panelDivider = new System.Windows.Forms.Panel();
//            this.lblBackToLogin = new System.Windows.Forms.Label();
//            this.lnkBackToLogin = new System.Windows.Forms.LinkLabel();
//            this.panelHeader.SuspendLayout();
//            this.panelMain.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // panelHeader
//            // 
//            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
//            this.panelHeader.Controls.Add(this.lblSubtitle);
//            this.panelHeader.Controls.Add(this.lblTitle);
//            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
//            this.panelHeader.Location = new System.Drawing.Point(0, 0);
//            this.panelHeader.Name = "panelHeader";
//            this.panelHeader.Size = new System.Drawing.Size(500, 100);
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
//            this.lblTitle.Size = new System.Drawing.Size(500, 60);
//            this.lblTitle.TabIndex = 0;
//            this.lblTitle.Text = "❓ Quên Mật Khẩu";
//            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            // 
//            // lblSubtitle
//            // 
//            this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Bottom;
//            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
//            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(230, 220, 255);
//            this.lblSubtitle.Location = new System.Drawing.Point(0, 60);
//            this.lblSubtitle.Name = "lblSubtitle";
//            this.lblSubtitle.Size = new System.Drawing.Size(500, 40);
//            this.lblSubtitle.TabIndex = 1;
//            this.lblSubtitle.Text = "Đặt lại mật khẩu của bạn";
//            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            // 
//            // panelMain
//            // 
//            this.panelMain.BackColor = System.Drawing.Color.White;
//            this.panelMain.Controls.Add(this.lnkBackToLogin);
//            this.panelMain.Controls.Add(this.lblBackToLogin);
//            this.panelMain.Controls.Add(this.panelDivider);
//            this.panelMain.Controls.Add(this.lblStatus);
//            this.panelMain.Controls.Add(this.progressBar);
//            this.panelMain.Controls.Add(this.btnCancel);
//            this.panelMain.Controls.Add(this.btnSubmit);
//            this.panelMain.Controls.Add(this.txtEmail);
//            this.panelMain.Controls.Add(this.lblEmail);
//            this.panelMain.Controls.Add(this.txtUsername);
//            this.panelMain.Controls.Add(this.lblUser);
//            this.panelMain.Controls.Add(this.lblDescription);
//            this.panelMain.Controls.Add(this.picIcon);
//            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.panelMain.Location = new System.Drawing.Point(0, 100);
//            this.panelMain.Name = "panelMain";
//            this.panelMain.Padding = new System.Windows.Forms.Padding(40, 30, 40, 30);
//            this.panelMain.Size = new System.Drawing.Size(500, 450);
//            this.panelMain.TabIndex = 1;
//            // 
//            // picIcon
//            // 
//            this.picIcon.Location = new System.Drawing.Point(200, 30);
//            this.picIcon.Name = "picIcon";
//            this.picIcon.Size = new System.Drawing.Size(100, 100);
//            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.picIcon.TabIndex = 0;
//            this.picIcon.TabStop = false;
//            // 
//            // lblDescription
//            // 
//            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F);
//            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
//            this.lblDescription.Location = new System.Drawing.Point(40, 140);
//            this.lblDescription.Name = "lblDescription";
//            this.lblDescription.Size = new System.Drawing.Size(420, 40);
//            this.lblDescription.TabIndex = 1;
//            this.lblDescription.Text = "Nhập tên đăng nhập và email của bạn.\nChúng tôi sẽ gửi mã OTP để đặt lại mật khẩu.";
//            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            // 
//            // lblUser
//            // 
//            this.lblUser.AutoSize = true;
//            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
//            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
//            this.lblUser.Location = new System.Drawing.Point(40, 190);
//            this.lblUser.Name = "lblUser";
//            this.lblUser.Size = new System.Drawing.Size(135, 19);
//            this.lblUser.TabIndex = 2;
//            this.lblUser.Text = "👤 Tên đăng nhập *";
//            // 
//            // txtUsername
//            // 
//            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
//            this.txtUsername.Location = new System.Drawing.Point(40, 215);
//            this.txtUsername.Name = "txtUsername";
//            this.txtUsername.Size = new System.Drawing.Size(420, 27);
//            this.txtUsername.TabIndex = 3;
//            // 
//            // lblEmail
//            // 
//            this.lblEmail.AutoSize = true;
//            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
//            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
//            this.lblEmail.Location = new System.Drawing.Point(40, 255);
//            this.lblEmail.Name = "lblEmail";
//            this.lblEmail.Size = new System.Drawing.Size(74, 19);
//            this.lblEmail.TabIndex = 4;
//            this.lblEmail.Text = "📧 Email *";
//            // 
//            // txtEmail
//            // 
//            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
//            this.txtEmail.Location = new System.Drawing.Point(40, 280);
//            this.txtEmail.Name = "txtEmail";
//            this.txtEmail.Size = new System.Drawing.Size(420, 27);
//            this.txtEmail.TabIndex = 5;
//            // 
//            // btnSubmit
//            // 
//            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
//            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
//            this.btnSubmit.ForeColor = System.Drawing.Color.White;
//            this.btnSubmit.Location = new System.Drawing.Point(40, 325);
//            this.btnSubmit.Name = "btnSubmit";
//            this.btnSubmit.Size = new System.Drawing.Size(200, 45);
//            this.btnSubmit.TabIndex = 6;
//            this.btnSubmit.Text = "📧 Gửi yêu cầu";
//            this.btnSubmit.UseVisualStyleBackColor = false;
//            // 
//            // btnCancel
//            // 
//            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
//            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
//            this.btnCancel.ForeColor = System.Drawing.Color.White;
//            this.btnCancel.Location = new System.Drawing.Point(260, 325);
//            this.btnCancel.Name = "btnCancel";
//            this.btnCancel.Size = new System.Drawing.Size(200, 45);
//            this.btnCancel.TabIndex = 7;
//            this.btnCancel.Text = "❌ Hủy";
//            this.btnCancel.UseVisualStyleBackColor = false;
//            // 
//            // progressBar
//            // 
//            this.progressBar.Location = new System.Drawing.Point(40, 375);
//            this.progressBar.Name = "progressBar";
//            this.progressBar.Size = new System.Drawing.Size(420, 3);
//            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
//            this.progressBar.TabIndex = 8;
//            this.progressBar.Visible = false;
//            // 
//            // lblStatus
//            // 
//            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblStatus.Location = new System.Drawing.Point(40, 383);
//            this.lblStatus.Name = "lblStatus";
//            this.lblStatus.Size = new System.Drawing.Size(420, 20);
//            this.lblStatus.TabIndex = 9;
//            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            // 
//            // panelDivider
//            // 
//            this.panelDivider.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
//            this.panelDivider.Location = new System.Drawing.Point(40, 410);
//            this.panelDivider.Name = "panelDivider";
//            this.panelDivider.Size = new System.Drawing.Size(420, 1);
//            this.panelDivider.TabIndex = 10;
//            // 
//            // lblBackToLogin
//            // 
//            this.lblBackToLogin.AutoSize = true;
//            this.lblBackToLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblBackToLogin.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
//            this.lblBackToLogin.Location = new System.Drawing.Point(150, 418);
//            this.lblBackToLogin.Name = "lblBackToLogin";
//            this.lblBackToLogin.Size = new System.Drawing.Size(103, 15);
//            this.lblBackToLogin.TabIndex = 11;
//            this.lblBackToLogin.Text = "Đã nhớ mật khẩu?";
//            // 
//            // lnkBackToLogin
//            // 
//            this.lnkBackToLogin.AutoSize = true;
//            this.lnkBackToLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
//            this.lnkBackToLogin.LinkColor = System.Drawing.Color.FromArgb(155, 89, 182);
//            this.lnkBackToLogin.Location = new System.Drawing.Point(259, 418);
//            this.lnkBackToLogin.Name = "lnkBackToLogin";
//            this.lnkBackToLogin.Size = new System.Drawing.Size(91, 15);
//            this.lnkBackToLogin.TabIndex = 12;
//            this.lnkBackToLogin.TabStop = true;
//            this.lnkBackToLogin.Text = "Quay lại đăng nhập";
//            // 
//            // ForgotPasswordForm
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
//            this.ClientSize = new System.Drawing.Size(500, 550);
//            this.Controls.Add(this.panelMain);
//            this.Controls.Add(this.panelHeader);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
//            this.MaximizeBox = false;
//            this.MinimizeBox = false;
//            this.Name = "ForgotPasswordForm";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Quên Mật Khẩu - Chat Nội Bộ";
//            this.panelHeader.ResumeLayout(false);
//            this.panelMain.ResumeLayout(false);
//            this.panelMain.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
//            this.ResumeLayout(false);
//        }

//        #endregion

//        private System.Windows.Forms.Panel panelHeader;
//        private System.Windows.Forms.Label lblTitle;
//        private System.Windows.Forms.Label lblSubtitle;
//        private System.Windows.Forms.Panel panelMain;
//        private System.Windows.Forms.PictureBox picIcon;
//        private System.Windows.Forms.Label lblDescription;
//        private System.Windows.Forms.Label lblUser;
//        private System.Windows.Forms.TextBox txtUsername;
//        private System.Windows.Forms.Label lblEmail;
//        private System.Windows.Forms.TextBox txtEmail;
//        private System.Windows.Forms.Button btnSubmit;
//        private System.Windows.Forms.Button btnCancel;
//        private System.Windows.Forms.ProgressBar progressBar;
//        private System.Windows.Forms.Label lblStatus;
//        private System.Windows.Forms.Panel panelDivider;
//        private System.Windows.Forms.Label lblBackToLogin;
//        private System.Windows.Forms.LinkLabel lnkBackToLogin;
//    }
//}

namespace ChatClient.Forms
{
    partial class ForgotPasswordForm
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
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlMain = new Panel();
            lnkBackToLogin = new LinkLabel();
            lblBackToLogin = new Label();
            pnlDivider = new Panel();
            lblStatus = new Label();
            progressBar = new ProgressBar();
            btnCancel = new Button();
            btnSubmit = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtUsername = new TextBox();
            lblUser = new Label();
            lblDescription = new Label();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2, 2, 2, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(400, 64);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Dock = DockStyle.Bottom;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 230, 255);
            lblSubtitle.Location = new Point(0, 40);
            lblSubtitle.Margin = new Padding(2, 0, 2, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(400, 24);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Đặt lại mật khẩu của bạn";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🔐 Quên Mật Khẩu";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(lnkBackToLogin);
            pnlMain.Controls.Add(lblBackToLogin);
            pnlMain.Controls.Add(pnlDivider);
            pnlMain.Controls.Add(lblStatus);
            pnlMain.Controls.Add(progressBar);
            pnlMain.Controls.Add(btnCancel);
            pnlMain.Controls.Add(btnSubmit);
            pnlMain.Controls.Add(txtEmail);
            pnlMain.Controls.Add(lblEmail);
            pnlMain.Controls.Add(txtUsername);
            pnlMain.Controls.Add(lblUser);
            pnlMain.Controls.Add(lblDescription);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 64);
            pnlMain.Margin = new Padding(2, 2, 2, 2);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(32, 24, 32, 24);
            pnlMain.Size = new Size(400, 296);
            pnlMain.TabIndex = 1;
            // 
            // lnkBackToLogin
            // 
            lnkBackToLogin.ActiveLinkColor = Color.FromArgb(41, 128, 185);
            lnkBackToLogin.AutoSize = true;
            lnkBackToLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lnkBackToLogin.LinkColor = Color.FromArgb(41, 128, 185);
            lnkBackToLogin.Location = new Point(144, 232);
            lnkBackToLogin.Margin = new Padding(2, 0, 2, 0);
            lnkBackToLogin.Name = "lnkBackToLogin";
            lnkBackToLogin.Size = new Size(143, 20);
            lnkBackToLogin.TabIndex = 12;
            lnkBackToLogin.TabStop = true;
            lnkBackToLogin.Text = "Quay lại đăng nhập";
            // 
            // lblBackToLogin
            // 
            lblBackToLogin.AutoSize = true;
            lblBackToLogin.Font = new Font("Segoe UI", 9F);
            lblBackToLogin.ForeColor = Color.FromArgb(127, 140, 141);
            lblBackToLogin.Location = new Point(32, 232);
            lblBackToLogin.Margin = new Padding(2, 0, 2, 0);
            lblBackToLogin.Name = "lblBackToLogin";
            lblBackToLogin.Size = new Size(129, 20);
            lblBackToLogin.TabIndex = 11;
            lblBackToLogin.Text = "Đã nhớ mật khẩu?";
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(220, 220, 220);
            pnlDivider.Location = new Point(32, 224);
            pnlDivider.Margin = new Padding(2, 2, 2, 2);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(336, 1);
            pnlDivider.TabIndex = 10;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.Location = new Point(32, 200);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(336, 20);
            lblStatus.TabIndex = 9;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(32, 196);
            progressBar.Margin = new Padding(2, 2, 2, 2);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(336, 2);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 8;
            progressBar.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(108, 117, 125);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(134, 142, 150);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(208, 160);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 32);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "❌ Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(52, 152, 219);
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 132, 73);
            btnSubmit.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 202, 106);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(32, 160);
            btnSubmit.Margin = new Padding(2, 2, 2, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(160, 32);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "📧 Gửi yêu cầu";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(32, 124);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(336, 30);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(52, 73, 94);
            lblEmail.Location = new Point(32, 104);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(92, 23);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "📧 Email *";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(32, 72);
            txtUsername.Margin = new Padding(2, 2, 2, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(336, 30);
            txtUsername.TabIndex = 3;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUser.ForeColor = Color.FromArgb(52, 73, 94);
            lblUser.Location = new Point(32, 52);
            lblUser.Margin = new Padding(2, 0, 2, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(165, 23);
            lblUser.TabIndex = 2;
            lblUser.Text = "👤 Tên đăng nhập *";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.ForeColor = Color.FromArgb(100, 100, 100);
            lblDescription.Location = new Point(32, 24);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(336, 24);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Nhập tên đăng nhập và email của bạn";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 360);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(404, 369);
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quên Mật Khẩu";
            pnlHeader.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlMain;
        private Label lblDescription;
        private Label lblUser;
        private TextBox txtUsername;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnSubmit;
        private Button btnCancel;
        private ProgressBar progressBar;
        private Label lblStatus;
        private Panel pnlDivider;
        private Label lblBackToLogin;
        private LinkLabel lnkBackToLogin;
    }
}