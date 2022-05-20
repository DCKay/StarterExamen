using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Keyboard : Product
    {
        [MaxLength(35)]
        [Required]
        public string? Manufacturer { get; set; }

        [MaxLength(20)]
        public Colour Colour { get; set; }

        [MaxLength(35)]
        public string? Name { get; set; }

        public bool HasRGB { get; set; }

        public Layout Layout { get; set; }

        public string? Switches { get; set; }

        public bool Wireless { get; set; }

        public string? Size { get; set; }
    }
}