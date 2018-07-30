﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommercer.Catalog.Application.Commands.Products.Dto
{
    public class ImageDto
    {
        public string ThumbnailImage { get; set; }
        public string MediumImage { get; set; }
        public string LargeImage { get; set; }
        public string EntityType { get; set; }
    }
}
