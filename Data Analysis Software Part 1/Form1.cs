using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Data_Analysis_Software_Part_1
{
    public partial class Form1 : Form
    {
        Stream myStream = null;
        int counter = 0;
        int timeSecs = 0;
        double speedTotal = 0;
        int cadenceTotal = 0; 
        double altitudeTotal = 0;
        int heartRateTotal = 0;
        int powerTotal = 0;
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
        static List<string> timeList = new List<string>();
        List<double> speedList = new List<double>();
        List<int> cadenceList = new List<int>();
        List<double> altitudeList = new List<double>();
        List<int> heartRateList = new List<int>();
        List<int> powerList = new List<int>();
        List<int> pBBIList = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

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
                    if (version >= 106)
                    {
                        if (sModeChars[0] == '0') { sModeSpeed = false; }                 else if (sModeChars[0] == '1') { sModeSpeed = true; }
                        if (sModeChars[1] == '0') { sModeCadence = false; }               else if (sModeChars[1] == '1') { sModeCadence = true; }
                        if (sModeChars[2] == '0') { sModeAltitude = false; }              else if (sModeChars[2] == '1') { sModeAltitude = true; }
                        if (sModeChars[3] == '0') { sModePower = false; }                 else if (sModeChars[3] == '1') { sModePower = true; }
                        if (sModeChars[4] == '0') { sModePowerLeftRightBalance = false; } else if (sModeChars[4] == '1') { sModePowerLeftRightBalance = true; }
                        if (sModeChars[5] == '0') { sModePowerPedallingIndex = false; }   else if (sModeChars[5] == '1') { sModePowerPedallingIndex = true; }
                        if (sModeChars[6] == '0') { sModeHRCC = false; }                  else if (sModeChars[6] == '1') { sModeHRCC = true; }
                        if (sModeChars[7] == '0') { sModeUnitStandard = false; }          else if (sModeChars[7] == '1') { sModeUnitStandard = true; }
                    }
                    if (version >= 107)
                    {
                        if (sModeChars[8] == 0) { sModeAirPressure = false; }           else if (sModeChars[8] == 1) { sModeAirPressure = true; }
                    }
                    Console.WriteLine("Version="+version);
                    Console.WriteLine("SMode="+sModeChars[0].ToString() + sModeChars[1].ToString() + sModeChars[2].ToString() +
                                               sModeChars[3].ToString() + sModeChars[4].ToString() + sModeChars[5].ToString() +
                                               sModeChars[6].ToString() + sModeChars[7].ToString());
                }

                if (line.Contains("Date"))
                {
                    String[] lineArray = line.Split('=');
                    dateLabel.Text = lineArray[1];
                }

                if (line.Contains("StartTime"))
                {
                    String[] lineArray = line.Split('=');
                    startTimeLabel.Text = lineArray[1];
                }

                if (line.Contains("Interval"))
                {
                    String[] lineArray = line.Split('=');
                    intervalLabel.Text = lineArray[1] + "s interval";
                }

                if (line.Contains("HRData"))
                {
                    data = true;
                }

                if (data == true)
                {
                    TimeSpan timeSpan = TimeSpan.FromSeconds(timeSecs);
                    if (!line.Contains("HRData")) {
                        timeSecs++;
                        string timeString = timeSpan.ToString(@"hh\:mm\:ss");
                        String[] lineArray = line.Split();
                        timeList.Add(timeString);
                        heartRateList.Add(Int32.Parse(lineArray[0]));
                        if (sModeSpeed == true) { speedList.Add(Int32.Parse(lineArray[1])); }
                        if (sModeCadence == true) { cadenceList.Add(Int32.Parse(lineArray[2])); }
                        if (sModeAltitude == true) { altitudeList.Add(Int32.Parse(lineArray[3])); }
                        if (sModePower == true) { powerList.Add(Int32.Parse(lineArray[4])); }
                        if (sModePowerLeftRightBalance == true) { pBBIList.Add(Int32.Parse(lineArray[5])); }
                    }
                }
                counter++;
            }
            file.Close();
            AddRows();
            CalculateAverages();
        }

        private void AddRows()
        {
            for (int i = 0; i < timeList.Count; i++)
            {
                string speedValue="";
                string cadenceValue="";
                string altitudeValue="";
                string powerValue="";
                if (sModeSpeed==true)    { speedValue = (speedList[i]/10).ToString(); }
                if (sModeCadence==true)  { cadenceValue = cadenceList[i].ToString(); }
                if (sModeAltitude==true) { altitudeValue = altitudeList[i].ToString(); }
                if (sModePower==true)    { powerValue = powerList[i].ToString(); }
                dataGridView.Rows.Add(timeList[i], heartRateList[i], speedValue, cadenceValue, altitudeValue, powerValue, pBBIList[i]);
            }
        }

        private void CalculateAverages()
        {
            speedTotal = 0;
            cadenceTotal = 0;
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

                foreach (int cadenceInt in cadenceList) { cadenceTotal += cadenceInt; }
                double cadenceAverage = cadenceTotal / cadenceList.Count;
                cadenceAverageLabel.Text = cadenceAverage.ToString() + "rpm";

                foreach (double altitudeDouble in altitudeList) { altitudeTotal += altitudeDouble; }
                double altitudeAverage = altitudeTotal / altitudeList.Count;
                altitudeAverage = Math.Round(altitudeAverage, 2);
                if (measurementTrackBar.Value == 0) { altitudeAverageLabel.Text = altitudeAverage.ToString() + "m"; }
                else if (measurementTrackBar.Value == 1) { altitudeAverageLabel.Text = altitudeAverage.ToString() + "ft"; }

                foreach (int powerInt in powerList) { powerTotal += powerInt; }
                double powerAverage = powerTotal / powerList.Count;
                powerAverageLabel.Text = powerAverage.ToString() + "Watts";
            }
            catch (System.DivideByZeroException)
            {

            }
        }

        private void PlotGraph()
        {
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.GraphPane.GraphObjList.Clear();
            GraphPane myPane = zedGraphControl1.GraphPane;            

            // Set the Titles
            myPane.Title.Text = "";
            myPane.XAxis.Title.Text = "X?";
            myPane.YAxis.Title.Text = "Y?";
            //myPane.XAxis.Scale.MajorStep = 60;
            //myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.Mag = 0;
            //myPane.XAxis.Scale.Max = timeSecs;
            myPane.XAxis.Type = AxisType.Date;
            myPane.XAxis.Scale.Format = "HH:mm:ss";

            myPane.XAxis.Scale.MinorUnit = DateUnit.Second;         
            myPane.XAxis.Scale.MajorUnit = DateUnit.Minute;
            //myPane.XAxis.Scale.MinorStep = 10;                        
            //myPane.XAxis.Scale.MajorStep = 60;



            PointPairList speedPairList = new PointPairList();
            PointPairList cadencePairList = new PointPairList();
            PointPairList altitudePairList = new PointPairList();
            PointPairList heartRatePairList = new PointPairList();
            PointPairList powerPairList = new PointPairList();

            for (int i = 0; i < timeSecs; i++)
            {


                speedPairList.Add(i, (speedList[i]/10));
                cadencePairList.Add(i, cadenceList[i]);
                altitudePairList.Add(i, altitudeList[i]);
                heartRatePairList.Add(i, heartRateList[i]);
                powerPairList.Add(i, powerList[i]);

                Console.WriteLine(i);
            }

            LineItem speedCurve = myPane.AddCurve("Speed",
                   speedPairList, Color.Red, SymbolType.None);

            LineItem cadenceCurve = myPane.AddCurve("Cadence",
                  cadencePairList, Color.Blue, SymbolType.None);

            LineItem altitudeCurve = myPane.AddCurve("Altitude",
                  altitudePairList, Color.Gray, SymbolType.None);

            LineItem heartRateCurve = myPane.AddCurve("Heart Rate",
                  heartRatePairList, Color.Purple, SymbolType.None);

            LineItem teamBCurve = myPane.AddCurve("Power",
                  powerPairList, Color.Orange, SymbolType.None);

            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();
        }

        private void SetSize()
        {
            zedGraphControl1.Location = new Point(0, 0);
            zedGraphControl1.IsShowPointValues = true;
            zedGraphControl1.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        Read();
                        PlotGraph();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void measurementTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (measurementTrackBar.Value == 0)
            {
                Metric();
            }
            else if(measurementTrackBar.Value == 1)
            {
                Imperial();
            }
        }

        private void Imperial()
        {
            dataGridView.Rows.Clear();
            for (int i = 0; i < speedList.Count; i++)
            {
                speedList[i] = Math.Round(speedList[i] * 0.6214);
            }

            for (int i = 0; i < altitudeList.Count; i++)
            {
                altitudeList[i] = Math.Round(altitudeList[i] * 3.2808);
            }
            AddRows();
            Thread.Sleep(50);
            CalculateAverages();
            PlotGraph();
        }

        private void Metric()
        {
            dataGridView.Rows.Clear();
            for (int i = 0; i < speedList.Count; i++)
            {
                speedList[i] = Math.Round(speedList[i] * 1.6093);
            }

            for (int i = 0; i < altitudeList.Count; i++)
            {
                altitudeList[i] = Math.Round(altitudeList[i] * 0.3048);
            }
            AddRows();
            Thread.Sleep(50);
            CalculateAverages();
            PlotGraph();
        }
    }
}
