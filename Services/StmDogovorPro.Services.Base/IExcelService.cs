using StmDogovorPro.Domain.Base;

namespace StmDogovorPro.Services.Base
{
    public interface IExcelService
    {
        ICollection<IExcelItem> GetData();
    }
}
