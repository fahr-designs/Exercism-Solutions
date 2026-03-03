class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int minutesRemaining)
    {
        return ExpectedMinutesInOven() - minutesRemaining;
    }

    public int PreparationTimeInMinutes(int numberOfLayersAdded)
    {
        return 2 * numberOfLayersAdded;
    }

    public int ElapsedTimeInMinutes(int numberOfLayersAdded, int minutesInOven)
    {
        return PreparationTimeInMinutes(numberOfLayersAdded) + minutesInOven;
    }
}
