using Ecommercer.Catalog.Domain.Produtcs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommercer.Catalog.EntityFramework.Repositories.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly CatalogContext context;
        public ProductRepository(CatalogContext context)
            => this.context = context;

        public async Task Add(Domain.Produtcs.Product product)
        {
            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();
        }
    }
}
