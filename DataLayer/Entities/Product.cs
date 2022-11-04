using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        [ForeignKey("ProductImage")]
        public int ProductImageId { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }


        public string Name { get; set; }
        public float Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsComplete { get; set; }

        public ProductImage ProductImages { get; set; }
        public Country Country { get; set; }
        public ProductType ProductType { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }
    }
}
