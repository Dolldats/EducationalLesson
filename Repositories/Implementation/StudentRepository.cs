using EducationalLesson.Entities;
using EducationalLesson.Repositories.Interface;
using System.Linq.Expressions;

namespace EducationalLesson.Repositories.Implementation
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
	{
		public StudentRepository(EducationalLessonContext context) : base(context)
		{
		}

		public Student GetUser(Expression<Func<Student, bool>> expression)
		{
			return _context.Students
				.Include(x => x.Role)
				.SingleOrDefault(expression);
		}
	}
}
