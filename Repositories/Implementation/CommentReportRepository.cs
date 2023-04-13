using EducationalLesson.Entities;
using EducationalLesson.Repositories.Interface;

namespace EducationalLesson.Repositories.Implementation
{
	public class CommentReportRepository : BaseRepository<CommentReport>, ICommentReportRepository
	{
		public CommentReportRepository(EducationalLessonContext context) : base(context)
		{
		}

		public CommentReport GetCommentReport(string id)
		{
			var commentReport = _context.CommentReports
				.Include(u => u.User)
				.Include(c => c.Comment)
				.Include(crf => crf.CommentReportFlags)
				.ThenInclude(f => f.Flag)
				.Where(cr => cr.Id.Equals(id))
				.FirstOrDefault();

			return commentReport;
		}

		public List<CommentReport> GetCommentReports()
		{
			var commentReports = _context.CommentReports
				.Include(c => c.User)
				.Include(c => c.Comment)
				.Include(c => c.CommentReportFlags)
				.ThenInclude(c => c.Flag)
				.ToList();

			return commentReports;
		}
	}
}
