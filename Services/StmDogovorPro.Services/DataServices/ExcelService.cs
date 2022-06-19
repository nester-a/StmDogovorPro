using StmDogovorPro.Domain;
using StmDogovorPro.Domain.Base;
using StmDogovorPro.Domain.ExcelBase;
using StmDogovorPro.Services.Base;

namespace StmDogovorPro.Services.DataServices
{
    public class ExcelService : IExcelService
    {
        private readonly IFileFinder _fileFinder;
        private readonly IReader _reader;

        public ExcelService(IFileFinder fileFinder, IReader reader)
        {
            _fileFinder = fileFinder;
            _reader = reader;
        }

        public ICollection<IExcelItem> GetData()
        {
            ICollection<IExcelItem> result = new List<IExcelItem>();
            if (!_fileFinder.Exist) return result;
            var stringsCol = _reader.Read(_fileFinder.Path);

            ExcelDataTransformator transformator = new ExcelDataTransformator();
            for (int i = 2; i < stringsCol.Count(); i++)
            {
                var valuesString = stringsCol.ToList()[i];
                var excelItem = transformator.Transform(valuesString);
                excelItem.Id = i - 1;
                result.Add(excelItem);
            }

            return result;
        }
    }
}
