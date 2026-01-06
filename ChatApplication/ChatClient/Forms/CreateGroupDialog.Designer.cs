//namespace ChatClient.Forms
//{
//    partial class CreateGroupDialog
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
//            this.pnlHeader = new System.Windows.Forms.Panel();
//            this.lblTitle = new System.Windows.Forms.Label();
//            this.lblGroupName = new System.Windows.Forms.Label();
//            this.txtGroupName = new System.Windows.Forms.TextBox();
//            this.lblGroupType = new System.Windows.Forms.Label();
//            this.cbGroupType = new System.Windows.Forms.ComboBox();
//            this.lblMembers = new System.Windows.Forms.Label();
//            this.lstMembers = new System.Windows.Forms.CheckedListBox();
//            this.btnOK = new System.Windows.Forms.Button();
//            this.btnCancel = new System.Windows.Forms.Button();
//            this.txtSearch = new System.Windows.Forms.TextBox();
//            this.btnSelectAll = new System.Windows.Forms.Button();
//            this.btnSelectNone = new System.Windows.Forms.Button();
//            this.lblSelectedCount = new System.Windows.Forms.Label();
//            this.pnlHeader.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // pnlHeader
//            // 
//            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(0, 132, 255);
//            this.pnlHeader.Controls.Add(this.lblTitle);
//            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
//            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
//            this.pnlHeader.Name = "pnlHeader";
//            this.pnlHeader.Size = new System.Drawing.Size(460, 60);
//            this.pnlHeader.TabIndex = 0;
//            // 
//            // lblTitle
//            // 
//            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
//            this.lblTitle.ForeColor = System.Drawing.Color.White;
//            this.lblTitle.Location = new System.Drawing.Point(0, 0);
//            this.lblTitle.Name = "lblTitle";
//            this.lblTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
//            this.lblTitle.Size = new System.Drawing.Size(460, 60);
//            this.lblTitle.TabIndex = 0;
//            this.lblTitle.Text = "👥 Tạo Nhóm Mới";
//            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            // 
//            // lblGroupName
//            // 
//            this.lblGroupName.AutoSize = true;
//            this.lblGroupName.Location = new System.Drawing.Point(20, 80);
//            this.lblGroupName.Name = "lblGroupName";
//            this.lblGroupName.Size = new System.Drawing.Size(77, 20);
//            this.lblGroupName.TabIndex = 1;
//            this.lblGroupName.Text = "Tên nhóm *";
//            // 
//            // txtGroupName
//            // 
//            this.txtGroupName.Location = new System.Drawing.Point(120, 77);
//            this.txtGroupName.MaxLength = 50;
//            this.txtGroupName.Name = "txtGroupName";
//            this.txtGroupName.Size = new System.Drawing.Size(310, 27);
//            this.txtGroupName.TabIndex = 2;
//            // 
//            // lblGroupType
//            // 
//            this.lblGroupType.AutoSize = true;
//            this.lblGroupType.Location = new System.Drawing.Point(20, 115);
//            this.lblGroupType.Name = "lblGroupType";
//            this.lblGroupType.Size = new System.Drawing.Size(74, 20);
//            this.lblGroupType.TabIndex = 3;
//            this.lblGroupType.Text = "Loại nhóm";
//            // 
//            // cbGroupType
//            // 
//            this.cbGroupType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.cbGroupType.FormattingEnabled = true;
//            this.cbGroupType.Location = new System.Drawing.Point(120, 112);
//            this.cbGroupType.Name = "cbGroupType";
//            this.cbGroupType.Size = new System.Drawing.Size(310, 28);
//            this.cbGroupType.TabIndex = 4;
//            // 
//            // lblMembers
//            // 
//            this.lblMembers.AutoSize = true;
//            this.lblMembers.Location = new System.Drawing.Point(20, 150);
//            this.lblMembers.Name = "lblMembers";
//            this.lblMembers.Size = new System.Drawing.Size(86, 20);
//            this.lblMembers.TabIndex = 5;
//            this.lblMembers.Text = "Thành viên *";
//            // 
//            // txtSearch
//            // 
//            this.txtSearch.Location = new System.Drawing.Point(120, 147);
//            this.txtSearch.Name = "txtSearch";
//            this.txtSearch.Size = new System.Drawing.Size(210, 27);
//            this.txtSearch.TabIndex = 6;
//            // 
//            // lstMembers
//            // 
//            this.lstMembers.CheckOnClick = true;
//            this.lstMembers.FormattingEnabled = true;
//            this.lstMembers.IntegralHeight = false;
//            this.lstMembers.Location = new System.Drawing.Point(120, 180);
//            this.lstMembers.Name = "lstMembers";
//            this.lstMembers.Size = new System.Drawing.Size(310, 155);
//            this.lstMembers.TabIndex = 7;
//            // 
//            // btnSelectAll
//            // 
//            this.btnSelectAll.Location = new System.Drawing.Point(120, 345);
//            this.btnSelectAll.Name = "btnSelectAll";
//            this.btnSelectAll.Size = new System.Drawing.Size(100, 30);
//            this.btnSelectAll.TabIndex = 8;
//            this.btnSelectAll.Text = "Chọn tất cả";
//            this.btnSelectAll.UseVisualStyleBackColor = true;
//            // 
//            // btnSelectNone
//            // 
//            this.btnSelectNone.Location = new System.Drawing.Point(230, 345);
//            this.btnSelectNone.Name = "btnSelectNone";
//            this.btnSelectNone.Size = new System.Drawing.Size(100, 30);
//            this.btnSelectNone.TabIndex = 9;
//            this.btnSelectNone.Text = "Bỏ chọn";
//            this.btnSelectNone.UseVisualStyleBackColor = true;
//            // 
//            // lblSelectedCount
//            // 
//            this.lblSelectedCount.AutoSize = true;
//            this.lblSelectedCount.Location = new System.Drawing.Point(340, 352);
//            this.lblSelectedCount.Name = "lblSelectedCount";
//            this.lblSelectedCount.Size = new System.Drawing.Size(79, 20);
//            this.lblSelectedCount.TabIndex = 10;
//            this.lblSelectedCount.Text = "Đã chọn: 0/0";
//            // 
//            // btnOK
//            // 
//            this.btnOK.Location = new System.Drawing.Point(240, 395);
//            this.btnOK.Name = "btnOK";
//            this.btnOK.Size = new System.Drawing.Size(100, 36);
//            this.btnOK.TabIndex = 11;
//            this.btnOK.Text = "Tạo nhóm";
//            this.btnOK.UseVisualStyleBackColor = true;
//            // 
//            // btnCancel
//            // 
//            this.btnCancel.Location = new System.Drawing.Point(350, 395);
//            this.btnCancel.Name = "btnCancel";
//            this.btnCancel.Size = new System.Drawing.Size(80, 36);
//            this.btnCancel.TabIndex = 12;
//            this.btnCancel.Text = "Hủy";
//            this.btnCancel.UseVisualStyleBackColor = true;
//            // 
//            // CreateGroupDialog
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(460, 450);
//            this.Controls.Add(this.pnlHeader);
//            this.Controls.Add(this.lblSelectedCount);
//            this.Controls.Add(this.btnSelectNone);
//            this.Controls.Add(this.btnSelectAll);
//            this.Controls.Add(this.txtSearch);
//            this.Controls.Add(this.btnCancel);
//            this.Controls.Add(this.btnOK);
//            this.Controls.Add(this.lstMembers);
//            this.Controls.Add(this.lblMembers);
//            this.Controls.Add(this.cbGroupType);
//            this.Controls.Add(this.lblGroupType);
//            this.Controls.Add(this.txtGroupName);
//            this.Controls.Add(this.lblGroupName);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
//            this.MaximizeBox = false;
//            this.MinimizeBox = false;
//            this.Name = "CreateGroupDialog";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
//            this.Text = "Tạo nhóm mới";
//            this.pnlHeader.ResumeLayout(false);
//            this.ResumeLayout(false);
//            this.PerformLayout();
//        }

