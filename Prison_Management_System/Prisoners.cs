using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace Prison_Management_System
{
    public partial class Prisoners : Form
    {
        public Prisoners()
        {
            InitializeComponent();
        }
        FileStream myFile;
        StreamReader sr;
        StreamWriter sw;
        string fileName = @"D:\prisoners.txt";
        private void Prisoners_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            myFile = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(myFile);
            sw.WriteLine(ID.Text + "-" + National_ID.Text + "-" + fName.Text + "-" + Crime.Text + "-" + Duration.Text + "-" + Cell.Text);
            sw.Close();
            myFile.Close();
            ID.Text = fName.Text = Crime.Text = Duration.Text = Cell.Text = National_ID.Text = "";
            if (
    string.IsNullOrWhiteSpace(ID.Text) ||
    string.IsNullOrWhiteSpace(fName.Text) ||
    string.IsNullOrWhiteSpace(Crime.Text) ||
    string.IsNullOrWhiteSpace(Duration.Text) ||
    string.IsNullOrWhiteSpace(Cell.Text) ||
    string.IsNullOrWhiteSpace(National_ID.Text))
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
