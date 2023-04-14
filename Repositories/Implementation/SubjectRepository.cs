using EducationalLesson.Entities;

namespace EducationalLesson.Repositories.Implementation
{
    public class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(EducationalLessonContext context) : base(context)
        {
        }
    }
}
