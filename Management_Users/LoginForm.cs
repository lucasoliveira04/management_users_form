namespace Management_Users;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        Console.Write("LoginForm_Load");
    }

    private void button1_Click(object sender, EventArgs e)
    {
        HomeUser homeUserForm = new HomeUser();
        homeUserForm.Show();
        this.Hide();
    }
}