using System;

namespace kRaisedToThePowerOfKEqualsN
{
    class Program
    {
        // https://edabit.com/challenge/jxQTbif5fx7J8FeTT
        // SOLVED

        static void Main(string[] args)
        {
            var x = new Calc("4", 2);
            Console.Write(x.IsSquare());
        }
    }
}
