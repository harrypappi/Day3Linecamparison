using System;

public class Line
{
    public Point Start { get; }
    public Point End { get; }

    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    public bool Equals(Line other)
    {
        if (other == null)
            return false;

        return (Start.Equals(other.Start) && End.Equals(other.End)) ||
               (Start.Equals(other.End) && End.Equals(other.Start));
    }
}

public class Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool Equals(Point other)
    {
        if (other == null)
            return false;

        return X == other.X && Y == other.Y;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Point start1 = new Point(1, 2);
        Point end1 = new Point(3, 4);
        Line line1 = new Line(start1, end1);

        Point start2 = new Point(3, 4);
        Point end2 = new Point(1, 2);
        Line line2 = new Line(start2, end2);

        bool areEqual = line1.Equals(line2);
        Console.WriteLine(areEqual); 
    }
}
