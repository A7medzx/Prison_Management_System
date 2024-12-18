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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            buttonLoadFile.Location = new Point(780, 402);
            buttonLoadFile.Name = "buttonLoadFile";
            buttonLoadFile.Size = new Size(115, 25);
            buttonLoadFile.TabIndex = 1;
            buttonLoadFile.Text = "buttonLoadFile";
            buttonLoadFile.UseVisualStyleBackColor = true;
            buttonLoadFile.Click += buttonLoadFile_Click;
            // 
            // comboBoxFiles
            // 
            comboBoxFiles.FormattingEnabled = true;
            comboBoxFiles.Location = new Point(629, 403);
            comboBoxFiles.Name = "comboBoxFiles";
            comboBoxFiles.Size = new Size(145, 23);
            comboBoxFiles.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(46, 51, 73);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.GridColor = SystemColors.MenuHighlight;
            dataGridView1.Location = new Point(9, 9);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.Size = new Size(902, 390);
            dataGridView1.TabIndex = 3;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(629, 433);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(145, 25);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Edit Record";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(780, 433);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(115, 25);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete Record";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(10, 420);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search here...";
            textBoxSearch.Size = new Size(200, 23);
            textBoxSearch.TabIndex = 6;
            textBoxSearch.KeyDown += TextBoxSearch_KeyDown;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.Location = new Point(676, 464);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(200, 23);
            btnExportToExcel.TabIndex = 7;
            btnExportToExcel.Text = "Export Data to Excel";
            btnExportToExcel.UseVisualStyleBackColor = true;
            btnExportToExcel.Click += btnExportToExcel_Click;
            // 
            // searchedtoexcelbtn
            // 
            searchedtoexcelbtn.Location = new Point(10, 449);
            searchedtoexcelbtn.Name = "searchedtoexcelbtn";
            searchedtoexcelbtn.Size = new Size(200, 23);
            searchedtoexcelbtn.TabIndex = 8;
            searchedtoexcelbtn.Text = "Export Search Results to Excel";
            searchedtoexcelbtn.UseVisualStyleBackColor = true;
            searchedtoexcelbtn.Click += this.searchedtoexcelbtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(920, 500);
            Controls.Add(searchedtoexcelbtn);
            Controls.Add(btnExportToExcel);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxFiles);
            Controls.Add(buttonLoadFile);
            FormBorderStyle = FormBorderStyle.None;
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
