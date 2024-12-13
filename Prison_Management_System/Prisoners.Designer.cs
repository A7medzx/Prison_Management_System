namespace Prison_Management_System
{
    partial class Prisoners
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ID = new TextBox();
            fName = new TextBox();
            Crime = new TextBox();
            Duration = new TextBox();
            Cell = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label6 = new Label();
            National_ID = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Prisoner ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 34);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 252);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Crime";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 111);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 3;
            label4.Text = "Sentence Duration";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(435, 111);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 4;
            label5.Text = "Cell Number";
            // 
            // ID
            // 
            ID.Location = new Point(127, 31);
            ID.Name = "ID";
            ID.Size = new Size(125, 27);
            ID.TabIndex = 5;
            // 
            // fName
            // 
            fName.Location = new Point(529, 34);
            fName.Name = "fName";
            fName.Size = new Size(125, 27);
            fName.TabIndex = 6;
            // 
            // Crime
            // 
            Crime.Location = new Point(82, 225);
            Crime.Multiline = true;
            Crime.Name = "Crime";
            Crime.Size = new Size(617, 90);
            Crime.TabIndex = 7;
            // 
            // Duration
            // 
            Duration.Location = new Point(154, 108);
            Duration.Name = "Duration";
            Duration.Size = new Size(125, 27);
            Duration.TabIndex = 8;
            // 
            // Cell
            // 
            Cell.Location = new Point(529, 108);
            Cell.Name = "Cell";
            Cell.Size = new Size(125, 27);
            Cell.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(82, 360);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(361, 360);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(630, 373);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(206, 424);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 13;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(490, 424);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 14;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 181);
            label6.Name = "label6";
            label6.Size = new Size(142, 20);
            label6.TabIndex = 15;
            label6.Text = "Prisoner National ID";
            // 
            // National_ID
            // 
            National_ID.Location = new Point(182, 167);
            National_ID.Multiline = true;
            National_ID.Name = "National_ID";
            National_ID.Size = new Size(273, 34);
            National_ID.TabIndex = 16;
            // 
            // Prisoners
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 493);
            Controls.Add(National_ID);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Cell);
            Controls.Add(Duration);
            Controls.Add(Crime);
            Controls.Add(fName);
            Controls.Add(ID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Prisoners";
            Text = "Prisoners";
            Load += Prisoners_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ID;
        private TextBox fName;
        private TextBox Crime;
        private TextBox Duration;
        private TextBox Cell;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label6;
        private TextBox National_ID;
    }
}
