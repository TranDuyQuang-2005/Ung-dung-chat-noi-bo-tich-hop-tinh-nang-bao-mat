//namespace ChatClient.Forms
//{
//    partial class MembersDialog
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
//            lstMembers = new System.Windows.Forms.ListView();
//            colUsername = new System.Windows.Forms.ColumnHeader();
//            colEmail = new System.Windows.Forms.ColumnHeader();
//            colRole = new System.Windows.Forms.ColumnHeader();
//            colBanStatus = new System.Windows.Forms.ColumnHeader();
//            colJoinedDate = new System.Windows.Forms.ColumnHeader();
//            btnAddMember = new System.Windows.Forms.Button();
//            btnRemoveMember = new System.Windows.Forms.Button();
//            btnBanMember = new System.Windows.Forms.Button();
//            btnUnbanMember = new System.Windows.Forms.Button();
//            btnClose = new System.Windows.Forms.Button();
//            lblStatus = new System.Windows.Forms.Label();
//            lblTitle = new System.Windows.Forms.Label();
//            SuspendLayout();
//            // 
//            // lstMembers
//            // 
//            lstMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { colUsername, colEmail, colRole, colBanStatus, colJoinedDate });
//            lstMembers.FullRowSelect = true;
//            lstMembers.GridLines = true;
//            lstMembers.Location = new System.Drawing.Point(20, 70);
//            lstMembers.MultiSelect = false;
//            lstMembers.Name = "lstMembers";
//            lstMembers.Size = new System.Drawing.Size(760, 450);
//            lstMembers.TabIndex = 0;
//            lstMembers.UseCompatibleStateImageBehavior = false;
//            lstMembers.View = System.Windows.Forms.View.Details;
//            // 
//            // colUsername
//            // 
//            colUsername.Text = "Người dùng";
//            colUsername.Width = 150;
//            // 
//            // colEmail
//            // 
//            colEmail.Text = "Email";
//            colEmail.Width = 180;
//            // 
//            // colRole
//            // 
//            colRole.Text = "Vai trò";
//            colRole.Width = 120;
//            // 
//            // colBanStatus
//            // 
//            colBanStatus.Text = "Trạng thái";
//            colBanStatus.Width = 120;
//            // 
//            // colJoinedDate
//            // 
//            colJoinedDate.Text = "Ngày tham gia";
//            colJoinedDate.Width = 140;
//            // 
//            // btnAddMember
//            // 
//            btnAddMember.Location = new System.Drawing.Point(20, 540);
//            btnAddMember.Name = "btnAddMember";
//            btnAddMember.Size = new System.Drawing.Size(130, 40);
//            btnAddMember.TabIndex = 1;
//            btnAddMember.Text = "➕ Thêm";
//            btnAddMember.UseVisualStyleBackColor = true;
//            // 
//            // btnRemoveMember
//            // 
//            btnRemoveMember.Enabled = false;
//            btnRemoveMember.Location = new System.Drawing.Point(160, 540);
//            btnRemoveMember.Name = "btnRemoveMember";
//            btnRemoveMember.Size = new System.Drawing.Size(130, 40);
//            btnRemoveMember.TabIndex = 2;
//            btnRemoveMember.Text = "❌ Xóa";
//            btnRemoveMember.UseVisualStyleBackColor = true;
//            // 
//            // btnBanMember
//            // 
//            btnBanMember.Enabled = false;
//            btnBanMember.Location = new System.Drawing.Point(300, 540);
//            btnBanMember.Name = "btnBanMember";
//            btnBanMember.Size = new System.Drawing.Size(130, 40);
//            btnBanMember.TabIndex = 3;
//            btnBanMember.Text = "🔇 Tắt tiếng";
//            btnBanMember.UseVisualStyleBackColor = true;
//            // 
//            // btnUnbanMember
//            // 
//            btnUnbanMember.Enabled = false;
//            btnUnbanMember.Location = new System.Drawing.Point(440, 540);
//            btnUnbanMember.Name = "btnUnbanMember";
//            btnUnbanMember.Size = new System.Drawing.Size(130, 40);
//            btnUnbanMember.TabIndex = 4;
//            btnUnbanMember.Text = "🔊 Bỏ tắt tiếng";
//            btnUnbanMember.UseVisualStyleBackColor = true;
//            // 
//            // btnClose
//            // 
//            btnClose.Location = new System.Drawing.Point(650, 540);
//            btnClose.Name = "btnClose";
//            btnClose.Size = new System.Drawing.Size(130, 40);
//            btnClose.TabIndex = 5;
//            btnClose.Text = "Đóng";
//            btnClose.UseVisualStyleBackColor = true;
//            // 
//            // lblStatus
//            // 
//            lblStatus.AutoSize = true;
//            lblStatus.Location = new System.Drawing.Point(20, 595);
//            lblStatus.Name = "lblStatus";
//            lblStatus.Size = new System.Drawing.Size(0, 20);
//            lblStatus.TabIndex = 6;
//            // 
//            // lblTitle
//            // 
//            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
//            lblTitle.ForeColor = System.Drawing.Color.FromArgb(28, 30, 33);
//            lblTitle.Location = new System.Drawing.Point(20, 15);
//            lblTitle.Name = "lblTitle";
//            lblTitle.Size = new System.Drawing.Size(760, 40);
//            lblTitle.TabIndex = 7;
//            lblTitle.Text = "👥 Quản Lý Thành Viên";
//            // 
//            // MembersDialog
//            // 
//            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
//            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            ClientSize = new System.Drawing.Size(800, 630);
//            Controls.Add(lblTitle);
//            Controls.Add(lblStatus);
//            Controls.Add(btnClose);
//            Controls.Add(btnUnbanMember);
//            Controls.Add(btnBanMember);
//            Controls.Add(btnRemoveMember);
//            Controls.Add(btnAddMember);
//            Controls.Add(lstMembers);
//            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
//            MaximizeBox = false;
//            MinimizeBox = false;
//            Name = "MembersDialog";
//            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
//            Text = "Quản lý thành viên";
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private System.Windows.Forms.ListView lstMembers;
//        private System.Windows.Forms.ColumnHeader colUsername;
//        private System.Windows.Forms.ColumnHeader colEmail;
//        private System.Windows.Forms.ColumnHeader colRole;
//        private System.Windows.Forms.ColumnHeader colBanStatus;
//        private System.Windows.Forms.ColumnHeader colJoinedDate;
//        private System.Windows.Forms.Button btnAddMember;
//        private System.Windows.Forms.Button btnRemoveMember;
//        private System.Windows.Forms.Button btnBanMember;
//        private System.Windows.Forms.Button btnUnbanMember;
//        private System.Windows.Forms.Button btnClose;
//        private System.Windows.Forms.Label lblStatus;
//        private System.Windows.Forms.Label lblTitle;
//    }
//}


