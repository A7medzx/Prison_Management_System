using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinForms = System.Windows.Forms;


namespace Prison_Management_System
{
    public partial class Staff : Form
    {
        FileStream myFile;
        StreamReader sr;
        StreamWriter sw;
        string fileName;
        private Dictionary<WinForms.TextBox, WinForms.TextBox> navigationMap;

        public Staff()
        {
            InitializeComponent();
            InitializeNavigationMap();
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }
        private void Add_Click(object sender, EventArgs e)
        {
            myFile = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(myFile);
            sw.WriteLine(textBox1.Text + "-" + textBox2.Text + "-" + textBox3.Text + "-" + textBox4.Text);
            sw.Close();
            myFile.Close();
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void search_Click(object sender, EventArgs e)
        {
            myFile = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
            sw = new StreamWriter(myFile);
            sr = new StreamReader(myFile);
            myFile.Seek(0, SeekOrigin.Begin);
            int Staff_ID = int.Parse(textBox1.Text);
            string line;
            string[] field;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains("*"))
                {
                    continue;
                }
                field = line.Split('-');
                if (int.Parse(field[0]) == Staff_ID)

                {
                    textBox2.Text = field[1];
                    textBox3.Text = field[2];
                    textBox4.Text = field[3];

                    return;
                }
            }
            MessageBox.Show("Staff Not Found");
        }

        private void edit_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(fileName);
            bool found = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('-');
                if (parts[0] == textBox1.Text)

                {
                    lines[i] = $"{textBox1.Text}-" +
                    $"{(string.IsNullOrWhiteSpace(textBox1.Text) ? parts[1] : textBox1.Text)}-" +
                    $"{(string.IsNullOrWhiteSpace(textBox2.Text) ? parts[2] : textBox2.Text)}-" +
                    $"{(string.IsNullOrWhiteSpace(textBox3.Text) ? parts[3] : textBox3.Text)}-" +
                    $"{(string.IsNullOrWhiteSpace(textBox4.Text) ? parts[4] : textBox4.Text)}-";
                    found = true;
                    break;
                }
            }
            if (found)
            {
                File.WriteAllLines(fileName, lines);
                MessageBox.Show("Staff Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Staff not Found!");
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            myFile = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
            sw = new StreamWriter(myFile);
            sr = new StreamReader(myFile);
            myFile.Seek(0, SeekOrigin.Begin);
            myFile.Flush();
            sw.Flush();
            int iv = int.Parse(textBox1.Text);
            string line;
            string[] field;
            int count = 0;
            while ((line = sr.ReadLine()) != null)
            {
                field = line.Split('-');
                if (int.Parse(field[0]) == iv)
                {
                    myFile.Seek(count, SeekOrigin.Begin);
                    sw.Write("*");
                    sw.Flush();
                    myFile.Flush();
                }
                count += line.Length + 2;
            }

        }

        private void InitializeNavigationMap()
        {
            // Define the navigation map

            navigationMap = new Dictionary<WinForms.TextBox, WinForms.TextBox>
            {
                {textBox1, textBox2},
                {textBox2, textBox3},
                {textBox3, textBox4},
                {textBox4, textBox1} // Loop back to the first textbox
            };
            textBox1.Focus();

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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}