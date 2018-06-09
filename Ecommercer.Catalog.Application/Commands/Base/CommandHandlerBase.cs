using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ecommercer.Catalog.Application.Commands.Base
{
    public abstract class CommandHandlerBase<T> : AsyncRequestHandler<T> where T : CommandBase
    {

    }
}
