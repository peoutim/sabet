// File: Switch.cs
using System;

class TestSwitch
{
    static void Main()
    {
        int x = 5;

        switch (x)
        {
            case 1:
                Console.WriteLine("x is 1");
                break;
            case 2:
                Console.WriteLine("x is 2");
                break;
            case 3:
            case 4:
                Console.WriteLine("x is 3 or 4");
                break;
            default://this has to happen no matter what
                Console.WriteLine("x is not 1 or 2 or 3 or 4");
                break;
        }

        string month = "Jan";

        switch (month)
        {
            case "Jan":
                Console.WriteLine("month is Jan");
                break;
            default:
                Console.WriteLine("month is not Jan");
                break;
        }
    }
}