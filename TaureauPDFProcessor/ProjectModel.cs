using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaureauPDFProcessor
{
    class ProjectModel
    {
        public int Id { get; set; }
        public string PdfFile { get; set; }
        public string[] CompanyNames { get; set; }
        public string Password { get; set; }
        private string MasterPassword = "masterpassword";
        public string SaveLocation { get; set; }
    }
}
