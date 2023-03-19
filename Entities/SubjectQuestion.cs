namespace EducationalLesson.Entities
{
    public class SubjectQuestion : BaseEntity
    {
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
