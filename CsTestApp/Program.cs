using System;

namespace CsTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numGenerator = new MyRandom.NumberGenerator();
            Console.WriteLine($"Unbounded Number     : {numGenerator.GetInteger()}");
            Console.WriteLine($"Bounded Number (0,10): {numGenerator.GetInteger(0,100)}");

            var messageOfTheDayGenerator = new MyRandom.MessageOfTheDayGenerator();
            Console.WriteLine($"Message: {messageOfTheDayGenerator.MessageOfTheDay()}");

        }
    }
}
