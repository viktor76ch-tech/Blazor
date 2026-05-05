using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BlazorAcademyHW.Models
{
    public class Teachers
    {
        [Key]
        [Column("teacher_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short TeacherId { get; set; }

        [Column("last_name")]
        public string? LastName { get; set; }

        [Column("first_name")]
        public string? FirstName { get; set; }

        [Column("middle_name")]
        public string? MiddleName { get; set; }

        [Column("birth_date")]
        public DateOnly? BirthDate { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }

        [Column("photo")]
        public byte[]? Photo { get; set; }

        [Column("work_since")]
        public DateOnly? WorkSince { get; set; }

        [Column("rate")]
        public decimal? Rate { get; set; }

        [JsonIgnore]
        public ICollection<TeachersDisciplines>? TeacherDisciplines { get; set; }
    }
}