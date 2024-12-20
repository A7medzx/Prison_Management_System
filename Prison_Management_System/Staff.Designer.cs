using Prison_Management_System.Properties;
using System.Resources;

namespace Prison_Management_System
{
    partial class Staff
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            clear = new Button();
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
            SuspendLayout();
            // 
            // clear
            // 
            clear.BackgroundImage = (Image)resources.GetObject("clear.BackgroundImage");
            clear.BackgroundImageLayout = ImageLayout.None;
            clear.Location = new Point(514, 304);
            clear.Name = "clear";
            clear.Size = new Size(102, 42);
            clear.TabIndex = 0;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // insert
            // 
            insert.BackgroundImage = (Image)resources.GetObject("insert.BackgroundImage");
            insert.BackgroundImageLayout = ImageLayout.None;
            insert.ImageAlign = ContentAlignment.MiddleLeft;
            insert.Location = new Point(245, 304);
            insert.Name = "insert";
            insert.Size = new Size(102, 42);
            insert.TabIndex = 1;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // shift
            // 
            shift.Location = new Point(339, 223);
            shift.Name = "shift";
            shift.Size = new Size(197, 23);
            shift.TabIndex = 2;
            // 
            // role
            // 
            role.Location = new Point(624, 142);
            role.Name = "role";
            role.Size = new Size(173, 23);
            role.TabIndex = 3;
            // 
            // name
            // 
            name.Location = new Point(624, 74);
            name.Name = "name";
            name.Size = new Size(173, 23);
            name.TabIndex = 4;
            // 
            // natId
            // 
            natId.Location = new Point(182, 142);
            natId.Name = "natId";
            natId.Size = new Size(173, 23);
            natId.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(245, 223);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 8;
            label4.Text = "Shift";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(27, 142);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 9;
            label2.Text = "National ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(461, 142);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 10;
            label3.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(461, 74);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(27, 78);
            label5.Name = "label5";
            label5.Size = new Size(32, 25);
            label5.TabIndex = 7;
            label5.Text = "ID";
            // 
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(182, 78);
            id.Name = "id";
            id.Size = new Size(173, 23);
            id.TabIndex = 5;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(856, 410);
            ControlBox = false;
            Controls.Add(clear);
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
            Load += Staff_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button clear;
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
    }
}
