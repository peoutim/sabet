// Formatting.cs
using System;

class TestMain
{
    static void Main()
    {
        Console.WriteLine("Left justified : [{0,-10}]", 15);
        Console.WriteLine("Right justified: [{0,10}]", 22);

        Console.WriteLine("Currency: {0:C}", 88.8);
        Console.WriteLine("Hex: {0:X}", 1203);
        Console.WriteLine("Fixed: {0:F3}", 1234.56789);

        Console.ReadLine();

        // output will be as follows:

        // Left justified : [15        ]
        // Right justified: [        22]
        // Currency: $88.80
        // Hex: 4B3
        // Fixed: 1234.568
    }
}