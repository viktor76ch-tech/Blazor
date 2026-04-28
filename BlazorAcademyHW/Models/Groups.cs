using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyHW.Models
{
    public class Groups
    {
        [Key]
        [Column("group_id")]
        public int GroupId { get; set; }

        [Column("group_name")]
        public string? GroupName { get; set; }

        [Column("direction")]
        public byte? Direction { get; set; }

        [NotMapped]
        public int DirectionInput
        {
            get => (int)Direction;
            set => Direction = (byte)Math.Clamp(value, 0, 255);
        }

        [ForeignKey(nameof(Direction))]
        public Directions? DirectionNavigation { get; set; }
    }
}
