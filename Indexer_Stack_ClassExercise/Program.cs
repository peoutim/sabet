// File: indexer_ex1.cs
// Create a string stack with an indexer
using System;

class Stack
{
    private string[] stack;
    private int sp = 0;

    public Stack(int maxstrings)
    {
        stack = new string[maxstrings];
    }

    public void Push(string v)
    {
        stack[sp++] = v;
    }

    public string Top
    {
        get
        {
            return stack[sp - 1];
        }
    }

    public bool IsEmpty
    {
        get
        {
            return sp == 0;
        }
    }

    public string Pop()
    {
        return stack[--sp];
    }

    // Exercise:
    // Create an indexer for object of this class that returns
    // the stack content based on the given index
    public string this[int index]
    {
        get
        {
            return stack[index];
        }
    }
}

class iex1
{
    public static void Main()
    {
        Stack stack = new Stack(10);

        stack.Push("first");
        stack.Push("second");
        stack.Push("third");

        for (int x = 0; x < 3; x++)
        {
            Console.WriteLine("stack[{0}] = {1}", x, stack[x]);
        }
    }
}
