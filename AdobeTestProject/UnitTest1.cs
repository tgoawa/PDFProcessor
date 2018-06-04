using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spire.Pdf;
using TaureauPDFProcessor;

namespace AdobeTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestTrueWaterMark()
        {
            IWatermark wm = new TestNullWatermark();
            PdfDocument doc = null;
            string company = string.Empty;
            ProcessPDF processPDf = new ProcessPDF();
            AdobeDTO dto = await processPDf.CreateWaterMark(wm, doc, company);
            Assert.IsNull(dto.pdf);
            Assert.AreEqual("PDF Document was empty", dto.Message);
        }

        [TestMethod]
        public async Task TestEmptyCompany()
        {
            IWatermark wm = new TestNullWatermark();
            PdfDocument doc = new PdfDocument();
            string company = string.Empty;
            ProcessPDF processPDf = new ProcessPDF();
            AdobeDTO dto = await processPDf.CreateWaterMark(wm, doc, company);
            Assert.IsNotNull(dto.pdf);
            Assert.AreEqual("Company name was empty", dto.Message );
        }

        [TestMethod]
        public async Task TestGoodWaterMark()
        {
            IWatermark wm = new TestGoodWatermark();
            PdfDocument doc = new PdfDocument();
            string company = "test company";
            ProcessPDF processPDf = new ProcessPDF();
            AdobeDTO dto = await processPDf.CreateWaterMark(wm, doc, company);
            Assert.IsNotNull(dto.pdf);
            Assert.AreEqual(string.Empty, dto.Message);

        }

        [TestMethod]
        public async Task TestExceptionWatermark()
        {
            IWatermark wm = new TestExceptionWatermark();
            PdfDocument doc = new PdfDocument();
            string company = "test company";
            ProcessPDF processPdf = new ProcessPDF();
            AdobeDTO dto = await processPdf.CreateWaterMark(wm, doc, company);
            Assert.AreNotSame(string.Empty, dto.Message);
        }

        [TestMethod]
        public async Task TestTrueSecurity()
        {
            ISecurity sc = new TestNullSecurity();
            PdfDocument doc = null;
            string company = string.Empty;
            string password = string.Empty;
            ProcessPDF processPDf = new ProcessPDF();
            AdobeDTO dto = await processPDf.SetSecurity(sc, doc, password, company);
            Assert.IsNull(dto.pdf);
            Assert.AreEqual("PDF Document was empty", dto.Message);
        }

        [TestMethod]
        public async Task TestEmptyCompanySecurity()
        {
            ISecurity sc = new TestNullSecurity();
            PdfDocument doc = new PdfDocument();
            string company = string.Empty;
            string password = string.Empty;
            ProcessPDF processPDf = new ProcessPDF();
            AdobeDTO dto = await processPDf.SetSecurity(sc, doc, password, company);
            Assert.IsNotNull(dto.pdf);
            Assert.AreEqual("Company name was empty", dto.Message);
        }

        [TestMethod]
        public async Task TestEmptyPassword()
        {
            ISecurity sc = new TestNullSecurity();
            PdfDocument doc = new PdfDocument();
            string company = "test company";
            string password = string.Empty;
            ProcessPDF processPDf = new ProcessPDF();
            AdobeDTO dto = await processPDf.SetSecurity(sc, doc, password, company);
            Assert.IsNotNull(dto.pdf);
            Assert.AreEqual("Password was empty", dto.Message);
        }

        [TestMethod]
        public async Task TestGoodSecurity()
        {
            ISecurity sc = new TestGoodSecurity();
            PdfDocument doc = new PdfDocument();
            string company = "test company";
            string password = "password";
            ProcessPDF processPDf = new ProcessPDF();
            AdobeDTO dto = await processPDf.SetSecurity(sc, doc, password, company);
            Assert.IsNotNull(dto.pdf);
            Assert.AreEqual(string.Empty, dto.Message);

        }

        [TestMethod]
        public async Task TestExceptionSecurity()
        {
            ISecurity sc = new TestExceptionSecurity();
            PdfDocument doc = new PdfDocument();
            string company = "test company";
            string password = "password";
            ProcessPDF processPDf = new ProcessPDF();
            AdobeDTO dto = await processPDf.SetSecurity(sc, doc, password, company);
            Assert.AreNotSame(string.Empty, dto.Message);
        }
    }
    public class TestNullWatermark : IWatermark
    {
        public Task<PdfDocument> CreateWatermark(PdfDocument doc, string companyName)
        {
            return null;
        }
    }
    public class TestGoodWatermark : IWatermark
    {
        public Task<PdfDocument> CreateWatermark(PdfDocument doc, string companyName)
        {
            PdfDocument pdf = new PdfDocument();
            return Task.FromResult(pdf);
        }
    }
    public class TestExceptionWatermark : IWatermark
    {
        public Task<PdfDocument> CreateWatermark(PdfDocument doc, string companyName)
        {
            throw new Exception("Exception thrown");
        }
    }

    public class TestNullSecurity : ISecurity
    {
        public Task<PdfDocument> SetSecurity(PdfDocument doc, string companyName)
        {
            return null;
        }
    }
    public class TestGoodSecurity : ISecurity
    {
        public Task<PdfDocument> SetSecurity(PdfDocument doc, string companyName)
        {
            PdfDocument pdf = new PdfDocument();
            return Task.FromResult(pdf);
        }
    }
    public class TestExceptionSecurity : ISecurity
    {
        public Task<PdfDocument> SetSecurity(PdfDocument doc, string companyName)
        {
            throw new Exception("Exception thrown");
        }
    }
}
