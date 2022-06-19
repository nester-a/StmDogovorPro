using StmDogovorPro.Services.Base;

namespace StmDogovorPro.FileData
{
    public class FileFinder : IFileFinder
    {
        public string Path { get; set; } = string.Empty;
        public bool Exist { get; set; } = false;

        public void Find()
        {
            FileInfo fileInfo = new FileInfo(Path);
            if (fileInfo.Exists)
            {
                Exist = true;
            }
        }
    }
}
