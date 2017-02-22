namespace Singleton
{
    using Microsoft.Practices.Unity;

    public static class IoC
    {
        private static IUnityContainer container;

        public static void Initialize(IUnityContainer container)
        {
            IoC.container = container;
        }

        public static TBase Resolve<TBase>()
        {
            return container.Resolve<TBase>();
        }
    }
}