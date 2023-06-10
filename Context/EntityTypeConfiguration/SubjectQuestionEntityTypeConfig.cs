using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EducationalLesson.Entities;

namespace EducationalLesson.Context.EntityTypeConfiguration
{
    public class SubjectQuestionEntityTypeConfiguration : IEntityTypeConfiguration<SubjectQuestion>
    {
        public void Configure(EntityTypeBuilder<SubjectQuestion> builder)
        {
            builder.ToTable("SubjectQuestion");
            builder.Ignore(cq => cq.Id);
            builder.HasKey(cq => new { cq.SubjectId, cq.QuestionId });

            builder.HasOne(cq => cq.Subject)
                .WithMany(c => c.SubjectQuestions)
                .HasForeignKey(cq => cq.SubjectId)
                .IsRequired();

            builder.HasOne(cq => cq.Question)
                .WithMany(q => q.SubjectQuestions)
                .HasForeignKey(cq => cq.QuestionId)
                .IsRequired();
        }
    }
}
