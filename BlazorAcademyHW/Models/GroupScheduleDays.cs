using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyHW.Models
{
    public class GroupScheduleDays
    {
        [Column("group_id")]
        public int GroupId { get; set; }

        [Column("day_of_week")]
        public byte DayOfWeek { get; set; } // 1 = Mon, 2 = Tue, ...

        [ForeignKey("GroupId")]
        public Groups? Group { get; set; }
    }
}
