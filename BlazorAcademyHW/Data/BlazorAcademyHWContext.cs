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

        public DbSet<BlazorAcademyHW.Models.Students> Students { get; set; } = default!;
        public DbSet<BlazorAcademyHW.Models.Teachers> Teachers { get; set; } = default!;
        public DbSet<BlazorAcademyHW.Models.Groups> Groups { get; set; } = default!;
        public DbSet<BlazorAcademyHW.Models.Disciplines> Disciplines { get; set; } = default!;
        public DbSet<BlazorAcademyHW.Models.Directions> Directions { get; set; } = default!;
    }
}
