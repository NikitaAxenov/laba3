using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fly2
{
    public partial class Form1 : Form
    {
        public int time_now = 0;
        public int min = 0;
        string timer;
        public int sec;
        public bool timer_bool = false;
        Calculation calculation;

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer_bool = false;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer_bool = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                calculation = new Calculation();
                chart.Series[0].Points.Clear();
                calculation.y = forHeight.Value;
                calculation.v0 = forSpeed.Value;
                double a = (double)forAngle.Value * Math.PI / 180;
                calculation.cosa = (decimal)Math.Cos(a);
                calculation.sina = (decimal)Math.Sin(a);
                calculation.S = forSize.Value;
                calculation.m = forWeight.Value;
                calculation.ForBtn();
                chart.Series[0].Points.AddXY(calculation.x, calculation.y);
                timer1.Start();
                timer_bool = true;
                timer = "00:00";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            calculation.ForTimer();
            chart.Series[0].Points.AddXY(calculation.x, calculation.y);
            if (timer_bool == true)
            {
                time_now += timer1.Interval;
                sec = time_now / 1000;
                if (min > 0)
                {
                    sec = Math.Abs(min * 60 - sec);
                }
                if (sec > 0 && sec % 60 == 0)
                {
                    sec = 0;
                    min += 1;
                }
                timer = "";

                if (min < 10)
                {
                    timer += "0" + min.ToString();
                }
                else
                {
                    timer += min.ToString();
                }

                timer += ":";

                if (sec < 10)
                {
                    timer += "0" + sec.ToString();
                }
                else
                {
                    timer += sec.ToString();
                }
                time.Text = timer;
            }
            if (calculation.y <= 0)
            {
                timer1.Stop();
                timer_bool = false;
                timer = "00:00";
                time_now = 0;
                min = 0;
            }
            forDistance.Text = calculation.x.ToString();
        }

    }
}
