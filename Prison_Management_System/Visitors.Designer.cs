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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visitors));
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
            clear = new Button();
            label6 = new Label();
            visitId = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(489, 123);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(55, 191);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 1;
            label2.Text = "National ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(489, 191);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 1;
            label3.Text = "Prisoner ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(55, 263);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 1;
            label4.Text = "Relationship";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(489, 257);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 1;
            label5.Text = "Date";
            // 
            // name
            // 
            name.Location = new Point(652, 123);
            name.Margin = new Padding(3, 2, 3, 2);
            name.Name = "name";
            name.Size = new Size(173, 23);
            name.TabIndex = 0;
            // 
            // natId
            // 
            natId.Location = new Point(210, 191);
            natId.Margin = new Padding(3, 2, 3, 2);
            natId.Name = "natId";
            natId.Size = new Size(173, 23);
            natId.TabIndex = 3;
            // 
            // prsrId
            // 
            prsrId.Location = new Point(652, 191);
            prsrId.Margin = new Padding(3, 2, 3, 2);
            prsrId.Name = "prsrId";
            prsrId.Size = new Size(173, 23);
            prsrId.TabIndex = 3;
            // 
            // rel
            // 
            rel.Location = new Point(210, 263);
            rel.Margin = new Padding(3, 2, 3, 2);
            rel.Name = "rel";
            rel.Size = new Size(173, 23);
            rel.TabIndex = 3;
            // 
            // date
            // 
            date.Location = new Point(652, 259);
            date.Margin = new Padding(3, 2, 3, 2);
            date.Name = "date";
            date.Size = new Size(173, 23);
            date.TabIndex = 3;
            // 
            // insert
            // 
            insert.BackgroundImage = (Image)resources.GetObject("insert.BackgroundImage");
            insert.BackgroundImageLayout = ImageLayout.None;
            insert.ImageAlign = ContentAlignment.MiddleLeft;
            insert.Location = new Point(273, 353);
            insert.Margin = new Padding(3, 2, 3, 2);
            insert.Name = "insert";
            insert.Size = new Size(102, 42);
            insert.TabIndex = 4;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // clear
            // 
            clear.BackgroundImage = (Image)resources.GetObject("clear.BackgroundImage");
            clear.BackgroundImageLayout = ImageLayout.None;
            clear.ImageAlign = ContentAlignment.MiddleLeft;
            clear.Location = new Point(542, 353);
            clear.Margin = new Padding(3, 2, 3, 2);
            clear.Name = "clear";
            clear.Size = new Size(102, 42);
            clear.TabIndex = 5;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(55, 127);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 1;
            label6.Text = "Visit ID";
            // 
            // visitId
            // 
            visitId.Enabled = false;
            visitId.Location = new Point(210, 127);
            visitId.Margin = new Padding(3, 2, 3, 2);
            visitId.Name = "visitId";
            visitId.Size = new Size(173, 23);
            visitId.TabIndex = 1;
            // 
            // Visitors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(904, 477);
            ControlBox = false;
            Controls.Add(clear);
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
        private Button clear;
        private Label label6;
        private TextBox visitId;
    }
}