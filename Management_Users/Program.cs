using Management_Users.database;
using Management_Users.entity;
using Management_Users.pages;
using Management_Users.repositories;

namespace Management_Users
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();

                if (context.Users.Any())
                {
                    var adminExists = context.Users.Any(u => u.Email == "admin@system.com");
                    var userExists = context.Users.Any(u => u.Email == "user@system.com");
                    var rootExists = context.Users.Any(u => u.Email == "admin");
                    
                    if (!adminExists || !userExists ||  !rootExists)
                    {
                        if (adminExists)
                        {
                            context.Users.Add(new UserEntity
                            {
                                Nome = "Administrador",
                                Email = "admin@system.com",
                                Password = "123456",
                                CreatedAt = DateTime.Now
                            });
                        }

                        if (!userExists)
                        {
                            context.Users.Add(new UserEntity
                            {
                                Nome = "Usuário Padrão",
                                Email = "user@system.com",
                                Password = "123456",
                                CreatedAt = DateTime.Now
                            });
                        }

                        if (!rootExists)
                        {
                            context.Users.Add(new UserEntity
                            {
                                Nome = "root",
                                Email = "root",
                                Password = "root",
                                CreatedAt = DateTime.Now
                            });
                        }
                        
                        

                        context.SaveChanges();
                    }
                }
            }

            ApplicationConfiguration.Initialize();

            var userRepository = new UserRepository();
            var users = userRepository.GetAll();

            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.Id}, Nome: {user.Nome}, Email: {user.Email}, Criado em: {user.CreatedAt}");
            }

            Application.Run(new Home());
        }
    }
}
