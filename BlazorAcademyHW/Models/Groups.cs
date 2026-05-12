using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyHW.Models
{
    public class Groups
    {
        [Key]
        [Column("group_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GroupId { get; set; }

        [Column("group_name")]
        public string? GroupName { get; set; }

        [Column("direction")]
        public byte? Direction { get; set; }

        [ForeignKey(nameof(Direction))]
        public virtual Directions? DirectionNM { get; set; }

        public ICollection<GroupScheduleDays>? ScheduleDays { get; set; }
    }
}