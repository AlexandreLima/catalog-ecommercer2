using Ecommercer.Catalog.Application.Commands.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommercer.Catalog.Application.Commands.Products
{
    public class AddProductCommand : Command
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Name { get; set; }

        public int Code { get; set; }
    }
}
