namespace FileCountReporter
{
    public partial class Form1 : Form
    {
        private string selectedFolderPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedFolderPath = dialog.SelectedPath;
                textBoxOutput.Text = $"{Environment.NewLine}{selectedFolderPath}";
            }
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            if (selectedFolderPath == null)
            {
                MessageBox.Show("Please Browse for a folder first.");
                return;
            }
        }
    }
}
