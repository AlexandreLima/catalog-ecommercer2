using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommercer.Catalog.Application.Commands.Products.Dto
{
    public class GiftOptionsDto
    {
        public bool AllowGiftWrap { get; set; }
        public bool AllowGiftMessage { get; set; }
        public bool AllowGiftReceipt { get; set; }
    }
}
