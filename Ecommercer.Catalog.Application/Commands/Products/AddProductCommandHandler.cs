using AutoMapper;
using Ecommercer.Catalog.Application.Commands.Base;
using Ecommercer.Catalog.Domain.Produtcs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ecommercer.Catalog.Application.Commands.Products
{
    public class AddProductCommandHandler : CommandHandlerBase<AddProductCommand>
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public AddProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        protected override async Task Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = mapper.Map<Product>(request);
            await productRepository.Add(product);
        }
    }
}
