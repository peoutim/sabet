// Arrays_InsDel.cs
using System;
class DynamicArray
{
    private int[] Array;

    public DynamicArray(int[] array)
    {
        Array = array;
    }
    public void Display(int[] array)
    {
        foreach (int x in array)
        {
            Console.Write("{0,2} ", x);
        }
        Console.WriteLine();
    }
    public void Insert(int index, int val)
    {

        for (int last = Array.Length - 1; last > index; last--)
        {
            Array[last] = Array[last - 1];
        }

        Array[index] = val;

    }
    public void RemoveAt(int index)
    {
        for (; index < Array.Length - 1; index++)
        {
            Array[index] = Array[index + 1];
        }

        Array[index] = -1;
    }
}

class Arrays_InsDel
{

    static void Main()
    {
        int[] array = new int[6] { 10, 20, 30, 40, 50, -1 };

        DynamicArray da = new DynamicArray(array);
        da.Display(array);

        da.Insert(2, 22);
        da.Display(array);

        da.RemoveAt(3);
        da.Display(array);

        Console.Write("Press Enter...");
        Console.ReadLine();
    }
}
