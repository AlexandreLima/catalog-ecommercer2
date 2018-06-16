using Ecommercer.Catalog.Domain.Produtcs;
using Microsoft.EntityFrameworkCore;

namespace Ecommercer.Catalog.EntityFramework
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

         
    }
}