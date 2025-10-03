using Management_Users.entity;
using Management_Users.repository;

namespace Management_Users.service
{
    public class LoginService
    {
        private readonly UserRepository _userRepository = new UserRepository();

        public UserEntity? Login(string usernameOrEmail, string password)
        {
            string? userContent = _userRepository.FindByUsername(usernameOrEmail) 
                                  ?? _userRepository.FindByEmail(usernameOrEmail);

            if (string.IsNullOrEmpty(userContent))
                return null; 

            var lines = userContent.Split('\n');

            if (lines.Length < 4)
                return null; 

            string storedPassword = lines[3].Replace("Password: ", "").Trim();

            if (storedPassword == password)
            {
                int id = int.Parse(lines[0].Replace("ID: ", "").Trim());
                string username = lines[1].Replace("Username: ", "").Trim();
                string email = lines[2].Replace("Email: ", "").Trim();
                var saldo = lines.Length > 4 ? double.Parse(lines[4].Replace("Saldo: ", "").Trim()) : 0.0;
                var pontos = lines.Length > 5 ? int.Parse(lines[5].Replace("Pontos: ", "").Trim()) : 0;
                var level = lines.Length > 6 ? int.Parse(lines[6].Replace("Level: ", "").Trim()) : 0;

                return new UserEntity(id, username, email, storedPassword, saldo, pontos, level);
            }

            return null; 
        }

    }
}