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
            panel1.Location = new Point(0, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 569);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(6, 11);
            button1.Name = "button1";
            button1.Size = new Size(41, 41);
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
            label3.Location = new Point(50, 220);
            label3.Name = "label3";
            label3.Size = new Size(161, 82);
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
            label1.Location = new Point(314, 287);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 8;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DimGray;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(314, 343);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DimGray;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(314, 161);
            label4.Name = "label4";
            label4.Size = new Size(129, 32);
            label4.TabIndex = 10;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DimGray;
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(314, 221);
            label5.Name = "label5";
            label5.Size = new Size(126, 32);
            label5.TabIndex = 11;
            label5.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DimGray;
            label6.Font = new Font("Segoe UI", 14F);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(317, 97);
            label6.Name = "label6";
            label6.Size = new Size(37, 32);
            label6.TabIndex = 12;
            label6.Text = "ID";
            // 
            // fName
            // 
            fName.BackColor = SystemColors.ScrollBar;
            fName.Location = new Point(443, 165);
            fName.Name = "fName";
            fName.Size = new Size(292, 27);
            fName.TabIndex = 13;
            // 
            // lName
            // 
            lName.BackColor = SystemColors.ScrollBar;
            lName.Location = new Point(443, 221);
            lName.Name = "lName";
            lName.Size = new Size(292, 27);
            lName.TabIndex = 14;
            // 
            // id
            // 
            id.BackColor = SystemColors.ScrollBar;
            id.Enabled = false;
            id.Location = new Point(443, 101);
            id.Name = "id";
            id.Size = new Size(292, 27);
            id.TabIndex = 15;
            // 
            // email
            // 
            email.BackColor = SystemColors.ScrollBar;
            email.Location = new Point(443, 287);
            email.Name = "email";
            email.Size = new Size(292, 27);
            email.TabIndex = 16;
            // 
            // pass
            // 
            pass.BackColor = SystemColors.ScrollBar;
            pass.Location = new Point(443, 348);
            pass.Name = "pass";
            pass.PasswordChar = '●';
            pass.Size = new Size(292, 27);
            pass.TabIndex = 17;
            // 
            // insert
            // 
            insert.Font = new Font("Segoe UI", 12F);
            insert.Image = (Image)resources.GetObject("insert.Image");
            insert.ImageAlign = ContentAlignment.MiddleLeft;
            insert.Location = new Point(506, 431);
            insert.Name = "insert";
            insert.Size = new Size(165, 59);
            insert.TabIndex = 18;
            insert.Text = "Sign Up";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(914, 560);
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
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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