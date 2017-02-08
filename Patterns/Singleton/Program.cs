namespace Singleton
{
    using System;

    using Microsoft.Practices.Unity;

    internal class Program
    {
        private static UnityDependencyResolver dependencyResolver;

        private static INumberWriter numberWriter;

        public static void Main(string[] args)
        {
            RegisterTypes();
            numberWriter = dependencyResolver.Container.Resolve<INumberWriter>();
            numberWriter.WriteNumbersToFile(100);
            Console.WriteLine("File write done.");
            Console.ReadLine();
        }

        private static void RegisterTypes()
        {
            dependencyResolver = new UnityDependencyResolver();
            dependencyResolver.EnsureDependenciesRegistered();
            dependencyResolver.Container.RegisterType<INumberWriter, AsyncNumberWriter>();
        }
    }
}