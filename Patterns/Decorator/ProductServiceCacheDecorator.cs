namespace Decorator
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Caching;

    public class ProductServiceCacheDecorator : ProductServiceDecorator
    {
        public ProductServiceCacheDecorator(IProductService productService)
            : base(productService)
        {
        }

        public override IEnumerable<Product> GetProducts()
        {
            ObjectCache cache = MemoryCache.Default;
            string key = "products";
            if (cache.Contains(key))
            {
                return (IEnumerable<Product>)cache[key];
            }
            else
            {
                IEnumerable<Product> products = this.ProductService.GetProducts();
                CacheItemPolicy policy = new CacheItemPolicy
                {
                    AbsoluteExpiration = new DateTimeOffset(DateTime.Now.AddMinutes(1))
                };
                cache.Add(key, products, policy);
                return products;
            }
        }
    }
}