using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SehirTanitim.Models
{
    [Table("SliderImages")]
    public class SliderImage
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string ImageUrl { get; set; }
    }
}
