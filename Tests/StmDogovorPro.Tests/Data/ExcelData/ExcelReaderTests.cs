using StmDogovorPro.ExcelData;
using System;
using System.Collections.Generic;
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

            ICollection<string> result = new List<string>();
            try
            {
                result = excel.Read(testPath);
            }
            catch
            {
                catched = true;
            }
            Assert.False(catched);
            Assert.True(result.Count == 3);
        }
    }
}
