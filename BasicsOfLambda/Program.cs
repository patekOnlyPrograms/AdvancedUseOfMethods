namespace BasicsOfLambda;

public class Program
{
    public static void Main(string[] args)
    {
        
    }

    public Func<string, int> GetLength = n => n.Length;
    public Func<int> GetRandomNumberBetween1And10 = () => new Random().Next(1, 10);
}