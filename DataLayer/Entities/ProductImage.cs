using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class ProductImage
    {
        [Key]
        public int ProductImageId { get; set; }

        public string Caption { get; set; }

        public string ImagePath { get; set; }

        // using image path method to wwwroot instead
        //public byte[] Image { get; set; }

        public virtual List<Product> Product { get; set; }
    }
}
