namespace StrategyDesignPattern;

public class Program
{
    public static void Main(string[] args)
    {
        var numbers = new List<int> { 10, -10, 200, 100, 50, 60, 70, 81,1,3,57,55 };

        Console.WriteLine(@"Select filer: 
        Even
        Odd
        Positive");

        var userInput = Console.ReadLine();

        List<int> result = new NumbersFilter().FilterBy(userInput,numbers);

        print(result);

        void print(IEnumerable<int> numbers)
        {
            Console.WriteLine(string.Join(",",numbers));
        }
    }

    public class NumbersFilter
    {
        public List<int> FilterBy(string filter, List<int> numbers)
        {
            switch (filter)
            {
                case "Even":
                    return SelectEven(numbers);
                    
                case "Odd":
                    return SelectOdd(numbers);
                case "Positive":
                    return SelectPositive(numbers);
                default:
                    throw new NotSupportedException($"{filter} is not valid filter");
            }
        }
        
        private List<int> SelectEven(List<int> numbers)
        {
            var result = new List<int>();

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    result.Add(number);
                }
            }

            return result;
        }
        
        private List<int> SelectOdd(List<int> numbers)
        {
            var result = new List<int>();

            foreach (var number in numbers)
            {
                if (number % 2 == 1)
                {
                    result.Add(number);
                }
            }

            return result;
        }
        
        private List<int> SelectPositive(List<int> numbers)
        {
            var result = new List<int>();

            foreach (var number in numbers)
            {
                if (number > 0)
                {
                    result.Add(number);
                }
            }

            return result;
        }
    }    
}

