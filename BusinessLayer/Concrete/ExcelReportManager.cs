﻿using BusinessLayer.Abstract;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExcelReportManager : IExcelReportService
    {
        public byte[] ExcelList<T>(List<T> t) where T : class
        {
            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("ExcelPage");
            workSheet.Cells["A1"].LoadFromCollection(t,true,OfficeOpenXml.Table.TableStyles.Light10);

            return excel.GetAsByteArray();
        }
    }
}
