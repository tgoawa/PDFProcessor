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
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
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
            // projectNameTextBox
            // 
            this.projectNameTextBox.AccessibleName = "Project Name Textbox";
            this.projectNameTextBox.Location = new System.Drawing.Point(16, 124);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.projectNameTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 627);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(this.projectNameLabel);
            this.Controls.Add(this.openCSV);
            this.Controls.Add(this.openPDFButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openPDFDialog;
        private System.Windows.Forms.Button openPDFButton;
        private System.Windows.Forms.OpenFileDialog openCSVDialog;
        private System.Windows.Forms.Button openCSV;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.TextBox projectNameTextBox;
    }
}

