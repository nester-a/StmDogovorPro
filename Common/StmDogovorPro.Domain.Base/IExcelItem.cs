using StmDogovorPro.Domain.Base.ExcellBase;

namespace StmDogovorPro.Domain.Base
{
    public interface IExcelItem : INamedItem
    {
        IAnnualVolume AnnualVolume { get; set; }
        IFirstBatch FirstBatch { get; set; }
        IRCElement RC { get; set; }
    }
}
