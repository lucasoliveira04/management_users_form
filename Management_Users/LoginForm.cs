using Management_Users.service;

namespace Management_Users;

public partial class LoginForm : Form
{
    private readonly LoginService _loginService = new LoginService();
    public LoginForm()
    {
        InitializeComponent();
    }
    private void LoginForm_Load(object sender, EventArgs e)
    {
        messageError.Hide();
        Console.Write("LoginForm_Load");
    }
    private async void button1_Click(object sender, EventArgs e)
    {
        var usernameOrEmail = textBox1.Text.Trim();
        var password = textBox2.Text.Trim();
        
        if (string.IsNullOrEmpty(usernameOrEmail) || string.IsNullOrEmpty(password))
        {
            messageError.Text = "Por favor, preencha todos os campos.";
            messageError.Show();
            return;
        }

        var user = _loginService.Login(usernameOrEmail, password);

        if (!checkBox1.Checked)
        {
            messageError.Text = "Você deve aceitar os termos de uso.";
            messageError.Show();
            return;
        }
        
        if (user == null)
        {
            messageError.Text = "Usuário ou senha incorretos.";
            messageError.Show();
            return;
        }

        messageError.Hide();

        button1.Enabled = false;
        button1.Text = "Carregando...";
        await Task.Delay(3500);
        button1.Enabled = true;
        button1.Text = "Entrar";

        HomeUser homeUser = new HomeUser(user);
        FormNavigator.Navigate(this, homeUser);
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        RegisterUser registerUser = new RegisterUser();
        FormNavigator.Navigate(this, registerUser);
    }
}