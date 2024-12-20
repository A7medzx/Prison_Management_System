using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prison_Management_System
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 2;
            if (panel2.Width >= 605)
            {
                timer1.Stop();
                Login fm1 = new Login();
                fm1.Show();
                this.Hide();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop and dispose timer
            timer1.Stop();
            timer1.Dispose();

            // Other cleanup code...

            // Ensure the application exits properly
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Force exit if needed
            Environment.Exit(0);
        }


    }
}
