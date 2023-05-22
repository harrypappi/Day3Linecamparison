using System;

public class Line : IComparable<Line>
{
    public Point Start { get; }
    public Point End { get; }

    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    public int CompareTo(Line other)
    {
        if (other == null)
            return 1;

        int startComparison = Start.CompareTo(other.Start);
        if (startComparison != 0)
            return startComparison;

        return End.CompareTo(other.End);
    }
}

public class Point : IComparable<Point>
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int CompareTo(Point other)
    {
        if (other == null)
            return 1;

        int xComparison = X.CompareTo(other.X);
        if (xComparison != 0)
            return xComparison;

        return Y.CompareTo(other.Y);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Point start1 = new Point(1, 2);
        Point end1 = new Point(3, 4);
        Line line1 = new Line(start1, end1);

        Point start2 = new Point(1, 2);
        Point end2 = new Point(5, 6);
        Line line2 = new Line(start2, end2);

        int comparison = line1.CompareTo(line2);
        if (comparison < 0)
            Console.WriteLine("Line 1 is less than Line 2");
        else if (comparison > 0)
            Console.WriteLine("Line 1 is greater than Line 2");
        else
            Console.WriteLine("Line 1 is equal to Line 2");
    }
}
