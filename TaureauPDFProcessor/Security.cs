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
        public PdfDocument SetSecurity(PdfDocument pdf, string password)
        {
            PdfDocument tempDoc = new PdfDocument();
            try
            {
                pdf.Security.KeySize = Spire.Pdf.Security.PdfEncryptionKeySize.Key256Bit;
                pdf.Security.OwnerPassword = "schenck";
                pdf.Security.UserPassword = password;
                pdf.Security.Permissions = Spire.Pdf.Security.PdfPermissionsFlags.Print;
                tempDoc = pdf;
                return tempDoc;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
