using System.Collections.Generic;
using System.Linq;
using Management_Users.database;
using Management_Users.entity;

namespace Management_Users.repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context = new();

        public bool IsAuthenticated(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            return user != null;
        }

        public UserEntity? Authenticate(string email, string password)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }
        public bool Add(UserEntity user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }

        public UserEntity? GetByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }

        public UserEntity? GetByPassword(string password)
        {
            return _context.Users.FirstOrDefault(u => u.Password == password);
        }

        public IEnumerable<UserEntity> GetAll()
        {
            return _context.Users.ToList();
        }

        public void Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}
