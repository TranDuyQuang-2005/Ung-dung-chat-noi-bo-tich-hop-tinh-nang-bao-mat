//namespace ChatClient.Forms
//{
//    partial class ChatFormNew
//    {
//        private System.ComponentModel.IContainer components = null;

//        // Thêm biến để theo dõi tên người dùng
//        private string currentUsername = "test"; // Thay bằng tên thực

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
//            splitContainer = new SplitContainer();
//            pnlSidebar = new Panel();
//            pnlUserInfo = new Panel();
//            lblUserName = new Label();
//            lblUserStatus = new Label();
//            lstConversations = new ListView();
//            colName = new ColumnHeader();
//            colType = new ColumnHeader();
//            colTime = new ColumnHeader();
//            pnlConvButtons = new Panel();
//            btnSettings = new Button();
//            pnlHiddenButtons = new Panel();
//            btnCreateGroup = new Button();
//            btnPrivateChat = new Button();
//            btnViewMembers = new Button();
//            btnRefresh = new Button();
//            btnProfile = new Button();
//            btnLogout = new Button();
//            pnlChatArea = new Panel();
//            pnlHeader = new Panel();
//            lblChatTitle = new Label();
//            lblParticipantCount = new Label();
//            pnlMessages = new Panel();
//            pnlInput = new Panel();
//            pnlReply = new Panel();
//            lblReplyTo = new Label();
//            btnCancelReply = new Button();
//            txtMessage = new TextBox();
//            pnlInputControls = new Panel();
//            cbSecurityLabel = new ComboBox();
//            btnAttachment = new Button();
//            btnSend = new Button();
//            statusStrip = new StatusStrip();
//            lblStatus = new ToolStripStatusLabel();
//            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
//            splitContainer.Panel1.SuspendLayout();
//            splitContainer.Panel2.SuspendLayout();
//            splitContainer.SuspendLayout();
//            pnlSidebar.SuspendLayout();
//            pnlUserInfo.SuspendLayout();
//            pnlConvButtons.SuspendLayout();
//            pnlHiddenButtons.SuspendLayout();
//            pnlChatArea.SuspendLayout();
//            pnlHeader.SuspendLayout();
//            pnlInput.SuspendLayout();
//            pnlReply.SuspendLayout();
//            pnlInputControls.SuspendLayout();
//            statusStrip.SuspendLayout();
//            SuspendLayout();
//            // 
//            // splitContainer
//            // 
//            splitContainer.Dock = DockStyle.Fill;
//            splitContainer.FixedPanel = FixedPanel.Panel1;
//            splitContainer.Location = new Point(0, 0);
//            splitContainer.Margin = new Padding(2, 2, 2, 2);
//            splitContainer.Name = "splitContainer";
//            // 
//            // splitContainer.Panel1
//            // 
//            splitContainer.Panel1.BackColor = Color.FromArgb(248, 250, 252);
//            splitContainer.Panel1.Controls.Add(pnlSidebar);
//            splitContainer.Panel1MinSize = 300;
//            // 
//            // splitContainer.Panel2
//            // 
//            splitContainer.Panel2.BackColor = Color.White;
//            splitContainer.Panel2.Controls.Add(pnlChatArea);
//            splitContainer.Size = new Size(960, 655);
//            splitContainer.SplitterDistance = 240;
//            splitContainer.SplitterWidth = 1;
//            splitContainer.TabIndex = 0;
//            // 
//            // pnlSidebar
//            // 
//            pnlSidebar.BackColor = Color.White;
//            pnlSidebar.BorderStyle = BorderStyle.FixedSingle;
//            pnlSidebar.Controls.Add(pnlUserInfo);
//            pnlSidebar.Controls.Add(lstConversations);
//            pnlSidebar.Controls.Add(pnlConvButtons);
//            pnlSidebar.Dock = DockStyle.Fill;
//            pnlSidebar.Location = new Point(0, 0);
//            pnlSidebar.Margin = new Padding(2, 2, 2, 2);
//            pnlSidebar.Name = "pnlSidebar";
//            pnlSidebar.Size = new Size(240, 655);
//            pnlSidebar.TabIndex = 2;
//            // 
//            // pnlUserInfo
//            // 
//            pnlUserInfo.BackColor = Color.FromArgb(41, 128, 185);
//            pnlUserInfo.Controls.Add(lblUserName);
//            pnlUserInfo.Controls.Add(lblUserStatus);
//            pnlUserInfo.Dock = DockStyle.Top;
//            pnlUserInfo.Location = new Point(0, 0);
//            pnlUserInfo.Margin = new Padding(2, 2, 2, 2);
//            pnlUserInfo.Name = "pnlUserInfo";
//            pnlUserInfo.Padding = new Padding(8, 6, 8, 6);
//            pnlUserInfo.Size = new Size(238, 64);
//            pnlUserInfo.TabIndex = 3;
//            // 
//            // lblUserName
//            // 
//            lblUserName.AutoSize = true;
//            lblUserName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
//            lblUserName.ForeColor = Color.White;
//            lblUserName.Location = new Point(8, 8);
//            lblUserName.Margin = new Padding(2, 0, 2, 0);
//            lblUserName.Name = "lblUserName";
//            lblUserName.Size = new Size(141, 25);
//            lblUserName.TabIndex = 0;
//            lblUserName.Text = "Người dùng: ...";
//            // 
//            // lblUserStatus
//            // 
//            lblUserStatus.AutoSize = true;
//            lblUserStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
//            lblUserStatus.ForeColor = Color.FromArgb(200, 230, 255);
//            lblUserStatus.Location = new Point(8, 38);
//            lblUserStatus.Margin = new Padding(2, 0, 2, 0);
//            lblUserStatus.Name = "lblUserStatus";
//            lblUserStatus.Size = new Size(102, 20);
//            lblUserStatus.TabIndex = 1;
//            lblUserStatus.Text = "\U0001f7e2 Trực tuyến";
//            // 
//            // lstConversations
//            // 
//            lstConversations.BackColor = Color.White;
//            lstConversations.BorderStyle = BorderStyle.None;
//            lstConversations.Columns.AddRange(new ColumnHeader[] { colName, colType, colTime });
//            lstConversations.Dock = DockStyle.Fill;
//            lstConversations.Font = new Font("Segoe UI", 9.5F);
//            lstConversations.FullRowSelect = true;
//            lstConversations.HeaderStyle = ColumnHeaderStyle.Nonclickable;
//            lstConversations.Location = new Point(0, 0);
//            lstConversations.Margin = new Padding(2, 2, 2, 2);
//            lstConversations.MultiSelect = false;
//            lstConversations.Name = "lstConversations";
//            lstConversations.ShowGroups = false;
//            lstConversations.Size = new Size(238, 430);
//            lstConversations.TabIndex = 0;
//            lstConversations.UseCompatibleStateImageBehavior = false;
//            lstConversations.View = View.Details;
//            // 
//            // colName
//            // 
//            colName.Text = "Cuộc trò chuyện";
//            colName.Width = 160;
//            // 
//            // colType
//            // 
//            colType.Text = "Loại";
//            // 
//            // colTime
//            // 
//            colTime.Text = "Thời gian";
//            // 
//            // pnlConvButtons
//            // 
//            pnlConvButtons.BackColor = Color.White;
//            pnlConvButtons.Controls.Add(btnSettings);
//            pnlConvButtons.Controls.Add(pnlHiddenButtons);
//            pnlConvButtons.Dock = DockStyle.Bottom;
//            pnlConvButtons.Location = new Point(0, 430);
//            pnlConvButtons.Margin = new Padding(2, 2, 2, 2);
//            pnlConvButtons.Name = "pnlConvButtons";
//            pnlConvButtons.Padding = new Padding(6, 6, 6, 6);
//            pnlConvButtons.Size = new Size(238, 223);
//            pnlConvButtons.TabIndex = 1;
//            // 
//            // btnSettings
//            // 
//            btnSettings.BackColor = Color.FromArgb(108, 117, 125);
//            btnSettings.Cursor = Cursors.Hand;
//            btnSettings.Dock = DockStyle.Top;
//            btnSettings.FlatAppearance.BorderSize = 0;
//            btnSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
//            btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(134, 142, 150);
//            btnSettings.FlatStyle = FlatStyle.Flat;
//            btnSettings.Font = new Font("Segoe UI", 9.5F);
//            btnSettings.ForeColor = Color.White;
//            btnSettings.Location = new Point(6, 189);
//            btnSettings.Margin = new Padding(2, 2, 2, 2);
//            btnSettings.Name = "btnSettings";
//            btnSettings.Size = new Size(226, 30);
//            btnSettings.TabIndex = 0;
//            btnSettings.Text = "⚙ Cài đặt";
//            btnSettings.UseVisualStyleBackColor = false;
//            btnSettings.Click += btnSettings_Click;
//            // 
//            // pnlHiddenButtons
//            // 
//            pnlHiddenButtons.BackColor = Color.FromArgb(250, 250, 250);
//            pnlHiddenButtons.BorderStyle = BorderStyle.FixedSingle;
//            pnlHiddenButtons.Controls.Add(btnCreateGroup);
//            pnlHiddenButtons.Controls.Add(btnPrivateChat);
//            pnlHiddenButtons.Controls.Add(btnViewMembers);
//            pnlHiddenButtons.Controls.Add(btnRefresh);
//            pnlHiddenButtons.Controls.Add(btnProfile);
//            pnlHiddenButtons.Controls.Add(btnLogout);
//            pnlHiddenButtons.Dock = DockStyle.Top;
//            pnlHiddenButtons.Location = new Point(6, 6);
//            pnlHiddenButtons.Margin = new Padding(2, 2, 2, 2);
//            pnlHiddenButtons.Name = "pnlHiddenButtons";
//            pnlHiddenButtons.Size = new Size(226, 183);
//            pnlHiddenButtons.TabIndex = 6;
//            pnlHiddenButtons.Visible = false;
//            // 
//            // btnCreateGroup
//            // 
//            btnCreateGroup.BackColor = Color.FromArgb(52, 152, 219);
//            btnCreateGroup.Cursor = Cursors.Hand;
//            btnCreateGroup.Dock = DockStyle.Top;
//            btnCreateGroup.FlatAppearance.BorderSize = 0;
//            btnCreateGroup.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
//            btnCreateGroup.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 163, 228);
//            btnCreateGroup.FlatStyle = FlatStyle.Flat;
//            btnCreateGroup.Font = new Font("Segoe UI", 9.5F);
//            btnCreateGroup.ForeColor = Color.White;
//            btnCreateGroup.Location = new Point(0, 150);
//            btnCreateGroup.Margin = new Padding(2, 2, 2, 2);
//            btnCreateGroup.Name = "btnCreateGroup";
//            btnCreateGroup.Size = new Size(224, 30);
//            btnCreateGroup.TabIndex = 0;
//            btnCreateGroup.Text = "➕ Tạo nhóm mới";
//            btnCreateGroup.UseVisualStyleBackColor = false;
//            // 
//            // btnPrivateChat
//            // 
//            btnPrivateChat.BackColor = Color.FromArgb(52, 152, 219);
//            btnPrivateChat.Cursor = Cursors.Hand;
//            btnPrivateChat.Dock = DockStyle.Top;
//            btnPrivateChat.FlatAppearance.BorderSize = 0;
//            btnPrivateChat.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
//            btnPrivateChat.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 163, 228);
//            btnPrivateChat.FlatStyle = FlatStyle.Flat;
//            btnPrivateChat.Font = new Font("Segoe UI", 9.5F);
//            btnPrivateChat.ForeColor = Color.White;
//            btnPrivateChat.Location = new Point(0, 120);
//            btnPrivateChat.Margin = new Padding(2, 2, 2, 2);
//            btnPrivateChat.Name = "btnPrivateChat";
//            btnPrivateChat.Size = new Size(224, 30);
//            btnPrivateChat.TabIndex = 1;
//            btnPrivateChat.Text = "💬 Chat riêng";
//            btnPrivateChat.UseVisualStyleBackColor = false;
//            // 
//            // btnViewMembers
//            // 
//            btnViewMembers.BackColor = Color.FromArgb(52, 152, 219);
//            btnViewMembers.Cursor = Cursors.Hand;
//            btnViewMembers.Dock = DockStyle.Top;
//            btnViewMembers.FlatAppearance.BorderSize = 0;
//            btnViewMembers.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
//            btnViewMembers.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 163, 228);
//            btnViewMembers.FlatStyle = FlatStyle.Flat;
//            btnViewMembers.Font = new Font("Segoe UI", 9.5F);
//            btnViewMembers.ForeColor = Color.White;
//            btnViewMembers.Location = new Point(0, 90);
//            btnViewMembers.Margin = new Padding(2, 2, 2, 2);
//            btnViewMembers.Name = "btnViewMembers";
//            btnViewMembers.Size = new Size(224, 30);
//            btnViewMembers.TabIndex = 2;
//            btnViewMembers.Text = "👥 Xem thành viên";
//            btnViewMembers.UseVisualStyleBackColor = false;
//            // 
//            // btnRefresh
//            // 
//            btnRefresh.BackColor = Color.FromArgb(52, 152, 219);
//            btnRefresh.Cursor = Cursors.Hand;
//            btnRefresh.Dock = DockStyle.Top;
//            btnRefresh.FlatAppearance.BorderSize = 0;
//            btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
//            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 163, 228);
//            btnRefresh.FlatStyle = FlatStyle.Flat;
//            btnRefresh.Font = new Font("Segoe UI", 9.5F);
//            btnRefresh.ForeColor = Color.White;
//            btnRefresh.Location = new Point(0, 60);
//            btnRefresh.Margin = new Padding(2, 2, 2, 2);
//            btnRefresh.Name = "btnRefresh";
//            btnRefresh.Size = new Size(224, 30);
//            btnRefresh.TabIndex = 3;
//            btnRefresh.Text = "🔄 Làm mới";
//            btnRefresh.UseVisualStyleBackColor = false;
//            // 
//            // btnProfile
//            // 
//            btnProfile.BackColor = Color.FromArgb(52, 152, 219);
//            btnProfile.Cursor = Cursors.Hand;
//            btnProfile.Dock = DockStyle.Top;
//            btnProfile.FlatAppearance.BorderSize = 0;
//            btnProfile.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
//            btnProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 163, 228);
//            btnProfile.FlatStyle = FlatStyle.Flat;
//            btnProfile.Font = new Font("Segoe UI", 9.5F);
//            btnProfile.ForeColor = Color.White;
//            btnProfile.Location = new Point(0, 30);
//            btnProfile.Margin = new Padding(2, 2, 2, 2);
//            btnProfile.Name = "btnProfile";
//            btnProfile.Size = new Size(224, 30);
//            btnProfile.TabIndex = 4;
//            btnProfile.Text = "👤 Hồ sơ cá nhân";
//            btnProfile.UseVisualStyleBackColor = false;
//            // 
//            // btnLogout
//            // 
//            btnLogout.BackColor = Color.FromArgb(231, 76, 60);
//            btnLogout.Cursor = Cursors.Hand;
//            btnLogout.Dock = DockStyle.Top;
//            btnLogout.FlatAppearance.BorderSize = 0;
//            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
//            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 108, 93);
//            btnLogout.FlatStyle = FlatStyle.Flat;
//            btnLogout.Font = new Font("Segoe UI", 9.5F);
//            btnLogout.ForeColor = Color.White;
//            btnLogout.Location = new Point(0, 0);
//            btnLogout.Margin = new Padding(2, 2, 2, 2);
//            btnLogout.Name = "btnLogout";
//            btnLogout.Size = new Size(224, 30);
//            btnLogout.TabIndex = 5;
//            btnLogout.Text = "🚪 Đăng xuất";
//            btnLogout.UseVisualStyleBackColor = false;
//            // 
//            // pnlChatArea
//            // 
//            pnlChatArea.BackColor = Color.White;
//            pnlChatArea.Controls.Add(pnlHeader);
//            pnlChatArea.Controls.Add(pnlMessages);
//            pnlChatArea.Controls.Add(pnlInput);
//            pnlChatArea.Dock = DockStyle.Fill;
//            pnlChatArea.Location = new Point(0, 0);
//            pnlChatArea.Margin = new Padding(2, 2, 2, 2);
//            pnlChatArea.Name = "pnlChatArea";
//            pnlChatArea.Size = new Size(719, 655);
//            pnlChatArea.TabIndex = 0;
//            // 
//            // pnlHeader
//            // 
//            pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
//            pnlHeader.Controls.Add(lblChatTitle);
//            pnlHeader.Controls.Add(lblParticipantCount);
//            pnlHeader.Dock = DockStyle.Top;
//            pnlHeader.Location = new Point(0, 0);
//            pnlHeader.Margin = new Padding(2, 2, 2, 2);
//            pnlHeader.Name = "pnlHeader";
//            pnlHeader.Padding = new Padding(12, 6, 12, 6);
//            pnlHeader.Size = new Size(719, 65);
//            pnlHeader.TabIndex = 3;
//            // 
//            // lblChatTitle
//            // 
//            lblChatTitle.AutoSize = true;
//            lblChatTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
//            lblChatTitle.ForeColor = Color.White;
//            lblChatTitle.Location = new Point(12, 14);
//            lblChatTitle.Margin = new Padding(2, 0, 2, 0);
//            lblChatTitle.Name = "lblChatTitle";
//            lblChatTitle.Size = new Size(268, 30);
//            lblChatTitle.TabIndex = 0;
//            lblChatTitle.Text = "💬 Chọn cuộc trò chuyện";
//            // 
//            // lblParticipantCount
//            // 
//            lblParticipantCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//            lblParticipantCount.AutoSize = true;
//            lblParticipantCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
//            lblParticipantCount.ForeColor = Color.FromArgb(200, 230, 255);
//            lblParticipantCount.Location = new Point(552, 20);
//            lblParticipantCount.Margin = new Padding(2, 0, 2, 0);
//            lblParticipantCount.Name = "lblParticipantCount";
//            lblParticipantCount.Size = new Size(120, 20);
//            lblParticipantCount.TabIndex = 1;
//            lblParticipantCount.Text = "0 người tham gia";
//            lblParticipantCount.TextAlign = ContentAlignment.MiddleRight;
//            // 
//            // pnlMessages
//            // 
//            pnlMessages.AutoScroll = true;
//            pnlMessages.BackColor = Color.FromArgb(248, 250, 252);
//            pnlMessages.Dock = DockStyle.Fill;
//            pnlMessages.Location = new Point(0, 0);
//            pnlMessages.Margin = new Padding(2, 2, 2, 2);
//            pnlMessages.Name = "pnlMessages";
//            pnlMessages.Padding = new Padding(10, 10, 10, 10);
//            pnlMessages.Size = new Size(719, 477);
//            pnlMessages.TabIndex = 1;
//            // 
//            // pnlInput
//            // 
//            pnlInput.BackColor = Color.White;
//            pnlInput.BorderStyle = BorderStyle.FixedSingle;
//            pnlInput.Controls.Add(pnlReply);
//            pnlInput.Controls.Add(txtMessage);
//            pnlInput.Controls.Add(pnlInputControls);
//            pnlInput.Dock = DockStyle.Bottom;
//            pnlInput.Location = new Point(0, 477);
//            pnlInput.Margin = new Padding(2, 2, 2, 2);
//            pnlInput.Name = "pnlInput";
//            pnlInput.Padding = new Padding(10, 10, 10, 10);
//            pnlInput.Size = new Size(719, 178);
//            pnlInput.TabIndex = 2;
//            // 
//            // pnlReply
//            // 
//            pnlReply.BackColor = Color.FromArgb(232, 242, 252);
//            pnlReply.Controls.Add(lblReplyTo);
//            pnlReply.Controls.Add(btnCancelReply);
//            pnlReply.Dock = DockStyle.Top;
//            pnlReply.Location = new Point(10, 10);
//            pnlReply.Margin = new Padding(2, 2, 2, 2);
//            pnlReply.Name = "pnlReply";
//            pnlReply.Size = new Size(697, 29);
//            pnlReply.TabIndex = 0;
//            pnlReply.Visible = false;
//            // 
//            // lblReplyTo
//            // 
//            lblReplyTo.AutoSize = true;
//            lblReplyTo.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
//            lblReplyTo.ForeColor = Color.FromArgb(41, 128, 185);
//            lblReplyTo.Location = new Point(8, 6);
//            lblReplyTo.Margin = new Padding(2, 0, 2, 0);
//            lblReplyTo.Name = "lblReplyTo";
//            lblReplyTo.Size = new Size(83, 20);
//            lblReplyTo.TabIndex = 0;
//            lblReplyTo.Text = "↩ Trả lời: ...";
//            // 
//            // btnCancelReply
//            // 
//            btnCancelReply.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//            btnCancelReply.BackColor = Color.Transparent;
//            btnCancelReply.FlatAppearance.BorderSize = 0;
//            btnCancelReply.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 200, 200);
//            btnCancelReply.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 230);
//            btnCancelReply.FlatStyle = FlatStyle.Flat;
//            btnCancelReply.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
//            btnCancelReply.ForeColor = Color.FromArgb(150, 150, 150);
//            btnCancelReply.Location = new Point(668, 2);
//            btnCancelReply.Margin = new Padding(2, 2, 2, 2);
//            btnCancelReply.Name = "btnCancelReply";
//            btnCancelReply.Size = new Size(27, 26);
//            btnCancelReply.TabIndex = 1;
//            btnCancelReply.Text = "✕";
//            btnCancelReply.UseVisualStyleBackColor = false;
//            // 
//            // txtMessage
//            // 
//            txtMessage.BorderStyle = BorderStyle.FixedSingle;
//            txtMessage.Dock = DockStyle.Fill;
//            txtMessage.Font = new Font("Segoe UI", 10F);
//            txtMessage.Location = new Point(10, 10);
//            txtMessage.Margin = new Padding(2, 2, 2, 2);
//            txtMessage.Multiline = true;
//            txtMessage.Name = "txtMessage";
//            txtMessage.PlaceholderText = "Nhập tin nhắn của bạn...";
//            txtMessage.ScrollBars = ScrollBars.Vertical;
//            txtMessage.Size = new Size(697, 126);
//            txtMessage.TabIndex = 1;
//            // 
//            // pnlInputControls
//            // 
//            pnlInputControls.BackColor = Color.White;
//            pnlInputControls.Controls.Add(cbSecurityLabel);
//            pnlInputControls.Controls.Add(btnAttachment);
//            pnlInputControls.Controls.Add(btnSend);
//            pnlInputControls.Dock = DockStyle.Bottom;
//            pnlInputControls.Location = new Point(10, 136);
//            pnlInputControls.Margin = new Padding(2, 2, 2, 2);
//            pnlInputControls.Name = "pnlInputControls";
//            pnlInputControls.Size = new Size(697, 30);
//            pnlInputControls.TabIndex = 5;
//            // 
//            // cbSecurityLabel
//            // 
//            cbSecurityLabel.DropDownStyle = ComboBoxStyle.DropDownList;
//            cbSecurityLabel.FlatStyle = FlatStyle.Flat;
//            cbSecurityLabel.Font = new Font("Segoe UI", 9F);
//            cbSecurityLabel.FormattingEnabled = true;
//            cbSecurityLabel.Location = new Point(0, 0);
//            cbSecurityLabel.Margin = new Padding(2, 2, 2, 2);
//            cbSecurityLabel.Name = "cbSecurityLabel";
//            cbSecurityLabel.Size = new Size(129, 28);
//            cbSecurityLabel.TabIndex = 2;
//            // 
//            // btnAttachment
//            // 
//            btnAttachment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//            btnAttachment.BackColor = Color.FromArgb(52, 152, 219);
//            btnAttachment.Cursor = Cursors.Hand;
//            btnAttachment.FlatAppearance.BorderSize = 0;
//            btnAttachment.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
//            btnAttachment.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 163, 228);
//            btnAttachment.FlatStyle = FlatStyle.Flat;
//            btnAttachment.Font = new Font("Segoe UI", 10F);
//            btnAttachment.ForeColor = Color.White;
//            btnAttachment.Location = new Point(449, 0);
//            btnAttachment.Margin = new Padding(2, 2, 2, 2);
//            btnAttachment.Name = "btnAttachment";
//            btnAttachment.Size = new Size(112, 29);
//            btnAttachment.TabIndex = 3;
//            btnAttachment.Text = "📎 Đính kèm";
//            btnAttachment.UseVisualStyleBackColor = false;
//            // 
//            // btnSend
//            // 
//            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//            btnSend.BackColor = Color.FromArgb(52, 152, 219);
//            btnSend.Cursor = Cursors.Hand;
//            btnSend.FlatAppearance.BorderSize = 0;
//            btnSend.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 132, 73);
//            btnSend.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 202, 106);
//            btnSend.FlatStyle = FlatStyle.Flat;
//            btnSend.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
//            btnSend.ForeColor = Color.White;
//            btnSend.Location = new Point(565, 0);
//            btnSend.Margin = new Padding(2, 2, 2, 2);
//            btnSend.Name = "btnSend";
//            btnSend.Size = new Size(132, 29);
//            btnSend.TabIndex = 4;
//            btnSend.Text = "Gửi tin nhắn ➤";
//            btnSend.UseVisualStyleBackColor = false;
//            // 
//            // statusStrip
//            // 
//            statusStrip.BackColor = Color.FromArgb(41, 128, 185);
//            statusStrip.ImageScalingSize = new Size(20, 20);
//            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus });
//            statusStrip.Location = new Point(0, 655);
//            statusStrip.Name = "statusStrip";
//            statusStrip.Padding = new Padding(1, 0, 10, 0);
//            statusStrip.Size = new Size(960, 26);
//            statusStrip.TabIndex = 1;
//            statusStrip.Text = "statusStrip1";
//            // 
//            // lblStatus
//            // 
//            lblStatus.ForeColor = Color.White;
//            lblStatus.Name = "lblStatus";
//            lblStatus.Size = new Size(93, 20);
//            lblStatus.Text = "\U0001f7e2 Sẵn sàng";
//            // 
//            // ChatFormNew
//            // 
//            AutoScaleDimensions = new SizeF(8F, 20F);
//            AutoScaleMode = AutoScaleMode.Font;
//            BackColor = Color.White;
//            ClientSize = new Size(960, 681);
//            Controls.Add(splitContainer);
//            Controls.Add(statusStrip);
//            Font = new Font("Segoe UI", 9F);
//            Margin = new Padding(2, 2, 2, 2);
//            MinimumSize = new Size(724, 449);
//            Name = "ChatFormNew";
//            StartPosition = FormStartPosition.CenterScreen;
//            Text = "💬 Chat Application";
//            Load += ChatFormNew_Load;
//            splitContainer.Panel1.ResumeLayout(false);
//            splitContainer.Panel2.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
//            splitContainer.ResumeLayout(false);
//            pnlSidebar.ResumeLayout(false);
//            pnlUserInfo.ResumeLayout(false);
//            pnlUserInfo.PerformLayout();
//            pnlConvButtons.ResumeLayout(false);
//            pnlHiddenButtons.ResumeLayout(false);
//            pnlChatArea.ResumeLayout(false);
//            pnlHeader.ResumeLayout(false);
//            pnlHeader.PerformLayout();
//            pnlInput.ResumeLayout(false);
//            pnlInput.PerformLayout();
//            pnlReply.ResumeLayout(false);
//            pnlReply.PerformLayout();
//            pnlInputControls.ResumeLayout(false);
//            statusStrip.ResumeLayout(false);
//            statusStrip.PerformLayout();
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private System.Windows.Forms.SplitContainer splitContainer;
//        private System.Windows.Forms.Panel pnlSidebar;
//        private System.Windows.Forms.Panel pnlUserInfo;
//        private System.Windows.Forms.Label lblUserName;
//        private System.Windows.Forms.Label lblUserStatus;
//        private System.Windows.Forms.ListView lstConversations;
//        private System.Windows.Forms.ColumnHeader colName;
//        private System.Windows.Forms.ColumnHeader colType;
//        private System.Windows.Forms.ColumnHeader colTime;
//        private System.Windows.Forms.Panel pnlConvButtons;
//        private System.Windows.Forms.Button btnLogout;
//        private System.Windows.Forms.Button btnProfile;
//        private System.Windows.Forms.Button btnRefresh;
//        private System.Windows.Forms.Button btnViewMembers;
//        private System.Windows.Forms.Button btnPrivateChat;
//        private System.Windows.Forms.Button btnCreateGroup;
//        private System.Windows.Forms.Panel pnlChatArea;
//        private System.Windows.Forms.Panel pnlHeader;
//        private System.Windows.Forms.Label lblChatTitle;
//        private System.Windows.Forms.Label lblParticipantCount;
//        private System.Windows.Forms.Panel pnlMessages;
//        private System.Windows.Forms.Panel pnlInput;
//        private System.Windows.Forms.Panel pnlReply;
//        private System.Windows.Forms.Label lblReplyTo;
//        private System.Windows.Forms.Button btnCancelReply;
//        private System.Windows.Forms.TextBox txtMessage;
//        private System.Windows.Forms.Panel pnlInputControls;
//        private System.Windows.Forms.ComboBox cbSecurityLabel;
//        private System.Windows.Forms.Button btnAttachment;
//        private System.Windows.Forms.Button btnSend;
//        private System.Windows.Forms.StatusStrip statusStrip;
//        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
//        private System.Windows.Forms.Panel pnlHiddenButtons;
//        private System.Windows.Forms.Button btnSettings;

