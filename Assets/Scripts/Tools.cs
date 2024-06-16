using System;

public static class Tools
{
    private static readonly Random s_random = new();

    public static int GetRandomNumber(int maxValue) => 
        s_random.Next(maxValue);
}