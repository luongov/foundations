using System;

class TestAverage
{
    static int iAvg;
    static double dAvg;

    // 1. Create the integer Average( ) function here.
    public static int Average(int x, int y, int z, int t)
    {
        iAvg = (x + y + z + t) / 4;
        return iAvg;
        
    }

    // 2. Create the double Average( ) function here.
    public static double Average(double dx, double dy, double dz, double dt)
    {
        dAvg = (dx + dy + dz + dt) / 4;
        return dAvg;
    }

    // 3. Nothing to do here.
    static void Main()
    {
        iAvg = Average(5, 4, 2, 8);
        Console.WriteLine("The average is {0}", iAvg);

        dAvg = Average(5.0, 4.0, 2.0, 8.0);
        Console.WriteLine("The average is {0}", dAvg);

        Console.ReadLine();
    }
}