using Ecommercer.Catalog.Domain.Produtcs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ecommercer.Catalog.EntityFramework.Repositories.Products
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                    .ValueGeneratedNever();

            builder.Property(p => p.Name)
                    .IsRequired()
                    .HasMaxLength(100);
        }
    }
}
