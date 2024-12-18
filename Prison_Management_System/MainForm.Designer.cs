namespace Prison_Management_System
{
    partial class MainForm // Changed to match the renamed class
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            buttonLoadFile = new Button();
            comboBoxFiles = new ComboBox();
            dataGridView1 = new DataGridView();
            buttonEdit = new Button();
            buttonDelete = new Button();
            textBoxSearch = new TextBox();
            btnExportToExcel = new Button();
            searchedtoexcelbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonLoadFile
            // 
            buttonLoadFile.Location = new Point(891, 536);
            buttonLoadFile.Margin = new Padding(3, 4, 3, 4);
            buttonLoadFile.Name = "buttonLoadFile";
            buttonLoadFile.Size = new Size(131, 33);
            buttonLoadFile.TabIndex = 1;
            buttonLoadFile.Text = "Load File";
            buttonLoadFile.UseVisualStyleBackColor = true;
            buttonLoadFile.Click += buttonLoadFile_Click;
            // 
            // comboBoxFiles
            // 
            comboBoxFiles.FormattingEnabled = true;
            comboBoxFiles.Location = new Point(719, 537);
            comboBoxFiles.Margin = new Padding(3, 4, 3, 4);
            comboBoxFiles.Name = "comboBoxFiles";
            comboBoxFiles.Size = new Size(165, 28);
            comboBoxFiles.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(46, 51, 73);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = SystemColors.MenuHighlight;
            dataGridView1.Location = new Point(10, 12);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.Size = new Size(1031, 520);
            dataGridView1.TabIndex = 3;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(719, 577);
            buttonEdit.Margin = new Padding(3, 4, 3, 4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(166, 33);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Edit Record";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(891, 577);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(131, 33);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete Record";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(11, 560);
            textBoxSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search here...";
            textBoxSearch.Size = new Size(228, 27);
            textBoxSearch.TabIndex = 6;
            textBoxSearch.KeyDown += TextBoxSearch_KeyDown;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.Location = new Point(773, 619);
            btnExportToExcel.Margin = new Padding(3, 4, 3, 4);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(229, 31);
            btnExportToExcel.TabIndex = 7;
            btnExportToExcel.Text = "Export Data to Excel";
            btnExportToExcel.UseVisualStyleBackColor = true;
            btnExportToExcel.Click += btnExportToExcel_Click;
            // 
            // searchedtoexcelbtn
            // 
            searchedtoexcelbtn.Location = new Point(11, 599);
            searchedtoexcelbtn.Margin = new Padding(3, 4, 3, 4);
            searchedtoexcelbtn.Name = "searchedtoexcelbtn";
            searchedtoexcelbtn.Size = new Size(229, 31);
            searchedtoexcelbtn.TabIndex = 8;
            searchedtoexcelbtn.Text = "Export Search Results to Excel";
            searchedtoexcelbtn.UseVisualStyleBackColor = true;
            searchedtoexcelbtn.Click += searchedtoexcelbtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1051, 667);
            Controls.Add(searchedtoexcelbtn);
            Controls.Add(btnExportToExcel);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxFiles);
            Controls.Add(buttonLoadFile);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonLoadFile;
        private ComboBox comboBoxFiles;
        private DataGridView dataGridView1;
        private Button buttonEdit;
        private Button buttonDelete;
        private TextBox textBoxSearch;
        private Button btnExportToExcel;
        private Button searchedtoexcelbtn;
    }
}
