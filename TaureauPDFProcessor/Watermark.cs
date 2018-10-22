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
                brush.Graphics.TranslateTransform(100, 200);
                brush.Graphics.RotateTransform(-45);
                brush.Graphics.DrawString(companyName,
                    new PdfFont(PdfFontFamily.Helvetica, 16), PdfBrushes.Purple, 0, 0,
                    new PdfStringFormat(PdfTextAlignment.Left));
                brush.Graphics.Restore();
                brush.Graphics.SetTransparency(1);
                page.Canvas.DrawRectangle(brush, new RectangleF(new PointF(0, 0), page.Canvas.ClientSize));
                //float calculateDistance = (page.Canvas.ClientSize.Height - 80) / 3;
                //float height = 40;
                //for (var count = 0; count < 4; count++)
                //{
                //page.Canvas.DrawString(companyName,
                //    new PdfFont(PdfFontFamily.Helvetica, 25f),
                //    new PdfSolidBrush(Color.Green),
                //    10, height);
                //    height = height + calculateDistance;
                //}
                //page.Canvas.RotateTransform(-20);
            }
            return Task.FromResult(doc);

        }
    }
}
