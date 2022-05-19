using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Computer : Product
    {
        [MaxLength(35)]
        [Required]
        public string Manufacturer { get; set; }

        [MaxLength(20)]
        public string CPU { get; set; }

        [MaxLength(20)]
        public string Ram { get; set; }

        [MaxLength(20)]
        public string Storage { get; set; }

        [MaxLength(35)]
        public string Name { get; set; }

        [MaxLength(20)]
        public Colour Colour { get; set; }

        [MaxLength(20)]
        public string OS { get; set; }

        [MaxLength(20)]
        public string GPU { get; set; }

        [MaxLength(20)]
        public string PSU { get; set; }

        public bool WiFi { get; set; }
    }
}