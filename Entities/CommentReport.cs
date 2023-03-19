namespace EducationalLesson.Entities
{
    public class CommentReport : BaseEntity
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
        public string AdditionalComment { get; set; }
        public ICollection<CommentReportFlag> CommentReportFlags { get; set; } = new HashSet<CommentReportFlag>();
    }
}
