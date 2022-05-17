using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public abstract class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Title { get; set; }

        [MaxLength(350)]
        public string SubTitle{ get; set; }

        [Range(0,5)]
        public int Rating { get; set; }

        public string Image { get; set; }
    }
}
