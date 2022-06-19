namespace StmDogovorPro.Services.Base
{
    public interface ITableDataTransformator<T>
    {
        T Transform(string data);
    }
}
