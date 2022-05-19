using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Mice : Product
    {
        [MaxLength(35)]
        [Required]
        public string Manufacturer { get; set; }

        [MaxLength(20)]
        public Colour Colour { get; set; }

        [MaxLength(35)]
        public string Name { get; set; }

        public bool Wireless { get; set; }

        [Range(1, 1000000)]
        public int DPI { get; set; }

        public Handedness Handy { get; set; }
    }
}