


//namespace ChatServer.Forms
//{
//    partial class AdminPanelForm
//    {
//        private System.ComponentModel.IContainer components = null;
//        private System.Windows.Forms.TabControl tabControl;
//        private System.Windows.Forms.TabPage tabUsers;
//        private System.Windows.Forms.TabPage tabConversations;
//        private System.Windows.Forms.TabPage tabMessages;
//        private System.Windows.Forms.TabPage tabAuditLogs;
//        //them sau

//        private System.Windows.Forms.DataGridView dgvUsers;
//        private System.Windows.Forms.DataGridView dgvConversations;
//        private System.Windows.Forms.DataGridView dgvMessages;
//        private System.Windows.Forms.DataGridView dgvAuditLogs;
//        private System.Windows.Forms.Button btnRefreshUsers;
//        private System.Windows.Forms.Button btnCreateUser;
//        private System.Windows.Forms.Button btnEditUser;
//        private System.Windows.Forms.Button btnDeleteUser;
//        private System.Windows.Forms.Button btnBanUser;
//        private System.Windows.Forms.Button btnUnbanUser;
//        private System.Windows.Forms.Button btnUnlockAccount;
//        private System.Windows.Forms.Button btnRefreshConversations;
//        private System.Windows.Forms.Button btnDeleteConversation;
//        private System.Windows.Forms.Button btnViewMessages;
//        private System.Windows.Forms.Button btnRefreshMessages;
//        private System.Windows.Forms.Button btnDeleteMessage;
//        private System.Windows.Forms.Button btnRefreshLogs;
//        private System.Windows.Forms.Label lblCurrentUser;
//        private System.Windows.Forms.Button btnPolicyManagement;
//        private System.Windows.Forms.Panel panelHeader;
//        private System.Windows.Forms.Panel panelButtonContainer;
//        private System.Windows.Forms.Panel panelFooter;
//        private System.Windows.Forms.Label lblFooter;
//        private System.Windows.Forms.Panel panelDataGridContainer;

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
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
//            tabControl = new System.Windows.Forms.TabControl();
//            tabUsers = new System.Windows.Forms.TabPage();
//            panelDataGridContainer = new System.Windows.Forms.Panel();
//            dgvUsers = new System.Windows.Forms.DataGridView();
//            panelButtonContainer = new System.Windows.Forms.Panel();
//            btnRefreshUsers = new System.Windows.Forms.Button();
//            btnCreateUser = new System.Windows.Forms.Button();
//            btnEditUser = new System.Windows.Forms.Button();
//            btnDeleteUser = new System.Windows.Forms.Button();
//            btnBanUser = new System.Windows.Forms.Button();
//            btnUnbanUser = new System.Windows.Forms.Button();
//            btnUnlockAccount = new System.Windows.Forms.Button();
//            tabConversations = new System.Windows.Forms.TabPage();
//            panelDataGridContainer2 = new System.Windows.Forms.Panel();
//            dgvConversations = new System.Windows.Forms.DataGridView();
//            panelButtonContainer2 = new System.Windows.Forms.Panel();
//            btnRefreshConversations = new System.Windows.Forms.Button();
//            btnDeleteConversation = new System.Windows.Forms.Button();
//            btnViewMessages = new System.Windows.Forms.Button();
//            tabMessages = new System.Windows.Forms.TabPage();
//            panelDataGridContainer3 = new System.Windows.Forms.Panel();
//            dgvMessages = new System.Windows.Forms.DataGridView();
//            panelButtonContainer3 = new System.Windows.Forms.Panel();
//            btnRefreshMessages = new System.Windows.Forms.Button();
//            btnDeleteMessage = new System.Windows.Forms.Button();
//            tabAuditLogs = new System.Windows.Forms.TabPage();
//            panelDataGridContainer4 = new System.Windows.Forms.Panel();
//            dgvAuditLogs = new System.Windows.Forms.DataGridView();
//            panelButtonContainer4 = new System.Windows.Forms.Panel();
//            btnRefreshLogs = new System.Windows.Forms.Button();
//            panelHeader = new System.Windows.Forms.Panel();
//            lblTitle = new System.Windows.Forms.Label();
//            lblCurrentUser = new System.Windows.Forms.Label();
//            btnPolicyManagement = new System.Windows.Forms.Button();
//            panelFooter = new System.Windows.Forms.Panel();
//            lblFooter = new System.Windows.Forms.Label();
//            tabControl.SuspendLayout();
//            tabUsers.SuspendLayout();
//            panelDataGridContainer.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
//            panelButtonContainer.SuspendLayout();
//            tabConversations.SuspendLayout();
//            panelDataGridContainer2.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)dgvConversations).BeginInit();
//            panelButtonContainer2.SuspendLayout();
//            tabMessages.SuspendLayout();
//            panelDataGridContainer3.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)dgvMessages).BeginInit();
//            panelButtonContainer3.SuspendLayout();
//            tabAuditLogs.SuspendLayout();
//            panelDataGridContainer4.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).BeginInit();
//            panelButtonContainer4.SuspendLayout();
//            panelHeader.SuspendLayout();
//            panelFooter.SuspendLayout();
//            SuspendLayout();
//            // 
//            // tabControl
//            // 
//            tabControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
//            tabControl.Controls.Add(tabUsers);
//            tabControl.Controls.Add(tabConversations);
//            tabControl.Controls.Add(tabMessages);
//            tabControl.Controls.Add(tabAuditLogs);
//            tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
//            tabControl.ItemSize = new System.Drawing.Size(180, 40);
//            tabControl.Location = new System.Drawing.Point(10, 92);
//            tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            tabControl.Name = "tabControl";
//            tabControl.SelectedIndex = 0;
//            tabControl.Size = new System.Drawing.Size(1167, 542);
//            tabControl.TabIndex = 0;
//            // 
//            // tabUsers
//            // 
//            tabUsers.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
//            tabUsers.Controls.Add(panelDataGridContainer);
//            tabUsers.Controls.Add(panelButtonContainer);
//            tabUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
//            tabUsers.Location = new System.Drawing.Point(4, 44);
//            tabUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            tabUsers.Name = "tabUsers";
//            tabUsers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            tabUsers.Size = new System.Drawing.Size(1159, 494);
//            tabUsers.TabIndex = 0;
//            tabUsers.Text = "👥 Quản lý Người dùng";
//            // 
//            // panelDataGridContainer
//            // 
//            panelDataGridContainer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
//            panelDataGridContainer.BackColor = System.Drawing.Color.White;
//            panelDataGridContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            panelDataGridContainer.Controls.Add(dgvUsers);
//            panelDataGridContainer.Location = new System.Drawing.Point(12, 69);
//            panelDataGridContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            panelDataGridContainer.Name = "panelDataGridContainer";
//            panelDataGridContainer.Size = new System.Drawing.Size(1137, 420);
//            panelDataGridContainer.TabIndex = 9;
//            // 
//            // dgvUsers
//            // 
//            dgvUsers.AllowUserToAddRows = false;
//            dgvUsers.AllowUserToDeleteRows = false;
//            dgvUsers.AllowUserToResizeRows = false;
//            dgvUsers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
//            dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            dgvUsers.BackgroundColor = System.Drawing.Color.White;
//            dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
//            dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
//            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(42, 128, 185);
//            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
//            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
//            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
//            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(42, 128, 185);
//            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
//            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
//            dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
//            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
//            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
//            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
//            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(232, 242, 252);
//            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
//            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
//            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
//            dgvUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
//            dgvUsers.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
//            dgvUsers.Location = new System.Drawing.Point(1, 1);
//            dgvUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            dgvUsers.MultiSelect = false;
//            dgvUsers.Name = "dgvUsers";
//            dgvUsers.ReadOnly = true;
//            dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
//            dgvUsers.RowHeadersVisible = false;
//            dgvUsers.RowHeadersWidth = 62;
//            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
//            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
//            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(232, 242, 252);
//            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
//            dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle3;
//            dgvUsers.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
//            dgvUsers.RowTemplate.Height = 45;
//            dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
//            dgvUsers.Size = new System.Drawing.Size(1133, 417);
//            dgvUsers.TabIndex = 0;
//            // 
//            // panelButtonContainer
//            // 
//            panelButtonContainer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
//            panelButtonContainer.BackColor = System.Drawing.Color.White;
//            panelButtonContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            panelButtonContainer.Controls.Add(btnRefreshUsers);
//            panelButtonContainer.Controls.Add(btnCreateUser);
//            panelButtonContainer.Controls.Add(btnEditUser);
//            panelButtonContainer.Controls.Add(btnDeleteUser);
//            panelButtonContainer.Controls.Add(btnBanUser);
//            panelButtonContainer.Controls.Add(btnUnbanUser);
//            panelButtonContainer.Controls.Add(btnUnlockAccount);
//            panelButtonContainer.Location = new System.Drawing.Point(12, 14);
//            panelButtonContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            panelButtonContainer.Name = "panelButtonContainer";
//            panelButtonContainer.Size = new System.Drawing.Size(1137, 47);
//            panelButtonContainer.TabIndex = 8;
//            // 
//            // btnRefreshUsers
//            // 
//            btnRefreshUsers.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
//            btnRefreshUsers.Cursor = System.Windows.Forms.Cursors.Hand;
//            btnRefreshUsers.FlatAppearance.BorderSize = 0;
//            btnRefreshUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
//            btnRefreshUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(72, 163, 228);
//            btnRefreshUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            btnRefreshUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
//            btnRefreshUsers.ForeColor = System.Drawing.Color.White;
//            btnRefreshUsers.Location = new System.Drawing.Point(12, 7);
//            btnRefreshUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            btnRefreshUsers.Name = "btnRefreshUsers";
//            btnRefreshUsers.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
//            btnRefreshUsers.Size = new System.Drawing.Size(117, 33);
//            btnRefreshUsers.TabIndex = 1;
//            btnRefreshUsers.Text = "🔄 Làm mới";
//            btnRefreshUsers.UseVisualStyleBackColor = false;
//            // 
//            // btnCreateUser
//            // 
//            btnCreateUser.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
//            btnCreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
//            btnCreateUser.FlatAppearance.BorderSize = 0;
//            btnCreateUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(39, 174, 96);
//            btnCreateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(88, 214, 141);
//            btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            btnCreateUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
//            btnCreateUser.ForeColor = System.Drawing.Color.White;
//            btnCreateUser.Location = new System.Drawing.Point(135, 7);
//            btnCreateUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            btnCreateUser.Name = "btnCreateUser";
//            btnCreateUser.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
//            btnCreateUser.Size = new System.Drawing.Size(117, 33);
//            btnCreateUser.TabIndex = 2;
//            btnCreateUser.Text = "➕ Tạo User";
//            btnCreateUser.UseVisualStyleBackColor = false;
//            // 
//            // btnEditUser
//            // 
//            btnEditUser.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
//            btnEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
//            btnEditUser.FlatAppearance.BorderSize = 0;
//            btnEditUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(243, 156, 18);
//            btnEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 176, 65);
//            btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            btnEditUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
//            btnEditUser.ForeColor = System.Drawing.Color.White;
//            btnEditUser.Location = new System.Drawing.Point(258, 7);
//            btnEditUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            btnEditUser.Name = "btnEditUser";
//            btnEditUser.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
//            btnEditUser.Size = new System.Drawing.Size(117, 33);
//            btnEditUser.TabIndex = 3;
//            btnEditUser.Text = "✏️ Sửa User";
//            btnEditUser.UseVisualStyleBackColor = false;
//            // 
//            // btnDeleteUser
//            // 
//            btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
//            btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
//            btnDeleteUser.FlatAppearance.BorderSize = 0;
//            btnDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 57, 43);
//            btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 108, 93);
//            btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            btnDeleteUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
//            btnDeleteUser.ForeColor = System.Drawing.Color.White;
//            btnDeleteUser.Location = new System.Drawing.Point(382, 7);
//            btnDeleteUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            btnDeleteUser.Name = "btnDeleteUser";
//            btnDeleteUser.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
//            btnDeleteUser.Size = new System.Drawing.Size(117, 33);
//            btnDeleteUser.TabIndex = 4;
//            btnDeleteUser.Text = "🗑️ Xóa User";
//            btnDeleteUser.UseVisualStyleBackColor = false;
//            // 
//            // btnBanUser
//            // 
//            btnBanUser.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
//            btnBanUser.Cursor = System.Windows.Forms.Cursors.Hand;
//            btnBanUser.FlatAppearance.BorderSize = 0;
//            btnBanUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(142, 68, 173);
//            btnBanUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(185, 127, 207);
//            btnBanUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            btnBanUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
//            btnBanUser.ForeColor = System.Drawing.Color.White;
//            btnBanUser.Location = new System.Drawing.Point(505, 7);
//            btnBanUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            btnBanUser.Name = "btnBanUser";
//            btnBanUser.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
//            btnBanUser.Size = new System.Drawing.Size(117, 33);
//            btnBanUser.TabIndex = 5;
//            btnBanUser.Text = "⛔ Cấm User";
//            btnBanUser.UseVisualStyleBackColor = false;
//            // 
//            // btnUnbanUser
//            // 
//            btnUnbanUser.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
//            btnUnbanUser.Cursor = System.Windows.Forms.Cursors.Hand;
//            btnUnbanUser.FlatAppearance.BorderSize = 0;
//            btnUnbanUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
//            btnUnbanUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(86, 101, 115);
//            btnUnbanUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            btnUnbanUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
//            btnUnbanUser.ForeColor = System.Drawing.Color.White;
//            btnUnbanUser.Location = new System.Drawing.Point(628, 7);
//            btnUnbanUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            btnUnbanUser.Name = "btnUnbanUser";
//            btnUnbanUser.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
//            btnUnbanUser.Size = new System.Drawing.Size(117, 33);
//            btnUnbanUser.TabIndex = 6;
//            btnUnbanUser.Text = "✅ Bỏ cấm";
//            btnUnbanUser.UseVisualStyleBackColor = false;
//            // 
//            // btnUnlockAccount
//            // 
//            btnUnlockAccount.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
//            btnUnlockAccount.Cursor = System.Windows.Forms.Cursors.Hand;
//            btnUnlockAccount.FlatAppearance.BorderSize = 0;
//            btnUnlockAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(22, 160, 133);
//            btnUnlockAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(72, 201, 176);
//            btnUnlockAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            btnUnlockAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
//            btnUnlockAccount.ForeColor = System.Drawing.Color.White;
//            btnUnlockAccount.Location = new System.Drawing.Point(752, 7);
//            btnUnlockAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            btnUnlockAccount.Name = "btnUnlockAccount";
//            btnUnlockAccount.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
//            btnUnlockAccount.Size = new System.Drawing.Size(117, 33);
//            btnUnlockAccount.TabIndex = 7;
//            btnUnlockAccount.Text = "🔓 Mở khóa";
//            btnUnlockAccount.UseVisualStyleBackColor = false;
//            // 
//            // tabConversations
//            // 
//            tabConversations.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
//            tabConversations.Controls.Add(panelDataGridContainer2);
//            tabConversations.Controls.Add(panelButtonContainer2);
//            tabConversations.Location = new System.Drawing.Point(4, 44);
//            tabConversations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            tabConversations.Name = "tabConversations";
//            tabConversations.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            tabConversations.Size = new System.Drawing.Size(1159, 494);
//            tabConversations.TabIndex = 1;
//            tabConversations.Text = "💬 Quản lý Hội thoại";
//            // 
//            // panelDataGridContainer2
//            // 
//            panelDataGridContainer2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
//            panelDataGridContainer2.BackColor = System.Drawing.Color.White;
//            panelDataGridContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            panelDataGridContainer2.Controls.Add(dgvConversations);
//            panelDataGridContainer2.Location = new System.Drawing.Point(12, 69);
//            panelDataGridContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            panelDataGridContainer2.Name = "panelDataGridContainer2";
//            panelDataGridContainer2.Size = new System.Drawing.Size(1137, 420);
//            panelDataGridContainer2.TabIndex = 11;
//            // 
//            // dgvConversations
//            // 
//            dgvConversations.AllowUserToAddRows = false;
//            dgvConversations.AllowUserToDeleteRows = false;
//            dgvConversations.AllowUserToResizeRows = false;
//            dgvConversations.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
//            dgvConversations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            dgvConversations.BackgroundColor = System.Drawing.Color.White;
//            dgvConversations.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            dgvConversations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
//            dgvConversations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
//            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
//            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
//            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
//            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
//            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
//            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
//            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//            dgvConversations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
//            dgvConversations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
//            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
//            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
//            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
//            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(232, 242, 252);
//            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
//            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
//            dgvConversations.DefaultCellStyle = dataGridViewCellStyle5;
//            dgvConversations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
//            dgvConversations.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
//            dgvConversations.Location = new System.Drawing.Point(1, 1);
//            dgvConversations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            dgvConversations.MultiSelect = false;
//            dgvConversations.Name = "dgvConversations";
//            dgvConversations.ReadOnly = true;
//            dgvConversations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
//            dgvConversations.RowHeadersVisible = false;
//            dgvConversations.RowHeadersWidth = 62;
//            dgvConversations.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
//            dgvConversations.RowTemplate.Height = 45;
//            dgvConversations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
//            dgvConversations.Size = new System.Drawing.Size(1133, 417);
//            dgvConversations.TabIndex = 0;
//            // 
//            // panelButtonContainer2
//            // 
//            panelButtonContainer2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
//            panelButtonContainer2.BackColor = System.Drawing.Color.White;
//            panelButtonContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            panelButtonContainer2.Controls.Add(btnRefreshConversations);
//            panelButtonContainer2.Controls.Add(btnDeleteConversation);
//            panelButtonContainer2.Controls.Add(btnViewMessages);
//            panelButtonContainer2.Location = new System.Drawing.Point(12, 14);
//            panelButtonContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            panelButtonContainer2.Name = "panelButtonContainer2";
//            panelButtonContainer2.Size = new System.Drawing.Size(1137, 47);
//            panelButtonContainer2.TabIndex = 10;
//            // 
//            // btnRefreshConversations
//            // 
//            btnRefreshConversations.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
//            btnRefreshConversations.Cursor = System.Windows.Forms.Cursors.Hand;
//            btnRefreshConversations.FlatAppearance.BorderSize = 0;
//            btnRefreshConversations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
//            btnRefreshConversations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(72, 163, 228);
//            btnRefreshConversations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            btnRefreshConversations.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
//            btnRefreshConversations.ForeColor = System.Drawing.Color.White;
//            btnRefreshConversations.Location = new System.Drawing.Point(12, 7);
//            btnRefreshConversations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            btnRefreshConversations.Name = "btnRefreshConversations";
//            btnRefreshConversations.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
//            btnRefreshConversations.Size = new System.Drawing.Size(117, 33);
//            btnRefreshConversations.TabIndex = 1;
//            btnRefreshConversations.Text = "🔄 Làm mới";
//            btnRefreshConversations.UseVisualStyleBackColor = false;
//            // 
//            // btnDeleteConversation
//            // 
//            btnDeleteConversation.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
//            btnDeleteConversation.Cursor = System.Windows.Forms.Cursors.Hand;
//            btnDeleteConversation.FlatAppearance.BorderSize = 0;
//            btnDeleteConversation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 57, 43);
//            btnDeleteConversation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 108, 93);
//            btnDeleteConversation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            btnDeleteConversation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
//            btnDeleteConversation.ForeColor = System.Drawing.Color.White;
//            btnDeleteConversation.Location = new System.Drawing.Point(135, 7);
//            btnDeleteConversation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            btnDeleteConversation.Name = "btnDeleteConversation";
//            btnDeleteConversation.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
//            btnDeleteConversation.Size = new System.Drawing.Size(117, 33);
//            btnDeleteConversation.TabIndex = 2;
//            btnDeleteConversation.Text = "🗑️ Xóa";
//            btnDeleteConversation.UseVisualStyleBackColor = false;
//            // 
//            // btnViewMessages
//            // 
//            btnViewMessages.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
//            btnViewMessages.Cursor = System.Windows.Forms.Cursors.Hand;
//            btnViewMessages.FlatAppearance.BorderSize = 0;
//            btnViewMessages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(142, 68, 173);
//            btnViewMessages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(185, 127, 207);
//            btnViewMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            btnViewMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
//            btnViewMessages.ForeColor = System.Drawing.Color.White;
//            btnViewMessages.Location = new System.Drawing.Point(258, 7);
//            btnViewMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            btnViewMessages.Name = "btnViewMessages";
//            btnViewMessages.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
//            btnViewMessages.Size = new System.Drawing.Size(150, 33);
//            btnViewMessages.TabIndex = 3;
//            btnViewMessages.Text = "📨 Xem Messages";
//            btnViewMessages.UseVisualStyleBackColor = false;
//            // 
//            // tabMessages
//            // 
//            tabMessages.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
//            tabMessages.Controls.Add(panelDataGridContainer3);
//            tabMessages.Controls.Add(panelButtonContainer3);
//            tabMessages.Location = new System.Drawing.Point(4, 44);
//            tabMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            tabMessages.Name = "tabMessages";
//            tabMessages.Size = new System.Drawing.Size(1159, 494);
//            tabMessages.TabIndex = 2;
//            tabMessages.Text = "📩 Quản lý Tin nhắn";
//            // 
//            // panelDataGridContainer3
//            // 
//            panelDataGridContainer3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
//            panelDataGridContainer3.BackColor = System.Drawing.Color.White;
//            panelDataGridContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            panelDataGridContainer3.Controls.Add(dgvMessages);
//            panelDataGridContainer3.Location = new System.Drawing.Point(12, 69);
//            panelDataGridContainer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            panelDataGridContainer3.Name = "panelDataGridContainer3";
//            panelDataGridContainer3.Size = new System.Drawing.Size(1137, 420);
//            panelDataGridContainer3.TabIndex = 13;
//            // 
//            // dgvMessages
//            // 
//            dgvMessages.AllowUserToAddRows = false;
//            dgvMessages.AllowUserToDeleteRows = false;
//            dgvMessages.AllowUserToResizeRows = false;
//            dgvMessages.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
//            dgvMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            dgvMessages.BackgroundColor = System.Drawing.Color.White;
//            dgvMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            dgvMessages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
//            dgvMessages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
//            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
//            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
//            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
//            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
//            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
//            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
//            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//            dgvMessages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
//            dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
//            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
//            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
//            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
//            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(232, 242, 252);
//            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
//            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
//            dgvMessages.DefaultCellStyle = dataGridViewCellStyle7;
//            dgvMessages.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
//            dgvMessages.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
//            dgvMessages.Location = new System.Drawing.Point(1, 1);
//            dgvMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            dgvMessages.MultiSelect = false;
//            dgvMessages.Name = "dgvMessages";
//            dgvMessages.ReadOnly = true;
//            dgvMessages.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
//            dgvMessages.RowHeadersVisible = false;
//            dgvMessages.RowHeadersWidth = 62;
//            dgvMessages.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
//            dgvMessages.RowTemplate.Height = 45;
//            dgvMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
//            dgvMessages.Size = new System.Drawing.Size(1133, 417);
//            dgvMessages.TabIndex = 0;
//            // 
//            // panelButtonContainer3
//            // 
//            panelButtonContainer3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
//            panelButtonContainer3.BackColor = System.Drawing.Color.White;
//            panelButtonContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            panelButtonContainer3.Controls.Add(btnRefreshMessages);
//            panelButtonContainer3.Controls.Add(btnDeleteMessage);
//            panelButtonContainer3.Location = new System.Drawing.Point(12, 14);
//            panelButtonContainer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            panelButtonContainer3.Name = "panelButtonContainer3";
//            panelButtonContainer3.Size = new System.Drawing.Size(1137, 47);
//            panelButtonContainer3.TabIndex = 12;
//            // 
//            // btnRefreshMessages
//            // 
//            btnRefreshMessages.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
//            btnRefreshMessages.Cursor = System.Windows.Forms.Cursors.Hand;
//            btnRefreshMessages.FlatAppearance.BorderSize = 0;
//            btnRefreshMessages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
//            btnRefreshMessages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(72, 163, 228);
//            btnRefreshMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            btnRefreshMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
//            btnRefreshMessages.ForeColor = System.Drawing.Color.White;
//            btnRefreshMessages.Location = new System.Drawing.Point(12, 7);
//            btnRefreshMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            btnRefreshMessages.Name = "btnRefreshMessages";
//            btnRefreshMessages.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
//            btnRefreshMessages.Size = new System.Drawing.Size(117, 33);
//            btnRefreshMessages.TabIndex = 1;
//            btnRefreshMessages.Text = "🔄 Làm mới";
//            btnRefreshMessages.UseVisualStyleBackColor = false;
//            // 
//            // btnDeleteMessage
//            // 
//            btnDeleteMessage.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
//            btnDeleteMessage.Cursor = System.Windows.Forms.Cursors.Hand;
//            btnDeleteMessage.FlatAppearance.BorderSize = 0;
//            btnDeleteMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 57, 43);
//            btnDeleteMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 108, 93);
//            btnDeleteMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            btnDeleteMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
//            btnDeleteMessage.ForeColor = System.Drawing.Color.White;
//            btnDeleteMessage.Location = new System.Drawing.Point(135, 7);
//            btnDeleteMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            btnDeleteMessage.Name = "btnDeleteMessage";
//            btnDeleteMessage.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
//            btnDeleteMessage.Size = new System.Drawing.Size(117, 33);
//            btnDeleteMessage.TabIndex = 2;
//            btnDeleteMessage.Text = "🗑️ Xóa";
//            btnDeleteMessage.UseVisualStyleBackColor = false;
//            // 
//            // tabAuditLogs
//            // 
//            tabAuditLogs.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
//            tabAuditLogs.Controls.Add(panelDataGridContainer4);
//            tabAuditLogs.Controls.Add(panelButtonContainer4);
//            tabAuditLogs.Location = new System.Drawing.Point(4, 44);
//            tabAuditLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            tabAuditLogs.Name = "tabAuditLogs";
//            tabAuditLogs.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            tabAuditLogs.Size = new System.Drawing.Size(1159, 494);
//            tabAuditLogs.TabIndex = 3;
//            tabAuditLogs.Text = "📊 Audit Logs";
//            // 
//            // panelDataGridContainer4
//            // 
//            panelDataGridContainer4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
//            panelDataGridContainer4.BackColor = System.Drawing.Color.White;
//            panelDataGridContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            panelDataGridContainer4.Controls.Add(dgvAuditLogs);
//            panelDataGridContainer4.Location = new System.Drawing.Point(12, 69);
//            panelDataGridContainer4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            panelDataGridContainer4.Name = "panelDataGridContainer4";
//            panelDataGridContainer4.Size = new System.Drawing.Size(1137, 420);
//            panelDataGridContainer4.TabIndex = 15;
//            // 
//            // dgvAuditLogs
//            // 
//            dgvAuditLogs.AllowUserToAddRows = false;
//            dgvAuditLogs.AllowUserToDeleteRows = false;
//            dgvAuditLogs.AllowUserToResizeRows = false;
//            dgvAuditLogs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
//            dgvAuditLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            dgvAuditLogs.BackgroundColor = System.Drawing.Color.White;
//            dgvAuditLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            dgvAuditLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
//            dgvAuditLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
//            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
//            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
//            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
//            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
//            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
//            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
//            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//            dgvAuditLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
//            dgvAuditLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            dgvAuditLogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
//            dgvAuditLogs.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
//            dgvAuditLogs.Location = new System.Drawing.Point(1, 1);
//            dgvAuditLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            dgvAuditLogs.MultiSelect = false;
//            dgvAuditLogs.Name = "dgvAuditLogs";
//            dgvAuditLogs.ReadOnly = true;
//            dgvAuditLogs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
//            dgvAuditLogs.RowHeadersVisible = false;
//            dgvAuditLogs.RowHeadersWidth = 62;
//            dgvAuditLogs.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
//            dgvAuditLogs.RowTemplate.Height = 45;
//            dgvAuditLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
//            dgvAuditLogs.Size = new System.Drawing.Size(1133, 417);
//            dgvAuditLogs.TabIndex = 0;
//            // 
//            // panelButtonContainer4
//            // 
//            panelButtonContainer4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
//            panelButtonContainer4.BackColor = System.Drawing.Color.White;
//            panelButtonContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            panelButtonContainer4.Controls.Add(btnRefreshLogs);
//            panelButtonContainer4.Location = new System.Drawing.Point(12, 14);
//            panelButtonContainer4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            panelButtonContainer4.Name = "panelButtonContainer4";
//            panelButtonContainer4.Size = new System.Drawing.Size(1137, 47);
//            panelButtonContainer4.TabIndex = 14;
//            // 
//            // btnRefreshLogs
//            // 
//            btnRefreshLogs.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
//            btnRefreshLogs.Cursor = System.Windows.Forms.Cursors.Hand;
//            btnRefreshLogs.FlatAppearance.BorderSize = 0;
//            btnRefreshLogs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
//            btnRefreshLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(72, 163, 228);
//            btnRefreshLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            btnRefreshLogs.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
//            btnRefreshLogs.ForeColor = System.Drawing.Color.White;
//            btnRefreshLogs.Location = new System.Drawing.Point(12, 7);
//            btnRefreshLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            btnRefreshLogs.Name = "btnRefreshLogs";
//            btnRefreshLogs.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
//            btnRefreshLogs.Size = new System.Drawing.Size(117, 33);
//            btnRefreshLogs.TabIndex = 1;
//            btnRefreshLogs.Text = "🔄 Làm mới";
//            btnRefreshLogs.UseVisualStyleBackColor = false;
//            // 
//            // panelHeader
//            // 
//            panelHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
//            panelHeader.BackColor = System.Drawing.Color.White;
//            panelHeader.Controls.Add(lblTitle);
//            panelHeader.Controls.Add(lblCurrentUser);
//            panelHeader.Controls.Add(btnPolicyManagement);
//            panelHeader.Location = new System.Drawing.Point(10, 10);
//            panelHeader.Margin = new System.Windows.Forms.Padding(2);
//            panelHeader.Name = "panelHeader";
//            panelHeader.Size = new System.Drawing.Size(1167, 75);
//            panelHeader.TabIndex = 1;
//            // 
//            // lblTitle
//            // 
//            lblTitle.AutoSize = true;
//            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
//            lblTitle.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
//            lblTitle.Location = new System.Drawing.Point(12, 12);
//            lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
//            lblTitle.Name = "lblTitle";
//            lblTitle.Size = new System.Drawing.Size(328, 37);
//            lblTitle.TabIndex = 3;
//            lblTitle.Text = "⚙️ Admin Control Panel";
//            // 
//            // lblCurrentUser
//            // 
//            lblCurrentUser.AutoSize = true;
//            lblCurrentUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
//            lblCurrentUser.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
//            lblCurrentUser.Location = new System.Drawing.Point(17, 46);
//            lblCurrentUser.Name = "lblCurrentUser";
//            lblCurrentUser.Size = new System.Drawing.Size(136, 23);
//            lblCurrentUser.TabIndex = 1;
//            lblCurrentUser.Text = "Xin chào: Admin";
//            // 
//            // btnPolicyManagement
//            // 
//            btnPolicyManagement.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
//            btnPolicyManagement.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
//            btnPolicyManagement.Cursor = System.Windows.Forms.Cursors.Hand;
//            btnPolicyManagement.FlatAppearance.BorderSize = 0;
//            btnPolicyManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(31, 97, 141);
//            btnPolicyManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 152, 219);
//            btnPolicyManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            btnPolicyManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
//            btnPolicyManagement.ForeColor = System.Drawing.Color.White;
//            btnPolicyManagement.Location = new System.Drawing.Point(983, 25);
//            btnPolicyManagement.Margin = new System.Windows.Forms.Padding(2);
//            btnPolicyManagement.Name = "btnPolicyManagement";
//            btnPolicyManagement.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
//            btnPolicyManagement.Size = new System.Drawing.Size(167, 38);
//            btnPolicyManagement.TabIndex = 2;
//            btnPolicyManagement.Text = "📜 Quản lý Policy";
//            btnPolicyManagement.UseVisualStyleBackColor = false;
//            // 
//            // panelFooter
//            // 
//            panelFooter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
//            panelFooter.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
//            panelFooter.Controls.Add(lblFooter);
//            panelFooter.Location = new System.Drawing.Point(10, 642);
//            panelFooter.Margin = new System.Windows.Forms.Padding(2);
//            panelFooter.Name = "panelFooter";
//            panelFooter.Size = new System.Drawing.Size(1167, 33);
//            panelFooter.TabIndex = 2;
//            // 
//            // lblFooter
//            // 
//            lblFooter.Anchor = System.Windows.Forms.AnchorStyles.None;
//            lblFooter.AutoSize = true;
//            lblFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
//            lblFooter.ForeColor = System.Drawing.Color.White;
//            lblFooter.Location = new System.Drawing.Point(518, 9);
//            lblFooter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
//            lblFooter.Name = "lblFooter";
//            lblFooter.Size = new System.Drawing.Size(131, 20);
//            lblFooter.TabIndex = 0;
//            lblFooter.Text = "Chat Server v1.0.0";
//            // 
//            // AdminPanelForm
//            // 
//            AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
//            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
//            BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
//            ClientSize = new System.Drawing.Size(1193, 685);
//            Controls.Add(panelFooter);
//            Controls.Add(panelHeader);
//            Controls.Add(tabControl);
//            Font = new System.Drawing.Font("Segoe UI", 9F);
//            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            MinimumSize = new System.Drawing.Size(1211, 675);
//            Name = "AdminPanelForm";
//            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            Text = "Admin Panel - Chat Server";
//            tabControl.ResumeLayout(false);
//            tabUsers.ResumeLayout(false);
//            panelDataGridContainer.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
//            panelButtonContainer.ResumeLayout(false);
//            tabConversations.ResumeLayout(false);
//            panelDataGridContainer2.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)dgvConversations).EndInit();
//            panelButtonContainer2.ResumeLayout(false);
//            tabMessages.ResumeLayout(false);
//            panelDataGridContainer3.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)dgvMessages).EndInit();
//            panelButtonContainer3.ResumeLayout(false);
//            tabAuditLogs.ResumeLayout(false);
//            panelDataGridContainer4.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).EndInit();
//            panelButtonContainer4.ResumeLayout(false);
//            panelHeader.ResumeLayout(false);
//            panelHeader.PerformLayout();
//            panelFooter.ResumeLayout(false);
//            panelFooter.PerformLayout();
//            ResumeLayout(false);
//        }

