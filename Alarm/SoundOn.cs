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
    public partial class SoundOn : Form
    {
        Thread th;

        public SoundOn()
        {
            InitializeComponent();
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
