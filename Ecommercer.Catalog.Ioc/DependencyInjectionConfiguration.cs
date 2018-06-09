using Ecommercer.Catalog.Application.Commands.Products;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommercer.Catalog.Ioc
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependecyInjection(this IServiceCollection services)
        {
            services.AddMediatR(typeof(AddProductCommandHandler).Assembly);

            services.AddScoped<IMediator, Mediator>();
        }
    }
}
