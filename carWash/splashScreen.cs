using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carWash
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;

            if (panel2.Width >= 200)
            {
                timer1.Stop();
                Form1 fm1 = new Form1();
                fm1.Show();
                this.Hide();
            }
        }
    }
}
