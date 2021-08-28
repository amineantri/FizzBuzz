using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzer fb = new FizzBuzzer();
            for(int i = 0; i < 101; i++)
            {
                Console.WriteLine(fb.Transform(i));
            }
            Console.ReadKey();
        }
    }
}
