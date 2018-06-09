using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommercer.Catalog.Application.Commands.Base
{
    public abstract class CommandBase : IRequest
    {
        public CommandBase()
        {
            this.Key = Guid.NewGuid();
            this.InitAt = DateTime.Now;
        }
        public Guid Key { get; private set; }
        public DateTime InitAt { get; private set; }
    }
}
