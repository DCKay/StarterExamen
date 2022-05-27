using System.ComponentModel.DataAnnotations;

namespace Project1.Models.Items
{
    public class Screen : Product
    {
        [MaxLength(35)]
        [Required]
        public string? Manufacturer { get; set; }

        [MaxLength(20)]
        public Colour Colour { get; set; }

        [MaxLength(35)]
        public string? Name { get; set; }

        public string? Resolution { get; set; }

        [Range(1, 400)]
        public int FPS { get; set; }
    }
}