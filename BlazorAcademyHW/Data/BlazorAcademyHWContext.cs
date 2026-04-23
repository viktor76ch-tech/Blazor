using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorAcademyHW.Models;

namespace BlazorAcademyHW.Data
{
    public class BlazorAcademyHWContext : DbContext
    {
        public BlazorAcademyHWContext (DbContextOptions<BlazorAcademyHWContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorAcademyHW.Models.Student> Student { get; set; } = default!;
        public DbSet<BlazorAcademyHW.Models.Group> Group { get; set; } = default!;
        public DbSet<BlazorAcademyHW.Models.Direction> Direction { get; set; } = default!;
        public DbSet<BlazorAcademyHW.Models.Discipline> Discipline { get; set; } = default!;
        public DbSet<BlazorAcademyHW.Models.Teacher> Teacher { get; set; } = default!;
    }
}
