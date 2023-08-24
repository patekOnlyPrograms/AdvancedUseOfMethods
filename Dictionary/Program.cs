namespace Dictionary;

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> currencyMapping = new Dictionary<string, string>()
        {
            {"USA","USD"},
            {"IND","INR"},
            {"SPAIN","EUR"},
            {"UK","GDP"},
            {"ITALY","EUR"},
        };

        currencyMapping["POLAND"] = "PLN";

        foreach (var currenyCountry in currencyMapping)
        {
            Console.WriteLine($"Country: {currenyCountry.Key}" + $" Currency: {currenyCountry.Value}");
        }
    }
}