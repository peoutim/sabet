//Calculate the polynomial
using System;

class dex1
{
    static void Main()
    {
        Console.Write("Please type an integer value for x: ");

        string str; // declare a string variable

        str = Console.ReadLine(); // read the string inputed by the user from console

        int x = int.Parse(str);  // convert a string into an integer type

        int iResult = (int)((3 * x * x * x) - (5 * x * x) + 6); // calculate the polynomial

        Console.WriteLine("The calculated value for 3x^2-5x^2+6 is {0}", iResult); // show the result on the console

        Console.ReadLine();// hold or pause the console to see the result
    }

}