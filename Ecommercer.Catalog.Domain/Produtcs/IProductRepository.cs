using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommercer.Catalog.Domain.Produtcs
{
    public interface IProductRepository
    {
        Task Add(Product product);
    }
}
