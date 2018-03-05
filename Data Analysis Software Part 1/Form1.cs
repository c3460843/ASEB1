using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ZedGraph;


/// <author>
/// c3460843
/// </author>

namespace Data_Analysis_Software_Part_1
{
    public partial class Form1 : Form
    {
        Stream myStream = null;
        int counter = 0;
        int timeSecs = 0;
        int interval;
        double speedTotal = 0;
        double speedMaximum = 0;
        double altitudeTotal = 0;
        double altitudeMaximum = 0;
        int heartRateTotal = 0;
        int userSetHeartRateMaximum = 0;
        int heartRateMaximum = 0;
        int heartRateMinimum = 0;
        int powerTotal = 0;
        int powerMaximum = 0;
        int userSetFTP = 0;
        decimal distanceTotal = 0;
        bool distanceCalculationFlag = false;
        int version;
        bool sModeSpeed;
        bool sModeCadence;
        bool sModeAltitude;
        bool sModePower;
        bool sModePowerLeftRightBalance;
        bool sModePowerPedallingIndex;
        bool sModeHRCC;
        bool sModeUnitStandard;
        bool sModeAirPressure;
        List<string> timeList = new List<string>();
        List<double> speedList = new List<double>();
        List<int> cadenceList = new List<int>();
        List<double> altitudeList = new List<double>();
        List<int> heartRateList = new List<int>();
        List<int> powerList = new List<int>();
        List<int> pBBIList = new List<int>();
        List<decimal> distanceList = new List<decimal>();
        List<double> heartRatePercentageList = new List<double>();
        List<double> powerPercentageList = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Reads the file then splits line by line into lists of data.
        /// </summary>
        public void Read()
        {
            string line;
            bool data = false;
            StreamReader file = new StreamReader(myStream);
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("Version"))
                {
                    String[] lineArray = line.Split('=');
                    version = Int32.Parse(lineArray[1]);
                }

                if (line.Contains("SMode"))
                {
                    String[] lineArray = line.Split('=');
                    char[] sModeChars = lineArray[1].ToCharArray();
                    int i = 0;
                    if (version >= 106)
                    {
                        if (sModeChars[i] == '0') { sModeSpeed = false; i++; }                  else if (sModeChars[i] == '1') { sModeSpeed = true; i++; }
                        if (sModeChars[i] == '0') { sModeCadence = false; i++; }                else if (sModeChars[i] == '1') { sModeCadence = true; i++; }
                        if (sModeChars[i] == '0') { sModeAltitude = false; i++; }               else if (sModeChars[i] == '1') { sModeAltitude = true; i++; }
                        if (sModeChars[i] == '0') { sModePower = false; i++; }                  else if (sModeChars[i] == '1') { sModePower = true; i++; }
                        if (sModeChars[i] == '0') { sModePowerLeftRightBalance = false; i++; }  else if (sModeChars[i] == '1') { sModePowerLeftRightBalance = true; i++; }
                        if (sModeChars[i] == '0') { sModePowerPedallingIndex = false; i++; }    else if (sModeChars[i] == '1') { sModePowerPedallingIndex = true; i++; }
                        if (sModeChars[i] == '0') { sModeHRCC = false; i++; }                   else if (sModeChars[i] == '1') { sModeHRCC = true; i++; }
                        if (sModeChars[i] == '0') { sModeUnitStandard = false; i++; }           else if (sModeChars[i] == '1') { sModeUnitStandard = true; i++; }
                    }
                    if (version >= 107)
                    {
                        if (sModeChars[i] == '0') { sModeAirPressure = false; i++; }            else if (sModeChars[8] == '1') { sModeAirPressure = true; i++; }
                    }
                    Console.WriteLine("Version="+version);
                    Console.WriteLine("SMode="+sModeChars[0].ToString() + sModeChars[1].ToString() + sModeChars[2].ToString() +
                                               sModeChars[3].ToString() + sModeChars[4].ToString() + sModeChars[5].ToString() +
                                               sModeChars[6].ToString() + sModeChars[7].ToString());
                }

