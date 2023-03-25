namespace EducationalLesson.Entities
{
    public class TopicQuestion : BaseEntity
    {
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