namespace ChatClient.Forms
{
    partial class MembersDialog
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
            lblTitle = new Label();
            pnlContent = new Panel();
            lstMembers = new ListView();
            colUsername = new ColumnHeader();
            colEmail = new ColumnHeader();
            colRole = new ColumnHeader();
            colBanStatus = new ColumnHeader();
            colJoinedDate = new ColumnHeader();
            lblStatus = new Label();
            pnlButtons = new Panel();
            btnClose = new Button();
            btnUnbanMember = new Button();
            btnBanMember = new Button();
            btnRemoveMember = new Button();
            btnAddMember = new Button();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(16, 0, 0, 0);
            pnlHeader.Size = new Size(640, 48);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(16, 0);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(624, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👥 Quản Lý Thành Viên";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Controls.Add(lstMembers);
            pnlContent.Controls.Add(lblStatus);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 48);
            pnlContent.Margin = new Padding(2);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(16, 16, 16, 0);
            pnlContent.Size = new Size(640, 376);
            pnlContent.TabIndex = 1;
            // 
            // lstMembers
            // 
            lstMembers.BackColor = Color.White;
            lstMembers.BorderStyle = BorderStyle.FixedSingle;
            lstMembers.Columns.AddRange(new ColumnHeader[] { colUsername, colEmail, colRole, colBanStatus, colJoinedDate });
            lstMembers.Dock = DockStyle.Fill;
            lstMembers.Font = new Font("Segoe UI", 10F);
            lstMembers.FullRowSelect = true;
            lstMembers.GridLines = true;
            lstMembers.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstMembers.Location = new Point(16, 16);
            lstMembers.Margin = new Padding(2);
            lstMembers.MultiSelect = false;
            lstMembers.Name = "lstMembers";
            lstMembers.Size = new Size(608, 336);
            lstMembers.TabIndex = 0;
            lstMembers.UseCompatibleStateImageBehavior = false;
            lstMembers.View = View.Details;
            // 
            // colUsername
            // 
            colUsername.Text = "Người dùng";
            colUsername.Width = 150;
            // 
            // colEmail
            // 
            colEmail.Text = "Email";
            colEmail.Width = 180;
            // 
            // colRole
            // 
            colRole.Text = "Vai trò";
            colRole.Width = 100;
            // 
            // colBanStatus
            // 
            colBanStatus.Text = "Trạng thái";
            colBanStatus.Width = 100;
            // 
            // colJoinedDate
            // 
            colJoinedDate.Text = "Ngày tham gia";
            colJoinedDate.Width = 120;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Bottom;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.Location = new Point(16, 352);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(608, 24);
            lblStatus.TabIndex = 1;
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(248, 250, 252);
            pnlButtons.Controls.Add(btnClose);
            pnlButtons.Controls.Add(btnUnbanMember);
            pnlButtons.Controls.Add(btnBanMember);
            pnlButtons.Controls.Add(btnRemoveMember);
            pnlButtons.Controls.Add(btnAddMember);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 424);
            pnlButtons.Margin = new Padding(2);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(16, 12, 16, 12);
            pnlButtons.Size = new Size(640, 80);
            pnlButtons.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(108, 117, 125);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(134, 142, 150);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(534, 12);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 32);
            btnClose.TabIndex = 4;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnUnbanMember
            // 
            btnUnbanMember.BackColor = Color.FromArgb(52, 152, 219);
            btnUnbanMember.Cursor = Cursors.Hand;
            btnUnbanMember.Enabled = false;
            btnUnbanMember.FlatAppearance.BorderSize = 0;
            btnUnbanMember.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 160, 133);
            btnUnbanMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 201, 176);
            btnUnbanMember.FlatStyle = FlatStyle.Flat;
            btnUnbanMember.Font = new Font("Segoe UI", 9F);
            btnUnbanMember.ForeColor = Color.White;
            btnUnbanMember.Location = new Point(370, 12);
            btnUnbanMember.Margin = new Padding(2);
            btnUnbanMember.Name = "btnUnbanMember";
            btnUnbanMember.Size = new Size(135, 32);
            btnUnbanMember.TabIndex = 3;
            btnUnbanMember.Text = "🔊 Bỏ Cấm Chat";
            btnUnbanMember.UseVisualStyleBackColor = false;
            // 
            // btnBanMember
            // 
            btnBanMember.BackColor = Color.FromArgb(52, 152, 219);
            btnBanMember.Cursor = Cursors.Hand;
            btnBanMember.Enabled = false;
            btnBanMember.FlatAppearance.BorderSize = 0;
            btnBanMember.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 156, 18);
            btnBanMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 176, 65);
            btnBanMember.FlatStyle = FlatStyle.Flat;
            btnBanMember.Font = new Font("Segoe UI", 9F);
            btnBanMember.ForeColor = Color.White;
            btnBanMember.Location = new Point(252, 12);
            btnBanMember.Margin = new Padding(2);
            btnBanMember.Name = "btnBanMember";
            btnBanMember.Size = new Size(110, 32);
            btnBanMember.TabIndex = 2;
            btnBanMember.Text = "🔇 Cấm Chat";
            btnBanMember.UseVisualStyleBackColor = false;
            // 
            // btnRemoveMember
            // 
            btnRemoveMember.BackColor = Color.FromArgb(52, 152, 219);
            btnRemoveMember.Cursor = Cursors.Hand;
            btnRemoveMember.Enabled = false;
            btnRemoveMember.FlatAppearance.BorderSize = 0;
            btnRemoveMember.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            btnRemoveMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 108, 93);
            btnRemoveMember.FlatStyle = FlatStyle.Flat;
            btnRemoveMember.Font = new Font("Segoe UI", 9F);
            btnRemoveMember.ForeColor = Color.White;
            btnRemoveMember.Location = new Point(134, 12);
            btnRemoveMember.Margin = new Padding(2);
            btnRemoveMember.Name = "btnRemoveMember";
            btnRemoveMember.Size = new Size(110, 32);
            btnRemoveMember.TabIndex = 1;
            btnRemoveMember.Text = "❌ Xóa";
            btnRemoveMember.UseVisualStyleBackColor = false;
            // 
            // btnAddMember
            // 
            btnAddMember.BackColor = Color.FromArgb(52, 152, 219);
            btnAddMember.Cursor = Cursors.Hand;
            btnAddMember.FlatAppearance.BorderSize = 0;
            btnAddMember.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 132, 73);
            btnAddMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 202, 106);
            btnAddMember.FlatStyle = FlatStyle.Flat;
            btnAddMember.Font = new Font("Segoe UI", 9F);
            btnAddMember.ForeColor = Color.White;
            btnAddMember.Location = new Point(16, 12);
            btnAddMember.Margin = new Padding(2);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(110, 32);
            btnAddMember.TabIndex = 0;
            btnAddMember.Text = "➕ Thêm";
            btnAddMember.UseVisualStyleBackColor = false;
            // 
            // MembersDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(640, 504);
            Controls.Add(pnlContent);
            Controls.Add(pnlButtons);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(656, 543);
            Name = "MembersDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý thành viên";
            pnlHeader.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlContent;
        private ListView lstMembers;
        private ColumnHeader colUsername;
        private ColumnHeader colEmail;
        private ColumnHeader colRole;
        private ColumnHeader colBanStatus;
        private ColumnHeader colJoinedDate;
        private Label lblStatus;
        private Panel pnlButtons;
        private Button btnAddMember;
        private Button btnRemoveMember;
        private Button btnBanMember;
        private Button btnUnbanMember;
        private Button btnClose;
    }
}