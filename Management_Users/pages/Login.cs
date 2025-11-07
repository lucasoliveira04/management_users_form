using Management_Users.repositories;

namespace Management_Users.pages;

public partial class Login : Form
{
    private readonly UserRepository _userRepository = new();
    public Login()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string email = emailLoginTextbox.Text.Trim();
        string senha = senhaLoginTextbox.Text.Trim();
        
        if (email.Length == 0 || senha.Length == 0)
        {
            MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        var user = _userRepository.Authenticate(email, senha);

        if (user == null)
        {
            MessageBox.Show("E-mail ou senha incorretos. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            var dashbord = new DashboardHome(user);
            dashbord.Show();
            this.Close();
        }
    }
    
    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var registerForm = new Register();
        registerForm.Show();
    }
}