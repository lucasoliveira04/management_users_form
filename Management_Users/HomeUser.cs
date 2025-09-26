namespace Management_Users;

public partial class HomeUser : Form
{
    public HomeUser()
    {
        InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }


    private void button_enviar_Click(object sender, EventArgs e)
    {
        string name = input_name.Text;
        string sexo = input_sexo.Text;
        string data_nascimento = input_data_nascimento.Text;

        string nomeArquivo = "teste.txt";
        
        string mensagem_save = name + " - " +  sexo + " - " + data_nascimento;

        string caminho = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", nomeArquivo);

        using (StreamWriter writer = new StreamWriter(caminho))
        {
            writer.WriteLine(mensagem_save);
        }

        Console.WriteLine($"Arquivo '{nomeArquivo}' criado na raiz do projeto.");
    }
}