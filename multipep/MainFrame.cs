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
        private InIReader MyIni = new InIReader("Apep.ini");
        private static string Section = "Settings";
        private DataGridViewTextBoxColumn loginColumn = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn passwordColumn = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn noteColumn = new DataGridViewTextBoxColumn();
        public MainFrame()
        {
            InitializeComponent();
            RemoveAccount.Enabled = false;
            dataGridView1.AllowUserToAddRows = false;
            // this.FormBorderStyle = FormBorderStyle.FixedSingle;
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.HeaderText = "Selected";
            checkboxColumn.Name = "Selected";
            checkboxColumn.Width = 15;
            dataGridView1.Columns.Add(checkboxColumn);

            loginColumn.HeaderText = "Login";
            loginColumn.Name = "Login";
            loginColumn.ReadOnly = true;
            dataGridView1.Columns.Add(loginColumn);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.FromArgb(220, 220, 198);

            passwordColumn.HeaderText = "Password";
            passwordColumn.Name = "Password";
            passwordColumn.ReadOnly = true;
            dataGridView1.Columns.Add(passwordColumn);

            noteColumn.HeaderText = "Note";
            noteColumn.Name = "Note";
            noteColumn.ReadOnly = true;
            dataGridView1.Columns.Add(noteColumn);

            accountsBindingList = new BindingList<Account>(accounts);
            dataGridView1.DataSource = accountsBindingList;

        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            RefreshTable();
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
        private void RemoveSelectedAccount()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string login = row.Cells["Login"].Value.ToString();
                string password = row.Cells["Password"].Value.ToString();

                Account accountToRemove = accounts.FirstOrDefault(acc => acc.Login == login && acc.Password == password);

                if (accountToRemove != null)
                {
                    accounts.Remove(accountToRemove);
                }
            }

            SaveAccounts();
            RefreshTable();
            accountsBindingList.ResetBindings();
        }

        private void RefreshTable()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            foreach (Account account in accounts)
            {
                if (ShowPwd.Checked)
                {
                    dataGridView1.Rows.Add(account.Selected, account.Login, account.Password, account.Note);
                }
                else
                {
                    dataGridView1.Rows.Add(account.Selected, account.Login, "********", account.Note);
                }
            }
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            accounts.Add(new Account { Login = textBox1.Text, Password = textBox2.Text , Note = textBox3.Text });
            SaveAccounts();
            RefreshTable();
        }
        private void RemoveAccount_Click(object sender, EventArgs e)
        {
            RemoveSelectedAccount();
        }
        private void LaunchTargetApp(string login, string password)
        {
            MyIni.Write("AccountName", login, Section);
            MyIni.Write("AccountPassword", password, Section);

            Process apepProcess = new Process();
            apepProcess.StartInfo.FileName = "apep.exe";
            apepProcess.Start();

            apepProcess.WaitForExit();
        }
        private void StartAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells["Selected"] as DataGridViewCheckBoxCell;
                if (chk.Value != null && (bool)chk.Value)
                {
                    string login = row.Cells["Login"].Value.ToString();
                    string password = ShowPwd.Checked ? row.Cells["Password"].Value.ToString() : GetAccountPassword(login);
                    LaunchTargetApp(login, password);
                }
            }
        }
        private string GetAccountPassword(string login)
        {
            Account account = accounts.FirstOrDefault(acc => acc.Login == login);
            return account != null ? account.Password : string.Empty;
        }

        private void ShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPwd.Checked)
            {
                loginColumn.ReadOnly = false;
                passwordColumn.ReadOnly = false;
                noteColumn.ReadOnly = false;
                RemoveAccount.Enabled = true;
            }
            else
            {
                loginColumn.ReadOnly = true;
                passwordColumn.ReadOnly = true;
                noteColumn.ReadOnly = true;
                RemoveAccount.Enabled = false;
            }

            RefreshTable();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string login = row.Cells["Login"].Value.ToString();
                string password = row.Cells["Password"].Value.ToString();
                string note = row.Cells["Note"].Value.ToString();
                bool selected = (bool)row.Cells["Selected"].Value;

                Account account = accounts[e.RowIndex];
                if (ShowPwd.Checked) { 
                account.Login = login;
                account.Password = password;
                account.Note = note;
                }
                account.Selected = selected;

                SaveAccounts();
            }
            RefreshTable();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }



    public class Account
    {
        public bool Selected { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Note { get; set; }
    }

}
