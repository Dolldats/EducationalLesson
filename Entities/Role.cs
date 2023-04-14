namespace EducationalLesson.Entities
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
