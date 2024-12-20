namespace Prison_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailInput = email.Text.Trim();
            string passwordInput = password.Text.Trim();

            // Check if fields are empty
            if (string.IsNullOrEmpty(emailInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Both fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // File path to Users Records.txt
            string filePath = @"../../../Database_Files/Users Records.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Users records file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Load user panel
                            Dashboard userForm = new Dashboard();
                            userForm.Show();
                        }

                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // If no matching email is found
            MessageBox.Show("Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}