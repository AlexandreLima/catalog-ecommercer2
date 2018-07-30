using Ecommercer.Catalog.Application.Commands.Products;
using Ecommercer.Catalog.Domain.Produtcs;
using Moq;
using System;
using Xunit;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;
using AutoMapper;
using Ecommercer.Catalog.Mapping;

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
        public async void Add_Products_With_Success()
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

                var config = new AutoMapper.MapperConfiguration(configuration =>
                {
                    configuration.AddProfile(new CommandToDomainMapping());
                });


                cfg.For<IMapper>().Use(() => config.CreateMapper());
            });

            mock.Setup(x => x.Add(It.IsAny<Product>())).Verifiable();

            var mediator = container.GetInstance<IMediator>();

           

            await mediator.Send(new AddProductCommand
            {
               
            });
        }
    }
}
