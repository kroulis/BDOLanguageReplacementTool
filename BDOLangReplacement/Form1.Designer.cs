
namespace BDOLangReplacement
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.controlTab = new System.Windows.Forms.TabControl();
            this.lvi = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshLanguageVersion = new System.Windows.Forms.Button();
            this.languageVersionBar = new System.Windows.Forms.ProgressBar();
            this.langList = new System.Windows.Forms.ListBox();
            this.changeLang = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.replacementLog = new System.Windows.Forms.TextBox();
            this.replaceBar = new System.Windows.Forms.ProgressBar();
            this.Restore = new System.Windows.Forms.Button();
            this.Replace = new System.Windows.Forms.Button();
            this.startLauncher = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fromSteam = new System.Windows.Forms.CheckBox();
            this.tgtLangName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.srcLangBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fonts = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TwcnFontSwitchButton = new System.Windows.Forms.RadioButton();
            this.ZhcnFontSwitchButton = new System.Windows.Forms.RadioButton();
            this.CNFont = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SetupCNFont = new System.Windows.Forms.Button();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.AboutTextBox = new System.Windows.Forms.TextBox();
            this.appLangBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.processStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.processCheck = new System.Windows.Forms.Timer(this.components);
            this.downloadUpdate = new System.Windows.Forms.Timer(this.components);
            this.fontCheck = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.controlTab.SuspendLayout();
            this.lvi.SuspendLayout();
            this.changeLang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Fonts.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.AboutTab.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlTab
            // 
            this.controlTab.Controls.Add(this.lvi);
            this.controlTab.Controls.Add(this.changeLang);
            this.controlTab.Controls.Add(this.Fonts);
            this.controlTab.Controls.Add(this.AboutTab);
            this.controlTab.Location = new System.Drawing.Point(12, 110);
            this.controlTab.Name = "controlTab";
            this.controlTab.SelectedIndex = 0;
            this.controlTab.Size = new System.Drawing.Size(592, 329);
            this.controlTab.TabIndex = 0;
            // 
            // lvi
            // 
            this.lvi.Controls.Add(this.label1);
            this.lvi.Controls.Add(this.refreshLanguageVersion);
            this.lvi.Controls.Add(this.languageVersionBar);
            this.lvi.Controls.Add(this.langList);
            this.lvi.Location = new System.Drawing.Point(4, 22);
            this.lvi.Name = "lvi";
            this.lvi.Padding = new System.Windows.Forms.Padding(3);
            this.lvi.Size = new System.Drawing.Size(584, 303);
            this.lvi.TabIndex = 0;
            this.lvi.Text = "Language Versions";
            this.lvi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Double click on the language file you want to replace to:";
            // 
            // refreshLanguageVersion
            // 
            this.refreshLanguageVersion.Location = new System.Drawing.Point(487, 272);
            this.refreshLanguageVersion.Name = "refreshLanguageVersion";
            this.refreshLanguageVersion.Size = new System.Drawing.Size(75, 23);
            this.refreshLanguageVersion.TabIndex = 2;
            this.refreshLanguageVersion.Text = "Refresh";
            this.refreshLanguageVersion.UseVisualStyleBackColor = true;
            this.refreshLanguageVersion.Click += new System.EventHandler(this.refreshLanguageVersion_Click);
            // 
            // languageVersionBar
            // 
            this.languageVersionBar.Location = new System.Drawing.Point(11, 272);
            this.languageVersionBar.Name = "languageVersionBar";
            this.languageVersionBar.Size = new System.Drawing.Size(461, 23);
            this.languageVersionBar.TabIndex = 1;
            // 
            // langList
            // 
            this.langList.FormattingEnabled = true;
            this.langList.HorizontalScrollbar = true;
            this.langList.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.langList.Items.AddRange(new object[] {
            "Unavailable"});
            this.langList.Location = new System.Drawing.Point(11, 21);
            this.langList.Name = "langList";
            this.langList.Size = new System.Drawing.Size(561, 238);
            this.langList.TabIndex = 0;
            this.langList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.langList_MouseDoubleClick);
            // 
            // changeLang
            // 
            this.changeLang.Controls.Add(this.label6);
            this.changeLang.Controls.Add(this.groupBox1);
            this.changeLang.Controls.Add(this.Restore);
            this.changeLang.Controls.Add(this.Replace);
            this.changeLang.Controls.Add(this.startLauncher);
            this.changeLang.Controls.Add(this.label5);
            this.changeLang.Controls.Add(this.fromSteam);
            this.changeLang.Controls.Add(this.tgtLangName);
            this.changeLang.Controls.Add(this.label4);
            this.changeLang.Controls.Add(this.label3);
            this.changeLang.Controls.Add(this.srcLangBox);
            this.changeLang.Controls.Add(this.label2);
            this.changeLang.Location = new System.Drawing.Point(4, 22);
            this.changeLang.Name = "changeLang";
            this.changeLang.Padding = new System.Windows.Forms.Padding(3);
            this.changeLang.Size = new System.Drawing.Size(584, 303);
            this.changeLang.TabIndex = 1;
            this.changeLang.Text = "Language File Replacement";
            this.changeLang.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = ">";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.replacementLog);
            this.groupBox1.Controls.Add(this.replaceBar);
            this.groupBox1.Location = new System.Drawing.Point(11, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 198);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // replacementLog
            // 
            this.replacementLog.Location = new System.Drawing.Point(6, 19);
            this.replacementLog.Multiline = true;
            this.replacementLog.Name = "replacementLog";
            this.replacementLog.ReadOnly = true;
            this.replacementLog.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.replacementLog.Size = new System.Drawing.Size(555, 144);
            this.replacementLog.TabIndex = 1;
            this.replacementLog.Text = "Please click \"Replace\" or \"Restore\" at the time you can start the game to begin.." +
    ".";
            // 
            // replaceBar
            // 
            this.replaceBar.Location = new System.Drawing.Point(6, 169);
            this.replaceBar.Name = "replaceBar";
            this.replaceBar.Size = new System.Drawing.Size(555, 23);
            this.replaceBar.TabIndex = 0;
            // 
            // Restore
            // 
            this.Restore.Enabled = false;
            this.Restore.Location = new System.Drawing.Point(442, 51);
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(75, 23);
            this.Restore.TabIndex = 9;
            this.Restore.TabStop = false;
            this.Restore.Text = "Restore";
            this.Restore.UseVisualStyleBackColor = true;
            this.Restore.Click += new System.EventHandler(this.Restore_Click);
            // 
            // Replace
            // 
            this.Replace.Enabled = false;
            this.Replace.Location = new System.Drawing.Point(361, 51);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(75, 23);
            this.Replace.TabIndex = 8;
            this.Replace.TabStop = false;
            this.Replace.Text = "Replace";
            this.Replace.UseVisualStyleBackColor = true;
            this.Replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // startLauncher
            // 
            this.startLauncher.Location = new System.Drawing.Point(249, 51);
            this.startLauncher.Name = "startLauncher";
            this.startLauncher.Size = new System.Drawing.Size(91, 23);
            this.startLauncher.TabIndex = 7;
            this.startLauncher.TabStop = false;
            this.startLauncher.Text = "Start Launcher";
            this.startLauncher.UseVisualStyleBackColor = true;
            this.startLauncher.Click += new System.EventHandler(this.startLauncher_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Is your game launched from Steam?";
            // 
            // fromSteam
            // 
            this.fromSteam.AutoSize = true;
            this.fromSteam.Location = new System.Drawing.Point(10, 65);
            this.fromSteam.Name = "fromSteam";
            this.fromSteam.Size = new System.Drawing.Size(82, 17);
            this.fromSteam.TabIndex = 5;
            this.fromSteam.Text = "From Steam";
            this.fromSteam.UseVisualStyleBackColor = true;
            this.fromSteam.CheckedChanged += new System.EventHandler(this.fromSteam_CheckedChanged);
            // 
            // tgtLangName
            // 
            this.tgtLangName.AutoSize = true;
            this.tgtLangName.Location = new System.Drawing.Point(246, 22);
            this.tgtLangName.Name = "tgtLangName";
            this.tgtLangName.Size = new System.Drawing.Size(271, 13);
            this.tgtLangName.TabIndex = 4;
            this.tgtLangName.Text = "Unknown Language. Please Select it in the Version Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "====>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "You are proposed to change to:";
            // 
            // srcLangBox
            // 
            this.srcLangBox.Location = new System.Drawing.Point(9, 19);
            this.srcLangBox.Name = "srcLangBox";
            this.srcLangBox.Size = new System.Drawing.Size(175, 21);
            this.srcLangBox.TabIndex = 1;
            this.srcLangBox.SelectedIndexChanged += new System.EventHandler(this.srcLangBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select your current language in game:";
            // 
            // Fonts
            // 
            this.Fonts.Controls.Add(this.groupBox2);
            this.Fonts.Location = new System.Drawing.Point(4, 22);
            this.Fonts.Name = "Fonts";
            this.Fonts.Size = new System.Drawing.Size(584, 303);
            this.Fonts.TabIndex = 2;
            this.Fonts.Text = "Fonts Setup";
            this.Fonts.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TwcnFontSwitchButton);
            this.groupBox2.Controls.Add(this.ZhcnFontSwitchButton);
            this.groupBox2.Controls.Add(this.CNFont);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.SetupCNFont);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 124);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TW_CN";
            // 
            // TwcnFontSwitchButton
            // 
            this.TwcnFontSwitchButton.AutoSize = true;
            this.TwcnFontSwitchButton.Checked = true;
            this.TwcnFontSwitchButton.Location = new System.Drawing.Point(28, 72);
            this.TwcnFontSwitchButton.Name = "TwcnFontSwitchButton";
            this.TwcnFontSwitchButton.Size = new System.Drawing.Size(115, 17);
            this.TwcnFontSwitchButton.TabIndex = 4;
            this.TwcnFontSwitchButton.TabStop = true;
            this.TwcnFontSwitchButton.Text = "Traditional Chinese";
            this.TwcnFontSwitchButton.UseVisualStyleBackColor = true;
            // 
            // ZhcnFontSwitchButton
            // 
            this.ZhcnFontSwitchButton.AutoSize = true;
            this.ZhcnFontSwitchButton.Location = new System.Drawing.Point(28, 49);
            this.ZhcnFontSwitchButton.Name = "ZhcnFontSwitchButton";
            this.ZhcnFontSwitchButton.Size = new System.Drawing.Size(110, 17);
            this.ZhcnFontSwitchButton.TabIndex = 3;
            this.ZhcnFontSwitchButton.TabStop = true;
            this.ZhcnFontSwitchButton.Text = "Simplified Chinese";
            this.ZhcnFontSwitchButton.UseVisualStyleBackColor = true;
            // 
            // CNFont
            // 
            this.CNFont.AutoSize = true;
            this.CNFont.ForeColor = System.Drawing.Color.Red;
            this.CNFont.Location = new System.Drawing.Point(81, 24);
            this.CNFont.Name = "CNFont";
            this.CNFont.Size = new System.Drawing.Size(57, 13);
            this.CNFont.TabIndex = 2;
            this.CNFont.Text = "Not Found";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Font Status:";
            // 
            // SetupCNFont
            // 
            this.SetupCNFont.Location = new System.Drawing.Point(13, 95);
            this.SetupCNFont.Name = "SetupCNFont";
            this.SetupCNFont.Size = new System.Drawing.Size(146, 23);
            this.SetupCNFont.TabIndex = 0;
            this.SetupCNFont.Text = "Install OR Remove pearl.ttf";
            this.SetupCNFont.UseVisualStyleBackColor = true;
            this.SetupCNFont.Click += new System.EventHandler(this.SetupCNFont_Click);
            // 
            // AboutTab
            // 
            this.AboutTab.Controls.Add(this.linkLabel1);
            this.AboutTab.Controls.Add(this.AboutTextBox);
            this.AboutTab.Controls.Add(this.appLangBox);
            this.AboutTab.Controls.Add(this.label8);
            this.AboutTab.Location = new System.Drawing.Point(4, 22);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Size = new System.Drawing.Size(584, 303);
            this.AboutTab.TabIndex = 3;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(512, 279);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub Repo";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AboutTextBox
            // 
            this.AboutTextBox.Location = new System.Drawing.Point(6, 3);
            this.AboutTextBox.Multiline = true;
            this.AboutTextBox.Name = "AboutTextBox";
            this.AboutTextBox.ReadOnly = true;
            this.AboutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AboutTextBox.Size = new System.Drawing.Size(575, 257);
            this.AboutTextBox.TabIndex = 2;
            // 
            // appLangBox
            // 
            this.appLangBox.FormattingEnabled = true;
            this.appLangBox.IntegralHeight = false;
            this.appLangBox.Items.AddRange(new object[] {
            "English",
            "简体中文"});
            this.appLangBox.Location = new System.Drawing.Point(6, 279);
            this.appLangBox.Name = "appLangBox";
            this.appLangBox.Size = new System.Drawing.Size(121, 21);
            this.appLangBox.TabIndex = 1;
            this.appLangBox.SelectedIndexChanged += new System.EventHandler(this.appLangBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Language:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processStatus,
            this.toolStripStatusLabel1,
            this.ToolVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(615, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // processStatus
            // 
            this.processStatus.Name = "processStatus";
            this.processStatus.Size = new System.Drawing.Size(169, 17);
            this.processStatus.Text = "Finding BDO Launcher Process";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(386, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // ToolVersion
            // 
            this.ToolVersion.Name = "ToolVersion";
            this.ToolVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToolVersion.Size = new System.Drawing.Size(45, 17);
            this.ToolVersion.Text = "version";
            // 
            // processCheck
            // 
            this.processCheck.Tick += new System.EventHandler(this.processCheck_Tick);
            // 
            // downloadUpdate
            // 
            this.downloadUpdate.Enabled = true;
            this.downloadUpdate.Interval = 500;
            this.downloadUpdate.Tick += new System.EventHandler(this.downloadUpdate_Tick);
            // 
            // fontCheck
            // 
            this.fontCheck.Enabled = true;
            this.fontCheck.Interval = 1000;
            this.fontCheck.Tick += new System.EventHandler(this.fontCheck_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(584, 92);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.controlTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BDOLanguageReplacementTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.controlTab.ResumeLayout(false);
            this.lvi.ResumeLayout(false);
            this.lvi.PerformLayout();
            this.changeLang.ResumeLayout(false);
            this.changeLang.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Fonts.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.AboutTab.ResumeLayout(false);
            this.AboutTab.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl controlTab;
        private System.Windows.Forms.TabPage lvi;
        private System.Windows.Forms.Button refreshLanguageVersion;
        private System.Windows.Forms.ProgressBar languageVersionBar;
        private System.Windows.Forms.ListBox langList;
        private System.Windows.Forms.TabPage changeLang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox srcLangBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tgtLangName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox fromSteam;
        private System.Windows.Forms.Button Restore;
        private System.Windows.Forms.Button Replace;
        private System.Windows.Forms.Button startLauncher;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel processStatus;
        private System.Windows.Forms.Timer processCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar replaceBar;
        private System.Windows.Forms.TextBox replacementLog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer downloadUpdate;
        private System.Windows.Forms.TabPage Fonts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label CNFont;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SetupCNFont;
        private System.Windows.Forms.Timer fontCheck;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel ToolVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage AboutTab;
        private System.Windows.Forms.ComboBox appLangBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AboutTextBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton TwcnFontSwitchButton;
        private System.Windows.Forms.RadioButton ZhcnFontSwitchButton;
    }
}

