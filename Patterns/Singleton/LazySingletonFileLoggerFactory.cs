namespace Singleton
{
    public class LazySingletonFileLoggerFactory : IFileLoggerFactory
    {
        public IFileLogger Create()
        {
            return FileLoggerLazySingleton.Instance;
        }
    }
}