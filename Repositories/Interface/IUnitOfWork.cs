namespace EducationalLesson.Repositories.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IRoleRepository Role { get; }
        IStudentRepository Students { get; }
        ISubjectRepository Subjects { get; }
        IQuestionRepository Questions { get; }
        ICommentRepository Comments { get; }
        IFlagRepository Flags { get; }
        IQuestionReportRepository QuestionReports { get; }
        ICommentReportRepository CommentReports { get; }
        int SaveChanges();
    }
}
