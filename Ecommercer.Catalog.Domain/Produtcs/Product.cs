using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommercer.Catalog.Domain.Produtcs
{
    public class Product
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Name { get; set; }

        public int Code { get; set; }
    }
}
