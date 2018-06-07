using Ecommercer.Catalog.Application.Commands.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ecommercer.Catalog.Application.Commands.Products
{
    public class AddProductCommandHandler : CommandHandler<AddProductCommand>
    {
        protected override Task Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
