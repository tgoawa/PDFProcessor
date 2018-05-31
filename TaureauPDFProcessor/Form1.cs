﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaureauPDFProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.projectNameTextBox = new TextBox();
            this.passwordTextBox = new TextBox();
        }

        private void openPDFButton_Click(object sender, EventArgs e)
        {
            string pdfName = null;

            using (this.openPDFDialog = new OpenFileDialog())
            {
                openPDFDialog.Filter = "csv files (*.csv)|*.csv";

                if (openPDFDialog.ShowDialog() == DialogResult.OK)
                {
                    pdfName = openPDFDialog.FileName;
                }
            }
        }

        private void openCSV_Click(object sender, EventArgs e)
        {
            string csvName = null;

            using (this.openCSVDialog = new OpenFileDialog())
            {
                openCSVDialog.Filter = "pdf files (*.pdf)|*.pdf";

                if (openCSVDialog.ShowDialog() == DialogResult.OK)
                {
                    csvName = openCSVDialog.FileName;
                }
            }
        }

    }
}
