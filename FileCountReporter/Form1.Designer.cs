namespace FileCountReporter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxOutput = new TextBox();
            buttonCount = new Button();
            labelFolderToScan = new Label();
            buttonBrowse = new Button();
            SuspendLayout();
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(52, 151);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(185, 27);
            textBoxOutput.TabIndex = 0;
            // 
            // buttonCount
            // 
            buttonCount.Location = new Point(122, 198);
            buttonCount.Name = "buttonCount";
            buttonCount.Size = new Size(140, 59);
            buttonCount.TabIndex = 1;
            buttonCount.Text = "Count";
            buttonCount.UseVisualStyleBackColor = true;
            buttonCount.Click += buttonCount_Click;
            // 
            // labelFolderToScan
            // 
            labelFolderToScan.AutoSize = true;
            labelFolderToScan.Location = new Point(52, 119);
            labelFolderToScan.Name = "labelFolderToScan";
            labelFolderToScan.Size = new Size(107, 20);
            labelFolderToScan.TabIndex = 2;
            labelFolderToScan.Text = "Folder to Scan:";
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(258, 151);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(101, 34);
            buttonBrowse.TabIndex = 3;
            buttonBrowse.Text = "Browse Folder";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 450);
            Controls.Add(buttonBrowse);
            Controls.Add(labelFolderToScan);
            Controls.Add(buttonCount);
            Controls.Add(textBoxOutput);
            Name = "Form1";
            Text = "File Count Reporter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxOutput;
        private Button buttonCount;
        private Label labelFolderToScan;
        private Button buttonBrowse;
    }
}