//        #endregion

//        private System.Windows.Forms.Panel pnlHeader;
//        private System.Windows.Forms.Label lblTitle;
//        private System.Windows.Forms.Label lblGroupName;
//        private System.Windows.Forms.TextBox txtGroupName;
//        private System.Windows.Forms.Label lblGroupType;
//        private System.Windows.Forms.ComboBox cbGroupType;
//        private System.Windows.Forms.Label lblMembers;
//        private System.Windows.Forms.CheckedListBox lstMembers;
//        private System.Windows.Forms.Button btnOK;
//        private System.Windows.Forms.Button btnCancel;
//        private System.Windows.Forms.TextBox txtSearch;
//        private System.Windows.Forms.Button btnSelectAll;
//        private System.Windows.Forms.Button btnSelectNone;
//        private System.Windows.Forms.Label lblSelectedCount;
//    }
//}


namespace ChatClient.Forms
{
    partial class CreateGroupDialog
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblGroupName = new Label();
            txtGroupName = new TextBox();
            lblGroupType = new Label();
            cbGroupType = new ComboBox();
            lblMembers = new Label();
            txtSearch = new TextBox();
            lstMembers = new CheckedListBox();
            btnSelectAll = new Button();
            btnSelectNone = new Button();
            lblSelectedCount = new Label();
            pnlButtons = new Panel();
            btnCancel = new Button();
            btnOK = new Button();
            pnlContent = new Panel();
            pnlHeader.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2, 2, 2, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(16, 0, 0, 0);
            pnlHeader.Size = new Size(400, 48);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(16, 0);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(384, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👥 Tạo Nhóm Mới";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGroupName
            // 
            lblGroupName.AutoSize = true;
            lblGroupName.Font = new Font("Segoe UI", 10F);
            lblGroupName.Location = new Point(16, 16);
            lblGroupName.Margin = new Padding(2, 0, 2, 0);
            lblGroupName.Name = "lblGroupName";
            lblGroupName.Size = new Size(98, 23);
            lblGroupName.TabIndex = 1;
            lblGroupName.Text = "Tên nhóm *";
            // 
            // txtGroupName
            // 
            txtGroupName.BorderStyle = BorderStyle.FixedSingle;
            txtGroupName.Font = new Font("Segoe UI", 10F);
            txtGroupName.Location = new Point(120, 14);
            txtGroupName.Margin = new Padding(2, 2, 2, 2);
            txtGroupName.MaxLength = 50;
            txtGroupName.Name = "txtGroupName";
            txtGroupName.Size = new Size(248, 30);
            txtGroupName.TabIndex = 1;
            // 
            // lblGroupType
            // 
            lblGroupType.AutoSize = true;
            lblGroupType.Font = new Font("Segoe UI", 10F);
            lblGroupType.Location = new Point(16, 52);
            lblGroupType.Margin = new Padding(2, 0, 2, 0);
            lblGroupType.Name = "lblGroupType";
            lblGroupType.Size = new Size(91, 23);
            lblGroupType.TabIndex = 3;
            lblGroupType.Text = "Loại nhóm";
            // 
            // cbGroupType
            // 
            cbGroupType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGroupType.FlatStyle = FlatStyle.Flat;
            cbGroupType.Font = new Font("Segoe UI", 10F);
            cbGroupType.FormattingEnabled = true;
            cbGroupType.Location = new Point(120, 50);
            cbGroupType.Margin = new Padding(2, 2, 2, 2);
            cbGroupType.Name = "cbGroupType";
            cbGroupType.Size = new Size(249, 31);
            cbGroupType.TabIndex = 2;
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Segoe UI", 10F);
            lblMembers.Location = new Point(16, 88);
            lblMembers.Margin = new Padding(2, 0, 2, 0);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(106, 23);
            lblMembers.TabIndex = 5;
            lblMembers.Text = "Thành viên *";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(120, 86);
            txtSearch.Margin = new Padding(2, 2, 2, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm thành viên...";
            txtSearch.Size = new Size(248, 30);
            txtSearch.TabIndex = 3;
            // 
            // lstMembers
            // 
            lstMembers.BackColor = Color.White;
            lstMembers.BorderStyle = BorderStyle.FixedSingle;
            lstMembers.CheckOnClick = true;
            lstMembers.Font = new Font("Segoe UI", 10F);
            lstMembers.FormattingEnabled = true;
            lstMembers.IntegralHeight = false;
            lstMembers.Location = new Point(120, 120);
            lstMembers.Margin = new Padding(2, 2, 2, 2);
            lstMembers.Name = "lstMembers";
            lstMembers.Size = new Size(248, 144);
            lstMembers.TabIndex = 4;
            // 
            // btnSelectAll
            // 
            btnSelectAll.BackColor = Color.FromArgb(52, 152, 219);
            btnSelectAll.Cursor = Cursors.Hand;
            btnSelectAll.FlatAppearance.BorderSize = 0;
            btnSelectAll.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            btnSelectAll.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 163, 228);
            btnSelectAll.FlatStyle = FlatStyle.Flat;
            btnSelectAll.Font = new Font("Segoe UI", 9.5F);
            btnSelectAll.ForeColor = Color.White;
            btnSelectAll.Location = new Point(120, 272);
            btnSelectAll.Margin = new Padding(2, 2, 2, 2);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new Size(120, 29);
            btnSelectAll.TabIndex = 5;
            btnSelectAll.Text = "Chọn tất cả";
            btnSelectAll.UseVisualStyleBackColor = false;
            // 
            // btnSelectNone
            // 
            btnSelectNone.BackColor = Color.FromArgb(108, 117, 125);
            btnSelectNone.Cursor = Cursors.Hand;
            btnSelectNone.FlatAppearance.BorderSize = 0;
            btnSelectNone.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btnSelectNone.FlatAppearance.MouseOverBackColor = Color.FromArgb(134, 142, 150);
            btnSelectNone.FlatStyle = FlatStyle.Flat;
            btnSelectNone.Font = new Font("Segoe UI", 9.5F);
            btnSelectNone.ForeColor = Color.White;
            btnSelectNone.Location = new Point(248, 272);
            btnSelectNone.Margin = new Padding(2, 2, 2, 2);
            btnSelectNone.Name = "btnSelectNone";
            btnSelectNone.Size = new Size(120, 29);
            btnSelectNone.TabIndex = 6;
            btnSelectNone.Text = "Bỏ chọn";
            btnSelectNone.UseVisualStyleBackColor = false;
            // 
            // lblSelectedCount
            // 
            lblSelectedCount.AutoSize = true;
            lblSelectedCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblSelectedCount.ForeColor = Color.FromArgb(100, 100, 100);
            lblSelectedCount.Location = new Point(120, 304);
            lblSelectedCount.Margin = new Padding(2, 0, 2, 0);
            lblSelectedCount.Name = "lblSelectedCount";
            lblSelectedCount.Size = new Size(92, 20);
            lblSelectedCount.TabIndex = 10;
            lblSelectedCount.Text = "Đã chọn: 0/0";
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(248, 250, 252);
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Controls.Add(btnOK);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 352);
            pnlButtons.Margin = new Padding(2, 2, 2, 2);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(16, 12, 16, 12);
            pnlButtons.Size = new Size(400, 64);
            pnlButtons.TabIndex = 11;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(108, 117, 125);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(134, 142, 150);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(304, 12);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOK.BackColor = Color.FromArgb(52, 152, 219);
            btnOK.Cursor = Cursors.Hand;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 132, 73);
            btnOK.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 202, 106);
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(208, 12);
            btnOK.Margin = new Padding(2, 2, 2, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(80, 29);
            btnOK.TabIndex = 7;
            btnOK.Text = "Tạo nhóm";
            btnOK.UseVisualStyleBackColor = false;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Controls.Add(lblGroupName);
            pnlContent.Controls.Add(txtGroupName);
            pnlContent.Controls.Add(lblSelectedCount);
            pnlContent.Controls.Add(lblGroupType);
            pnlContent.Controls.Add(btnSelectNone);
            pnlContent.Controls.Add(cbGroupType);
            pnlContent.Controls.Add(btnSelectAll);
            pnlContent.Controls.Add(lblMembers);
            pnlContent.Controls.Add(lstMembers);
            pnlContent.Controls.Add(txtSearch);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 48);
            pnlContent.Margin = new Padding(2, 2, 2, 2);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(16, 16, 16, 0);
            pnlContent.Size = new Size(400, 304);
            pnlContent.TabIndex = 12;
            // 
            // CreateGroupDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 416);
            Controls.Add(pnlContent);
            Controls.Add(pnlButtons);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateGroupDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tạo nhóm mới";
            pnlHeader.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label lblGroupType;
        private System.Windows.Forms.ComboBox cbGroupType;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.CheckedListBox lstMembers;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSelectNone;
        private System.Windows.Forms.Label lblSelectedCount;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlContent;
    }
}