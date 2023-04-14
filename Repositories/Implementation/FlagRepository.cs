using EducationalLesson.Entities;

namespace EducationalLesson.Repositories.Implementation
{
    public class FlagRepository : BaseRepository<Flag>, IFlagRepository
    {
        public FlagRepository(EducationalLessonContext context) : base(context)
        {
        }
    }
}
