using EducationalLesson.Entities;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Emit;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace EducationalLesson.Context
{
    public class EducationalLessonContext : DbContext
    {
        public EducationalLessonContext(DbContextOptions<EducationalLessonContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    ((BaseEntity)entry.Entity).DateCreated = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                    ((BaseEntity)entry.Entity).LastModified = DateTime.Now;
            }

            foreach (var entry in ChangeTracker.Entries().Where(e => e.Entity is ISoftDeletable && e.State == EntityState.Deleted))
            {
                entry.State = EntityState.Modified;
                entry.CurrentValues["IsDeleted"] = true;
            }
            return base.SaveChanges();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Flag> Flags { get; set; }
        public DbSet<QuestionReport> QuestionReports { get; set; }
        public DbSet<QuestionReportFlag> QuestionReportFlags { get; set; }
        public DbSet<SubjectQuestion> SubjectQuestions { get; set; }
        public DbSet<CommentReport> CommentReports { get; set; }
        public DbSet<CommentReportFlag> CommentReportFlags { get; set; }
    }
}
