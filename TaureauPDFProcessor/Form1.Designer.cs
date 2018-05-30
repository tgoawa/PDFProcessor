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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 627);
            this.Controls.Add(this.openPDFButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openPDFDialog;
        private System.Windows.Forms.Button openPDFButton;
    }
}

