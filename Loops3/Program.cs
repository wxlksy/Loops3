using System;

class Program
{
    static void Main()
    {
        double dist = 10;
        double tDist = 0;
        int day = 0;

        while (tDist <= 100)
        {
            day++;
            tDist += dist;
            dist *= 1.1;
        }

        Console.WriteLine($"На {day}-й день суммарный пробег превысит 100 км.");
    }
}