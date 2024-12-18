namespace Prison_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = this.email.Text;
            string password = this.password.Text;

            if (email == "ashmawy@gmail.com" && password == "1234")
            {
                MessageBox.Show("Welcome Ashmawy", "Alart",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Email or Password", "ALert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}