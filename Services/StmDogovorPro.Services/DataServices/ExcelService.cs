using StmDogovorPro.Domain.Base;
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
            var strings = _reader.Read(_fileFinder.Path);

            // todo разбиваем на массив

            return default;
        }
    }
}
