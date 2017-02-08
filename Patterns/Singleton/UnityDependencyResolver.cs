namespace Singleton
{
    using Microsoft.Practices.Unity;

    public class UnityDependencyResolver
    {
        private static readonly IUnityContainer TheContainer;

        static UnityDependencyResolver()
        {
            TheContainer = new UnityContainer();
            IoC.Initialize(TheContainer);
        }

        public IUnityContainer Container
        {
            get
            {
                return TheContainer;
            }
        }

        public void EnsureDependenciesRegistered()
        {
            TheContainer.RegisterType<IFileLoggerFactory, LazySingletonFileLoggerFactory>();
        }
    }
}