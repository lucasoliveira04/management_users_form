using Management_Users.entity;
using Management_Users.service;

namespace Management_Users;

public partial class RegisterUser : Form
{
    public RegisterUser()
    {
        InitializeComponent();
    }
    
    private readonly Random _random = new Random();

    private void btn_create_account_Click(object sender, EventArgs e)
    {
        string username = name_textbox.Text.Trim();
        string email = textbox_email.Text.Trim();
        string password = textbox_password.Text.Trim();

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Preencha todos os campos!");
            return;
        }
        
        var userEntity = new UserEntity(
            id: GenerateID.Generate(),
            username: username,
            email: email,
            password: password,
            level: _random.Next(1, 100),
            pontos: _random.Next(0, 500),
            saldo: Math.Round(_random.NextDouble() * 1000, 2)
            
        );
     
        CreateUser createUser = new CreateUser();
        createUser.Create(userEntity);
    }


    private void label5_Click(object sender, EventArgs e)
    {
        LoginForm loginForm = new LoginForm();
        FormNavigator.Navigate(this, loginForm);
    }
}