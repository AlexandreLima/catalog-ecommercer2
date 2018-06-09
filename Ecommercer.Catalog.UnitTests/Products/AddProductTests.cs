using Ecommercer.Catalog.Application.Commands.Products;
using Ecommercer.Catalog.Domain.Produtcs;
using Moq;
using System;
using Xunit;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;

namespace Ecommercer.Catalog.Products.UnitTests
{
    public class AddProductTests
    {
        Mock<IProductRepository> mock;
        AddProductCommandHandler addProductCommand;

        public AddProductTests()
        {
            mock = new Mock<IProductRepository>();
        }

        [Fact]
        public void Add_Products_With_Success()
        {
            var container = new Container(cfg =>
            {

                cfg.Scan(scanner =>
                {
                    scanner.AssemblyContainingType(typeof(AddProductCommandHandler));
                    scanner.IncludeNamespaceContainingType<AddProductCommandHandler>();
                    scanner.WithDefaultConventions();
                    scanner.AddAllTypesOf(typeof(IRequestHandler<,>));
                });

                cfg.For<ServiceFactory>().Use<ServiceFactory>(ctx => t => ctx.GetInstance(t));
                cfg.For<IMediator>().Use<Mediator>();
                cfg.For<IProductRepository>().Use(x => mock.Object);
            });

            mock.Setup(x => x.Add(It.IsAny<Product>())).Verifiable();

            var mediator = container.GetInstance<IMediator>();

            mediator.Send(new AddProductCommand
            {
                Code = 1,
                CreatedAt = DateTime.Now,
                Name = "Product 1"
            });
        }
    }
}
