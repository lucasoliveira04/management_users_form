namespace Management_Users.entity;

public class UserEntity
{
    private static readonly Random _random = new Random();
    
    public int Id { get; private set; }
    public string Username { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }

    public double Saldo { get; set; }
    public int Pontos { get; set; }
    public int Level { get; set; }
    
    public UserEntity(int id, string username, string email, string password, double saldo, int pontos, int level)
    {
        Id = id;
        Username = username;
        Email = email;
        Password = password;
        Saldo = saldo;
        Pontos = pontos;
        Level = level;
    }
    
    public UserEntity(int id, string username, string email, string password)
    {
        Id = id;
        Username = username;
        Email = email;
        Password = password;
    }
}