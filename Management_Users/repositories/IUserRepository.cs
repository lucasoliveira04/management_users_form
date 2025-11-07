using System.Collections.Generic;
using Management_Users.entity;

namespace Management_Users.repositories
{
    public interface IUserRepository
    {
        bool Add(UserEntity user);
        UserEntity? GetByEmail(string email);
        UserEntity? GetByPassword(string password);
        IEnumerable<UserEntity> GetAll();
        void Delete(int id);
    }
}