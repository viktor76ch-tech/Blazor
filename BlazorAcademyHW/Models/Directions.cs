using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyHW.Models
{
    public class Directions
    {
        [Key]
        [Column("direction_id")]
        public byte DirectionId { get; set; }

        [Column("direction_name")]
        public string? DirectionName { get; set; }
    }
}
