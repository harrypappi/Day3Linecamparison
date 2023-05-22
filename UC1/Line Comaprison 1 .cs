using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int attendance = random.Next(2);
        if (attendance == 1)
        {
            Console.WriteLine("Employee is present.");
        }
        else
        {
            Console.WriteLine("Employee is absent.");
        }
    }
}
