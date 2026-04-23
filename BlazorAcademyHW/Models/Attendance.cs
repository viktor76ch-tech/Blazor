using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models;

public partial class Attendance
{
    [Key]
    public int AttendanceId { get; set; }
    public int Student { get; set; }

    public long Lesson { get; set; }

    public bool Present { get; set; }

    public virtual Schedule LessonNavigation { get; set; } = null!;

    public virtual Student StudentNavigation { get; set; } = null!;
}
