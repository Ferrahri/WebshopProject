using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Dto
{
    public class ProductImageDto
    {
        public int ProductImageId { get; set; }

        public string Caption { get; set; }

        // using image path method to wwwroot instead
        //public byte[] Image { get; set; }
        public string ImagePath { get; set; }   
    }
}
