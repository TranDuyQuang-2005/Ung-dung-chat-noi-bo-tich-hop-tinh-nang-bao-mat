//namespace ChatClient.Forms
//{
//    partial class RegisterForm
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.lblTitle = new System.Windows.Forms.Label();
//            this.lblUser = new System.Windows.Forms.Label();
//            this.txtUsername = new System.Windows.Forms.TextBox();
//            this.lblPassword = new System.Windows.Forms.Label();
//            this.txtPassword = new System.Windows.Forms.TextBox();
//            this.lblConfirm = new System.Windows.Forms.Label();
//            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
//            this.lblEmail = new System.Windows.Forms.Label();
//            this.txtEmail = new System.Windows.Forms.TextBox();
//            this.lblHovaten = new System.Windows.Forms.Label();
//            this.txtHovaten = new System.Windows.Forms.TextBox();
//            this.lblSdt = new System.Windows.Forms.Label();
//            this.txtSdt = new System.Windows.Forms.TextBox();
//            this.lblClearance = new System.Windows.Forms.Label();
//            this.cbClearance = new System.Windows.Forms.ComboBox();
//            this.btnRegister = new System.Windows.Forms.Button();
//            this.btnCancel = new System.Windows.Forms.Button();
//            this.lblStatus = new System.Windows.Forms.Label();
//            this.SuspendLayout();
//            // 
//            // lblTitle
//            // 
//            this.lblTitle.AutoSize = true;
//            this.lblTitle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.lblTitle.Location = new System.Drawing.Point(100, 20);
//            this.lblTitle.Name = "lblTitle";
//            this.lblTitle.Size = new System.Drawing.Size(180, 18);
//            this.lblTitle.TabIndex = 0;
//            this.lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN MỚI";
//            // 
//            // lblUser
//            // 
//            this.lblUser.AutoSize = true;
//            this.lblUser.Location = new System.Drawing.Point(20, 60);
//            this.lblUser.Name = "lblUser";
//            this.lblUser.Size = new System.Drawing.Size(95, 15);
//            this.lblUser.TabIndex = 1;
//            this.lblUser.Text = "Tên đăng nhập:";
//            // 
//            // txtUsername
//            // 
//            this.txtUsername.Location = new System.Drawing.Point(150, 57);
//            this.txtUsername.Name = "txtUsername";
//            this.txtUsername.Size = new System.Drawing.Size(250, 23);
//            this.txtUsername.TabIndex = 2;
//            // 
//            // lblPassword
//            // 
//            this.lblPassword.AutoSize = true;
//            this.lblPassword.Location = new System.Drawing.Point(20, 100);
//            this.lblPassword.Name = "lblPassword";
//            this.lblPassword.Size = new System.Drawing.Size(60, 15);
//            this.lblPassword.TabIndex = 3;
//            this.lblPassword.Text = "Mật khẩu:";
//            // 
//            // txtPassword
//            // 
//            this.txtPassword.Location = new System.Drawing.Point(150, 97);
//            this.txtPassword.Name = "txtPassword";
//            this.txtPassword.PasswordChar = '*';
//            this.txtPassword.Size = new System.Drawing.Size(250, 23);
//            this.txtPassword.TabIndex = 4;
//            // 
//            // lblConfirm
//            // 
//            this.lblConfirm.AutoSize = true;
//            this.lblConfirm.Location = new System.Drawing.Point(20, 140);
//            this.lblConfirm.Name = "lblConfirm";
//            this.lblConfirm.Size = new System.Drawing.Size(108, 15);
//            this.lblConfirm.TabIndex = 5;
//            this.lblConfirm.Text = "Xác nhận mật khẩu:";
//            // 
//            // txtConfirmPassword
//            // 
//            this.txtConfirmPassword.Location = new System.Drawing.Point(150, 137);
//            this.txtConfirmPassword.Name = "txtConfirmPassword";
//            this.txtConfirmPassword.PasswordChar = '*';
//            this.txtConfirmPassword.Size = new System.Drawing.Size(250, 23);
//            this.txtConfirmPassword.TabIndex = 6;
//            // 
//            // lblEmail
//            // 
//            this.lblEmail.AutoSize = true;
//            this.lblEmail.Location = new System.Drawing.Point(20, 180);
//            this.lblEmail.Name = "lblEmail";
//            this.lblEmail.Size = new System.Drawing.Size(39, 15);
//            this.lblEmail.TabIndex = 7;
//            this.lblEmail.Text = "Email:";
//            // 
//            // txtEmail
//            // 
//            this.txtEmail.Location = new System.Drawing.Point(150, 177);
//            this.txtEmail.Name = "txtEmail";
//            this.txtEmail.Size = new System.Drawing.Size(250, 23);
//            this.txtEmail.TabIndex = 8;
//            // 
//            // lblHovaten
//            // 
//            this.lblHovaten.AutoSize = true;
//            this.lblHovaten.Location = new System.Drawing.Point(20, 220);
//            this.lblHovaten.Name = "lblHovaten";
//            this.lblHovaten.Size = new System.Drawing.Size(70, 15);
//            this.lblHovaten.TabIndex = 9;
//            this.lblHovaten.Text = "Họ và tên:";
//            // 
//            // txtHovaten
//            // 
//            this.txtHovaten.Location = new System.Drawing.Point(150, 217);
//            this.txtHovaten.Name = "txtHovaten";
//            this.txtHovaten.Size = new System.Drawing.Size(250, 23);
//            this.txtHovaten.TabIndex = 10;
//            // 
//            // lblSdt
//            // 
//            this.lblSdt.AutoSize = true;
//            this.lblSdt.Location = new System.Drawing.Point(20, 260);
//            this.lblSdt.Name = "lblSdt";
//            this.lblSdt.Size = new System.Drawing.Size(76, 15);
//            this.lblSdt.TabIndex = 11;
//            this.lblSdt.Text = "Số điện thoại:";
//            // 
//            // txtSdt
//            // 
//            this.txtSdt.Location = new System.Drawing.Point(150, 257);
//            this.txtSdt.Name = "txtSdt";
//            this.txtSdt.Size = new System.Drawing.Size(250, 23);
//            this.txtSdt.TabIndex = 12;
//            // 
//            // lblClearance
//            // 
//            this.lblClearance.AutoSize = true;
//            this.lblClearance.Location = new System.Drawing.Point(20, 300);
//            this.lblClearance.Name = "lblClearance";
//            this.lblClearance.Size = new System.Drawing.Size(95, 15);
//            this.lblClearance.TabIndex = 13;
//            this.lblClearance.Text = "Mức độ bảo mật:";
//            // 
//            // cbClearance
//            // 
//            this.cbClearance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.cbClearance.FormattingEnabled = true;
//            this.cbClearance.Items.AddRange(new object[] {
//            "1 - LOW",
//            "2 - MEDIUM"});
//            this.cbClearance.Location = new System.Drawing.Point(150, 297);
//            this.cbClearance.Name = "cbClearance";
//            this.cbClearance.Size = new System.Drawing.Size(250, 23);
//            this.cbClearance.TabIndex = 14;
//            // 
//            // btnRegister
//            // 
//            this.btnRegister.Location = new System.Drawing.Point(150, 340);
//            this.btnRegister.Name = "btnRegister";
//            this.btnRegister.Size = new System.Drawing.Size(100, 35);
//            this.btnRegister.TabIndex = 15;
//            this.btnRegister.Text = "Đăng ký";
//            this.btnRegister.UseVisualStyleBackColor = true;
//            // 
//            // btnCancel
//            // 
//            this.btnCancel.Location = new System.Drawing.Point(260, 340);
//            this.btnCancel.Name = "btnCancel";
//            this.btnCancel.Size = new System.Drawing.Size(100, 35);
//            this.btnCancel.TabIndex = 16;
//            this.btnCancel.Text = "Hủy";
//            this.btnCancel.UseVisualStyleBackColor = true;
//            // 
//            // lblStatus
//            // 
//            this.lblStatus.AutoSize = true;
//            this.lblStatus.ForeColor = System.Drawing.Color.Red;
//            this.lblStatus.Location = new System.Drawing.Point(20, 390);
//            this.lblStatus.Name = "lblStatus";
//            this.lblStatus.Size = new System.Drawing.Size(0, 15);
//            this.lblStatus.TabIndex = 17;
//            // 
//            // RegisterForm
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
//            this.ClientSize = new System.Drawing.Size(450, 460);
//            this.Controls.Add(this.lblStatus);
//            this.Controls.Add(this.btnCancel);
//            this.Controls.Add(this.btnRegister);
//            this.Controls.Add(this.cbClearance);
//            this.Controls.Add(this.lblClearance);
//            this.Controls.Add(this.txtSdt);
//            this.Controls.Add(this.lblSdt);
//            this.Controls.Add(this.txtEmail);
//            this.Controls.Add(this.lblEmail);
//            this.Controls.Add(this.txtHovaten);
//            this.Controls.Add(this.lblHovaten);
//            this.Controls.Add(this.txtConfirmPassword);
//            this.Controls.Add(this.lblConfirm);
//            this.Controls.Add(this.txtPassword);
//            this.Controls.Add(this.lblPassword);
//            this.Controls.Add(this.txtUsername);
//            this.Controls.Add(this.lblUser);
//            this.Controls.Add(this.lblTitle);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
//            this.MaximizeBox = false;
//            this.Name = "RegisterForm";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Đăng Ký Tài Khoản";
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Label lblTitle;
//        private System.Windows.Forms.Label lblUser;
//        private System.Windows.Forms.TextBox txtUsername;
//        private System.Windows.Forms.Label lblPassword;
//        private System.Windows.Forms.TextBox txtPassword;
//        private System.Windows.Forms.Label lblConfirm;
//        private System.Windows.Forms.TextBox txtConfirmPassword;
//        private System.Windows.Forms.Label lblEmail;
//        private System.Windows.Forms.TextBox txtEmail;
//        private System.Windows.Forms.Label lblHovaten;
//        private System.Windows.Forms.TextBox txtHovaten;
//        private System.Windows.Forms.Label lblSdt;
//        private System.Windows.Forms.TextBox txtSdt;
//        private System.Windows.Forms.Label lblClearance;
//        private System.Windows.Forms.ComboBox cbClearance;
//        private System.Windows.Forms.Button btnRegister;
//        private System.Windows.Forms.Button btnCancel;
//        private System.Windows.Forms.Label lblStatus;
//    }
//}


