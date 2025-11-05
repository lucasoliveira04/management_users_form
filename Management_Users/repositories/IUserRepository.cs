using System.Collections.Generic;
using Management_Users.entity;

namespace Management_Users.repositories
{
    public interface IUserRepository
    {
        void Add(UserEntity user);
        UserEntity? GetByEmail(string email);
        IEnumerable<UserEntity> GetAll();
        void Delete(int id);
    }
}