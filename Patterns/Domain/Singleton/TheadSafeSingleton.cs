namespace Domain.Singleton
{
    using System.Diagnostics.CodeAnalysis;

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

            [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1409:RemoveUnnecessaryCode", Justification = "Reviewed. Suppression is OK here.")]
            static Nested()
            {
            }
        }
    }
}