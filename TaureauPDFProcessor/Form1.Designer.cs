namespace TaureauPDFProcessor
{
    partial class Form1
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
            this.openPDFDialog = new System.Windows.Forms.OpenFileDialog();
            this.openPDFButton = new System.Windows.Forms.Button();
            this.openCSVDialog = new System.Windows.Forms.OpenFileDialog();
            this.openCSV = new System.Windows.Forms.Button();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.projectPasswordLabel = new System.Windows.Forms.Label();
            this.projectSaveDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.projectSaveLocation = new System.Windows.Forms.Button();
            this.runProcessButton = new System.Windows.Forms.Button();
            this.pdfPath = new System.Windows.Forms.Label();
            this.csvPath = new System.Windows.Forms.Label();
            this.saveLocationPath = new System.Windows.Forms.Label();
            this.submitLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.processingLabel = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openPDFDialog
            // 
            this.openPDFDialog.FileName = "openPDFDialog";
            this.openPDFDialog.Title = "Open PDF";
            // 
            // openPDFButton
            // 
            this.openPDFButton.Location = new System.Drawing.Point(13, 22);
            this.openPDFButton.Name = "openPDFButton";
            this.openPDFButton.Size = new System.Drawing.Size(75, 23);
            this.openPDFButton.TabIndex = 0;
            this.openPDFButton.Text = "Open PDF";
            this.openPDFButton.UseVisualStyleBackColor = true;
            this.openPDFButton.Click += new System.EventHandler(this.openPDFButton_Click);
            // 
            // openCSVDialog
            // 
            this.openCSVDialog.FileName = "openCSVDialog";
            this.openCSVDialog.Title = "Open CSV";
            // 
            // openCSV
            // 
            this.openCSV.AccessibleName = "Open CSV";
            this.openCSV.Location = new System.Drawing.Point(13, 61);
            this.openCSV.Name = "openCSV";
            this.openCSV.Size = new System.Drawing.Size(75, 23);
            this.openCSV.TabIndex = 1;
            this.openCSV.Text = "Open CSV";
            this.openCSV.UseVisualStyleBackColor = true;
            this.openCSV.Click += new System.EventHandler(this.openCSV_Click);
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AccessibleName = "Porject Name Label";
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(13, 107);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(71, 13);
            this.projectNameLabel.TabIndex = 2;
            this.projectNameLabel.Text = "Project Name";
            // 
            // projectPasswordLabel
            // 
            this.projectPasswordLabel.AccessibleName = "Password Label";
            this.projectPasswordLabel.AutoSize = true;
            this.projectPasswordLabel.Location = new System.Drawing.Point(13, 165);
            this.projectPasswordLabel.Name = "projectPasswordLabel";
            this.projectPasswordLabel.Size = new System.Drawing.Size(89, 13);
            this.projectPasswordLabel.TabIndex = 4;
            this.projectPasswordLabel.Text = "Project Password";
            // 
            // projectSaveLocation
            // 
            this.projectSaveLocation.AccessibleName = "Folder Save button";
            this.projectSaveLocation.Location = new System.Drawing.Point(16, 237);
            this.projectSaveLocation.Name = "projectSaveLocation";
            this.projectSaveLocation.Size = new System.Drawing.Size(166, 23);
            this.projectSaveLocation.TabIndex = 6;
            this.projectSaveLocation.Text = "Select Project Save Location";
            this.projectSaveLocation.UseVisualStyleBackColor = true;
            this.projectSaveLocation.Click += new System.EventHandler(this.projectSaveLocation_Click);
            // 
            // runProcessButton
            // 
            this.runProcessButton.AccessibleName = "Run Process Button";
            this.runProcessButton.Location = new System.Drawing.Point(16, 284);
            this.runProcessButton.Name = "runProcessButton";
            this.runProcessButton.Size = new System.Drawing.Size(75, 23);
            this.runProcessButton.TabIndex = 7;
            this.runProcessButton.Text = "Run Process";
            this.runProcessButton.UseVisualStyleBackColor = true;
            this.runProcessButton.Click += new System.EventHandler(this.runProcessButton_Click);
            // 
            // pdfPath
            // 
            this.pdfPath.AutoSize = true;
            this.pdfPath.Location = new System.Drawing.Point(111, 27);
            this.pdfPath.Name = "pdfPath";
            this.pdfPath.Size = new System.Drawing.Size(0, 13);
            this.pdfPath.TabIndex = 10;
            // 
            // csvPath
            // 
            this.csvPath.AutoSize = true;
            this.csvPath.Location = new System.Drawing.Point(111, 66);
            this.csvPath.Name = "csvPath";
            this.csvPath.Size = new System.Drawing.Size(0, 13);
            this.csvPath.TabIndex = 11;
            // 
            // saveLocationPath
            // 
            this.saveLocationPath.AutoSize = true;
            this.saveLocationPath.Location = new System.Drawing.Point(197, 242);
            this.saveLocationPath.Name = "saveLocationPath";
            this.saveLocationPath.Size = new System.Drawing.Size(0, 13);
            this.saveLocationPath.TabIndex = 12;
            // 
            // submitLabel
            // 
            this.submitLabel.AutoSize = true;
            this.submitLabel.ForeColor = System.Drawing.Color.Red;
            this.submitLabel.Location = new System.Drawing.Point(111, 289);
            this.submitLabel.Name = "submitLabel";
            this.submitLabel.Size = new System.Drawing.Size(0, 13);
            this.submitLabel.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // processingLabel
            // 
            this.processingLabel.AutoSize = true;
            this.processingLabel.Location = new System.Drawing.Point(432, 353);
            this.processingLabel.Name = "processingLabel";
            this.processingLabel.Size = new System.Drawing.Size(0, 13);
            this.processingLabel.TabIndex = 16;
            // 
            // close
            // 
            this.close.AccessibleName = "Close Button";
            this.close.Location = new System.Drawing.Point(16, 464);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(140, 23);
            this.close.TabIndex = 17;
            this.close.Text = "Close Application";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 627);
            this.Controls.Add(this.close);
            this.Controls.Add(this.processingLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.submitLabel);
            this.Controls.Add(this.saveLocationPath);
            this.Controls.Add(this.csvPath);
            this.Controls.Add(this.pdfPath);
            this.Controls.Add(this.runProcessButton);
            this.Controls.Add(this.projectSaveLocation);
            this.Controls.Add(this.projectPasswordLabel);
            this.Controls.Add(this.projectNameLabel);
            this.Controls.Add(this.openCSV);
            this.Controls.Add(this.openPDFButton);
            this.Name = "Form1";
            this.Text = "PDF Processor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openPDFDialog;
        private System.Windows.Forms.Button openPDFButton;
        private System.Windows.Forms.OpenFileDialog openCSVDialog;
        private System.Windows.Forms.Button openCSV;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Label projectPasswordLabel;
        private System.Windows.Forms.FolderBrowserDialog projectSaveDialog;
        private System.Windows.Forms.Button projectSaveLocation;
        private System.Windows.Forms.Button runProcessButton;
        private System.Windows.Forms.Label pdfPath;
        private System.Windows.Forms.Label csvPath;
        private System.Windows.Forms.Label saveLocationPath;
        private System.Windows.Forms.Label submitLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label processingLabel;
        private System.Windows.Forms.Button close;
    }
}

