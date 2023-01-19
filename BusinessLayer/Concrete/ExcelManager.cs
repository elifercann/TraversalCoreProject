using BusinessLayer.Abstract;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExcelManager : IExcelService
    {
        public byte[] ExcelList<T>(List<T> entity) where T : class
        {
            ExcelPackage excelPackage = new ExcelPackage();
            var workSheet = excelPackage.Workbook.Worksheets.Add("Statik1");
            workSheet.Cells["A1"].LoadFromCollection(entity,true, OfficeOpenXml.Table.TableStyles.Light10);
            return excelPackage.GetAsByteArray();
        }
    }
}
