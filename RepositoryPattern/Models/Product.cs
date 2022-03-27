﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string PictureUrl { get; set; } = string.Empty;
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public ProductBrands ProductBrand { get; set; }
        public int ProductBrandId { get; set; }
    }
}