namespace EducationalLesson.Entities
{
    public class Classes : BaseEntity
    {
        public string ClassesName { get; set; }
        public string Description { get; set; }
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
