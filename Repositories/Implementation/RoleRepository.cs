using EducationalLesson.Entities;
using EducationalLesson.Repositories.Interface;

namespace EducationalLesson.Repositories.Implementation
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
	{
		public RoleRepository(EducationalLessonContext context) : base(context)
		{
		}
	}
}
