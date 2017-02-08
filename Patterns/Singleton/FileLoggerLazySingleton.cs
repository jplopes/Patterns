namespace Singleton
{
    using System.IO;

    public class FileLoggerLazySingleton : IFileLogger
    {
        private const string FilePath = @"c:\logfile.txt";

        private readonly TextWriter logfile;

        private FileLoggerLazySingleton()
        {
            this.logfile = this.GetFileStream();
        }

        public static FileLoggerLazySingleton Instance
        {
            get
            {
                return Nested.TheInstance;
            }
        }

        public void WriteLineToFile(string value)
        {
            this.logfile.WriteLine(value);
        }

        public void CloseFile()
        {
            this.logfile.Close();
        }

        private TextWriter GetFileStream()
        {
            return TextWriter.Synchronized(File.AppendText(FilePath));
        }

        private class Nested
        {
            internal static readonly FileLoggerLazySingleton TheInstance = new FileLoggerLazySingleton();

            static Nested()
            {
            }
        }
    }
}