using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using ParachuteTravel.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace ParachuteTravel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExcelReportController : Controller
    {
        private readonly IExcelReportService _excelReportService;

        public ExcelReportController(IExcelReportService excelReportService)
        {
            _excelReportService = excelReportService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public List<DestinationViewModel> DestinationList()
        {
            List<DestinationViewModel> destinationViewModels = new List<DestinationViewModel>();
            using (var context = new Context())
            {
                destinationViewModels = context.Destinations.Select(x => new DestinationViewModel
                {
                    City = x.CityName,
                    DayNight = x.DayNight,
                    Price = x.Price,
                    Capacity = x.Capacity
                }).ToList();
            }
            return destinationViewModels;
        }

        public IActionResult StaticExcelReport()
        {
            Guid guid = Guid.NewGuid();
            var root = "wwwroot/ExcelReport/";
            var fileName = guid.ToString() + ".xlsx";
            string path = Path.Combine(Directory.GetCurrentDirectory(), root + fileName);
            var stream = new FileStream(path, FileMode.Create);
            var newFile = stream;
            return File(_excelReportService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", root + fileName);
        }

        public IActionResult DestinationExcelReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Tour List");
                workSheet.Cell(1, 1).Value = "City";
                workSheet.Cell(1, 2).Value = "Day/Night";
                workSheet.Cell(1, 3).Value = "Price";
                workSheet.Cell(1, 3).Value = "Quota";

                int rowCount = 2;
                foreach (var excel in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = excel.City;
                    workSheet.Cell(rowCount, 2).Value = excel.DayNight;
                    workSheet.Cell(rowCount, 3).Value = excel.Price;
                    workSheet.Cell(rowCount, 4).Value = excel.Capacity;
                    rowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "newtours.xlsx");
                }
            }
        }
    }
}