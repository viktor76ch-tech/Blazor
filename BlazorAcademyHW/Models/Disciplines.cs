using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyHW.Models
{
    public class Disciplines
    {
        [Key]
        [Column("discipline_id")]
        public short DisciplineId { get; set; }

        [Column("discipline_name")]
        public string? DisciplineName { get; set; }

        [Column("number_of_lessons")]
        public byte NumberOfLessons { get; set; }
        [NotMapped]
        public int NumberOfLessonsInput
        {
            get => NumberOfLessons;
            set => NumberOfLessons = (byte)Math.Clamp(value, 0, 255);
        }
    }
}
