using System.ComponentModel.DataAnnotations;

namespace BlazorWebApp.Models
{
    public class ValidationForm
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        public float Price { get; set; }
    }
}
