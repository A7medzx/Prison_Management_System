using System.Diagnostics.Metrics;
using System.Xml.Linq;
using WinForms = System.Windows.Forms;

namespace Prison_Management_System
{
    public partial class Login : Form
    {
        private Dictionary<WinForms.TextBox, WinForms.TextBox> navigationMap;
        public Login()
        {
            InitializeComponent();
            InitializeNavigationMap();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static string sharedVariable = "";
        private void insert_Click(object sender, EventArgs e)
        {
            string emailInput = email.Text.Trim();
            string passwordInput = password.Text.Trim();

            // Check if fields are empty
            if (string.IsNullOrEmpty(emailInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Both Fields Must be Filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // File path to Users Records.txt
            string filePath = @"../../../Database_Files/Users Records.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Users Records File not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Read the file line by line
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] fields = line.Split('|');

                if (fields.Length < 5) continue;

                string emailField = fields[3].Trim();
                string passwordField = fields[4].Trim();


                if (emailField.Equals(emailInput, StringComparison.OrdinalIgnoreCase))
                {
                    if (passwordField == passwordInput)
                    {

                        string firstname = fields[1].Trim();
                        string username = firstname;
                        sharedVariable = "" + username;

                        // Check if this is the admin user (first record)
                        if (line == lines[0])
                        {
                            MessageBox.Show("Welcome Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Load admin panel
                            AdminDashboard adminForm = new AdminDashboard();
                            adminForm.Show();
                        }
                        else
                        { 
                            // Load user panel
                            Dashboard userForm = new Dashboard();
                            userForm.Show();
                        }

                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // If no matching email is found
            MessageBox.Show("Email not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void register_Click_1(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
        private void YourForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void InitializeNavigationMap()
        {
            // Define the navigation map

            navigationMap = new Dictionary<WinForms.TextBox, WinForms.TextBox>
            {
                {email, password},
                {password, email} // Loop back to the first textbox
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
    }
}
