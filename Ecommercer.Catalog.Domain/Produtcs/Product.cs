using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommercer.Catalog.Domain.Produtcs
{
    public class Product
    {
        public Product(DateTime createdAt, string name, int code)
        {
            CreatedAt = createdAt;
            Name = name;
            Code = code;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public string Name { get; private set; }

        public int Code { get; private set; }
    }
}
