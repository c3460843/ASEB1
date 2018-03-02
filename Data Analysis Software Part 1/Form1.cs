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
        List<string> timeList = new List<string>();
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
                        speedList.Add(Int32.Parse(lineArray[1]));
                        cadenceList.Add(Int32.Parse(lineArray[2]));
                        altitudeList.Add(Int32.Parse(lineArray[3]));
                        powerList.Add(Int32.Parse(lineArray[4]));
                        pBBIList.Add(Int32.Parse(lineArray[5]));
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
            dataGridView.Rows.Add(timeList[i], heartRateList[i], speedList[i], cadenceList[i], altitudeList[i], powerList[i], pBBIList[i]);
            }
        }

        private void CalculateAverages()
        {
            speedTotal = 0;
            cadenceTotal = 0;
            altitudeTotal = 0;
            heartRateTotal = 0;
            powerTotal = 0;

            foreach (int heartRateInt in heartRateList)
            {
                heartRateTotal += heartRateInt;
            }
            double heartRateAverage = heartRateTotal / heartRateList.Count;
            heartRateAverageLabel.Text = heartRateAverage.ToString() + "bpm";

            foreach (double speedDouble in speedList)
            {
                speedTotal += speedDouble;
            }
            double speedAverage = speedTotal / speedList.Count;
            speedAverage = Math.Round(speedAverage, 1);
            if (measurementTrackBar.Value == 0)
            {
                speedAverageLabel.Text = (speedAverage / 10).ToString() + "km/h";
            }
            else if (measurementTrackBar.Value == 1)
            {
                speedAverageLabel.Text = (speedAverage / 10).ToString() + "mph";
            }

            foreach (int cadenceInt in cadenceList)
            {
                cadenceTotal += cadenceInt;
            }
            double cadenceAverage = cadenceTotal / cadenceList.Count;
            cadenceAverageLabel.Text = cadenceAverage.ToString() + "rpm";

            foreach (double altitudeDouble in altitudeList)
            {
                altitudeTotal += altitudeDouble;
            }
            double altitudeAverage = altitudeTotal / altitudeList.Count;
            altitudeAverage = Math.Round(altitudeAverage, 2);
            if (measurementTrackBar.Value == 0)
            {
                altitudeAverageLabel.Text = altitudeAverage.ToString() + "m";
            }
            else if (measurementTrackBar.Value == 1)
            {
                altitudeAverageLabel.Text = altitudeAverage.ToString() + "ft";
            }

            foreach (int powerInt in powerList)
            {
                powerTotal += powerInt;
            }
            double powerAverage = powerTotal / powerList.Count;
            powerAverageLabel.Text = powerAverage.ToString() + "Watts";
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
            CalculateAverages();
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
            Thread.Sleep(100);
            CalculateAverages();
        }
    }
}
