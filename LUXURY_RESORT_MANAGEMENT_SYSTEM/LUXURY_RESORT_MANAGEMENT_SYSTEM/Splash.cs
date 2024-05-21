using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUXURY_RESORT_MANAGEMENT_SYSTEM
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int startPoint = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            startPoint += 1;
            myProgressBar.Value = startPoint;
            if (myProgressBar.Value == 30)
            {
                myProgressBar.Value = 0;
                timer1.Stop();
                Form1 fn = new Form1();
                this.Hide();
                fn.Show();

            }
        }
        private void Splash_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
