using Prison_Management_System.Properties;
using System.Resources;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prisoners));
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
            clear = new Button();
            label6 = new Label();
            natId = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(27, 78);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 1;
            label1.Text = "Prisoner ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(461, 74);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(461, 142);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 1;
            label3.Text = "Crime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(27, 214);
            label4.Name = "label4";
            label4.Size = new Size(152, 21);
            label4.TabIndex = 1;
            label4.Text = "Sentence Duration";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(461, 208);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 1;
            label5.Text = "Cell Number";
            // 
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(182, 78);
            id.Margin = new Padding(3, 2, 3, 2);
            id.Name = "id";
            id.Size = new Size(173, 23);
            id.TabIndex = 1;
            // 
            // name
            // 
            name.Location = new Point(624, 74);
            name.Margin = new Padding(3, 2, 3, 2);
            name.Name = "name";
            name.Size = new Size(173, 23);
            name.TabIndex = 0;
            // 
            // crime
            // 
            crime.Location = new Point(624, 142);
            crime.Margin = new Padding(3, 2, 3, 2);
            crime.Name = "crime";
            crime.Size = new Size(173, 23);
            crime.TabIndex = 3;
            // 
            // duration
            // 
            duration.Location = new Point(182, 214);
            duration.Margin = new Padding(3, 2, 3, 2);
            duration.Name = "duration";
            duration.Size = new Size(173, 23);
            duration.TabIndex = 3;
            // 
            // cell
            // 
            cell.Location = new Point(624, 210);
            cell.Margin = new Padding(3, 2, 3, 2);
            cell.Name = "cell";
            cell.Size = new Size(173, 23);
            cell.TabIndex = 3;
            // 
            // insert
            // 
            insert.BackgroundImage = (Image)resources.GetObject("insert.BackgroundImage");
            insert.BackgroundImageLayout = ImageLayout.None;
            insert.ImageAlign = ContentAlignment.MiddleLeft;
            insert.Location = new Point(245, 304);
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
            clear.Location = new Point(514, 304);
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
            label6.Location = new Point(27, 142);
            label6.Name = "label6";
            label6.Size = new Size(113, 25);
            label6.TabIndex = 1;
            label6.Text = "National ID";
            // 
            // natId
            // 
            natId.Location = new Point(182, 142);
            natId.Margin = new Padding(3, 2, 3, 2);
            natId.Name = "natId";
            natId.Size = new Size(173, 23);
            natId.TabIndex = 3;
            // 
            // Prisoners
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(856, 410);
            ControlBox = false;
            Controls.Add(natId);
            Controls.Add(label6);
            Controls.Add(clear);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox id;
        private TextBox name;
        private TextBox crime;
        private TextBox duration;
        private TextBox cell;
        private Button insert;
        private Button clear;
        private Label label6;
        private TextBox natId;
    }
}
