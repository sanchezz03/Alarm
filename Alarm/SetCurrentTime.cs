using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class SetCurrentTime : Form
    {
        private int hour;
        private int minute;
        private bool isActiveForHour;
        private bool isActiveForMinute;
        private string newCurrentTime;
        Thread th;

        public int GetHour
        {
            get
            {
                return hour;
            }
            set
            {
                hour = value;
            }
        }
        public int GetMinute
        {
            get
            {
                return minute;
            }
            set
            {
                minute = value;
            }
        }
        public SetCurrentTime()
        {
            InitializeComponent();
        }

        private void SetHour_button_Click(object sender, EventArgs e)
        {
            isActiveForHour = true;
            isActiveForMinute = false;
        }

        private void Up_button_Click(object sender, EventArgs e)
        {
            if (isActiveForMinute)
            {
                if (minute > 60)
                {
                    minute = 0;
                }
                else
                    minute++;
            }
            else if(isActiveForHour)
            {
                if (hour >= 24)
                {
                    hour = 0;
                }
                else
                    hour++;
            }
            if (hour > 0 || minute > 0)
                Ok_button.Enabled = true;
            if(isActiveForHour)
                DrawTimeHour();
            else if (isActiveForMinute)
                DrawTimeMinute();
        }

        private void Down_button_Click(object sender, EventArgs e)
        {
            if (isActiveForMinute)
            {
                if (minute <= 0)
                {
                    minute = 59;
                }
                else
                    minute--;
            }
            else if (isActiveForHour)
            {
                if (hour <= 0)
                {
                    hour = 24;
                }
                else
                    hour--;
            }
            if (isActiveForHour)
                DrawTimeHour();
            else if (isActiveForMinute)
                DrawTimeMinute();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Ok_button.Enabled = false;
            isActiveForHour = false;
            isActiveForMinute = false;
            minute = 0;
            hour = 0;
        }

        private void SetMinute_button_Click(object sender, EventArgs e)
        {
            isActiveForMinute = true;
            isActiveForHour = false;
        }

        private void DrawTimeHour()
        {
            Hour_label.Text = String.Format("{0:00}", hour);
        }
        private void DrawTimeMinute()
        {
            Minute_label.Text = String.Format("{0:00}", minute);
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
