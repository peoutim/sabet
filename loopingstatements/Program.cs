// File: for.cs
using System;

class TestFor
{
    static void Main()
    {
        int sum = 0;
        int x = 1;  // need to declare x here if we need to access it outside the loop

        for (; ;) // use semicolons between statements
        {
            sum = sum + x;

            if (sum > 20)
            {
                // exits the for loop
                break;
            }

            if (sum == 10)
            {
                // skips remainder of loop body
                continue;
            }

            Console.WriteLine("x is {0} and sum is {1}", x, sum);
        }
    }
}