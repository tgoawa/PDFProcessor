using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Pdf;

namespace TaureauPDFProcessor
{
    class ProcessPDF
    {
        public void RunProject(ProjectModel project)
        {   
            Watermark water = new Watermark();
            Security sec = new Security();
            try
            {
                Directory.SetCurrentDirectory(project.PdfFile);
                foreach (string company in project.CompanyNames)
                {
                    PdfDocument doc = new PdfDocument();
                    AdobeDTO dto = new AdobeDTO();
                    doc.LoadFromFile(project.PdfFile);
                    dto = water.CreateWatermark(doc, company);
                    if (dto.pdf == null)
                    {
                        Console.Write("Issue with " + company + dto.Message);
                    }
                    else
                    {
                        string saveName = project.ProjectName + company + ".pdf";
                        doc = sec.SetSecurity(doc, project.Password);
                        doc.SaveToFile(project.SaveLocation + saveName);
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
