namespace Domain.Singleton
{
    public class ThreadSafeSingleton
    {
        private ThreadSafeSingleton()
        {
        }

        public static ThreadSafeSingleton Instance
        {
            get
            {
                return Nested.Instance;
            }
        }

        private class Nested
        {
            internal static readonly ThreadSafeSingleton Instance = new ThreadSafeSingleton();

            static Nested()
            {
            }
        }
    }
}