                if (line.Contains("Date"))
                {
                    String[] lineArray = line.Split('=');
                    DateTime myDate = DateTime.ParseExact(lineArray[1], "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    dateLabel.Text = myDate.ToString("dd/MM/yyyy");
                }

                if (line.Contains("StartTime"))
                {
                    String[] lineArray = line.Split('=');
                    startTimeLabel.Text = lineArray[1];
                }

                if (line.Contains("Interval"))
                {
                    String[] lineArray = line.Split('=');
                    intervalLabel.Text = lineArray[1] + "s";
                    interval = Int32.Parse(lineArray[1]);
                }

                if (line.Contains("HRData"))
                {
                    data = true;
                }

                if (data == true)
                {
                    TimeSpan timeSpan = TimeSpan.FromSeconds(timeSecs);
                    if (!line.Contains("HRData"))
                    {
                        timeSecs+=interval;
                        string timeString = timeSpan.ToString(@"hh\:mm\:ss");
                        String[] lineArray = line.Split();
                        timeList.Add(timeString);
                        heartRateList.Add(Int32.Parse(lineArray[0]));

                        if (sModeSpeed == true)
                        {
                            speedList.Add(Int32.Parse(lineArray[1]));
                            distanceList.Add(Decimal.Parse(lineArray[1]) / 3600);
                        }
                        if (sModeCadence == true)               { cadenceList.Add(Int32.Parse(lineArray[2])); }
                        if (sModeAltitude == true)              { altitudeList.Add(Int32.Parse(lineArray[3])); }
                        if (sModePower == true)                 { powerList.Add(Int32.Parse(lineArray[4])); }
                        if (sModePowerLeftRightBalance == true) { pBBIList.Add(Int32.Parse(lineArray[5])); }
                    }
                }
                counter++;
            }
            file.Close();
            AddRows();
            Calculate();
            heartRateTrackBar.Value = 0;
            powerTrackBar.Value = 0;

        }


        /// <summary>
        /// Adds rows of data from lists to a data grid.       
        /// </summary>
        private void AddRows()
        {
            for (int i = 0; i < timeList.Count; i++)
            {
                string speedValue="";
                string cadenceValue="";
                string altitudeValue="";
                string powerValue="";
                string heartRateValue="";
                if (sModeSpeed==true)    { speedValue = (speedList[i]/10).ToString(); }
                if (sModeCadence==true)  { cadenceValue = cadenceList[i].ToString(); }
                if (sModeAltitude==true) { altitudeValue = altitudeList[i].ToString(); }
                if (sModePower == true)
                {
                    if (powerTrackBar.Value == 0)      { powerValue = powerList[i].ToString();  }
                    else if (powerTrackBar.Value == 1) { powerValue = Math.Round(powerPercentageList[i], 2).ToString();  }
                }
                if (sModeHRCC == true)
                {
                    if (heartRateTrackBar.Value == 0)      { heartRateValue = heartRateList[i].ToString(); }
                    else if (heartRateTrackBar.Value == 1) { heartRateValue = Math.Round(heartRatePercentageList[i], 2).ToString();  }
                }
                dataGridView.Rows.Add(timeList[i], heartRateValue, speedValue, cadenceValue, altitudeValue, powerValue, pBBIList[i]);
            }
            Console.WriteLine("AddRows()");
        }

        /// <summary>
        /// Calculates all the averages, minimums and maximums from the lists.
        /// </summary>
        private void Calculate()
        {
            speedTotal = 0;
            speedMaximum = 0;
            altitudeTotal = 0;
            heartRateTotal = 0;
            powerTotal = 0;

            try
            {
                foreach (int heartRateInt in heartRateList) { heartRateTotal += heartRateInt; }
                double heartRateAverage = heartRateTotal / heartRateList.Count;
                heartRateAverageLabel.Text = heartRateAverage.ToString() + "bpm";

                foreach (double speedDouble in speedList) { speedTotal += speedDouble; }
                double speedAverage = speedTotal / speedList.Count;
                speedAverage = Math.Round(speedAverage, 1);
                if (measurementTrackBar.Value == 0) { speedAverageLabel.Text = (speedAverage / 10).ToString() + "km/h"; }
                else if (measurementTrackBar.Value == 1) { speedAverageLabel.Text = (speedAverage / 10).ToString() + "mph"; }

                foreach (double altitudeDouble in altitudeList) { altitudeTotal += altitudeDouble; }
                double altitudeAverage = altitudeTotal / altitudeList.Count;
                altitudeAverage = Math.Round(altitudeAverage, 2);
                if (measurementTrackBar.Value == 0) { altitudeAverageLabel.Text = altitudeAverage.ToString() + "m"; }
                else if (measurementTrackBar.Value == 1) { altitudeAverageLabel.Text = altitudeAverage.ToString() + "ft"; }

                foreach (int powerInt in powerList) { powerTotal += powerInt; }
                double powerAverage = powerTotal / powerList.Count;
                powerAverageLabel.Text = powerAverage.ToString() + "W";

                foreach (double speedInt in speedList) { if (speedInt > speedMaximum) { speedMaximum = speedInt; } }
                if (measurementTrackBar.Value == 0) { speedMaximumLabel.Text = (speedMaximum / 10) + "km/h"; }
                else if (measurementTrackBar.Value == 1) { speedMaximumLabel.Text = (speedMaximum / 10) + "mph"; }

                if (distanceCalculationFlag == false)
                {
                    foreach (decimal distanceDecimal in distanceList) { distanceTotal += distanceDecimal; }
                    distanceTotal = Math.Round(distanceTotal, 1);
                    distanceCalculationFlag = true;
                }
                if (measurementTrackBar.Value == 0) { totalDistanceLabel.Text = (distanceTotal / 10) + "km"; }
                else if (measurementTrackBar.Value == 1) { totalDistanceLabel.Text = (distanceTotal / 10) + "miles"; }

                foreach (int heartRateInt in heartRateList) { if (heartRateInt > heartRateMaximum) { heartRateMaximum = heartRateInt; } }
                heartRateMaximumLabel.Text = heartRateMaximum + "bpm";

                heartRateMinimum = heartRateList[0];
                foreach (int heartRateInt in heartRateList) { if (heartRateInt < heartRateMinimum) { heartRateMinimum = heartRateInt; } }
                heartRateMinimumLabel.Text = heartRateMinimum + "bpm";

                foreach (int powerInt in powerList) { if (powerInt > powerMaximum) { powerMaximum = powerInt; } }
                powerMaximumLabel.Text = powerMaximum + "W";

                foreach (double altitudeInt in altitudeList) { if (altitudeInt > altitudeMaximum) { altitudeMaximum = altitudeInt; } }
                if (measurementTrackBar.Value == 0) { altitudeMaximumLabel.Text = altitudeMaximum + "m"; }
                else if (measurementTrackBar.Value == 1) { altitudeMaximumLabel.Text = altitudeMaximum + "ft"; }
            }
            catch (System.DivideByZeroException)
            {
                //No user dialogue needed.
            }
            Console.WriteLine("Calculate()");
        }

