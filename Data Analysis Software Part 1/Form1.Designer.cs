namespace Data_Analysis_Software_Part_1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.setFTPButton = new System.Windows.Forms.Button();
            this.setBPMButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.powerTrackBar = new System.Windows.Forms.TrackBar();
            this.heartRateTrackBar = new System.Windows.Forms.TrackBar();
            this.fTPTextBox = new System.Windows.Forms.TextBox();
            this.heartRateMaxTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.speedSelectLabel = new System.Windows.Forms.Label();
            this.measurementTrackBar = new System.Windows.Forms.TrackBar();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.powerAverageLabel = new System.Windows.Forms.Label();
            this.heartRateAverageLabel = new System.Windows.Forms.Label();
            this.altitudeAverageLabel = new System.Windows.Forms.Label();
            this.speedAverageLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tablePage = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.summaryPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.heartRateMaximumLabel = new System.Windows.Forms.Label();
            this.heartRateMinimumLabel = new System.Windows.Forms.Label();
            this.speedMaximumLabel = new System.Windows.Forms.Label();
            this.totalDistanceLabel = new System.Windows.Forms.Label();
            this.powerMaximumLabel = new System.Windows.Forms.Label();
            this.altitudeMaximumLabel = new System.Windows.Forms.Label();
            this.graphPage1 = new System.Windows.Forms.TabPage();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.graphPage2 = new System.Windows.Forms.TabPage();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeartRates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cadence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBPIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartRateTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementTrackBar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tablePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.summaryPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.graphPage1.SuspendLayout();
            this.graphPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.setFTPButton);
            this.panel1.Controls.Add(this.setBPMButton);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.powerTrackBar);
            this.panel1.Controls.Add(this.heartRateTrackBar);
            this.panel1.Controls.Add(this.fTPTextBox);
            this.panel1.Controls.Add(this.heartRateMaxTextBox);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.speedSelectLabel);
            this.panel1.Controls.Add(this.measurementTrackBar);
            this.panel1.Controls.Add(this.intervalLabel);
            this.panel1.Controls.Add(this.startTimeLabel);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 83);
            this.panel1.TabIndex = 1;
            // 
            // setFTPButton
            // 
            this.setFTPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setFTPButton.Location = new System.Drawing.Point(562, 50);
            this.setFTPButton.Name = "setFTPButton";
            this.setFTPButton.Size = new System.Drawing.Size(60, 25);
            this.setFTPButton.TabIndex = 23;
            this.setFTPButton.Text = "Set FTP";
            this.setFTPButton.UseVisualStyleBackColor = true;
            this.setFTPButton.Click += new System.EventHandler(this.setFTPButton_Click);
            // 
            // setBPMButton
            // 
            this.setBPMButton.Location = new System.Drawing.Point(340, 50);
            this.setBPMButton.Name = "setBPMButton";
            this.setBPMButton.Size = new System.Drawing.Size(60, 25);
            this.setBPMButton.TabIndex = 22;
            this.setBPMButton.Text = "Set BPM";
            this.setBPMButton.UseVisualStyleBackColor = true;
            this.setBPMButton.Click += new System.EventHandler(this.setBPMButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(606, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 12);
            this.label14.TabIndex = 21;
            this.label14.Text = "W";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(379, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 12);
            this.label17.TabIndex = 20;
            this.label17.Text = "BPM";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(691, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 12);
            this.label16.TabIndex = 19;
            this.label16.Text = "Watts  /  %";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(464, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 12);
            this.label15.TabIndex = 18;
            this.label15.Text = "BPM  /  %";
            // 
            // powerTrackBar
            // 
            this.powerTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.powerTrackBar.Location = new System.Drawing.Point(688, 21);
            this.powerTrackBar.Maximum = 1;
            this.powerTrackBar.Name = "powerTrackBar";
            this.powerTrackBar.Size = new System.Drawing.Size(58, 45);
            this.powerTrackBar.TabIndex = 17;
            this.powerTrackBar.ValueChanged += new System.EventHandler(this.PowerTrackBar_ValueChanged);
            // 
            // heartRateTrackBar
            // 
            this.heartRateTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.heartRateTrackBar.Location = new System.Drawing.Point(457, 21);
            this.heartRateTrackBar.Maximum = 1;
            this.heartRateTrackBar.Name = "heartRateTrackBar";
            this.heartRateTrackBar.Size = new System.Drawing.Size(58, 45);
            this.heartRateTrackBar.TabIndex = 16;
            this.heartRateTrackBar.ValueChanged += new System.EventHandler(this.HeartRateTrackBar_ValueChanged);
            // 
            // fTPTextBox
            // 
            this.fTPTextBox.Location = new System.Drawing.Point(563, 24);
            this.fTPTextBox.MaxLength = 4;
            this.fTPTextBox.Name = "fTPTextBox";
            this.fTPTextBox.Size = new System.Drawing.Size(41, 20);
            this.fTPTextBox.TabIndex = 14;
            // 
            // heartRateMaxTextBox
            // 
            this.heartRateMaxTextBox.Location = new System.Drawing.Point(341, 24);
            this.heartRateMaxTextBox.MaxLength = 3;
            this.heartRateMaxTextBox.Name = "heartRateMaxTextBox";
            this.heartRateMaxTextBox.Size = new System.Drawing.Size(38, 20);
            this.heartRateMaxTextBox.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 12);
            this.label13.TabIndex = 11;
            this.label13.Text = "Interval:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 12);
            this.label12.TabIndex = 10;
            this.label12.Text = "Start Time:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "Date:";
            // 
            // speedSelectLabel
            // 
            this.speedSelectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.speedSelectLabel.AutoSize = true;
            this.speedSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedSelectLabel.Location = new System.Drawing.Point(240, 54);
            this.speedSelectLabel.Name = "speedSelectLabel";
            this.speedSelectLabel.Size = new System.Drawing.Size(72, 12);
            this.speedSelectLabel.TabIndex = 8;
            this.speedSelectLabel.Text = "Metric / Imperial";
            // 
            // measurementTrackBar
            // 
            this.measurementTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.measurementTrackBar.Location = new System.Drawing.Point(246, 21);
            this.measurementTrackBar.Maximum = 1;
            this.measurementTrackBar.Name = "measurementTrackBar";
            this.measurementTrackBar.Size = new System.Drawing.Size(58, 45);
            this.measurementTrackBar.TabIndex = 3;
            this.measurementTrackBar.ValueChanged += new System.EventHandler(this.measurementTrackBar_ValueChanged);
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(99, 62);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(47, 13);
            this.intervalLabel.TabIndex = 2;
            this.intervalLabel.Text = "(interval)";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(99, 38);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(55, 13);
            this.startTimeLabel.TabIndex = 1;
            this.startTimeLabel.Text = "(start time)";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(99, 12);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(34, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "(date)";
            // 
            // powerAverageLabel
            // 
            this.powerAverageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.powerAverageLabel.AutoSize = true;
            this.powerAverageLabel.Location = new System.Drawing.Point(495, 179);
            this.powerAverageLabel.Name = "powerAverageLabel";
            this.powerAverageLabel.Size = new System.Drawing.Size(84, 13);
            this.powerAverageLabel.TabIndex = 7;
            this.powerAverageLabel.Text = "(average power)";
            // 
            // heartRateAverageLabel
            // 
            this.heartRateAverageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heartRateAverageLabel.AutoSize = true;
            this.heartRateAverageLabel.Location = new System.Drawing.Point(487, 93);
            this.heartRateAverageLabel.Name = "heartRateAverageLabel";
            this.heartRateAverageLabel.Size = new System.Drawing.Size(100, 13);
            this.heartRateAverageLabel.TabIndex = 6;
            this.heartRateAverageLabel.Text = "(average heart rate)";
            // 
            // altitudeAverageLabel
            // 
            this.altitudeAverageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.altitudeAverageLabel.AutoSize = true;
            this.altitudeAverageLabel.Location = new System.Drawing.Point(492, 238);
            this.altitudeAverageLabel.Name = "altitudeAverageLabel";
            this.altitudeAverageLabel.Size = new System.Drawing.Size(89, 13);
            this.altitudeAverageLabel.TabIndex = 5;
            this.altitudeAverageLabel.Text = "(average altitude)";
            // 
            // speedAverageLabel
            // 
            this.speedAverageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speedAverageLabel.AutoSize = true;
            this.speedAverageLabel.Location = new System.Drawing.Point(495, 34);
            this.speedAverageLabel.Name = "speedAverageLabel";
            this.speedAverageLabel.Size = new System.Drawing.Size(84, 13);
            this.speedAverageLabel.TabIndex = 3;
            this.speedAverageLabel.Text = "(average speed)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tablePage);
            this.tabControl1.Controls.Add(this.summaryPage);
            this.tabControl1.Controls.Add(this.graphPage1);
            this.tabControl1.Controls.Add(this.graphPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 107);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 326);
            this.tabControl1.TabIndex = 2;
            // 
            // tablePage
            // 
            this.tablePage.Controls.Add(this.dataGridView);
            this.tablePage.Location = new System.Drawing.Point(4, 22);
            this.tablePage.Name = "tablePage";
            this.tablePage.Padding = new System.Windows.Forms.Padding(3);
            this.tablePage.Size = new System.Drawing.Size(750, 300);
            this.tablePage.TabIndex = 0;
            this.tablePage.Text = "Table";
            this.tablePage.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.HeartRates,
            this.Speed,
            this.Cadence,
            this.Altitude,
            this.Power,
            this.PBPIndex});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(744, 294);
            this.dataGridView.TabIndex = 0;
            // 
            // summaryPage
            // 
            this.summaryPage.Controls.Add(this.tableLayoutPanel1);
            this.summaryPage.Location = new System.Drawing.Point(4, 22);
            this.summaryPage.Name = "summaryPage";
            this.summaryPage.Padding = new System.Windows.Forms.Padding(3);
            this.summaryPage.Size = new System.Drawing.Size(722, 300);
            this.summaryPage.TabIndex = 1;
            this.summaryPage.Text = "Summary";
            this.summaryPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.heartRateAverageLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.powerAverageLabel, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.speedAverageLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.altitudeAverageLabel, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.heartRateMaximumLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.heartRateMinimumLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.speedMaximumLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.totalDistanceLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.powerMaximumLabel, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.altitudeMaximumLabel, 1, 12);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.405941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.405941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.405941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.980198F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.405941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.405941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.405941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.980198F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.405941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.405941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.980198F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.405941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.405941F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 294);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Distance Covered";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average Speed";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maximum Speed";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average Heart Rate";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maximum Heart Rate";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Minimum Heart Rate";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Average Power";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Maximum Power";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Average Altitude";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(134, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Maximum Altitude";
            // 
            // heartRateMaximumLabel
            // 
            this.heartRateMaximumLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heartRateMaximumLabel.AutoSize = true;
            this.heartRateMaximumLabel.Location = new System.Drawing.Point(485, 120);
            this.heartRateMaximumLabel.Name = "heartRateMaximumLabel";
            this.heartRateMaximumLabel.Size = new System.Drawing.Size(104, 13);
            this.heartRateMaximumLabel.TabIndex = 10;
            this.heartRateMaximumLabel.Text = "(maximum heart rate)";
            // 
            // heartRateMinimumLabel
            // 
            this.heartRateMinimumLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heartRateMinimumLabel.AutoSize = true;
            this.heartRateMinimumLabel.Location = new System.Drawing.Point(486, 147);
            this.heartRateMinimumLabel.Name = "heartRateMinimumLabel";
            this.heartRateMinimumLabel.Size = new System.Drawing.Size(101, 13);
            this.heartRateMinimumLabel.TabIndex = 11;
            this.heartRateMinimumLabel.Text = "(minimum heart rate)";
            // 
            // speedMaximumLabel
            // 
            this.speedMaximumLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speedMaximumLabel.AutoSize = true;
            this.speedMaximumLabel.Location = new System.Drawing.Point(493, 61);
            this.speedMaximumLabel.Name = "speedMaximumLabel";
            this.speedMaximumLabel.Size = new System.Drawing.Size(88, 13);
            this.speedMaximumLabel.TabIndex = 12;
            this.speedMaximumLabel.Text = "(maximum speed)";
            // 
            // totalDistanceLabel
            // 
            this.totalDistanceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalDistanceLabel.AutoSize = true;
            this.totalDistanceLabel.Location = new System.Drawing.Point(499, 7);
            this.totalDistanceLabel.Name = "totalDistanceLabel";
            this.totalDistanceLabel.Size = new System.Drawing.Size(76, 13);
            this.totalDistanceLabel.TabIndex = 13;
            this.totalDistanceLabel.Text = "(total distance)";
            // 
            // powerMaximumLabel
            // 
            this.powerMaximumLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.powerMaximumLabel.AutoSize = true;
            this.powerMaximumLabel.Location = new System.Drawing.Point(493, 206);
            this.powerMaximumLabel.Name = "powerMaximumLabel";
            this.powerMaximumLabel.Size = new System.Drawing.Size(88, 13);
            this.powerMaximumLabel.TabIndex = 14;
            this.powerMaximumLabel.Text = "(maximum power)";
            // 
            // altitudeMaximumLabel
            // 
            this.altitudeMaximumLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.altitudeMaximumLabel.AutoSize = true;
            this.altitudeMaximumLabel.Location = new System.Drawing.Point(490, 269);
            this.altitudeMaximumLabel.Name = "altitudeMaximumLabel";
            this.altitudeMaximumLabel.Size = new System.Drawing.Size(93, 13);
            this.altitudeMaximumLabel.TabIndex = 15;
            this.altitudeMaximumLabel.Text = "(maximum altitude)";
            // 
            // graphPage1
            // 
            this.graphPage1.Controls.Add(this.zedGraphControl1);
            this.graphPage1.Location = new System.Drawing.Point(4, 22);
            this.graphPage1.Name = "graphPage1";
            this.graphPage1.Size = new System.Drawing.Size(722, 300);
            this.graphPage1.TabIndex = 2;
            this.graphPage1.Text = "Graph (*)";
            this.graphPage1.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(722, 300);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // graphPage2
            // 
            this.graphPage2.Controls.Add(this.zedGraphControl2);
            this.graphPage2.Location = new System.Drawing.Point(4, 22);
            this.graphPage2.Name = "graphPage2";
            this.graphPage2.Size = new System.Drawing.Size(722, 300);
            this.graphPage2.TabIndex = 3;
            this.graphPage2.Text = "Graph (%)";
            this.graphPage2.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl2.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(722, 300);
            this.zedGraphControl2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 426);
            this.progressBar1.MaximumSize = new System.Drawing.Size(0, 7);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(758, 7);
            this.progressBar1.TabIndex = 3;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time                   (hh:mm:ss)";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HeartRates
            // 
            this.HeartRates.HeaderText = "Heart Rates          (bpm / % of max)";
            this.HeartRates.Name = "HeartRates";
            this.HeartRates.ReadOnly = true;
            this.HeartRates.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HeartRates.Width = 120;
            // 
            // Speed
            // 
            this.Speed.HeaderText = "Speed                 (kmh / mph)";
            this.Speed.Name = "Speed";
            this.Speed.ReadOnly = true;
            this.Speed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cadence
            // 
            this.Cadence.HeaderText = "Cadence             (rpm)";
            this.Cadence.Name = "Cadence";
            this.Cadence.ReadOnly = true;
            this.Cadence.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Altitude
            // 
            this.Altitude.HeaderText = "Altitude              (m / ft)";
            this.Altitude.Name = "Altitude";
            this.Altitude.ReadOnly = true;
            this.Altitude.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Power
            // 
            this.Power.HeaderText = "Power      (Watts / % of FTP)";
            this.Power.Name = "Power";
            this.Power.ReadOnly = true;
            this.Power.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PBPIndex
            // 
            this.PBPIndex.HeaderText = "PBP Index";
            this.PBPIndex.Name = "PBPIndex";
            this.PBPIndex.ReadOnly = true;
            this.PBPIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 433);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ASEB1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartRateTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementTrackBar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tablePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.summaryPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.graphPage1.ResumeLayout(false);
            this.graphPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tablePage;
        private System.Windows.Forms.TabPage summaryPage;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label speedAverageLabel;
        private System.Windows.Forms.Label powerAverageLabel;
        private System.Windows.Forms.Label heartRateAverageLabel;
        private System.Windows.Forms.Label altitudeAverageLabel;
        private System.Windows.Forms.Label speedSelectLabel;
        private System.Windows.Forms.TrackBar measurementTrackBar;
        private System.Windows.Forms.TabPage graphPage1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label heartRateMaximumLabel;
        private System.Windows.Forms.Label heartRateMinimumLabel;
        private System.Windows.Forms.Label speedMaximumLabel;
        private System.Windows.Forms.Label totalDistanceLabel;
        private System.Windows.Forms.Label powerMaximumLabel;
        private System.Windows.Forms.Label altitudeMaximumLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox fTPTextBox;
        private System.Windows.Forms.TextBox heartRateMaxTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TrackBar powerTrackBar;
        private System.Windows.Forms.TrackBar heartRateTrackBar;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.TabPage graphPage2;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button setFTPButton;
        private System.Windows.Forms.Button setBPMButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeartRates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cadence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
        private System.Windows.Forms.DataGridViewTextBoxColumn PBPIndex;
    }
}

