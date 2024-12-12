using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;


namespace Prison_Management_System
{
    public partial class Visitors : Form
    {
        FileStream file;
        StreamReader sr;
        StreamWriter sw;
        string fileName = @"C:\\Users\\Salma\\Desktop\\test.txt";

        public Visitors()
        {
            InitializeComponent();
        }

        private void Visitors_Load(object sender, EventArgs e)
        {
        }

        private void insert_Click(object sender, EventArgs e)
        {
            string data = name.Text + " | " + natId.Text + " | " + prsrId.Text + " | " + rel.Text + " | " + date.Text;
            file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            sw = new StreamWriter(file);
            sw.WriteLine(data);
            sw.Close();
            file.Close();
        }
    }
}
