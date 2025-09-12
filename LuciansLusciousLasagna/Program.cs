namespace LuciansLusciousLasagna;
class Program
{
    static void Main()
    {
        Console.WriteLine("=== Lucian's Luscious Lasagna ===");
        Console.WriteLine($"Expected oven time: {Lasagna.ExpectedMinutesInOven()} minutes");
        Console.WriteLine($"Remaining oven time (30 min in oven): {Lasagna.RemainingMinutesInOven(30)} minutes");
        Console.WriteLine($"Preparation time (3 layers): {Lasagna.PreparationTimeInMinutes(3)} minutes");
        Console.WriteLine($"Elapsed time (3 layers, 20 min in oven): {Lasagna.ElapsedTimeInMinutes(3, 20)} minutes");
    }
}
