using Timer = System.Windows.Forms.Timer;

namespace Management_Users.pages;

public partial class Home : Form
{

    private string[] frases = new[]
    {
        "Bem-vindo ao sistema!",
        "Gerencie seus usuários facilmente.",
        "Clique em 'Registrar' para começar.",
        "Acesse sua conta clicando em 'Login'."
    };

    private int index = 0;
    private Timer timer;
    
    public Home()
    {
        InitializeComponent();

        timer = new Timer();
        timer.Interval = 5000; 
        timer.Tick += Timer_Tick;
        timer.Start();
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        textchange.Text = frases[index];
        index = (index + 1) % frases.Length;
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
        {
            FileName = "https://www.linkedin.com/in/lucas-oliveira-campos/",
            UseShellExecute = true
        });
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
        {
            FileName = "https://www.github.com/lucasoliveira04/",
            UseShellExecute = true
        });
    }

    private void button1_Click(object sender, EventArgs e)
    {
        new Register().ShowDialog();
    }
    
    private void button2_Click(object sender, EventArgs e)
    {
        new Login().ShowDialog();
    }
    
    private void button3_Click(object sender, EventArgs e)
    {
        new Login().ShowDialog();
    }
}