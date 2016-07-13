// Ask user to input a month number 1, or 2, or 3 for (jan, feb, and Mar).
// Then check how many days each month has (say 31, 29, 30 days for each).
// Print the month and the number of days to screen.
// Finish the rest of exercise on your own and include all the months of the year.

using System;

class ex3
{
    static void Main()
    {
        string strName; // declare a sting type to read the input from console

        Console.Write("Please enter a month number (1 to 12): ");
        strName = Console.ReadLine(); // store the input

        string month; // declare a string for month
        int nDays = 0;// declare an int for number of days associated with a month

        switch (strName) // we switch based on the inputed string by the user
        {
            case "1": // if user enters string 1 then we know it is January and show the number of days for this month
                month = "January";
                nDays = 31;
                break;

            case "2": // if user entere string 2 then we know it is February and show the number of days for this month
                month = "February";
                nDays = 29;
                break;
            case "3":
                month = "March";
                nDays = 30;
                break;
            // Continue the code up to caes "12", December
            default:
                month = "unknown"; // if user enters garbage of something that we do not recognize, we go to default
                nDays = -1;        // showing a -1 gives a clue that something bad happened
                break;             // do not forget to type break for each case
        }

        Console.WriteLine("The month {0} has {1} days", month, nDays); // show on the console the result
        Console.ReadLine(); // hold or pause console to see the results
    }

}