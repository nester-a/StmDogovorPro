namespace StmDogovorPro.Services.Base
{
    public interface IReader
    {
        ICollection<string> Read(string path);
    }
}
