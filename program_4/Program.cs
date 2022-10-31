using System;

namespace program_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,t,s;

            Console.WriteLine("Enter a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter t:");
            t = double.Parse(Console.ReadLine());

            s = a*t*t/2.0;
            Console.WriteLine("Distance = {0}",s);
        }
    }
}