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
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.LinkLabel;

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
        string fileName = @"D:\pris.txt";
        private void Prisoners_Load(object sender, EventArgs e)
        {

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrWhiteSpace(ID.Text) || string.IsNullOrWhiteSpace(fName.Text) || string.IsNullOrWhiteSpace(Crime.Text) ||string.IsNullOrWhiteSpace(Duration.Text) ||string.IsNullOrWhiteSpace(Cell.Text) || string.IsNullOrWhiteSpace(National_ID.Text))
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }
            myFile = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(myFile);
            sw.WriteLine(ID.Text + "-" + National_ID.Text + "-" + fName.Text + "-" + Crime.Text + "-" + Duration.Text + "-" + Cell.Text);
            sw.Close();
            myFile.Close();
            ID.Text = fName.Text = Crime.Text = Duration.Text = Cell.Text = National_ID.Text = "";
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            myFile = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
            sw = new StreamWriter(myFile);
            sr = new StreamReader(myFile);
            myFile.Seek(0, SeekOrigin.Begin);
            myFile.Flush();
            sw.Flush();
            int idp = int.Parse(ID.Text);
            string line;
            string[] field;
            int count = 0;
            while ((line = sr.ReadLine()) != null)
            {
                field = line.Split('-');
                if (int.Parse(field[0]) == idp)
                {
                    myFile.Seek(count, SeekOrigin.Begin);
                    sw.Write("*");
                    sw.Flush();
                    myFile.Flush();
                }
                count += line.Length + 2;
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            {
                myFile = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
                sw = new StreamWriter(myFile);
                sr = new StreamReader(myFile);
                myFile.Seek(0, SeekOrigin.Begin);
                int idnumber = int.Parse(ID.Text);
                string line;
                string[] field;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("*"))
                    {
                        continue; 
                    }
                    field = line.Split('-');
                        if (int.Parse(field[0]) == idnumber)
                    {
                        National_ID.Text = field[1];
                        fName.Text = field[2];
                        Crime.Text = field[3];
                        Duration.Text = field[4];
                        Cell.Text = field[5];
                        MessageBox.Show("Found prisoner");
                        return;
                    }
                }
                MessageBox.Show("Not found prisoner");
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            ID.Text = fName.Text = Crime.Text = Duration.Text = Cell.Text = National_ID.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
                string[] lines = File.ReadAllLines(fileName); 
                bool found = false;
                for (int i = 0; i < lines.Length; i++) 
                {
                    string[] parts = lines[i].Split('-'); 
                    if (parts[0] == ID.Text) 
                    {
                        lines[i] = $"{ID.Text}-{National_ID.Text}-{fName.Text}-{Crime.Text}-{Duration.Text}-{Cell.Text}"; 
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    File.WriteAllLines(fileName, lines); 
                    MessageBox.Show("Prisoner updated successfully!");
                }
                else
                {
                    MessageBox.Show("Prisoner not found!");
                }
                ID.Clear();
                fName.Clear();
                Crime.Clear();
                Duration.Clear();
                Cell.Clear();
                National_ID.Clear();
            }
        }
    }


