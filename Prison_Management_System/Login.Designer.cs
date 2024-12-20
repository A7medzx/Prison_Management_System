namespace Prison_Management_System
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            email = new TextBox();
            password = new TextBox();
            button1 = new Button();
            label3 = new Label();
            panel1 = new Panel();
            register = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(242, 125);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DimGray;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(242, 202);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // email
            // 
            email.BackColor = SystemColors.ScrollBar;
            email.Location = new Point(408, 125);
            email.Margin = new Padding(3, 2, 3, 2);
            email.Name = "email";
            email.Size = new Size(256, 23);
            email.TabIndex = 3;
            // 
            // password
            // 
            password.BackColor = SystemColors.ScrollBar;
            password.Location = new Point(408, 207);
            password.Margin = new Padding(3, 2, 3, 2);
            password.Name = "password";
            password.PasswordChar = '●';
            password.Size = new Size(256, 23);
            password.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(300, 288);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(144, 44);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(46, 51, 73);
            label3.Font = new Font("Tahoma", 19.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(88, 155);
            label3.Name = "label3";
            label3.Size = new Size(89, 66);
            label3.TabIndex = 1;
            label3.Text = "Login\r\nMenu";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-27, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 458);
            panel1.TabIndex = 6;
            // 
            // register
            // 
            register.Image = Properties.Resources.add_user;
            register.ImageAlign = ContentAlignment.MiddleLeft;
            register.Location = new Point(577, 288);
            register.Margin = new Padding(3, 2, 3, 2);
            register.Name = "register";
            register.Size = new Size(144, 44);
            register.TabIndex = 7;
            register.Text = "Register";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(785, 420);
            Controls.Add(register);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(label2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox email;
        private TextBox password;
        private Button button1;
        private Label label3;
        private Panel panel1;
        private Button register;
    }
}
