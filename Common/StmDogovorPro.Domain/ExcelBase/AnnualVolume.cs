using StmDogovorPro.Domain.Base.ExcelBase;

namespace StmDogovorPro.Domain.ExcelBase
{
    public class AnnualVolume : IAnnualVolume
    {
        public int RRC { get; set; }
        public int TD { get; set; }
        public decimal FK { get; set; }
        public decimal? NAS { get; set; }
        public decimal SGA { get; set; }
        public decimal HF { get; set; }
        public decimal Total { get; set; }
    }
}
