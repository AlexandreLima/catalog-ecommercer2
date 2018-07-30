using AutoMapper;
using Ecommercer.Catalog.Application.Commands.Products;
using Ecommercer.Catalog.Domain.Produtcs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommercer.Catalog.Mapping
{
    public class CommandToDomainMapping : Profile
    {
        public CommandToDomainMapping()
        {
            CreateMap<AddProductCommand, Product>();
        }
    }
}
