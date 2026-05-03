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

        [NotMapped]
        public int DirectionInput
        {
            get => Direction ?? 0;
            set => Direction = (byte)Math.Clamp(value, 0, 255);
        }

        [ForeignKey(nameof(Direction))]
        public Directions? DirectionNavigation { get; set; }

        public ICollection<GroupScheduleDays>? ScheduleDays { get; set; }
    }
}