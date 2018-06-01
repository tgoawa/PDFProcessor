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
            this.projectNameTextBox = new TextBox();
            this.passwordTextBox = new TextBox();
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
                    File.WriteAllLines(csvName, companyNames);
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
            }
        }

        private void runProcessButton_Click(object sender, EventArgs e)
        {
            var projectToProcess = new ProcessPDF();

            projectToProcess.RunProject(this.project);
        }

    }
}
