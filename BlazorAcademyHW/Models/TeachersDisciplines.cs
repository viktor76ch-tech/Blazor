using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BlazorAcademyHW.Models
{
    public class TeachersDisciplines
    {
        [Column("teacher_id")]
        public short TeacherId { get; set; }

        [Column("discipline_id")]
        public short DisciplineId { get; set; }

        [JsonIgnore]
        [ForeignKey("TeacherId")]
        public Teachers? Teacher { get; set; }

        [JsonIgnore]
        [ForeignKey("DisciplineId")]
        public Disciplines? Discipline { get; set; }
    }
}