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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tablePage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.speedAverageLabel = new System.Windows.Forms.Label();
            this.cadenceAverageLabel = new System.Windows.Forms.Label();
            this.altitudeAverageLabel = new System.Windows.Forms.Label();
            this.heartRateAverageLabel = new System.Windows.Forms.Label();
            this.powerAverageLabel = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeartRates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cadence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBPIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementTrackBar = new System.Windows.Forms.TrackBar();
            this.speedSelectLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tablePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.speedSelectLabel);
            this.panel1.Controls.Add(this.measurementTrackBar);
            this.panel1.Controls.Add(this.powerAverageLabel);
            this.panel1.Controls.Add(this.heartRateAverageLabel);
            this.panel1.Controls.Add(this.altitudeAverageLabel);
            this.panel1.Controls.Add(this.cadenceAverageLabel);
            this.panel1.Controls.Add(this.speedAverageLabel);
            this.panel1.Controls.Add(this.intervalLabel);
            this.panel1.Controls.Add(this.startTimeLabel);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 61);
            this.panel1.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 8);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(34, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "(date)";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(132, 8);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(55, 13);
            this.startTimeLabel.TabIndex = 1;
            this.startTimeLabel.Text = "(start time)";
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(258, 8);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(47, 13);
            this.intervalLabel.TabIndex = 2;
            this.intervalLabel.Text = "(interval)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tablePage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 403);
            this.tabControl1.TabIndex = 2;
            // 
            // tablePage
            // 
            this.tablePage.Controls.Add(this.dataGridView);
            this.tablePage.Location = new System.Drawing.Point(4, 22);
            this.tablePage.Name = "tablePage";
            this.tablePage.Padding = new System.Windows.Forms.Padding(3);
            this.tablePage.Size = new System.Drawing.Size(749, 377);
            this.tablePage.TabIndex = 0;
            this.tablePage.Text = "Table";
            this.tablePage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(749, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.dataGridView.Size = new System.Drawing.Size(743, 371);
            this.dataGridView.TabIndex = 0;
            // 
            // speedAverageLabel
            // 
            this.speedAverageLabel.AutoSize = true;
            this.speedAverageLabel.Location = new System.Drawing.Point(12, 37);
            this.speedAverageLabel.Name = "speedAverageLabel";
            this.speedAverageLabel.Size = new System.Drawing.Size(84, 13);
            this.speedAverageLabel.TabIndex = 3;
            this.speedAverageLabel.Text = "(average speed)";
            // 
            // cadenceAverageLabel
            // 
            this.cadenceAverageLabel.AutoSize = true;
            this.cadenceAverageLabel.Location = new System.Drawing.Point(132, 37);
            this.cadenceAverageLabel.Name = "cadenceAverageLabel";
            this.cadenceAverageLabel.Size = new System.Drawing.Size(97, 13);
            this.cadenceAverageLabel.TabIndex = 4;
            this.cadenceAverageLabel.Text = "(average cadence)";
            // 
            // altitudeAverageLabel
            // 
            this.altitudeAverageLabel.AutoSize = true;
            this.altitudeAverageLabel.Location = new System.Drawing.Point(258, 37);
            this.altitudeAverageLabel.Name = "altitudeAverageLabel";
            this.altitudeAverageLabel.Size = new System.Drawing.Size(89, 13);
            this.altitudeAverageLabel.TabIndex = 5;
            this.altitudeAverageLabel.Text = "(average altitude)";
            // 
            // heartRateAverageLabel
            // 
            this.heartRateAverageLabel.AutoSize = true;
            this.heartRateAverageLabel.Location = new System.Drawing.Point(381, 37);
            this.heartRateAverageLabel.Name = "heartRateAverageLabel";
            this.heartRateAverageLabel.Size = new System.Drawing.Size(100, 13);
            this.heartRateAverageLabel.TabIndex = 6;
            this.heartRateAverageLabel.Text = "(average heart rate)";
            // 
            // powerAverageLabel
            // 
            this.powerAverageLabel.AutoSize = true;
            this.powerAverageLabel.Location = new System.Drawing.Point(531, 37);
            this.powerAverageLabel.Name = "powerAverageLabel";
            this.powerAverageLabel.Size = new System.Drawing.Size(84, 13);
            this.powerAverageLabel.TabIndex = 7;
            this.powerAverageLabel.Text = "(average power)";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time (hh:mm:ss)";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HeartRates
            // 
            this.HeartRates.HeaderText = "Heart Rates (bpm)";
            this.HeartRates.Name = "HeartRates";
            this.HeartRates.ReadOnly = true;
            this.HeartRates.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Speed
            // 
            this.Speed.HeaderText = "Speed (km/h)";
            this.Speed.Name = "Speed";
            this.Speed.ReadOnly = true;
            this.Speed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cadence
            // 
            this.Cadence.HeaderText = "Cadence (rpm)";
            this.Cadence.Name = "Cadence";
            this.Cadence.ReadOnly = true;
            this.Cadence.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Altitude
            // 
            this.Altitude.HeaderText = "Altitude (m)";
            this.Altitude.Name = "Altitude";
            this.Altitude.ReadOnly = true;
            this.Altitude.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Power
            // 
            this.Power.HeaderText = "Power (Watts)";
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
            // measurementTrackBar
            // 
            this.measurementTrackBar.Location = new System.Drawing.Point(673, 18);
            this.measurementTrackBar.Maximum = 1;
            this.measurementTrackBar.Name = "measurementTrackBar";
            this.measurementTrackBar.Size = new System.Drawing.Size(58, 45);
            this.measurementTrackBar.TabIndex = 3;
            this.measurementTrackBar.ValueChanged += new System.EventHandler(this.measurementTrackBar_ValueChanged);
            // 
            // speedSelectLabel
            // 
            this.speedSelectLabel.AutoSize = true;
            this.speedSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedSelectLabel.Location = new System.Drawing.Point(669, 46);
            this.speedSelectLabel.Name = "speedSelectLabel";
            this.speedSelectLabel.Size = new System.Drawing.Size(70, 12);
            this.speedSelectLabel.TabIndex = 8;
            this.speedSelectLabel.Text = "metric / imperial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 488);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tablePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementTrackBar)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label speedAverageLabel;
        private System.Windows.Forms.Label powerAverageLabel;
        private System.Windows.Forms.Label heartRateAverageLabel;
        private System.Windows.Forms.Label altitudeAverageLabel;
        private System.Windows.Forms.Label cadenceAverageLabel;
        private System.Windows.Forms.Label speedSelectLabel;
        private System.Windows.Forms.TrackBar measurementTrackBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeartRates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cadence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
        private System.Windows.Forms.DataGridViewTextBoxColumn PBPIndex;
    }
}

