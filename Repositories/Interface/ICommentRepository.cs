using EducationalLesson.Entities;
using System.Linq.Expressions;

namespace EducationalLesson.Repositories.Interface
{
	public interface ICommentRepository : IRepository<Comment>
	{
		Comment GetCommentWithReportList(string id);
		Comment GetCommentWithReportList(Expression<Func<Comment, bool>> expression);
		List<CommentReport> GetCommentReportsByCommentId(string id);
	} 
}
