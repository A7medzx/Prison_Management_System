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
        private void insert_Click(object sender, EventArgs e)
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
        
        
        private void clearButton_Click(object sender, EventArgs e)
        {
            name.Text = crime.Text = duration.Text = cell.Text = natId.Text = "";
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


