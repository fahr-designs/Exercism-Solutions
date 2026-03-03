class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int minutesRemaining)
    {
        int expectedMinutes = ExpectedMinutesInOven();
        return expectedMinutes - minutesRemaining;
    }

    public int PreparationTimeInMinutes(int numberOfLayersAdded)
    {
        return 2 * numberOfLayersAdded;
    }

    public int ElapsedTimeInMinutes(int numberOfLayersAdded, int minutesInOven)
    {
        int prepTime = PreparationTimeInMinutes(numberOfLayersAdded);
        int minutesWorkedOnLasagna = prepTime + minutesInOven;
        return minutesWorkedOnLasagna;
    }
}
