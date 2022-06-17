namespace StmDogovorPro.Domain.Base
{
    public interface IWordItem : INamedItem
    {
        int Packing { get; set; }
        decimal UnitCost { get; set; }
        int VolumeForPeriod { get; set; }
        int FirstBatchVolume { get; set; }
    }
}
