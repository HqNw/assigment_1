using System;

namespace program_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r =new Random();
            int answer = 1 + (r.Next() % 100);
            int  g;
            
            System.Console.WriteLine(answer);

            do{
                Console.WriteLine("Guess a number");
                g = int.Parse(Console.ReadLine());
                if (g > answer)
                    Console.WriteLine("Too large");
                else if(g < answer)
                    Console.WriteLine("Too small");
            }while(g != answer);
            Console.WriteLine("That's correct");
        }   
    }
}
