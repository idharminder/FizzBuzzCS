using System;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main()
        {
            var myFizzBuzzer = new FizzBuzzer();
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(myFizzBuzzer.FizzBuzz(i));
            }

        }
    }
}
