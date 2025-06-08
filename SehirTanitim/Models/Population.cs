using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SehirTanitim.Models
{
    [Table("Population")]
    public class Population
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int PopulationCount { get; set; }
    }
}
