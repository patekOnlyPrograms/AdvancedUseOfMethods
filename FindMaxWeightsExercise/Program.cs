namespace FindMaxWeightsExercise;

public class Program
{
    public static void Main(string[] args)
    {
        var PetsDictionary = new List<Pet>()
        {
            new Pet(PetType.Dog, 10),
            new Pet(PetType.Cat, 5),
            new Pet(PetType.Fish, 0.9),
            new Pet(PetType.Dog, 45),
            new Pet(PetType.Cat, 2),
            new Pet(PetType.Fish, 0.02),
        };
        
        Console.WriteLine(PetsDictionary.ToString());
    }
    
    public static Dictionary<PetType, double> FindMaxWeights(List<Pet> pets)
    {
        var result = new Dictionary<PetType, double>();
        foreach (var pet in pets)
        {
            if (!result.ContainsKey(pet.PetType) || pet.Weight > result[pet.PetType])
            {
                result[pet.PetType] = pet.Weight;
            }
        }

        return result;
    }
}

public class Pet
{
    public PetType PetType { get; }
    public double Weight { get; }
    
    public Pet(PetType petType, double weight)
    {
        PetType = petType;
        Weight = weight;    
    }
        
    public override string ToString() => $"{PetType}, {Weight} kilos";
}
    
public enum PetType { Dog, Cat, Fish }