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
            id = new TextBox();
            name = new TextBox();
            crime = new TextBox();
            duration = new TextBox();
            cell = new TextBox();
            insert = new Button();
            clearButton = new Button();
            label6 = new Label();
            natId = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 1;
            label1.Text = "Prisoner ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 35);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 252);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Crime";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 111);
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
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(127, 31);
            id.Name = "id";
            id.Size = new Size(125, 27);
            id.TabIndex = 5;
            // 
            // name
            // 
            name.Location = new Point(529, 35);
            name.Name = "name";
            name.Size = new Size(125, 27);
            name.TabIndex = 0;
            // 
            // crime
            // 
            crime.Location = new Point(82, 225);
            crime.Multiline = true;
            crime.Name = "crime";
            crime.Size = new Size(617, 89);
            crime.TabIndex = 7;
            // 
            // duration
            // 
            duration.Location = new Point(154, 108);
            duration.Name = "duration";
            duration.Size = new Size(125, 27);
            duration.TabIndex = 8;
            // 
            // cell
            // 
            cell.Location = new Point(529, 108);
            cell.Name = "cell";
            cell.Size = new Size(125, 27);
            cell.TabIndex = 9;
            // 
            // insert
            // 
            insert.Location = new Point(82, 360);
            insert.Name = "insert";
            insert.Size = new Size(94, 29);
            insert.TabIndex = 10;
            insert.Text = "Add";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(361, 360);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 11;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 181);
            label6.Name = "label6";
            label6.Size = new Size(142, 20);
            label6.TabIndex = 15;
            label6.Text = "Prisoner National ID";
            // 
            // natId
            // 
            natId.Location = new Point(182, 167);
            natId.Multiline = true;
            natId.Name = "natId";
            natId.Size = new Size(273, 33);
            natId.TabIndex = 16;
            // 
            // Prisoners
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 493);
            Controls.Add(natId);
            Controls.Add(label6);
            Controls.Add(clearButton);
            Controls.Add(insert);
            Controls.Add(cell);
            Controls.Add(duration);
            Controls.Add(crime);
            Controls.Add(name);
            Controls.Add(id);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Prisoners";
            Text = "`";
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
        private TextBox id;
        private TextBox name;
        private TextBox crime;
        private TextBox duration;
        private TextBox cell;
        private Button insert;
        private Button clearButton;
        private Label label6;
        private TextBox natId;
    }
}
