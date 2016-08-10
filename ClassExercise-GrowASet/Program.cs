// Arrays_Sets.cs
using System;

class Set
{
    private const int defValue = 5; // create a small array size to test this
    private int[] array;
    private int length;

    public Set() : this(defValue)
    {
    }

    public Set(int initialSize)
    {
        array = new int[initialSize];
        length = 0;
    }

    public int Length
    {
        get
        {
            return length;
        }
    }

    public int Capacity
    {
        get
        {
            return array.Length;
        }
    }
    public int this[int index]
    {
        get
        {
            if (index >= length)
            {
                throw new IndexOutOfRangeException();
            }
            return array[index];
        }
        set
        {
            if (index >= length)
            {
                throw new IndexOutOfRangeException();
            }

            // Check if the element is already in
            // the set.

            bool found = false;

            for (int x = 0; x < length; x++)
            {
                if (array[x] == value)
                {
                    found = true;
                    break;
                }
            }

            // If the element is already in the
            // set then no need to add or set the value.
            if (!found)
            {
                array[index] = value;
            }
        }
    }

    // step 1: create a Resize() method to grow the Set Array when it reaches its capacity
    public void ResizeArray(int capacity)
    {
        //a. create a newArray
        int[] newArray = new int[capacity];

        //b. do a for loop to copy the content of existing array[index] into the newArray[index]
        for (int index = 0; index < length; index++)
        {
            newArray[index] = array[index];
        }
        //c. set the array to newArray
        array = newArray;
    }

    // Add will call on ResizeArray() as needed
    public void Add(int v)
    {
        // When exceeding the size of array, we will grow the array
        if (length >= array.Length)
        {
            //throw new IndexOutOfRangeException(); // not needed since we grow the array
            // step 2: call on Resize() method to grow the Set Array if needed
            ResizeArray(length * 2);
        }

        bool found = false;

        for (int index = 0; index < length; index++)
        {
            if (array[index] == v) // since set has to have unique values, it does not accept duplicates
            {
                found = true;
                break;
            }
        }

        if (!found) // if no duplicates
        {
            array[length++] = v; // then allow to the value to be assigned into the array
        }
    }

    public void Remove(int v)
    {
        for (int index = 0; index < length; index++)
        {
            if (array[index] == v)
            {
                // compact the array
                length--;
                for (; index < length; index++)
                {
                    array[index] = array[index + 1];
                }

                break;
            }
        }
    }

    public override string ToString()
    {
        string str = "[";
        bool first = true;

        for (int index = 0; index < length; index++)
        {
            if (!first)
            {
                str = str + ", ";
            }
            first = false;

            str = str + array[index];
        }

        return str + "]";
    } // a way of rewriting the string


}

class Arrays_Sets
{
    static void Main()
    {
        Set mySet = new Set();

        mySet.Add(2);
        mySet.Add(4);
        mySet.Add(5);
        mySet.Add(6);
        mySet.Add(70);
        mySet.Add(80);// exceed the size to test if the ResizeArray() gets called

        Console.WriteLine("{0} has {1} elements", mySet, mySet.Length);

        // Set array element 1 to a value of 2
        mySet[1] = 2;
        Console.WriteLine("{0} has {1} elements", mySet, mySet.Length);

        mySet.Remove(3);
        mySet.Remove(2);
        Console.WriteLine("{0} has {1} elements", mySet, mySet.Length);

        Console.Write("Press Enter...");
        Console.ReadLine();
    }
}