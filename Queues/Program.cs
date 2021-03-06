﻿// Arrays_Queue.cs

using System;

class Queue
{
    private const int defValue = 10;
    private int[] array;
    private int head = 0;
    private int tail = 0;
    private int count = 0;

    public Queue() : this(defValue)
    {
    }

    public Queue(int initialSize)
    {
        array = new int[initialSize];
        head = 0;
        tail = 0;
    }

    public int Count
    {
        get
        {
            return count;
        }
    }

    public void Enqueue(int v) // adds to the tail
    {
        if (count + 1 >= array.Length)
        {
            throw new IndexOutOfRangeException();
        }

        count++;
        array[tail++] = v;

        if (tail >= array.Length)
        {
            tail = 0;
        }
    }

    public int Dequeue() //process from the head
    {
        // Check if empty
        if (head == tail) // if empty nothing to do, warn the user
        {
            throw new IndexOutOfRangeException();
        }

        count--;
        int v = array[head++]; // store the value of where the head is and then move head by one

        if (head >= array.Length)
        {
            head = 0;
        }

        return v; // give me the stored value
    }
}

class Arrays_Queue
{
    static void Main()
    {
        Queue q = new Queue();

        q.Enqueue(5);
        q.Enqueue(3);
        q.Enqueue(13);
        q.Enqueue(8);
        q.Enqueue(2);
        q.Enqueue(1);

        while (q.Count > 0)
        {
            Console.WriteLine("Dequeue {0} ", q.Dequeue());
        }
        Console.WriteLine();

        // Do this again to see how
        // head and tail are wrapping around the array.
        q.Enqueue(15);
        q.Enqueue(13);
        q.Enqueue(113);
        q.Enqueue(18);
        q.Enqueue(12);
        q.Enqueue(11);

        while (q.Count > 0)
        {
            Console.WriteLine("Dequeue {0} ", q.Dequeue());
        }
        Console.WriteLine();

        Console.Write("Press Enter...");
        Console.ReadLine();
    }
}