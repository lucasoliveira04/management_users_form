namespace Management_Users;

public class FileText
{
    public void Write(string path, string content)
    {
        File.WriteAllText(path, content);
    }

    public string Read(string path)
    {
        if (!File.Exists(path)) return string.Empty;
        return File.ReadAllText(path);
    }

    public void Delete(string path)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }

    public bool Buscar(String path, int id)
    {
        return File.Exists(path);
    }
}