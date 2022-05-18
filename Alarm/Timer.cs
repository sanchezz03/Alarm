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
    public partial class Timer : Form
    {
        private int minutes;
        private int seconds;
        Thread th;
        public Timer()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Stop_button.Enabled = false;
            minutes = 0;
            seconds = 0;
            for (int i = 0; i <= 60; i++)
            {
                Second_ComboBox.Items.Add(i);
                if(i<=24)
                Minute_ComboBox.Items.Add(i);
            }

            Minute_ComboBox.Text = minutes.ToString();
            Second_ComboBox.Text = seconds.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
  
        public void openNewForm()
        {
            Application.Run(new AlarmGUI());
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            Start_button.Enabled = false;
            Stop_button.Enabled = true;

            minutes = int.Parse(Minute_ComboBox.SelectedItem.ToString());
            seconds = int.Parse(Second_ComboBox.SelectedItem.ToString());

            Hour_timer.Enabled = true;
            Second_timer.Enabled = true;
        }

        private void Stop_button_Click(object sender, EventArgs e)
        {
           Stop_button.Enabled = false;
           Start_button.Enabled = true;

            Hour_timer.Enabled = false;
            Second_timer.Enabled = false;
        }

        private void Minute_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Minutes_label.Text = Minute_ComboBox.Text;
        }

        private void Second_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Seconds_label.Text = Second_ComboBox.Text;
        }

        private void Second_timer_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                seconds--;
                Second_ComboBox.Text = seconds.ToString();
            }
            else if (minutes > 0 && seconds == 0)
            {
                minutes--;
                seconds = 59;
                Second_ComboBox.Text = seconds.ToString();
                Minute_ComboBox.Text = minutes.ToString();
            }
            else
            {
                Second_timer.Stop();
                MessageBox.Show("Timer has stoped");
                Stop_button.Enabled = false;
                Start_button.Enabled = true;
                Second_ComboBox.Text = seconds.ToString();
            }
            
        }
    }
}
