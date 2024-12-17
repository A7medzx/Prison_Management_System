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
            string email = textBox1.Text;
            string password = textBox2.Text;

            if (email == "Ashmawy@gmail.com" && password == "1234")
            {
                MessageBox.Show("Welcome Ashmawy", "Alart",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
