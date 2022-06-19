namespace StmDogovorPro.Services.Base
{
    public interface IFileFinder
    {
        string Path { get; set; }
        bool Exist { get; set; }
        void Find();
    }
}
