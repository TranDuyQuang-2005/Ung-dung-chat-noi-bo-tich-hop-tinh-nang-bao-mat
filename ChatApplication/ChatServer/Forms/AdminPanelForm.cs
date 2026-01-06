//using System;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using ChatServer.Database;
//using ChatServer.Services;

//namespace ChatServer.Forms
//{
//    public partial class AdminPanelForm : Form
//    {
//        private readonly DbContext _dbContext;
//        private readonly string _adminUsername;
//        private readonly int _clearanceLevel;

//        public AdminPanelForm(DbContext dbContext, string adminUsername, int clearanceLevel)
//        {
//            _dbContext = dbContext;
//            _adminUsername = adminUsername;
//            _clearanceLevel = clearanceLevel;
//            InitializeComponent();
//            SetupEventHandlers();
//            lblCurrentUser.Text = $"Đăng nhập bởi: {adminUsername} (Level {clearanceLevel})";

//            // Load initial data asynchronously
//            _ = Task.Run(async () =>
//            {
//                await Task.Delay(100); // Small delay to ensure form is fully loaded

//                // Set MAC context với admin level để bypass VPD restrictions cho toàn bộ admin session
//                try
//                {
//                    await _dbContext.SetMacContextAsync(adminUsername, clearanceLevel >= 4 ? clearanceLevel : 5);
//                }
//                catch { /* Ignore if procedure doesn't exist */ }

//                if (InvokeRequired)
//                {
//                    Invoke(new Action(async () => await LoadUsersAsync()));
//                }
//                else
//                {
//                    await LoadUsersAsync();
//                }
//            });
//        }

//        private void SetupEventHandlers()
//        {
//            btnRefreshUsers.Click += async (_, _) => await LoadUsersAsync();
//            btnCreateUser.Click += (_, _) => ShowCreateUserDialog();
//            btnEditUser.Click += (_, _) => ShowEditUserDialog();
//            btnDeleteUser.Click += async (_, _) => await DeleteUserAsync();
//            btnBanUser.Click += async (_, _) => await BanUserAsync();
//            btnUnbanUser.Click += async (_, _) => await UnbanUserAsync();
//            btnUnlockAccount.Click += async (_, _) => await UnlockAccountAsync();

//            btnRefreshConversations.Click += async (_, _) => await LoadConversationsAsync();
//            btnDeleteConversation.Click += async (_, _) => await DeleteConversationAsync();
//            btnViewMessages.Click += async (_, _) => await LoadConversationMessagesAsync();

//            btnRefreshMessages.Click += async (_, _) => await LoadMessagesAsync();
//            btnDeleteMessage.Click += async (_, _) => await DeleteMessageAsync();

//            btnRefreshLogs.Click += async (_, _) => await LoadAuditLogsAsync();

//            // Policy Management button - gắn trực tiếp
//            btnPolicyManagement.Click += (_, _) => OpenPolicyManagement();

//            tabControl.SelectedIndexChanged += async (_, _) => await OnTabChangedAsync();
//        }

//        private void OpenPolicyManagement()
//        {
//            try
//            {
//                using var policyForm = new PolicyManagementForm(_dbContext, _adminUsername);
//                policyForm.ShowDialog(this);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Lỗi mở Policy Management: {ex.Message}\n\nChi tiết: {ex.StackTrace}", "Lỗi",
//                    MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private async Task OnTabChangedAsync()
//        {
//            switch (tabControl.SelectedIndex)
//            {
//                case 0: await LoadUsersAsync(); break;
//                case 1: await LoadConversationsAsync(); break;
//                case 2: await LoadMessagesAsync(); break;
//                case 3: await LoadAuditLogsAsync(); break;
//            }
//        }

//        // Users Management
//        private async Task LoadUsersAsync()
//        {
//            try
//            {
//                if (InvokeRequired)
//                {
//                    Invoke(new Action(async () => await LoadUsersAsync()));
//                    return;
//                }

//                btnRefreshUsers.Enabled = false;
//                var users = await Task.Run(() => _dbContext.GetAllUsersAsync().Result);

//                dgvUsers.DataSource = users.Select(u => new
//                {
//                    u.Matk,
//                    u.Username,
//                    u.Hovaten,
//                    u.Chucvu,
//                    u.Phongban,
//                    u.Email,
//                    u.Phone,
//                    u.ClearanceLevel,
//                    IsBanned = u.IsBannedGlobal ? "Có" : "Không",
//                    IsVerified = u.IsOtpVerified ? "Có" : "Không",
//                    AccountLocked = u.IsAccountLocked ? $"🔒 Khóa ({u.FailedLoginAttempts} lần)" : 
//                                   (u.FailedLoginAttempts > 0 ? $"⚠️ {u.FailedLoginAttempts}/5 lần sai" : "✓ Bình thường"),
//                    u.NgayTao
//                }).ToList();

//                btnRefreshUsers.Enabled = true;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                btnRefreshUsers.Enabled = true;
//            }
//        }

//        private void ShowCreateUserDialog()
//        {
//            try
//            {
//                using var createForm = new UserEditForm(_dbContext);
//                if (createForm.ShowDialog(this) == DialogResult.OK)
//                {
//                    _ = LoadUsersAsync();
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Lỗi mở form tạo user: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void ShowEditUserDialog()
//        {
//            if (dgvUsers.SelectedRows.Count == 0)
//            {
//                MessageBox.Show("Vui lòng chọn một user để chỉnh sửa.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            var username = dgvUsers.SelectedRows[0].Cells["Username"].Value?.ToString();
//            if (string.IsNullOrEmpty(username))
//                return;

//            try
//            {
//                using var editForm = new UserEditForm(_dbContext, username);
//                if (editForm.ShowDialog(this) == DialogResult.OK)
//                {
//                    _ = LoadUsersAsync();
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Lỗi mở form chỉnh sửa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private async Task DeleteUserAsync()
//        {
//            if (dgvUsers.SelectedRows.Count == 0)
//            {
//                MessageBox.Show("Vui lòng chọn một user để xóa.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            var username = dgvUsers.SelectedRows[0].Cells["Username"].Value?.ToString();
//            if (string.IsNullOrEmpty(username))
//                return;

