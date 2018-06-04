using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaureauPDFProcessor
{
    public partial class Form1 : Form
    {
        private ProjectModel project;
        public Form1()
        {
            InitializeComponent();
            this.project = new ProjectModel();
        }

        private void openPDFButton_Click(object sender, EventArgs e)
        {
            string pdfName = null;

            using (this.openPDFDialog = new OpenFileDialog())
            {
                openPDFDialog.Filter = "pdf files (*.pdf)|*.pdf";

                if (openPDFDialog.ShowDialog() == DialogResult.OK)
                {
                    pdfName = openPDFDialog.FileName;
                }

                if (pdfName != null)
                {
                    this.project.PdfFile = pdfName;
                    this.pdfPath.Text = pdfName;
                }
            }
        }

        private void openCSV_Click(object sender, EventArgs e)
        {
            string csvName = null;
            string[] companyNames = {};

            using (this.openCSVDialog = new OpenFileDialog())
            {
                openCSVDialog.Filter = "csv files (*.csv)|*.csv";

                if (openCSVDialog.ShowDialog() == DialogResult.OK)
                {
                    csvName = openCSVDialog.FileName;
                }

                if (csvName != null)
                {
                    companyNames = File.ReadAllLines(csvName);
                    this.csvPath.Text = csvName;
                }

                if (companyNames.Length > 0)
                {
                    this.project.CompanyNames = companyNames;
                }

            }
        }

        private void projectSaveLocation_Click(object sender, EventArgs e)
        {
            string folderName = null;

            DialogResult result = this.projectSaveDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                folderName = this.projectSaveDialog.SelectedPath;
            }

            if (folderName != null)
            {
                this.project.SaveLocation = folderName;
                this.saveLocationPath.Text = folderName;
            }
        }

        private async void runProcessButton_Click(object sender, EventArgs e)
        {
            var projectToProcess = new ProcessPDF();
            this.project.ProjectName = this.textBox1.Text;
            this.project.Password = this.textBox2.Text;

            if (String.IsNullOrEmpty(this.pdfPath.Text))
            {
                this.submitLabel.Text = "No PDF selected";
                return;
            }
            if (String.IsNullOrEmpty(this.csvPath.Text))
            {
                this.submitLabel.Text = "No CSV selected";
                return;
            }
            if (String.IsNullOrEmpty(this.project.ProjectName))
            {
                this.submitLabel.Text = "No Project name selected";
                return;
            }
            if (String.IsNullOrEmpty(this.project.Password))
            {
                this.submitLabel.Text = "No password chosen";
                return;
            }
            if (String.IsNullOrEmpty(this.saveLocationPath.Text))
            {
                this.submitLabel.Text = "No save location chosen";
                return;
            }
            this.submitLabel.Text = "";
            this.processingLabel.Text = "Now processing " + this.project.CompanyNames.Length + " different companies";
            string message = await projectToProcess.RunProject(this.project);
            if (string.IsNullOrEmpty(message))
            {
                message = "Process completed";
                this.processingLabel.Text = message;
                MessageBox.Show("Finished processing");
            }
            else
            {
                this.processingLabel.Text = message;
                MessageBox.Show(message);
            }
        }

    }
}
