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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinForms = System.Windows.Forms;


namespace Prison_Management_System
{
    public partial class Prisoners : Form
    {
        public Prisoners()
        {
            InitializeComponent();
            InitializeNavigationMap();
        }
        FileStream myFile;
        StreamReader sr;
        StreamWriter sw;
        string fileName = @"D:\pris.txt";
        private Dictionary<WinForms.TextBox, WinForms.TextBox> navigationMap;

        private void Prisoners_Load(object sender, EventArgs e)
        {

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ID.Text) || string.IsNullOrWhiteSpace(fName.Text) || string.IsNullOrWhiteSpace(Crime.Text) || string.IsNullOrWhiteSpace(Duration.Text) || string.IsNullOrWhiteSpace(Cell.Text) || string.IsNullOrWhiteSpace(National_ID.Text))
            {
                MessageBox.Show("Please Fill in All Fields!");
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
                        MessageBox.Show("Prisoner Found!");
                        return;
                    }
                }
                MessageBox.Show("Prisoner Not Found!");
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
                    lines[i] = $"{ID.Text}-" +
                    $"{(string.IsNullOrWhiteSpace(National_ID.Text) ? parts[1] : National_ID.Text)}-" +
                    $"{(string.IsNullOrWhiteSpace(fName.Text) ? parts[2] : fName.Text)}-" +
                    $"{(string.IsNullOrWhiteSpace(Crime.Text) ? parts[3] : Crime.Text)}-" +
                    $"{(string.IsNullOrWhiteSpace(Duration.Text) ? parts[4] : Duration.Text)}-" +
                    $"{(string.IsNullOrWhiteSpace(Cell.Text) ? parts[5] : Cell.Text)}";
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

        private void InitializeNavigationMap()
        {
            // Define the navigation map

            navigationMap = new Dictionary<WinForms.TextBox, WinForms.TextBox>
        {
            {ID, fName},
            {fName, National_ID},
            {National_ID, Crime},
            {Crime, Duration},
            {Duration, Cell},
            {Cell, fName} // Loop back to the first textbox
            };
            //fName.Focus();

            foreach (var pair in navigationMap.Keys)
            {
                pair.KeyDown += TextBox_KeyDown;
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent the "ding" sound

                var currentTextBox = sender as WinForms.TextBox;

                if (currentTextBox != null && navigationMap.ContainsKey(currentTextBox))
                {
                    // Move to the next textbox in the map
                    navigationMap[currentTextBox].Focus();
                }
            }
        }
    }
}


