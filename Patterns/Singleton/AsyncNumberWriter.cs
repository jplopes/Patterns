namespace Singleton
{
    using System;
    using System.Threading.Tasks;

    public class AsyncNumberWriter : INumberWriter
    {
        private readonly IFileLoggerFactory fileLoggerFactory;

        public AsyncNumberWriter(IFileLoggerFactory fileLoggerFactory)
        {
            this.fileLoggerFactory = fileLoggerFactory;
        }

        public void WriteNumbersToFile(int max)
        {
            IFileLogger myLogger = null;
            Action<int> logToFile = i =>
                {
                    myLogger = this.fileLoggerFactory.Create();
                    myLogger.WriteLineToFile("Ready for next number...");
                    myLogger.WriteLineToFile("Logged number: " + i);
                };
            Parallel.For(0, max, logToFile);
            myLogger.CloseFile();
        }
    }
}