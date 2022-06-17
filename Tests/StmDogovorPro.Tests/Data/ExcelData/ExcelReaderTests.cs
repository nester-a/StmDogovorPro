using StmDogovorPro.ExcelData;
using System;
using System.IO;
using Xunit;

namespace StmDogovorPro.Tests.Data.ExcelData
{
    public class ExcelReaderTests
    {
        ExcelReader excel = new ExcelReader();

        [Fact]
        public void ReadTest()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            var excelPath = "excelTest.xlsx";

            var testPath = Path.Combine(path, excelPath);
            bool catched = false;
            try
            {
                excel.TestRead();
            }
            catch (NotImplementedException e)
            {
                catched = true;
                Assert.True(e is NotImplementedException);
            }
            Assert.True(catched);
        }
    }
}
