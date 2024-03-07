using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static multipep.MainFrame;

namespace multipep
{

    public partial class MainFrame : Form
    {
        [DllImport("user32.dll")]
        public static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private List<Account> accounts = new List<Account>();
        private BindingList<Account> accountsBindingList;
        private static string Section = "Settings";
        private DataGridViewTextBoxColumn loginColumn = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn passwordColumn = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn noteColumn = new DataGridViewTextBoxColumn();
        private DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
        private DataGridViewTextBoxColumn WoWColumn = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn ApepColumn = new DataGridViewTextBoxColumn();
        private RunAsLibrary.Api Api = new RunAsLibrary.Api();
        private ToolTip toolTip1 = new ToolTip();
        public MainFrame()
        {
            InitializeComponent();
            setup_all();
            setup_tooltip();
        }

        private void setup_tooltip()
        {
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.SymLinkByPass_c, "For those who have problems\nWith Symbolic Link's writing permissions.");
            toolTip1.SetToolTip(this.MoP_AltInjection_c, "Alernative method of injection, only for MoP.");
            toolTip1.SetToolTip(this.wotlk_WardenLog_c, "Who that pokemon?");
            toolTip1.SetToolTip(this.novoice_c, "No apep sound?");
            toolTip1.SetToolTip(this.siticoneCircleButton1, "Select path to Wow.exe");
            toolTip1.SetToolTip(this.SelectApep, "Select path to Apep.exe");
            toolTip1.SetToolTip(this.no_crc_c, "Disables CRC check.");

        }

        private void setup_all()
        {
            RemoveAccount.Enabled = false;
            DataTable.AllowUserToAddRows = false;
            DataTable.AllowUserToResizeRows = false;
            DataTable.AllowUserToResizeColumns = false;

            checkboxColumn.HeaderText = "Selected";
            checkboxColumn.Name = "Selected";
            checkboxColumn.Width = 40;
            DataTable.Columns.Add(checkboxColumn);

            loginColumn.HeaderText = "Login";
            loginColumn.Name = "Login";
            loginColumn.ReadOnly = true;
            loginColumn.Width = 100;
            DataTable.Columns.Add(loginColumn);

            DataTable.RowHeadersVisible = false;
            DataTable.ColumnHeadersVisible = false;
            DataTable.BorderStyle = BorderStyle.FixedSingle;
            DataTable.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DataTable.GridColor = Color.FromArgb(220, 220, 198);

            passwordColumn.HeaderText = "Password";
            passwordColumn.Name = "Password";
            passwordColumn.ReadOnly = true;
            passwordColumn.Width = 100;
            DataTable.Columns.Add(passwordColumn);

            WoWColumn.HeaderText = "WoW";
            WoWColumn.Name = "WoW";
            WoWColumn.ReadOnly = true;
            WoWColumn.Width = 140;
            DataTable.Columns.Add(WoWColumn);

            ApepColumn.HeaderText = "Apep";
            ApepColumn.Name = "Apep";
            ApepColumn.ReadOnly = true;
            ApepColumn.Width = 140;
            DataTable.Columns.Add(ApepColumn);

            noteColumn.HeaderText = "Note";
            noteColumn.Name = "Note";
            noteColumn.ReadOnly = true;
            noteColumn.Width = 143;
            DataTable.Columns.Add(noteColumn);

            accountsBindingList = new BindingList<Account>(accounts);
            DataTable.DataSource = accountsBindingList;
        }

        private void LoadAccounts()
        {
            try
            {
                string json = File.ReadAllText("accounts.json");
                accounts = JsonConvert.DeserializeObject<List<Account>>(json);
            }
            catch (FileNotFoundException)
            {
                SaveAccounts();
            }
        }

        private void SaveAccounts()
        {
            string json = JsonConvert.SerializeObject(accounts);
            File.WriteAllText("accounts.json", json);
        }

        private void RefreshTable()
        {
            DataTable.DataSource = null;
            DataTable.Rows.Clear();
            foreach (Account account in accounts)
            {
                if (ShowPwd.Checked)
                {
                    DataTable.Rows.Add(account.Selected, account.Login, account.Password, account.WoW, account.Apep, account.Note);
                }
                else
                {
                    DataTable.Rows.Add(account.Selected, account.Login, "********", "WoW", "Apep", account.Note);
                }
            }
        }

