namespace LuciansLusciousLasagna;

public static class Lasagna
{
    private const int ExpectedOvenTime = 40;
    private const int PrepTimePerLayer = 2;

    public static int ExpectedMinutesInOven() => ExpectedOvenTime;

    public static int RemainingMinutesInOven(int actualMinutesInOven)
        => ExpectedOvenTime - actualMinutesInOven;

    public static int PreparationTimeInMinutes(int numberOfLayers)
        => numberOfLayers * PrepTimePerLayer;

    public static int ElapsedTimeInMinutes(int numberOfLayers, int actualMinutesInOven)
        => PreparationTimeInMinutes(numberOfLayers) + actualMinutesInOven;
}