namespace ChatClient.Forms
{
    partial class RegisterForm
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
            pnlBottom = new Panel();
            pnlButtons = new Panel();
            btnCancel = new Button();
            btnRegister = new Button();
            pnlFormContainer = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblUser = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirm = new Label();
            txtConfirmPassword = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblHovaten = new Label();
            txtHovaten = new TextBox();
            lblSdt = new Label();
            txtSdt = new TextBox();
            lblClearance = new Label();
            cbClearance = new ComboBox();
            lblClearanceInfo = new Label();
            lblStatus = new Label();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlFormContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(500, 100);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Dock = DockStyle.Bottom;
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(200, 230, 255);
            lblSubtitle.Location = new Point(0, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Padding = new Padding(0, 0, 0, 10);
            lblSubtitle.Size = new Size(500, 40);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Tạo tài khoản mới để tham gia ứng dụng chat";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(0, 15, 0, 5);
            lblTitle.Size = new Size(500, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👤 Đăng Ký Tài Khoản";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(pnlBottom);
            pnlMain.Controls.Add(pnlFormContainer);
            pnlMain.Controls.Add(lblStatus);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 100);
            pnlMain.Margin = new Padding(3, 4, 3, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(20);
            pnlMain.Size = new Size(500, 500);
            pnlMain.TabIndex = 1;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(pnlButtons);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(20, 400);
            pnlBottom.Margin = new Padding(3, 4, 3, 4);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(460, 80);
            pnlBottom.TabIndex = 22;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Controls.Add(btnRegister);
            pnlButtons.Location = new Point(100, 15);
            pnlButtons.Margin = new Padding(3, 4, 3, 4);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(260, 50);
            pnlButtons.TabIndex = 19;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(108, 117, 125);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(134, 142, 150);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(140, 5);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "❌ Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(52, 152, 219);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 132, 73);
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 202, 106);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(0, 5);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 40);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "✅ Đăng ký";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // pnlFormContainer
            // 
            pnlFormContainer.Controls.Add(tableLayoutPanel1);
            pnlFormContainer.Dock = DockStyle.Fill;
            pnlFormContainer.Location = new Point(20, 36);
            pnlFormContainer.Margin = new Padding(3, 4, 3, 4);
            pnlFormContainer.Name = "pnlFormContainer";
            pnlFormContainer.Size = new Size(460, 444);
            pnlFormContainer.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(lblUser, 0, 0);
            tableLayoutPanel1.Controls.Add(txtUsername, 1, 0);
            tableLayoutPanel1.Controls.Add(lblPassword, 0, 1);
            tableLayoutPanel1.Controls.Add(txtPassword, 1, 1);
            tableLayoutPanel1.Controls.Add(lblConfirm, 0, 2);
            tableLayoutPanel1.Controls.Add(txtConfirmPassword, 1, 2);
            tableLayoutPanel1.Controls.Add(lblEmail, 0, 3);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 3);
            tableLayoutPanel1.Controls.Add(lblHovaten, 0, 4);
            tableLayoutPanel1.Controls.Add(txtHovaten, 1, 4);
            tableLayoutPanel1.Controls.Add(lblSdt, 0, 5);
            tableLayoutPanel1.Controls.Add(txtSdt, 1, 5);
            tableLayoutPanel1.Controls.Add(lblClearance, 0, 6);
            tableLayoutPanel1.Controls.Add(cbClearance, 1, 6);
            tableLayoutPanel1.Controls.Add(lblClearanceInfo, 0, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(460, 444);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUser.ForeColor = Color.FromArgb(52, 73, 94);
            lblUser.Location = new Point(3, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(155, 40);
            lblUser.TabIndex = 0;
            lblUser.Text = "👤 Tên đăng nhập";
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(164, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(293, 30);
            txtUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Dock = DockStyle.Fill;
            lblPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(52, 73, 94);
            lblPassword.Location = new Point(3, 40);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(155, 40);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "🔐 Mật khẩu";
            lblPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(164, 43);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(293, 30);
            txtPassword.TabIndex = 1;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Dock = DockStyle.Fill;
            lblConfirm.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblConfirm.ForeColor = Color.FromArgb(52, 73, 94);
            lblConfirm.Location = new Point(3, 80);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(155, 40);
            lblConfirm.TabIndex = 2;
            lblConfirm.Text = "🔑 Xác nhận MK";
            lblConfirm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Dock = DockStyle.Fill;
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.Location = new Point(164, 83);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.Size = new Size(293, 30);
            txtConfirmPassword.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(52, 73, 94);
            lblEmail.Location = new Point(3, 120);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(155, 40);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "📧 Email";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(164, 123);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(293, 30);
            txtEmail.TabIndex = 3;
            // 
            // lblHovaten
            // 
            lblHovaten.AutoSize = true;
            lblHovaten.Dock = DockStyle.Fill;
            lblHovaten.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblHovaten.ForeColor = Color.FromArgb(52, 73, 94);
            lblHovaten.Location = new Point(3, 160);
            lblHovaten.Name = "lblHovaten";
            lblHovaten.Size = new Size(155, 40);
            lblHovaten.TabIndex = 4;
            lblHovaten.Text = "👤 Họ và tên";
            lblHovaten.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHovaten
            // 
            txtHovaten.BorderStyle = BorderStyle.FixedSingle;
            txtHovaten.Dock = DockStyle.Fill;
            txtHovaten.Font = new Font("Segoe UI", 10F);
            txtHovaten.Location = new Point(164, 163);
            txtHovaten.Name = "txtHovaten";
            txtHovaten.Size = new Size(293, 30);
            txtHovaten.TabIndex = 4;
            // 
            // lblSdt
            // 
            lblSdt.AutoSize = true;
            lblSdt.Dock = DockStyle.Fill;
            lblSdt.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSdt.ForeColor = Color.FromArgb(52, 73, 94);
            lblSdt.Location = new Point(3, 200);
            lblSdt.Name = "lblSdt";
            lblSdt.Size = new Size(155, 40);
            lblSdt.TabIndex = 5;
            lblSdt.Text = "📞 Điện thoại";
            lblSdt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSdt
            // 
            txtSdt.BorderStyle = BorderStyle.FixedSingle;
            txtSdt.Dock = DockStyle.Fill;
            txtSdt.Font = new Font("Segoe UI", 10F);
            txtSdt.Location = new Point(164, 203);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(293, 30);
            txtSdt.TabIndex = 5;
            // 
            // lblClearance
            // 
            lblClearance.AutoSize = true;
            lblClearance.Dock = DockStyle.Fill;
            lblClearance.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblClearance.ForeColor = Color.FromArgb(52, 73, 94);
            lblClearance.Location = new Point(3, 240);
            lblClearance.Name = "lblClearance";
            lblClearance.Size = new Size(155, 40);
            lblClearance.TabIndex = 6;
            lblClearance.Text = "🔒 Mức độ bảo mật";
            lblClearance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbClearance
            // 
            cbClearance.Dock = DockStyle.Fill;
            cbClearance.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClearance.FlatStyle = FlatStyle.Flat;
            cbClearance.Font = new Font("Segoe UI", 10F);
            cbClearance.FormattingEnabled = true;
            cbClearance.Items.AddRange(new object[] { "1 - LOW: Truy cập cơ bản", "2 - MEDIUM: Truy cập tiêu chuẩn", "3 - HIGH: Truy cập đầy đủ" });
            cbClearance.Location = new Point(164, 243);
            cbClearance.Name = "cbClearance";
            cbClearance.Size = new Size(293, 31);
            cbClearance.TabIndex = 6;
            // 
            // lblClearanceInfo
            // 
            lblClearanceInfo.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblClearanceInfo, 2);
            lblClearanceInfo.Dock = DockStyle.Fill;
            lblClearanceInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblClearanceInfo.ForeColor = Color.FromArgb(108, 117, 125);
            lblClearanceInfo.Location = new Point(3, 280);
            lblClearanceInfo.Name = "lblClearanceInfo";
            lblClearanceInfo.Size = new Size(454, 164);
            lblClearanceInfo.TabIndex = 7;
            lblClearanceInfo.Text = "Mức độ bảo mật xác định quyền truy cập và tính năng bạn có thể sử dụng";
            lblClearanceInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Top;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(20, 20);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(460, 16);
            lblStatus.TabIndex = 20;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(500, 600);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimumSize = new Size(518, 647);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Ký Tài Khoản";
            pnlHeader.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            pnlFormContainer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlMain;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblUser;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirm;
        private TextBox txtConfirmPassword;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblHovaten;
        private TextBox txtHovaten;
        private Label lblSdt;
        private TextBox txtSdt;
        private Label lblClearance;
        private ComboBox cbClearance;
        private Panel pnlButtons;
        private Button btnCancel;
        private Button btnRegister;
        private Label lblStatus;
        private Panel pnlFormContainer;
        private Panel pnlBottom;
        private Label lblClearanceInfo;
    }
}