        private void RemoveSelectedAccount()
        {
            bool anySelected = false;
            foreach (DataGridViewRow row in DataTable.Rows)
            {
                if (row.Cells["Selected"].Value != null && (bool)row.Cells["Selected"].Value)
                {
                    anySelected = true;
                    break;
                }
            }

            if (!anySelected)
            {
                MessageBox.Show("No accounts selected to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete checked accounts?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                List<int> rowsToRemove = new List<int>();

                for (int i = 0; i < DataTable.Rows.Count; i++)
                {
                    if (DataTable.Rows[i].Cells["Selected"].Value != null &&
                        (bool)DataTable.Rows[i].Cells["Selected"].Value)
                    {
                        rowsToRemove.Add(i);
                    }
                }

                foreach (int rowIndex in rowsToRemove.OrderByDescending(x => x))
                {
                    DataTable.Rows.RemoveAt(rowIndex);
                    accounts.RemoveAt(rowIndex);
                }

                SaveAccounts();
            }
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            RefreshTable();
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            accounts.Add(new Account
            {
                Login = textBox1.Text,
                Password = textBox2.Text,
                Note = textBox3.Text,
                WoW = textBox4.Text,
                Apep = textBox5.Text
            });
            SaveAccounts();
            RefreshTable();
        }

        private void RemoveAccount_Click(object sender, EventArgs e)
        {
            RemoveSelectedAccount();
        }

        private async Task LaunchTargetAppAsync(string GamePath, string Apep, string accountName, string accountPassword)
        {

            using (Process apepProcess = new Process())
            {


                if (string.IsNullOrEmpty(Apep) || string.IsNullOrEmpty(accountName) || string.IsNullOrEmpty(accountPassword) || string.IsNullOrEmpty(GamePath))
                {
                    string errorMessage = string.Empty;
                    if (string.IsNullOrEmpty(Apep))
                    {
                        errorMessage = "Apep Path";
                    }
                    if (string.IsNullOrEmpty(GamePath))
                    {
                        errorMessage = "Game Path";
                    }
                    if (string.IsNullOrEmpty(accountName))
                    {
                        errorMessage = "Login";
                    }
                    if (string.IsNullOrEmpty(accountPassword))
                    {
                        errorMessage += string.IsNullOrEmpty(errorMessage) ? "Password" : " and Password";
                    }
                    MessageBox.Show($"{errorMessage} not set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                apepProcess.StartInfo.FileName = Apep.Replace("/", "\\");

                string formattedGamePath = GamePath.Replace("/", "\\");

                string arguments = $"-exec=\"{formattedGamePath}\"";

                // Add additional arguments based on checkbox states
                if (MoP_AltInjection_c.Checked)
                {
                    arguments += " -mopAltInjection";
                }

                if (wotlk_WardenLog_c.Checked)
                {
                    arguments += " -wardenLog";
                }

                if (SymLinkByPass_c.Checked)
                {
                    arguments += " -noSymLink";
                }

                if (novoice_c.Checked)
                {
                    arguments += " -noVoice";
                }

                if (no_crc_c.Checked)
                {
                    arguments += " -noCrc";
                }

                arguments += $" -user=\"{accountName}\"";
                arguments += $" -pwd=\"{accountPassword}\"";
             //   await Console.Out.WriteLineAsync(arguments);
                apepProcess.StartInfo.Arguments = arguments;
                apepProcess.Start();

                await Task.Run(() => apepProcess.WaitForExit());
            }
        }

        private async Task StartAllAsync()
        {
            foreach (DataGridViewRow row in DataTable.Rows)
            {
                if (row.Cells["Selected"].Value is bool selected && selected)
                {
                    string accountName = row.Cells["Login"].Value.ToString();
                    // string wow = row.Cells["WoW"].Value.ToString();
                    string apep = row.Cells["Apep"].Value.ToString();
                    string accountPassword = ShowPwd.Checked ? row.Cells["Password"].Value.ToString() : GetAccountPassword(accountName);
                    string wow = ShowPwd.Checked ? row.Cells["WoW"].Value.ToString() : GetAccountWoW(accountName);

                    try
                    {
                        await LaunchTargetAppAsync(wow, apep, accountName, accountPassword);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void StartAll_Click(object sender, EventArgs e)
        {
            await StartAllAsync();
        }

        private string GetAccountPassword(string login)
        {
            Account account = accounts.FirstOrDefault(acc => acc.Login == login);
            return account != null ? account.Password : string.Empty;
        }
        private string GetAccountWoW(string login)
        {
            Account account = accounts.FirstOrDefault(acc => acc.Login == login);
            return account != null ? account.WoW : string.Empty;
        }

        private void ShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPwd.Checked)
            {
                loginColumn.ReadOnly = false;
                passwordColumn.ReadOnly = false;
                noteColumn.ReadOnly = false;
                WoWColumn.ReadOnly = false;
                ApepColumn.ReadOnly = false;
                RemoveAccount.Enabled = true;
            }
            else
            {
                loginColumn.ReadOnly = true;
                passwordColumn.ReadOnly = true;
                noteColumn.ReadOnly = true;
                WoWColumn.ReadOnly = true;
                RemoveAccount.Enabled = false;
            }

            RefreshTable();
        }

        private void DataTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = DataTable.Rows[e.RowIndex];
                string login = row.Cells["Login"].Value != null ? row.Cells["Login"].Value.ToString() : "";
                string password = row.Cells["Password"].Value != null ? row.Cells["Password"].Value.ToString() : "";
                string note = row.Cells["Note"].Value != null ? row.Cells["Note"].Value.ToString() : "";
                string WoW = row.Cells["WoW"].Value != null ? row.Cells["WoW"].Value.ToString() : "";
                string Apep = row.Cells["Apep"].Value != null ? row.Cells["Apep"].Value.ToString() : "";
                bool selected = row.Cells["Selected"].Value != null ? (bool)row.Cells["Selected"].Value : false;

                Account account = accounts[e.RowIndex];
                if (ShowPwd.Checked)
                {
                    account.Login = login;
                    account.Password = password;
                    account.WoW = WoW;
                    account.Apep = Apep;
                    account.Note = note;
                }
                account.Selected = selected;

                SaveAccounts();
            }
            RefreshTable();
        }

        private void MainFrame_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Call the Windows API functions to allow window movement
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectWoW_Click(object sender, EventArgs e)
        {
            var path = Api.Get_FolderPath();
            var path_exe = Api.Get_Exe();
            textBox4.Text = $"{path}/{path_exe}";
        }

        private void SelectApep_Click(object sender, EventArgs e)
        {
            var path = Api.Get_FolderPath();
            var path_exe = Api.Get_Exe();
            textBox5.Text = $"{path}/{path_exe}";
        }

    }

    public class Account
    {
        public bool Selected { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string WoW { get; set; }
        public string Apep { get; set; }
        public string Note { get; set; }
    }

}