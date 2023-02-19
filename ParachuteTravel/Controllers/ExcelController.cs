using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using ParachuteTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Controllers
{
    public class ExcelController : Controller
    {
        public IActionResult Index()
        {
            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Page1");
            workSheet.Cells[1, 1].Value = "Route";
            workSheet.Cells[1, 2].Value = "Guide";
            workSheet.Cells[1, 3].Value = "Quota";

            workSheet.Cells[2, 1].Value = "Georgia-Batumi";
            workSheet.Cells[2, 2].Value = "Hatice Balcık";
            workSheet.Cells[2, 3].Value = "35";

            workSheet.Cells[3, 1].Value = "Serbia- Macedonia";
            workSheet.Cells[3, 2].Value = "Mehmet Çelik";
            workSheet.Cells[3, 3].Value = "55";

            var bytes = excel.GetAsByteArray();
            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","tour.xlsx");
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
    }
}