//            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa user '{username}'?\n\nLưu ý: Tất cả dữ liệu liên quan sẽ bị xóa!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
//            {
//                try
//                {
//                    // Get MATK from username first
//                    string matk = username;
//                    using (var lookupCmd = _dbContext.Connection.CreateCommand())
//                    {
//                        lookupCmd.CommandText = "SELECT MATK FROM TAIKHOAN WHERE MATK = :p_value OR TENTK = :p_value";
//                        lookupCmd.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter("p_value", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2) { Value = username });
//                        var result = await lookupCmd.ExecuteScalarAsync();
//                        if (result != null && result != DBNull.Value)
//                            matk = result.ToString()!;
//                    }

//                    // Delete from child tables in correct order (due to FK constraints)
//                    var deleteCommands = new[] {
//                        "DELETE FROM XACTHUCOTP WHERE MATK = :p",
//                        "DELETE FROM AUDIT_LOGS WHERE MATK = :p",
//                        "DELETE FROM ENCRYPTION_KEYS WHERE MATK = :p",
//                        "DELETE FROM TINNHAN_ATTACH WHERE MATN IN (SELECT MATN FROM TINNHAN WHERE MATK = :p)",
//                        "DELETE FROM ATTACHMENT WHERE MATK = :p",
//                        "DELETE FROM TINNHAN WHERE MATK = :p",
//                        "DELETE FROM THANHVIEN WHERE MATK = :p",
//                        "DELETE FROM NGUOIDUNG WHERE MATK = :p",
//                        "UPDATE CUOCTROCHUYEN SET NGUOIQL = NULL WHERE NGUOIQL = :p",
//                        "DELETE FROM TAIKHOAN WHERE MATK = :p"
//                    };

//                    foreach (var sql in deleteCommands)
//                    {
//                        try
//                        {
//                            using var cmd = _dbContext.Connection.CreateCommand();
//                            cmd.CommandText = sql;
//                            cmd.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter("p", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2) { Value = matk });
//                            await cmd.ExecuteNonQueryAsync();
//                        }
//                        catch (Exception tableEx)
//                        {
//                            System.Diagnostics.Debug.WriteLine($"[DeleteUser] Error: {tableEx.Message}");
//                        }
//                    }

//                    await _dbContext.WriteAuditLogAsync(_adminUsername, "ADMIN_DELETE_USER", $"Deleted: {username} (MATK: {matk})", 0);
//                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    await LoadUsersAsync();
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//        }

//        private async Task BanUserAsync()
//        {
//            if (dgvUsers.SelectedRows.Count == 0)
//            {
//                MessageBox.Show("Vui lòng chọn một user để cấm.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            var username = dgvUsers.SelectedRows[0].Cells["Username"].Value?.ToString();
//            if (string.IsNullOrEmpty(username))
//                return;

//            try
//            {
//                await _dbContext.BanUserGlobalAsync(username);
//                await _dbContext.WriteAuditLogAsync(_adminUsername, "ADMIN_BAN_USER", username, 0);
//                MessageBox.Show("User banned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                await LoadUsersAsync();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private async Task UnbanUserAsync()
//        {
//            if (dgvUsers.SelectedRows.Count == 0)
//            {
//                MessageBox.Show("Vui lòng chọn một user để bỏ cấm.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            var username = dgvUsers.SelectedRows[0].Cells["Username"].Value?.ToString();
//            if (string.IsNullOrEmpty(username))
//                return;

//            try
//            {
//                await _dbContext.UnbanUserGlobalAsync(username);
//                await _dbContext.WriteAuditLogAsync(_adminUsername, "ADMIN_UNBAN_USER", username, 0);
//                MessageBox.Show("User unbanned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                await LoadUsersAsync();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private async Task UnlockAccountAsync()
//        {
//            if (dgvUsers.SelectedRows.Count == 0)
//            {
//                MessageBox.Show("Vui lòng chọn một user để mở khóa.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            var matk = dgvUsers.SelectedRows[0].Cells["Matk"].Value?.ToString();
//            var username = dgvUsers.SelectedRows[0].Cells["Username"].Value?.ToString();
//            if (string.IsNullOrEmpty(matk))
//                return;

//            try
//            {
//                await _dbContext.UnlockAccountAsync(matk);
//                await _dbContext.WriteAuditLogAsync(_adminUsername, "ADMIN_UNLOCK_ACCOUNT", username ?? matk, 0);
//                MessageBox.Show($"Đã mở khóa tài khoản {username}.\nUser có thể đăng nhập lại.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                await LoadUsersAsync();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        // Conversations Management
//        private async Task LoadConversationsAsync()
//        {
//            try
//            {
//                if (InvokeRequired)
//                {
//                    Invoke(new Action(async () => await LoadConversationsAsync()));
//                    return;
//                }

//                btnRefreshConversations.Enabled = false;

//                // Call async method directly without Task.Run and .Result
//                var conversations = await _dbContext.GetAllConversationsAsync();

//                dgvConversations.DataSource = conversations.Select(c => new
//                {
//                    c.Mactc,
//                    c.Tenctc,
//                    c.Maloaictc,
//                    IsPrivate = c.IsPrivate ? "Có" : "Không",
//                    c.Nguoiql,
//                    MinClearance = $"Mức {c.MinClearance}",
//                    c.MemberCount,
//                    c.MessageCount,
//                    NgayTao = c.NgayTao.ToString("dd/MM/yyyy HH:mm")
//                }).ToList();

//                btnRefreshConversations.Enabled = true;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Lỗi tải conversations:\n{ex.Message}\n\nStack Trace:\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                btnRefreshConversations.Enabled = true;
//            }
//        }

