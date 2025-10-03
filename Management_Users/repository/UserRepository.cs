using Management_Users.entity;

namespace Management_Users.repository
{
    public class UserRepository
    {
        private readonly string _rootPath = @"C:\UserData";

        public bool ExistByUsername(string username)
        {
            string userFolder = Path.Combine(_rootPath, username);
            return Directory.Exists(userFolder);
        }

        // Retorna o conteúdo do arquivo do usuário pelo username
        public string FindByUsername(string username)
        {
            string userFolder = Path.Combine(_rootPath, username);
            string filePath = Path.Combine(userFolder, $"{username}.txt");
            
            return File.Exists(filePath) ? File.ReadAllText(filePath) : null;
        }

        // Retorna o conteúdo do arquivo do usuário pelo email
        public string FindByEmail(string email)
        {
            var directories = Directory.GetDirectories(_rootPath);
            foreach (var dir in directories)
            {
                var files = Directory.GetFiles(dir, "*.txt");
                foreach (var file in files)
                {
                    var content = File.ReadAllText(file);
                    if (content.Contains($"Email: {email}"))
                        return content;
                }
            }
            return null;
        }

        public void Save(UserEntity user)
        {
            string userFolder = Path.Combine(_rootPath, user.Username);
            if (!Directory.Exists(userFolder))
                Directory.CreateDirectory(userFolder);

            string filePath = Path.Combine(userFolder, $"{user.Username}.txt");
            string content = $"ID: {user.Id}\nUsername: {user.Username}\nEmail: {user.Email}\nPassword: {user.Password}\nSaldo: {user.Saldo}\nPontos: {user.Pontos}\nLevel: {user.Level}";
            File.WriteAllText(filePath, content);
        }
    }
}