﻿using System;
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
        }

        private void Visitors_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 50; // Corner radius
            int width = insert.Width;
            int height = insert.Height;

            // Define rounded rectangle path
            path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
            path.AddArc(width - radius, 0, radius, radius, 270, 90); // Top-right corner
            path.AddArc(width - radius, height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(0, height - radius, radius, radius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            insert.Region = new Region(path);

        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(natId.Text) || string.IsNullOrWhiteSpace(prsrId.Text) || string.IsNullOrWhiteSpace(rel.Text) || string.IsNullOrWhiteSpace(date.Text))
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

        }

        private void delete_Click(object sender, EventArgs e)
        {
            file = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
            sw = new StreamWriter(file);
            sr = new StreamReader(file);
            file.Seek(0, SeekOrigin.Begin);
            file.Flush();
            sw.Flush();
            int pId = int.Parse(prsrId.Text);
            int nId = int.Parse(natId.Text);
            string line;
            string[] field;
            int count = 0;
            while ((line = sr.ReadLine()) != null)
            {
                field = line.Split('|');
                if (int.Parse(field[0]) == pId)
                {
                    file.Seek(count, SeekOrigin.Begin);
                    sw.Write("*");
                    sw.Flush();
                    file.Flush();
                }
                count += line.Length + 2;
            }
        }
        private void search_Click(object sender, EventArgs e)
        {
            file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            sw = new StreamWriter(file);
            sr = new StreamReader(file);
            file.Seek(0, SeekOrigin.Begin);
            int pId = int.Parse(prsrId.Text);
            int nId = int.Parse(natId.Text);
            string line;
            string[] field;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains("*"))
                {
                    continue;
                }
                field = line.Split('|');
                if (int.Parse(field[0]) == pId)
                {
                    name.Text = field[1];
                    natId.Text = field[2];
                    prsrId.Text = field[3];
                    rel.Text = field[4];
                    date.Text = field[5];
                    MessageBox.Show("Visit Found");
                    return;
                }
            }
            MessageBox.Show("Visit Not found");
        }

        private void clear_Click(object sender, EventArgs e)
        {
            name.Text = natId.Text = prsrId.Text = rel.Text = date.Text = "";
        }
        private void edit_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(fileName);
            bool found = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                if (parts[0] == natId.Text)
                {
                    lines[i] = $"{natId.Text}|" +
                    $"{(string.IsNullOrWhiteSpace(prsrId.Text) ? parts[1] : prsrId.Text)}|" +
                    $"{(string.IsNullOrWhiteSpace(name.Text) ? parts[2] : name.Text)}|" +
                    $"{(string.IsNullOrWhiteSpace(rel.Text) ? parts[3] : rel.Text)}|" +
                    $"{(string.IsNullOrWhiteSpace(date.Text) ? parts[4] : date.Text)}";
                    found = true;
                    break;
                }
            }
            if (found)
            {
                File.WriteAllLines(fileName, lines);
                MessageBox.Show("Visit Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Visit not Found!");
            }
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
            {rel, date},
            {date, name} // Loop back to the first textbox
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
    }
}
