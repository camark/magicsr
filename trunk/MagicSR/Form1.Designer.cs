namespace MagicSR
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_SearchInResult = new System.Windows.Forms.CheckBox();
            this.chb_WholeWord = new System.Windows.Forms.CheckBox();
            this.chk_Case = new System.Windows.Forms.CheckBox();
            this.cbb_FileMatch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rb_Single = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lv_SearchFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.lsb_SearchResult = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbb_Query = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_SR_Replace = new System.Windows.Forms.Button();
            this.btn_SR_Search = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lv_SR_SearchResult = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.lsb_SR_FileList = new System.Windows.Forms.ListBox();
            this.tb_SR_Replace = new System.Windows.Forms.TextBox();
            this.lbl_TxtReplace = new System.Windows.Forms.Label();
            this.tb_SR_Search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Modify_Replace = new System.Windows.Forms.RadioButton();
            this.rb_Modify_None = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chk_CreateBackup = new System.Windows.Forms.CheckBox();
            this.chk_SearchSubFolder = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.bgw_Find = new System.ComponentModel.BackgroundWorker();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_CancelFind = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_SearchInResult);
            this.panel1.Controls.Add(this.chb_WholeWord);
            this.panel1.Controls.Add(this.chk_Case);
            this.panel1.Controls.Add(this.cbb_FileMatch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.tb_Path);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 101);
            this.panel1.TabIndex = 1;
            // 
            // chk_SearchInResult
            // 
            this.chk_SearchInResult.AutoSize = true;
            this.chk_SearchInResult.Location = new System.Drawing.Point(275, 75);
            this.chk_SearchInResult.Name = "chk_SearchInResult";
            this.chk_SearchInResult.Size = new System.Drawing.Size(104, 17);
            this.chk_SearchInResult.TabIndex = 7;
            this.chk_SearchInResult.Text = "Search in Result";
            this.chk_SearchInResult.UseVisualStyleBackColor = true;
            // 
            // chb_WholeWord
            // 
            this.chb_WholeWord.AutoSize = true;
            this.chb_WholeWord.Location = new System.Drawing.Point(173, 74);
            this.chb_WholeWord.Name = "chb_WholeWord";
            this.chb_WholeWord.Size = new System.Drawing.Size(86, 17);
            this.chb_WholeWord.TabIndex = 6;
            this.chb_WholeWord.Text = "Whole Word";
            this.chb_WholeWord.UseVisualStyleBackColor = true;
            // 
            // chk_Case
            // 
            this.chk_Case.AutoSize = true;
            this.chk_Case.Location = new System.Drawing.Point(62, 74);
            this.chk_Case.Name = "chk_Case";
            this.chk_Case.Size = new System.Drawing.Size(105, 17);
            this.chk_Case.TabIndex = 5;
            this.chk_Case.Text = "Case Sensenses";
            this.chk_Case.UseVisualStyleBackColor = true;
            // 
            // cbb_FileMatch
            // 
            this.cbb_FileMatch.FormattingEnabled = true;
            this.cbb_FileMatch.Items.AddRange(new object[] {
            "*.txt",
            "*.htm",
            "*.html"});
            this.cbb_FileMatch.Location = new System.Drawing.Point(60, 45);
            this.cbb_FileMatch.Name = "cbb_FileMatch";
            this.cbb_FileMatch.Size = new System.Drawing.Size(229, 21);
            this.cbb_FileMatch.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Match";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(508, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(63, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tb_Path
            // 
            this.tb_Path.Location = new System.Drawing.Point(60, 19);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.Size = new System.Drawing.Size(435, 20);
            this.tb_Path.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(0, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 441);
            this.panel2.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(630, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_CancelFind);
            this.tabPage1.Controls.Add(this.rb_Single);
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cbb_Query);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(622, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Find";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rb_Single
            // 
            this.rb_Single.AutoSize = true;
            this.rb_Single.Checked = true;
            this.rb_Single.Location = new System.Drawing.Point(78, 12);
            this.rb_Single.Name = "rb_Single";
            this.rb_Single.Size = new System.Drawing.Size(61, 17);
            this.rb_Single.TabIndex = 5;
            this.rb_Single.TabStop = true;
            this.rb_Single.Text = "Phrurse";
            this.rb_Single.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(5, 102);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lv_SearchFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lsb_SearchResult);
            this.splitContainer1.Size = new System.Drawing.Size(615, 316);
            this.splitContainer1.SplitterDistance = 108;
            this.splitContainer1.TabIndex = 4;
            // 
            // lv_SearchFiles
            // 
            this.lv_SearchFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_SearchFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_SearchFiles.FullRowSelect = true;
            this.lv_SearchFiles.Location = new System.Drawing.Point(5, 6);
            this.lv_SearchFiles.Name = "lv_SearchFiles";
            this.lv_SearchFiles.Size = new System.Drawing.Size(609, 99);
            this.lv_SearchFiles.TabIndex = 0;
            this.lv_SearchFiles.UseCompatibleStateImageBehavior = false;
            this.lv_SearchFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FileName";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FilePath";
            this.columnHeader2.Width = 277;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Find Count";
            this.columnHeader3.Width = 159;
            // 
            // lsb_SearchResult
            // 
            this.lsb_SearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lsb_SearchResult.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lsb_SearchResult.FormattingEnabled = true;
            this.lsb_SearchResult.HorizontalScrollbar = true;
            this.lsb_SearchResult.Location = new System.Drawing.Point(5, 3);
            this.lsb_SearchResult.Name = "lsb_SearchResult";
            this.lsb_SearchResult.Size = new System.Drawing.Size(608, 186);
            this.lsb_SearchResult.TabIndex = 0;
            this.lsb_SearchResult.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lsb_SearchResult_DrawItem);
            this.lsb_SearchResult.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lsb_SearchResult_MeasureItem);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbb_Query
            // 
            this.cbb_Query.FormattingEnabled = true;
            this.cbb_Query.Location = new System.Drawing.Point(78, 38);
            this.cbb_Query.Name = "cbb_Query";
            this.cbb_Query.Size = new System.Drawing.Size(441, 21);
            this.cbb_Query.TabIndex = 2;
            this.cbb_Query.Text = "ed2k";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Query";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_SR_Replace);
            this.tabPage2.Controls.Add(this.btn_SR_Search);
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Controls.Add(this.tb_SR_Replace);
            this.tabPage2.Controls.Add(this.lbl_TxtReplace);
            this.tabPage2.Controls.Add(this.tb_SR_Search);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(622, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Replace";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_SR_Replace
            // 
            this.btn_SR_Replace.Enabled = false;
            this.btn_SR_Replace.Location = new System.Drawing.Point(497, 98);
            this.btn_SR_Replace.Name = "btn_SR_Replace";
            this.btn_SR_Replace.Size = new System.Drawing.Size(75, 23);
            this.btn_SR_Replace.TabIndex = 8;
            this.btn_SR_Replace.Text = "Replace";
            this.btn_SR_Replace.UseVisualStyleBackColor = true;
            this.btn_SR_Replace.Click += new System.EventHandler(this.btn_SR_Replace_Click);
            // 
            // btn_SR_Search
            // 
            this.btn_SR_Search.Location = new System.Drawing.Point(497, 63);
            this.btn_SR_Search.Name = "btn_SR_Search";
            this.btn_SR_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_SR_Search.TabIndex = 7;
            this.btn_SR_Search.Text = "Search";
            this.btn_SR_Search.UseVisualStyleBackColor = true;
            this.btn_SR_Search.Click += new System.EventHandler(this.btn_SR_Search_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(18, 130);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lv_SR_SearchResult);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lsb_SR_FileList);
            this.splitContainer2.Size = new System.Drawing.Size(548, 234);
            this.splitContainer2.SplitterDistance = 100;
            this.splitContainer2.TabIndex = 6;
            // 
            // lv_SR_SearchResult
            // 
            this.lv_SR_SearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_SR_SearchResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_SR_SearchResult.FullRowSelect = true;
            this.lv_SR_SearchResult.Location = new System.Drawing.Point(6, 6);
            this.lv_SR_SearchResult.Name = "lv_SR_SearchResult";
            this.lv_SR_SearchResult.Size = new System.Drawing.Size(541, 89);
            this.lv_SR_SearchResult.TabIndex = 0;
            this.lv_SR_SearchResult.UseCompatibleStateImageBehavior = false;
            this.lv_SR_SearchResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "FileName";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "File Path";
            this.columnHeader5.Width = 296;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "FindCount";
            this.columnHeader6.Width = 450;
            // 
            // lsb_SR_FileList
            // 
            this.lsb_SR_FileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lsb_SR_FileList.FormattingEnabled = true;
            this.lsb_SR_FileList.Location = new System.Drawing.Point(5, 5);
            this.lsb_SR_FileList.Name = "lsb_SR_FileList";
            this.lsb_SR_FileList.Size = new System.Drawing.Size(541, 121);
            this.lsb_SR_FileList.TabIndex = 0;
            // 
            // tb_SR_Replace
            // 
            this.tb_SR_Replace.Enabled = false;
            this.tb_SR_Replace.Location = new System.Drawing.Point(93, 101);
            this.tb_SR_Replace.Name = "tb_SR_Replace";
            this.tb_SR_Replace.Size = new System.Drawing.Size(398, 20);
            this.tb_SR_Replace.TabIndex = 5;
            // 
            // lbl_TxtReplace
            // 
            this.lbl_TxtReplace.AutoSize = true;
            this.lbl_TxtReplace.Enabled = false;
            this.lbl_TxtReplace.Location = new System.Drawing.Point(13, 104);
            this.lbl_TxtReplace.Name = "lbl_TxtReplace";
            this.lbl_TxtReplace.Size = new System.Drawing.Size(74, 13);
            this.lbl_TxtReplace.TabIndex = 4;
            this.lbl_TxtReplace.Text = "Text Replace:";
            // 
            // tb_SR_Search
            // 
            this.tb_SR_Search.Location = new System.Drawing.Point(93, 66);
            this.tb_SR_Search.Name = "tb_SR_Search";
            this.tb_SR_Search.Size = new System.Drawing.Size(398, 20);
            this.tb_SR_Search.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Text Search:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Modify_Replace);
            this.groupBox2.Controls.Add(this.rb_Modify_None);
            this.groupBox2.Location = new System.Drawing.Point(262, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modify Option";
            // 
            // rb_Modify_Replace
            // 
            this.rb_Modify_Replace.AutoSize = true;
            this.rb_Modify_Replace.Location = new System.Drawing.Point(75, 19);
            this.rb_Modify_Replace.Name = "rb_Modify_Replace";
            this.rb_Modify_Replace.Size = new System.Drawing.Size(65, 17);
            this.rb_Modify_Replace.TabIndex = 1;
            this.rb_Modify_Replace.Text = "Replace";
            this.rb_Modify_Replace.UseVisualStyleBackColor = true;
            this.rb_Modify_Replace.CheckedChanged += new System.EventHandler(this.rb_Modify_Replace_CheckedChanged);
            // 
            // rb_Modify_None
            // 
            this.rb_Modify_None.AutoSize = true;
            this.rb_Modify_None.Checked = true;
            this.rb_Modify_None.Location = new System.Drawing.Point(12, 19);
            this.rb_Modify_None.Name = "rb_Modify_None";
            this.rb_Modify_None.Size = new System.Drawing.Size(51, 17);
            this.rb_Modify_None.TabIndex = 0;
            this.rb_Modify_None.TabStop = true;
            this.rb_Modify_None.Text = "None";
            this.rb_Modify_None.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Option";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chk_CreateBackup);
            this.tabPage3.Controls.Add(this.chk_SearchSubFolder);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(622, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Option";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chk_CreateBackup
            // 
            this.chk_CreateBackup.AutoSize = true;
            this.chk_CreateBackup.Location = new System.Drawing.Point(217, 19);
            this.chk_CreateBackup.Name = "chk_CreateBackup";
            this.chk_CreateBackup.Size = new System.Drawing.Size(174, 17);
            this.chk_CreateBackup.TabIndex = 1;
            this.chk_CreateBackup.Text = "Create Backup Before Replace";
            this.chk_CreateBackup.UseVisualStyleBackColor = true;
            // 
            // chk_SearchSubFolder
            // 
            this.chk_SearchSubFolder.AutoSize = true;
            this.chk_SearchSubFolder.Checked = true;
            this.chk_SearchSubFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_SearchSubFolder.Location = new System.Drawing.Point(22, 20);
            this.chk_SearchSubFolder.Name = "chk_SearchSubFolder";
            this.chk_SearchSubFolder.Size = new System.Drawing.Size(148, 17);
            this.chk_SearchSubFolder.TabIndex = 0;
            this.chk_SearchSubFolder.Text = "Search include SubFolder";
            this.chk_SearchSubFolder.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(630, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // bgw_Find
            // 
            this.bgw_Find.WorkerReportsProgress = true;
            this.bgw_Find.WorkerSupportsCancellation = true;
            this.bgw_Find.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.bgw_Find.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_Find_RunWorkerCompleted);
            this.bgw_Find.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_Find_ProgressChanged);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(580, 17);
            this.tssStatus.Spring = true;
            // 
            // btn_CancelFind
            // 
            this.btn_CancelFind.Location = new System.Drawing.Point(130, 70);
            this.btn_CancelFind.Name = "btn_CancelFind";
            this.btn_CancelFind.Size = new System.Drawing.Size(75, 23);
            this.btn_CancelFind.TabIndex = 6;
            this.btn_CancelFind.Text = "Cancel";
            this.btn_CancelFind.UseVisualStyleBackColor = true;
            this.btn_CancelFind.Click += new System.EventHandler(this.btn_CancelFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 604);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Magic Search & Replace";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tb_Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbb_Query;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lv_SearchFiles;
        private System.Windows.Forms.ListBox lsb_SearchResult;
        private System.Windows.Forms.ComboBox cbb_FileMatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.CheckBox chk_Case;
        private System.Windows.Forms.CheckBox chb_WholeWord;
        private System.Windows.Forms.CheckBox chk_SearchInResult;
        private System.Windows.Forms.RadioButton rb_Single;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_TxtReplace;
        private System.Windows.Forms.TextBox tb_SR_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_SR_Replace;
        private System.Windows.Forms.RadioButton rb_Modify_Replace;
        private System.Windows.Forms.RadioButton rb_Modify_None;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView lv_SR_SearchResult;
        private System.Windows.Forms.ListBox lsb_SR_FileList;
        private System.Windows.Forms.Button btn_SR_Search;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btn_SR_Replace;
        private System.Windows.Forms.CheckBox chk_CreateBackup;
        private System.Windows.Forms.CheckBox chk_SearchSubFolder;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.ComponentModel.BackgroundWorker bgw_Find;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.Button btn_CancelFind;
    }
}

