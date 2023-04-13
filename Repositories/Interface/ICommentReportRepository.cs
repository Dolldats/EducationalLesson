using EducationalLesson.Entities;

namespace EducationalLesson.Repositories.Interface
{
	public interface ICommentReportRepository : IRepository<CommentReport>
	{
		List<CommentReport> GetCommentReports();
		CommentReport GetCommentReport(string id);
	}
}
