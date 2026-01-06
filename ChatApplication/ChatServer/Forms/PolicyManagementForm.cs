using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using ChatServer.Database;
using Oracle.ManagedDataAccess.Client;

namespace ChatServer.Forms
{
    /// <summary>
    /// Policy Management Form V2 - Dễ sử dụng hơn với preset policies
    /// </summary>
    public class PolicyManagementForm : Form
    {
        private readonly DbContext _dbContext;
        private readonly string _adminUsername;

        // Controls
        private TabControl tabControl = null!;
        private DataGridView dgvVPD = null!, dgvFGA = null!, dgvMAC = null!;
        private Label lblStatus = null!;
        private ListBox lstPresetVPD = null!, lstPresetFGA = null!;

        public PolicyManagementForm(DbContext dbContext, string adminUsername)
        {
            _dbContext = dbContext;
            _adminUsername = adminUsername;
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "🔐 Oracle Security Policy Manager";
            this.Size = new Size(1300, 800);
            this.StartPosition = FormStartPosition.CenterParent;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.Font = new Font("Segoe UI", 9F);

            var lblTitle = new Label
            {
                Text = "🔐 Oracle Security Policy Manager",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 102, 204),
                Location = new Point(20, 12),
                AutoSize = true
            };

            tabControl = new TabControl
            {
                Location = new Point(20, 50),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
                Size = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 120),
                Font = new Font("Segoe UI", 10F)
            };
            tabControl.SelectedIndexChanged += async (s, e) => await LoadCurrentTabAsync();

            // ===== VPD TAB =====
            CreateVPDTab();
            
            // ===== FGA TAB =====
            CreateFGATab();
            
            // ===== MAC TAB =====
            CreateMACTab();
            
            // ===== HELP TAB =====
            CreateHelpTab();

            // Bottom controls (anchored to bottom)
            lblStatus = new Label { Text = "Sẵn sàng", AutoSize = true, ForeColor = Color.Gray, Anchor = AnchorStyles.Bottom | AnchorStyles.Left };
            var btnRefresh = CreateBtn("🔄 Tải lại", Color.FromArgb(0, 123, 255), Point.Empty);
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefresh.Click += async (s, e) => await LoadCurrentTabAsync();
            var btnClose = CreateBtn("Đóng", Color.FromArgb(108, 117, 125), Point.Empty);
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.DialogResult = DialogResult.OK;

            this.Controls.AddRange(new Control[] { lblTitle, tabControl, lblStatus, btnRefresh, btnClose });
            this.AcceptButton = btnClose;
            
