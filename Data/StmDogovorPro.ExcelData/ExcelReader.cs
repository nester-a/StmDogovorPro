using System.Text;
using ExcelDataReader;
using StmDogovorPro.Services.Base;

namespace StmDogovorPro.ExcelData
{
    public class ExcelReader : IReader
    {
        public ICollection<string> Read(string path)
        {
            StringBuilder sb = new StringBuilder();
            ICollection<string> col = new List<string>();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (var file = File.Open(path, FileMode.Open))
            {
                using (var app = ExcelReaderFactory.CreateReader(file))
                {
                    var result = app.AsDataSet();
                    var reader = result.CreateDataReader();

                    //читаем колонку
                    while (reader.Read())
                    {
                        for (int column = 0; column < reader.FieldCount; column++)
                        {
                            //читаем строку
                            var value = reader.GetValue(column);
                            sb.Append(value.ToString() + ";");
                        }
                        col.Add(sb.ToString());
                        sb.Clear();
                    }
                }
            }
            return col;
        }
    }
}