//        private async Task DeleteConversationAsync()
//        {
//            if (dgvConversations.SelectedRows.Count == 0)
//            {
//                MessageBox.Show("Vui lòng chọn một conversation để xóa.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            var mactc = dgvConversations.SelectedRows[0].Cells["Mactc"].Value?.ToString();
//            if (string.IsNullOrEmpty(mactc))
//                return;

//            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa conversation này?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
//            {
//                try
//                {
//                    await _dbContext.DeleteConversationAsync(mactc);
//                    await _dbContext.WriteAuditLogAsync(_adminUsername, "ADMIN_DELETE_CONVERSATION", mactc, 0);
//                    MessageBox.Show("Conversation deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    await LoadConversationsAsync();
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//        }

//        private async Task LoadConversationMessagesAsync()
//        {
//            if (dgvConversations.SelectedRows.Count == 0)
//            {
//                MessageBox.Show("Vui lòng chọn một conversation để xem messages.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            var mactc = dgvConversations.SelectedRows[0].Cells["Mactc"].Value?.ToString();
//            if (string.IsNullOrEmpty(mactc))
//                return;

//            try
//            {
//                if (InvokeRequired)
//                {
//                    Invoke(new Action(async () => await LoadConversationMessagesAsync()));
//                    return;
//                }

//                btnViewMessages.Enabled = false;
//                btnRefreshMessages.Enabled = false;

//                // Call async method directly without Task.Run and .Result
//                var messages = await _dbContext.GetConversationMessagesAdminAsync(mactc, 100);

//                dgvMessages.DataSource = messages.Select(m => new
//                {
//                    m.Matn,
//                    m.Username,
//                    Noidung = m.Noidung.Length > 100 ? m.Noidung.Substring(0, 100) + "..." : m.Noidung,
//                    SecurityLabel = $"Mức {m.SecurityLabel}",
//                    Ngaygui = m.Ngaygui.ToString("dd/MM/yyyy HH:mm:ss"),
//                    m.Maloaitn,
//                    m.Matrangthai
//                }).ToList();

//                btnViewMessages.Enabled = true;
//                btnRefreshMessages.Enabled = true;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Lỗi tải messages:\n{ex.Message}\n\nStack Trace:\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                btnViewMessages.Enabled = true;
//                btnRefreshMessages.Enabled = true;
//            }
//        }

//        // Messages Management
//        private async Task LoadMessagesAsync()
//        {
//            await LoadConversationMessagesAsync();
//        }

//        private async Task DeleteMessageAsync()
//        {
//            if (dgvMessages.SelectedRows.Count == 0)
//            {
//                MessageBox.Show("Vui lòng chọn một message để xóa.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            var matnStr = dgvMessages.SelectedRows[0].Cells["Matn"].Value?.ToString();
//            if (string.IsNullOrEmpty(matnStr) || !int.TryParse(matnStr, out var matn))
//                return;

//            if (MessageBox.Show("Bạn có chắc chắn muốn xóa message này?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
//            {
//                try
//                {
//                    await _dbContext.DeleteMessageAsync(matn);
//                    await _dbContext.WriteAuditLogAsync(_adminUsername, "ADMIN_DELETE_MESSAGE", matn.ToString(), 0);
//                    MessageBox.Show("Message deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    await LoadMessagesAsync();
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//        }

//        // Audit Logs
//        private async Task LoadAuditLogsAsync()
//        {
//            try
//            {
//                if (InvokeRequired)
//                {
//                    Invoke(new Action(async () => await LoadAuditLogsAsync()));
//                    return;
//                }

//                btnRefreshLogs.Enabled = false;

//                var logs = await Task.Run(async () =>
//                {
//                    try
//                    {
//                        return await _dbContext.GetAuditLogsAsync(100);
//                    }
//                    catch (Exception ex)
//                    {
//                        System.Diagnostics.Debug.WriteLine($"GetAuditLogsAsync error: {ex.Message}");
//                        return new System.Collections.Generic.List<AuditLogInfo>();
//                    }
//                });

//                if (logs != null && logs.Count > 0)
//                {
//                    dgvAuditLogs.DataSource = logs.Select(l => new
//                    {
//                        ID = l.LogId,
//                        User = l.Matk ?? "N/A",
//                        Action = l.Action ?? "N/A",
//                        Target = l.Target ?? "N/A",
//                        Level = l.SecurityLabel,
//                        Time = l.Timestamp.ToString("yyyy-MM-dd HH:mm:ss")
//                    }).ToList();
//                }
//                else
//                {
//                    dgvAuditLogs.DataSource = null;
//                    MessageBox.Show("Không có audit log nào hoặc xảy ra lỗi khi tải.", "Thông báo",
//                        MessageBoxButtons.OK, MessageBoxIcon.Information);
//                }

//                btnRefreshLogs.Enabled = true;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Lỗi tải audit logs: {ex.Message}\n\nChi tiết: {ex.StackTrace}", "Lỗi",
//                    MessageBoxButtons.OK, MessageBoxIcon.Error);
//                btnRefreshLogs.Enabled = true;
//            }
//        }
//    }
//}


using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatServer.Database;
using ChatServer.Services;
using System.Collections.Generic;
using System.IO;
using OfficeOpenXml;
using System.ComponentModel;

namespace ChatServer.Forms
{
    public partial class AdminPanelForm : Form
    {
        private readonly DbContext _dbContext;
        private readonly string _adminUsername;
        private readonly int _clearanceLevel;

        public AdminPanelForm(DbContext dbContext, string adminUsername, int clearanceLevel)
        {
            _dbContext = dbContext;
            _adminUsername = adminUsername;
            _clearanceLevel = clearanceLevel;
            InitializeComponent();
            SetupEventHandlers();
            lblCurrentUser.Text = $"Đăng nhập bởi: {adminUsername} (Level {clearanceLevel})";

            // Load initial data asynchronously
            _ = Task.Run(async () =>
            {
                await Task.Delay(100); // Small delay to ensure form is fully loaded

                // Set MAC context với admin level để bypass VPD restrictions cho toàn bộ admin session
                try
                {
                    await _dbContext.SetMacContextAsync(adminUsername, clearanceLevel >= 4 ? clearanceLevel : 5);
                }
                catch { /* Ignore if procedure doesn't exist */ }

                if (InvokeRequired)
                {
                    Invoke(new Action(async () => await LoadUsersAsync()));
                }
                else
                {
                    await LoadUsersAsync();
                }
            });
        }

