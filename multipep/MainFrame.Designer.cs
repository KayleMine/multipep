namespace multipep
{
    partial class MainFrame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.StartAll = new System.Windows.Forms.Button();
            this.AddAccount = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.RemoveAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowPwd = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.siticoneCirclePictureBox1 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.MoP_AltInjection_c = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.wotlk_WardenLog_c = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.SymLinkByPass_c = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.siticoneCircleButton1 = new Siticone.UI.WinForms.SiticoneCircleButton();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.novoice_c = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SelectApep = new Siticone.UI.WinForms.SiticoneCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // StartAll
            // 
            this.StartAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.StartAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.StartAll.Location = new System.Drawing.Point(704, 439);
            this.StartAll.Name = "StartAll";
            this.StartAll.Size = new System.Drawing.Size(82, 42);
            this.StartAll.TabIndex = 1;
            this.StartAll.Text = "Start selected";
            this.StartAll.UseVisualStyleBackColor = false;
            this.StartAll.Click += new System.EventHandler(this.StartAll_Click);
            // 
            // AddAccount
            // 
            this.AddAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.AddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.AddAccount.Location = new System.Drawing.Point(748, 145);
            this.AddAccount.Name = "AddAccount";
            this.AddAccount.Size = new System.Drawing.Size(100, 25);
            this.AddAccount.TabIndex = 2;
            this.AddAccount.Text = "Add";
            this.AddAccount.UseVisualStyleBackColor = false;
            this.AddAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.textBox1.Location = new System.Drawing.Point(748, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.textBox2.Location = new System.Drawing.Point(748, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // RemoveAccount
            // 
            this.RemoveAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.RemoveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.RemoveAccount.Location = new System.Drawing.Point(748, 173);
            this.RemoveAccount.Name = "RemoveAccount";
            this.RemoveAccount.Size = new System.Drawing.Size(100, 25);
            this.RemoveAccount.TabIndex = 5;
            this.RemoveAccount.Text = "Remove selected";
            this.RemoveAccount.UseVisualStyleBackColor = false;
            this.RemoveAccount.Click += new System.EventHandler(this.RemoveAccount_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.label1.Location = new System.Drawing.Point(707, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.label2.Location = new System.Drawing.Point(707, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Psswrd";
            // 
            // ShowPwd
            // 
            this.ShowPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowPwd.Appearance = System.Windows.Forms.Appearance.Button;
            this.ShowPwd.AutoSize = true;
            this.ShowPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.ShowPwd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.ShowPwd.Location = new System.Drawing.Point(763, 204);
            this.ShowPwd.Name = "ShowPwd";
            this.ShowPwd.Size = new System.Drawing.Size(70, 23);
            this.ShowPwd.TabIndex = 8;
            this.ShowPwd.Text = "Enable edit";
            this.ShowPwd.UseVisualStyleBackColor = false;
            this.ShowPwd.CheckedChanged += new System.EventHandler(this.ShowPwd_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.label3.Location = new System.Drawing.Point(707, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Note";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.textBox3.Location = new System.Drawing.Point(748, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.Exit.Location = new System.Drawing.Point(792, 439);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(82, 42);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.siticoneCirclePictureBox1.Image = global::Seth.Properties.Resources.seth_copy;
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(12, 435);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.ShadowDecoration.Parent = this.siticoneCirclePictureBox1;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(58, 46);
            this.siticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticoneCirclePictureBox1.TabIndex = 12;
            this.siticoneCirclePictureBox1.TabStop = false;
            // 
            // MoP_AltInjection_c
            // 
            this.MoP_AltInjection_c.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MoP_AltInjection_c.AutoSize = true;
            this.MoP_AltInjection_c.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MoP_AltInjection_c.CheckedState.BorderRadius = 2;
            this.MoP_AltInjection_c.CheckedState.BorderThickness = 0;
            this.MoP_AltInjection_c.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MoP_AltInjection_c.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.MoP_AltInjection_c.Location = new System.Drawing.Point(76, 435);
            this.MoP_AltInjection_c.Name = "MoP_AltInjection_c";
            this.MoP_AltInjection_c.Size = new System.Drawing.Size(102, 17);
            this.MoP_AltInjection_c.TabIndex = 16;
            this.MoP_AltInjection_c.Text = "5.4  Alt-Injection";
            this.MoP_AltInjection_c.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MoP_AltInjection_c.UncheckedState.BorderRadius = 2;
            this.MoP_AltInjection_c.UncheckedState.BorderThickness = 0;
            this.MoP_AltInjection_c.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MoP_AltInjection_c.UseVisualStyleBackColor = true;
            // 
            // wotlk_WardenLog_c
            // 
            this.wotlk_WardenLog_c.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.wotlk_WardenLog_c.AutoSize = true;
            this.wotlk_WardenLog_c.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.wotlk_WardenLog_c.CheckedState.BorderRadius = 2;
            this.wotlk_WardenLog_c.CheckedState.BorderThickness = 0;
            this.wotlk_WardenLog_c.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.wotlk_WardenLog_c.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.wotlk_WardenLog_c.Location = new System.Drawing.Point(76, 458);
            this.wotlk_WardenLog_c.Name = "wotlk_WardenLog_c";
            this.wotlk_WardenLog_c.Size = new System.Drawing.Size(109, 17);
            this.wotlk_WardenLog_c.TabIndex = 17;
            this.wotlk_WardenLog_c.Text = "3.3.5 WardenLog";
            this.wotlk_WardenLog_c.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.wotlk_WardenLog_c.UncheckedState.BorderRadius = 2;
            this.wotlk_WardenLog_c.UncheckedState.BorderThickness = 0;
            this.wotlk_WardenLog_c.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.wotlk_WardenLog_c.UseVisualStyleBackColor = true;
            // 
            // SymLinkByPass_c
            // 
            this.SymLinkByPass_c.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SymLinkByPass_c.AutoSize = true;
            this.SymLinkByPass_c.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SymLinkByPass_c.CheckedState.BorderRadius = 2;
            this.SymLinkByPass_c.CheckedState.BorderThickness = 0;
            this.SymLinkByPass_c.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SymLinkByPass_c.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.SymLinkByPass_c.Location = new System.Drawing.Point(184, 435);
            this.SymLinkByPass_c.Name = "SymLinkByPass_c";
            this.SymLinkByPass_c.Size = new System.Drawing.Size(103, 17);
            this.SymLinkByPass_c.TabIndex = 18;
            this.SymLinkByPass_c.Text = "SymLink-Bypass";
            this.SymLinkByPass_c.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SymLinkByPass_c.UncheckedState.BorderRadius = 2;
            this.SymLinkByPass_c.UncheckedState.BorderThickness = 0;
            this.SymLinkByPass_c.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SymLinkByPass_c.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.label4.Location = new System.Drawing.Point(707, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "WoW";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.textBox4.Location = new System.Drawing.Point(748, 67);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 19;
            // 
            // siticoneCircleButton1
            // 
            this.siticoneCircleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneCircleButton1.BorderColor = System.Drawing.Color.BurlyWood;
            this.siticoneCircleButton1.BorderRadius = 1;
            this.siticoneCircleButton1.BorderThickness = 1;
            this.siticoneCircleButton1.CheckedState.Parent = this.siticoneCircleButton1;
            this.siticoneCircleButton1.CustomImages.Parent = this.siticoneCircleButton1;
            this.siticoneCircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.siticoneCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneCircleButton1.ForeColor = System.Drawing.SystemColors.Window;
            this.siticoneCircleButton1.HoveredState.Parent = this.siticoneCircleButton1;
            this.siticoneCircleButton1.Location = new System.Drawing.Point(854, 67);
            this.siticoneCircleButton1.Name = "siticoneCircleButton1";
            this.siticoneCircleButton1.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCircleButton1.ShadowDecoration.Parent = this.siticoneCircleButton1;
            this.siticoneCircleButton1.Size = new System.Drawing.Size(20, 20);
            this.siticoneCircleButton1.TabIndex = 21;
            this.siticoneCircleButton1.Text = "S";
            this.siticoneCircleButton1.Click += new System.EventHandler(this.SelectWoW_Click);
            // 
            // DataTable
            // 
            this.DataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataTable.Location = new System.Drawing.Point(12, 12);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataTable.Size = new System.Drawing.Size(689, 417);
            this.DataTable.TabIndex = 22;
            this.DataTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTable_CellValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.label5.Location = new System.Drawing.Point(181, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "  * All of this apply to all start sequence.";
            // 
            // novoice_c
            // 
            this.novoice_c.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.novoice_c.AutoSize = true;
            this.novoice_c.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.novoice_c.CheckedState.BorderRadius = 2;
            this.novoice_c.CheckedState.BorderThickness = 0;
            this.novoice_c.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.novoice_c.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.novoice_c.Location = new System.Drawing.Point(293, 435);
            this.novoice_c.Name = "novoice_c";
            this.novoice_c.Size = new System.Drawing.Size(70, 17);
            this.novoice_c.TabIndex = 24;
            this.novoice_c.Text = "No Voice";
            this.novoice_c.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.novoice_c.UncheckedState.BorderRadius = 2;
            this.novoice_c.UncheckedState.BorderThickness = 0;
            this.novoice_c.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.novoice_c.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.label6.Location = new System.Drawing.Point(707, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Apep";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.textBox5.Location = new System.Drawing.Point(748, 93);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 25;
            // 
            // SelectApep
            // 
            this.SelectApep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectApep.BorderColor = System.Drawing.Color.BurlyWood;
            this.SelectApep.BorderRadius = 1;
            this.SelectApep.BorderThickness = 1;
            this.SelectApep.CheckedState.Parent = this.SelectApep;
            this.SelectApep.CustomImages.Parent = this.SelectApep;
            this.SelectApep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.SelectApep.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectApep.ForeColor = System.Drawing.SystemColors.Window;
            this.SelectApep.HoveredState.Parent = this.SelectApep;
            this.SelectApep.Location = new System.Drawing.Point(854, 93);
            this.SelectApep.Name = "SelectApep";
            this.SelectApep.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.SelectApep.ShadowDecoration.Parent = this.SelectApep;
            this.SelectApep.Size = new System.Drawing.Size(20, 20);
            this.SelectApep.TabIndex = 27;
            this.SelectApep.Text = "S";
            this.SelectApep.Click += new System.EventHandler(this.SelectApep_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(886, 493);
            this.Controls.Add(this.SelectApep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.novoice_c);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.siticoneCircleButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.SymLinkByPass_c);
            this.Controls.Add(this.wotlk_WardenLog_c);
            this.Controls.Add(this.MoP_AltInjection_c);
            this.Controls.Add(this.siticoneCirclePictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ShowPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveAccount);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddAccount);
            this.Controls.Add(this.StartAll);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.Text = "Multi-Seth";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFrame_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartAll;
        private System.Windows.Forms.Button AddAccount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button RemoveAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ShowPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Exit;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private Siticone.UI.WinForms.SiticoneCheckBox MoP_AltInjection_c;
        private Siticone.UI.WinForms.SiticoneCheckBox wotlk_WardenLog_c;
        private Siticone.UI.WinForms.SiticoneCheckBox SymLinkByPass_c;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private Siticone.UI.WinForms.SiticoneCircleButton siticoneCircleButton1;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Label label5;
        private Siticone.UI.WinForms.SiticoneCheckBox novoice_c;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private Siticone.UI.WinForms.SiticoneCircleButton SelectApep;
    }
}

