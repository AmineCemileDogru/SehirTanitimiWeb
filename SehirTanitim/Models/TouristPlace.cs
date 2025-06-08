using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SehirTanitim.Models
{
    [Table("TouristPlaces")]
    public class TouristPlace
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [MaxLength(255)]
        public string ImageUrl { get; set; }
    }
}
