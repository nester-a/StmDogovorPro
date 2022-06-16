namespace StmDogovorPro.Domain.Base
{
    public interface INamedItem : IItem
    {
        string Name { get; set; }
    }
}
