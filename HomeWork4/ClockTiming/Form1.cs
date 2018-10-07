using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockTiming
{
    public partial class Clock : Form
    {
        int settedHour, settedMinute;

        public Clock()
        {
            InitializeComponent();
        }

        private void ShowTimeLeft()
        {
            leftTime.Show();
            hour.Show();
            minute.Show();
            second.Show();
            label1.Show();
            label2.Show();
        }

        private void HideTimeLeft()
        {
            leftTime.Hide();
            hour.Hide();
            minute.Hide();
            second.Hide();
            label1.Hide();
            label2.Hide();
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            HideTimeLeft();
            timer1.Enabled = false;
        }

        private void certain_Click(object sender, EventArgs e)
        {
            settedHour = Convert.ToInt32(setHour.Value);
            settedMinute = Convert.ToInt32(setMinute.Value);
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowTimeLeft();
            DateTime currTime = DateTime.Now;

            if(settedMinute - 1 < currTime.Minute)
            {
                minute.Text = (settedMinute + 60 - currTime.Minute).ToString();
            }
            else
            {
                minute.Text = (settedMinute - 1 - currTime.Minute).ToString();
            }
            hour.Text = (settedHour - currTime.Hour).ToString();
            second.Text = (60 - currTime.Second).ToString();


            if(currTime.Hour == settedHour && currTime.Minute == settedMinute)
            {
                timer1.Enabled = false;
                HideTimeLeft();
                MessageBox.Show("Your setted time is now on !!!");
            }
        }
    }
}
