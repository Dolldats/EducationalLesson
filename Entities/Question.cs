namespace EducationalLesson.Entities
{
    public class Question : BaseEntity
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public string QuestionText { get; set; }
        public string ImageUrl { get; set; }
        public bool IsClosed { get; set; }
        public ICollection<SubjectQuestion> SubjectQuestions { get; set; } = new HashSet<SubjectQuestion>();
        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
        
    }
}
