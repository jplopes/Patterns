﻿namespace Decorator
{
    using System.Collections.Generic;

    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }
}