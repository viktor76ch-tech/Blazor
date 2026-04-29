using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyHW.Models
{
    public class TeachersDisciplines
    {
        [Column("teacher_id")]
        public short TeacherId { get; set; }

        [Column("discipline_id")]
        public short DisciplineId { get; set; }

        [ForeignKey("TeacherId")]
        public Teachers? Teacher { get; set; }

        [ForeignKey("DisciplineId")]
        public Disciplines? Discipline { get; set; }
    }
}