namespace Decorator
{
    using System.Collections.Generic;

    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>();
        }
    }
}