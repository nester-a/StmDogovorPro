using StmDogovorPro.Domain.Base;
using StmDogovorPro.Domain.Base.ExcelBase;

namespace StmDogovorPro.Domain
{
    public class ExcelItem : IExcelItem
    {
        public decimal CostWithTaxes { get; set; }
        public decimal SaleCost { get; set; }
        public IAnnualVolume AnnualVolume { get; set; }
        public IFirstBatch FirstBatch { get; set; }
        public IRCElement RC { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
