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
   public  class ProcessPDF
    {
       
        Security sec = new Security();
        public async Task<string> RunProject(ProjectModel project)
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
                    Watermark wm = new Watermark();
                    Security sec = new Security();

                    dto = await CreateWaterMark(wm,doc, companyName);
                    if (!string.IsNullOrEmpty(dto.Message))
                        return dto.Message;

                    dto = await SetSecurity(sec, dto.pdf, project.Password, companyName);
                    if (!string.IsNullOrEmpty(dto.Message))
                        return dto.Message;

                    dto = await SavePDF(dto.pdf, project.ProjectName, project.SaveLocation, companyName);
                    if (!string.IsNullOrEmpty(dto.Message))
                        return dto.Message;

                    await Task.Delay(500);
                }

                return string.Empty;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        public async Task<AdobeDTO> CreateWaterMark(IWatermark wm, PdfDocument doc, string companyName)
        {
            AdobeDTO dto = new AdobeDTO();
            if (doc == null)
            {
                dto.pdf = null;
                dto.Message = "PDF Document was empty";
                return dto;
            }

            if (string.IsNullOrEmpty(companyName))
            {
                dto.pdf = new PdfDocument();
                dto.Message = "Company name was empty";
                return dto;
            }
            try
            {
               dto.pdf = await wm.CreateWatermark(doc, companyName);
                dto.Message = string.Empty;
                return dto;
            }
            catch (Exception e)
            {
                dto.pdf = null;
                dto.Message = e.Message;
                return dto;
            }
        }

        public async Task<AdobeDTO> SetSecurity(ISecurity sc, PdfDocument doc, string password, string companyName)
        {
            AdobeDTO dto = new AdobeDTO();
            if (doc == null)
            {
                dto.pdf = null;
                dto.Message = "PDF Document was empty";
                return dto;
            }
            if (string.IsNullOrEmpty(companyName))
            {
                dto.pdf = new PdfDocument();
                dto.Message = "Company name was empty";
                return dto;
            }
            if (string.IsNullOrEmpty(password))
            {
                dto.pdf = new PdfDocument();
                dto.Message = "Password was empty";
                return dto;
            }
            try
            {
                dto.pdf = await sc.SetSecurity(doc, password);
                dto.Message = string.Empty;
                return dto;
            }
            catch (Exception e)
            {
                dto.pdf = null;
                dto.Message = e.Message;
                return dto;
            }
        }

        public async Task<AdobeDTO> SavePDF(PdfDocument doc, string projectName, string saveLocation, string companyName)
        {
            AdobeDTO dto = new AdobeDTO();

            if (doc == null)
            {
                dto.pdf = null;
                dto.Message = "PDF Document was empty";
                return dto;
            }
            if (string.IsNullOrEmpty(projectName))
            {
                dto.pdf = new PdfDocument();
                dto.Message = "Project name was empty";
                return dto;
            }
            if (string.IsNullOrEmpty(saveLocation))
            {
                dto.pdf = new PdfDocument();
                dto.Message = "Save location was empty";
                return dto;
            }
            if (string.IsNullOrEmpty(companyName))
            {
                dto.pdf = new PdfDocument();
                dto.Message = "Company name was empty";
                return dto;
            }
            try
            {
                string saveName = projectName + "-" + companyName + ".pdf";
                doc.SaveToFile(saveLocation + " \\ " + saveName);
                dto.Message = string.Empty;
                return dto;
            }
            catch(Exception e)
            {
                dto.pdf = null;
                dto.Message = e.Message;
                return dto;
            }

        }

    }
}
