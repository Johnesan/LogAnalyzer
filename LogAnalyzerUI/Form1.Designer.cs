namespace LogAnalyzerUI
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectedDirectory = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toSizeSearch = new System.Windows.Forms.TextBox();
            this.fromSizeSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.LogFiles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.duplicateLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.uniqueErrorsLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.duplicateErrorsLabel = new System.Windows.Forms.Label();
            this.uniqueErrorLabel = new System.Windows.Forms.Label();
            this.totalLogsLabel = new System.Windows.Forms.Label();
            this.archivesLabel = new System.Windows.Forms.Label();
            this.contentLabel = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.archiveList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.deleteArchiveButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.deleteArchiveFrom = new System.Windows.Forms.DateTimePicker();
            this.deleteArchiveTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.createArchiveFrom = new System.Windows.Forms.DateTimePicker();
            this.createArchiveTo = new System.Windows.Forms.DateTimePicker();
            this.createArchiveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectedDirectory);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(224, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1127, 485);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // selectedDirectory
            // 
            this.selectedDirectory.AutoSize = true;
            this.selectedDirectory.Location = new System.Drawing.Point(549, 63);
            this.selectedDirectory.Name = "selectedDirectory";
            this.selectedDirectory.Size = new System.Drawing.Size(70, 25);
            this.selectedDirectory.TabIndex = 1;
            this.selectedDirectory.Text = "label7";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.toSizeSearch);
            this.groupBox3.Controls.Add(this.fromSizeSearch);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(568, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 357);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "By Size";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 54);
            this.button3.TabIndex = 14;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "To Size:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "From Size:";
            // 
            // toSizeSearch
            // 
            this.toSizeSearch.Location = new System.Drawing.Point(196, 185);
            this.toSizeSearch.Name = "toSizeSearch";
            this.toSizeSearch.Size = new System.Drawing.Size(140, 31);
            this.toSizeSearch.TabIndex = 5;
            // 
            // fromSizeSearch
            // 
            this.fromSizeSearch.Location = new System.Drawing.Point(196, 123);
            this.fromSizeSearch.Name = "fromSizeSearch";
            this.fromSizeSearch.Size = new System.Drawing.Size(140, 31);
            this.fromSizeSearch.TabIndex = 4;
            this.fromSizeSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "kb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "kb";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Log Directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Location = new System.Drawing.Point(38, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 357);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "By Date";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 54);
            this.button2.TabIndex = 13;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "To Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "From Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(204, 197);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tabControl1);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.archivesLabel);
            this.groupBox5.Controls.Add(this.totalLogsLabel);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(30, 586);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1645, 748);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Result";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(8, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1469, 694);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Upload to API";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox8);
            this.tabPage7.Controls.Add(this.groupBox7);
            this.tabPage7.Controls.Add(this.listView2);
            this.tabPage7.Location = new System.Drawing.Point(8, 39);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1469, 694);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Archives";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1469, 694);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Log Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LogFiles});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 17);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(457, 610);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // LogFiles
            // 
            this.LogFiles.Text = "Log Files";
            this.LogFiles.Width = 150;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.contentLabel);
            this.groupBox4.Location = new System.Drawing.Point(495, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(610, 611);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Content";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.duplicateErrorsLabel);
            this.groupBox6.Controls.Add(this.duplicateLabel);
            this.groupBox6.Controls.Add(this.uniqueErrorLabel);
            this.groupBox6.Controls.Add(this.uniqueErrorsLabel);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Location = new System.Drawing.Point(1138, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(313, 505);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Statistics";
            // 
            // duplicateLabel
            // 
            this.duplicateLabel.AutoSize = true;
            this.duplicateLabel.Location = new System.Drawing.Point(6, 56);
            this.duplicateLabel.Name = "duplicateLabel";
            this.duplicateLabel.Size = new System.Drawing.Size(289, 25);
            this.duplicateLabel.TabIndex = 8;
            this.duplicateLabel.Text = "Number of Duplicated Errors:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(-159, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(143, 25);
            this.label18.TabIndex = 10;
            this.label18.Text = "Total of Logs:";
            // 
            // uniqueErrorsLabel
            // 
            this.uniqueErrorsLabel.AutoSize = true;
            this.uniqueErrorsLabel.Location = new System.Drawing.Point(6, 149);
            this.uniqueErrorsLabel.Name = "uniqueErrorsLabel";
            this.uniqueErrorsLabel.Size = new System.Drawing.Size(255, 25);
            this.uniqueErrorsLabel.TabIndex = 12;
            this.uniqueErrorsLabel.Text = "Number of Unique Errors:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(443, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Number of Archives:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Total Number of Logs:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(48, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1485, 741);
            this.tabControl1.TabIndex = 0;
            // 
            // duplicateErrorsLabel
            // 
            this.duplicateErrorsLabel.AutoSize = true;
            this.duplicateErrorsLabel.Location = new System.Drawing.Point(50, 100);
            this.duplicateErrorsLabel.Name = "duplicateErrorsLabel";
            this.duplicateErrorsLabel.Size = new System.Drawing.Size(19, 25);
            this.duplicateErrorsLabel.TabIndex = 16;
            this.duplicateErrorsLabel.Text = "-";
            // 
            // uniqueErrorLabel
            // 
            this.uniqueErrorLabel.AutoSize = true;
            this.uniqueErrorLabel.Location = new System.Drawing.Point(50, 196);
            this.uniqueErrorLabel.Name = "uniqueErrorLabel";
            this.uniqueErrorLabel.Size = new System.Drawing.Size(19, 25);
            this.uniqueErrorLabel.TabIndex = 17;
            this.uniqueErrorLabel.Text = "-";
            // 
            // totalLogsLabel
            // 
            this.totalLogsLabel.AutoSize = true;
            this.totalLogsLabel.Location = new System.Drawing.Point(285, 64);
            this.totalLogsLabel.Name = "totalLogsLabel";
            this.totalLogsLabel.Size = new System.Drawing.Size(19, 25);
            this.totalLogsLabel.TabIndex = 18;
            this.totalLogsLabel.Text = "-";
            // 
            // archivesLabel
            // 
            this.archivesLabel.AutoSize = true;
            this.archivesLabel.Location = new System.Drawing.Point(665, 64);
            this.archivesLabel.Name = "archivesLabel";
            this.archivesLabel.Size = new System.Drawing.Size(19, 25);
            this.archivesLabel.TabIndex = 19;
            this.archivesLabel.Text = "-";
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(35, 46);
            this.contentLabel.MaximumSize = new System.Drawing.Size(100, 0);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(19, 25);
            this.contentLabel.TabIndex = 0;
            this.contentLabel.Text = "-";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.archiveList});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 12);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(457, 610);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // archiveList
            // 
            this.archiveList.Text = "Archive List";
            this.archiveList.Width = 150;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.deleteArchiveFrom);
            this.groupBox7.Controls.Add(this.deleteArchiveTo);
            this.groupBox7.Controls.Add(this.deleteArchiveButton);
            this.groupBox7.Location = new System.Drawing.Point(959, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(461, 364);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Delete Archives";
            // 
            // deleteArchiveButton
            // 
            this.deleteArchiveButton.Location = new System.Drawing.Point(237, 259);
            this.deleteArchiveButton.Name = "deleteArchiveButton";
            this.deleteArchiveButton.Size = new System.Drawing.Size(162, 54);
            this.deleteArchiveButton.TabIndex = 0;
            this.deleteArchiveButton.Text = "Delete";
            this.deleteArchiveButton.UseVisualStyleBackColor = true;
            this.deleteArchiveButton.Click += new System.EventHandler(this.deleteArchiveButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "To Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "From Date:";
            // 
            // deleteArchiveFrom
            // 
            this.deleteArchiveFrom.Location = new System.Drawing.Point(199, 102);
            this.deleteArchiveFrom.Name = "deleteArchiveFrom";
            this.deleteArchiveFrom.Size = new System.Drawing.Size(200, 31);
            this.deleteArchiveFrom.TabIndex = 7;
            // 
            // deleteArchiveTo
            // 
            this.deleteArchiveTo.Location = new System.Drawing.Point(199, 176);
            this.deleteArchiveTo.Name = "deleteArchiveTo";
            this.deleteArchiveTo.Size = new System.Drawing.Size(200, 31);
            this.deleteArchiveTo.TabIndex = 8;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.createArchiveFrom);
            this.groupBox8.Controls.Add(this.createArchiveTo);
            this.groupBox8.Controls.Add(this.createArchiveButton);
            this.groupBox8.Location = new System.Drawing.Point(480, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(442, 364);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Create Archive";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 25);
            this.label13.TabIndex = 10;
            this.label13.Text = "To Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 25);
            this.label14.TabIndex = 9;
            this.label14.Text = "From Date:";
            // 
            // createArchiveFrom
            // 
            this.createArchiveFrom.Location = new System.Drawing.Point(199, 102);
            this.createArchiveFrom.Name = "createArchiveFrom";
            this.createArchiveFrom.Size = new System.Drawing.Size(200, 31);
            this.createArchiveFrom.TabIndex = 7;
            // 
            // createArchiveTo
            // 
            this.createArchiveTo.Location = new System.Drawing.Point(199, 176);
            this.createArchiveTo.Name = "createArchiveTo";
            this.createArchiveTo.Size = new System.Drawing.Size(200, 31);
            this.createArchiveTo.TabIndex = 8;
            // 
            // createArchiveButton
            // 
            this.createArchiveButton.Location = new System.Drawing.Point(237, 259);
            this.createArchiveButton.Name = "createArchiveButton";
            this.createArchiveButton.Size = new System.Drawing.Size(162, 54);
            this.createArchiveButton.TabIndex = 0;
            this.createArchiveButton.Text = "Create";
            this.createArchiveButton.UseVisualStyleBackColor = true;
            this.createArchiveButton.Click += new System.EventHandler(this.createArchiveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 1346);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox fromSizeSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox toSizeSearch;
        private System.Windows.Forms.Label selectedDirectory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label archivesLabel;
        private System.Windows.Forms.Label totalLogsLabel;
        private System.Windows.Forms.Label uniqueErrorLabel;
        private System.Windows.Forms.Label duplicateErrorsLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label uniqueErrorsLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label duplicateLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader LogFiles;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker deleteArchiveFrom;
        private System.Windows.Forms.DateTimePicker deleteArchiveTo;
        private System.Windows.Forms.Button deleteArchiveButton;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader archiveList;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker createArchiveFrom;
        private System.Windows.Forms.DateTimePicker createArchiveTo;
        private System.Windows.Forms.Button createArchiveButton;
    }
}

