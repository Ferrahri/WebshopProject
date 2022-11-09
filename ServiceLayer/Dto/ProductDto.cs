using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductType { get; set; }
        public string Category { get; set; }
        public string BrandName { get; set; }
        public string ProductImagePath { get; set; }
        public string CountryName { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
    }
}
