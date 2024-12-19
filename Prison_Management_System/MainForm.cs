using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Prison_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Manually add the specific filenames to the ComboBox
            comboBoxFiles.Items.Add("Prisoners Records.txt");
            comboBoxFiles.Items.Add("Visitors Records.txt");
            comboBoxFiles.Items.Add("Staff Records.txt");
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            // Folder path to load files from
            string folderPath = @"../../../Database_Files";

            if (comboBoxFiles.SelectedItem == null)
            {
                MessageBox.Show("Please select a file from the dropdown.");
                return;
            }

            string selectedFile = comboBoxFiles.SelectedItem.ToString();
            string filePath = Path.Combine(folderPath, selectedFile);

            if (File.Exists(filePath))
            {

                Console.WriteLine($"Loading file: {filePath}");

                // Read all lines from the file
                var lines = File.ReadAllLines(filePath);

                // Create a DataTable to store the data
                DataTable table = new DataTable();

                // Set up columns based on the file type
                if (selectedFile == "Prisoners Records.txt")
                {
                    table.Columns.Add("ID");
                    table.Columns.Add("National ID");
                    table.Columns.Add("Name");
                    table.Columns.Add("Crime");
                    table.Columns.Add("Duration");
                    table.Columns.Add("Cell");
                }
                else if (selectedFile == "Visitors Records.txt")
                {
                    table.Columns.Add("Visit ID");
                    table.Columns.Add("Name");
                    table.Columns.Add("National ID");
                    table.Columns.Add("Prisoner ID");
                    table.Columns.Add("Relation");
                    table.Columns.Add("Visit Date");
                }
                else if (selectedFile == "Staff Records.txt")
                {
                    table.Columns.Add("Staff ID");
                    table.Columns.Add("Name");
                    table.Columns.Add("National ID");
                    table.Columns.Add("Role");
                    table.Columns.Add("Shift");
                }

                // Loop through each line and add it to the DataTable
                foreach (var line in lines) // Lines has all the lines in the file
                {
                    if (string.IsNullOrWhiteSpace(line)) continue; // Skip empty lines

                    var columns = line.Split('|'); // Use '|' as the delimiter
                    if (columns.Length == table.Columns.Count) // Checks if the No. of data in each line eqauls the No. of columns
                    {
                        table.Rows.Add(columns); // Add row to the table
                    }
                    else
                    {
                        Console.WriteLine($"Skipping malformed line: {line}");
                    }
                }

                // Bind the DataTable to the DataGridView to display the data
                dataGridView1.DataSource = table;
            }
            else
            {
                MessageBox.Show($"File '{selectedFile}' not found!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            // Get the selected row index
            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedIndex];
            string selectedID = selectedRow.Cells[0].Value.ToString();

            // Get the selected file from ComboBox
            string selectedFile = comboBoxFiles.SelectedItem.ToString();
            string filePath = Path.Combine(@"../../../Database_Files", selectedFile);

            // Read all lines from the file
            var lines = File.ReadAllLines(filePath).ToList();

            // Find the line that corresponds to the selected ID
            lines.RemoveAll(line => line.StartsWith(selectedID + "|"));

            // Save the updated content back to the file
            File.WriteAllLines(filePath, lines);

            // Refresh DataGridView
            buttonLoadFile_Click(sender, e); // Reload the data from the file
            MessageBox.Show($"Record with ID {selectedID} has been deleted.");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Ensure a record is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to edit.");
                return;
            }
             
                // Get the selected file from ComboBox
                if (comboBoxFiles.SelectedItem == null)
                {
                    MessageBox.Show("Please select a file first.");
                    return;
                }
                string selectedFile = comboBoxFiles.SelectedItem.ToString();

                
                MessageBox.Show($"Selected file: {selectedFile}");

                string filePath = Path.Combine(@"../../../Database_Files", selectedFile);

                // Read all lines from the file
                var lines = File.ReadAllLines(filePath).ToList();

                // Get the selected row index and the ID
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedIndex];

                // Get the ID from the first column of the selected row
                string selectedID = selectedRow.Cells[0].Value.ToString();
                if (string.IsNullOrEmpty(selectedID))
                {
                    MessageBox.Show("Invalid record selection.");
                    return;
                }

                // Find the line that corresponds to the selected ID
                int lineIndex = lines.FindIndex(line => line.StartsWith(selectedID + "|"));
                if (lineIndex == -1)
                {
                    MessageBox.Show("Record not found in the file.");
                    return;
                }

                // Prepare input boxes based on file name
                string[] lineParts = lines[lineIndex].Split('|');
                string updatedLine = "";

                // More flexible file type checking
                if (selectedFile.ToLower().Contains("visitor") || selectedFile.ToLower().Contains("visit"))
                {
                    string newVisitId = Microsoft.VisualBasic.Interaction.InputBox("Enter new Visit ID", "Edit Record", lineParts[0]);
                    string newName = Microsoft.VisualBasic.Interaction.InputBox("Enter new Name", "Edit Record", lineParts[1]);
                    string newNatId = Microsoft.VisualBasic.Interaction.InputBox("Enter new National ID", "Edit Record", lineParts[2]);
                    string newPrsrId = Microsoft.VisualBasic.Interaction.InputBox("Enter new Prisoner ID", "Edit Record", lineParts[3]);
                    string newRel = Microsoft.VisualBasic.Interaction.InputBox("Enter new Relation", "Edit Record", lineParts[4]);
                    string newDate = Microsoft.VisualBasic.Interaction.InputBox("Enter new Date", "Edit Record", lineParts[5]);

                    updatedLine = $"{newVisitId}|{newName}|{newNatId}|{newPrsrId}|{newRel}|{newDate}";
                }
                else if (selectedFile.ToLower().Contains("prisoner") || selectedFile.ToLower().Contains("prison"))
                {
                    string newId = Microsoft.VisualBasic.Interaction.InputBox("Enter new Prisoner ID", "Edit Record", lineParts[0]);
                    string newNatId = Microsoft.VisualBasic.Interaction.InputBox("Enter new National ID", "Edit Record", lineParts[1]);
                    string newName = Microsoft.VisualBasic.Interaction.InputBox("Enter new Name", "Edit Record", lineParts[2]);
                    string newCrime = Microsoft.VisualBasic.Interaction.InputBox("Enter new Crime", "Edit Record", lineParts[3]);
                    string newDuration = Microsoft.VisualBasic.Interaction.InputBox("Enter new Duration", "Edit Record", lineParts[4]);
                    string newCell = Microsoft.VisualBasic.Interaction.InputBox("Enter new Cell", "Edit Record", lineParts[5]);

                    updatedLine = $"{newId}|{newNatId}|{newName}|{newCrime}|{newDuration}|{newCell}";
                }
                else if (selectedFile.ToLower().Contains("staff"))
                {
                    string newId = Microsoft.VisualBasic.Interaction.InputBox("Enter new Staff ID", "Edit Record", lineParts[0]);
                    string newName = Microsoft.VisualBasic.Interaction.InputBox("Enter new Name", "Edit Record", lineParts[1]);
                    string newNatId = Microsoft.VisualBasic.Interaction.InputBox("Enter new National ID", "Edit Record", lineParts[2]);
                    string newRole = Microsoft.VisualBasic.Interaction.InputBox("Enter new Role", "Edit Record", lineParts[3]);
                    string newShift = Microsoft.VisualBasic.Interaction.InputBox("Enter new Shift", "Edit Record", lineParts[4]);

                    updatedLine = $"{newId}|{newName}|{newNatId}|{newRole}|{newShift}";
                }
                else
                {
                    // If no matching file type found, show more diagnostic information
                    MessageBox.Show($"Unsupported file type. File name: {selectedFile}\n\n" +
                                    $"Full path: {filePath}\n\n" +
                                    "Please ensure the file name contains 'visitor', 'prisoner', or 'staff'.");
                    return;
                }

                // Replace the old line with the updated line
                lines[lineIndex] = updatedLine;

                // Save the updated content back to the file
                File.WriteAllLines(filePath, lines);

                // Refresh the DataGridView
                buttonLoadFile_Click(sender, e);

                MessageBox.Show($"Record with ID {selectedID} has been updated.");
            
        }

        private void SearchAndSelect(string searchTerm)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No records to search in.");
                return;
            }

            // Clear existing selections
            dataGridView1.ClearSelection();

            bool matchFound = false;

            // Iterate through the rows and columns to search for the term
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                    {
                        // Select the row if a match is found
                        row.Selected = true;
                        matchFound = true;
                        break; // Stop searching in this row, move to the next
                    }
                }
            }

            if (!matchFound)
            {
                MessageBox.Show("No matching records found.");
            }
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = false; // Allow the beep sound on Enter
                string searchTerm = textBoxSearch.Text.Trim();
                SearchAndSelect(searchTerm);
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToExcel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during export: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportToExcel()
        {
            // Ensure EPPlus license compliance
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Check if the DataGridView has rows
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data available to export.", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Open Save File Dialog to choose file location
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Save Exported Search Results",
                FileName = $"DataBase[{DateTime.Now:yyyy-MM-dd_HH-mm-ss}].xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (var package = new ExcelPackage())
                {
                    // Create a worksheet
                    var worksheet = package.Workbook.Worksheets.Add("DataBase");

                    // Add column headers
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
                    }

                    // Add rows of data
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    // Save the Excel file
                    FileInfo file = new FileInfo(filePath);
                    package.SaveAs(file);

                    MessageBox.Show($"DataBase exported successfully!\nFile saved at: {file.FullName}", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void searchedtoexcelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ExportSearchResultsToExcel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during export: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportSearchResultsToExcel()
        {
            // Ensure there are selected rows
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one record to export.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save the Excel File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Excel package
                    using (var package = new ExcelPackage(new FileInfo(saveFileDialog.FileName)))
                    {
                        // Create a worksheet in the Excel file
                        var worksheet = package.Workbook.Worksheets.Add("Searched Data");

                        // Add column headers to the first row
                        for (int col = 0; col < dataGridView1.Columns.Count; col++)
                        {
                            worksheet.Cells[1, col + 1].Value = dataGridView1.Columns[col].HeaderText;
                        }

                        // Loop through the selected rows and add them to the worksheet
                        int rowIndex = 2; // Start from row 2 (row 1 is for headers)
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            for (int col = 0; col < dataGridView1.Columns.Count; col++)
                            {
                                worksheet.Cells[rowIndex, col + 1].Value = row.Cells[col].Value?.ToString();
                            }
                            rowIndex++;
                        }

                        // Save the package
                        package.Save();

                        MessageBox.Show("Selected records have been exported to Excel.");
                    }
                }
            }
        }
    }
}