using System.Collections.Generic;
using System.Linq;
using Management_Users.database;
using Management_Users.entity;

namespace Management_Users.repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository()
        {
            _context = new AppDbContext();
        }

        public void Add(UserEntity user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public UserEntity? GetByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
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