            // Position bottom controls after adding to form
            this.Resize += (s, e) => RepositionBottomControls(lblStatus, btnRefresh, btnClose);
            this.Shown += async (s, e) => { RepositionBottomControls(lblStatus, btnRefresh, btnClose); await LoadCurrentTabAsync(); };
        }

        #region ===== VPD TAB =====
        private void CreateVPDTab()
        {
            var tabVPD = new TabPage("🛡️ VPD / RLS");
            tabVPD.BackColor = Color.White;

            // Info panel - Dock top, auto width
            var panelInfo = new Panel { Dock = DockStyle.Top, Height = 60, BackColor = Color.FromArgb(232, 245, 233) };
            panelInfo.Controls.Add(new Label
            {
                Text = "🛡️ VPD (Virtual Private Database) / RLS (Row Level Security)\n" +
                       "• Tự động thêm WHERE vào mọi query để lọc theo quyền  • Package: DBMS_RLS  • Dưới đây chỉ hiển thị, không chỉnh sửa trực tiếp",
                Dock = DockStyle.Fill,
                Padding = new Padding(10, 8, 10, 0),
                Font = new Font("Segoe UI", 9F)
            });

            // Main content panel
            var panelContent = new Panel { Dock = DockStyle.Fill, Padding = new Padding(10) };
            
            // Split container for left/right
            var splitContainer = new SplitContainer
            {
                Dock = DockStyle.Fill,
                Orientation = Orientation.Vertical,
                SplitterDistance = 700,
                SplitterWidth = 8
            };

            // LEFT: Policies hiện có
            var lblCurrent = new Label { Text = "📋 Danh sách VPD/RLS đang tồn tại (chỉ xem):", Dock = DockStyle.Top, Height = 25, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            dgvVPD = new DataGridView
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White
            };
            
            // Button xóa policy
            var panelVPDButtons = new FlowLayoutPanel { Dock = DockStyle.Bottom, Height = 40, FlowDirection = FlowDirection.LeftToRight, Padding = new Padding(0, 5, 0, 0) };
            var btnDropVPD = CreateBtn("🗑️ Xóa Policy", Color.FromArgb(220, 53, 69), Point.Empty);
            btnDropVPD.Click += async (s, e) => await DropSelectedVPDAsync();
            panelVPDButtons.Controls.Add(btnDropVPD);
            
            splitContainer.Panel1.Controls.Add(dgvVPD);
            splitContainer.Panel1.Controls.Add(panelVPDButtons);
            splitContainer.Panel1.Controls.Add(lblCurrent);

            // RIGHT: Preset policies
            var lblPreset = new Label { Text = "⚡ Policy mẫu (double-click để thêm lại nếu đã xóa):", Dock = DockStyle.Top, Height = 25, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            lstPresetVPD = new ListBox { Dock = DockStyle.Fill, Font = new Font("Segoe UI", 9F) };
            // Preset items will be refreshed when loading VPD
            lstPresetVPD.DoubleClick += async (s, e) => await AddPresetVPDAsync();
            
            splitContainer.Panel2.Controls.Add(lstPresetVPD);
            splitContainer.Panel2.Controls.Add(lblPreset);

            panelContent.Controls.Add(splitContainer);
            tabVPD.Controls.Add(panelContent);
            tabVPD.Controls.Add(panelInfo);
            tabControl.TabPages.Add(tabVPD);
        }

        // All available VPD presets - using correct function names from 04_policies.sql
        private static readonly (string Table, string Policy, string Function, string Stmt, string Desc)[] _vpdPresets = new[]
        {
            ("TINNHAN", "VPD_TINNHAN_SELECT", "VPD_TINNHAN_SELECT_FN", "SELECT", "Lọc tin nhắn theo Security Label (MAC - No Read Up)"),
            ("TINNHAN", "VPD_TINNHAN_INSERT", "VPD_TINNHAN_INSERT_FN", "INSERT", "Ngăn gửi tin mức cao hơn clearance (MAC - No Write Up)"),
            ("CUOCTROCHUYEN", "VPD_CUOCTROCHUYEN_SELECT", "VPD_CUOCTROCHUYEN_SELECT_FN", "SELECT", "Chỉ xem cuộc trò chuyện mình tham gia hoặc có quyền"),
            ("TAIKHOAN", "VPD_TAIKHOAN_SELECT", "VPD_TAIKHOAN_SELECT_FN", "SELECT", "Ẩn tài khoản có clearance cao hơn (Admin bypass)")
        };

        private async Task AddPresetVPDAsync()
        {
            if (lstPresetVPD.SelectedIndex < 0) return;
            
            // Get the selected preset from the Tag
            var selectedItem = lstPresetVPD.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedItem) || selectedItem.StartsWith("✓")) return;
            
            // Find matching preset
            var preset = _vpdPresets.FirstOrDefault(p => selectedItem.Contains(p.Policy));
            if (preset.Policy == null)
            {
                MessageBox.Show("Không tìm thấy preset!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            try
            {
                // Check if function exists and is valid
                using var checkCmd = _dbContext.Connection.CreateCommand();
                checkCmd.CommandText = $"SELECT STATUS FROM USER_OBJECTS WHERE OBJECT_NAME = '{preset.Function}' AND OBJECT_TYPE = 'FUNCTION'";
                var status = await checkCmd.ExecuteScalarAsync();
                if (status == null || status == DBNull.Value)
                {
                    MessageBox.Show($"Function '{preset.Function}' chưa tồn tại!\n\nCần chạy script 04_policies.sql để tạo function trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (status.ToString() != "VALID")
                {
                    MessageBox.Show($"Function '{preset.Function}' bị INVALID!\n\nChạy: ALTER FUNCTION {preset.Function} COMPILE;", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using var cmd = _dbContext.Connection.CreateCommand();
                // Compact format - avoid any whitespace issues, trim all values
                var stmtType = preset.Stmt.Trim().ToUpper();
                // INSERT policy cần update_check => TRUE để kiểm tra predicate sau insert
                var updateCheck = stmtType.Contains("INSERT") ? ", update_check => TRUE" : "";
                var sql = "BEGIN DBMS_RLS.ADD_POLICY(" +
                    "object_schema => 'CHATAPPLICATION', " +
                    $"object_name => '{preset.Table.Trim()}', " +
                    $"policy_name => '{preset.Policy.Trim()}', " +
                    "function_schema => 'CHATAPPLICATION', " +
                    $"policy_function => '{preset.Function.Trim()}', " +
                    $"statement_types => '{stmtType}'" +
                    $"{updateCheck}, enable => TRUE); END;";
                cmd.CommandText = sql;
                Console.WriteLine($"[VPD] Adding policy: {sql}");
                await cmd.ExecuteNonQueryAsync();
                await _dbContext.WriteAuditLogAsync(_adminUsername, "VPD_ADD_PRESET", $"{preset.Table}.{preset.Policy}", 0);
                MessageBox.Show($"✓ Đã thêm VPD Policy: {preset.Policy}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadVPDAsync();
            }
            catch (OracleException ex) when (ex.Number == 28101) // Policy already exists
            {
                MessageBox.Show($"Policy '{preset.Policy}' đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (OracleException ex) when (ex.Number == 904 || ex.Number == 6550) // Function not found
            {
                MessageBox.Show($"Function '{preset.Function}' chưa tồn tại!\n\nCần chạy script 04_policies.sql để tạo function trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OracleException ex) when (ex.Number == 28104) // Invalid statement_types
            {
                MessageBox.Show($"Lỗi statement_types không hợp lệ!\n\nPolicy: {preset.Policy}\nStatement: {preset.Stmt}\n\nThử chạy trực tiếp trong SQL*Plus.", "Lỗi ORA-28104", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task DropSelectedVPDAsync()
        {
            if (dgvVPD.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn một policy để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvVPD.SelectedRows[0];
            var tableName = row.Cells["Table"].Value?.ToString();
            var policyName = row.Cells["Policy"].Value?.ToString();

            if (string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(policyName))
            {
                MessageBox.Show("Không thể xác định policy!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Xóa VPD Policy '{policyName}' trên bảng '{tableName}'?", "Xác nhận xóa", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using var cmd = _dbContext.Connection.CreateCommand();
                cmd.CommandText = $"BEGIN DBMS_RLS.DROP_POLICY(USER, '{tableName}', '{policyName}'); END;";
                await cmd.ExecuteNonQueryAsync();
                await _dbContext.WriteAuditLogAsync(_adminUsername, "VPD_DROP", $"{tableName}.{policyName}", 0);
                MessageBox.Show($"✓ Đã xóa policy: {policyName}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadVPDAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa policy: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region ===== FGA TAB =====
        private void CreateFGATab()
        {
            var tabFGA = new TabPage("📋 FGA / Audit");
            tabFGA.BackColor = Color.White;

            // Info panel - Dock top
            var panelInfo = new Panel { Dock = DockStyle.Top, Height = 60, BackColor = Color.FromArgb(255, 243, 224) };
            panelInfo.Controls.Add(new Label
            {
                Text = "📋 FGA (Fine-Grained Auditing) - Ghi log truy cập dữ liệu\n" +
                       "• Audit SELECT/UPDATE/DELETE trên dữ liệu nhạy cảm  • Xem log: DBA_FGA_AUDIT_TRAIL  • Đây là chế độ chỉ xem; double-click preset để thêm lại mẫu",
                Dock = DockStyle.Fill,
                Padding = new Padding(10, 8, 10, 0),
                Font = new Font("Segoe UI", 9F)
            });

            // Main content panel
            var panelContent = new Panel { Dock = DockStyle.Fill, Padding = new Padding(10) };
            
            // Split container for left/right
            var splitContainer = new SplitContainer
            {
                Dock = DockStyle.Fill,
                Orientation = Orientation.Vertical,
                SplitterDistance = 700,
                SplitterWidth = 8
            };

            // LEFT: Policies hiện có
            var lblCurrent = new Label { Text = "📋 Danh sách FGA hiện có (chỉ xem):", Dock = DockStyle.Top, Height = 25, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            dgvFGA = new DataGridView
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White
            };

            // Buttons: Xóa + Xem Logs
            var panelFGAButtons = new FlowLayoutPanel { Dock = DockStyle.Bottom, Height = 40, FlowDirection = FlowDirection.LeftToRight, Padding = new Padding(0, 5, 0, 0) };
            var btnDropFGA = CreateBtn("🗑️ Xóa Policy", Color.FromArgb(220, 53, 69), Point.Empty);
            btnDropFGA.Click += async (s, e) => await DropSelectedFGAAsync();
            var btnViewLogs = CreateBtn("📄 Xem Audit Logs", Color.FromArgb(108, 117, 125), Point.Empty);
            btnViewLogs.Size = new Size(140, 32);
            btnViewLogs.Click += async (s, e) => await ViewFGALogsAsync();
            panelFGAButtons.Controls.AddRange(new Control[] { btnDropFGA, btnViewLogs });

            splitContainer.Panel1.Controls.Add(dgvFGA);
            splitContainer.Panel1.Controls.Add(panelFGAButtons);
            splitContainer.Panel1.Controls.Add(lblCurrent);

            // RIGHT: Preset policies
            var lblPreset = new Label { Text = "⚡ Policy mẫu (double-click để thêm lại nếu đã xóa):", Dock = DockStyle.Top, Height = 25, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            lstPresetFGA = new ListBox { Dock = DockStyle.Fill, Font = new Font("Segoe UI", 9F) };
            // Preset items will be refreshed when loading FGA
            lstPresetFGA.DoubleClick += async (s, e) => await AddPresetFGAAsync();

            splitContainer.Panel2.Controls.Add(lstPresetFGA);
            splitContainer.Panel2.Controls.Add(lblPreset);

            panelContent.Controls.Add(splitContainer);
            tabFGA.Controls.Add(panelContent);
            tabFGA.Controls.Add(panelInfo);
            tabControl.TabPages.Add(tabFGA);
        }

        // All available FGA presets - khớp với 04_policies.sql
        private static readonly (string Table, string Policy, string Column, string Condition, string Stmt, string Desc)[] _fgaPresets = new[]
        {
            ("TINNHAN", "FGA_TINNHAN_SELECT", "NOIDUNG,SECURITYLABEL", "", "SELECT", "Ghi log khi đọc tin nhắn"),
            ("TINNHAN", "FGA_TINNHAN_SENSITIVE", "NOIDUNG", "SECURITYLABEL >= 4", "SELECT,INSERT,UPDATE,DELETE", "Audit tin nhắn nhạy cảm (Level >= 4)"),
            ("TAIKHOAN", "FGA_TAIKHOAN_PASSWORD", "PASSWORD_HASH", "", "SELECT,UPDATE", "Audit truy cập mật khẩu"),
            ("AUDIT_LOGS", "FGA_AUDIT_ACCESS", "", "", "SELECT,DELETE", "Audit truy cập bảng audit logs")
        };

        private async Task AddPresetFGAAsync()
        {
            if (lstPresetFGA.SelectedIndex < 0) return;
            
            var selectedItem = lstPresetFGA.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedItem) || selectedItem.StartsWith("✓")) return;
            
            // Find matching preset
            var preset = _fgaPresets.FirstOrDefault(p => selectedItem.Contains(p.Policy));
            if (preset.Policy == null)
            {
                MessageBox.Show("Không tìm thấy preset!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            try
            {
                using var cmd = _dbContext.Connection.CreateCommand();
                // Dùng 'CHATAPPLICATION' giống 04_policies.sql, NULL cho empty values
                var auditCol = string.IsNullOrEmpty(preset.Column) ? "NULL" : $"'{preset.Column}'";
                var auditCond = string.IsNullOrEmpty(preset.Condition) ? "NULL" : $"'{preset.Condition.Replace("'", "''")}'";
                cmd.CommandText = $@"BEGIN DBMS_FGA.ADD_POLICY(
                    object_schema => 'CHATAPPLICATION', 
                    object_name => '{preset.Table}', 
                    policy_name => '{preset.Policy}',
                    audit_column => {auditCol}, 
                    audit_condition => {auditCond}, 
                    statement_types => '{preset.Stmt}', 
                    enable => TRUE); END;";
                await cmd.ExecuteNonQueryAsync();
                await _dbContext.WriteAuditLogAsync(_adminUsername, "FGA_ADD_PRESET", $"{preset.Table}.{preset.Policy}", 0);
                MessageBox.Show($"✓ Đã thêm FGA Policy: {preset.Policy}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadFGAAsync();
            }
            catch (OracleException ex) when (ex.Number == 28101) // Policy already exists
            {
                MessageBox.Show($"Policy '{preset.Policy}' đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task DropSelectedFGAAsync()
        {
            if (dgvFGA.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn một policy để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvFGA.SelectedRows[0];
            var tableName = row.Cells["Table"].Value?.ToString();
            var policyName = row.Cells["Policy"].Value?.ToString();

            if (string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(policyName))
            {
                MessageBox.Show("Không thể xác định policy!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Xóa FGA Policy '{policyName}' trên bảng '{tableName}'?", "Xác nhận xóa", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using var cmd = _dbContext.Connection.CreateCommand();
                cmd.CommandText = $"BEGIN DBMS_FGA.DROP_POLICY(USER, '{tableName}', '{policyName}'); END;";
                await cmd.ExecuteNonQueryAsync();
                await _dbContext.WriteAuditLogAsync(_adminUsername, "FGA_DROP", $"{tableName}.{policyName}", 0);
                MessageBox.Show($"✓ Đã xóa policy: {policyName}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadFGAAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa policy: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region ===== MAC TAB =====
        private void CreateMACTab()
        {
            var tabMAC = new TabPage("🏷️ MAC / Labels");
            tabMAC.BackColor = Color.White;

            var panelInfo = new Panel { Dock = DockStyle.Top, Height = 60, BackColor = Color.FromArgb(232, 234, 246) };
            panelInfo.Controls.Add(new Label
            {
                Text = "🏷️ MAC (Mandatory Access Control) - Bảo mật theo labels/levels\n" +
                       "• Bell-LaPadula: No Read Up, No Write Down  • TAIKHOAN.CLEARANCELEVEL vs TINNHAN.SECURITYLABEL",
                Dock = DockStyle.Fill,
                Padding = new Padding(10, 8, 10, 0),
                Font = new Font("Segoe UI", 9F)
            });

            var panelContent = new Panel { Dock = DockStyle.Fill, Padding = new Padding(10) };
            var splitContainer = new SplitContainer
            {
                Dock = DockStyle.Fill,
                Orientation = Orientation.Vertical,
                SplitterDistance = 500,
                SplitterWidth = 8
            };

            dgvMAC = new DataGridView
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White
            };
            splitContainer.Panel1.Controls.Add(dgvMAC);

            var txtLevels = new TextBox
            {
                Dock = DockStyle.Fill,
                Multiline = true,
                ReadOnly = true,
                Font = new Font("Consolas", 10F),
                BackColor = Color.FromArgb(40, 44, 52),
                ForeColor = Color.FromArgb(171, 178, 191),
                Text = @"╔═════════════════════════════════════╗
║     SECURITY LEVELS (Bell-LaPadula)  ║
╠═════════════════════════════════════╣
║  Level 1: UNCLASSIFIED  - Công khai  ║
║  Level 2: INTERNAL      - Nội bộ     ║
║  Level 3: CONFIDENTIAL  - Bảo mật    ║
║  Level 4: SECRET        - Bí mật     ║
║  Level 5: TOP SECRET    - Tối mật    ║
╠═════════════════════════════════════╣
║  User (Clearance=X) chỉ đọc được    ║
║  tin nhắn có SecurityLabel <= X      ║
╚═════════════════════════════════════╝"
            };
            splitContainer.Panel2.Controls.Add(txtLevels);

            panelContent.Controls.Add(splitContainer);
            tabMAC.Controls.Add(panelContent);
            tabMAC.Controls.Add(panelInfo);
            tabControl.TabPages.Add(tabMAC);
        }
        #endregion

        #region ===== HELP TAB =====
        private void CreateHelpTab()
        {
            var tabHelp = new TabPage("❓ Hướng dẫn");
            var txtHelp = new TextBox
            {
                Dock = DockStyle.Fill,
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Font = new Font("Consolas", 9.5F),
                BackColor = Color.FromArgb(30, 30, 30),
                ForeColor = Color.FromArgb(220, 220, 220),
                Text = GetHelpText()
            };
            tabHelp.Controls.Add(txtHelp);
            tabControl.TabPages.Add(tabHelp);
        }
        #endregion

        #region ===== DATA LOADING =====
        private async Task LoadCurrentTabAsync()
        {
            switch (tabControl.SelectedIndex)
            {
                case 0: await LoadVPDAsync(); break;
                case 1: await LoadFGAAsync(); break;
                case 2: await LoadMACAsync(); break;
            }
        }

        private async Task LoadVPDAsync()
        {
            try
            {
                lblStatus.Text = "Loading VPD...";
                using var cmd = _dbContext.Connection.CreateCommand();
                cmd.CommandText = "SELECT OBJECT_NAME, POLICY_NAME, NVL(FUNCTION,'N/A') AS FUNC, ENABLE FROM USER_POLICIES ORDER BY OBJECT_NAME";
                var list = new List<object>();
                var activePolicies = new HashSet<string>();
                using var r = await cmd.ExecuteReaderAsync();
                while (await r.ReadAsync())
                {
                    var policyName = r.GetString(1);
                    activePolicies.Add(policyName);
                    list.Add(new { Table = r.GetString(0), Policy = policyName, Function = r.GetString(2), Status = r.GetString(3) == "YES" ? "✓ Enabled" : "✗ Disabled" });
                }
                dgvVPD.DataSource = list;
                
                // Refresh preset list - only show policies that are NOT currently active
                lstPresetVPD.Items.Clear();
                foreach (var preset in _vpdPresets)
                {
                    if (!activePolicies.Contains(preset.Policy))
                    {
                        lstPresetVPD.Items.Add($"🔒 {preset.Table}: {preset.Desc} [{preset.Policy}]");
                    }
                }
                if (lstPresetVPD.Items.Count == 0)
                    lstPresetVPD.Items.Add("✓ Tất cả policy mẫu đã được thêm");
                    
                lblStatus.Text = $"VPD: {list.Count} policies đang hoạt động";
            }
            catch (Exception ex) { lblStatus.Text = $"Error: {ex.Message}"; MessageBox.Show($"Lỗi load VPD:\n{ex.Message}", "Error"); }
        }

        private async Task LoadFGAAsync()
        {
            try
            {
                lblStatus.Text = "Loading FGA...";
                using var cmd = _dbContext.Connection.CreateCommand();
                var list = new List<object>();
                var activePolicies = new HashSet<string>();
                
                // Try DBA view first (if user has DBA role)
                try
                {
                    cmd.CommandText = @"
                        SELECT OBJECT_NAME, POLICY_NAME, ENABLED, 
                               NVL(AUDIT_COLUMN,'ALL') AS AUDIT_COL, 
                               NVL(STATEMENT_TYPES,'SELECT') AS STMT_TYPES
                        FROM DBA_AUDIT_POLICIES 
                        WHERE OBJECT_SCHEMA = USER
                        ORDER BY OBJECT_NAME";
                    using var r = await cmd.ExecuteReaderAsync();
                    while (await r.ReadAsync())
                    {
                        var policyName = r.GetString(1);
                        activePolicies.Add(policyName);
                        list.Add(new { Table = r.GetString(0), Policy = policyName, Status = r.GetString(2) == "YES" ? "✓ Enabled" : "✗ Disabled", Column = r.GetString(3), Statements = r.GetString(4) });
                    }
                }
                catch
                {
                    // Fallback to checking ADMIN_POLICY table for FGA records
                    list.Clear();
                    using var cmd2 = _dbContext.Connection.CreateCommand();
                    cmd2.CommandText = @"
                        SELECT TABLE_NAME, POLICY_NAME, IS_ENABLED, 
                               NVL(STATEMENT_TYPES,'SELECT') AS STMT_TYPES,
                               NVL(DESCRIPTION,'') AS DESCR
                        FROM ADMIN_POLICY 
                        WHERE POLICY_TYPE = 'FGA'
                        ORDER BY TABLE_NAME";
                    using var r2 = await cmd2.ExecuteReaderAsync();
                    while (await r2.ReadAsync())
                    {
                        var policyName = r2.GetString(1);
                        activePolicies.Add(policyName);
                        list.Add(new { 
                            Table = r2.GetString(0), 
                            Policy = policyName, 
                            Status = r2.GetInt32(2) == 1 ? "✓ Enabled" : "✗ Disabled", 
                            Column = "ALL",
                            Statements = r2.GetString(3) 
                        });
                    }
                }
                
                dgvFGA.DataSource = list;
                
                // Refresh preset list - only show policies that are NOT currently active
                lstPresetFGA.Items.Clear();
                foreach (var preset in _fgaPresets)
                {
                    if (!activePolicies.Contains(preset.Policy))
                    {
                        lstPresetFGA.Items.Add($"📝 {preset.Table}: {preset.Desc} [{preset.Policy}]");
                    }
                }
                if (lstPresetFGA.Items.Count == 0)
                    lstPresetFGA.Items.Add("✓ Tất cả policy mẫu đã được thêm");
                    
                lblStatus.Text = $"FGA: {list.Count} policies đang hoạt động";
            }
            catch (Exception ex) { lblStatus.Text = $"Error: {ex.Message}"; }
        }

        private async Task LoadMACAsync()
        {
            try
            {
                lblStatus.Text = "Loading MAC...";
                using var cmd = _dbContext.Connection.CreateCommand();
                cmd.CommandText = @"
                    SELECT 1 AS LVL, 'UNCLASSIFIED' AS NAME, (SELECT COUNT(*) FROM TAIKHOAN WHERE NVL(CLEARANCELEVEL,1)=1) AS CNT FROM DUAL UNION ALL
                    SELECT 2, 'INTERNAL', (SELECT COUNT(*) FROM TAIKHOAN WHERE CLEARANCELEVEL=2) FROM DUAL UNION ALL
                    SELECT 3, 'CONFIDENTIAL', (SELECT COUNT(*) FROM TAIKHOAN WHERE CLEARANCELEVEL=3) FROM DUAL UNION ALL
                    SELECT 4, 'SECRET', (SELECT COUNT(*) FROM TAIKHOAN WHERE CLEARANCELEVEL=4) FROM DUAL UNION ALL
                    SELECT 5, 'TOP SECRET', (SELECT COUNT(*) FROM TAIKHOAN WHERE CLEARANCELEVEL=5) FROM DUAL";
                using var r = await cmd.ExecuteReaderAsync();
                var list = new List<object>();
                while (await r.ReadAsync())
                    list.Add(new { Level = r.GetInt32(0), Name = r.GetString(1), Users = r.GetInt32(2) });
                dgvMAC.DataSource = list;
                lblStatus.Text = "MAC: Loaded";
            }
            catch (Exception ex) { lblStatus.Text = $"Error: {ex.Message}"; }
        }

        #endregion

        #region ===== POLICY ACTIONS =====
        private async Task ToggleVPDAsync(bool enable)
        {
            if (dgvVPD.SelectedRows.Count == 0) { MessageBox.Show("Chọn một policy"); return; }
            var tbl = dgvVPD.SelectedRows[0].Cells["Table"].Value?.ToString();
            var pol = dgvVPD.SelectedRows[0].Cells["Policy"].Value?.ToString();
            try
            {
                using var cmd = _dbContext.Connection.CreateCommand();
                cmd.CommandText = $"BEGIN DBMS_RLS.{(enable ? "ENABLE" : "DISABLE")}_POLICY(USER, :t, :p); END;";
                cmd.Parameters.Add(new OracleParameter("t", tbl));
                cmd.Parameters.Add(new OracleParameter("p", pol));
                await cmd.ExecuteNonQueryAsync();
                await _dbContext.WriteAuditLogAsync(_adminUsername, enable ? "VPD_ENABLE" : "VPD_DISABLE", $"{tbl}.{pol}", 0);
                MessageBox.Show($"✓ Policy {(enable ? "enabled" : "disabled")}!", "Thành công");
                await LoadVPDAsync();
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi: {ex.Message}"); }
        }

        private async Task DropVPDAsync()
        {
            if (dgvVPD.SelectedRows.Count == 0) { MessageBox.Show("Chọn một policy"); return; }
            if (MessageBox.Show("Xóa VPD policy này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            var tbl = dgvVPD.SelectedRows[0].Cells["Table"].Value?.ToString();
            var pol = dgvVPD.SelectedRows[0].Cells["Policy"].Value?.ToString();
            try
            {
                using var cmd = _dbContext.Connection.CreateCommand();
                cmd.CommandText = "BEGIN DBMS_RLS.DROP_POLICY(USER, :t, :p); END;";
                cmd.Parameters.Add(new OracleParameter("t", tbl));
                cmd.Parameters.Add(new OracleParameter("p", pol));
                await cmd.ExecuteNonQueryAsync();
                MessageBox.Show("✓ Đã xóa!"); await LoadVPDAsync();
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi: {ex.Message}"); }
        }

        private async Task ToggleFGAAsync(bool enable)
        {
            if (dgvFGA.SelectedRows.Count == 0) { MessageBox.Show("Chọn một FGA policy"); return; }
            var tbl = dgvFGA.SelectedRows[0].Cells["Table"].Value?.ToString();
            var pol = dgvFGA.SelectedRows[0].Cells["Policy"].Value?.ToString();
            try
            {
                using var cmd = _dbContext.Connection.CreateCommand();
                cmd.CommandText = $"BEGIN DBMS_FGA.{(enable ? "ENABLE" : "DISABLE")}_POLICY(USER, :t, :p); END;";
                cmd.Parameters.Add(new OracleParameter("t", tbl));
                cmd.Parameters.Add(new OracleParameter("p", pol));
                await cmd.ExecuteNonQueryAsync();
                MessageBox.Show($"✓ FGA Policy {(enable ? "enabled" : "disabled")}!"); await LoadFGAAsync();
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi: {ex.Message}"); }
        }

        private async Task DropFGAAsync()
        {
            if (dgvFGA.SelectedRows.Count == 0) { MessageBox.Show("Chọn một FGA policy"); return; }
            if (MessageBox.Show("Xóa FGA policy này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            var tbl = dgvFGA.SelectedRows[0].Cells["Table"].Value?.ToString();
            var pol = dgvFGA.SelectedRows[0].Cells["Policy"].Value?.ToString();
            try
            {
                using var cmd = _dbContext.Connection.CreateCommand();
                cmd.CommandText = "BEGIN DBMS_FGA.DROP_POLICY(USER, :t, :p); END;";
                cmd.Parameters.Add(new OracleParameter("t", tbl));
                cmd.Parameters.Add(new OracleParameter("p", pol));
                await cmd.ExecuteNonQueryAsync();
                MessageBox.Show("✓ Đã xóa!"); await LoadFGAAsync();
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi: {ex.Message}"); }
        }

        private async Task ViewFGALogsAsync()
        {
            try
            {
                using var cmd = _dbContext.Connection.CreateCommand();
                cmd.CommandText = "SELECT TIMESTAMP, DB_USER, OBJECT_NAME, POLICY_NAME, SQL_TEXT FROM DBA_FGA_AUDIT_TRAIL WHERE OBJECT_SCHEMA = USER ORDER BY TIMESTAMP DESC FETCH FIRST 100 ROWS ONLY";
                var list = new List<object>();
                using var r = await cmd.ExecuteReaderAsync();
                while (await r.ReadAsync())
                    list.Add(new { Time = r.GetDateTime(0).ToString("dd/MM HH:mm"), User = r.GetString(1), Table = r.GetString(2), Policy = r.GetString(3), SQL = r.IsDBNull(4) ? "" : r.GetString(4).Substring(0, Math.Min(50, r.GetString(4).Length)) });

                using var dlg = new Form { Text = "FGA Audit Logs", Size = new Size(900, 500), BackColor = Color.White };
                var dgv = new DataGridView { Dock = DockStyle.Fill, DataSource = list, ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
                if (list.Count == 0)
                {
                    var lbl = new Label { Text = "📋 Chưa có FGA audit logs.\n\n1. Thêm FGA policy (click đôi vào preset)\n2. Thực hiện query thỏa điều kiện\n3. Logs sẽ hiện ở đây", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 12F) };
                    dlg.Controls.Add(lbl);
                }
                else dlg.Controls.Add(dgv);
                dlg.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}\n\nCần quyền SELECT trên DBA_FGA_AUDIT_TRAIL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Custom VPD/FGA dialogs removed - chỉ sử dụng preset policies
        #endregion

        #region ===== HELPERS =====
        private void RepositionBottomControls(Label lblStatus, Button btnRefresh, Button btnClose)
        {
            int bottom = this.ClientSize.Height - 45;
            lblStatus.Location = new Point(20, bottom + 8);
            btnClose.Location = new Point(this.ClientSize.Width - 130, bottom);
            btnRefresh.Location = new Point(this.ClientSize.Width - 260, bottom);
        }

        private Button CreateBtn(string text, Color bg, Point loc, Color? fg = null)
        {
            var btn = new Button { Text = text, Size = new Size(110, 32), Location = loc, BackColor = bg, ForeColor = fg ?? Color.White, FlatStyle = FlatStyle.Flat, Cursor = Cursors.Hand };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }

        private string GetHelpText()
        {
            return @"
╔══════════════════════════════════════════════════════════════════════════════════╗
║                    HƯỚNG DẪN ORACLE SECURITY POLICIES                            ║
╚══════════════════════════════════════════════════════════════════════════════════╝

🛡️ VPD (Virtual Private Database) / RLS (Row Level Security)
════════════════════════════════════════════════════════════════════════════════════
  📌 TỰ ĐỘNG thêm WHERE clause vào query
     SELECT * FROM TINNHAN  →  SELECT * FROM TINNHAN WHERE SECURITYLABEL <= 2
  
  📌 CÁC PRESET:
     • VPD_TINNHAN_MAC: Lọc theo SecurityLabel (Bell-LaPadula)
     • VPD_CUOCTROCHUYEN_MEMBER: Chỉ xem cuộc chat mình tham gia
     • VPD_THANHVIEN_MEMBER: Chỉ xem thành viên trong chat của mình

📋 FGA (Fine-Grained Auditing)
════════════════════════════════════════════════════════════════════════════════════
  📌 GHI LOG khi user truy cập data nhạy cảm
  
  📌 CÁC PRESET:
     • FGA_TINNHAN_CONFIDENTIAL: Audit khi xem tin SecurityLabel >= 3
     • FGA_TINNHAN_MODIFY: Audit khi UPDATE/DELETE tin nhắn
     • FGA_TAIKHOAN_PASSWORD: Audit khi xem thông tin mật khẩu

🔐 ENCRYPTION (AES / RSA / Hybrid)
════════════════════════════════════════════════════════════════════════════════════
  📌 AES-256 (Symmetric): 
     • Socket communication: EncryptionHelper.Encrypt()/Decrypt()
     • Database: DBMS_CRYPTO trong SP_GUI_TINNHAN_MAHOA_AES
  
  📌 RSA-2048 (Asymmetric):
     • Chữ ký số: RsaSign() khi gửi, RsaVerify() khi nhận
     • Key exchange: Mã hóa AES key để gửi qua mạng
     • Mã hóa data nhỏ: RsaEncrypt() cho data < 200 bytes
  
  📌 Hybrid (RSA + AES):
     • HybridEncrypt(): Mã hóa file/attachment lớn
       1. Tạo AES session key ngẫu nhiên
       2. Mã hóa data bằng AES (nhanh)
       3. Mã hóa AES key bằng RSA (bảo mật)

💡 CÁCH SỬ DỤNG:
════════════════════════════════════════════════════════════════════════════════════
  1. Click đôi vào preset policy để thêm nhanh
  2. Hoặc click '➕ Tùy chỉnh' để tạo policy riêng
  3. Xem ENCRYPTION_LOGS để theo dõi mã hóa

⚠️ LƯU Ý:
  • Chạy SQL script trước: Database/Scripts/create_encryption_logs.sql
  • FGA cần quyền DBA để xem logs: DBA_FGA_AUDIT_TRAIL
";
        }
        #endregion
    }
}
