using System;

namespace program_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer number: ");
            uint num = uint.Parse(Console.ReadLine());
            uint divider = 2;
            uint maxDivider = (uint) Math.Sqrt(num);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (num % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine("Prime? {0}",prime);           
        }
    }
}