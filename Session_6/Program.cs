// File: Point3.cs
using System;

class Point
{
    private int X;
    private int Y;

    // public Constructor
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void GetPointByVal(int x, int y)
    {
        x = X;
        y = Y;
    }
    public void GetPointByRef(ref int x, ref int y)
    {
        x = X;
        y = Y;
    }
    public void GetPointByOut(out int x, out int y)
    {
        x = X;
        y = Y;
    }
}

class TestPoint3Class
{
    static void Main()
    {
        Point pt = new Point(10, 20);

        int px = 0;
        int py = 0;
        pt.GetPointByVal(px, py);
        Console.WriteLine("{0},{1}", px, py);

        int x = 0;
        int y = 0;
        pt.GetPointByRef(ref x, ref y);
        Console.WriteLine("{0},{1}", x, y);

        int ox;
        int oy;
        pt.GetPointByOut(out ox, out oy);
        Console.WriteLine("{0},{1}", ox, oy);

        Console.ReadLine();
    }
}