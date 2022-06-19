using StmDogovorPro.ExcelData;
using StmDogovorPro.FileData;
using StmDogovorPro.Services.Base;
using StmDogovorPro.Services.DataServices;
using System;
using System.IO;
using Xunit;

namespace StmDogovorPro.Tests.Services.DataServices
{
    public class ExcelServiceTests
    {
        [Fact]
        public void GetDataTest()
        {
            IReader reader = new ExcelReader();
            IFileFinder fileFinder = new FileFinder();

            var path = AppDomain.CurrentDomain.BaseDirectory;
            var excelPath = "excelTest.xlsx";
            var testPath = Path.Combine(path, excelPath);

            fileFinder.Path = testPath;
            fileFinder.Find();

            IExcelService service = new ExcelService(fileFinder, reader);
            var data = service.GetData();
        }
    }
}
