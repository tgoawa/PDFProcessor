using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Pdf;

namespace TaureauPDFProcessor
{
    class Security
    {
        public AdobeDTO SetSecurity(PdfDocument pdf, string companyName)
        {
            AdobeDTO dto = new AdobeDTO();
            dto.pdf = null;
            dto.Message = String.Empty;
            try
            {
                pdf.Security.KeySize = Spire.Pdf.Security.PdfEncryptionKeySize.Key256Bit;
                pdf.Security.OwnerPassword = "schenck";
                pdf.Security.UserPassword = companyName;
                pdf.Security.Permissions = Spire.Pdf.Security.PdfPermissionsFlags.Print;
                dto.pdf = pdf;
            }
            catch (Exception ex)
            {

                dto.Message = ex.Message;
            }

            return dto;
        }
    }
}
