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
    public class Watermark :IWatermark  
    {
        public Task<PdfDocument> CreateWatermark(PdfDocument doc, string companyName)
        {
            foreach (PdfPageBase page in doc.Pages)
                {
                PdfTilingBrush brush = new PdfTilingBrush(new SizeF(page.Canvas.ClientSize.Width, page.Canvas.ClientSize.Height));
                brush.Graphics.SetTransparency(0.3f);
                brush.Graphics.Save();
                brush.Graphics.TranslateTransform(350, 215);
                brush.Graphics.RotateTransform(-45);
                brush.Graphics.DrawString(companyName,
                    new PdfFont(PdfFontFamily.Helvetica, 24), PdfBrushes.Gray, 0, 0,
                    new PdfStringFormat(PdfTextAlignment.Center));
                brush.Graphics.Restore();
                brush.Graphics.SetTransparency(1);
                page.Canvas.DrawRectangle(brush, new RectangleF(new PointF(0, 0), page.Canvas.ClientSize));
            }
            return Task.FromResult(doc);

        }
    }
}
