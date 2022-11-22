using System;
using System.Windows.Forms;

namespace StopWatchForm
{
    public partial class Form1 : Form
    {
        int mli = 0, mliTemp = 0;
        int sec = 0, secTemp = 0;
        int min = 0, minTemp = 0;
        int count = 1;

        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
        }

        public void AddLap(int s, int m, int h)
        {
            ListBox.Items.Add($"{count})   {h} : {m} : {s}");
            count++;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            mli++;
            if (mli == 100)
            {
                sec++;
                if (sec == 60)
                {
                    min++;
                    TextHour.Text = min.ToString();
                    mli = 0;
                    sec = 0;
                }
                TextMin.Text = sec.ToString();
                mli = 0;
            }

            TextSec.Text = mli.ToString();

            mliTemp++;
            if (mliTemp == 100)
            {
                secTemp++;
                if (secTemp == 60)
                {
                    minTemp++;
                    mliTemp = 0;
                    secTemp = 0;
                }
                mliTemp = 0;
            }
        }

        private void ButStart_Click(object sender, EventArgs e)
        {
            if (ButStart.Text == "Start")
            {
                ButLep.Enabled = true;
                timer1.Start();
                ButLep.Text = "Lap";
                ButStart.Text = "Stop";
            }
            else if (ButStart.Text == "Stop")
            {
                timer1.Stop();
                ButLep.Text = "Reset";
                ButStart.Text = "Start";
            }
        }

        private void ButLap_Click(object sender, EventArgs e)
        {
            if (ButLep.Text == "Lap")
            {
                AddLap(mliTemp, secTemp, minTemp);

                mliTemp = 0;
                secTemp = 0;
                minTemp = 0;
            }
            else if (ButLep.Text == "Reset")
            {
                count = 1;
                timer1.Stop();
                mli = 0;
                mliTemp = 0;
                sec = 0;
                secTemp = 0;
                min = 0;
                minTemp = 0;
                TextSec.Text = "0";
                TextMin.Text = "0";
                TextHour.Text = "0";
                ListBox.Items.Clear();
                ButLep.Text = "Lap";
                ButLep.Enabled = false;
            }
        }
    }
}
