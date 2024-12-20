using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prison_Management_System
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            string value = Login.sharedVariable;
            label6.Text = value;
            this.PnlPrisonersForm2.Controls.Clear();
            Prisoners frmprisoners = new Prisoners() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmprisoners.FormBorderStyle = FormBorderStyle.None;
            this.PnlPrisonersForm2.Controls.Add(frmprisoners);
            frmprisoners.Show();
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void BtnVisitors_Click(object sender, EventArgs e)
        {
            this.PnlPrisonersForm2.Controls.Clear();
            Visitors frmvisitors = new Visitors() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmvisitors.FormBorderStyle = FormBorderStyle.None;
            this.PnlPrisonersForm2.Controls.Add(frmvisitors);
            frmvisitors.Show();
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            this.PnlPrisonersForm2.Controls.Clear();
            Staff frmstaff = new Staff() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmstaff.FormBorderStyle = FormBorderStyle.None;
            this.PnlPrisonersForm2.Controls.Add(frmstaff);
            frmstaff.Show();
        }

        private void BtnDataGridView_Click(object sender, EventArgs e)
        {
            this.PnlPrisonersForm2.Controls.Clear();
            AdminGrid frmdashboard = new AdminGrid() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmdashboard.FormBorderStyle = FormBorderStyle.None;
            this.PnlPrisonersForm2.Controls.Add(frmdashboard);
            frmdashboard.Show();
        }

        private void BtnPrisoners_Click_1(object sender, EventArgs e)
        {
            this.PnlPrisonersForm2.Controls.Clear();
            Prisoners frmprisoners = new Prisoners() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmprisoners.FormBorderStyle = FormBorderStyle.None;
            this.PnlPrisonersForm2.Controls.Add(frmprisoners);
            frmprisoners.Show();
        }
        private void YourForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        
    }
}
