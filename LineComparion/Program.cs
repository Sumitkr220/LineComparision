﻿using System;

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

            Console.WriteLine("Enter value of x3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of y3");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of x4");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of y4");
            int y4 = Convert.ToInt32(Console.ReadLine());

            int x = (x2 - x1) * (x2 - x1);
            int y = (y2 - y1) * (y2 - y1);

            int xx = (x4 - x3) * (x4 - x3);
            int yy = (y4 - y3) * (y4 - y3);

            double Length_Of_Line1 = Math.Sqrt(x + y);
            double Length_Of_Line2 = Math.Sqrt(xx + yy);

            Boolean b = Length_Of_Line1.Equals(Length_Of_Line2);
            if (b)
            {
                Console.WriteLine("Both Lines are equal");
            }
            else

                Console.WriteLine("Both lines are not equal");


        }
    }
}
