using System;
using FizzBuzz;
namespace PrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate FizzBuzzRunner Class with default values
            FizzBuzzRunner fizzBuzz = new FizzBuzzRunner(3,"Fizz", 5,"Buzz");

            //Run fizzbuzz with upper bounds initalized at 100
            Console.Write(fizzBuzz.Run(100));

        }
    }
}
