using Microsoft.EntityFrameworkCore;
using BlazorAcademyHW.Models;

namespace BlazorAcademyHW.Data
{
    public partial class BlazorAcademyHWContext : DbContext
    {
        public BlazorAcademyHWContext(DbContextOptions<BlazorAcademyHWContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Teachers> Teachers { get; set; } = null!;
        public virtual DbSet<Students> Students { get; set; } = null!;
        public virtual DbSet<Groups> Groups { get; set; } = null!;
        public virtual DbSet<Directions> Directions { get; set; } = null!;
        public virtual DbSet<Disciplines> Disciplines { get; set; } = null!;
        public virtual DbSet<GroupScheduleDays> GroupScheduleDays { get; set; } = null!;

        public virtual DbSet<TeachersDisciplines> TeachersDisciplines { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GroupScheduleDays>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.DayOfWeek });

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ScheduleDays)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<TeachersDisciplines>(entity =>
                {
                    entity.HasKey(e => new { e.TeacherId, e.DisciplineId });

                    entity.HasOne(d => d.Teacher)
                        .WithMany(p => p.TeacherDisciplines)
                        .HasForeignKey(d => d.TeacherId);

                    entity.HasOne(d => d.Discipline)
                        .WithMany(p => p.TeacherDisciplines)
                        .HasForeignKey(d => d.DisciplineId);
                });
            }
    }
}