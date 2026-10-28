namespace FileCountReporter
{
    public partial class Form1 : Form
    {
        // This string stores the chosen folder with the browse button.
        private string selectedFolderPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();

            // Saves the selected path only if the user confirms their choice.
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedFolderPath = dialog.SelectedPath;
                textBoxOutput.Text = $"{Environment.NewLine}{selectedFolderPath}";
            }
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            // A folder must be selected before its contents can be counted.
            if (selectedFolderPath == null)
            {
                MessageBox.Show("Please Browse for a folder first.");
                return;
            }

            try
            {
                // Count files and folders directly inside the selected folder.
                int files = Directory.GetFiles(selectedFolderPath).Length;
                int folders = Directory.GetDirectories(selectedFolderPath).Length;

                // Display both totals in the output text box.
                textBoxOutput.Text = $"Files: {files} {Environment.NewLine}Folders: {folders}";
            }
            catch (IOException)
            {
                // Display a message if the folder cannot be read or is no longer available.
                textBoxOutput.Text = "Error: Could not read the selected Folder!";
            }
            catch (UnauthorizedAccessException)
            {
                // Display a message if the user does not have permission to access the folder.
                textBoxOutput.Text = "Error: You do not have permission to access the selected folder!";
            }
        }
    }
}
