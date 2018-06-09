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
        public AddProductCommandHandler(IProductRepository productRepository)
            => this.productRepository = productRepository;

        protected override async Task Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.CreatedAt, request.Name, request.Code);

            await productRepository.Add(product);
        }
    }
}
