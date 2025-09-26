namespace Management_Users;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        messageError.Hide();
        Console.Write("LoginForm_Load");
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (textBox1.Text != "admin" && 
            textBox2.Text != "admin")
        {
            messageError.Text = "Usuário ou senha inválidos";
            messageError.Show();
            return;
        }

        if (!checkBox1.Checked)
        {
            messageError.Text = "Por favor aceite os termos de uso e privacidade";
            messageError.Show();
            return;
        }
        
        messageError.Hide();
        HomeUser homeUser = new HomeUser();
        homeUser.Show();
        this.Hide();

    }
}