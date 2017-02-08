namespace Singleton
{
    public interface IFileLogger
    {
        void WriteLineToFile(string value);

        void CloseFile();
    }
}