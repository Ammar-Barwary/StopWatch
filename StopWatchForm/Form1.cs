using System;
using System.Windows.Forms;

namespace StopWatchForm
{
    public partial class Form1 : Form
    {
        int sec = 0;
        int min = 0;
        int hour = 0;
        int count = 1;

        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
        }

        public void AddLastTimer(int s, int m, int h)
        {
            ListBox.Items.Add($"{count})   {h} : {m} : {s}");
            count++;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 60)
            {
                min++;
                if (min == 60)
                {
                    hour++;
                    TextHour.Text = hour.ToString();
                    sec = 0;
                    min = 0;
                }
                TextMin.Text = min.ToString();
                sec = 0;
            }

            TextSec.Text = sec.ToString();
        }

        private void ButStart_Click(object sender, EventArgs e)
        {
            ButPR.Enabled = true;
            ButStop.Enabled = true;
            ButStart.Enabled = false;
            timer1.Start();
        }

        private void ButPR_Click(object sender, EventArgs e)
        {
            //timer1.Stop();

            if (ButPR.Text == "Pause")
            {
                timer1.Stop();
                ButPR.Text = "Resume";
            } else if (ButPR.Text == "Resume")
            {
                timer1.Start();
                ButPR.Text = "Pause";
            }
        }

        private void ButStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            AddLastTimer(sec, min, hour);
            sec = 0;
            min = 0;
            hour = 0;
            TextSec.Text = "0";
            TextMin.Text = "0";
            TextHour.Text = "0";
            ButPR.Enabled = false;
            ButStop.Enabled = false;
            ButStart.Enabled = true;
        }
    }
}
