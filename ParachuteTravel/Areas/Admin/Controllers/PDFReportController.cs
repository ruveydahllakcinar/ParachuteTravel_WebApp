using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PDFReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticPdfReport()
        {
            Guid guid = Guid.NewGuid();
            var root = "wwwroot/PDFReports/";
            var fileName = "static" + " " + guid.ToString() + ".pdf";

            string path = Path.Combine(Directory.GetCurrentDirectory(), root + fileName);
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf Raporu");

            document.Add(paragraph);
            document.Close();
            return File("/PDFReports/" + fileName, "application/pdf", fileName);
        }

        public IActionResult StaticCustomerReport()
        {
            Guid guid = Guid.NewGuid();
            var root = "wwwroot/PDFReports/";
            var fileName =  "user_table"+ " " + guid.ToString() + ".pdf";

            string path = Path.Combine(Directory.GetCurrentDirectory(),root+fileName);
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell("User Name");
            pdfPTable.AddCell("User Surname");
            pdfPTable.AddCell("User Tc");

            pdfPTable.AddCell("Batuhan");
            pdfPTable.AddCell("Basay");
            pdfPTable.AddCell("111222333445");

            pdfPTable.AddCell("Yaman");
            pdfPTable.AddCell("Eroğlu");
            pdfPTable.AddCell("36521478952");

            pdfPTable.AddCell("Halime");
            pdfPTable.AddCell("Keskin");
            pdfPTable.AddCell("24858745457");

            document.Add(pdfPTable);
            document.Close();
            return File("/PDFReports/" + fileName, "application/pdf", fileName);
        }
    }
}
