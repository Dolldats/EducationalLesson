using EducationalLesson.Repositories.Interface;

namespace EducationalLesson.Repositories.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EducationalLessonContext _context;
        private bool _disposed = false;
        public IRoleRepository Roles { get; }
        public IStudentRepository Students { get; }
        public ISubjectRepository Subjects { get; }
        public IQuestionRepository Questions { get; }
        public ICommentRepository Comments { get; }
        public IFlagRepository Flags { get; }
        public IQuestionReportRepository QuestionReports { get; }
        public ICommentReportRepository CommentReports { get; }

        public UnitOfWork(
            EducationalLessonContext context,
            IRoleRepository roleRepository,
            IStudentRepository studentRepository,
            ISubjectRepository subjectRepository,
            IQuestionRepository questionRepository,
            ICommentRepository commentRepository,
            IFlagRepository flagRepository,
            IQuestionReportRepository questionReportRepository,
            ICommentReportRepository commentReportRepository)
        {
            _context = context;
            Roles = roleRepository;
            Students = studentRepository;
            Subjects = subjectRepository;
            Questions = questionRepository;
            Comments = commentRepository;
            Flags = flagRepository;
            QuestionReports = questionReportRepository;
            CommentReports = commentReportRepository;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
