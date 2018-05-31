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
        public static string SetSecurity(PdfDocument pdf, string companyName)
        {
            string message = null;
            try
            {
                pdf.Security.KeySize = Spire.Pdf.Security.PdfEncryptionKeySize.Key256Bit;
                pdf.Security.OwnerPassword = "schenck";
                pdf.Security.UserPassword = companyName;
                pdf.Security.Permissions = Spire.Pdf.Security.PdfPermissionsFlags.Print;
                return message;
            }
            catch (Exception ex)
            {

                message = ex.Message;
                return message
            }

        }
    }
}
