using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EducationalLesson.Entities;

namespace EducationalLesson.Context.EntityTypeConfiguration
{
    public class StudentEntityTypeConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.StudentName)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(u => u.Email)
                .IsRequired();

            builder.Property(u => u.RoleId)
                .IsRequired();

            builder.HasOne(u => u.Role)
                .WithMany(r => r.Students)
                .HasForeignKey(u => u.RoleId);
        }
    }
}
