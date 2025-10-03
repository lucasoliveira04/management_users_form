using Management_Users.entity;

namespace Management_Users;

public partial class HomeUser : Form
{
    private readonly UserEntity _user;
    public HomeUser(UserEntity user)
    {
        InitializeComponent();
        _user = user;
        
        label_name_user.Text = _user.Username;
        label_points.Text = _user.Pontos + " Pontos";
        label_level.Text = _user.Level + " Level";
        label_saldo.Text = _user.Saldo + " R$";
    }

    private void button_Click(object sender, EventArgs e)
    {
        FormNavigator.Navigate(this, new LoginForm());
    }
}