namespace EducationalLesson.Entities
{
    public class Student : BaseEntity
    {
        public string StudentName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
