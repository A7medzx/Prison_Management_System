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
            insert = new Button();
            shift = new TextBox();
            role = new TextBox();
            name = new TextBox();
            natId = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            id = new TextBox();
            searchId = new TextBox();
            label7 = new Label();
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
            // insert
            // 
            insert.Location = new Point(650, 269);
            insert.Name = "insert";
            insert.Size = new Size(105, 40);
            insert.TabIndex = 16;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // shift
            // 
            shift.Location = new Point(312, 308);
            shift.Name = "shift";
            shift.Size = new Size(197, 27);
            shift.TabIndex = 12;
            // 
            // role
            // 
            role.Location = new Point(312, 237);
            role.Name = "role";
            role.Size = new Size(197, 27);
            role.TabIndex = 13;
            // 
            // name
            // 
            name.Location = new Point(312, 125);
            name.Name = "name";
            name.Size = new Size(197, 27);
            name.TabIndex = 0;
            // 
            // natId
            // 
            natId.Location = new Point(312, 180);
            natId.Name = "natId";
            natId.Size = new Size(197, 27);
            natId.TabIndex = 0;
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
            label2.Location = new Point(208, 187);
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
            label1.Location = new Point(208, 132);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 10;
            label1.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(208, 77);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 8;
            label5.Text = "Id";
            // 
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(312, 70);
            id.Name = "id";
            id.Size = new Size(197, 27);
            id.TabIndex = 1;
            // 
            // searchId
            // 
            searchId.Location = new Point(534, 403);
            searchId.Name = "searchId";
            searchId.Size = new Size(125, 27);
            searchId.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(431, 403);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 21;
            label7.Text = "Search ID";
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 698);
            Controls.Add(searchId);
            Controls.Add(label7);
            Controls.Add(clear);
            Controls.Add(search);
            Controls.Add(edit);
            Controls.Add(delete);
            Controls.Add(insert);
            Controls.Add(shift);
            Controls.Add(role);
            Controls.Add(name);
            Controls.Add(id);
            Controls.Add(natId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button insert;
        private TextBox shift;
        private TextBox role;
        private TextBox name;
        private TextBox natId;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label5;
        private TextBox id;
        private TextBox searchId;
        private Label label7;
    }
}