//        // Thêm biến để theo dõi trạng thái panel
//        private bool isSettingsPanelOpen = false;

//        private void btnSettings_Click(object sender, EventArgs e)
//        {
//            ToggleSettingsPanel();
//        }

//        private void ToggleSettingsPanel()
//        {
//            isSettingsPanelOpen = !isSettingsPanelOpen;
//            pnlHiddenButtons.Visible = isSettingsPanelOpen;

//            if (isSettingsPanelOpen)
//            {
//                btnSettings.Text = "⚙ Đóng";
//            }
//            else
//            {
//                btnSettings.Text = "⚙ Cài đặt";
//            }
//        }

//        private void ChatFormNew_Load(object sender, EventArgs e)
//        {
//            // Cập nhật tên người dùng khi form load
//            UpdateUserInfo();

//            // Thêm sự kiện click cho form để đóng panel khi click ra ngoài
//            this.Click += (s, args) =>
//            {
//                if (isSettingsPanelOpen && !pnlHiddenButtons.Bounds.Contains(PointToClient(Cursor.Position)))
//                {
//                    ToggleSettingsPanel();
//                }
//            };

//            // Thêm sự kiện click cho các panel khác
//            pnlSidebar.Click += (s, args) =>
//            {
//                if (isSettingsPanelOpen && !pnlHiddenButtons.Bounds.Contains(PointToClient(Cursor.Position)))
//                {
//                    ToggleSettingsPanel();
//                }
//            };

