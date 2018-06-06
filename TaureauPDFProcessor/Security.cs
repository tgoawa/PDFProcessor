using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Pdf;

namespace TaureauPDFProcessor
{
    public class Security: ISecurity
    {
        public Task<PdfDocument> SetSecurity(PdfDocument pdf, string password)
        {
                pdf.Security.KeySize = Spire.Pdf.Security.PdfEncryptionKeySize.Key256Bit;
                pdf.Security.OwnerPassword = password;
                pdf.Security.Permissions = Spire.Pdf.Security.PdfPermissionsFlags.Print;

            return Task.FromResult(pdf);
        }
    }
}