        private void SetupEventHandlers()
        {
            // Existing handlers
            btnRefreshUsers.Click += async (_, _) => await LoadUsersAsync();
            btnCreateUser.Click += (_, _) => ShowCreateUserDialog();
            btnEditUser.Click += (_, _) => ShowEditUserDialog();
            btnDeleteUser.Click += async (_, _) => await DeleteUserAsync();
            btnBanUser.Click += async (_, _) => await BanUserAsync();
            btnUnbanUser.Click += async (_, _) => await UnbanUserAsync();
            btnUnlockAccount.Click += async (_, _) => await UnlockAccountAsync();

            btnRefreshConversations.Click += async (_, _) => await LoadConversationsAsync();
            btnDeleteConversation.Click += async (_, _) => await DeleteConversationAsync();
            btnViewMessages.Click += async (_, _) => await LoadConversationMessagesAsync();

            btnRefreshMessages.Click += async (_, _) => await LoadMessagesAsync();
            btnDeleteMessage.Click += async (_, _) => await DeleteMessageAsync();

            btnRefreshLogs.Click += async (_, _) => await LoadAuditLogsAsync();

            // Policy Management button
            btnPolicyManagement.Click += (_, _) => OpenPolicyManagement();

            // NEW: Backup/Restore handlers
            btnRefreshBackup.Click += async (_, _) => await LoadBackupHistoryAsync();
            btnBackupNow.Click += async (_, _) => await BackupNowAsync();
            btnRestoreBackup.Click += async (_, _) => await RestoreBackupAsync();

            // NEW: Timeout Settings handlers
            btnRefreshTimeout.Click += async (_, _) => await LoadTimeoutSettingsAsync();
            btnUpdateTimeout.Click += async (_, _) => await UpdateTimeoutSettingsAsync();

            // NEW: Login History handlers
            btnRefreshLoginHistory.Click += async (_, _) => await LoadLoginHistoryAsync();
            btnExportLoginHistory.Click += async (_, _) => await ExportLoginHistoryAsync();

            tabControl.SelectedIndexChanged += async (_, _) => await OnTabChangedAsync();
        }

        private void OpenPolicyManagement()
        {
            try
            {
                using var policyForm = new PolicyManagementForm(_dbContext, _adminUsername);
                policyForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi mở Policy Management: {ex.Message}\n\nChi tiết: {ex.StackTrace}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task OnTabChangedAsync()
        {
            switch (tabControl.SelectedIndex)
            {
                case 0: await LoadUsersAsync(); break;
                case 1: await LoadConversationsAsync(); break;
                case 2: await LoadMessagesAsync(); break;
                case 3: await LoadAuditLogsAsync(); break;
                case 4: await LoadBackupHistoryAsync(); break; // Backup/Restore
                case 5: await LoadTimeoutSettingsAsync(); break; // Timeout Settings
                case 6: await LoadLoginHistoryAsync(); break; // Login History
            }
        }

        // ============================================
        // 1. USERS MANAGEMENT
        // ============================================
        private async Task LoadUsersAsync()
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(async () => await LoadUsersAsync()));
                    return;
                }

                btnRefreshUsers.Enabled = false;
                var users = await Task.Run(() => _dbContext.GetAllUsersAsync().Result);

                dgvUsers.DataSource = users.Select(u => new
                {
                    u.Matk,
                    u.Username,
                    u.Hovaten,
                    u.Chucvu,
                    u.Phongban,
                    u.Email,
                    u.Phone,
                    u.ClearanceLevel,
                    IsBanned = u.IsBannedGlobal ? "Có" : "Không",
                    IsVerified = u.IsOtpVerified ? "Có" : "Không",
                    AccountLocked = u.IsAccountLocked ? $"🔒 Khóa ({u.FailedLoginAttempts} lần)" :
                                   (u.FailedLoginAttempts > 0 ? $"⚠️ {u.FailedLoginAttempts}/5 lần sai" : "✓ Bình thường"),
                    u.NgayTao
                }).ToList();

