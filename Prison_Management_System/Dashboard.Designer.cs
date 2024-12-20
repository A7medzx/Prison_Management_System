namespace Prison_Management_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            logout = new Button();
            label2 = new Label();
            label1 = new Label();
            BtnPrisoners = new Button();
            BtnVisitors = new Button();
            BtnStaff = new Button();
            BtnDataGridView = new Button();
            PnlPrisonersForm2 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.BackColor = Color.FromArgb(24, 30, 54);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(BtnPrisoners);
            flowLayoutPanel1.Controls.Add(BtnVisitors);
            flowLayoutPanel1.Controls.Add(BtnStaff);
            flowLayoutPanel1.Controls.Add(BtnDataGridView);
            flowLayoutPanel1.Location = new Point(1, 1);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(241, 777);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(logout);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 200);
            panel1.TabIndex = 0;
            // 
            // logout
            // 
            logout.BackColor = Color.DarkRed;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.Transparent;
            logout.Location = new Point(67, 127);
            logout.Margin = new Padding(0);
            logout.Name = "logout";
            logout.Size = new Size(93, 47);
            logout.TabIndex = 0;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 156, 149);
            label2.Location = new Point(29, 18);
            label2.Name = "label2";
            label2.Size = new Size(167, 46);
            label2.TabIndex = 2;
            label2.Text = "Welcome";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 156, 149);
            label1.Location = new Point(3, 64);
            label1.Name = "label1";
            label1.Size = new Size(221, 41);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            BtnPrisoners.Click += BtnPrisoners_Click;
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
            PnlPrisonersForm2.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1359, 744);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(PnlPrisonersForm2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Button BtnPrisoners;
        private Button BtnVisitors;
        private Button BtnStaff;
        private Button BtnDataGridView;
        private Panel PnlPrisonersForm2;
        private Label label2;
        private Button logout;
    }
}