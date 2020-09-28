using System;

namespace LineComparion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            int x = (x2 - x1) * (x2 - x1);
            int y = (y2 - y1) * (y2 - y1);

            double Length_Of_Line = Math.Sqrt(x + y);

            Console.WriteLine(Length_Of_Line);
        }
    }
}
