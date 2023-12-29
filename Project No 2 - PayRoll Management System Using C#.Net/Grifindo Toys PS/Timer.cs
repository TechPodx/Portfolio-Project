using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys_PS
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        int startpoint1 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            ProgressBar1.Value = startpoint;
            if (ProgressBar1.Value == 100)
            {
                ProgressBar1.Value = 0;
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            startpoint1 += 1;
            ProgressBar2.Value = startpoint1;
            if (ProgressBar2.Value == 100)
            {
                ProgressBar2.Value = 0;
                timer2.Stop();
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void Timer_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (ProgressBar1.Value == 0)
            {
                timer2.Start();
            }
        }
    }
}
