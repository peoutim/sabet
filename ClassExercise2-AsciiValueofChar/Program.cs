using System;

class ClassExercise2
{
    static void Main()
    {
        //ask the user to input a string
        Console.Write("Enter a string:"); 

        // Read the string from Console
        string str = Console.ReadLine();

        //Store the first character of the typed string into a char type ch
        char ch = str[0];

        // convert and cast the stored character into its ascii value
        int ascii = (int)ch;

        // Show the ascii value on the console
        Console.WriteLine("Ascii = {0}", ascii);

        // hold or pause the console to show the result
        Console.ReadLine();
    }
}