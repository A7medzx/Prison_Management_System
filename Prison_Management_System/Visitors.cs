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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinForms = System.Windows.Forms;

namespace Prison_Management_System
{
    public partial class Visitors : Form
    {
        FileStream file;
        StreamReader sr;
        StreamWriter sw;
        string fileName = @"../../../Database_Files/Visitors Records.txt";
        private Dictionary<WinForms.TextBox, WinForms.TextBox> navigationMap;
        string filePath = @"../../../Database_Files/VID.txt"; // File to store the last used ID
        int lastID = 0;
        public Visitors()
        {
            InitializeComponent();
            InitializeNavigationMap();
            LoadLastID();
            visitId.Text = lastID.ToString("D4");
            currentDate();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(natId.Text) || string.IsNullOrWhiteSpace(prsrId.Text) || string.IsNullOrWhiteSpace(rel.Text))
            {
                MessageBox.Show("Please Fill in All Fields!");
                return;
            }
            string data = visitId.Text + "|" + name.Text + "|" + natId.Text + "|" + prsrId.Text + "|" + rel.Text + "|" + date.Text;
            file = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(file);
            sw.WriteLine(data);
            sw.Close();
            file.Close();
            name.Text = natId.Text = prsrId.Text = rel.Text = date.Text = "";
            GenerateNewID();
            visitId.Text = lastID.ToString("D4");
            if (string.IsNullOrWhiteSpace(name.Text) && string.IsNullOrWhiteSpace(natId.Text) && string.IsNullOrWhiteSpace(prsrId.Text) && string.IsNullOrWhiteSpace(rel.Text))
                MessageBox.Show("Visit Inserted Successfully!");
        }

        private void clear_Click(object sender, EventArgs e)
        {
            name.Clear();
            natId.Clear();
            prsrId.Clear();
            rel.Clear();
            date.Clear();
        }

        private void InitializeNavigationMap()
        {
            // Define the navigation map

            navigationMap = new Dictionary<WinForms.TextBox, WinForms.TextBox>
            {
                {name, natId},
                {natId, prsrId},
                {prsrId, rel},
                {rel, name} // Loop back to the first textbox
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

        private void Visitors_Load(object sender, EventArgs e)
        {

        }

        private void currentDate()
        {
            date.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

    }
}
