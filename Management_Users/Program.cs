using System;
using Management_Users.pages;
using Management_Users.repositories;

namespace Management_Users
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var userRepository = new UserRepository();
            var users = userRepository.GetAll();

            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.Id}, Nome: {user.Nome}, Email: {user.Email}, Horario de Criação: {user.CreatedAt}");
            }
            
            Application.Run(new Home());
        }
    }
}