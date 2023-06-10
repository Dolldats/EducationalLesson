using EducationalLesson.Entities;
using System.Data;

namespace EducationalLesson.Context
{
    internal class DbInitializer
    {
        internal static void Initialize(EducationalLessonContext context)
        {
            ArgumentNullException.ThrowIfNull(context, nameof(context));

            context.Database.EnsureCreated();

            if (context.Roles.Any())
            {
                return;
            }

            var roles = new Role[]
            {
                new Role()
                {
                    RoleName = "Admin",
                    Description = "Role for admin",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "",
                    LastModified = new DateTime() //0001-01-01 00:00:00:00
                },
                new Role()
                {
                    RoleName = "AppUser",
                    Description = "Role for nominal user",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "",
                    LastModified = new DateTime()
                }
            };

            foreach (var r in roles)
            {
                context.Roles.Add(r);
            }

            context.SaveChanges();

            var password = "p@ssword1";
            var salt = HashingHelper.GenerateSalt();
            var admin = context.Roles.Where(r => r.RoleName == "Admin").SingleOrDefault();

            var users = new Student[]
            {
                new Student()
                {
                    StudentName = "admin",
                    HashSalt = salt,
                    PasswordHash = HashingHelper.HashPassword(password, salt),
                    Email = "admin@gmail.com",
                    RoleId = admin.Id,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    IsDeleted = false,
                    ModifiedBy = "",
                    LastModified = new DateTime()
                }
            };

            foreach (var u in users)
            {
                context.Students.Add(u);
            }

            context.SaveChanges();
        }
    }
}
