// File: RPN.cs
using System;

class Stack
{
    private int[] stack = new int[10];
    private int sp = 0;

    public void Push(int v)
    {
        stack[sp++] = v;
    }

    public int Pop()
    {
        return stack[--sp];
    }

    public int Top
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
}

class RPN // finish this RPN class
{
    private Stack stack = new Stack(); // make use of class Stack tools

    // We need a Process method that accepts a string
    // Depending on the string given by the user it has to do a process
    public void Process(string str)
    {
        // if a number is given, then store or push into the stack
        // if an operator + is given, you need to pop the last two values and add them
        // if an operator - is given, you need to pop the last two values and subtract them

        // Let's make use of switch statement to take care of all cases above

        switch (str)
        {

            case "+": // if + then pop the last two value  
                {
                    int v2 = stack.Pop();
                    int v1 = stack.Pop();

                    stack.Push(v1 + v2); //and then add them and push the result back into the stack
                    break;
                }

            case "-": // similar to above
                {
                    int v2 = stack.Pop();
                    int v1 = stack.Pop();

                    stack.Push(v1 - v2); // and then subtract them and push the result back into the stack
                    break;
                }
            default:
                {

                    int v1 = int.Parse(str);
                    stack.Push(v1);
                    break;
                }
        }
    }


    // We need a Result Property to give me the Top value in the stack
    public int Result
    {
        get
        {
            return stack.Top;
        }
    }
}

class TestClass
{
    static void Main()
    {
        RPN rpn = new RPN();

        while (true)
        {
            string str;

            Console.Write("RPN>");
            str = Console.ReadLine();

            rpn.Process(str);

            Console.WriteLine("= {0}", rpn.Result);
        }
    }
}