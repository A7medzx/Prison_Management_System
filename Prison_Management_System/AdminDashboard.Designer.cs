namespace Prison_Management_System
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            log_out = new Button();
            label5 = new Label();
            label6 = new Label();
            logout = new Button();
            label1 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            BtnPrisoners = new Button();
            BtnVisitors = new Button();
            BtnStaff = new Button();
            BtnDataGridView = new Button();
            PnlPrisonersForm2 = new Panel();
            flowLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.None;
            flowLayoutPanel2.BackColor = Color.FromArgb(24, 30, 54);
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Controls.Add(BtnPrisoners);
            flowLayoutPanel2.Controls.Add(BtnVisitors);
            flowLayoutPanel2.Controls.Add(BtnStaff);
            flowLayoutPanel2.Controls.Add(BtnDataGridView);
            flowLayoutPanel2.Location = new Point(1, 0);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(241, 777);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 200);
            panel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(logout);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 200);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(log_out);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(227, 200);
            panel3.TabIndex = 3;
            // 
            // log_out
            // 
            log_out.BackColor = Color.DarkRed;
            log_out.FlatAppearance.BorderSize = 0;
            log_out.FlatStyle = FlatStyle.Flat;
            log_out.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            log_out.ForeColor = Color.Transparent;
            log_out.Location = new Point(67, 127);
            log_out.Margin = new Padding(0);
            log_out.Name = "log_out";
            log_out.Size = new Size(93, 47);
            log_out.TabIndex = 0;
            log_out.Text = "Logout";
            log_out.UseVisualStyleBackColor = false;
            log_out.Click += log_out_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 156, 149);
            label5.Location = new Point(29, 18);
            label5.Name = "label5";
            label5.Size = new Size(167, 46);
            label5.TabIndex = 2;
            label5.Text = "Welcome";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 156, 149);
            label6.Location = new Point(8, 64);
            label6.Name = "label6";
            label6.Size = new Size(216, 41);
            label6.TabIndex = 1;
            label6.Text = "Username";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logout
            // 
            logout.BackColor = Color.DarkRed;
            logout.FlatStyle = FlatStyle.Popup;
            logout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.Transparent;
            logout.Location = new Point(67, 127);
            logout.Margin = new Padding(0);
            logout.Name = "logout";
            logout.Size = new Size(93, 47);
            logout.TabIndex = 0;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = false;
            logout.Click += log_out_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 156, 149);
            label1.Location = new Point(29, 18);
            label1.Name = "label1";
            label1.Size = new Size(167, 46);
            label1.TabIndex = 2;
            label1.Text = "Welcome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 156, 149);
            label4.Location = new Point(32, 64);
            label4.Name = "label4";
            label4.Size = new Size(158, 41);
            label4.TabIndex = 1;
            label4.Text = "Username";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(71, 11);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 156, 149);
            label2.Location = new Point(33, 88);
            label2.Name = "label2";
            label2.Size = new Size(167, 46);
            label2.TabIndex = 2;
            label2.Text = "Welcome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 156, 149);
            label3.Location = new Point(38, 133);
            label3.Name = "label3";
            label3.Size = new Size(164, 41);
            label3.TabIndex = 1;
            label3.Text = "UserName";
            // 
            // BtnPrisoners
            // 
            BtnPrisoners.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPrisoners.FlatAppearance.BorderSize = 0;
            BtnPrisoners.FlatStyle = FlatStyle.Flat;
            BtnPrisoners.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPrisoners.ForeColor = Color.FromArgb(0, 126, 249);
            BtnPrisoners.Image = (Image)resources.GetObject("BtnPrisoners.Image");
            BtnPrisoners.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPrisoners.Location = new Point(3, 212);
            BtnPrisoners.Margin = new Padding(3, 4, 3, 40);
            BtnPrisoners.Name = "BtnPrisoners";
            BtnPrisoners.Size = new Size(227, 93);
            BtnPrisoners.TabIndex = 1;
            BtnPrisoners.Text = "Prisoners";
            BtnPrisoners.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnPrisoners.UseVisualStyleBackColor = true;
            BtnPrisoners.Click += BtnPrisoners_Click_1;
            // 
            // BtnVisitors
            // 
            BtnVisitors.BackgroundImageLayout = ImageLayout.Zoom;
            BtnVisitors.FlatAppearance.BorderSize = 0;
            BtnVisitors.FlatStyle = FlatStyle.Flat;
            BtnVisitors.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVisitors.ForeColor = Color.FromArgb(0, 126, 249);
            BtnVisitors.Image = (Image)resources.GetObject("BtnVisitors.Image");
            BtnVisitors.ImageAlign = ContentAlignment.MiddleLeft;
            BtnVisitors.Location = new Point(3, 349);
            BtnVisitors.Margin = new Padding(3, 4, 3, 40);
            BtnVisitors.Name = "BtnVisitors";
            BtnVisitors.Size = new Size(227, 93);
            BtnVisitors.TabIndex = 1;
            BtnVisitors.Text = "Visitors";
            BtnVisitors.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnVisitors.UseVisualStyleBackColor = true;
            BtnVisitors.Click += BtnVisitors_Click;
            // 
            // BtnStaff
            // 
            BtnStaff.BackgroundImageLayout = ImageLayout.Zoom;
            BtnStaff.FlatAppearance.BorderSize = 0;
            BtnStaff.FlatStyle = FlatStyle.Flat;
            BtnStaff.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnStaff.ForeColor = Color.FromArgb(0, 126, 249);
            BtnStaff.Image = (Image)resources.GetObject("BtnStaff.Image");
            BtnStaff.ImageAlign = ContentAlignment.MiddleLeft;
            BtnStaff.Location = new Point(3, 486);
            BtnStaff.Margin = new Padding(3, 4, 3, 40);
            BtnStaff.Name = "BtnStaff";
            BtnStaff.Size = new Size(227, 93);
            BtnStaff.TabIndex = 1;
            BtnStaff.Text = "Staff";
            BtnStaff.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnStaff.UseVisualStyleBackColor = true;
            BtnStaff.Click += BtnStaff_Click;
            // 
            // BtnDataGridView
            // 
            BtnDataGridView.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDataGridView.FlatAppearance.BorderSize = 0;
            BtnDataGridView.FlatStyle = FlatStyle.Flat;
            BtnDataGridView.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDataGridView.ForeColor = Color.FromArgb(0, 126, 249);
            BtnDataGridView.Image = (Image)resources.GetObject("BtnDataGridView.Image");
            BtnDataGridView.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDataGridView.Location = new Point(3, 623);
            BtnDataGridView.Margin = new Padding(3, 4, 3, 67);
            BtnDataGridView.Name = "BtnDataGridView";
            BtnDataGridView.Size = new Size(227, 93);
            BtnDataGridView.TabIndex = 1;
            BtnDataGridView.Text = "DataGridView";
            BtnDataGridView.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnDataGridView.UseVisualStyleBackColor = true;
            BtnDataGridView.Click += BtnDataGridView_Click;
            // 
            // PnlPrisonersForm2
            // 
            PnlPrisonersForm2.Location = new Point(287, 35);
            PnlPrisonersForm2.Margin = new Padding(3, 4, 3, 4);
            PnlPrisonersForm2.Name = "PnlPrisonersForm2";
            PnlPrisonersForm2.Size = new Size(1051, 687);
            PnlPrisonersForm2.TabIndex = 3;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1359, 744);
            Controls.Add(PnlPrisonersForm2);
            Controls.Add(flowLayoutPanel2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            flowLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Button BtnPrisoners;
        private Button BtnVisitors;
        private Button BtnStaff;
        private Button BtnDataGridView;
        private Panel PnlPrisonersForm2;
        private Panel panel1;
        private Button logout;
        private Label label1;
        private Label label4;
        private Panel panel3;
        private Button log_out;
        private Label label5;
        private Label label6;
    }
}