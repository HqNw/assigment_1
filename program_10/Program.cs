using System;

namespace program_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine()) + 10;
            Console.WriteLine("Your age after 10 years is :{0}",age);
        }   
    }
}
