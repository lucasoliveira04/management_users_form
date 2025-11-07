using Management_Users.entity;
using Management_Users.repositories;

namespace Management_Users.pages;

public partial class DashboardHome : Form
{

    private readonly UserEntity _loggedUser;
    public DashboardHome(UserEntity loggedUser)
    {
        InitializeComponent();
        _loggedUser = loggedUser;
    }

    private void DashboardHome_Load(object sender, EventArgs e)
    {
        string nameUser = $"Olá, {_loggedUser.Nome}";
        nomeUserDashboard.Text = nameUser;
    }
}