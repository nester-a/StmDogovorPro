using StmDogovorPro.FileData;
using StmDogovorPro.Services.Base;
using System;
using System.IO;
using Xunit;
namespace StmDogovorPro.Tests.Data.FileData
{
    public class FileFinderTests
    {
        [Fact]
        public void FindTest()
        {
            IFileFinder fileFinder = new FileFinder();

            var path = AppDomain.CurrentDomain.BaseDirectory;
            var excelPath = "excelTest.xlsx";
            var testPath = Path.Combine(path, excelPath);

            fileFinder.Path = testPath;

            fileFinder.Find();

            Assert.True(fileFinder.Exist);
        }

        [Fact]
        public void FindTest_Exist_is_False()
        {
            IFileFinder fileFinder = new FileFinder();

            var path = AppDomain.CurrentDomain.BaseDirectory;
            var excelPath = "hello.xlsx";
            var testPath = Path.Combine(path, excelPath);

            fileFinder.Path = testPath;

            fileFinder.Find();

            Assert.False(fileFinder.Exist);
        }
    }
}
