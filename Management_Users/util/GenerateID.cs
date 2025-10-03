namespace Management_Users;

public class GenerateID
{
    private static readonly Random random = new Random();
    public static int Generate()
    {
        return random.Next(1000, 9999);
    }
}