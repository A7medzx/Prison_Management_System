namespace Prison_Management_System
{
    partial class Staff
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
            clear = new Button();
            search = new Button();
            edit = new Button();
            delete = new Button();
            Add = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            Id = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // clear
            // 
            clear.Location = new Point(253, 404);
            clear.Name = "clear";
            clear.Size = new Size(102, 40);
            clear.TabIndex = 17;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            search.Location = new Point(565, 401);
            search.Name = "search";
            search.Size = new Size(102, 43);
            search.TabIndex = 18;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            edit.Location = new Point(825, 79);
            edit.Name = "edit";
            edit.Size = new Size(105, 43);
            edit.TabIndex = 19;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(825, 193);
            delete.Name = "delete";
            delete.Size = new Size(105, 43);
            delete.TabIndex = 20;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            Add.Location = new Point(825, 317);
            Add.Name = "Add";
            Add.Size = new Size(105, 44);
            Add.TabIndex = 16;
            Add.Text = "Insert";
            Add.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(410, 317);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(197, 27);
            textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(410, 256);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(197, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(410, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 27);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(410, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 27);
            textBox1.TabIndex = 0;
            // 
            // Id
            // 
            Id.Enabled = false;
            Id.Location = new Point(410, 79);
            Id.Name = "Id";
            Id.Size = new Size(197, 27);
            Id.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-7, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 703);
            panel1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(46, 51, 73);
            label6.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(57, 212);
            label6.Name = "label6";
            label6.Size = new Size(110, 82);
            label6.TabIndex = 2;
            label6.Text = "Staff \r\nForm\r\n";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DimGray;
            label7.Font = new Font("Segoe UI", 14F);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(253, 79);
            label7.Name = "label7";
            label7.Size = new Size(37, 32);
            label7.TabIndex = 22;
            label7.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DimGray;
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(253, 132);
            label5.Name = "label5";
            label5.Size = new Size(78, 32);
            label5.TabIndex = 23;
            label5.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(253, 193);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 24;
            label1.Text = "National ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DimGray;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(253, 256);
            label2.Name = "label2";
            label2.Size = new Size(60, 32);
            label2.TabIndex = 25;
            label2.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DimGray;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(253, 317);
            label3.Name = "label3";
            label3.Size = new Size(63, 32);
            label3.TabIndex = 26;
            label3.Text = "Shift";
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(969, 565);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(clear);
            Controls.Add(search);
            Controls.Add(edit);
            Controls.Add(delete);
            Controls.Add(Add);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(Id);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Staff";
            Text = "Staff";
            Load += Staff_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clear;
        private Button search;
        private Button edit;
        private Button delete;
        private Button Add;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox Id;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}