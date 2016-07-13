using System;

namespace BubbleSort
{
    // Write a program that sorts an array of numbers. 
    // Use the array from exercise 1 to sort. 
    // (Hint: Use Bubble sort)

    class Program
    {
        static void Main()
        {
            int[] numbers = new int[] { 5, -2, 100, 4, 5 };
            
            // show the array before sorting
            Console.WriteLine("Before:");
            foreach (int z in numbers)
            {
                Console.Write("{0,3} ", z);
            }
            
            // give it a blank line
            Console.WriteLine();

            // use "nested for loop" to find the first and then the next value 
            // and if first greater than the next one, we need to swap them

            for(int x = 0; x < numbers.Length; x++)
            {
                for(int y=x+1; y<numbers.Length; y++)
                {
                    if(numbers[x] > numbers[y])
                    {
                        //swap them: 3 steps to swap
                        int t = numbers[x];       // save the first
                        numbers[x] = numbers[y];  // do the swap
                        numbers[y] = t;           // set the next to first
                    }
                }
            }

            // show the result after sort is finished
            Console.WriteLine("After:");
            foreach(int z in numbers)
            {
                Console.Write("{0,3} ", z);
            }

            Console.ReadLine();
        }
    }
}
