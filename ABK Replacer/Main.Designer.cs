namespace ABK_Replacer
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.abkPanel = new System.Windows.Forms.Panel();
            this.abkOpen = new MetroFramework.Controls.MetroButton();
            this.abkLocTXT = new MetroFramework.Controls.MetroTextBox();
            this.abkLabel = new MetroFramework.Controls.MetroLabel();
            this.audioPanel = new System.Windows.Forms.Panel();
            this.aud8Check = new MetroFramework.Controls.MetroCheckBox();
            this.aud7Check = new MetroFramework.Controls.MetroCheckBox();
            this.aud6Check = new MetroFramework.Controls.MetroCheckBox();
            this.aud5Check = new MetroFramework.Controls.MetroCheckBox();
            this.aud4Check = new MetroFramework.Controls.MetroCheckBox();
            this.aud3Check = new MetroFramework.Controls.MetroCheckBox();
            this.aud2Check = new MetroFramework.Controls.MetroCheckBox();
            this.aud1Check = new MetroFramework.Controls.MetroCheckBox();
            this.aud5Panel = new System.Windows.Forms.Panel();
            this.aud5Open = new MetroFramework.Controls.MetroButton();
            this.aud5TXT = new MetroFramework.Controls.MetroTextBox();
            this.aud8Panel = new System.Windows.Forms.Panel();
            this.aud8Open = new MetroFramework.Controls.MetroButton();
            this.aud8TXT = new MetroFramework.Controls.MetroTextBox();
            this.aud7Panel = new System.Windows.Forms.Panel();
            this.aud7Open = new MetroFramework.Controls.MetroButton();
            this.aud7TXT = new MetroFramework.Controls.MetroTextBox();
            this.aud6Panel = new System.Windows.Forms.Panel();
            this.aud6Open = new MetroFramework.Controls.MetroButton();
            this.aud6TXT = new MetroFramework.Controls.MetroTextBox();
            this.aud4Panel = new System.Windows.Forms.Panel();
            this.aud4Open = new MetroFramework.Controls.MetroButton();
            this.aud4TXT = new MetroFramework.Controls.MetroTextBox();
            this.aud3Panel = new System.Windows.Forms.Panel();
            this.aud3Open = new MetroFramework.Controls.MetroButton();
            this.aud3TXT = new MetroFramework.Controls.MetroTextBox();
            this.aud2Panel = new System.Windows.Forms.Panel();
            this.aud2Open = new MetroFramework.Controls.MetroButton();
            this.aud2TXT = new MetroFramework.Controls.MetroTextBox();
            this.aud1Panel = new System.Windows.Forms.Panel();
            this.aud1Open = new MetroFramework.Controls.MetroButton();
            this.aud1TXT = new MetroFramework.Controls.MetroTextBox();
            this.audHeader = new MetroFramework.Controls.MetroLabel();
            this.abkSelected = new System.Windows.Forms.Timer(this.components);
            this.startButton = new MetroFramework.Controls.MetroButton();
            this.buttonTimer = new System.Windows.Forms.Timer(this.components);
            this.abkPanel.SuspendLayout();
            this.audioPanel.SuspendLayout();
            this.aud5Panel.SuspendLayout();
            this.aud8Panel.SuspendLayout();
            this.aud7Panel.SuspendLayout();
            this.aud6Panel.SuspendLayout();
            this.aud4Panel.SuspendLayout();
            this.aud3Panel.SuspendLayout();
            this.aud2Panel.SuspendLayout();
            this.aud1Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // abkPanel
            // 
            this.abkPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.abkPanel.Controls.Add(this.abkOpen);
            this.abkPanel.Controls.Add(this.abkLocTXT);
            this.abkPanel.Controls.Add(this.abkLabel);
            this.abkPanel.Location = new System.Drawing.Point(23, 96);
            this.abkPanel.Name = "abkPanel";
            this.abkPanel.Size = new System.Drawing.Size(557, 50);
            this.abkPanel.TabIndex = 0;
            // 
            // abkOpen
            // 
            this.abkOpen.Location = new System.Drawing.Point(475, 13);
            this.abkOpen.Name = "abkOpen";
            this.abkOpen.Size = new System.Drawing.Size(75, 23);
            this.abkOpen.Style = MetroFramework.MetroColorStyle.Red;
            this.abkOpen.TabIndex = 2;
            this.abkOpen.Text = "...";
            this.abkOpen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.abkOpen.UseSelectable = true;
            this.abkOpen.UseStyleColors = true;
            this.abkOpen.Click += new System.EventHandler(this.abkOpen_Click);
            // 
            // abkLocTXT
            // 
            // 
            // 
            // 
            this.abkLocTXT.CustomButton.Image = null;
            this.abkLocTXT.CustomButton.Location = new System.Drawing.Point(380, 1);
            this.abkLocTXT.CustomButton.Name = "";
            this.abkLocTXT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.abkLocTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.abkLocTXT.CustomButton.TabIndex = 1;
            this.abkLocTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.abkLocTXT.CustomButton.UseSelectable = true;
            this.abkLocTXT.CustomButton.Visible = false;
            this.abkLocTXT.Lines = new string[] {
        "Select From Right ->"};
            this.abkLocTXT.Location = new System.Drawing.Point(67, 13);
            this.abkLocTXT.MaxLength = 32767;
            this.abkLocTXT.Name = "abkLocTXT";
            this.abkLocTXT.PasswordChar = '\0';
            this.abkLocTXT.ReadOnly = true;
            this.abkLocTXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.abkLocTXT.SelectedText = "";
            this.abkLocTXT.SelectionLength = 0;
            this.abkLocTXT.SelectionStart = 0;
            this.abkLocTXT.ShortcutsEnabled = true;
            this.abkLocTXT.Size = new System.Drawing.Size(402, 23);
            this.abkLocTXT.Style = MetroFramework.MetroColorStyle.Red;
            this.abkLocTXT.TabIndex = 1;
            this.abkLocTXT.Text = "Select From Right ->";
            this.abkLocTXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.abkLocTXT.UseSelectable = true;
            this.abkLocTXT.UseStyleColors = true;
            this.abkLocTXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.abkLocTXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // abkLabel
            // 
            this.abkLabel.AutoSize = true;
            this.abkLabel.ForeColor = System.Drawing.Color.White;
            this.abkLabel.Location = new System.Drawing.Point(3, 14);
            this.abkLabel.Name = "abkLabel";
            this.abkLabel.Size = new System.Drawing.Size(60, 19);
            this.abkLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.abkLabel.TabIndex = 0;
            this.abkLabel.Text = "ABK File:";
            this.abkLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.abkLabel.UseCustomBackColor = true;
            this.abkLabel.UseCustomForeColor = true;
            // 
            // audioPanel
            // 
            this.audioPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.audioPanel.Controls.Add(this.aud8Check);
            this.audioPanel.Controls.Add(this.aud7Check);
            this.audioPanel.Controls.Add(this.aud6Check);
            this.audioPanel.Controls.Add(this.aud5Check);
            this.audioPanel.Controls.Add(this.aud4Check);
            this.audioPanel.Controls.Add(this.aud3Check);
            this.audioPanel.Controls.Add(this.aud2Check);
            this.audioPanel.Controls.Add(this.aud1Check);
            this.audioPanel.Controls.Add(this.aud5Panel);
            this.audioPanel.Controls.Add(this.aud8Panel);
            this.audioPanel.Controls.Add(this.aud7Panel);
            this.audioPanel.Controls.Add(this.aud6Panel);
            this.audioPanel.Controls.Add(this.aud4Panel);
            this.audioPanel.Controls.Add(this.aud3Panel);
            this.audioPanel.Controls.Add(this.aud2Panel);
            this.audioPanel.Controls.Add(this.aud1Panel);
            this.audioPanel.Controls.Add(this.audHeader);
            this.audioPanel.Enabled = false;
            this.audioPanel.Location = new System.Drawing.Point(23, 186);
            this.audioPanel.Name = "audioPanel";
            this.audioPanel.Size = new System.Drawing.Size(557, 440);
            this.audioPanel.TabIndex = 1;
            // 
            // aud8Check
            // 
            this.aud8Check.AutoSize = true;
            this.aud8Check.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.aud8Check.ForeColor = System.Drawing.Color.White;
            this.aud8Check.Location = new System.Drawing.Point(7, 403);
            this.aud8Check.Name = "aud8Check";
            this.aud8Check.Size = new System.Drawing.Size(44, 19);
            this.aud8Check.Style = MetroFramework.MetroColorStyle.Red;
            this.aud8Check.TabIndex = 15;
            this.aud8Check.Text = "08.";
            this.aud8Check.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud8Check.UseCustomBackColor = true;
            this.aud8Check.UseCustomForeColor = true;
            this.aud8Check.UseSelectable = true;
            this.aud8Check.UseStyleColors = true;
            this.aud8Check.CheckedChanged += new System.EventHandler(this.aud8Check_CheckedChanged);
            // 
            // aud7Check
            // 
            this.aud7Check.AutoSize = true;
            this.aud7Check.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.aud7Check.ForeColor = System.Drawing.Color.White;
            this.aud7Check.Location = new System.Drawing.Point(7, 352);
            this.aud7Check.Name = "aud7Check";
            this.aud7Check.Size = new System.Drawing.Size(44, 19);
            this.aud7Check.Style = MetroFramework.MetroColorStyle.Red;
            this.aud7Check.TabIndex = 14;
            this.aud7Check.Text = "07.";
            this.aud7Check.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud7Check.UseCustomBackColor = true;
            this.aud7Check.UseCustomForeColor = true;
            this.aud7Check.UseSelectable = true;
            this.aud7Check.UseStyleColors = true;
            this.aud7Check.CheckedChanged += new System.EventHandler(this.aud7Check_CheckedChanged);
            // 
            // aud6Check
            // 
            this.aud6Check.AutoSize = true;
            this.aud6Check.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.aud6Check.ForeColor = System.Drawing.Color.White;
            this.aud6Check.Location = new System.Drawing.Point(7, 301);
            this.aud6Check.Name = "aud6Check";
            this.aud6Check.Size = new System.Drawing.Size(44, 19);
            this.aud6Check.Style = MetroFramework.MetroColorStyle.Red;
            this.aud6Check.TabIndex = 13;
            this.aud6Check.Text = "06.";
            this.aud6Check.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud6Check.UseCustomBackColor = true;
            this.aud6Check.UseCustomForeColor = true;
            this.aud6Check.UseSelectable = true;
            this.aud6Check.UseStyleColors = true;
            this.aud6Check.CheckedChanged += new System.EventHandler(this.aud6Check_CheckedChanged);
            // 
            // aud5Check
            // 
            this.aud5Check.AutoSize = true;
            this.aud5Check.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.aud5Check.ForeColor = System.Drawing.Color.White;
            this.aud5Check.Location = new System.Drawing.Point(7, 249);
            this.aud5Check.Name = "aud5Check";
            this.aud5Check.Size = new System.Drawing.Size(44, 19);
            this.aud5Check.Style = MetroFramework.MetroColorStyle.Red;
            this.aud5Check.TabIndex = 12;
            this.aud5Check.Text = "05.";
            this.aud5Check.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud5Check.UseCustomBackColor = true;
            this.aud5Check.UseCustomForeColor = true;
            this.aud5Check.UseSelectable = true;
            this.aud5Check.UseStyleColors = true;
            this.aud5Check.CheckedChanged += new System.EventHandler(this.aud5Check_CheckedChanged);
            // 
            // aud4Check
            // 
            this.aud4Check.AutoSize = true;
            this.aud4Check.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.aud4Check.ForeColor = System.Drawing.Color.White;
            this.aud4Check.Location = new System.Drawing.Point(7, 199);
            this.aud4Check.Name = "aud4Check";
            this.aud4Check.Size = new System.Drawing.Size(44, 19);
            this.aud4Check.Style = MetroFramework.MetroColorStyle.Red;
            this.aud4Check.TabIndex = 11;
            this.aud4Check.Text = "04.";
            this.aud4Check.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud4Check.UseCustomBackColor = true;
            this.aud4Check.UseCustomForeColor = true;
            this.aud4Check.UseSelectable = true;
            this.aud4Check.UseStyleColors = true;
            this.aud4Check.CheckedChanged += new System.EventHandler(this.aud4Check_CheckedChanged);
            // 
            // aud3Check
            // 
            this.aud3Check.AutoSize = true;
            this.aud3Check.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.aud3Check.ForeColor = System.Drawing.Color.White;
            this.aud3Check.Location = new System.Drawing.Point(7, 149);
            this.aud3Check.Name = "aud3Check";
            this.aud3Check.Size = new System.Drawing.Size(44, 19);
            this.aud3Check.Style = MetroFramework.MetroColorStyle.Red;
            this.aud3Check.TabIndex = 10;
            this.aud3Check.Text = "03.";
            this.aud3Check.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud3Check.UseCustomBackColor = true;
            this.aud3Check.UseCustomForeColor = true;
            this.aud3Check.UseSelectable = true;
            this.aud3Check.UseStyleColors = true;
            this.aud3Check.CheckedChanged += new System.EventHandler(this.aud3Check_CheckedChanged);
            // 
            // aud2Check
            // 
            this.aud2Check.AutoSize = true;
            this.aud2Check.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.aud2Check.ForeColor = System.Drawing.Color.White;
            this.aud2Check.Location = new System.Drawing.Point(7, 100);
            this.aud2Check.Name = "aud2Check";
            this.aud2Check.Size = new System.Drawing.Size(44, 19);
            this.aud2Check.Style = MetroFramework.MetroColorStyle.Red;
            this.aud2Check.TabIndex = 9;
            this.aud2Check.Text = "02.";
            this.aud2Check.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud2Check.UseCustomBackColor = true;
            this.aud2Check.UseCustomForeColor = true;
            this.aud2Check.UseSelectable = true;
            this.aud2Check.UseStyleColors = true;
            this.aud2Check.CheckedChanged += new System.EventHandler(this.aud2Check_CheckedChanged);
            // 
            // aud1Check
            // 
            this.aud1Check.AutoSize = true;
            this.aud1Check.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.aud1Check.ForeColor = System.Drawing.Color.White;
            this.aud1Check.Location = new System.Drawing.Point(7, 46);
            this.aud1Check.Name = "aud1Check";
            this.aud1Check.Size = new System.Drawing.Size(44, 19);
            this.aud1Check.Style = MetroFramework.MetroColorStyle.Red;
            this.aud1Check.TabIndex = 8;
            this.aud1Check.Text = "01.";
            this.aud1Check.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud1Check.UseCustomBackColor = true;
            this.aud1Check.UseCustomForeColor = true;
            this.aud1Check.UseSelectable = true;
            this.aud1Check.UseStyleColors = true;
            this.aud1Check.CheckedChanged += new System.EventHandler(this.aud1Check_CheckedChanged);
            // 
            // aud5Panel
            // 
            this.aud5Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.aud5Panel.Controls.Add(this.aud5Open);
            this.aud5Panel.Controls.Add(this.aud5TXT);
            this.aud5Panel.Enabled = false;
            this.aud5Panel.Location = new System.Drawing.Point(57, 234);
            this.aud5Panel.Name = "aud5Panel";
            this.aud5Panel.Size = new System.Drawing.Size(497, 50);
            this.aud5Panel.TabIndex = 5;
            // 
            // aud5Open
            // 
            this.aud5Open.Location = new System.Drawing.Point(416, 13);
            this.aud5Open.Name = "aud5Open";
            this.aud5Open.Size = new System.Drawing.Size(75, 23);
            this.aud5Open.Style = MetroFramework.MetroColorStyle.Red;
            this.aud5Open.TabIndex = 2;
            this.aud5Open.Text = "...";
            this.aud5Open.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud5Open.UseSelectable = true;
            this.aud5Open.UseStyleColors = true;
            this.aud5Open.Click += new System.EventHandler(this.aud5Open_Click);
            // 
            // aud5TXT
            // 
            // 
            // 
            // 
            this.aud5TXT.CustomButton.Image = null;
            this.aud5TXT.CustomButton.Location = new System.Drawing.Point(380, 1);
            this.aud5TXT.CustomButton.Name = "";
            this.aud5TXT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.aud5TXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.aud5TXT.CustomButton.TabIndex = 1;
            this.aud5TXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.aud5TXT.CustomButton.UseSelectable = true;
            this.aud5TXT.CustomButton.Visible = false;
            this.aud5TXT.Lines = new string[] {
        "Select From Right ->"};
            this.aud5TXT.Location = new System.Drawing.Point(8, 13);
            this.aud5TXT.MaxLength = 32767;
            this.aud5TXT.Name = "aud5TXT";
            this.aud5TXT.PasswordChar = '\0';
            this.aud5TXT.ReadOnly = true;
            this.aud5TXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aud5TXT.SelectedText = "";
            this.aud5TXT.SelectionLength = 0;
            this.aud5TXT.SelectionStart = 0;
            this.aud5TXT.ShortcutsEnabled = true;
            this.aud5TXT.Size = new System.Drawing.Size(402, 23);
            this.aud5TXT.Style = MetroFramework.MetroColorStyle.Red;
            this.aud5TXT.TabIndex = 1;
            this.aud5TXT.Text = "Select From Right ->";
            this.aud5TXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud5TXT.UseSelectable = true;
            this.aud5TXT.UseStyleColors = true;
            this.aud5TXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.aud5TXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // aud8Panel
            // 
            this.aud8Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.aud8Panel.Controls.Add(this.aud8Open);
            this.aud8Panel.Controls.Add(this.aud8TXT);
            this.aud8Panel.Enabled = false;
            this.aud8Panel.Location = new System.Drawing.Point(57, 388);
            this.aud8Panel.Name = "aud8Panel";
            this.aud8Panel.Size = new System.Drawing.Size(500, 50);
            this.aud8Panel.TabIndex = 7;
            // 
            // aud8Open
            // 
            this.aud8Open.Location = new System.Drawing.Point(416, 13);
            this.aud8Open.Name = "aud8Open";
            this.aud8Open.Size = new System.Drawing.Size(75, 23);
            this.aud8Open.Style = MetroFramework.MetroColorStyle.Red;
            this.aud8Open.TabIndex = 2;
            this.aud8Open.Text = "...";
            this.aud8Open.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud8Open.UseSelectable = true;
            this.aud8Open.UseStyleColors = true;
            this.aud8Open.Click += new System.EventHandler(this.aud8Open_Click);
            // 
            // aud8TXT
            // 
            // 
            // 
            // 
            this.aud8TXT.CustomButton.Image = null;
            this.aud8TXT.CustomButton.Location = new System.Drawing.Point(380, 1);
            this.aud8TXT.CustomButton.Name = "";
            this.aud8TXT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.aud8TXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.aud8TXT.CustomButton.TabIndex = 1;
            this.aud8TXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.aud8TXT.CustomButton.UseSelectable = true;
            this.aud8TXT.CustomButton.Visible = false;
            this.aud8TXT.Lines = new string[] {
        "Select From Right ->"};
            this.aud8TXT.Location = new System.Drawing.Point(8, 13);
            this.aud8TXT.MaxLength = 32767;
            this.aud8TXT.Name = "aud8TXT";
            this.aud8TXT.PasswordChar = '\0';
            this.aud8TXT.ReadOnly = true;
            this.aud8TXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aud8TXT.SelectedText = "";
            this.aud8TXT.SelectionLength = 0;
            this.aud8TXT.SelectionStart = 0;
            this.aud8TXT.ShortcutsEnabled = true;
            this.aud8TXT.Size = new System.Drawing.Size(402, 23);
            this.aud8TXT.Style = MetroFramework.MetroColorStyle.Red;
            this.aud8TXT.TabIndex = 1;
            this.aud8TXT.Text = "Select From Right ->";
            this.aud8TXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud8TXT.UseSelectable = true;
            this.aud8TXT.UseStyleColors = true;
            this.aud8TXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.aud8TXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // aud7Panel
            // 
            this.aud7Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.aud7Panel.Controls.Add(this.aud7Open);
            this.aud7Panel.Controls.Add(this.aud7TXT);
            this.aud7Panel.Enabled = false;
            this.aud7Panel.Location = new System.Drawing.Point(57, 337);
            this.aud7Panel.Name = "aud7Panel";
            this.aud7Panel.Size = new System.Drawing.Size(500, 50);
            this.aud7Panel.TabIndex = 5;
            // 
            // aud7Open
            // 
            this.aud7Open.Location = new System.Drawing.Point(416, 13);
            this.aud7Open.Name = "aud7Open";
            this.aud7Open.Size = new System.Drawing.Size(75, 23);
            this.aud7Open.Style = MetroFramework.MetroColorStyle.Red;
            this.aud7Open.TabIndex = 2;
            this.aud7Open.Text = "...";
            this.aud7Open.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud7Open.UseSelectable = true;
            this.aud7Open.UseStyleColors = true;
            this.aud7Open.Click += new System.EventHandler(this.aud7Open_Click);
            // 
            // aud7TXT
            // 
            // 
            // 
            // 
            this.aud7TXT.CustomButton.Image = null;
            this.aud7TXT.CustomButton.Location = new System.Drawing.Point(380, 1);
            this.aud7TXT.CustomButton.Name = "";
            this.aud7TXT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.aud7TXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.aud7TXT.CustomButton.TabIndex = 1;
            this.aud7TXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.aud7TXT.CustomButton.UseSelectable = true;
            this.aud7TXT.CustomButton.Visible = false;
            this.aud7TXT.Lines = new string[] {
        "Select From Right ->"};
            this.aud7TXT.Location = new System.Drawing.Point(8, 13);
            this.aud7TXT.MaxLength = 32767;
            this.aud7TXT.Name = "aud7TXT";
            this.aud7TXT.PasswordChar = '\0';
            this.aud7TXT.ReadOnly = true;
            this.aud7TXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aud7TXT.SelectedText = "";
            this.aud7TXT.SelectionLength = 0;
            this.aud7TXT.SelectionStart = 0;
            this.aud7TXT.ShortcutsEnabled = true;
            this.aud7TXT.Size = new System.Drawing.Size(402, 23);
            this.aud7TXT.Style = MetroFramework.MetroColorStyle.Red;
            this.aud7TXT.TabIndex = 1;
            this.aud7TXT.Text = "Select From Right ->";
            this.aud7TXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud7TXT.UseSelectable = true;
            this.aud7TXT.UseStyleColors = true;
            this.aud7TXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.aud7TXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // aud6Panel
            // 
            this.aud6Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.aud6Panel.Controls.Add(this.aud6Open);
            this.aud6Panel.Controls.Add(this.aud6TXT);
            this.aud6Panel.Enabled = false;
            this.aud6Panel.Location = new System.Drawing.Point(57, 286);
            this.aud6Panel.Name = "aud6Panel";
            this.aud6Panel.Size = new System.Drawing.Size(500, 50);
            this.aud6Panel.TabIndex = 6;
            // 
            // aud6Open
            // 
            this.aud6Open.Location = new System.Drawing.Point(417, 13);
            this.aud6Open.Name = "aud6Open";
            this.aud6Open.Size = new System.Drawing.Size(75, 23);
            this.aud6Open.Style = MetroFramework.MetroColorStyle.Red;
            this.aud6Open.TabIndex = 2;
            this.aud6Open.Text = "...";
            this.aud6Open.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud6Open.UseSelectable = true;
            this.aud6Open.UseStyleColors = true;
            this.aud6Open.Click += new System.EventHandler(this.aud6Open_Click);
            // 
            // aud6TXT
            // 
            // 
            // 
            // 
            this.aud6TXT.CustomButton.Image = null;
            this.aud6TXT.CustomButton.Location = new System.Drawing.Point(380, 1);
            this.aud6TXT.CustomButton.Name = "";
            this.aud6TXT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.aud6TXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.aud6TXT.CustomButton.TabIndex = 1;
            this.aud6TXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.aud6TXT.CustomButton.UseSelectable = true;
            this.aud6TXT.CustomButton.Visible = false;
            this.aud6TXT.Lines = new string[] {
        "Select From Right ->"};
            this.aud6TXT.Location = new System.Drawing.Point(9, 13);
            this.aud6TXT.MaxLength = 32767;
            this.aud6TXT.Name = "aud6TXT";
            this.aud6TXT.PasswordChar = '\0';
            this.aud6TXT.ReadOnly = true;
            this.aud6TXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aud6TXT.SelectedText = "";
            this.aud6TXT.SelectionLength = 0;
            this.aud6TXT.SelectionStart = 0;
            this.aud6TXT.ShortcutsEnabled = true;
            this.aud6TXT.Size = new System.Drawing.Size(402, 23);
            this.aud6TXT.Style = MetroFramework.MetroColorStyle.Red;
            this.aud6TXT.TabIndex = 1;
            this.aud6TXT.Text = "Select From Right ->";
            this.aud6TXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud6TXT.UseSelectable = true;
            this.aud6TXT.UseStyleColors = true;
            this.aud6TXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.aud6TXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // aud4Panel
            // 
            this.aud4Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.aud4Panel.Controls.Add(this.aud4Open);
            this.aud4Panel.Controls.Add(this.aud4TXT);
            this.aud4Panel.Enabled = false;
            this.aud4Panel.Location = new System.Drawing.Point(57, 184);
            this.aud4Panel.Name = "aud4Panel";
            this.aud4Panel.Size = new System.Drawing.Size(500, 50);
            this.aud4Panel.TabIndex = 5;
            // 
            // aud4Open
            // 
            this.aud4Open.Location = new System.Drawing.Point(416, 13);
            this.aud4Open.Name = "aud4Open";
            this.aud4Open.Size = new System.Drawing.Size(75, 23);
            this.aud4Open.Style = MetroFramework.MetroColorStyle.Red;
            this.aud4Open.TabIndex = 2;
            this.aud4Open.Text = "...";
            this.aud4Open.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud4Open.UseSelectable = true;
            this.aud4Open.UseStyleColors = true;
            this.aud4Open.Click += new System.EventHandler(this.aud4Open_Click);
            // 
            // aud4TXT
            // 
            // 
            // 
            // 
            this.aud4TXT.CustomButton.Image = null;
            this.aud4TXT.CustomButton.Location = new System.Drawing.Point(380, 1);
            this.aud4TXT.CustomButton.Name = "";
            this.aud4TXT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.aud4TXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.aud4TXT.CustomButton.TabIndex = 1;
            this.aud4TXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.aud4TXT.CustomButton.UseSelectable = true;
            this.aud4TXT.CustomButton.Visible = false;
            this.aud4TXT.Lines = new string[] {
        "Select From Right ->"};
            this.aud4TXT.Location = new System.Drawing.Point(8, 13);
            this.aud4TXT.MaxLength = 32767;
            this.aud4TXT.Name = "aud4TXT";
            this.aud4TXT.PasswordChar = '\0';
            this.aud4TXT.ReadOnly = true;
            this.aud4TXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aud4TXT.SelectedText = "";
            this.aud4TXT.SelectionLength = 0;
            this.aud4TXT.SelectionStart = 0;
            this.aud4TXT.ShortcutsEnabled = true;
            this.aud4TXT.Size = new System.Drawing.Size(402, 23);
            this.aud4TXT.Style = MetroFramework.MetroColorStyle.Red;
            this.aud4TXT.TabIndex = 1;
            this.aud4TXT.Text = "Select From Right ->";
            this.aud4TXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud4TXT.UseSelectable = true;
            this.aud4TXT.UseStyleColors = true;
            this.aud4TXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.aud4TXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // aud3Panel
            // 
            this.aud3Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.aud3Panel.Controls.Add(this.aud3Open);
            this.aud3Panel.Controls.Add(this.aud3TXT);
            this.aud3Panel.Enabled = false;
            this.aud3Panel.Location = new System.Drawing.Point(57, 134);
            this.aud3Panel.Name = "aud3Panel";
            this.aud3Panel.Size = new System.Drawing.Size(500, 50);
            this.aud3Panel.TabIndex = 5;
            // 
            // aud3Open
            // 
            this.aud3Open.Location = new System.Drawing.Point(416, 13);
            this.aud3Open.Name = "aud3Open";
            this.aud3Open.Size = new System.Drawing.Size(75, 23);
            this.aud3Open.Style = MetroFramework.MetroColorStyle.Red;
            this.aud3Open.TabIndex = 2;
            this.aud3Open.Text = "...";
            this.aud3Open.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud3Open.UseSelectable = true;
            this.aud3Open.UseStyleColors = true;
            this.aud3Open.Click += new System.EventHandler(this.aud3Open_Click);
            // 
            // aud3TXT
            // 
            // 
            // 
            // 
            this.aud3TXT.CustomButton.Image = null;
            this.aud3TXT.CustomButton.Location = new System.Drawing.Point(380, 1);
            this.aud3TXT.CustomButton.Name = "";
            this.aud3TXT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.aud3TXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.aud3TXT.CustomButton.TabIndex = 1;
            this.aud3TXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.aud3TXT.CustomButton.UseSelectable = true;
            this.aud3TXT.CustomButton.Visible = false;
            this.aud3TXT.Lines = new string[] {
        "Select From Right ->"};
            this.aud3TXT.Location = new System.Drawing.Point(8, 13);
            this.aud3TXT.MaxLength = 32767;
            this.aud3TXT.Name = "aud3TXT";
            this.aud3TXT.PasswordChar = '\0';
            this.aud3TXT.ReadOnly = true;
            this.aud3TXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aud3TXT.SelectedText = "";
            this.aud3TXT.SelectionLength = 0;
            this.aud3TXT.SelectionStart = 0;
            this.aud3TXT.ShortcutsEnabled = true;
            this.aud3TXT.Size = new System.Drawing.Size(402, 23);
            this.aud3TXT.Style = MetroFramework.MetroColorStyle.Red;
            this.aud3TXT.TabIndex = 1;
            this.aud3TXT.Text = "Select From Right ->";
            this.aud3TXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud3TXT.UseSelectable = true;
            this.aud3TXT.UseStyleColors = true;
            this.aud3TXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.aud3TXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // aud2Panel
            // 
            this.aud2Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.aud2Panel.Controls.Add(this.aud2Open);
            this.aud2Panel.Controls.Add(this.aud2TXT);
            this.aud2Panel.Enabled = false;
            this.aud2Panel.Location = new System.Drawing.Point(57, 84);
            this.aud2Panel.Name = "aud2Panel";
            this.aud2Panel.Size = new System.Drawing.Size(500, 50);
            this.aud2Panel.TabIndex = 5;
            // 
            // aud2Open
            // 
            this.aud2Open.Location = new System.Drawing.Point(415, 14);
            this.aud2Open.Name = "aud2Open";
            this.aud2Open.Size = new System.Drawing.Size(75, 23);
            this.aud2Open.Style = MetroFramework.MetroColorStyle.Red;
            this.aud2Open.TabIndex = 2;
            this.aud2Open.Text = "...";
            this.aud2Open.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud2Open.UseSelectable = true;
            this.aud2Open.UseStyleColors = true;
            this.aud2Open.Click += new System.EventHandler(this.aud2Open_Click);
            // 
            // aud2TXT
            // 
            // 
            // 
            // 
            this.aud2TXT.CustomButton.Image = null;
            this.aud2TXT.CustomButton.Location = new System.Drawing.Point(380, 1);
            this.aud2TXT.CustomButton.Name = "";
            this.aud2TXT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.aud2TXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.aud2TXT.CustomButton.TabIndex = 1;
            this.aud2TXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.aud2TXT.CustomButton.UseSelectable = true;
            this.aud2TXT.CustomButton.Visible = false;
            this.aud2TXT.Lines = new string[] {
        "Select From Right ->"};
            this.aud2TXT.Location = new System.Drawing.Point(7, 14);
            this.aud2TXT.MaxLength = 32767;
            this.aud2TXT.Name = "aud2TXT";
            this.aud2TXT.PasswordChar = '\0';
            this.aud2TXT.ReadOnly = true;
            this.aud2TXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aud2TXT.SelectedText = "";
            this.aud2TXT.SelectionLength = 0;
            this.aud2TXT.SelectionStart = 0;
            this.aud2TXT.ShortcutsEnabled = true;
            this.aud2TXT.Size = new System.Drawing.Size(402, 23);
            this.aud2TXT.Style = MetroFramework.MetroColorStyle.Red;
            this.aud2TXT.TabIndex = 1;
            this.aud2TXT.Text = "Select From Right ->";
            this.aud2TXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud2TXT.UseSelectable = true;
            this.aud2TXT.UseStyleColors = true;
            this.aud2TXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.aud2TXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // aud1Panel
            // 
            this.aud1Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.aud1Panel.Controls.Add(this.aud1Open);
            this.aud1Panel.Controls.Add(this.aud1TXT);
            this.aud1Panel.Enabled = false;
            this.aud1Panel.Location = new System.Drawing.Point(57, 34);
            this.aud1Panel.Name = "aud1Panel";
            this.aud1Panel.Size = new System.Drawing.Size(500, 50);
            this.aud1Panel.TabIndex = 4;
            // 
            // aud1Open
            // 
            this.aud1Open.Location = new System.Drawing.Point(416, 12);
            this.aud1Open.Name = "aud1Open";
            this.aud1Open.Size = new System.Drawing.Size(75, 23);
            this.aud1Open.Style = MetroFramework.MetroColorStyle.Red;
            this.aud1Open.TabIndex = 2;
            this.aud1Open.Text = "...";
            this.aud1Open.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud1Open.UseSelectable = true;
            this.aud1Open.UseStyleColors = true;
            this.aud1Open.Click += new System.EventHandler(this.aud1Open_Click);
            // 
            // aud1TXT
            // 
            // 
            // 
            // 
            this.aud1TXT.CustomButton.Image = null;
            this.aud1TXT.CustomButton.Location = new System.Drawing.Point(380, 1);
            this.aud1TXT.CustomButton.Name = "";
            this.aud1TXT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.aud1TXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.aud1TXT.CustomButton.TabIndex = 1;
            this.aud1TXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.aud1TXT.CustomButton.UseSelectable = true;
            this.aud1TXT.CustomButton.Visible = false;
            this.aud1TXT.Lines = new string[] {
        "Select From Right ->"};
            this.aud1TXT.Location = new System.Drawing.Point(8, 12);
            this.aud1TXT.MaxLength = 32767;
            this.aud1TXT.Name = "aud1TXT";
            this.aud1TXT.PasswordChar = '\0';
            this.aud1TXT.ReadOnly = true;
            this.aud1TXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aud1TXT.SelectedText = "";
            this.aud1TXT.SelectionLength = 0;
            this.aud1TXT.SelectionStart = 0;
            this.aud1TXT.ShortcutsEnabled = true;
            this.aud1TXT.Size = new System.Drawing.Size(402, 23);
            this.aud1TXT.Style = MetroFramework.MetroColorStyle.Red;
            this.aud1TXT.TabIndex = 1;
            this.aud1TXT.Text = "Select From Right ->";
            this.aud1TXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.aud1TXT.UseSelectable = true;
            this.aud1TXT.UseStyleColors = true;
            this.aud1TXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.aud1TXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // audHeader
            // 
            this.audHeader.AutoSize = true;
            this.audHeader.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.audHeader.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.audHeader.ForeColor = System.Drawing.Color.White;
            this.audHeader.Location = new System.Drawing.Point(199, 5);
            this.audHeader.Name = "audHeader";
            this.audHeader.Size = new System.Drawing.Size(160, 25);
            this.audHeader.Style = MetroFramework.MetroColorStyle.Red;
            this.audHeader.TabIndex = 3;
            this.audHeader.Text = "-=AUDIO FILES=-";
            this.audHeader.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.audHeader.UseCustomBackColor = true;
            this.audHeader.UseCustomForeColor = true;
            // 
            // abkSelected
            // 
            this.abkSelected.Tick += new System.EventHandler(this.abkSelected_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(23, 634);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(557, 23);
            this.startButton.Style = MetroFramework.MetroColorStyle.Red;
            this.startButton.TabIndex = 2;
            this.startButton.Text = "START PROCESSING!";
            this.startButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.startButton.UseSelectable = true;
            this.startButton.UseStyleColors = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // buttonTimer
            // 
            this.buttonTimer.Enabled = true;
            this.buttonTimer.Interval = 1000;
            this.buttonTimer.Tick += new System.EventHandler(this.buttonTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 680);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.audioPanel);
            this.Controls.Add(this.abkPanel);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "ABK Replacer By Cylops";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.abkPanel.ResumeLayout(false);
            this.abkPanel.PerformLayout();
            this.audioPanel.ResumeLayout(false);
            this.audioPanel.PerformLayout();
            this.aud5Panel.ResumeLayout(false);
            this.aud8Panel.ResumeLayout(false);
            this.aud7Panel.ResumeLayout(false);
            this.aud6Panel.ResumeLayout(false);
            this.aud4Panel.ResumeLayout(false);
            this.aud3Panel.ResumeLayout(false);
            this.aud2Panel.ResumeLayout(false);
            this.aud1Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel abkPanel;
        private MetroFramework.Controls.MetroLabel abkLabel;
        private MetroFramework.Controls.MetroTextBox abkLocTXT;
        private MetroFramework.Controls.MetroButton abkOpen;
        private System.Windows.Forms.Panel audioPanel;
        private MetroFramework.Controls.MetroLabel audHeader;
        private System.Windows.Forms.Panel aud8Panel;
        private MetroFramework.Controls.MetroButton aud8Open;
        private MetroFramework.Controls.MetroTextBox aud8TXT;
        private System.Windows.Forms.Panel aud7Panel;
        private MetroFramework.Controls.MetroButton aud7Open;
        private MetroFramework.Controls.MetroTextBox aud7TXT;
        private System.Windows.Forms.Panel aud6Panel;
        private MetroFramework.Controls.MetroButton aud6Open;
        private MetroFramework.Controls.MetroTextBox aud6TXT;
        private System.Windows.Forms.Panel aud4Panel;
        private MetroFramework.Controls.MetroButton aud4Open;
        private MetroFramework.Controls.MetroTextBox aud4TXT;
        private System.Windows.Forms.Panel aud3Panel;
        private MetroFramework.Controls.MetroButton aud3Open;
        private MetroFramework.Controls.MetroTextBox aud3TXT;
        private System.Windows.Forms.Panel aud2Panel;
        private MetroFramework.Controls.MetroButton aud2Open;
        private MetroFramework.Controls.MetroTextBox aud2TXT;
        private System.Windows.Forms.Panel aud1Panel;
        private MetroFramework.Controls.MetroButton aud1Open;
        private MetroFramework.Controls.MetroTextBox aud1TXT;
        private System.Windows.Forms.Panel aud5Panel;
        private MetroFramework.Controls.MetroButton aud5Open;
        private MetroFramework.Controls.MetroTextBox aud5TXT;
        private System.Windows.Forms.Timer abkSelected;
        private MetroFramework.Controls.MetroCheckBox aud1Check;
        private MetroFramework.Controls.MetroCheckBox aud8Check;
        private MetroFramework.Controls.MetroCheckBox aud7Check;
        private MetroFramework.Controls.MetroCheckBox aud6Check;
        private MetroFramework.Controls.MetroCheckBox aud5Check;
        private MetroFramework.Controls.MetroCheckBox aud4Check;
        private MetroFramework.Controls.MetroCheckBox aud3Check;
        private MetroFramework.Controls.MetroCheckBox aud2Check;
        private MetroFramework.Controls.MetroButton startButton;
        private System.Windows.Forms.Timer buttonTimer;
    }
}

