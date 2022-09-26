
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Waiting for execution");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.controlTab = new System.Windows.Forms.TabControl();
            this.lvi = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshLanguageVersion = new System.Windows.Forms.Button();
            this.languageVersionBar = new System.Windows.Forms.ProgressBar();
            this.langList = new System.Windows.Forms.ListBox();
            this.changeLang = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.ScriptsBtn = new System.Windows.Forms.Button();
            this.advancedText = new System.Windows.Forms.Label();
            this.MergeBtn = new System.Windows.Forms.Button();
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
            this.advance = new System.Windows.Forms.TabPage();
            this.advOpExecTreeView = new System.Windows.Forms.TreeView();
            this.advOpGroup = new System.Windows.Forms.GroupBox();
            this.advOpProgressBar = new System.Windows.Forms.ProgressBar();
            this.executeHelperBtn = new System.Windows.Forms.Button();
            this.advOpAdditionalFile2BrowseBtn = new System.Windows.Forms.Button();
            this.advOpAdditionalFile2Input = new System.Windows.Forms.TextBox();
            this.advOpAdditionalFile2Label = new System.Windows.Forms.Label();
            this.advOpAdditionalFile1BrowseBtn = new System.Windows.Forms.Button();
            this.advOpAdditionalFile1Input = new System.Windows.Forms.TextBox();
            this.advOpAdditionalFile1Label = new System.Windows.Forms.Label();
            this.advOpOutputBrowseBtn = new System.Windows.Forms.Button();
            this.advOpOutputInput = new System.Windows.Forms.TextBox();
            this.advOpOutputLabel = new System.Windows.Forms.Label();
            this.advOpSourceBrowseBtn = new System.Windows.Forms.Button();
            this.advOpSourceInput = new System.Windows.Forms.TextBox();
            this.advOpSourceLabel = new System.Windows.Forms.Label();
            this.advOpCodeLabel = new System.Windows.Forms.Label();
            this.advOpCodeBox = new System.Windows.Forms.ComboBox();
            this.helperToolCompTab = new System.Windows.Forms.GroupBox();
            this.uninstallHelperToolBtn = new System.Windows.Forms.Button();
            this.helperToolOnlineVerLabel = new System.Windows.Forms.Label();
            this.helperToolOnlineText = new System.Windows.Forms.Label();
            this.InstallUpdateHelperToolBtn = new System.Windows.Forms.Button();
            this.helperToolStatusLabel = new System.Windows.Forms.Label();
            this.helperToolLocalText = new System.Windows.Forms.Label();
            this.Fonts = new System.Windows.Forms.TabPage();
            this.exampleBox = new System.Windows.Forms.RichTextBox();
            this.customFontBox = new System.Windows.Forms.GroupBox();
            this.fontFileBrowse = new System.Windows.Forms.Button();
            this.fontBrowse = new System.Windows.Forms.Button();
            this.SetupCNFont = new System.Windows.Forms.Button();
            this.fontInput = new System.Windows.Forms.TextBox();
            this.embFontBox = new System.Windows.Forms.GroupBox();
            this.customRadioBtn = new System.Windows.Forms.RadioButton();
            this.TwcnFontSwitchButton = new System.Windows.Forms.RadioButton();
            this.ZhcnFontSwitchButton = new System.Windows.Forms.RadioButton();
            this.CNFont = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.helperToolProcess = new System.Diagnostics.Process();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.controlTab.SuspendLayout();
            this.lvi.SuspendLayout();
            this.changeLang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.advance.SuspendLayout();
            this.advOpGroup.SuspendLayout();
            this.helperToolCompTab.SuspendLayout();
            this.Fonts.SuspendLayout();
            this.customFontBox.SuspendLayout();
            this.embFontBox.SuspendLayout();
            this.AboutTab.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlTab
            // 
            this.controlTab.Controls.Add(this.lvi);
            this.controlTab.Controls.Add(this.changeLang);
            this.controlTab.Controls.Add(this.advance);
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
            this.changeLang.Controls.Add(this.label11);
            this.changeLang.Controls.Add(this.ScriptsBtn);
            this.changeLang.Controls.Add(this.advancedText);
            this.changeLang.Controls.Add(this.MergeBtn);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(345, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = ">";
            // 
            // ScriptsBtn
            // 
            this.ScriptsBtn.Enabled = false;
            this.ScriptsBtn.Location = new System.Drawing.Point(442, 80);
            this.ScriptsBtn.Name = "ScriptsBtn";
            this.ScriptsBtn.Size = new System.Drawing.Size(75, 23);
            this.ScriptsBtn.TabIndex = 14;
            this.ScriptsBtn.TabStop = false;
            this.ScriptsBtn.Text = "Script";
            this.ScriptsBtn.UseVisualStyleBackColor = true;
            // 
            // advancedText
            // 
            this.advancedText.AutoSize = true;
            this.advancedText.Location = new System.Drawing.Point(282, 86);
            this.advancedText.Name = "advancedText";
            this.advancedText.Size = new System.Drawing.Size(56, 13);
            this.advancedText.TabIndex = 13;
            this.advancedText.Text = "Advanced";
            this.advancedText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MergeBtn
            // 
            this.MergeBtn.Enabled = false;
            this.MergeBtn.Location = new System.Drawing.Point(361, 80);
            this.MergeBtn.Name = "MergeBtn";
            this.MergeBtn.Size = new System.Drawing.Size(75, 23);
            this.MergeBtn.TabIndex = 12;
            this.MergeBtn.TabStop = false;
            this.MergeBtn.Text = "Merge";
            this.MergeBtn.UseVisualStyleBackColor = true;
            this.MergeBtn.Click += new System.EventHandler(this.MergeBtn_Click);
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
            // advance
            // 
            this.advance.Controls.Add(this.advOpExecTreeView);
            this.advance.Controls.Add(this.advOpGroup);
            this.advance.Controls.Add(this.helperToolCompTab);
            this.advance.Location = new System.Drawing.Point(4, 22);
            this.advance.Name = "advance";
            this.advance.Size = new System.Drawing.Size(584, 303);
            this.advance.TabIndex = 4;
            this.advance.Text = "Advance";
            this.advance.UseVisualStyleBackColor = true;
            // 
            // advOpExecTreeView
            // 
            this.advOpExecTreeView.Location = new System.Drawing.Point(328, 9);
            this.advOpExecTreeView.Name = "advOpExecTreeView";
            treeNode1.Name = "NoResult";
            treeNode1.Text = "Waiting for execution";
            this.advOpExecTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.advOpExecTreeView.Size = new System.Drawing.Size(244, 291);
            this.advOpExecTreeView.TabIndex = 2;
            // 
            // advOpGroup
            // 
            this.advOpGroup.Controls.Add(this.advOpProgressBar);
            this.advOpGroup.Controls.Add(this.executeHelperBtn);
            this.advOpGroup.Controls.Add(this.advOpAdditionalFile2BrowseBtn);
            this.advOpGroup.Controls.Add(this.advOpAdditionalFile2Input);
            this.advOpGroup.Controls.Add(this.advOpAdditionalFile2Label);
            this.advOpGroup.Controls.Add(this.advOpAdditionalFile1BrowseBtn);
            this.advOpGroup.Controls.Add(this.advOpAdditionalFile1Input);
            this.advOpGroup.Controls.Add(this.advOpAdditionalFile1Label);
            this.advOpGroup.Controls.Add(this.advOpOutputBrowseBtn);
            this.advOpGroup.Controls.Add(this.advOpOutputInput);
            this.advOpGroup.Controls.Add(this.advOpOutputLabel);
            this.advOpGroup.Controls.Add(this.advOpSourceBrowseBtn);
            this.advOpGroup.Controls.Add(this.advOpSourceInput);
            this.advOpGroup.Controls.Add(this.advOpSourceLabel);
            this.advOpGroup.Controls.Add(this.advOpCodeLabel);
            this.advOpGroup.Controls.Add(this.advOpCodeBox);
            this.advOpGroup.Location = new System.Drawing.Point(3, 86);
            this.advOpGroup.Name = "advOpGroup";
            this.advOpGroup.Size = new System.Drawing.Size(323, 214);
            this.advOpGroup.TabIndex = 1;
            this.advOpGroup.TabStop = false;
            this.advOpGroup.Text = "Advanced Operations";
            // 
            // advOpProgressBar
            // 
            this.advOpProgressBar.Location = new System.Drawing.Point(101, 169);
            this.advOpProgressBar.Name = "advOpProgressBar";
            this.advOpProgressBar.Size = new System.Drawing.Size(213, 29);
            this.advOpProgressBar.TabIndex = 15;
            // 
            // executeHelperBtn
            // 
            this.executeHelperBtn.Location = new System.Drawing.Point(9, 168);
            this.executeHelperBtn.Name = "executeHelperBtn";
            this.executeHelperBtn.Size = new System.Drawing.Size(84, 29);
            this.executeHelperBtn.TabIndex = 14;
            this.executeHelperBtn.Text = "Execute";
            this.executeHelperBtn.UseVisualStyleBackColor = true;
            this.executeHelperBtn.Click += new System.EventHandler(this.executeHelperBtn_Click);
            // 
            // advOpAdditionalFile2BrowseBtn
            // 
            this.advOpAdditionalFile2BrowseBtn.Location = new System.Drawing.Point(258, 128);
            this.advOpAdditionalFile2BrowseBtn.Name = "advOpAdditionalFile2BrowseBtn";
            this.advOpAdditionalFile2BrowseBtn.Size = new System.Drawing.Size(57, 23);
            this.advOpAdditionalFile2BrowseBtn.TabIndex = 13;
            this.advOpAdditionalFile2BrowseBtn.Text = "Browse";
            this.advOpAdditionalFile2BrowseBtn.UseVisualStyleBackColor = true;
            this.advOpAdditionalFile2BrowseBtn.Click += new System.EventHandler(this.advOpAdditionalFile2BrowseBtn_Click);
            // 
            // advOpAdditionalFile2Input
            // 
            this.advOpAdditionalFile2Input.Location = new System.Drawing.Point(63, 130);
            this.advOpAdditionalFile2Input.Name = "advOpAdditionalFile2Input";
            this.advOpAdditionalFile2Input.Size = new System.Drawing.Size(194, 20);
            this.advOpAdditionalFile2Input.TabIndex = 12;
            // 
            // advOpAdditionalFile2Label
            // 
            this.advOpAdditionalFile2Label.AutoSize = true;
            this.advOpAdditionalFile2Label.Location = new System.Drawing.Point(4, 134);
            this.advOpAdditionalFile2Label.Name = "advOpAdditionalFile2Label";
            this.advOpAdditionalFile2Label.Size = new System.Drawing.Size(62, 13);
            this.advOpAdditionalFile2Label.TabIndex = 11;
            this.advOpAdditionalFile2Label.Text = "Additional2:";
            // 
            // advOpAdditionalFile1BrowseBtn
            // 
            this.advOpAdditionalFile1BrowseBtn.Location = new System.Drawing.Point(258, 100);
            this.advOpAdditionalFile1BrowseBtn.Name = "advOpAdditionalFile1BrowseBtn";
            this.advOpAdditionalFile1BrowseBtn.Size = new System.Drawing.Size(57, 23);
            this.advOpAdditionalFile1BrowseBtn.TabIndex = 10;
            this.advOpAdditionalFile1BrowseBtn.Text = "Browse";
            this.advOpAdditionalFile1BrowseBtn.UseVisualStyleBackColor = true;
            this.advOpAdditionalFile1BrowseBtn.Click += new System.EventHandler(this.advOpAdditionalFile1BrowseBtn_Click);
            // 
            // advOpAdditionalFile1Input
            // 
            this.advOpAdditionalFile1Input.Location = new System.Drawing.Point(63, 102);
            this.advOpAdditionalFile1Input.Name = "advOpAdditionalFile1Input";
            this.advOpAdditionalFile1Input.Size = new System.Drawing.Size(194, 20);
            this.advOpAdditionalFile1Input.TabIndex = 9;
            // 
            // advOpAdditionalFile1Label
            // 
            this.advOpAdditionalFile1Label.AutoSize = true;
            this.advOpAdditionalFile1Label.Location = new System.Drawing.Point(4, 106);
            this.advOpAdditionalFile1Label.Name = "advOpAdditionalFile1Label";
            this.advOpAdditionalFile1Label.Size = new System.Drawing.Size(62, 13);
            this.advOpAdditionalFile1Label.TabIndex = 8;
            this.advOpAdditionalFile1Label.Text = "Additional1:";
            // 
            // advOpOutputBrowseBtn
            // 
            this.advOpOutputBrowseBtn.Location = new System.Drawing.Point(258, 72);
            this.advOpOutputBrowseBtn.Name = "advOpOutputBrowseBtn";
            this.advOpOutputBrowseBtn.Size = new System.Drawing.Size(57, 23);
            this.advOpOutputBrowseBtn.TabIndex = 7;
            this.advOpOutputBrowseBtn.Text = "Browse";
            this.advOpOutputBrowseBtn.UseVisualStyleBackColor = true;
            this.advOpOutputBrowseBtn.Click += new System.EventHandler(this.advOpOutputBrowseBtn_Click);
            // 
            // advOpOutputInput
            // 
            this.advOpOutputInput.Location = new System.Drawing.Point(63, 74);
            this.advOpOutputInput.Name = "advOpOutputInput";
            this.advOpOutputInput.Size = new System.Drawing.Size(194, 20);
            this.advOpOutputInput.TabIndex = 6;
            // 
            // advOpOutputLabel
            // 
            this.advOpOutputLabel.AutoSize = true;
            this.advOpOutputLabel.Location = new System.Drawing.Point(4, 78);
            this.advOpOutputLabel.Name = "advOpOutputLabel";
            this.advOpOutputLabel.Size = new System.Drawing.Size(42, 13);
            this.advOpOutputLabel.TabIndex = 5;
            this.advOpOutputLabel.Text = "Output:";
            // 
            // advOpSourceBrowseBtn
            // 
            this.advOpSourceBrowseBtn.Location = new System.Drawing.Point(258, 45);
            this.advOpSourceBrowseBtn.Name = "advOpSourceBrowseBtn";
            this.advOpSourceBrowseBtn.Size = new System.Drawing.Size(57, 23);
            this.advOpSourceBrowseBtn.TabIndex = 4;
            this.advOpSourceBrowseBtn.Text = "Browse";
            this.advOpSourceBrowseBtn.UseVisualStyleBackColor = true;
            this.advOpSourceBrowseBtn.Click += new System.EventHandler(this.advOpSourceBrowseBtn_Click);
            // 
            // advOpSourceInput
            // 
            this.advOpSourceInput.Location = new System.Drawing.Point(63, 46);
            this.advOpSourceInput.Name = "advOpSourceInput";
            this.advOpSourceInput.Size = new System.Drawing.Size(194, 20);
            this.advOpSourceInput.TabIndex = 3;
            // 
            // advOpSourceLabel
            // 
            this.advOpSourceLabel.AutoSize = true;
            this.advOpSourceLabel.Location = new System.Drawing.Point(4, 50);
            this.advOpSourceLabel.Name = "advOpSourceLabel";
            this.advOpSourceLabel.Size = new System.Drawing.Size(44, 13);
            this.advOpSourceLabel.TabIndex = 2;
            this.advOpSourceLabel.Text = "Source:";
            // 
            // advOpCodeLabel
            // 
            this.advOpCodeLabel.AutoSize = true;
            this.advOpCodeLabel.Location = new System.Drawing.Point(4, 22);
            this.advOpCodeLabel.Name = "advOpCodeLabel";
            this.advOpCodeLabel.Size = new System.Drawing.Size(56, 13);
            this.advOpCodeLabel.TabIndex = 1;
            this.advOpCodeLabel.Text = "Operation:";
            // 
            // advOpCodeBox
            // 
            this.advOpCodeBox.FormattingEnabled = true;
            this.advOpCodeBox.Items.AddRange(new object[] {
            "Encrypt",
            "Decrypt",
            "Diff",
            "Merge",
            "Translate (Traditional Chinese to Simplified Chinese)"});
            this.advOpCodeBox.Location = new System.Drawing.Point(63, 18);
            this.advOpCodeBox.Name = "advOpCodeBox";
            this.advOpCodeBox.Size = new System.Drawing.Size(252, 21);
            this.advOpCodeBox.TabIndex = 0;
            // 
            // helperToolCompTab
            // 
            this.helperToolCompTab.Controls.Add(this.uninstallHelperToolBtn);
            this.helperToolCompTab.Controls.Add(this.helperToolOnlineVerLabel);
            this.helperToolCompTab.Controls.Add(this.helperToolOnlineText);
            this.helperToolCompTab.Controls.Add(this.InstallUpdateHelperToolBtn);
            this.helperToolCompTab.Controls.Add(this.helperToolStatusLabel);
            this.helperToolCompTab.Controls.Add(this.helperToolLocalText);
            this.helperToolCompTab.Location = new System.Drawing.Point(3, 3);
            this.helperToolCompTab.Name = "helperToolCompTab";
            this.helperToolCompTab.Size = new System.Drawing.Size(323, 77);
            this.helperToolCompTab.TabIndex = 0;
            this.helperToolCompTab.TabStop = false;
            this.helperToolCompTab.Text = "HelperTool Status";
            // 
            // uninstallHelperToolBtn
            // 
            this.uninstallHelperToolBtn.Enabled = false;
            this.uninstallHelperToolBtn.Location = new System.Drawing.Point(177, 44);
            this.uninstallHelperToolBtn.Name = "uninstallHelperToolBtn";
            this.uninstallHelperToolBtn.Size = new System.Drawing.Size(100, 23);
            this.uninstallHelperToolBtn.TabIndex = 5;
            this.uninstallHelperToolBtn.Text = "Uninstall";
            this.uninstallHelperToolBtn.UseVisualStyleBackColor = false;
            this.uninstallHelperToolBtn.Click += new System.EventHandler(this.uninstallHelperToolBtn_Click);
            // 
            // helperToolOnlineVerLabel
            // 
            this.helperToolOnlineVerLabel.AutoSize = true;
            this.helperToolOnlineVerLabel.ForeColor = System.Drawing.Color.Red;
            this.helperToolOnlineVerLabel.Location = new System.Drawing.Point(99, 49);
            this.helperToolOnlineVerLabel.Name = "helperToolOnlineVerLabel";
            this.helperToolOnlineVerLabel.Size = new System.Drawing.Size(57, 13);
            this.helperToolOnlineVerLabel.TabIndex = 4;
            this.helperToolOnlineVerLabel.Text = "Not Found";
            // 
            // helperToolOnlineText
            // 
            this.helperToolOnlineText.AutoSize = true;
            this.helperToolOnlineText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helperToolOnlineText.Location = new System.Drawing.Point(6, 49);
            this.helperToolOnlineText.Name = "helperToolOnlineText";
            this.helperToolOnlineText.Size = new System.Drawing.Size(78, 13);
            this.helperToolOnlineText.TabIndex = 3;
            this.helperToolOnlineText.Text = "Online Version:";
            // 
            // InstallUpdateHelperToolBtn
            // 
            this.InstallUpdateHelperToolBtn.Enabled = false;
            this.InstallUpdateHelperToolBtn.Location = new System.Drawing.Point(177, 19);
            this.InstallUpdateHelperToolBtn.Name = "InstallUpdateHelperToolBtn";
            this.InstallUpdateHelperToolBtn.Size = new System.Drawing.Size(100, 23);
            this.InstallUpdateHelperToolBtn.TabIndex = 2;
            this.InstallUpdateHelperToolBtn.Text = "Install/Update";
            this.InstallUpdateHelperToolBtn.UseVisualStyleBackColor = true;
            this.InstallUpdateHelperToolBtn.Click += new System.EventHandler(this.InstallUpdateHelperToolBtn_Click);
            // 
            // helperToolStatusLabel
            // 
            this.helperToolStatusLabel.AutoSize = true;
            this.helperToolStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.helperToolStatusLabel.Location = new System.Drawing.Point(99, 24);
            this.helperToolStatusLabel.Name = "helperToolStatusLabel";
            this.helperToolStatusLabel.Size = new System.Drawing.Size(57, 13);
            this.helperToolStatusLabel.TabIndex = 1;
            this.helperToolStatusLabel.Text = "Not Found";
            // 
            // helperToolLocalText
            // 
            this.helperToolLocalText.AutoSize = true;
            this.helperToolLocalText.Location = new System.Drawing.Point(6, 24);
            this.helperToolLocalText.Name = "helperToolLocalText";
            this.helperToolLocalText.Size = new System.Drawing.Size(87, 13);
            this.helperToolLocalText.TabIndex = 0;
            this.helperToolLocalText.Text = "Installed Version:";
            // 
            // Fonts
            // 
            this.Fonts.Controls.Add(this.exampleBox);
            this.Fonts.Controls.Add(this.customFontBox);
            this.Fonts.Controls.Add(this.embFontBox);
            this.Fonts.Controls.Add(this.CNFont);
            this.Fonts.Controls.Add(this.label7);
            this.Fonts.Location = new System.Drawing.Point(4, 22);
            this.Fonts.Name = "Fonts";
            this.Fonts.Size = new System.Drawing.Size(584, 303);
            this.Fonts.TabIndex = 2;
            this.Fonts.Text = "Fonts Setup";
            this.Fonts.UseVisualStyleBackColor = true;
            // 
            // exampleBox
            // 
            this.exampleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exampleBox.Location = new System.Drawing.Point(15, 142);
            this.exampleBox.Name = "exampleBox";
            this.exampleBox.ReadOnly = true;
            this.exampleBox.Size = new System.Drawing.Size(556, 150);
            this.exampleBox.TabIndex = 3;
            this.exampleBox.Text = resources.GetString("exampleBox.Text");
            // 
            // customFontBox
            // 
            this.customFontBox.Controls.Add(this.fontFileBrowse);
            this.customFontBox.Controls.Add(this.fontBrowse);
            this.customFontBox.Controls.Add(this.SetupCNFont);
            this.customFontBox.Controls.Add(this.fontInput);
            this.customFontBox.Location = new System.Drawing.Point(182, 36);
            this.customFontBox.Name = "customFontBox";
            this.customFontBox.Size = new System.Drawing.Size(389, 100);
            this.customFontBox.TabIndex = 1;
            this.customFontBox.TabStop = false;
            this.customFontBox.Text = "Custom Font";
            // 
            // fontFileBrowse
            // 
            this.fontFileBrowse.Location = new System.Drawing.Point(106, 65);
            this.fontFileBrowse.Name = "fontFileBrowse";
            this.fontFileBrowse.Size = new System.Drawing.Size(85, 23);
            this.fontFileBrowse.TabIndex = 2;
            this.fontFileBrowse.Text = "Browse File";
            this.fontFileBrowse.UseVisualStyleBackColor = true;
            this.fontFileBrowse.Click += new System.EventHandler(this.fontFileBrowse_Click);
            // 
            // fontBrowse
            // 
            this.fontBrowse.Location = new System.Drawing.Point(15, 65);
            this.fontBrowse.Name = "fontBrowse";
            this.fontBrowse.Size = new System.Drawing.Size(85, 23);
            this.fontBrowse.TabIndex = 1;
            this.fontBrowse.Text = "Browse Fonts";
            this.fontBrowse.UseVisualStyleBackColor = true;
            this.fontBrowse.Click += new System.EventHandler(this.fontBrowse_Click);
            // 
            // SetupCNFont
            // 
            this.SetupCNFont.Location = new System.Drawing.Point(197, 65);
            this.SetupCNFont.Name = "SetupCNFont";
            this.SetupCNFont.Size = new System.Drawing.Size(186, 23);
            this.SetupCNFont.TabIndex = 0;
            this.SetupCNFont.Text = "Install OR Remove pearl.ttf";
            this.SetupCNFont.UseVisualStyleBackColor = true;
            this.SetupCNFont.Click += new System.EventHandler(this.SetupCNFont_Click);
            // 
            // fontInput
            // 
            this.fontInput.Location = new System.Drawing.Point(15, 30);
            this.fontInput.Name = "fontInput";
            this.fontInput.Size = new System.Drawing.Size(368, 20);
            this.fontInput.TabIndex = 0;
            // 
            // embFontBox
            // 
            this.embFontBox.Controls.Add(this.customRadioBtn);
            this.embFontBox.Controls.Add(this.TwcnFontSwitchButton);
            this.embFontBox.Controls.Add(this.ZhcnFontSwitchButton);
            this.embFontBox.Location = new System.Drawing.Point(15, 36);
            this.embFontBox.Name = "embFontBox";
            this.embFontBox.Size = new System.Drawing.Size(161, 100);
            this.embFontBox.TabIndex = 0;
            this.embFontBox.TabStop = false;
            this.embFontBox.Text = "Embedded Fonts";
            // 
            // customRadioBtn
            // 
            this.customRadioBtn.AutoSize = true;
            this.customRadioBtn.Location = new System.Drawing.Point(14, 65);
            this.customRadioBtn.Name = "customRadioBtn";
            this.customRadioBtn.Size = new System.Drawing.Size(84, 17);
            this.customRadioBtn.TabIndex = 0;
            this.customRadioBtn.Text = "Custom Font";
            this.customRadioBtn.UseVisualStyleBackColor = true;
            // 
            // TwcnFontSwitchButton
            // 
            this.TwcnFontSwitchButton.AutoSize = true;
            this.TwcnFontSwitchButton.Checked = true;
            this.TwcnFontSwitchButton.Location = new System.Drawing.Point(14, 42);
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
            this.ZhcnFontSwitchButton.Location = new System.Drawing.Point(14, 19);
            this.ZhcnFontSwitchButton.Name = "ZhcnFontSwitchButton";
            this.ZhcnFontSwitchButton.Size = new System.Drawing.Size(110, 17);
            this.ZhcnFontSwitchButton.TabIndex = 3;
            this.ZhcnFontSwitchButton.Text = "Simplified Chinese";
            this.ZhcnFontSwitchButton.UseVisualStyleBackColor = true;
            // 
            // CNFont
            // 
            this.CNFont.AutoSize = true;
            this.CNFont.ForeColor = System.Drawing.Color.Red;
            this.CNFont.Location = new System.Drawing.Point(82, 11);
            this.CNFont.Name = "CNFont";
            this.CNFont.Size = new System.Drawing.Size(57, 13);
            this.CNFont.TabIndex = 2;
            this.CNFont.Text = "Not Found";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Font Status:";
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
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            // helperToolProcess
            // 
            this.helperToolProcess.StartInfo.Domain = "";
            this.helperToolProcess.StartInfo.LoadUserProfile = false;
            this.helperToolProcess.StartInfo.Password = null;
            this.helperToolProcess.StartInfo.RedirectStandardOutput = true;
            this.helperToolProcess.StartInfo.StandardErrorEncoding = null;
            this.helperToolProcess.StartInfo.StandardOutputEncoding = null;
            this.helperToolProcess.StartInfo.UserName = "";
            this.helperToolProcess.SynchronizingObject = this;
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
            this.advance.ResumeLayout(false);
            this.advOpGroup.ResumeLayout(false);
            this.advOpGroup.PerformLayout();
            this.helperToolCompTab.ResumeLayout(false);
            this.helperToolCompTab.PerformLayout();
            this.Fonts.ResumeLayout(false);
            this.Fonts.PerformLayout();
            this.customFontBox.ResumeLayout(false);
            this.customFontBox.PerformLayout();
            this.embFontBox.ResumeLayout(false);
            this.embFontBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox embFontBox;
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
        private System.Windows.Forms.Button MergeBtn;
        private System.Windows.Forms.Label advancedText;
        private System.Windows.Forms.TabPage advance;
        private System.Windows.Forms.GroupBox helperToolCompTab;
        private System.Windows.Forms.Button InstallUpdateHelperToolBtn;
        private System.Windows.Forms.Label helperToolStatusLabel;
        private System.Windows.Forms.Label helperToolLocalText;
        private System.Windows.Forms.GroupBox advOpGroup;
        private System.Windows.Forms.Label advOpCodeLabel;
        private System.Windows.Forms.ComboBox advOpCodeBox;
        private System.Windows.Forms.Button uninstallHelperToolBtn;
        private System.Windows.Forms.Label helperToolOnlineVerLabel;
        private System.Windows.Forms.Label helperToolOnlineText;
        private System.Windows.Forms.TextBox advOpOutputInput;
        private System.Windows.Forms.Label advOpOutputLabel;
        private System.Windows.Forms.Button advOpSourceBrowseBtn;
        private System.Windows.Forms.TextBox advOpSourceInput;
        private System.Windows.Forms.Label advOpSourceLabel;
        private System.Windows.Forms.Button advOpOutputBrowseBtn;
        private System.Windows.Forms.TextBox advOpAdditionalFile1Input;
        private System.Windows.Forms.Label advOpAdditionalFile1Label;
        private System.Windows.Forms.Button advOpAdditionalFile1BrowseBtn;
        private System.Windows.Forms.ProgressBar advOpProgressBar;
        private System.Windows.Forms.Button executeHelperBtn;
        private System.Windows.Forms.Button advOpAdditionalFile2BrowseBtn;
        private System.Windows.Forms.TextBox advOpAdditionalFile2Input;
        private System.Windows.Forms.Label advOpAdditionalFile2Label;
        private System.Diagnostics.Process helperToolProcess;
        private System.Windows.Forms.Button ScriptsBtn;
        private System.Windows.Forms.TreeView advOpExecTreeView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox customFontBox;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.RichTextBox exampleBox;
        private System.Windows.Forms.Button fontBrowse;
        private System.Windows.Forms.TextBox fontInput;
        private System.Windows.Forms.Button fontFileBrowse;
        private System.Windows.Forms.RadioButton customRadioBtn;
    }
}

