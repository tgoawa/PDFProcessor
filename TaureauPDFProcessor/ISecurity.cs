using System.Threading.Tasks;
using Spire.Pdf;

namespace TaureauPDFProcessor
{
    public interface ISecurity
    {
        Task<PdfDocument> SetSecurity(PdfDocument pdf, string password);
    }
}
