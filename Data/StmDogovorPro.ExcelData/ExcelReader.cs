using System.Text;
using ExcelDataReader;
using StmDogovorPro.Services.Base;

namespace StmDogovorPro.ExcelData
{
    public class ExcelReader : IReader
    {
        static CodePagesEncodingProvider code;
        public ICollection<string> Read(string path)
        {

            return default;
        }

        public void TestRead()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            var excelPath = "excelTest.xlsx";

            var testPath = Path.Combine(path, excelPath);

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (var file = File.Open(testPath, FileMode.Open))
            {
                using (var app = ExcelReaderFactory.CreateReader(file))
                {
                    var result = app.AsDataSet();
                    var reader = result.CreateDataReader();
                    while (reader.Read())
                    {
                        //нужно как-то прочесть фаил
                        var one = reader.GetString(0);
                    }

                }
            }
            
        }
    }
}
