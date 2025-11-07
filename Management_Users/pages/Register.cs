using Management_Users.entity;
using Management_Users.repositories;

namespace Management_Users.pages
{
    public partial class Register : Form
    {
        private readonly IUserRepository _userRepository;
        
        public Register()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }
    
        private void buttonCriarConta_Click(object sender, EventArgs e)
        {
            String nome = nomeTextbox.Text.Trim();
            String email = emailTextbox.Text.Trim();
            String senha = senhaTextBox.Text.Trim();
            String confirmarSenha = confirmarSenhaTextbox.Text.Trim();
            
            if (nome.Length == 0 || email.Length == 0 || senha.Length == 0 || confirmarSenha.Length == 0)
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (senha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (_userRepository.GetByEmail(email) != null)
            {
                MessageBox.Show("Já existe uma conta com este e-mail. Por favor, use outro e-mail.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserEntity user = new UserEntity();
            user.Nome = nome;
            user.Password = senha;
            user.Email = email;
            
            var registerUser = _userRepository.Add(user);
            if (registerUser)
            {
                MessageBox.Show("Conta criada com sucesso");
                return;
            } 
        }
    }
}

