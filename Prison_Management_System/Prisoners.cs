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
        FileStream myFile;
        StreamReader sr;
        StreamWriter sw;
        string fileName = @"../../../Database_Files/Prisoners Records.txt";
        private Dictionary<WinForms.TextBox, WinForms.TextBox> navigationMap;
        string filePath = @"../../../Database_Files/PID.txt"; // File to store the last used ID
        int lastID = 0;

        public Prisoners()
        {
            InitializeComponent();
            InitializeNavigationMap();
            LoadLastID();
            id.Text = lastID.ToString("D4");
        }

        private void Prisoners_Load(object sender, EventArgs e)
        {

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id.Text) || string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(crime.Text) || string.IsNullOrWhiteSpace(duration.Text) || string.IsNullOrWhiteSpace(cell.Text) || string.IsNullOrWhiteSpace(natId.Text))
            {
                MessageBox.Show("Please Fill in All Fields!");
                return;
            }
            myFile = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(myFile);
            sw.WriteLine(id.Text + "|" + natId.Text + "|" + name.Text + "|" + crime.Text + "|" + duration.Text + "|" + cell.Text);
            sw.Close();
            myFile.Close();
            id.Text = name.Text = crime.Text = duration.Text = cell.Text = natId.Text = "";
            GenerateNewID();
            id.Text = lastID.ToString("D4");
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
            int idp = int.Parse(searchId.Text);
            string line;
            string[] field;
            int count = 0;
            while ((line = sr.ReadLine()) != null)
            {
                field = line.Split('|');
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
                int idnumber = int.Parse(searchId.Text);
                string line;
                string[] field;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("*"))
                    {
                        continue;
                    }
                    field = line.Split('|');
                    if (int.Parse(field[0]) == idnumber)
                    {
                        natId.Text = field[1];
                        name.Text = field[2];
                        crime.Text = field[3];
                        duration.Text = field[4];
                        cell.Text = field[5];
                        MessageBox.Show("Prisoner Found!");
                        return;
                    }
                }
                MessageBox.Show("Prisoner Not Found!");
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            name.Text = crime.Text = duration.Text = cell.Text = natId.Text = searchId.Text = "";
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(fileName);
            bool found = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                if (parts[0] == id.Text)
                {
                    lines[i] = $"{id.Text}|" +
                    $"{(string.IsNullOrWhiteSpace(natId.Text) ? parts[1] : natId.Text)}|" +
                    $"{(string.IsNullOrWhiteSpace(name.Text) ? parts[2] : name.Text)}|" +
                    $"{(string.IsNullOrWhiteSpace(crime.Text) ? parts[3] : crime.Text)}|" +
                    $"{(string.IsNullOrWhiteSpace(duration.Text) ? parts[4] : duration.Text)}|" +
                    $"{(string.IsNullOrWhiteSpace(cell.Text) ? parts[5] : cell.Text)}";
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
            id.Clear();
            name.Clear();
            crime.Clear();
            duration.Clear();
            cell.Clear();
            natId.Clear();
        }

        private void InitializeNavigationMap()
        {
            // Define the navigation map

            navigationMap = new Dictionary<WinForms.TextBox, WinForms.TextBox>
        {
            {id, name},
            {name, natId},
            {natId, crime},
            {crime, duration},
            {duration, cell},
            {cell, name} // Loop back to the first textbox
            };

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

        private void LoadLastID()
        {
            if (File.Exists(filePath)) // Check if the file exists
            {
                string content = File.ReadAllText(filePath); // Read the content
                if (int.TryParse(content, out lastID)) // Convert to integer
                {
                    lastID = int.Parse(content); // Successfully loaded ID
                }
                else
                {
                    lastID = 0; // Reset if file content is invalid
                }
            }
            else
            {
                File.WriteAllText(filePath, "0"); // Create the file with 0 if it doesn't exist
            }
        }

        // Method to generate a new ID
        private void GenerateNewID()
        {
            lastID++; // Increment the ID
            // Save the updated ID back to the file
            File.WriteAllText(filePath, lastID.ToString());
        }

        private void searchId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


