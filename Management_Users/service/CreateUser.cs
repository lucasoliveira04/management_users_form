using System;
using System.IO;
using Management_Users.entity;
using Management_Users.repository;

namespace Management_Users.service;

public class CreateUser
{
    private readonly UserRepository _userRepository = new UserRepository();

    public void Create(UserEntity entity)
    {
        if (_userRepository.ExistByUsername(entity.Username))
        {
            Console.WriteLine("Usuário já existe.");
            return;
        }
        
        
        _userRepository.Save(entity);
    }
}