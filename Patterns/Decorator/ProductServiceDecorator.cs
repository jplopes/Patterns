namespace Decorator
{
    using System.Collections.Generic;

    public class ProductServiceDecorator : IProductService
    {
        private readonly IProductService productService;

        public ProductServiceDecorator(IProductService productService)
        {
            this.productService = productService;
        }

        public IProductService ProductService
        {
            get
            {
                return this.productService;
            }
        }

        public virtual IEnumerable<Product> GetProducts()
        {
            return this.productService.GetProducts();
        }
    }
}