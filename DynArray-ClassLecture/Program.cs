// Arrays_Stacks.cs
using System;

class Stack
{
    private int[] stack = new int[5]; // size 5
    private int sp = 0;

    public void Push(int v)
    {
        //put the value into the stack
        stack[sp] = v;

        //move the sp to the next available spot
        sp = sp + 1;

        if (sp == stack.Length)
        {
            //step 1: create an index that is greater than the current array size
            int x = stack.Length + 10;

            //step 2: create a new stack based on the new index size that you have from step 1
            int[] newstack = new int[x];

            //step 3: copy the content of the old stack into the new stack
            stack.CopyTo(newstack, 0);

            //step 4: set the current stack to the new stack that we can work with
            stack = newstack;
        }
    }

    public int Pop()
    {
        // move the sp down to point to the top (last value in the stack)
        sp = sp - 1;

        // return the value at that spot
        return stack[sp];
    }

    public int Top
    {
        get
        {
            return stack[sp - 1]; // last value entered into the stack
        }
    }

    public bool IsEmpty
    {
        get
        {
            //if(sp == 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return sp == 0;
        }
    }
}

class Arrays_Stacks
{
    static void Main()
    {
        Stack stack = new Stack();

        stack.Push(10);
        stack.Push(11);
        stack.Push(12);
        stack.Push(13);
        stack.Push(14);
        stack.Push(15);
        stack.Push(16);


        Console.WriteLine("The last value pushed was {0}", stack.Top);

        while (!stack.IsEmpty)
        {
            Console.WriteLine("Popping {0}", stack.Pop());
        }

        Console.Write("Press Enter...");
        Console.ReadLine();
    }
}