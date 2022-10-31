using System;

namespace program_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1416;

            int radius;
            double area;

            radius = int.Parse(Console.ReadLine());
            area = pi*radius*radius;
            Console.WriteLine(area);
        }
    }
}
