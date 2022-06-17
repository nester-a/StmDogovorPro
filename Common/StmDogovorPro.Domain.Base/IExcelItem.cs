using StmDogovorPro.Domain.Base.ExcellBase;

namespace StmDogovorPro.Domain.Base
{
    public interface IExcelItem : INamedItem
    {
        decimal CostWithTaxes { get; set; }
        decimal SaleCost { get; set;}
        IAnnualVolume AnnualVolume { get; set; }
        IFirstBatch FirstBatch { get; set; }
        IRCElement RC { get; set; }
    }
}
