using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Pdf;
using Spire.Pdf.Graphics;

namespace TaureauPDFProcessor
{
    class Watermark
    {
        public AdobeDTO CreateWatermark(PdfDocument doc, string companyName)
        {
            AdobeDTO dto = new AdobeDTO();
            dto.pdf = null;
            dto.Message = String.Empty;
            try
            {
                foreach (PdfPageBase page in doc.Pages)
                {
                    PdfTilingBrush brush = new PdfTilingBrush(new SizeF(page.Canvas.ClientSize.Width / 2, page.Canvas.ClientSize.Height / 3));
                    brush.Graphics.SetTransparency(0.3f);
                    brush.Graphics.Save();
                    brush.Graphics.TranslateTransform(brush.Size.Width / 2, brush.Size.Height / 2);
                    brush.Graphics.RotateTransform(-45);
                    brush.Graphics.DrawString(companyName,
                        new PdfFont(PdfFontFamily.Helvetica, 24), PdfBrushes.Violet, 0, 0,
                        new PdfStringFormat(PdfTextAlignment.Center));
                    brush.Graphics.Restore();
                    brush.Graphics.SetTransparency(1);
                    page.Canvas.DrawRectangle(brush, new RectangleF(new PointF(0, 0), page.Canvas.ClientSize));
                }
                dto.pdf = doc;
            }

            catch (Exception ex)
            {
                dto.Message = ex.Message;
            }

            return dto;
        }
    }
}
