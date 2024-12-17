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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 115);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 163);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nat ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 213);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 1;
            label3.Text = "Prisoner ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 261);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 1;
            label4.Text = "Relationship";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 311);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 1;
            label5.Text = "Date";
            // 
            // name
            // 
            name.Location = new Point(243, 118);
            name.Margin = new Padding(3, 2, 3, 2);
            name.Name = "name";
            name.Size = new Size(173, 23);
            name.TabIndex = 1;
            // 
            // natId
            // 
            natId.Location = new Point(243, 158);
            natId.Margin = new Padding(3, 2, 3, 2);
            natId.Name = "natId";
            natId.Size = new Size(173, 23);
            natId.TabIndex = 3;
            // 
            // prsrId
            // 
            prsrId.Location = new Point(243, 208);
            prsrId.Margin = new Padding(3, 2, 3, 2);
            prsrId.Name = "prsrId";
            prsrId.Size = new Size(173, 23);
            prsrId.TabIndex = 3;
            // 
            // rel
            // 
            rel.Location = new Point(243, 261);
            rel.Margin = new Padding(3, 2, 3, 2);
            rel.Name = "rel";
            rel.Size = new Size(173, 23);
            rel.TabIndex = 3;
            // 
            // date
            // 
            date.Location = new Point(243, 311);
            date.Margin = new Padding(3, 2, 3, 2);
            date.Name = "date";
            date.Size = new Size(173, 23);
            date.TabIndex = 3;
            // 
            // insert
            // 
            insert.Location = new Point(539, 232);
            insert.Margin = new Padding(3, 2, 3, 2);
            insert.Name = "insert";
            insert.Size = new Size(92, 30);
            insert.TabIndex = 4;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // delete
            // 
            delete.Location = new Point(636, 442);
            delete.Margin = new Padding(3, 2, 3, 2);
            delete.Name = "delete";
            delete.Size = new Size(82, 22);
            delete.TabIndex = 5;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // search
            // 
            search.Location = new Point(284, 434);
            search.Margin = new Padding(3, 2, 3, 2);
            search.Name = "search";
            search.Size = new Size(82, 22);
            search.TabIndex = 5;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += delete_Click;
            // 
            // clear
            // 
            clear.Location = new Point(176, 442);
            clear.Margin = new Padding(3, 2, 3, 2);
            clear.Name = "clear";
            clear.Size = new Size(82, 22);
            clear.TabIndex = 5;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += delete_Click;
            // 
            // edit
            // 
            edit.Location = new Point(520, 463);
            edit.Margin = new Padding(3, 2, 3, 2);
            edit.Name = "edit";
            edit.Size = new Size(82, 22);
            edit.TabIndex = 5;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = true;
            edit.Click += delete_Click;
            // 
            // Visitors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1000, 600);
            ControlBox = false;
            Controls.Add(clear);
            Controls.Add(search);
            Controls.Add(edit);
            Controls.Add(delete);
            Controls.Add(insert);
            Controls.Add(date);
            Controls.Add(rel);
            Controls.Add(prsrId);
            Controls.Add(natId);
            Controls.Add(name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
    }
}