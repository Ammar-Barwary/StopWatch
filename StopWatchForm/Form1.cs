using System;
using System.Windows.Forms;

namespace StopWatchForm
{
    public partial class Form1 : Form
    {
        int sec = 0;
        int min = 0;
        int hour = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
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
            timer1.Start();
        }

        private void ButStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void ButReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sec = 0;
            min = 0;
            hour = 0;
            TextSec.Text = "0";
            TextMin.Text = "0";
            TextHour.Text = "0";
        }
    }
}
