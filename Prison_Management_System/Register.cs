using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinForms = System.Windows.Forms;
using System.ComponentModel;


namespace Prison_Management_System
{
    public partial class Register : Form
    {
        private Dictionary<WinForms.TextBox, WinForms.TextBox> navigationMap;

        public Register()
        {
            InitializeComponent();
            InitializeNavigationMap();
        }

        FileStream myfile;
        StreamWriter sr;
        string filename = @"../../../Database_Files/Users Records.txt";
        string idFile = @"../../../Database_Files/UID.txt";

        private void Register_Load(object sender, EventArgs e)
        {

            int newId = GenerateNewId();
            id.Text = newId.ToString();
            id.ReadOnly = true;
        }

        private void insert_Click(object sender, EventArgs e)
        {

            // Check for empty fields
            if (string.IsNullOrWhiteSpace(fName.Text) ||
                string.IsNullOrWhiteSpace(lName.Text) ||
                string.IsNullOrWhiteSpace(email.Text) ||
                string.IsNullOrWhiteSpace(pass.Text))
            {
                MessageBox.Show("All Fields are Required. Please Fill in All Fields.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Keep the form open, don't proceed
            }

            // Validate password
            if (!ValidatePassword(pass.Text))
            {
                MessageBox.Show("Password Must be at Least 8 Characters Long and Include:\n- at Least One Uppercase Letter\n- at Least One Lowercase Letter\n- at Least one number\n- at least one special character",
                    "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Keep the form open, don't proceed
            }

            try
            {
                string data = id.Text + "|" + fName.Text + "|" + lName.Text + "|" + email.Text + "|" + pass.Text;

                myfile = new FileStream(filename, FileMode.Append, FileAccess.Write);
                sr = new StreamWriter(myfile);
                sr.WriteLine(data);
                sr.Close();
                myfile.Close();

                File.WriteAllText(idFile, id.Text);

                fName.Text = lName.Text = email.Text = pass.Text = "";

                MessageBox.Show("User Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Login form = new Login();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("an Error Occurred While Saving The Data: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GenerateNewId()
        {
            int currentId = 1000;
            int lastId = 0;
            if (File.Exists(idFile))
            {
                string[] lines = File.ReadAllLines(idFile); // Read all lines
                if (lines.Length > 0) //checks if there are any IDs or No
                {
                    string lastLine = lines[^1]; // Get the last line
                    if (int.TryParse(lastLine, out lastId)) //checks if the last line is a valid integer. If valid, it updates currentId with lastId.
                    {
                        currentId = lastId;
                    }
                }
            }
            return currentId + 1;
        }

        private bool ValidatePassword(string password)
        {
            // Check if the password is at least 8 characters long
            if (password.Length < 8)
                return false;

            // Check if the password contains at least one uppercase letter
            if (!Regex.IsMatch(password, "[A-Z]"))
                return false;

            // Check if the password contains at least one lowercase letter
            if (!Regex.IsMatch(password, "[a-z]"))
                return false;

            // Check if the password contains at least one digit
            if (!Regex.IsMatch(password, "[0-9]"))
                return false;

            // Check if the password contains at least one special character
            if (!Regex.IsMatch(password, @"[\W_]"))
                return false;

            // All checks passed
            return true;
        }

        private void InitializeNavigationMap()
        {
            // Define the navigation map

            navigationMap = new Dictionary<WinForms.TextBox, WinForms.TextBox>
            {
                {fName, lName},
                {lName, email},
                {email, pass},
                {pass, fName} // Loop back to the first textbox
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

        private void button1_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Force exit if needed
            Environment.Exit(0);
        }
    }
}
