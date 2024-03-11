using MailService.Models;

namespace MailWebApi.DAL
{
    internal class DbInitializer
    {
        public static void Initialize(MailDbContext mailDbContext)
        {
            mailDbContext.Database.EnsureCreated();

            if (!mailDbContext.Users.Any())
            {
                var newUsers = new User[]
                {
                    new User{FullName = "Петр"},
                    new User{FullName = "Сергей"},
                    new User{FullName = "Иван"},
                    new User{FullName = "Олег"},
                    new User{FullName = "Денис"},
                    new User{FullName = "Василий"},
                    new User{FullName = "Андрей"},
                    new User{FullName = "Алексей"},
                    new User{FullName = "Александр"},
                    new User{FullName = "Павел"},
                    new User{FullName = "Максим"},
                    new User{FullName = "Константин"},

                };

                foreach (var user in newUsers)
                    mailDbContext.Users.Add(user);
            }
            mailDbContext.SaveChanges();
        }
    }
}
