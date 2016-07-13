using System;


namespace SearchForAnItemInArray
{
    //Write a program that allows the user to enter a number. 
    // The program will determine if the number that the user entered is in the array.
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[] { 10, 15, 20, 25, 30, 35 };

            Console.Write("Enter a number:");
            string str = Console.ReadLine();

            int num = int.Parse(str);
            bool found = false; // create a boolean flag (a post-it)

            // search into the array to find the number
            foreach (int x in numbers)
            {

                if (num == x) // when you find it
                {
                    // set the bool flag on true
                    found = true;
                }
            }

            // if flag is true then show the number that you found in the list
            if (found)
            {
                Console.WriteLine("Found the number!");
            }
            else
            {
                Console.WriteLine("Sorry, I did not find the number, try again");
            }

            Console.ReadLine();
        }
    }
}
