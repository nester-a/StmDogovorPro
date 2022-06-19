using StmDogovorPro.Domain.Base.ExcelBase;

namespace StmDogovorPro.Domain.ExcelBase
{
    public class AnnualVolume : IAnnualVolume
    {
        public double TD { get; set; }
        public double FK { get; set; }
        public double NAS { get; set; }
        public double SGA { get; set; }
        public double HF { get; set; }
        public double Total { get; set; }
    }
}
