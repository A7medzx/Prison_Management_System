namespace Prison_Management_System
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            fName = new TextBox();
            lName = new TextBox();
            id = new TextBox();
            email = new TextBox();
            pass = new TextBox();
            insert = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, -4);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 427);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(5, 8);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(36, 31);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(46, 51, 73);
            label3.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(44, 165);
            label3.Name = "label3";
            label3.Size = new Size(129, 66);
            label3.TabIndex = 1;
            label3.Text = "Register\r\nMenu\r\n";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(275, 215);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 8;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DimGray;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(275, 257);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DimGray;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(275, 121);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 10;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DimGray;
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(275, 166);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 11;
            label5.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DimGray;
            label6.Font = new Font("Segoe UI", 14F);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(277, 73);
            label6.Name = "label6";
            label6.Size = new Size(30, 25);
            label6.TabIndex = 12;
            label6.Text = "ID";
            // 
            // fName
            // 
            fName.BackColor = SystemColors.ScrollBar;
            fName.Location = new Point(388, 124);
            fName.Margin = new Padding(3, 2, 3, 2);
            fName.Name = "fName";
            fName.Size = new Size(256, 23);
            fName.TabIndex = 13;
            // 
            // lName
            // 
            lName.BackColor = SystemColors.ScrollBar;
            lName.Location = new Point(388, 166);
            lName.Margin = new Padding(3, 2, 3, 2);
            lName.Name = "lName";
            lName.Size = new Size(256, 23);
            lName.TabIndex = 14;
            // 
            // id
            // 
            id.BackColor = SystemColors.ScrollBar;
            id.Enabled = false;
            id.Location = new Point(388, 76);
            id.Margin = new Padding(3, 2, 3, 2);
            id.Name = "id";
            id.Size = new Size(256, 23);
            id.TabIndex = 15;
            // 
            // email
            // 
            email.BackColor = SystemColors.ScrollBar;
            email.Location = new Point(388, 215);
            email.Margin = new Padding(3, 2, 3, 2);
            email.Name = "email";
            email.Size = new Size(256, 23);
            email.TabIndex = 16;
            // 
            // pass
            // 
            pass.BackColor = SystemColors.ScrollBar;
            pass.Location = new Point(388, 261);
            pass.Margin = new Padding(3, 2, 3, 2);
            pass.Name = "pass";
            pass.PasswordChar = '●';
            pass.Size = new Size(256, 23);
            pass.TabIndex = 17;
            // 
            // insert
            // 
            insert.Font = new Font("Segoe UI", 12F);
            insert.Image = (Image)resources.GetObject("insert.Image");
            insert.ImageAlign = ContentAlignment.MiddleLeft;
            insert.Location = new Point(443, 323);
            insert.Margin = new Padding(3, 2, 3, 2);
            insert.Name = "insert";
            insert.Size = new Size(144, 44);
            insert.TabIndex = 18;
            insert.Text = "Sign Up";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 420);
            Controls.Add(insert);
            Controls.Add(pass);
            Controls.Add(email);
            Controls.Add(id);
            Controls.Add(lName);
            Controls.Add(fName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resister";
            Load += Register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox fName;
        private TextBox lName;
        private TextBox id;
        private TextBox email;
        private TextBox pass;
        private Button insert;
        private Button button1;
    }
}