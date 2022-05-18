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
    public partial class Radio : Form
    {
        private int choice;
        private bool wasHideGerman;
        private bool wasHideUkraine;
        private bool wasHideAmerica;
        private Thread th;

        public Radio()
        {
            InitializeComponent();
            German_PictureBox.Hide();
            wasHideGerman = true;
            American_PictureBox.Hide();
            wasHideAmerica = true;
            Ukraine_PictureBox.Hide();
            wasHideUkraine = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            choice  = listBox1.SelectedIndex;
            switch (choice)
            {
                case 1:
                    textBox1.Text = "Germany Radio";
                    if (wasHideUkraine == false)
                    {
                        wasHideUkraine = true;
                        Ukraine_PictureBox.Hide();
                    }
                    else if (wasHideAmerica == false)
                    {
                        wasHideAmerica = true;
                        American_PictureBox.Hide();
                    }
                        German_PictureBox.Show();
                    wasHideGerman = false;
                    break;
                case 3:
                    textBox1.Text = "American Radio";
                    if (wasHideUkraine == false)
                    {
                        wasHideUkraine = true;
                        Ukraine_PictureBox.Hide();
                    }
                    else if(wasHideGerman == false)
                    {
                        wasHideGerman = true;
                        German_PictureBox.Hide();
                    }
                    American_PictureBox.Show();
                    wasHideAmerica = false;
                    break;
                case 5:
                    textBox1.Text = "Ukraine Radio";
                    if (wasHideGerman == false)
                    {
                        wasHideGerman = true;
                        German_PictureBox.Hide();
                    }
                    else if (wasHideAmerica == false)
                    {
                        wasHideAmerica = true;
                        American_PictureBox.Hide();   
                    }
                    Ukraine_PictureBox.Show();
                    wasHideUkraine = false;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Leave_Form();
        }
        public void Leave_Form()
        {
            th = new Thread(Open_New_Form);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        public void Open_New_Form()
        {
            Application.Run(new AlarmGUI());
        }

    }
}
