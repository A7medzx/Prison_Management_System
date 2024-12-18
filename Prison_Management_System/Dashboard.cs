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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void BtnPrisoners_Click(object sender, EventArgs e)
        {
            Prisoners prisoner = new Prisoners();
            prisoner.Show();


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void BtnVisitors_Click(object sender, EventArgs e)
        {
            Visitors visitor = new Visitors();
            visitor.Show();

        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();

        }

        private void BtnDataGridView_Click(object sender, EventArgs e)
        {

            //dgv=datagridview
            DataGridView dgv = new DataGridView();
            dgv.Show();
            
        }
    }
}