        /// <summary>
        /// Plots the zedGraph for numerical data.
        /// </summary>
        private void PlotGraph1()
        {
            Console.WriteLine(1);
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.GraphPane.GraphObjList.Clear();
            GraphPane myPane1 = zedGraphControl1.GraphPane;

            Console.WriteLine(2);
            myPane1.XAxis.Title.Text = "Time (Seconds)";
            myPane1.YAxis.Title.Text = "";
            myPane1.XAxis.Scale.Max = timeSecs;
            PointPairList speedPairList = new PointPairList();
            PointPairList cadencePairList = new PointPairList();
            PointPairList altitudePairList = new PointPairList();
            PointPairList heartRatePairList = new PointPairList();
            PointPairList powerPairList = new PointPairList();

            Console.WriteLine(3);
            for (int i = 0; i < timeSecs; i++)
            {
                speedPairList.Add(i, (speedList[i] / 10));
                cadencePairList.Add(i, cadenceList[i]);
                altitudePairList.Add(i, altitudeList[i]);
                heartRatePairList.Add(i, heartRateList[i]);
                powerPairList.Add(i, powerList[i]);
            }

            Console.WriteLine(4);
            LineItem speedCurve = myPane1.AddCurve("Speed",
                   speedPairList, Color.Red, SymbolType.None);

            LineItem cadenceCurve = myPane1.AddCurve("Cadence",
                  cadencePairList, Color.Green, SymbolType.None);

            LineItem altitudeCurve = myPane1.AddCurve("Altitude",
                  altitudePairList, Color.Gray, SymbolType.None);

            LineItem heartRateCurve = myPane1.AddCurve("Heart Rate",
                  heartRatePairList, Color.Purple, SymbolType.None);

            LineItem powerCurve = myPane1.AddCurve("Power",
                  powerPairList, Color.Orange, SymbolType.None);

            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();

            Console.WriteLine("PlotGraph1()");
        }

        /// <summary>
        /// Plots the zedGraph for percentage data.
        /// </summary>
        private void PlotGraph2()
        {
            try
            {
                zedGraphControl2.GraphPane.CurveList.Clear();
                zedGraphControl2.GraphPane.GraphObjList.Clear();
                GraphPane myPane2 = zedGraphControl2.GraphPane;

                myPane2.XAxis.Title.Text = "Time (Seconds)";
                myPane2.YAxis.Title.Text = "%";
                myPane2.XAxis.Scale.Max = timeSecs;
                PointPairList heartRatePercentagePairList = new PointPairList();
                PointPairList powerPercentagePairList = new PointPairList();

                for (int i = 0; i < timeSecs; i++)
                {
                    heartRatePercentagePairList.Add(i, heartRatePercentageList[i]);
                    powerPercentagePairList.Add(i, powerPercentageList[i]);
                }

                LineItem heartRatePercentageCurve = myPane2.AddCurve("Heart Rate",
                      heartRatePercentagePairList, Color.Purple, SymbolType.None);

                LineItem powerPercentageCurve = myPane2.AddCurve("Power",
                      powerPercentagePairList, Color.Orange, SymbolType.None);

                zedGraphControl2.AxisChange();
                zedGraphControl2.Refresh();

                Console.WriteLine("PlotGraph2()");
            }
            catch (Exception)
            {

            }
        }

