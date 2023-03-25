namespace EducationalLesson.Entities
{
    public class Topic : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<TopicQuestion> TopicQuestions { get; set; } = new HashSet<TopicQuestion>();
    }
}
