using EducationalLesson.Entities;
using System.Linq.Expressions;

namespace EducationalLesson.Repositories.Interface
{
	public interface IStudentRepository : IRepository<Student>
	{
		Student GetUser(Expression<Func<Student, bool>> expression);
	}
}