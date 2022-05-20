using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Mousemat : Product
    {
        [MaxLength(35)]
        [Required]
        public string? Manufacturer { get; set; }

        [MaxLength(20)]
        public Colour Colour { get; set; }

        [MaxLength(35)]
        public string? Name { get; set; }

        public Size Size { get; set; }
    }
}