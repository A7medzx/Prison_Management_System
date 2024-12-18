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
            addButton = new Button();
            clearButton = new Button();
            searchButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            label6 = new Label();
            natId = new TextBox();
            label7 = new Label();
            searchId = new TextBox();
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
            name.Location = new Point(529, 34);
            name.Name = "name";
            name.Size = new Size(125, 27);
            name.TabIndex = 0;
            // 
            // crime
            // 
            crime.Location = new Point(82, 225);
            crime.Multiline = true;
            crime.Name = "crime";
            crime.Size = new Size(617, 90);
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
            // addButton
            // 
            addButton.Location = new Point(82, 360);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
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
            // searchButton
            // 
            searchButton.Location = new Point(630, 373);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 12;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(206, 424);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 29);
            editButton.TabIndex = 13;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(490, 424);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
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
            // natId
            // 
            natId.Location = new Point(182, 167);
            natId.Multiline = true;
            natId.Name = "natId";
            natId.Size = new Size(273, 34);
            natId.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(548, 181);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 1;
            label7.Text = "Search ID";
            // 
            // searchId
            // 
            searchId.Location = new Point(651, 181);
            searchId.Name = "searchId";
            searchId.Size = new Size(125, 27);
            searchId.TabIndex = 5;
            // 
            // Prisoners
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 493);
            Controls.Add(natId);
            Controls.Add(label6);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(searchButton);
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(cell);
            Controls.Add(duration);
            Controls.Add(crime);
            Controls.Add(name);
            Controls.Add(searchId);
            Controls.Add(id);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
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
        private Button addButton;
        private Button clearButton;
        private Button searchButton;
        private Button editButton;
        private Button deleteButton;
        private Label label6;
        private TextBox natId;
        private Label label7;
        private TextBox searchId;
    }
}