//            pnlUserInfo.Click += (s, args) =>
//            {
//                if (isSettingsPanelOpen && !pnlHiddenButtons.Bounds.Contains(PointToClient(Cursor.Position)))
//                {
//                    ToggleSettingsPanel();
//                }
//            };

//            lstConversations.Click += (s, args) =>
//            {
//                if (isSettingsPanelOpen && !pnlHiddenButtons.Bounds.Contains(PointToClient(Cursor.Position)))
//                {
//                    ToggleSettingsPanel();
//                }
//            };
//        }

//        private void UpdateUserInfo()
//        {
//            // Cập nhật tên người dùng (thay bằng tên thực từ database hoặc session)
//            lblUserName.Text = $"Người dùng: {currentUsername}";

//            // Nếu có avatar, có thể thêm ở đây
//            // picUserAvatar.Image = ...
//        }

//        // Thêm phương thức để thiết lập tên người dùng từ bên ngoài
//        public void SetCurrentUser(string username)
//        {
//            currentUsername = username;
//            if (lblUserName != null)
//            {
//                lblUserName.Text = $"Người dùng: {currentUsername}";
//            }
//        }
//    }
//}

namespace ChatClient.Forms
{
    partial class ChatFormNew
    {
        private System.ComponentModel.IContainer components = null;

