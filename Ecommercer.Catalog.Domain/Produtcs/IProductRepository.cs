using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommercer.Catalog.Domain.Produtcs
{
    public interface IProductRepository
    {
        void Add(Product product);
    }
}
