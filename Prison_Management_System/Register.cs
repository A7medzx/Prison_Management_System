using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        string filename = @"../../../Database_Files/Users Records.txt";
        string idFile = @"../../../Database_Files/UID.txt";

        private void Register_Load(object sender, EventArgs e)
        {

            int newId = GenerateNewId();
            id.Text = newId.ToString();
            id.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Check for empty fields
            if (string.IsNullOrWhiteSpace(fname.Text) ||
                string.IsNullOrWhiteSpace(lname.Text) ||
                string.IsNullOrWhiteSpace(email.Text) ||
                string.IsNullOrWhiteSpace(pass.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all fields.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Keep the form open, don't proceed
            }

            // Validate password
            if (!ValidatePassword(pass.Text))
            {
                MessageBox.Show("Password must be at least 8 characters long and include:\n- At least one uppercase letter\n- At least one lowercase letter\n- At least one number\n- At least one special character",
                    "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Keep the form open, don't proceed
            }

            try
            {
                string data = id.Text + "|" + fname.Text + "|" + lname.Text + "|" + email.Text + "|" + pass.Text;

                myfile = new FileStream(filename, FileMode.Append, FileAccess.Write);
                sr = new StreamWriter(myfile);
                sr.WriteLine(data);
                sr.Close();
                myfile.Close();

                File.WriteAllText(idFile, id.Text);

                fname.Text = lname.Text = email.Text = pass.Text = "";

                MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Login form = new Login();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the data: " + ex.Message,
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















    }
}