//        #endregion

//        // Thêm các panel container cho các tab khác
//        private System.Windows.Forms.Panel panelDataGridContainer2;
//        private System.Windows.Forms.Panel panelButtonContainer2;
//        private System.Windows.Forms.Panel panelDataGridContainer3;
//        private System.Windows.Forms.Panel panelButtonContainer3;
//        private System.Windows.Forms.Panel panelDataGridContainer4;
//        private System.Windows.Forms.Panel panelButtonContainer4;
//        private System.Windows.Forms.Label lblTitle;
//    }
//}

namespace ChatServer.Forms
{
    partial class AdminPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            tabControl = new System.Windows.Forms.TabControl();
            tabUsers = new System.Windows.Forms.TabPage();
            panelDataGridContainer = new System.Windows.Forms.Panel();
            dgvUsers = new System.Windows.Forms.DataGridView();
            panelButtonContainer = new System.Windows.Forms.Panel();
            btnRefreshUsers = new System.Windows.Forms.Button();
            btnCreateUser = new System.Windows.Forms.Button();
            btnEditUser = new System.Windows.Forms.Button();
            btnDeleteUser = new System.Windows.Forms.Button();
            btnBanUser = new System.Windows.Forms.Button();
            btnUnbanUser = new System.Windows.Forms.Button();
            btnUnlockAccount = new System.Windows.Forms.Button();
            tabConversations = new System.Windows.Forms.TabPage();
            panelDataGridContainer2 = new System.Windows.Forms.Panel();
            dgvConversations = new System.Windows.Forms.DataGridView();
            panelButtonContainer2 = new System.Windows.Forms.Panel();
            btnRefreshConversations = new System.Windows.Forms.Button();
            btnDeleteConversation = new System.Windows.Forms.Button();
            btnViewMessages = new System.Windows.Forms.Button();
            tabMessages = new System.Windows.Forms.TabPage();
            panelDataGridContainer3 = new System.Windows.Forms.Panel();
            dgvMessages = new System.Windows.Forms.DataGridView();
            panelButtonContainer3 = new System.Windows.Forms.Panel();
            btnRefreshMessages = new System.Windows.Forms.Button();
            btnDeleteMessage = new System.Windows.Forms.Button();
            tabAuditLogs = new System.Windows.Forms.TabPage();
            panelDataGridContainer4 = new System.Windows.Forms.Panel();
            dgvAuditLogs = new System.Windows.Forms.DataGridView();
            panelButtonContainer4 = new System.Windows.Forms.Panel();
            btnRefreshLogs = new System.Windows.Forms.Button();
            tabBackupRestore = new System.Windows.Forms.TabPage();
            panelDataGridContainer5 = new System.Windows.Forms.Panel();
            dgvBackupHistory = new System.Windows.Forms.DataGridView();
            panelButtonContainer5 = new System.Windows.Forms.Panel();
            btnRefreshBackup = new System.Windows.Forms.Button();
            btnBackupNow = new System.Windows.Forms.Button();
            btnRestoreBackup = new System.Windows.Forms.Button();
            tabTimeout = new System.Windows.Forms.TabPage();
            panelDataGridContainer6 = new System.Windows.Forms.Panel();
            dgvTimeoutSettings = new System.Windows.Forms.DataGridView();
            panelButtonContainer6 = new System.Windows.Forms.Panel();
            btnRefreshTimeout = new System.Windows.Forms.Button();
            btnUpdateTimeout = new System.Windows.Forms.Button();
            tabLoginHistory = new System.Windows.Forms.TabPage();
            panelDataGridContainer7 = new System.Windows.Forms.Panel();
            dgvLoginHistory = new System.Windows.Forms.DataGridView();
            panelButtonContainer7 = new System.Windows.Forms.Panel();
            btnRefreshLoginHistory = new System.Windows.Forms.Button();
            btnExportLoginHistory = new System.Windows.Forms.Button();
            panelHeader = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            lblCurrentUser = new System.Windows.Forms.Label();
            btnPolicyManagement = new System.Windows.Forms.Button();
            panelFooter = new System.Windows.Forms.Panel();
            lblFooter = new System.Windows.Forms.Label();
            tabControl.SuspendLayout();
            tabUsers.SuspendLayout();
            panelDataGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panelButtonContainer.SuspendLayout();
            tabConversations.SuspendLayout();
            panelDataGridContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConversations).BeginInit();
            panelButtonContainer2.SuspendLayout();
            tabMessages.SuspendLayout();
            panelDataGridContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMessages).BeginInit();
            panelButtonContainer3.SuspendLayout();
            tabAuditLogs.SuspendLayout();
            panelDataGridContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).BeginInit();
            panelButtonContainer4.SuspendLayout();
            tabBackupRestore.SuspendLayout();
            panelDataGridContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBackupHistory).BeginInit();
            panelButtonContainer5.SuspendLayout();
            tabTimeout.SuspendLayout();
            panelDataGridContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimeoutSettings).BeginInit();
            panelButtonContainer6.SuspendLayout();
            tabLoginHistory.SuspendLayout();
            panelDataGridContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoginHistory).BeginInit();
            panelButtonContainer7.SuspendLayout();
            panelHeader.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl.Controls.Add(tabUsers);
            tabControl.Controls.Add(tabConversations);
            tabControl.Controls.Add(tabMessages);
            tabControl.Controls.Add(tabAuditLogs);
            tabControl.Controls.Add(tabBackupRestore);
            tabControl.Controls.Add(tabTimeout);
            tabControl.Controls.Add(tabLoginHistory);
            tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            tabControl.ItemSize = new System.Drawing.Size(180, 40);
            tabControl.Location = new System.Drawing.Point(10, 92);
            tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(1240, 542);
            tabControl.TabIndex = 0;
            // 
            // tabUsers
            // 
            tabUsers.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            tabUsers.Controls.Add(panelDataGridContainer);
            tabUsers.Controls.Add(panelButtonContainer);
            tabUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            tabUsers.Location = new System.Drawing.Point(4, 44);
            tabUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabUsers.Size = new System.Drawing.Size(1232, 494);
            tabUsers.TabIndex = 0;
            tabUsers.Text = "👥 Quản lý Người dùng";
            // 
            // panelDataGridContainer
            // 
            panelDataGridContainer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelDataGridContainer.BackColor = System.Drawing.Color.White;
            panelDataGridContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelDataGridContainer.Controls.Add(dgvUsers);
            panelDataGridContainer.Location = new System.Drawing.Point(12, 69);
            panelDataGridContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelDataGridContainer.Name = "panelDataGridContainer";
            panelDataGridContainer.Size = new System.Drawing.Size(1210, 420);
            panelDataGridContainer.TabIndex = 9;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = System.Drawing.Color.White;
            dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(42, 128, 185);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(42, 128, 185);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(232, 242, 252);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dgvUsers.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
            dgvUsers.Location = new System.Drawing.Point(1, 1);
            dgvUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(232, 242, 252);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            dgvUsers.RowTemplate.Height = 45;
            dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new System.Drawing.Size(1206, 417);
            dgvUsers.TabIndex = 0;
            // 
            // panelButtonContainer
            // 
            panelButtonContainer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelButtonContainer.BackColor = System.Drawing.Color.White;
            panelButtonContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelButtonContainer.Controls.Add(btnRefreshUsers);
            panelButtonContainer.Controls.Add(btnCreateUser);
            panelButtonContainer.Controls.Add(btnEditUser);
            panelButtonContainer.Controls.Add(btnDeleteUser);
            panelButtonContainer.Controls.Add(btnBanUser);
            panelButtonContainer.Controls.Add(btnUnbanUser);
            panelButtonContainer.Controls.Add(btnUnlockAccount);
            panelButtonContainer.Location = new System.Drawing.Point(12, 14);
            panelButtonContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelButtonContainer.Name = "panelButtonContainer";
            panelButtonContainer.Size = new System.Drawing.Size(1210, 47);
            panelButtonContainer.TabIndex = 8;
            // 
            // btnRefreshUsers
            // 
            btnRefreshUsers.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnRefreshUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefreshUsers.FlatAppearance.BorderSize = 0;
            btnRefreshUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnRefreshUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(72, 163, 228);
            btnRefreshUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefreshUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnRefreshUsers.ForeColor = System.Drawing.Color.White;
            btnRefreshUsers.Location = new System.Drawing.Point(12, 7);
            btnRefreshUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRefreshUsers.Name = "btnRefreshUsers";
            btnRefreshUsers.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnRefreshUsers.Size = new System.Drawing.Size(117, 33);
            btnRefreshUsers.TabIndex = 1;
            btnRefreshUsers.Text = "🔄 Làm mới";
            btnRefreshUsers.UseVisualStyleBackColor = false;
            // 
            // btnCreateUser
            // 
            btnCreateUser.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            btnCreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCreateUser.FlatAppearance.BorderSize = 0;
            btnCreateUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            btnCreateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(88, 214, 141);
            btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCreateUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnCreateUser.ForeColor = System.Drawing.Color.White;
            btnCreateUser.Location = new System.Drawing.Point(135, 7);
            btnCreateUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnCreateUser.Size = new System.Drawing.Size(117, 33);
            btnCreateUser.TabIndex = 2;
            btnCreateUser.Text = "➕ Tạo User";
            btnCreateUser.UseVisualStyleBackColor = false;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            btnEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditUser.FlatAppearance.BorderSize = 0;
            btnEditUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            btnEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 176, 65);
            btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnEditUser.ForeColor = System.Drawing.Color.White;
            btnEditUser.Location = new System.Drawing.Point(258, 7);
            btnEditUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnEditUser.Size = new System.Drawing.Size(117, 33);
            btnEditUser.TabIndex = 3;
            btnEditUser.Text = "✏️ Sửa User";
            btnEditUser.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDeleteUser.FlatAppearance.BorderSize = 0;
            btnDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 108, 93);
            btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnDeleteUser.ForeColor = System.Drawing.Color.White;
            btnDeleteUser.Location = new System.Drawing.Point(382, 7);
            btnDeleteUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnDeleteUser.Size = new System.Drawing.Size(117, 33);
            btnDeleteUser.TabIndex = 4;
            btnDeleteUser.Text = "🗑️ Xóa User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnBanUser
            // 
            btnBanUser.BackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            btnBanUser.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBanUser.FlatAppearance.BorderSize = 0;
            btnBanUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            btnBanUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(185, 127, 207);
            btnBanUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBanUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnBanUser.ForeColor = System.Drawing.Color.White;
            btnBanUser.Location = new System.Drawing.Point(505, 7);
            btnBanUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnBanUser.Name = "btnBanUser";
            btnBanUser.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnBanUser.Size = new System.Drawing.Size(117, 33);
            btnBanUser.TabIndex = 5;
            btnBanUser.Text = "⛔ Cấm User";
            btnBanUser.UseVisualStyleBackColor = false;
            // 
            // btnUnbanUser
            // 
            btnUnbanUser.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            btnUnbanUser.Cursor = System.Windows.Forms.Cursors.Hand;
            btnUnbanUser.FlatAppearance.BorderSize = 0;
            btnUnbanUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            btnUnbanUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(86, 101, 115);
            btnUnbanUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUnbanUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnUnbanUser.ForeColor = System.Drawing.Color.White;
            btnUnbanUser.Location = new System.Drawing.Point(628, 7);
            btnUnbanUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUnbanUser.Name = "btnUnbanUser";
            btnUnbanUser.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnUnbanUser.Size = new System.Drawing.Size(117, 33);
            btnUnbanUser.TabIndex = 6;
            btnUnbanUser.Text = "✅ Bỏ cấm";
            btnUnbanUser.UseVisualStyleBackColor = false;
            // 
            // btnUnlockAccount
            // 
            btnUnlockAccount.BackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            btnUnlockAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            btnUnlockAccount.FlatAppearance.BorderSize = 0;
            btnUnlockAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            btnUnlockAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(72, 201, 176);
            btnUnlockAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUnlockAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnUnlockAccount.ForeColor = System.Drawing.Color.White;
            btnUnlockAccount.Location = new System.Drawing.Point(752, 7);
            btnUnlockAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUnlockAccount.Name = "btnUnlockAccount";
            btnUnlockAccount.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnUnlockAccount.Size = new System.Drawing.Size(117, 33);
            btnUnlockAccount.TabIndex = 7;
            btnUnlockAccount.Text = "🔓 Mở khóa";
            btnUnlockAccount.UseVisualStyleBackColor = false;
            // 
            // tabConversations
            // 
            tabConversations.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            tabConversations.Controls.Add(panelDataGridContainer2);
            tabConversations.Controls.Add(panelButtonContainer2);
            tabConversations.Location = new System.Drawing.Point(4, 44);
            tabConversations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabConversations.Name = "tabConversations";
            tabConversations.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabConversations.Size = new System.Drawing.Size(1159, 494);
            tabConversations.TabIndex = 1;
            tabConversations.Text = "💬 Quản lý Hội thoại";
            // 
            // panelDataGridContainer2
            // 
            panelDataGridContainer2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelDataGridContainer2.BackColor = System.Drawing.Color.White;
            panelDataGridContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelDataGridContainer2.Controls.Add(dgvConversations);
            panelDataGridContainer2.Location = new System.Drawing.Point(12, 69);
            panelDataGridContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelDataGridContainer2.Name = "panelDataGridContainer2";
            panelDataGridContainer2.Size = new System.Drawing.Size(1137, 420);
            panelDataGridContainer2.TabIndex = 11;
            // 
            // dgvConversations
            // 
            dgvConversations.AllowUserToAddRows = false;
            dgvConversations.AllowUserToDeleteRows = false;
            dgvConversations.AllowUserToResizeRows = false;
            dgvConversations.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvConversations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvConversations.BackgroundColor = System.Drawing.Color.White;
            dgvConversations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvConversations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvConversations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvConversations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvConversations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(232, 242, 252);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvConversations.DefaultCellStyle = dataGridViewCellStyle5;
            dgvConversations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dgvConversations.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
            dgvConversations.Location = new System.Drawing.Point(1, 1);
            dgvConversations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvConversations.MultiSelect = false;
            dgvConversations.Name = "dgvConversations";
            dgvConversations.ReadOnly = true;
            dgvConversations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvConversations.RowHeadersVisible = false;
            dgvConversations.RowHeadersWidth = 62;
            dgvConversations.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            dgvConversations.RowTemplate.Height = 45;
            dgvConversations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvConversations.Size = new System.Drawing.Size(1133, 417);
            dgvConversations.TabIndex = 0;
            // 
            // panelButtonContainer2
            // 
            panelButtonContainer2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelButtonContainer2.BackColor = System.Drawing.Color.White;
            panelButtonContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelButtonContainer2.Controls.Add(btnRefreshConversations);
            panelButtonContainer2.Controls.Add(btnDeleteConversation);
            panelButtonContainer2.Controls.Add(btnViewMessages);
            panelButtonContainer2.Location = new System.Drawing.Point(12, 14);
            panelButtonContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelButtonContainer2.Name = "panelButtonContainer2";
            panelButtonContainer2.Size = new System.Drawing.Size(1137, 47);
            panelButtonContainer2.TabIndex = 10;
            // 
            // btnRefreshConversations
            // 
            btnRefreshConversations.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnRefreshConversations.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefreshConversations.FlatAppearance.BorderSize = 0;
            btnRefreshConversations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnRefreshConversations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(72, 163, 228);
            btnRefreshConversations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefreshConversations.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnRefreshConversations.ForeColor = System.Drawing.Color.White;
            btnRefreshConversations.Location = new System.Drawing.Point(12, 7);
            btnRefreshConversations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRefreshConversations.Name = "btnRefreshConversations";
            btnRefreshConversations.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnRefreshConversations.Size = new System.Drawing.Size(117, 33);
            btnRefreshConversations.TabIndex = 1;
            btnRefreshConversations.Text = "🔄 Làm mới";
            btnRefreshConversations.UseVisualStyleBackColor = false;
            // 
            // btnDeleteConversation
            // 
            btnDeleteConversation.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnDeleteConversation.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDeleteConversation.FlatAppearance.BorderSize = 0;
            btnDeleteConversation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            btnDeleteConversation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 108, 93);
            btnDeleteConversation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteConversation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnDeleteConversation.ForeColor = System.Drawing.Color.White;
            btnDeleteConversation.Location = new System.Drawing.Point(135, 7);
            btnDeleteConversation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDeleteConversation.Name = "btnDeleteConversation";
            btnDeleteConversation.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnDeleteConversation.Size = new System.Drawing.Size(117, 33);
            btnDeleteConversation.TabIndex = 2;
            btnDeleteConversation.Text = "🗑️ Xóa";
            btnDeleteConversation.UseVisualStyleBackColor = false;
            // 
            // btnViewMessages
            // 
            btnViewMessages.BackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            btnViewMessages.Cursor = System.Windows.Forms.Cursors.Hand;
            btnViewMessages.FlatAppearance.BorderSize = 0;
            btnViewMessages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            btnViewMessages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(185, 127, 207);
            btnViewMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnViewMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnViewMessages.ForeColor = System.Drawing.Color.White;
            btnViewMessages.Location = new System.Drawing.Point(258, 7);
            btnViewMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnViewMessages.Name = "btnViewMessages";
            btnViewMessages.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnViewMessages.Size = new System.Drawing.Size(150, 33);
            btnViewMessages.TabIndex = 3;
            btnViewMessages.Text = "📨 Xem Messages";
            btnViewMessages.UseVisualStyleBackColor = false;
            // 
            // tabMessages
            // 
            tabMessages.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            tabMessages.Controls.Add(panelDataGridContainer3);
            tabMessages.Controls.Add(panelButtonContainer3);
            tabMessages.Location = new System.Drawing.Point(4, 44);
            tabMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabMessages.Name = "tabMessages";
            tabMessages.Size = new System.Drawing.Size(1159, 494);
            tabMessages.TabIndex = 2;
            tabMessages.Text = "📩 Quản lý Tin nhắn";
            // 
            // panelDataGridContainer3
            // 
            panelDataGridContainer3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelDataGridContainer3.BackColor = System.Drawing.Color.White;
            panelDataGridContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelDataGridContainer3.Controls.Add(dgvMessages);
            panelDataGridContainer3.Location = new System.Drawing.Point(12, 69);
            panelDataGridContainer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelDataGridContainer3.Name = "panelDataGridContainer3";
            panelDataGridContainer3.Size = new System.Drawing.Size(1137, 420);
            panelDataGridContainer3.TabIndex = 13;
            // 
            // dgvMessages
            // 
            dgvMessages.AllowUserToAddRows = false;
            dgvMessages.AllowUserToDeleteRows = false;
            dgvMessages.AllowUserToResizeRows = false;
            dgvMessages.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMessages.BackgroundColor = System.Drawing.Color.White;
            dgvMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvMessages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMessages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvMessages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(232, 242, 252);
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvMessages.DefaultCellStyle = dataGridViewCellStyle7;
            dgvMessages.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dgvMessages.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
            dgvMessages.Location = new System.Drawing.Point(1, 1);
            dgvMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvMessages.MultiSelect = false;
            dgvMessages.Name = "dgvMessages";
            dgvMessages.ReadOnly = true;
            dgvMessages.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvMessages.RowHeadersVisible = false;
            dgvMessages.RowHeadersWidth = 62;
            dgvMessages.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            dgvMessages.RowTemplate.Height = 45;
            dgvMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMessages.Size = new System.Drawing.Size(1133, 417);
            dgvMessages.TabIndex = 0;
            // 
            // panelButtonContainer3
            // 
            panelButtonContainer3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelButtonContainer3.BackColor = System.Drawing.Color.White;
            panelButtonContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelButtonContainer3.Controls.Add(btnRefreshMessages);
            panelButtonContainer3.Controls.Add(btnDeleteMessage);
            panelButtonContainer3.Location = new System.Drawing.Point(12, 14);
            panelButtonContainer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelButtonContainer3.Name = "panelButtonContainer3";
            panelButtonContainer3.Size = new System.Drawing.Size(1137, 47);
            panelButtonContainer3.TabIndex = 12;
            // 
            // btnRefreshMessages
            // 
            btnRefreshMessages.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnRefreshMessages.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefreshMessages.FlatAppearance.BorderSize = 0;
            btnRefreshMessages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnRefreshMessages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(72, 163, 228);
            btnRefreshMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefreshMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnRefreshMessages.ForeColor = System.Drawing.Color.White;
            btnRefreshMessages.Location = new System.Drawing.Point(12, 7);
            btnRefreshMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRefreshMessages.Name = "btnRefreshMessages";
            btnRefreshMessages.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnRefreshMessages.Size = new System.Drawing.Size(117, 33);
            btnRefreshMessages.TabIndex = 1;
            btnRefreshMessages.Text = "🔄 Làm mới";
            btnRefreshMessages.UseVisualStyleBackColor = false;
            // 
            // btnDeleteMessage
            // 
            btnDeleteMessage.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnDeleteMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDeleteMessage.FlatAppearance.BorderSize = 0;
            btnDeleteMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            btnDeleteMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 108, 93);
            btnDeleteMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnDeleteMessage.ForeColor = System.Drawing.Color.White;
            btnDeleteMessage.Location = new System.Drawing.Point(135, 7);
            btnDeleteMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDeleteMessage.Name = "btnDeleteMessage";
            btnDeleteMessage.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnDeleteMessage.Size = new System.Drawing.Size(117, 33);
            btnDeleteMessage.TabIndex = 2;
            btnDeleteMessage.Text = "🗑️ Xóa";
            btnDeleteMessage.UseVisualStyleBackColor = false;
            // 
            // tabAuditLogs
            // 
            tabAuditLogs.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            tabAuditLogs.Controls.Add(panelDataGridContainer4);
            tabAuditLogs.Controls.Add(panelButtonContainer4);
            tabAuditLogs.Location = new System.Drawing.Point(4, 44);
            tabAuditLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabAuditLogs.Name = "tabAuditLogs";
            tabAuditLogs.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabAuditLogs.Size = new System.Drawing.Size(1159, 494);
            tabAuditLogs.TabIndex = 3;
            tabAuditLogs.Text = "📊 Audit Logs";
            // 
            // panelDataGridContainer4
            // 
            panelDataGridContainer4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelDataGridContainer4.BackColor = System.Drawing.Color.White;
            panelDataGridContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelDataGridContainer4.Controls.Add(dgvAuditLogs);
            panelDataGridContainer4.Location = new System.Drawing.Point(12, 69);
            panelDataGridContainer4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelDataGridContainer4.Name = "panelDataGridContainer4";
            panelDataGridContainer4.Size = new System.Drawing.Size(1137, 420);
            panelDataGridContainer4.TabIndex = 15;
            // 
            // dgvAuditLogs
            // 
            dgvAuditLogs.AllowUserToAddRows = false;
            dgvAuditLogs.AllowUserToDeleteRows = false;
            dgvAuditLogs.AllowUserToResizeRows = false;
            dgvAuditLogs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvAuditLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuditLogs.BackgroundColor = System.Drawing.Color.White;
            dgvAuditLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvAuditLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAuditLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvAuditLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvAuditLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditLogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dgvAuditLogs.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
            dgvAuditLogs.Location = new System.Drawing.Point(1, 1);
            dgvAuditLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvAuditLogs.MultiSelect = false;
            dgvAuditLogs.Name = "dgvAuditLogs";
            dgvAuditLogs.ReadOnly = true;
            dgvAuditLogs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvAuditLogs.RowHeadersVisible = false;
            dgvAuditLogs.RowHeadersWidth = 62;
            dgvAuditLogs.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            dgvAuditLogs.RowTemplate.Height = 45;
            dgvAuditLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAuditLogs.Size = new System.Drawing.Size(1133, 417);
            dgvAuditLogs.TabIndex = 0;
            // 
            // panelButtonContainer4
            // 
            panelButtonContainer4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelButtonContainer4.BackColor = System.Drawing.Color.White;
            panelButtonContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelButtonContainer4.Controls.Add(btnRefreshLogs);
            panelButtonContainer4.Location = new System.Drawing.Point(12, 14);
            panelButtonContainer4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelButtonContainer4.Name = "panelButtonContainer4";
            panelButtonContainer4.Size = new System.Drawing.Size(1137, 47);
            panelButtonContainer4.TabIndex = 14;
            // 
            // btnRefreshLogs
            // 
            btnRefreshLogs.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnRefreshLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefreshLogs.FlatAppearance.BorderSize = 0;
            btnRefreshLogs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnRefreshLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(72, 163, 228);
            btnRefreshLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefreshLogs.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnRefreshLogs.ForeColor = System.Drawing.Color.White;
            btnRefreshLogs.Location = new System.Drawing.Point(12, 7);
            btnRefreshLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRefreshLogs.Name = "btnRefreshLogs";
            btnRefreshLogs.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnRefreshLogs.Size = new System.Drawing.Size(117, 33);
            btnRefreshLogs.TabIndex = 1;
            btnRefreshLogs.Text = "🔄 Làm mới";
            btnRefreshLogs.UseVisualStyleBackColor = false;
            // 
            // tabBackupRestore
            // 
            tabBackupRestore.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            tabBackupRestore.Controls.Add(panelDataGridContainer5);
            tabBackupRestore.Controls.Add(panelButtonContainer5);
            tabBackupRestore.Location = new System.Drawing.Point(4, 44);
            tabBackupRestore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabBackupRestore.Name = "tabBackupRestore";
            tabBackupRestore.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabBackupRestore.Size = new System.Drawing.Size(1232, 494);
            tabBackupRestore.TabIndex = 4;
            tabBackupRestore.Text = "💾 Backup/Restore";
            // 
            // panelDataGridContainer5
            // 
            panelDataGridContainer5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelDataGridContainer5.BackColor = System.Drawing.Color.White;
            panelDataGridContainer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelDataGridContainer5.Controls.Add(dgvBackupHistory);
            panelDataGridContainer5.Location = new System.Drawing.Point(12, 69);
            panelDataGridContainer5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelDataGridContainer5.Name = "panelDataGridContainer5";
            panelDataGridContainer5.Size = new System.Drawing.Size(1210, 420);
            panelDataGridContainer5.TabIndex = 17;
            // 
            // dgvBackupHistory
            // 
            dgvBackupHistory.AllowUserToAddRows = false;
            dgvBackupHistory.AllowUserToDeleteRows = false;
            dgvBackupHistory.AllowUserToResizeRows = false;
            dgvBackupHistory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvBackupHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvBackupHistory.BackgroundColor = System.Drawing.Color.White;
            dgvBackupHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvBackupHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBackupHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvBackupHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvBackupHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(232, 242, 252);
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvBackupHistory.DefaultCellStyle = dataGridViewCellStyle10;
            dgvBackupHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dgvBackupHistory.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
            dgvBackupHistory.Location = new System.Drawing.Point(1, 1);
            dgvBackupHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvBackupHistory.MultiSelect = false;
            dgvBackupHistory.Name = "dgvBackupHistory";
            dgvBackupHistory.ReadOnly = true;
            dgvBackupHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvBackupHistory.RowHeadersVisible = false;
            dgvBackupHistory.RowHeadersWidth = 62;
            dgvBackupHistory.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            dgvBackupHistory.RowTemplate.Height = 45;
            dgvBackupHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvBackupHistory.Size = new System.Drawing.Size(1206, 417);
            dgvBackupHistory.TabIndex = 0;
            // 
            // panelButtonContainer5
            // 
            panelButtonContainer5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelButtonContainer5.BackColor = System.Drawing.Color.White;
            panelButtonContainer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelButtonContainer5.Controls.Add(btnRefreshBackup);
            panelButtonContainer5.Controls.Add(btnBackupNow);
            panelButtonContainer5.Controls.Add(btnRestoreBackup);
            panelButtonContainer5.Location = new System.Drawing.Point(12, 14);
            panelButtonContainer5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelButtonContainer5.Name = "panelButtonContainer5";
            panelButtonContainer5.Size = new System.Drawing.Size(1210, 47);
            panelButtonContainer5.TabIndex = 16;
            // 
            // btnRefreshBackup
            // 
            btnRefreshBackup.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnRefreshBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefreshBackup.FlatAppearance.BorderSize = 0;
            btnRefreshBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnRefreshBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(72, 163, 228);
            btnRefreshBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefreshBackup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnRefreshBackup.ForeColor = System.Drawing.Color.White;
            btnRefreshBackup.Location = new System.Drawing.Point(12, 7);
            btnRefreshBackup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRefreshBackup.Name = "btnRefreshBackup";
            btnRefreshBackup.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnRefreshBackup.Size = new System.Drawing.Size(117, 33);
            btnRefreshBackup.TabIndex = 1;
            btnRefreshBackup.Text = "🔄 Làm mới";
            btnRefreshBackup.UseVisualStyleBackColor = false;
            // 
            // btnBackupNow
            // 
            btnBackupNow.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            btnBackupNow.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBackupNow.FlatAppearance.BorderSize = 0;
            btnBackupNow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(30, 132, 73);
            btnBackupNow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnBackupNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBackupNow.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnBackupNow.ForeColor = System.Drawing.Color.White;
            btnBackupNow.Location = new System.Drawing.Point(135, 7);
            btnBackupNow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnBackupNow.Name = "btnBackupNow";
            btnBackupNow.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnBackupNow.Size = new System.Drawing.Size(150, 33);
            btnBackupNow.TabIndex = 2;
            btnBackupNow.Text = "💾 Backup ngay";
            btnBackupNow.UseVisualStyleBackColor = false;
            // 
            // btnRestoreBackup
            // 
            btnRestoreBackup.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            btnRestoreBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRestoreBackup.FlatAppearance.BorderSize = 0;
            btnRestoreBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            btnRestoreBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(165, 105, 189);
            btnRestoreBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRestoreBackup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnRestoreBackup.ForeColor = System.Drawing.Color.White;
            btnRestoreBackup.Location = new System.Drawing.Point(291, 7);
            btnRestoreBackup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRestoreBackup.Name = "btnRestoreBackup";
            btnRestoreBackup.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnRestoreBackup.Size = new System.Drawing.Size(150, 33);
            btnRestoreBackup.TabIndex = 3;
            btnRestoreBackup.Text = "🔄 Restore";
            btnRestoreBackup.UseVisualStyleBackColor = false;
            // 
            // tabTimeout
            // 
            tabTimeout.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            tabTimeout.Controls.Add(panelDataGridContainer6);
            tabTimeout.Controls.Add(panelButtonContainer6);
            tabTimeout.Location = new System.Drawing.Point(4, 44);
            tabTimeout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabTimeout.Name = "tabTimeout";
            tabTimeout.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabTimeout.Size = new System.Drawing.Size(1232, 494);
            tabTimeout.TabIndex = 5;
            tabTimeout.Text = "⏱️ Timeout Session";
            // 
            // panelDataGridContainer6
            // 
            panelDataGridContainer6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelDataGridContainer6.BackColor = System.Drawing.Color.White;
            panelDataGridContainer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelDataGridContainer6.Controls.Add(dgvTimeoutSettings);
            panelDataGridContainer6.Location = new System.Drawing.Point(12, 69);
            panelDataGridContainer6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelDataGridContainer6.Name = "panelDataGridContainer6";
            panelDataGridContainer6.Size = new System.Drawing.Size(1210, 420);
            panelDataGridContainer6.TabIndex = 19;
            // 
            // dgvTimeoutSettings
            // 
            dgvTimeoutSettings.AllowUserToAddRows = false;
            dgvTimeoutSettings.AllowUserToDeleteRows = false;
            dgvTimeoutSettings.AllowUserToResizeRows = false;
            dgvTimeoutSettings.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvTimeoutSettings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvTimeoutSettings.BackgroundColor = System.Drawing.Color.White;
            dgvTimeoutSettings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvTimeoutSettings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTimeoutSettings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvTimeoutSettings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvTimeoutSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(232, 242, 252);
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvTimeoutSettings.DefaultCellStyle = dataGridViewCellStyle12;
            dgvTimeoutSettings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dgvTimeoutSettings.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
            dgvTimeoutSettings.Location = new System.Drawing.Point(1, 1);
            dgvTimeoutSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvTimeoutSettings.MultiSelect = false;
            dgvTimeoutSettings.Name = "dgvTimeoutSettings";
            dgvTimeoutSettings.ReadOnly = true;
            dgvTimeoutSettings.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvTimeoutSettings.RowHeadersVisible = false;
            dgvTimeoutSettings.RowHeadersWidth = 62;
            dgvTimeoutSettings.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            dgvTimeoutSettings.RowTemplate.Height = 45;
            dgvTimeoutSettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvTimeoutSettings.Size = new System.Drawing.Size(1206, 417);
            dgvTimeoutSettings.TabIndex = 0;
            // 
            // panelButtonContainer6
            // 
            panelButtonContainer6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelButtonContainer6.BackColor = System.Drawing.Color.White;
            panelButtonContainer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelButtonContainer6.Controls.Add(btnRefreshTimeout);
            panelButtonContainer6.Controls.Add(btnUpdateTimeout);
            panelButtonContainer6.Location = new System.Drawing.Point(12, 14);
            panelButtonContainer6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelButtonContainer6.Name = "panelButtonContainer6";
            panelButtonContainer6.Size = new System.Drawing.Size(1210, 47);
            panelButtonContainer6.TabIndex = 18;
            // 
            // btnRefreshTimeout
            // 
            btnRefreshTimeout.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnRefreshTimeout.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefreshTimeout.FlatAppearance.BorderSize = 0;
            btnRefreshTimeout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnRefreshTimeout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(72, 163, 228);
            btnRefreshTimeout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefreshTimeout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnRefreshTimeout.ForeColor = System.Drawing.Color.White;
            btnRefreshTimeout.Location = new System.Drawing.Point(12, 7);
            btnRefreshTimeout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRefreshTimeout.Name = "btnRefreshTimeout";
            btnRefreshTimeout.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnRefreshTimeout.Size = new System.Drawing.Size(117, 33);
            btnRefreshTimeout.TabIndex = 1;
            btnRefreshTimeout.Text = "🔄 Làm mới";
            btnRefreshTimeout.UseVisualStyleBackColor = false;
            // 
            // btnUpdateTimeout
            // 
            btnUpdateTimeout.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            btnUpdateTimeout.Cursor = System.Windows.Forms.Cursors.Hand;
            btnUpdateTimeout.FlatAppearance.BorderSize = 0;
            btnUpdateTimeout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            btnUpdateTimeout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 176, 65);
            btnUpdateTimeout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdateTimeout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnUpdateTimeout.ForeColor = System.Drawing.Color.White;
            btnUpdateTimeout.Location = new System.Drawing.Point(135, 7);
            btnUpdateTimeout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUpdateTimeout.Name = "btnUpdateTimeout";
            btnUpdateTimeout.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnUpdateTimeout.Size = new System.Drawing.Size(150, 33);
            btnUpdateTimeout.TabIndex = 2;
            btnUpdateTimeout.Text = "✏️ Cập nhật";
            btnUpdateTimeout.UseVisualStyleBackColor = false;
            // 
            // tabLoginHistory
            // 
            tabLoginHistory.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            tabLoginHistory.Controls.Add(panelDataGridContainer7);
            tabLoginHistory.Controls.Add(panelButtonContainer7);
            tabLoginHistory.Location = new System.Drawing.Point(4, 44);
            tabLoginHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabLoginHistory.Name = "tabLoginHistory";
            tabLoginHistory.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabLoginHistory.Size = new System.Drawing.Size(1232, 494);
            tabLoginHistory.TabIndex = 6;
            tabLoginHistory.Text = "📝 Lịch sử Đăng nhập";
            // 
            // panelDataGridContainer7
            // 
            panelDataGridContainer7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelDataGridContainer7.BackColor = System.Drawing.Color.White;
            panelDataGridContainer7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelDataGridContainer7.Controls.Add(dgvLoginHistory);
            panelDataGridContainer7.Location = new System.Drawing.Point(12, 69);
            panelDataGridContainer7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelDataGridContainer7.Name = "panelDataGridContainer7";
            panelDataGridContainer7.Size = new System.Drawing.Size(1210, 420);
            panelDataGridContainer7.TabIndex = 21;
            // 
            // dgvLoginHistory
            // 
            dgvLoginHistory.AllowUserToAddRows = false;
            dgvLoginHistory.AllowUserToDeleteRows = false;
            dgvLoginHistory.AllowUserToResizeRows = false;
            dgvLoginHistory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvLoginHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoginHistory.BackgroundColor = System.Drawing.Color.White;
            dgvLoginHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvLoginHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLoginHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvLoginHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvLoginHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(232, 242, 252);
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvLoginHistory.DefaultCellStyle = dataGridViewCellStyle14;
            dgvLoginHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dgvLoginHistory.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
            dgvLoginHistory.Location = new System.Drawing.Point(1, 1);
            dgvLoginHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvLoginHistory.MultiSelect = false;
            dgvLoginHistory.Name = "dgvLoginHistory";
            dgvLoginHistory.ReadOnly = true;
            dgvLoginHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvLoginHistory.RowHeadersVisible = false;
            dgvLoginHistory.RowHeadersWidth = 62;
            dgvLoginHistory.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            dgvLoginHistory.RowTemplate.Height = 45;
            dgvLoginHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvLoginHistory.Size = new System.Drawing.Size(1206, 417);
            dgvLoginHistory.TabIndex = 0;
            // 
            // panelButtonContainer7
            // 
            panelButtonContainer7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelButtonContainer7.BackColor = System.Drawing.Color.White;
            panelButtonContainer7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelButtonContainer7.Controls.Add(btnRefreshLoginHistory);
            panelButtonContainer7.Controls.Add(btnExportLoginHistory);
            panelButtonContainer7.Location = new System.Drawing.Point(12, 14);
            panelButtonContainer7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelButtonContainer7.Name = "panelButtonContainer7";
            panelButtonContainer7.Size = new System.Drawing.Size(1210, 47);
            panelButtonContainer7.TabIndex = 20;
            // 
            // btnRefreshLoginHistory
            // 
            btnRefreshLoginHistory.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnRefreshLoginHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefreshLoginHistory.FlatAppearance.BorderSize = 0;
            btnRefreshLoginHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnRefreshLoginHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(72, 163, 228);
            btnRefreshLoginHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefreshLoginHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnRefreshLoginHistory.ForeColor = System.Drawing.Color.White;
            btnRefreshLoginHistory.Location = new System.Drawing.Point(12, 7);
            btnRefreshLoginHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRefreshLoginHistory.Name = "btnRefreshLoginHistory";
            btnRefreshLoginHistory.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnRefreshLoginHistory.Size = new System.Drawing.Size(117, 33);
            btnRefreshLoginHistory.TabIndex = 1;
            btnRefreshLoginHistory.Text = "🔄 Làm mới";
            btnRefreshLoginHistory.UseVisualStyleBackColor = false;
            // 
            // btnExportLoginHistory
            // 
            btnExportLoginHistory.BackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            btnExportLoginHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExportLoginHistory.FlatAppearance.BorderSize = 0;
            btnExportLoginHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            btnExportLoginHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(72, 201, 176);
            btnExportLoginHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExportLoginHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnExportLoginHistory.ForeColor = System.Drawing.Color.White;
            btnExportLoginHistory.Location = new System.Drawing.Point(135, 7);
            btnExportLoginHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnExportLoginHistory.Name = "btnExportLoginHistory";
            btnExportLoginHistory.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            btnExportLoginHistory.Size = new System.Drawing.Size(150, 33);
            btnExportLoginHistory.TabIndex = 2;
            btnExportLoginHistory.Text = "📤 Xuất Excel";
            btnExportLoginHistory.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            panelHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelHeader.BackColor = System.Drawing.Color.White;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblCurrentUser);
            panelHeader.Controls.Add(btnPolicyManagement);
            panelHeader.Location = new System.Drawing.Point(10, 10);
            panelHeader.Margin = new System.Windows.Forms.Padding(2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(1240, 75);
            panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            lblTitle.Location = new System.Drawing.Point(12, 12);
            lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(328, 37);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "⚙️ Admin Control Panel";
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            lblCurrentUser.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblCurrentUser.Location = new System.Drawing.Point(17, 46);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new System.Drawing.Size(136, 23);
            lblCurrentUser.TabIndex = 1;
            lblCurrentUser.Text = "Xin chào: Admin";
            // 
            // btnPolicyManagement
            // 
            btnPolicyManagement.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnPolicyManagement.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnPolicyManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPolicyManagement.FlatAppearance.BorderSize = 0;
            btnPolicyManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(31, 97, 141);
            btnPolicyManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnPolicyManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPolicyManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            btnPolicyManagement.ForeColor = System.Drawing.Color.White;
            btnPolicyManagement.Location = new System.Drawing.Point(1056, 25);
            btnPolicyManagement.Margin = new System.Windows.Forms.Padding(2);
            btnPolicyManagement.Name = "btnPolicyManagement";
            btnPolicyManagement.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            btnPolicyManagement.Size = new System.Drawing.Size(167, 38);
            btnPolicyManagement.TabIndex = 2;
            btnPolicyManagement.Text = "📜 Quản lý Policy";
            btnPolicyManagement.UseVisualStyleBackColor = false;
            // 
            // panelFooter
            // 
            panelFooter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelFooter.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Location = new System.Drawing.Point(10, 642);
            panelFooter.Margin = new System.Windows.Forms.Padding(2);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new System.Drawing.Size(1240, 33);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblFooter.AutoSize = true;
            lblFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblFooter.ForeColor = System.Drawing.Color.White;
            lblFooter.Location = new System.Drawing.Point(555, 9);
            lblFooter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new System.Drawing.Size(131, 20);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Chat Server v1.0.0";
            // 
            // AdminPanelForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            ClientSize = new System.Drawing.Size(1266, 685);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Controls.Add(tabControl);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimumSize = new System.Drawing.Size(1211, 675);
            Name = "AdminPanelForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Admin Panel - Chat Server";
            tabControl.ResumeLayout(false);
            tabUsers.ResumeLayout(false);
            panelDataGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panelButtonContainer.ResumeLayout(false);
            tabConversations.ResumeLayout(false);
            panelDataGridContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvConversations).EndInit();
            panelButtonContainer2.ResumeLayout(false);
            tabMessages.ResumeLayout(false);
            panelDataGridContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMessages).EndInit();
            panelButtonContainer3.ResumeLayout(false);
            tabAuditLogs.ResumeLayout(false);
            panelDataGridContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).EndInit();
            panelButtonContainer4.ResumeLayout(false);
            tabBackupRestore.ResumeLayout(false);
            panelDataGridContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBackupHistory).EndInit();
            panelButtonContainer5.ResumeLayout(false);
            tabTimeout.ResumeLayout(false);
            panelDataGridContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTimeoutSettings).EndInit();
            panelButtonContainer6.ResumeLayout(false);
            tabLoginHistory.ResumeLayout(false);
            panelDataGridContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoginHistory).EndInit();
            panelButtonContainer7.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Panel panelDataGridContainer;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panelButtonContainer;
        private System.Windows.Forms.Button btnRefreshUsers;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnBanUser;
        private System.Windows.Forms.Button btnUnbanUser;
        private System.Windows.Forms.Button btnUnlockAccount;
        private System.Windows.Forms.TabPage tabConversations;
        private System.Windows.Forms.Panel panelDataGridContainer2;
        private System.Windows.Forms.DataGridView dgvConversations;
        private System.Windows.Forms.Panel panelButtonContainer2;
        private System.Windows.Forms.Button btnRefreshConversations;
        private System.Windows.Forms.Button btnDeleteConversation;
        private System.Windows.Forms.Button btnViewMessages;
        private System.Windows.Forms.TabPage tabMessages;
        private System.Windows.Forms.Panel panelDataGridContainer3;
        private System.Windows.Forms.DataGridView dgvMessages;
        private System.Windows.Forms.Panel panelButtonContainer3;
        private System.Windows.Forms.Button btnRefreshMessages;
        private System.Windows.Forms.Button btnDeleteMessage;
        private System.Windows.Forms.TabPage tabAuditLogs;
        private System.Windows.Forms.Panel panelDataGridContainer4;
        private System.Windows.Forms.DataGridView dgvAuditLogs;
        private System.Windows.Forms.Panel panelButtonContainer4;
        private System.Windows.Forms.Button btnRefreshLogs;
        private System.Windows.Forms.TabPage tabBackupRestore;
        private System.Windows.Forms.Panel panelDataGridContainer5;
        private System.Windows.Forms.DataGridView dgvBackupHistory;
        private System.Windows.Forms.Panel panelButtonContainer5;
        private System.Windows.Forms.Button btnRefreshBackup;
        private System.Windows.Forms.Button btnBackupNow;
        private System.Windows.Forms.Button btnRestoreBackup;
        private System.Windows.Forms.TabPage tabTimeout;
        private System.Windows.Forms.Panel panelDataGridContainer6;
        private System.Windows.Forms.DataGridView dgvTimeoutSettings;
        private System.Windows.Forms.Panel panelButtonContainer6;
        private System.Windows.Forms.Button btnRefreshTimeout;
        private System.Windows.Forms.Button btnUpdateTimeout;
        private System.Windows.Forms.TabPage tabLoginHistory;
        private System.Windows.Forms.Panel panelDataGridContainer7;
        private System.Windows.Forms.DataGridView dgvLoginHistory;
        private System.Windows.Forms.Panel panelButtonContainer7;
        private System.Windows.Forms.Button btnRefreshLoginHistory;
        private System.Windows.Forms.Button btnExportLoginHistory;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button btnPolicyManagement;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;
    }
}