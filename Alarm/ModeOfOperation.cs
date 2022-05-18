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
    public partial class ModeOfOperation : Form
    {
        public bool forHour;
        public bool forMinute;
        public int hour;
        public int minute;
        public int countForHours;
        public int countForMinutes;
        private string newTime;
   

        public string NewTime
        {
            get
            {
                return newTime;
            }
            set
            {
                newTime = value;
            }
        }
        public ModeOfOperation()
        {
            InitializeComponent();
            forHour = false;
            forMinute = false;
            countForHours = 0;
            countForMinutes = 0;
            hour = 0;
            minute = 0;
            Save_button.Enabled = false;
        }
        private void Null_button_Click(object sender, EventArgs e)
        {
            if (forHour)
                countForHours++;
            else if (forMinute)
                countForMinutes++;
            if (countForHours == 1 || countForMinutes == 1)
            {
                if(forHour)
                hour = 0;
                if(forMinute)
                minute = 0;
            }
            else if (countForHours == 2 || countForMinutes == 2)
            {
                if (forHour)
                {
                    if (hour == 1)
                        hour = 10;
                    else if (hour == 2)
                        hour = 20;
                }
                if (forMinute)
                {
                    if (minute == 1)
                        minute = 10;
                    else if (minute == 2)
                        minute = 20;
                    else if (minute == 3)
                        minute = 30;
                    else if (minute == 4)
                        minute = 40;
                    else if (minute == 5)
                        minute = 50;
                    else if (minute >= 6)
                        minute = 0;
                }
                countForHours = 0;
                countForMinutes = 0;
            }
            if (forHour)
                DrawTimeHour();
            else if (forMinute)
                DrawTimeMinute();
        }

        private void One_button_Click(object sender, EventArgs e)
        {
            if (forHour)
                countForHours++;
            else if (forMinute)
                countForMinutes++;
            if (countForHours == 1 || countForMinutes == 1)
            {
                if (forHour)
                    hour = 1;
                if(forMinute)
                minute = 1;
            }
            else if (countForHours == 2 || countForMinutes == 2)
            {
                if (forHour)
                {
                    if (hour == 2)
                        hour = 21;
                    else if (hour >= 3)
                        hour = 0;
                    else
                    {
                        hour = 11;
                    }
                }
                if (forMinute)
                {
                    if (minute == 1)
                        minute = 11;
                    else if (minute == 2)
                        minute = 21;
                    else if (minute == 3)
                        minute = 31;
                    else if (minute == 4)
                        minute = 41;
                    else if (minute == 5)
                        minute = 51;
                    else
                        minute = 0;
                }
                countForHours = 0;
                countForMinutes = 0;
            }
            if (forHour)
                DrawTimeHour();
            else if(forMinute)
                DrawTimeMinute();
        }

        private void Two_button_Click(object sender, EventArgs e)
        {
            if (forHour)
                countForHours++;
            if (forMinute)
                countForMinutes++;
            if (countForHours == 1 || countForMinutes == 1)
            {
                if(forHour)
                hour = 2;
                if(forMinute)
                minute = 2;
            }
            else if (countForHours == 2 || countForMinutes == 2)
            {
                if (forHour)
                {
                    if (hour == 1)
                        hour = 12;
                    else if (hour == 2)
                        hour = 22;
                    else if (hour >= 3)
                        hour = 0;
                }
                if (forMinute)
                {
                    if (minute == 1)
                        minute = 12;
                    else if (minute == 2)
                        minute = 22;
                    else if (minute == 3)
                        minute = 32;
                    else if (minute == 4)
                        minute = 42;
                    else if (minute == 5)
                        minute = 52;
                    else
                        minute = 0;
                }
                countForHours = 0;
                countForMinutes = 0;
            }
            if (forHour)
                DrawTimeHour();
            else if (forMinute)
                DrawTimeMinute();
        }

        private void Tree_button_Click(object sender, EventArgs e)
        {
            if (forHour)
                countForHours++;
            else if (forMinute)
                countForMinutes++;
            if (countForHours == 1 || countForMinutes == 1)
            {
                if(forHour)
                hour = 3;
                if(forMinute)
                minute = 3;
            }
            else if (countForHours == 2 || countForMinutes == 2)
            {
                if (forHour)
                {
                    if (hour == 1)
                        hour = 13;
                    else if (hour == 2)
                        hour = 23;
                    else if (hour >= 3)
                        hour = 0;
                }
                if (forMinute)
                {
                    if (minute == 1)
                        minute = 13;
                    else if (minute == 2)
                        minute = 23;
                    else if (minute == 3)
                        minute = 33;
                    else if (minute == 4)
                        minute = 43;
                    else if (minute == 5)
                        minute = 53;
                    else
                        minute = 0;
                }
                countForHours = 0;
                countForMinutes = 0;
            }
            if (forHour)
                DrawTimeHour();
            else if (forMinute)
                DrawTimeMinute();
        }

        private void Four_button_Click(object sender, EventArgs e)
        {
            if (forHour)
                countForHours++;
            else if (forMinute)
                countForMinutes++;
            if (countForHours == 1 || countForMinutes == 1)
            {
                if(forHour)
                hour = 4;
                if(forMinute)
                minute = 4;
            }
            else if (countForHours == 2 || countForMinutes == 2)
            {
                if (forHour)
                {
                    if (hour == 1)
                        hour = 14;
                    else if (hour == 2)
                        hour = 24;
                    else if (hour >= 3)
                        hour = 0;
                }
                if (forMinute)
                {
                    if (minute == 1)
                        minute = 14;
                    else if (minute == 2)
                        minute = 24;
                    else if (minute == 3)
                        minute = 34;
                    else if (minute == 4)
                        minute = 44;
                    else if (minute == 5)
                        minute = 54;
                    else
                        minute = 0;
                }
                countForHours = 0;
                countForMinutes = 0;
            }
            if (forHour)
                DrawTimeHour();
            else if (forMinute)
                DrawTimeMinute();
        }

        private void Five_button_Click(object sender, EventArgs e)
        {
            if (forHour)
                countForHours++;
            else if (forMinute)
                countForMinutes++;
            if (countForHours == 1 || countForMinutes == 1)
            {
                if(forHour)
                hour = 5;
                if(forMinute)
                minute = 5;
            }
            else if (countForHours == 2 || countForMinutes == 2)
            {
                if (forHour)
                {
                    if (hour == 1)
                        hour = 15;
                    else if (hour >= 2)
                    {
                        hour = 0;
                    }
                }
                if (forMinute)
                {
                    if (minute == 1)
                        minute = 15;
                    else if (minute == 2)
                        minute = 25;
                    else if (minute == 3)
                        minute = 35;
                    else if (minute == 4)
                        minute = 45;
                    else if (minute == 5)
                        minute = 55;
                    else
                        minute = 0;
                }
                countForHours = 0;
                countForMinutes = 0;
            }
            if (forHour)
                DrawTimeHour();
            else if (forMinute)
                DrawTimeMinute();
        }

        private void Six_button_Click(object sender, EventArgs e)
        {
            if (forHour)
                countForHours++;
            else if (forMinute)
                countForMinutes++;
            if (countForHours == 1 || countForMinutes == 1)
            {
                if(forHour)
                hour = 6;
                if(forMinute)
                minute = 6;
            }
            else if (countForHours == 2 || countForMinutes == 2)
            {
                if (forHour)
                {
                    if (hour == 1)
                        hour = 16;
                    else if (hour >= 2)
                    {
                        hour = 0;
                    }
                }
                if (forMinute)
                {
                    if (minute == 1)
                        minute = 16;
                    else if (minute == 2)
                        minute = 26;
                    else if (minute == 3)
                        minute = 36;
                    else if (minute == 4)
                        minute = 46;
                    else if (minute == 5)
                        minute = 56;
                    else
                        minute = 0;
                }
                countForHours = 0;
                countForMinutes = 0;
            }
            if (forHour)
                DrawTimeHour();
            else if (forMinute)
                DrawTimeMinute();
        }

        private void Seven_button_Click(object sender, EventArgs e)
        {
            if (forHour)
                countForHours++;
            else if (forMinute)
                countForMinutes++;
            if (countForHours == 1 || countForMinutes == 1)
            {
                if(forHour)
                hour = 7;
                if(forMinute)
                minute = 7;
            }
            else if (countForHours == 2 || countForMinutes == 2)
            {
                if (forHour)
                {
                    if (hour == 1)
                        hour = 17;
                    else if (hour >= 2)
                    {
                        hour = 0;
                    }
                }
                if (forMinute)
                {
                    if (minute == 1)
                        minute = 17;
                    else if (minute == 2)
                        minute = 27;
                    else if (minute == 3)
                        minute = 37;
                    else if (minute == 4)
                        minute = 47;
                    else if (minute == 5)
                        minute = 57;
                    else
                        minute = 0;
                }
                countForHours = 0;
                countForMinutes = 0;
            }
            if (forHour)
                DrawTimeHour();
            else if (forMinute)
                DrawTimeMinute();
        }

        private void Eight_button_Click(object sender, EventArgs e)
        {
            if (forHour)
                countForHours++;
            else if (forMinute)
                countForMinutes++;
            if (countForHours == 1 || countForMinutes == 1)
            {
                if(forHour)
                hour = 8;
                if(forMinute)
                minute = 8;
            }
            else if (countForHours == 2 || countForMinutes == 2)
            {
                if (forHour)
                {
                    if (hour == 1)
                        hour = 18;
                    else if (hour >= 2)
                    {
                        hour = 0;
                    }
                }
                if (forMinute)
                {
                    if (minute == 1)
                        minute = 18;
                    else if (minute == 2)
                        minute = 28;
                    else if (minute == 3)
                        minute = 38;
                    else if (minute == 4)
                        minute = 48;
                    else if (minute == 5)
                        minute = 58;
                    else
                        minute = 0;
                }
                countForHours = 0;
                countForMinutes = 0;
            }
            if (forHour)
                DrawTimeHour();
            else if (forMinute)
                DrawTimeMinute();
        }

        private void Nine_button_Click(object sender, EventArgs e)
        {
            if (forHour)
                countForHours++;
            else if (forMinute)
                countForMinutes++;
            if (countForHours == 1 || countForMinutes == 1)
            {
                if(forHour)
                hour = 9;
                if(forMinute)
                minute = 9;
            }
            else if (countForHours == 2 || countForMinutes == 2)
            {
                if (forHour)
                {
                    if (hour == 1)
                        hour = 19;
                    else if (hour >= 2)
                    {
                        hour = 0;
                    }
                }
                if (forMinute)
                {
                    if (minute == 1)
                        minute = 19;
                    else if (minute == 2)
                        minute = 29;
                    else if (minute == 3)
                        minute = 39;
                    else if (minute == 4)
                        minute = 49;
                    else if (minute == 5)
                        minute = 59;
                    else
                        minute = 0;
                }
                countForHours = 0;
                countForMinutes = 0;
            }
            if (forHour)
                DrawTimeHour();
            else if (forMinute)
                DrawTimeMinute();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            if (forHour)
            { 
                Hours_TextBox.Text = "";
                hour = 0;
            }
            if (forMinute)
            {
                Minutes_TextBox.Text = "";
                minute = 0;
            }
        }

        private void DrawTimeHour()
        {
            Hours_TextBox.Text = String.Format("{0:00}", hour);
        }
        private void DrawTimeMinute()
        {
            Minutes_TextBox.Text = String.Format("{0:00}", minute);
        }


        private void Apply_button_Click(object sender, EventArgs e)
        {
            NewTime = Hours_TextBox.Text + ":" + Minutes_TextBox.Text + ":" +"00";
            Alarms_listBox.Items.Add(String.Format("{0:00}", NewTime));
        }

        private void ChangeHour_button_Click(object sender, EventArgs e)
        {
            forHour = true;
            Save_button.Enabled = true;
            forMinute = false;
        }

        private void ChangeMinute_button_Click(object sender, EventArgs e)
        {
            forMinute = true;
            Save_button.Enabled = true;
            forHour = false;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
