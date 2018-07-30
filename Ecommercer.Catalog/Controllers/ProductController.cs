using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommercer.Catalog.Application.Commands.Products;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommercer.Catalog.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Product")]
    public class ProductController : Controller
    {
        private readonly IMediator mediator;
        public ProductController(IMediator mediator)
            => this.mediator = mediator;

        public async Task<StatusCodeResult> Post([FromBody]AddProductCommand addProductCommand)
        {
            await mediator.Send(addProductCommand);

            return new StatusCodeResult(201);
        }
        
    }
}