        private void SetSize()
        {
            zedGraphControl1.Location = new Point(0, 0);
            zedGraphControl1.IsShowPointValues = true;
            zedGraphControl1.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);
            zedGraphControl2.Location = new Point(0, 0);
            zedGraphControl2.IsShowPointValues = true;
            zedGraphControl2.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        /// <summary>
        /// Listens for File...Open click, and creates open file dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if(sModeUnitStandard == false)      { measurementTrackBar.Value = 0; }
            else if (sModeUnitStandard == true) { measurementTrackBar.Value = 1; }
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        dataGridView.Rows.Clear();
                        Read();
                        PlotGraph1();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Listens for change in Metric/Imperial trackbar value change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void measurementTrackBar_ValueChanged(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            if (measurementTrackBar.Value == 0)
            {
                Metric();
            }
            else if(measurementTrackBar.Value == 1)
            {
                Imperial();
            }
            AddRows();
            Thread.Sleep(50);
            Calculate();
            PlotGraph1();
            Console.WriteLine("measurementTrackBar_ValueChanged()");
        }

        /// <summary>
        /// Maths for converting metric into imperial.
        /// </summary>
        private void Imperial()
        {
            for (int i = 0; i < speedList.Count; i++)
            {
                speedList[i] = Math.Round(speedList[i] * 0.6214);
            }

            for (int i = 0; i < altitudeList.Count; i++)
            {
                altitudeList[i] = Math.Round(altitudeList[i] * 3.2808);
            }

            distanceTotal = Math.Round(distanceTotal * (Convert.ToDecimal(0.6214)), 1);
            altitudeMaximum = Math.Round(altitudeMaximum * 3.2808);
            dataGridView.Columns[2].HeaderText = "Speed (mph)";
            dataGridView.Columns[4].HeaderText = "Altitude (ft)";
        }

        /// <summary>
        /// Maths for converting imperial into metric.
        /// </summary>
        private void Metric()
        {
            for (int i = 0; i < speedList.Count; i++)
            {
                speedList[i] = Math.Round(speedList[i] * 1.6093);
            }

            for (int i = 0; i < altitudeList.Count; i++)
            {
                altitudeList[i] = Math.Round(altitudeList[i] * 0.3048);
            }

            distanceTotal = Math.Round(distanceTotal * (Convert.ToDecimal(1.6093)), 1);
            altitudeMaximum = Math.Round(altitudeMaximum * 0.3048);
            dataGridView.Columns[2].HeaderText = "Speed (km/h)";
            dataGridView.Columns[4].HeaderText = "Altitude (m)";
        }

        /// <summary>
        /// Listens for change in numerical/percentage heart rate trackbar value change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeartRateTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (userSetHeartRateMaximum != 0)
            {
                Console.WriteLine("HeartRateTrackBar_ValueChanged()");
                dataGridView.Rows.Clear();
                AddRows();
            }
            if (heartRateTrackBar.Value == 0)      { dataGridView.Columns[1].HeaderText = "Heart Rate (bpm)"; }
            else if (heartRateTrackBar.Value == 1) { dataGridView.Columns[1].HeaderText = "Heart Rate (%ofMax)"; }
        }
        
        /// <summary>
        /// Listens for change in numerical/percentage power trackbar value change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PowerTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (userSetFTP != 0)
            {
                Console.WriteLine("PowerTrackBar_ValueChanged()");
                dataGridView.Rows.Clear();
                AddRows();
            }
            if (powerTrackBar.Value == 0) { dataGridView.Columns[5].HeaderText = "Power (Watts)"; }
            else if (powerTrackBar.Value == 1) { dataGridView.Columns[5].HeaderText = "Power (%ofFTP)"; }
        }

        /// <summary>
        /// Button for setting user defined heart rate in beats per minute.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setBPMButton_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            try
            {
                userSetHeartRateMaximum = Int32.Parse(heartRateMaxTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid heart rate(bpm).");
                heartRateMaxTextBox.Text = heartRateMaximum.ToString();
            }
            heartRatePercentageList.Clear();
            foreach (double heartRateInt in heartRateList) { heartRatePercentageList.Add((heartRateInt / userSetHeartRateMaximum) * 100); }
            AddRows();
            PlotGraph2();
        }

        /// <summary>
        /// Button for setting user defined power in watts.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setFTPButton_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            try
            {
                userSetFTP = Int32.Parse(fTPTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid functional threshold power(W).");
                fTPTextBox.Text = powerMaximum.ToString();
            }
            powerPercentageList.Clear();
            foreach (double powerInt in powerList) { powerPercentageList.Add((powerInt / userSetFTP) * 100); }
            AddRows();
            PlotGraph2();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by c3460843 using ZedGraph.");
        }
    }
}
