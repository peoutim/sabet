// File: foreach.cs
using System;

class TestForeach
{
    static void Main()
    {
        int[] mynumbers = new int[] { 5, -2, 100, 12, 4, -5 };
        int Min = mynumbers[0];  // pick one from the list for comparison to find min
        int Max = mynumbers[0];  // pick one from the list for comparison  to find max

        // find the min and max
        // minimum value is -5
        // maximum value is 100

        foreach (int x in mynumbers) // looping into an array
        {
            if (x < Min)
            {
                // code here
                Min = x;

            }

            if (x > Max)
            {
                // code here
                Max = x;
            }
        }

        Console.WriteLine("The Minimum value is {0}", Min);
        Console.WriteLine("The Maximum value is {0}", Max);

        Console.ReadLine();
    }
}