        // Thêm biến để theo dõi tên người dùng
        private string currentUsername = "test"; // Thay bằng tên thực

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
            splitContainer = new SplitContainer();
            pnlSidebar = new Panel();
            pnlUserInfo = new Panel();
            lblUserName = new Label();
            lblUserStatus = new Label();
            lstConversations = new ListView();
            colName = new ColumnHeader();
            colType = new ColumnHeader();
            colTime = new ColumnHeader();
            pnlConvButtons = new Panel();
            btnSettings = new Button();
            pnlHiddenButtons = new Panel();
            btnCreateGroup = new Button();
            btnPrivateChat = new Button();
            btnViewMembers = new Button();
            btnRefresh = new Button();
            btnProfile = new Button();
            btnLogout = new Button();
            pnlChatArea = new Panel();
            pnlHeader = new Panel();
            lblChatTitle = new Label();
            lblParticipantCount = new Label();
            pnlMessages = new Panel();
            pnlInput = new Panel();
            pnlReply = new Panel();
            lblReplyTo = new Label();
            btnCancelReply = new Button();
            txtMessage = new TextBox();
            pnlInputControls = new Panel();
            cbSecurityLabel = new ComboBox();
            btnAttachment = new Button();
            btnSend = new Button();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlUserInfo.SuspendLayout();
            pnlConvButtons.SuspendLayout();
            pnlHiddenButtons.SuspendLayout();
            pnlChatArea.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlInput.SuspendLayout();
            pnlReply.SuspendLayout();
            pnlInputControls.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.FixedPanel = FixedPanel.Panel1;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Margin = new Padding(2, 2, 2, 2);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.BackColor = Color.FromArgb(248, 250, 252);
            splitContainer.Panel1.Controls.Add(pnlSidebar);
            splitContainer.Panel1MinSize = 300;
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.BackColor = Color.White;
            splitContainer.Panel2.Controls.Add(pnlChatArea);
            splitContainer.Size = new Size(960, 655);
            splitContainer.SplitterDistance = 240;
            splitContainer.SplitterWidth = 1;
            splitContainer.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.BorderStyle = BorderStyle.FixedSingle;
            pnlSidebar.Controls.Add(lstConversations);
            pnlSidebar.Controls.Add(pnlConvButtons);
            pnlSidebar.Controls.Add(pnlUserInfo);
            pnlSidebar.Dock = DockStyle.Fill;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(2, 2, 2, 2);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(240, 655);
            pnlSidebar.TabIndex = 2;
            // 
            // pnlUserInfo
            // 
            pnlUserInfo.BackColor = Color.FromArgb(41, 128, 185);
            pnlUserInfo.Controls.Add(lblUserName);
            pnlUserInfo.Controls.Add(lblUserStatus);
            pnlUserInfo.Dock = DockStyle.Top;
            pnlUserInfo.Location = new Point(0, 0);
            pnlUserInfo.Margin = new Padding(2, 2, 2, 2);
            pnlUserInfo.Name = "pnlUserInfo";
            pnlUserInfo.Padding = new Padding(8, 6, 8, 6);
            pnlUserInfo.Size = new Size(238, 64);
            pnlUserInfo.TabIndex = 3;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(8, 8);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(141, 25);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Người dùng: ...";
            // 
            // lblUserStatus
            // 
            lblUserStatus.AutoSize = true;
            lblUserStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblUserStatus.ForeColor = Color.FromArgb(200, 230, 255);
            lblUserStatus.Location = new Point(8, 38);
            lblUserStatus.Margin = new Padding(2, 0, 2, 0);
            lblUserStatus.Name = "lblUserStatus";
            lblUserStatus.Size = new Size(102, 20);
            lblUserStatus.TabIndex = 1;
            lblUserStatus.Text = "\U0001f7e2 Trực tuyến";
            // 
            // lstConversations
            // 
            lstConversations.BackColor = Color.White;
            lstConversations.BorderStyle = BorderStyle.None;
            lstConversations.Columns.AddRange(new ColumnHeader[] { colName, colType, colTime });
            lstConversations.Dock = DockStyle.Fill;
            lstConversations.Font = new Font("Segoe UI", 9.5F);
            lstConversations.FullRowSelect = true;
            lstConversations.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstConversations.Location = new Point(0, 64);
            lstConversations.Margin = new Padding(2, 2, 2, 2);
            lstConversations.MultiSelect = false;
            lstConversations.Name = "lstConversations";
            lstConversations.ShowGroups = false;
            lstConversations.Size = new Size(238, 368);
            lstConversations.TabIndex = 0;
            lstConversations.UseCompatibleStateImageBehavior = false;
            lstConversations.View = View.Details;
            // 
            // colName
            // 
            colName.Text = "Cuộc trò chuyện";
            colName.Width = 160;
            // 
            // colType
            // 
            colType.Text = "Loại";
            // 
            // colTime
            // 
            colTime.Text = "Thời gian";
            // 
            // pnlConvButtons
            // 
            pnlConvButtons.BackColor = Color.White;
            pnlConvButtons.Controls.Add(btnSettings);
            pnlConvButtons.Controls.Add(pnlHiddenButtons);
            pnlConvButtons.Dock = DockStyle.Bottom;
            pnlConvButtons.Location = new Point(0, 432);
            pnlConvButtons.Margin = new Padding(2, 2, 2, 2);
            pnlConvButtons.Name = "pnlConvButtons";
            pnlConvButtons.Padding = new Padding(6, 6, 6, 6);
            pnlConvButtons.Size = new Size(238, 223);
            pnlConvButtons.TabIndex = 1;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(108, 117, 125);
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(134, 142, 150);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 9.5F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(6, 189);
            btnSettings.Margin = new Padding(2, 2, 2, 2);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(226, 30);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "⚙ Cài đặt";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // pnlHiddenButtons
            // 
            pnlHiddenButtons.BackColor = Color.FromArgb(250, 250, 250);
            pnlHiddenButtons.BorderStyle = BorderStyle.FixedSingle;
            pnlHiddenButtons.Controls.Add(btnCreateGroup);
            pnlHiddenButtons.Controls.Add(btnPrivateChat);
            pnlHiddenButtons.Controls.Add(btnViewMembers);
            pnlHiddenButtons.Controls.Add(btnRefresh);
            pnlHiddenButtons.Controls.Add(btnProfile);
            pnlHiddenButtons.Controls.Add(btnLogout);
            pnlHiddenButtons.Dock = DockStyle.Top;
            pnlHiddenButtons.Location = new Point(6, 6);
            pnlHiddenButtons.Margin = new Padding(2, 2, 2, 2);
            pnlHiddenButtons.Name = "pnlHiddenButtons";
            pnlHiddenButtons.Size = new Size(226, 183);
            pnlHiddenButtons.TabIndex = 6;
            pnlHiddenButtons.Visible = false;
            // 
            // btnCreateGroup
            // 
            btnCreateGroup.BackColor = Color.FromArgb(52, 152, 219);
            btnCreateGroup.Cursor = Cursors.Hand;
            btnCreateGroup.Dock = DockStyle.Top;
            btnCreateGroup.FlatAppearance.BorderSize = 0;
            btnCreateGroup.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            btnCreateGroup.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 163, 228);
            btnCreateGroup.FlatStyle = FlatStyle.Flat;
            btnCreateGroup.Font = new Font("Segoe UI", 9.5F);
            btnCreateGroup.ForeColor = Color.White;
            btnCreateGroup.Location = new Point(0, 150);
            btnCreateGroup.Margin = new Padding(2, 2, 2, 2);
            btnCreateGroup.Name = "btnCreateGroup";
            btnCreateGroup.Size = new Size(224, 30);
            btnCreateGroup.TabIndex = 0;
            btnCreateGroup.Text = "➕ Tạo nhóm mới";
            btnCreateGroup.UseVisualStyleBackColor = false;
            // 
            // btnPrivateChat
            // 
            btnPrivateChat.BackColor = Color.FromArgb(52, 152, 219);
            btnPrivateChat.Cursor = Cursors.Hand;
            btnPrivateChat.Dock = DockStyle.Top;
            btnPrivateChat.FlatAppearance.BorderSize = 0;
            btnPrivateChat.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            btnPrivateChat.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 163, 228);
            btnPrivateChat.FlatStyle = FlatStyle.Flat;
            btnPrivateChat.Font = new Font("Segoe UI", 9.5F);
            btnPrivateChat.ForeColor = Color.White;
            btnPrivateChat.Location = new Point(0, 120);
            btnPrivateChat.Margin = new Padding(2, 2, 2, 2);
            btnPrivateChat.Name = "btnPrivateChat";
            btnPrivateChat.Size = new Size(224, 30);
            btnPrivateChat.TabIndex = 1;
            btnPrivateChat.Text = "💬 Chat riêng";
            btnPrivateChat.UseVisualStyleBackColor = false;
            // 
            // btnViewMembers
            // 
            btnViewMembers.BackColor = Color.FromArgb(52, 152, 219);
            btnViewMembers.Cursor = Cursors.Hand;
            btnViewMembers.Dock = DockStyle.Top;
            btnViewMembers.FlatAppearance.BorderSize = 0;
            btnViewMembers.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            btnViewMembers.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 163, 228);
            btnViewMembers.FlatStyle = FlatStyle.Flat;
            btnViewMembers.Font = new Font("Segoe UI", 9.5F);
            btnViewMembers.ForeColor = Color.White;
            btnViewMembers.Location = new Point(0, 90);
            btnViewMembers.Margin = new Padding(2, 2, 2, 2);
            btnViewMembers.Name = "btnViewMembers";
            btnViewMembers.Size = new Size(224, 30);
            btnViewMembers.TabIndex = 2;
            btnViewMembers.Text = "👥 Xem thành viên";
            btnViewMembers.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(52, 152, 219);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Dock = DockStyle.Top;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 163, 228);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.5F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(0, 60);
            btnRefresh.Margin = new Padding(2, 2, 2, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(224, 30);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "🔄 Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(52, 152, 219);
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.Dock = DockStyle.Top;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            btnProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 163, 228);
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 9.5F);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(0, 30);
            btnProfile.Margin = new Padding(2, 2, 2, 2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(224, 30);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "👤 Hồ sơ cá nhân";
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(231, 76, 60);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 108, 93);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9.5F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 0);
            btnLogout.Margin = new Padding(2, 2, 2, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(224, 30);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "🚪 Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // pnlChatArea
            // 
            pnlChatArea.BackColor = Color.White;
            pnlChatArea.Controls.Add(pnlMessages);
            pnlChatArea.Controls.Add(pnlInput);
            pnlChatArea.Controls.Add(pnlHeader);
            pnlChatArea.Dock = DockStyle.Fill;
            pnlChatArea.Location = new Point(0, 0);
            pnlChatArea.Margin = new Padding(2, 2, 2, 2);
            pnlChatArea.Name = "pnlChatArea";
            pnlChatArea.Size = new Size(719, 655);
            pnlChatArea.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
            pnlHeader.Controls.Add(lblChatTitle);
            pnlHeader.Controls.Add(lblParticipantCount);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2, 2, 2, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(12, 6, 12, 6);
            pnlHeader.Size = new Size(719, 65);
            pnlHeader.TabIndex = 3;
            // 
            // lblChatTitle
            // 
            lblChatTitle.AutoSize = true;
            lblChatTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblChatTitle.ForeColor = Color.White;
            lblChatTitle.Location = new Point(12, 14);
            lblChatTitle.Margin = new Padding(2, 0, 2, 0);
            lblChatTitle.Name = "lblChatTitle";
            lblChatTitle.Size = new Size(268, 30);
            lblChatTitle.TabIndex = 0;
            lblChatTitle.Text = "💬 Chọn cuộc trò chuyện";
            // 
            // lblParticipantCount
            // 
            lblParticipantCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblParticipantCount.AutoSize = true;
            lblParticipantCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblParticipantCount.ForeColor = Color.FromArgb(200, 230, 255);
            lblParticipantCount.Location = new Point(552, 20);
            lblParticipantCount.Margin = new Padding(2, 0, 2, 0);
            lblParticipantCount.Name = "lblParticipantCount";
            lblParticipantCount.Size = new Size(120, 20);
            lblParticipantCount.TabIndex = 1;
            lblParticipantCount.Text = "0 người tham gia";
            lblParticipantCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlMessages
            // 
            pnlMessages.AutoScroll = true;
            pnlMessages.BackColor = Color.FromArgb(248, 250, 252);
            pnlMessages.Dock = DockStyle.Fill;
            pnlMessages.Location = new Point(0, 65);
            pnlMessages.Margin = new Padding(2, 2, 2, 2);
            pnlMessages.Name = "pnlMessages";
            pnlMessages.Padding = new Padding(10, 10, 10, 10);
            pnlMessages.Size = new Size(719, 390);
            pnlMessages.TabIndex = 1;
            // 
            // pnlInput
            // 
            pnlInput.BackColor = Color.White;
            pnlInput.BorderStyle = BorderStyle.FixedSingle;
            pnlInput.Controls.Add(pnlReply);
            pnlInput.Controls.Add(txtMessage);
            pnlInput.Controls.Add(pnlInputControls);
            pnlInput.Dock = DockStyle.Bottom;
            pnlInput.Location = new Point(0, 455);
            pnlInput.Margin = new Padding(2, 2, 2, 2);
            pnlInput.Name = "pnlInput";
            pnlInput.Padding = new Padding(10, 10, 10, 10);
            pnlInput.Size = new Size(719, 200);
            pnlInput.TabIndex = 2;
            // 
            // pnlReply
            // 
            pnlReply.BackColor = Color.FromArgb(232, 242, 252);
            pnlReply.Controls.Add(lblReplyTo);
            pnlReply.Controls.Add(btnCancelReply);
            pnlReply.Dock = DockStyle.Top;
            pnlReply.Location = new Point(10, 10);
            pnlReply.Margin = new Padding(2, 2, 2, 2);
            pnlReply.Name = "pnlReply";
            pnlReply.Size = new Size(697, 29);
            pnlReply.TabIndex = 0;
            pnlReply.Visible = false;
            // 
            // lblReplyTo
            // 
            lblReplyTo.AutoSize = true;
            lblReplyTo.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblReplyTo.ForeColor = Color.FromArgb(41, 128, 185);
            lblReplyTo.Location = new Point(8, 6);
            lblReplyTo.Margin = new Padding(2, 0, 2, 0);
            lblReplyTo.Name = "lblReplyTo";
            lblReplyTo.Size = new Size(83, 20);
            lblReplyTo.TabIndex = 0;
            lblReplyTo.Text = "↩ Trả lời: ...";
            // 
            // btnCancelReply
            // 
            btnCancelReply.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelReply.BackColor = Color.Transparent;
            btnCancelReply.FlatAppearance.BorderSize = 0;
            btnCancelReply.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 200, 200);
            btnCancelReply.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 230);
            btnCancelReply.FlatStyle = FlatStyle.Flat;
            btnCancelReply.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelReply.ForeColor = Color.FromArgb(150, 150, 150);
            btnCancelReply.Location = new Point(668, 2);
            btnCancelReply.Margin = new Padding(2, 2, 2, 2);
            btnCancelReply.Name = "btnCancelReply";
            btnCancelReply.Size = new Size(27, 26);
            btnCancelReply.TabIndex = 1;
            btnCancelReply.Text = "✕";
            btnCancelReply.UseVisualStyleBackColor = false;
            // 
            // txtMessage
            // 
            txtMessage.BorderStyle = BorderStyle.FixedSingle;
            txtMessage.Dock = DockStyle.Fill;
            txtMessage.Font = new Font("Segoe UI", 10F);
            txtMessage.Location = new Point(10, 10);
            txtMessage.Margin = new Padding(2, 2, 2, 2);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "Nhập tin nhắn của bạn...";
            txtMessage.ScrollBars = ScrollBars.Vertical;
            txtMessage.Size = new Size(697, 126);
            txtMessage.TabIndex = 1;
            // 
            // pnlInputControls
            // 
            pnlInputControls.BackColor = Color.White;
            pnlInputControls.Controls.Add(cbSecurityLabel);
            pnlInputControls.Controls.Add(btnAttachment);
            pnlInputControls.Controls.Add(btnSend);
            pnlInputControls.Dock = DockStyle.Bottom;
            pnlInputControls.Location = new Point(10, 136);
            pnlInputControls.Margin = new Padding(2, 2, 2, 2);
            pnlInputControls.Name = "pnlInputControls";
            pnlInputControls.Size = new Size(697, 42);
            pnlInputControls.TabIndex = 5;
            // 
            // cbSecurityLabel
            // 
            cbSecurityLabel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSecurityLabel.FlatStyle = FlatStyle.Flat;
            cbSecurityLabel.Font = new Font("Segoe UI", 9F);
            cbSecurityLabel.FormattingEnabled = true;
            cbSecurityLabel.Location = new Point(0, 6);
            cbSecurityLabel.Margin = new Padding(2, 2, 2, 2);
            cbSecurityLabel.Name = "cbSecurityLabel";
            cbSecurityLabel.Size = new Size(129, 28);
            cbSecurityLabel.TabIndex = 2;
            // 
            // btnAttachment
            // 
            btnAttachment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAttachment.BackColor = Color.FromArgb(52, 152, 219);
            btnAttachment.Cursor = Cursors.Hand;
            btnAttachment.FlatAppearance.BorderSize = 0;
            btnAttachment.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            btnAttachment.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 163, 228);
            btnAttachment.FlatStyle = FlatStyle.Flat;
            btnAttachment.Font = new Font("Segoe UI", 10F);
            btnAttachment.ForeColor = Color.White;
            btnAttachment.Location = new Point(449, 0);
            btnAttachment.Margin = new Padding(2, 2, 2, 2);
            btnAttachment.Name = "btnAttachment";
            btnAttachment.Size = new Size(112, 29);
            btnAttachment.TabIndex = 3;
            btnAttachment.Text = "📎 Đính kèm";
            btnAttachment.UseVisualStyleBackColor = false;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSend.BackColor = Color.FromArgb(52, 152, 219);
            btnSend.Cursor = Cursors.Hand;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 132, 73);
            btnSend.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 202, 106);
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(565, 0);
            btnSend.Margin = new Padding(2, 2, 2, 2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(132, 29);
            btnSend.TabIndex = 4;
            btnSend.Text = "Gửi tin nhắn ➤";
            btnSend.UseVisualStyleBackColor = false;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(41, 128, 185);
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip.Location = new Point(0, 655);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 10, 0);
            statusStrip.Size = new Size(960, 26);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.White;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(93, 20);
            lblStatus.Text = "\U0001f7e2 Sẵn sàng";
            // 
            // ChatFormNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(960, 681);
            Controls.Add(splitContainer);
            Controls.Add(statusStrip);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(724, 449);
            Name = "ChatFormNew";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "💬 Chat Application";
            Load += ChatFormNew_Load;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            pnlUserInfo.ResumeLayout(false);
            pnlUserInfo.PerformLayout();
            pnlConvButtons.ResumeLayout(false);
            pnlHiddenButtons.ResumeLayout(false);
            pnlChatArea.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            pnlReply.ResumeLayout(false);
            pnlReply.PerformLayout();
            pnlInputControls.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserStatus;
        private System.Windows.Forms.ListView lstConversations;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.Panel pnlConvButtons;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnViewMembers;
        private System.Windows.Forms.Button btnPrivateChat;
        private System.Windows.Forms.Button btnCreateGroup;
        private System.Windows.Forms.Panel pnlChatArea;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblChatTitle;
        private System.Windows.Forms.Label lblParticipantCount;
        private System.Windows.Forms.Panel pnlMessages;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlReply;
        private System.Windows.Forms.Label lblReplyTo;
        private System.Windows.Forms.Button btnCancelReply;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Panel pnlInputControls;
        private System.Windows.Forms.ComboBox cbSecurityLabel;
        private System.Windows.Forms.Button btnAttachment;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Panel pnlHiddenButtons;
        private System.Windows.Forms.Button btnSettings;

        // Thêm biến để theo dõi trạng thái panel
        private bool isSettingsPanelOpen = false;

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ToggleSettingsPanel();
        }

        private void ToggleSettingsPanel()
        {
            isSettingsPanelOpen = !isSettingsPanelOpen;
            pnlHiddenButtons.Visible = isSettingsPanelOpen;

            if (isSettingsPanelOpen)
            {
                btnSettings.Text = "⚙ Đóng";
            }
            else
            {
                btnSettings.Text = "⚙ Cài đặt";
            }
        }

        private void ChatFormNew_Load(object sender, EventArgs e)
        {
            // Cập nhật tên người dùng khi form load
            UpdateUserInfo();

            // Thêm sự kiện click cho form để đóng panel khi click ra ngoài
            this.Click += (s, args) =>
            {
                if (isSettingsPanelOpen && !pnlHiddenButtons.Bounds.Contains(PointToClient(Cursor.Position)))
                {
                    ToggleSettingsPanel();
                }
            };

            // Thêm sự kiện click cho các panel khác
            pnlSidebar.Click += (s, args) =>
            {
                if (isSettingsPanelOpen && !pnlHiddenButtons.Bounds.Contains(PointToClient(Cursor.Position)))
                {
                    ToggleSettingsPanel();
                }
            };

            pnlUserInfo.Click += (s, args) =>
            {
                if (isSettingsPanelOpen && !pnlHiddenButtons.Bounds.Contains(PointToClient(Cursor.Position)))
                {
                    ToggleSettingsPanel();
                }
            };

            lstConversations.Click += (s, args) =>
            {
                if (isSettingsPanelOpen && !pnlHiddenButtons.Bounds.Contains(PointToClient(Cursor.Position)))
                {
                    ToggleSettingsPanel();
                }
            };
        }

        private void UpdateUserInfo()
        {
            // Cập nhật tên người dùng (thay bằng tên thực từ database hoặc session)
            lblUserName.Text = $"Người dùng: {currentUsername}";

            // Nếu có avatar, có thể thêm ở đây
            // picUserAvatar.Image = ...
        }

        // Thêm phương thức để thiết lập tên người dùng từ bên ngoài
        public void SetCurrentUser(string username)
        {
            currentUsername = username;
            if (lblUserName != null)
            {
                lblUserName.Text = $"Người dùng: {currentUsername}";
            }
        }
    }
}