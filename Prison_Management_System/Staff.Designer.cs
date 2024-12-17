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
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // clear
            // 
            clear.Location = new Point(235, 549);
            clear.Name = "clear";
            clear.Size = new Size(94, 29);
            clear.TabIndex = 17;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            search.Location = new Point(358, 539);
            search.Name = "search";
            search.Size = new Size(94, 29);
            search.TabIndex = 18;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            edit.Location = new Point(628, 577);
            edit.Name = "edit";
            edit.Size = new Size(94, 29);
            edit.TabIndex = 19;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(761, 549);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 20;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            Add.Location = new Point(650, 269);
            Add.Name = "Add";
            Add.Size = new Size(105, 40);
            Add.TabIndex = 16;
            Add.Text = "Insert";
            Add.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(312, 308);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(197, 27);
            textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(312, 237);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(197, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(312, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 27);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 27);
            textBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 308);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 7;
            label4.Text = "Shift";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 124);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 8;
            label2.Text = "Nat ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 244);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 9;
            label3.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 177);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 10;
            label1.Text = "Name";
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 698);
            Controls.Add(clear);
            Controls.Add(search);
            Controls.Add(edit);
            Controls.Add(delete);
            Controls.Add(Add);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Staff";
            Text = "Staff";
            Load += Staff_Load;
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
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}