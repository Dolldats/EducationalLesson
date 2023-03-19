namespace EducationalLesson.Entities
{
    public class Comment : BaseEntity
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public string CommentText { get; set; }
        public ICollection<CommentReport> CommentReports { get; set; } = new HashSet<CommentReport>();
    }
}