                btnRefreshUsers.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRefreshUsers.Enabled = true;
            }
        }

        private void ShowCreateUserDialog()
        {
            try
            {
                using var createForm = new UserEditForm(_dbContext);
                if (createForm.ShowDialog(this) == DialogResult.OK)
                {
                    _ = LoadUsersAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi mở form tạo user: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowEditUserDialog()
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một user để chỉnh sửa.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var username = dgvUsers.SelectedRows[0].Cells["Username"].Value?.ToString();
            if (string.IsNullOrEmpty(username))
                return;

            try
            {
                using var editForm = new UserEditForm(_dbContext, username);
                if (editForm.ShowDialog(this) == DialogResult.OK)
                {
                    _ = LoadUsersAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi mở form chỉnh sửa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task DeleteUserAsync()
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một user để xóa.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var username = dgvUsers.SelectedRows[0].Cells["Username"].Value?.ToString();
            if (string.IsNullOrEmpty(username))
                return;

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa user '{username}'?\n\nLưu ý: Tất cả dữ liệu liên quan sẽ bị xóa!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string matk = username;
                    using (var lookupCmd = _dbContext.Connection.CreateCommand())
                    {
                        lookupCmd.CommandText = "SELECT MATK FROM TAIKHOAN WHERE MATK = :p_value OR TENTK = :p_value";
                        lookupCmd.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter("p_value", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2) { Value = username });
                        var result = await lookupCmd.ExecuteScalarAsync();
                        if (result != null && result != DBNull.Value)
                            matk = result.ToString()!;
                    }

                    var deleteCommands = new[] {
                        "DELETE FROM XACTHUCOTP WHERE MATK = :p",
                        "DELETE FROM AUDIT_LOGS WHERE MATK = :p",
                        "DELETE FROM ENCRYPTION_KEYS WHERE MATK = :p",
                        "DELETE FROM TINNHAN_ATTACH WHERE MATN IN (SELECT MATN FROM TINNHAN WHERE MATK = :p)",
                        "DELETE FROM ATTACHMENT WHERE MATK = :p",
                        "DELETE FROM TINNHAN WHERE MATK = :p",
                        "DELETE FROM THANHVIEN WHERE MATK = :p",
                        "DELETE FROM NGUOIDUNG WHERE MATK = :p",
                        "UPDATE CUOCTROCHUYEN SET NGUOIQL = NULL WHERE NGUOIQL = :p",
                        "DELETE FROM TAIKHOAN WHERE MATK = :p"
                    };

                    foreach (var sql in deleteCommands)
                    {
                        try
                        {
                            using var cmd = _dbContext.Connection.CreateCommand();
                            cmd.CommandText = sql;
                            cmd.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter("p", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2) { Value = matk });
                            await cmd.ExecuteNonQueryAsync();
                        }
                        catch (Exception tableEx)
                        {
                            System.Diagnostics.Debug.WriteLine($"[DeleteUser] Error: {tableEx.Message}");
                        }
                    }

                    await _dbContext.WriteAuditLogAsync(_adminUsername, "ADMIN_DELETE_USER", $"Deleted: {username} (MATK: {matk})", 0);
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadUsersAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task BanUserAsync()
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một user để cấm.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var username = dgvUsers.SelectedRows[0].Cells["Username"].Value?.ToString();
            if (string.IsNullOrEmpty(username))
                return;

            try
            {
                await _dbContext.BanUserGlobalAsync(username);
                await _dbContext.WriteAuditLogAsync(_adminUsername, "ADMIN_BAN_USER", username, 0);
                MessageBox.Show("User banned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadUsersAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task UnbanUserAsync()
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một user để bỏ cấm.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var username = dgvUsers.SelectedRows[0].Cells["Username"].Value?.ToString();
            if (string.IsNullOrEmpty(username))
                return;

            try
            {
                await _dbContext.UnbanUserGlobalAsync(username);
                await _dbContext.WriteAuditLogAsync(_adminUsername, "ADMIN_UNBAN_USER", username, 0);
                MessageBox.Show("User unbanned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadUsersAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task UnlockAccountAsync()
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một user để mở khóa.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var matk = dgvUsers.SelectedRows[0].Cells["Matk"].Value?.ToString();
            var username = dgvUsers.SelectedRows[0].Cells["Username"].Value?.ToString();
            if (string.IsNullOrEmpty(matk))
                return;

            try
            {
                await _dbContext.UnlockAccountAsync(matk);
                await _dbContext.WriteAuditLogAsync(_adminUsername, "ADMIN_UNLOCK_ACCOUNT", username ?? matk, 0);
                MessageBox.Show($"Đã mở khóa tài khoản {username}.\nUser có thể đăng nhập lại.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadUsersAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================
        // 2. CONVERSATIONS MANAGEMENT
        // ============================================
        private async Task LoadConversationsAsync()
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(async () => await LoadConversationsAsync()));
                    return;
                }

                btnRefreshConversations.Enabled = false;

                var conversations = await _dbContext.GetAllConversationsAsync();

                dgvConversations.DataSource = conversations.Select(c => new
                {
                    c.Mactc,
                    c.Tenctc,
                    c.Maloaictc,
                    IsPrivate = c.IsPrivate ? "Có" : "Không",
                    c.Nguoiql,
                    MinClearance = $"Mức {c.MinClearance}",
                    c.MemberCount,
                    c.MessageCount,
                    NgayTao = c.NgayTao.ToString("dd/MM/yyyy HH:mm")
                }).ToList();

                btnRefreshConversations.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải conversations:\n{ex.Message}\n\nStack Trace:\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRefreshConversations.Enabled = true;
            }
        }

        private async Task DeleteConversationAsync()
        {
            if (dgvConversations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một conversation để xóa.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var mactc = dgvConversations.SelectedRows[0].Cells["Mactc"].Value?.ToString();
            if (string.IsNullOrEmpty(mactc))
                return;

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa conversation này?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    await _dbContext.DeleteConversationAsync(mactc);
                    await _dbContext.WriteAuditLogAsync(_adminUsername, "ADMIN_DELETE_CONVERSATION", mactc, 0);
                    MessageBox.Show("Conversation deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadConversationsAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task LoadConversationMessagesAsync()
        {
            if (dgvConversations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một conversation để xem messages.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var mactc = dgvConversations.SelectedRows[0].Cells["Mactc"].Value?.ToString();
            if (string.IsNullOrEmpty(mactc))
                return;

            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(async () => await LoadConversationMessagesAsync()));
                    return;
                }

                btnViewMessages.Enabled = false;
                btnRefreshMessages.Enabled = false;

                var messages = await _dbContext.GetConversationMessagesAdminAsync(mactc, 100);

                dgvMessages.DataSource = messages.Select(m => new
                {
                    m.Matn,
                    m.Username,
                    Noidung = m.Noidung.Length > 100 ? m.Noidung.Substring(0, 100) + "..." : m.Noidung,
                    SecurityLabel = $"Mức {m.SecurityLabel}",
                    Ngaygui = m.Ngaygui.ToString("dd/MM/yyyy HH:mm:ss"),
                    m.Maloaitn,
                    m.Matrangthai
                }).ToList();

                btnViewMessages.Enabled = true;
                btnRefreshMessages.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải messages:\n{ex.Message}\n\nStack Trace:\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnViewMessages.Enabled = true;
                btnRefreshMessages.Enabled = true;
            }
        }

        private async Task LoadMessagesAsync()
        {
            await LoadConversationMessagesAsync();
        }

        private async Task DeleteMessageAsync()
        {
            if (dgvMessages.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một message để xóa.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var matnStr = dgvMessages.SelectedRows[0].Cells["Matn"].Value?.ToString();
            if (string.IsNullOrEmpty(matnStr) || !int.TryParse(matnStr, out var matn))
                return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa message này?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    await _dbContext.DeleteMessageAsync(matn);
                    await _dbContext.WriteAuditLogAsync(_adminUsername, "ADMIN_DELETE_MESSAGE", matn.ToString(), 0);
                    MessageBox.Show("Message deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadMessagesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ============================================
        // 3. AUDIT LOGS
        // ============================================
        private async Task LoadAuditLogsAsync()
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(async () => await LoadAuditLogsAsync()));
                    return;
                }

                btnRefreshLogs.Enabled = false;

                var logs = await Task.Run(async () =>
                {
                    try
                    {
                        return await _dbContext.GetAuditLogsAsync(100);
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"GetAuditLogsAsync error: {ex.Message}");
                        return new List<AuditLogInfo>();
                    }
                });

                if (logs != null && logs.Count > 0)
                {
                    dgvAuditLogs.DataSource = logs.Select(l => new
                    {
                        ID = l.LogId,
                        User = l.Matk ?? "N/A",
                        Action = l.Action ?? "N/A",
                        Target = l.Target ?? "N/A",
                        Level = l.SecurityLabel,
                        Time = l.Timestamp.ToString("yyyy-MM-dd HH:mm:ss")
                    }).ToList();
                }
                else
                {
                    dgvAuditLogs.DataSource = null;
                    MessageBox.Show("Không có audit log nào hoặc xảy ra lỗi khi tải.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                btnRefreshLogs.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải audit logs: {ex.Message}\n\nChi tiết: {ex.StackTrace}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRefreshLogs.Enabled = true;
            }
        }

        // ============================================
        // 4. BACKUP/RESTORE MANAGEMENT (NEW)
        // ============================================
        private async Task LoadBackupHistoryAsync()
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(async () => await LoadBackupHistoryAsync()));
                    return;
                }

                btnRefreshBackup.Enabled = false;

                var backupHistory = await Task.Run(async () =>
                {
                    using var cmd = _dbContext.Connection.CreateCommand();
                    cmd.CommandText = @"
                        SELECT 
                            BACKUP_ID,
                            BACKUP_TYPE,
                            BACKUP_FILE,
                            BACKUP_SIZE_MB,
                            TO_CHAR(BACKUP_TIME, 'DD/MM/YYYY HH24:MI:SS') AS BACKUP_TIME,
                            STATUS,
                            MESSAGE,
                            CREATED_BY
                        FROM BACKUP_HISTORY 
                        ORDER BY BACKUP_TIME DESC";

                    using var reader = await cmd.ExecuteReaderAsync();
                    var backups = new List<BackupInfo>();

                    while (await reader.ReadAsync())
                    {
                        backups.Add(new BackupInfo
                        {
                            BackupId = reader["BACKUP_ID"].ToString(),
                            BackupType = reader["BACKUP_TYPE"].ToString(),
                            BackupFile = reader["BACKUP_FILE"].ToString(),
                            BackupSize = reader["BACKUP_SIZE_MB"] != DBNull.Value ?
                                         Convert.ToDecimal(reader["BACKUP_SIZE_MB"]) : 0,
                            BackupTime = reader["BACKUP_TIME"].ToString(),
                            Status = reader["STATUS"].ToString(),
                            Message = reader["MESSAGE"].ToString(),
                            CreatedBy = reader["CREATED_BY"].ToString()
                        });
                    }
                    return backups;
                });

                dgvBackupHistory.DataSource = backupHistory;
                btnRefreshBackup.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải backup history: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRefreshBackup.Enabled = true;
            }
        }

        private async Task BackupNowAsync()
        {
            try
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn backup database?\n\n" +
                                           "Quá trình sẽ tạo bản ghi trong lịch sử backup.", "Xác nhận Backup",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    btnBackupNow.Enabled = false;

                    using var cmd = _dbContext.Connection.CreateCommand();
                    cmd.CommandText = "SP_BACKUP_DATA";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter(
                        "p_backup_type", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2)
                    { Value = "FULL" });
                    cmd.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter(
                        "p_created_by", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2)
                    { Value = _adminUsername });

                    await cmd.ExecuteNonQueryAsync();

                    MessageBox.Show("Backup completed successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    await LoadBackupHistoryAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi backup: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnBackupNow.Enabled = true;
            }
        }

        private async Task RestoreBackupAsync()
        {
            if (dgvBackupHistory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một backup để restore.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var backupIdStr = dgvBackupHistory.SelectedRows[0].Cells["BackupId"].Value?.ToString();
            var backupFile = dgvBackupHistory.SelectedRows[0].Cells["BackupFile"].Value?.ToString();

            if (string.IsNullOrEmpty(backupIdStr) || !int.TryParse(backupIdStr, out var backupId))
                return;

            var result = MessageBox.Show(
                $"Bạn có chắc chắn muốn restore từ backup?\n\n" +
                $"File: {backupFile}\n" +
                $"ID: {backupId}\n\n" +
                "LƯU Ý: Đây là thao tác mô phỏng. Trong thực tế, cần có quyền admin cao hơn để restore.",
                "Xác nhận Restore",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    btnRestoreBackup.Enabled = false;

                    using var cmd = _dbContext.Connection.CreateCommand();
                    cmd.CommandText = "SP_RESTORE_BACKUP";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter(
                        "p_backup_id", Oracle.ManagedDataAccess.Client.OracleDbType.Int32)
                    { Value = backupId });
                    cmd.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter(
                        "p_restored_by", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2)
                    { Value = _adminUsername });

                    await cmd.ExecuteNonQueryAsync();

                    MessageBox.Show("Restore completed successfully!\n\n" +
                                  "Dữ liệu đã được cập nhật trong bảng backup history.", "Thành công",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi restore: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnRestoreBackup.Enabled = true;
                }
            }
        }

        // ============================================
        // 5. TIMEOUT SETTINGS MANAGEMENT (NEW)
        // ============================================
        private async Task LoadTimeoutSettingsAsync()
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(async () => await LoadTimeoutSettingsAsync()));
                    return;
                }

                btnRefreshTimeout.Enabled = false;

                var timeoutSettings = await Task.Run(async () =>
                {
                    using var cmd = _dbContext.Connection.CreateCommand();
                    cmd.CommandText = @"
                        SELECT 
                            SETTING_ID,
                            SETTING_NAME,
                            TIMEOUT_MINUTES,
                            DESCRIPTION,
                            UPDATED_BY,
                            TO_CHAR(UPDATED_AT, 'DD/MM/YYYY HH24:MI:SS') AS LAST_UPDATED
                        FROM TIMEOUT_SETTINGS 
                        ORDER BY SETTING_ID";

                    using var reader = await cmd.ExecuteReaderAsync();
                    var settings = new List<TimeoutSetting>();

                    while (await reader.ReadAsync())
                    {
                        settings.Add(new TimeoutSetting
                        {
                            SettingId = reader["SETTING_ID"].ToString(),
                            SettingName = reader["SETTING_NAME"].ToString(),
                            TimeoutMinutes = Convert.ToInt32(reader["TIMEOUT_MINUTES"]),
                            Description = reader["DESCRIPTION"].ToString(),
                            UpdatedBy = reader["UPDATED_BY"]?.ToString() ?? "N/A",
                            LastUpdated = reader["LAST_UPDATED"].ToString()
                        });
                    }
                    return settings;
                });

                dgvTimeoutSettings.DataSource = timeoutSettings;
                btnRefreshTimeout.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải timeout settings: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRefreshTimeout.Enabled = true;
            }
        }

        private async Task UpdateTimeoutSettingsAsync()
        {
            if (dgvTimeoutSettings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một setting để cập nhật.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var settingId = dgvTimeoutSettings.SelectedRows[0].Cells["SettingId"].Value?.ToString();
            var settingName = dgvTimeoutSettings.SelectedRows[0].Cells["SettingName"].Value?.ToString();
            var currentValue = dgvTimeoutSettings.SelectedRows[0].Cells["TimeoutMinutes"].Value?.ToString();

            if (string.IsNullOrEmpty(settingId) || string.IsNullOrEmpty(currentValue))
                return;

            using var inputForm = new Form
            {
                Text = $"Cập nhật {settingName}",
                Size = new System.Drawing.Size(300, 180),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            var lblPrompt = new Label
            {
                Text = $"Nhập thời gian timeout (phút) cho {settingName}:",
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(250, 40)
            };

            var numTimeout = new NumericUpDown
            {
                Minimum = 1,
                Maximum = 1440,
                Value = Convert.ToInt32(currentValue),
                Location = new System.Drawing.Point(10, 60),
                Width = 100
            };

            var btnOk = new Button
            {
                Text = "Cập nhật",
                DialogResult = DialogResult.OK,
                Location = new System.Drawing.Point(10, 100)
            };

            var btnCancel = new Button
            {
                Text = "Hủy",
                DialogResult = DialogResult.Cancel,
                Location = new System.Drawing.Point(100, 100)
            };

            inputForm.Controls.AddRange(new Control[] { lblPrompt, numTimeout, btnOk, btnCancel });

            if (inputForm.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    btnUpdateTimeout.Enabled = false;

                    using var cmd = _dbContext.Connection.CreateCommand();
                    cmd.CommandText = "SP_UPDATE_TIMEOUT_SETTING";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter(
                        "p_setting_id", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2)
                    { Value = settingId });
                    cmd.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter(
                        "p_timeout_minutes", Oracle.ManagedDataAccess.Client.OracleDbType.Int32)
                    { Value = Convert.ToInt32(numTimeout.Value) });
                    cmd.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter(
                        "p_updated_by", Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2)
                    { Value = _adminUsername });

                    await cmd.ExecuteNonQueryAsync();

                    MessageBox.Show($"Đã cập nhật {settingName} thành {numTimeout.Value} phút", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    await LoadTimeoutSettingsAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi cập nhật: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnUpdateTimeout.Enabled = true;
                }
            }
        }

        // ============================================
        // 6. LOGIN HISTORY MANAGEMENT (NEW)
        // ============================================
        private async Task LoadLoginHistoryAsync()
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(async () => await LoadLoginHistoryAsync()));
                    return;
                }

                btnRefreshLoginHistory.Enabled = false;

                var loginHistory = await Task.Run(async () =>
                {
                    using var cmd = _dbContext.Connection.CreateCommand();
                    cmd.CommandText = @"
                SELECT 
                    TO_CHAR(al.TIMESTAMP, 'DD/MM/YYYY HH24:MI:SS') AS LOGIN_TIME,
                    COALESCE(u.TENTK, al.MATK) AS USERNAME,
                    nd.HOVATEN,
                    al.ACTION,
                    al.IP_ADDRESS,
                    al.TARGET AS DETAILS
                FROM AUDIT_LOGS al
                LEFT JOIN TAIKHOAN u ON al.MATK = u.MATK
                LEFT JOIN NGUOIDUNG nd ON u.MATK = nd.MATK
                WHERE al.ACTION LIKE '%LOGIN%'
                ORDER BY al.TIMESTAMP DESC
                FETCH FIRST 100 ROWS ONLY";

                    using var reader = await cmd.ExecuteReaderAsync();
                    var history = new List<LoginHistoryInfo>();

                    while (await reader.ReadAsync())
                    {
                        var action = reader["ACTION"].ToString();
                        var details = reader["DETAILS"].ToString();

                        // Xác định loại hành động và status
                        string actionType, status;
                        if (action.Contains("SUCCESS"))
                        {
                            actionType = "Đăng nhập thành công";
                            status = "SUCCESS";
                        }
                        else if (action.Contains("FAILED"))
                        {
                            actionType = "Đăng nhập thất bại";
                            status = "FAILED";
                        }
                        else
                        {
                            actionType = action;
                            status = "OTHER";
                        }

                        history.Add(new LoginHistoryInfo
                        {
                            LoginTime = reader["LOGIN_TIME"].ToString(),
                            Username = reader["USERNAME"].ToString(),
                            FullName = reader["HOVATEN"]?.ToString() ?? "N/A",
                            ActionType = actionType,
                            IpAddress = reader["IP_ADDRESS"]?.ToString() ?? "N/A",
                            Status = status,
                            Details = details
                        });
                    }
                    return history;
                });

                dgvLoginHistory.DataSource = loginHistory;
                btnRefreshLoginHistory.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải login history: {ex.Message}\n\nChi tiết: {ex.StackTrace}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRefreshLoginHistory.Enabled = true;
            }
        }
        //private async Task LoadLoginHistoryAsync()
        //{
        //    try
        //    {
        //        if (InvokeRequired)
        //        {
        //            Invoke(new Action(async () => await LoadLoginHistoryAsync()));
        //            return;
        //        }

        //        btnRefreshLoginHistory.Enabled = false;

        //        var loginHistory = await Task.Run(async () =>
        //        {
        //            using var cmd = _dbContext.Connection.CreateCommand();
        //            cmd.CommandText = @"
        //                SELECT 
        //                    LOGIN_TIME,
        //                    USERNAME,
        //                    HOVATEN,
        //                    ACTION_TYPE,
        //                    IP_ADDRESS,
        //                    STATUS,
        //                    DETAILS
        //                FROM V_LOGIN_HISTORY
        //                ORDER BY RAW_TIMESTAMP DESC
        //                FETCH FIRST 500 ROWS ONLY";

        //            using var reader = await cmd.ExecuteReaderAsync();
        //            var history = new List<LoginHistoryInfo>();

        //            while (await reader.ReadAsync())
        //            {
        //                history.Add(new LoginHistoryInfo
        //                {
        //                    LoginTime = reader["LOGIN_TIME"].ToString(),
        //                    Username = reader["USERNAME"].ToString(),
        //                    FullName = reader["HOVATEN"]?.ToString() ?? "N/A",
        //                    ActionType = reader["ACTION_TYPE"].ToString(),
        //                    IpAddress = reader["IP_ADDRESS"]?.ToString() ?? "N/A",
        //                    Status = reader["STATUS"].ToString(),
        //                    Details = reader["DETAILS"]?.ToString() ?? string.Empty
        //                });
        //            }
        //            return history;
        //        });

        //        dgvLoginHistory.DataSource = loginHistory;
        //        btnRefreshLoginHistory.Enabled = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi tải login history: {ex.Message}", "Lỗi",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        btnRefreshLoginHistory.Enabled = true;
        //    }
        //}

        private async Task ExportLoginHistoryAsync()
        {
            try
            {
                using var saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx|CSV Files|*.csv|All Files|*.*",
                    FileName = $"LoginHistory_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx",
                    Title = "Export Login History"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    btnExportLoginHistory.Enabled = false;

                    // Lấy dữ liệu từ grid
                    var data = dgvLoginHistory.DataSource as List<LoginHistoryInfo>;

                    if (data == null || data.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để export", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Cấu hình EPPlus License
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;


                    using var excelPackage = new ExcelPackage();
                    var worksheet = excelPackage.Workbook.Worksheets.Add("LoginHistory");

                    // Header
                    worksheet.Cells[1, 1].Value = "Thời gian";
                    worksheet.Cells[1, 2].Value = "Username";
                    worksheet.Cells[1, 3].Value = "Họ tên";
                    worksheet.Cells[1, 4].Value = "Loại hành động";
                    worksheet.Cells[1, 5].Value = "IP Address";
                    worksheet.Cells[1, 6].Value = "Trạng thái";
                    worksheet.Cells[1, 7].Value = "Chi tiết";

                    // Data
                    for (int i = 0; i < data.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = data[i].LoginTime;
                        worksheet.Cells[i + 2, 2].Value = data[i].Username;
                        worksheet.Cells[i + 2, 3].Value = data[i].FullName;
                        worksheet.Cells[i + 2, 4].Value = data[i].ActionType;
                        worksheet.Cells[i + 2, 5].Value = data[i].IpAddress;
                        worksheet.Cells[i + 2, 6].Value = data[i].Status;
                        worksheet.Cells[i + 2, 7].Value = data[i].Details;
                    }

                    // Formatting
                    using (var range = worksheet.Cells[1, 1, 1, 7])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
                        range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    }

                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    // Save file
                    excelPackage.SaveAs(new FileInfo(saveFileDialog.FileName));

                    MessageBox.Show($"Đã export {data.Count} bản ghi thành công!\nFile: {saveFileDialog.FileName}",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi export: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnExportLoginHistory.Enabled = true;
            }
        }

        // ============================================
        // MODEL CLASSES FOR NEW TABS
        // ============================================
        private class BackupInfo
        {
            public string BackupId { get; set; }
            public string BackupType { get; set; }
            public string BackupFile { get; set; }
            public decimal BackupSize { get; set; }
            public string BackupTime { get; set; }
            public string Status { get; set; }
            public string Message { get; set; }
            public string CreatedBy { get; set; }
        }

        private class TimeoutSetting
        {
            public string SettingId { get; set; }
            public string SettingName { get; set; }
            public int TimeoutMinutes { get; set; }
            public string Description { get; set; }
            public string UpdatedBy { get; set; }
            public string LastUpdated { get; set; }
        }

        private class LoginHistoryInfo
        {
            public string LoginTime { get; set; }
            public string Username { get; set; }
            public string FullName { get; set; }
            public string ActionType { get; set; }
            public string IpAddress { get; set; }
            public string Status { get; set; }
            public string Details { get; set; }
        }
    }
}