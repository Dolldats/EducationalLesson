namespace EducationalLesson.Entities
{
    public class QuestionReport : BaseEntity
    {
        public int StudentId { get; set; }
        public Student Student      { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public string AdditionalComment { get; set; }
        public ICollection<QuestionReportFlag> QuestionReportFlags { get; set; } = new HashSet<QuestionReportFlag>();
    }
}
