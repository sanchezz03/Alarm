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
    public partial class AlarmGUI : BaseAlarmGUIForm
    {
        //private int minute;
        //private int hour;
        private int second;
        private string currentTime;
        public bool changeCurrentTime;
        private bool timerOn;
        private bool firstAttempt;
        private bool first;
        //private Thread th;
        public AlarmGUI()
        {
            InitializeComponent();
         
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            On_button.Hide();
            Off_button.Hide();
            timerOn = false;
            firstAttempt = true;
            first = true;
        }
        private void TimeSettign_button_Click(object sender, EventArgs e)
        {
            SetCurrentTime setCurrentTime = new SetCurrentTime();
            if (setCurrentTime.ShowDialog() == DialogResult.OK)
            {
                timer.Stop();
                Hours = setCurrentTime.GetHour;
                Minutes = setCurrentTime.GetMinute;
                second = DateTime.Now.Second;
                timer2.Start();
            }
        }
        public void openNewForm2()
        {
            Application.Run(new SetCurrentTime());
        }

        public void openNewForm3()
        {
            Application.Run(new Timer());
        }

        public void openNewForm4()
        {
            Application.Run(new ModeOfOperation());
        }

        public void openNewForm5()
        {
            Application.Run(new SoundOn());
        }
        public void openNewForm6()
        {
            Application.Run(new Radio());
        }
        private void Timer_button_Click(object sender, EventArgs e)
        {
            Thread = new Thread(openNewForm3);
            Thread.SetApartmentState(ApartmentState.STA);
            Thread.Start();
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Time_label.Text = DateTime.Now.ToLongTimeString();
            Hours = DateTime.Now.Hour;
            Minutes = DateTime.Now.Minute;
            second = DateTime.Now.Second;
            if(timerOn)
            Ring_Alarm();
        }

        private void ModeOfOperation_button_Click(object sender, EventArgs e)
        {
            ModeOfOperation modeOfOperation = new ModeOfOperation();
            if (modeOfOperation.ShowDialog() == DialogResult.OK)
            {
                AlarmGui_listbox.Items.Add(modeOfOperation.NewTime);
            }
        }
        public void Ring_Alarm()
        {
            currentTime = $"{Hours}:{Minutes}:{second}";
            //currentTime = string.Format("{0:D2}:{1:00}:{2:d2}", hour, minute, second);
            string userTime = AlarmGui_listbox.Text;
            if (currentTime == userTime&&firstAttempt!=false)
            {
                Thread = new Thread(openNewForm5);
                Thread.SetApartmentState(ApartmentState.STA);
                Thread.Start();
                this.Close();
            }
        }
         private void On_button_Click(object sender, EventArgs e)
        {
            Off_button.Show();
            On_button.Hide();
            timerOn = true;
        }

        private void Off_button_Click(object sender, EventArgs e)
        {
            Off_button.Hide();
            timerOn = false;
        }

        private void AlarmGui_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            On_button.Show();
        }

        private void Radio_button_Click(object sender, EventArgs e)
        {
            Thread = new Thread(openNewForm6);
            Thread.SetApartmentState(ApartmentState.STA);
            Thread.Start();
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now;
            second = DateTime.Now.Second;
            if (DateTime.Now.Second == 59&&first)
            {
                if (Minutes < 59)
                {
                    if(DateTime.Now.Second == 59&&first)
                    { 
                        Minutes++;
                        second = 0;
                        first = false;
                    }
                }
                else
                    Minutes = 0;
            }
                       dt = dt.Date.Add(new TimeSpan(Hours, Minutes, second));
            Time_label.Text = string.Format("{0:D2}:{1:00}:{2:d2}", dt.Hour,dt.Minute,dt.Second);
            if (DateTime.Now.Second == 0)
                first = true;
            if (timerOn)
                Ring_Alarm();
        }
    }
}
