using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Pdf;

namespace TaureauPDFProcessor
{
    class ProcessPDF
    {
        Watermark water = new Watermark();
        Security sec = new Security();
        public async Task<bool> RunProject(ProjectModel project)
        {   
            try
            {
                foreach (string company in project.CompanyNames)
                {
                    string str = company;
                    string companyName = str.Replace("\"", "");
                    PdfDocument doc = new PdfDocument();
                    AdobeDTO dto = new AdobeDTO();
                    doc.LoadFromFile(project.PdfFile);
                    dto = water.CreateWatermark(doc, companyName);
                    if (dto.pdf == null)
                    {
                        Console.Write("Issue with " + companyName + dto.Message);
                    }

                    else
                    {
                        dto = sec.SetSecurity(dto.pdf, project.Password);
                        string saveName = project.ProjectName + "-" + companyName + ".pdf";
                        doc = dto.pdf;
                        doc.SaveToFile(project.SaveLocation + " \\ " + saveName);
                    }

                    await Task.Delay(500);
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //private PdfDocument createWaterMark(PdfDocument doc, string companyName)
        //{
        //    //AdobeDTO waterMarkDto = new AdobeDTO();
        //    //waterMarkDto = water.CreateWatermark(doc, companyName);

        //    //if (waterMarkDto.pdf == null)
        //    //{
        //    //    Debug.WriteLine("Issue with " + companyName + waterMarkDto.Message);
        //    //    return;
        //    //}
        //    //else
        //    //{
        //    //    return waterMarkDto.pdf;
        //    //}
        //}
    }
}
