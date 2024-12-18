namespace Prison_Management_System
{
    partial class Visitors
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            name = new TextBox();
            natId = new TextBox();
            prsrId = new TextBox();
            rel = new TextBox();
            date = new TextBox();
            insert = new Button();
            delete = new Button();
            search = new Button();
            clear = new Button();
            edit = new Button();
            label6 = new Label();
            visitId = new TextBox();
            searchId = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 153);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 217);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Nat ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 284);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 1;
            label3.Text = "Prisoner ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 348);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 1;
            label4.Text = "Relationship";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(174, 415);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 1;
            label5.Text = "Date";
            // 
            // name
            // 
            name.Location = new Point(278, 157);
            name.Name = "name";
            name.Size = new Size(197, 27);
            name.TabIndex = 0;
            // 
            // natId
            // 
            natId.Location = new Point(278, 211);
            natId.Name = "natId";
            natId.Size = new Size(197, 27);
            natId.TabIndex = 3;
            // 
            // prsrId
            // 
            prsrId.Location = new Point(278, 277);
            prsrId.Name = "prsrId";
            prsrId.Size = new Size(197, 27);
            prsrId.TabIndex = 3;
            // 
            // rel
            // 
            rel.Location = new Point(278, 348);
            rel.Name = "rel";
            rel.Size = new Size(197, 27);
            rel.TabIndex = 3;
            // 
            // date
            // 
            date.Location = new Point(278, 415);
            date.Name = "date";
            date.Size = new Size(197, 27);
            date.TabIndex = 3;
            // 
            // insert
            // 
            insert.Location = new Point(616, 309);
            insert.Name = "insert";
            insert.Size = new Size(105, 40);
            insert.TabIndex = 4;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // delete
            // 
            delete.Location = new Point(727, 589);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 5;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // search
            // 
            search.Location = new Point(325, 579);
            search.Name = "search";
            search.Size = new Size(94, 29);
            search.TabIndex = 5;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += delete_Click;
            // 
            // clear
            // 
            clear.Location = new Point(201, 589);
            clear.Name = "clear";
            clear.Size = new Size(94, 29);
            clear.TabIndex = 5;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += delete_Click;
            // 
            // edit
            // 
            edit.Location = new Point(594, 617);
            edit.Name = "edit";
            edit.Size = new Size(94, 29);
            edit.TabIndex = 5;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = true;
            edit.Click += delete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(174, 105);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 1;
            label6.Text = "Visit ID";
            // 
            // visitId
            // 
            visitId.Enabled = false;
            visitId.Location = new Point(278, 109);
            visitId.Name = "visitId";
            visitId.Size = new Size(197, 27);
            visitId.TabIndex = 1;
            // 
            // searchId
            // 
            searchId.Location = new Point(616, 467);
            searchId.Name = "searchId";
            searchId.Size = new Size(125, 27);
            searchId.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(513, 467);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 6;
            label7.Text = "Search ID";
            // 
            // Visitors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1143, 800);
            ControlBox = false;
            Controls.Add(searchId);
            Controls.Add(label7);
            Controls.Add(clear);
            Controls.Add(search);
            Controls.Add(edit);
            Controls.Add(delete);
            Controls.Add(insert);
            Controls.Add(date);
            Controls.Add(rel);
            Controls.Add(prsrId);
            Controls.Add(natId);
            Controls.Add(visitId);
            Controls.Add(name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Visitors";
            Text = "Visitors";
            Load += Visitors_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox name;
        private TextBox natId;
        private TextBox prsrId;
        private TextBox rel;
        private TextBox date;
        private Button insert;
        private Button delete;
        private Button search;
        private Button clear;
        private Button edit;
        private Label label6;
        private TextBox visitId;
        private TextBox searchId;
        private Label label7;
    }
}