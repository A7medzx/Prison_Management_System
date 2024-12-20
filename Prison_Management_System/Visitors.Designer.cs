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
            label1.Location = new Point(559, 164);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(63, 255);
            label2.Name = "label2";
            label2.Size = new Size(137, 31);
            label2.TabIndex = 1;
            label2.Text = "National ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(559, 255);
            label3.Name = "label3";
            label3.Size = new Size(133, 31);
            label3.TabIndex = 1;
            label3.Text = "Prisoner ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(63, 351);
            label4.Name = "label4";
            label4.Size = new Size(148, 31);
            label4.TabIndex = 1;
            label4.Text = "Relationship";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(559, 343);
            label5.Name = "label5";
            label5.Size = new Size(64, 31);
            label5.TabIndex = 1;
            label5.Text = "Date";
            // 
            // name
            // 
            name.Location = new Point(745, 164);
            name.Name = "name";
            name.Size = new Size(197, 27);
            name.TabIndex = 0;
            // 
            // natId
            // 
            natId.Location = new Point(240, 255);
            natId.Name = "natId";
            natId.Size = new Size(197, 27);
            natId.TabIndex = 3;
            // 
            // prsrId
            // 
            prsrId.Location = new Point(745, 255);
            prsrId.Name = "prsrId";
            prsrId.Size = new Size(197, 27);
            prsrId.TabIndex = 3;
            // 
            // rel
            // 
            rel.Location = new Point(240, 351);
            rel.Name = "rel";
            rel.Size = new Size(197, 27);
            rel.TabIndex = 3;
            // 
            // date
            // 
            date.Enabled = false;
            date.Location = new Point(745, 345);
            date.Name = "date";
            date.Size = new Size(197, 27);
            date.TabIndex = 3;
            // 
            // insert
            // 
            insert.BackgroundImage = (Image)resources.GetObject("insert.BackgroundImage");
            insert.BackgroundImageLayout = ImageLayout.None;
            insert.ImageAlign = ContentAlignment.MiddleLeft;
            insert.Location = new Point(312, 471);
            insert.Name = "insert";
            insert.Size = new Size(117, 56);
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
            clear.Location = new Point(619, 471);
            clear.Name = "clear";
            clear.Size = new Size(117, 56);
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
            label6.Location = new Point(63, 169);
            label6.Name = "label6";
            label6.Size = new Size(92, 31);
            label6.TabIndex = 1;
            label6.Text = "Visit ID";
            // 
            // visitId
            // 
            visitId.Enabled = false;
            visitId.Location = new Point(240, 169);
            visitId.Name = "visitId";
            visitId.Size = new Size(197, 27);
            visitId.TabIndex = 1;
            // 
            // Visitors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1033, 636);
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