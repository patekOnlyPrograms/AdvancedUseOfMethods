namespace AdvancedUseOfMethods;

public class Program
{
    public static void Main(string[] args)
    {
        var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 25, 35, 14 };

        Func<int, bool> predicate1 = isLargerThan10;
        Console.WriteLine("is larger than 10 ? " + IsAny(numbers,predicate1));


        Func<int, bool> predicate2 = isEven;
        Console.WriteLine("is larger than 10 ? " + IsAny(numbers,predicate2));
        
        bool IsAny(IEnumerable<int> numbers, Func<int, bool> predicate)
        {
            foreach (var number in numbers)
            {
                if (predicate(number))
                {
                    return true;
                }
            }
    
            return false;
        }

        bool isLargerThan10(int number)
        {
            return number > 10;
        }

        bool isEven(int number)
        {
            return number % 2 == 0;
        }
    }
}