using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Prison_Management_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        FileStream myfile;
        StreamWriter sr;
        string filename = @"../../../Database_Files/Users Record.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            string data = fname.Text + "|" + lname.Text + "|" + email.Text + "|" + pass.Text;
            myfile=new FileStream(filename, FileMode.Append, FileAccess.Write);
            sr = new StreamWriter(myfile);
            sr.Write(data);
            sr.Close();
            myfile.Close();
            fname.Text=lname.Text=email.Text=pass.Text="";
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
