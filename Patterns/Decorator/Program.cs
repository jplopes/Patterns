namespace Decorator
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static void Main(string[] args)
        {
            // Before decoration
            // Beach beach = new Beach();

            // Console.WriteLine(beach.Description);
            // Console.WriteLine("Price: {0}", beach.Price);
            // Console.ReadKey();

            // After decoration
            Vacation beach = new Beach();
            beach = new PrivatePool(beach);
            beach = new AllInclusive(beach);
            beach = new Massage(beach);

            Console.WriteLine(beach.Description);
            Console.WriteLine("Price: {0}", beach.Price);
            Console.ReadKey();

            // IProductService productService = new ProductService();
            // IEnumerable<Product> products = productService.GetProducts();
            // Console.ReadKey();
            IProductService productService = new ProductService();
            productService = new ProductServiceCacheDecorator(productService);
            IEnumerable<Product> products = productService.GetProducts();
            Console.ReadKey();
        }
    }
}