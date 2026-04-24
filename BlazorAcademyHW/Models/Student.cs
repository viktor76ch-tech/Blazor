using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyHW.Models;

public partial class Student
{
    [Key]
    [Column("stud_id")]
    public int StudId { get; set; }

    [Column("last_name")]
    public string LastName { get; set; } = null!;

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

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual Group? GroupNavigation { get; set; }
}
