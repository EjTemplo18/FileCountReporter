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
                textBoxOutput.Text = $"Selected folder:{Environment.NewLine}{selectedFolderPath}";
            }
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {

        }
    }
}
