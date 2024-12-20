using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Prison_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            string value = Login.sharedVariable;
            label1.Text = value;
            this.PnlPrisonersForm2.Controls.Clear();
            Prisoners frmprisoners = new Prisoners() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmprisoners.FormBorderStyle = FormBorderStyle.None;
            this.PnlPrisonersForm2.Controls.Add(frmprisoners);
            frmprisoners.Show();
        }

        private void BtnPrisoners_Click(object sender, EventArgs e)
        {
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
            MainForm frmdashboard = new MainForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmdashboard.FormBorderStyle = FormBorderStyle.None;
            this.PnlPrisonersForm2.Controls.Add(frmdashboard);
            frmdashboard.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void YourForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }
    }
}
