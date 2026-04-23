using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models;

public partial class Exam
{
    [Key]
    public int ExamId { get; set; }
    public int Student { get; set; }

    public short Discipline { get; set; }

    public DateOnly? Date { get; set; }

    public byte? Grade { get; set; }

    public virtual Discipline DisciplineNavigation { get; set; } = null!;

    public virtual Student StudentNavigation { get; set; } = null!;
}
