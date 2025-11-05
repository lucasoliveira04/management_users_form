using Management_Users.repositories;

namespace Management_Users.pages;

public partial class Login : Form
{
    private readonly UserRepository _userRepository = new UserRepository();
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

        if (!_userRepository.IsAuthenticated(email, senha))
        {
            MessageBox.Show("E-mail ou senha incorretos. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}