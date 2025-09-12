
class Program
{
    static void Main()
    {
        Console.WriteLine("=== Annalyn's Infiltration ===");

        var knightAwake = false;
        var archerAwake = true;
        var prisonerAwake = true;
        var dogPresent = false;

        Console.WriteLine($"Fast attack: {QuestLogic.CanFastAttack(knightAwake)}");
        Console.WriteLine($"Spy: {QuestLogic.CanSpy(knightAwake, archerAwake, prisonerAwake)}");
        Console.WriteLine($"Signal prisoner: {QuestLogic.CanSignalPrisoner(archerAwake, prisonerAwake)}");
        Console.WriteLine($"Free prisoner: {QuestLogic.CanFreePrisoner(knightAwake, archerAwake, prisonerAwake, dogPresent)}");
    }
}
