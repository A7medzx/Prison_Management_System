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
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(211, 583);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(199, 150);
            panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(62, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 156, 149);
            label2.Location = new Point(29, 66);
            label2.Name = "label2";
            label2.Size = new Size(136, 37);
            label2.TabIndex = 2;
            label2.Text = "Welcome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 156, 149);
            label3.Location = new Point(33, 100);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
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
            BtnPrisoners.Location = new Point(3, 159);
            BtnPrisoners.Margin = new Padding(3, 3, 3, 30);
            BtnPrisoners.Name = "BtnPrisoners";
            BtnPrisoners.Size = new Size(199, 70);
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
            BtnVisitors.Location = new Point(3, 262);
            BtnVisitors.Margin = new Padding(3, 3, 3, 30);
            BtnVisitors.Name = "BtnVisitors";
            BtnVisitors.Size = new Size(199, 70);
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
            BtnStaff.Location = new Point(3, 365);
            BtnStaff.Margin = new Padding(3, 3, 3, 30);
            BtnStaff.Name = "BtnStaff";
            BtnStaff.Size = new Size(199, 70);
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
            BtnDataGridView.Location = new Point(3, 468);
            BtnDataGridView.Margin = new Padding(3, 3, 3, 50);
            BtnDataGridView.Name = "BtnDataGridView";
            BtnDataGridView.Size = new Size(199, 70);
            BtnDataGridView.TabIndex = 1;
            BtnDataGridView.Text = "DataGridView";
            BtnDataGridView.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnDataGridView.UseVisualStyleBackColor = true;
            BtnDataGridView.Click += BtnDataGridView_Click;
            // 
            // PnlPrisonersForm2
            // 
            PnlPrisonersForm2.Location = new Point(251, 26);
            PnlPrisonersForm2.Name = "PnlPrisonersForm2";
            PnlPrisonersForm2.Size = new Size(920, 515);
            PnlPrisonersForm2.TabIndex = 3;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1189, 558);
            Controls.Add(PnlPrisonersForm2);
            Controls.Add(flowLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            flowLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
    }
}