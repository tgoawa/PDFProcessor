using System.Threading.Tasks;
using Spire.Pdf;

namespace TaureauPDFProcessor
{
    public interface IWatermark
    {
        Task<PdfDocument> CreateWatermark(PdfDocument doc, string companyName);
    }
}
