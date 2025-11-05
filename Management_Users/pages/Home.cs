namespace Management_Users.pages;

public partial class Home : Form
{
    public Home()
    {
        InitializeComponent();
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