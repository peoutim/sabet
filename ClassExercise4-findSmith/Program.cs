// File: if_ex6.cs
using System;

class ex6
{
    static void Main()
    {
        while(true)// keep letting you to input again when you press enter
        { 
        Console.Write("Enter a person's full name:"); // ask a person to type a full name
        string str = Console.ReadLine(); // store the name

        Console.WriteLine(); //insert a blank line for clarity
        Console.WriteLine(); // insert another blank line for clarity

        str = str.ToUpper(); // ***this allows you to take all characters to become uppercase characters

        if (str.EndsWith(" SMITH"))// ***EndsWith functionality under string type is useful
        {
            Console.WriteLine("You found a Smith!");
            Console.WriteLine(); //insert a blank line for clarity
            }
        else
        {
            Console.WriteLine("You didn't find a Smith.");
            Console.WriteLine(); //insert a blank line for clarity
            }

        Console.ReadLine(); //hold or pause the console to show results
        }
    }
}