using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyHW.Models
{
    public class Students
    {
        [Key]
        [Column("stud_id")]
        public int StudId { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        //[Display(Name = "Last Name")]
        [Column("last_name")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "First name is required")]
        //[Display(Name = "First Name")]
        [Column("first_name")]
        public string FirstName { get; set; } = null!;

        [Column("middle_name")]
        public string? MiddleName { get; set; }

        [Column("birth_date")]
        public DateOnly BirthDate { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }

        [Column("photo")]
        public byte[]? Photo { get; set; }

        [Column("group")]
        public int? Group { get; set; }
    }
}
