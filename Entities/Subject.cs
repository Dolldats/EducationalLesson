namespace EducationalLesson.Entities
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<SubjectQuestion>SubjectQuestions { get; set; } = new HashSet<SubjectQuestion>();
    }
}
