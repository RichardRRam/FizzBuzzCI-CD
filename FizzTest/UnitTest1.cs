using NUnit.Framework;
using FizzBuzz;
namespace Tests
{
    public class Tests
    {
        public FizzBuzzRunner fizzDefault;
        public FizzBuzzRunner fizzDivisible;
        public FizzBuzzRunner fizzNegativeDivisors;
        public FizzBuzzRunner fizzRun;
        [SetUp]
        public void Setup()
        {
            //Set up different instances of FizzBuzzRunner for the different edge cases
            fizzDefault = new FizzBuzzRunner(3, "Fizz", 5,"Buzz");
            fizzDivisible = new FizzBuzzRunner(0, "Fizz", 0, "Buzz");
            fizzNegativeDivisors = new FizzBuzzRunner(-3, "Fizz", -5, "Buzz");
            fizzRun = new FizzBuzzRunner(2, "Foo", 3, "Bar");
        }

        [Test]
        public void DivisibleBy15()
        {
            Assert.AreEqual("FizzBuzz", fizzDefault.getString(15));
        }

        [Test]
        public void DivisibleBy3()
        {
            Assert.AreEqual("Fizz", fizzDefault.getString(3));
        }

        [Test]
        public void DivisibleBy5()
        {
            Assert.AreEqual("Buzz", fizzDefault.getString(5));
        }

        [Test]
        public void DivideByZero()
        {
            Assert.AreEqual("Fizz", fizzDivisible.getString(3));
            Assert.AreEqual("Buzz", fizzDivisible.getString(5));
            Assert.AreEqual("FizzBuzz", fizzDivisible.getString(15));
        }

        [Test]
        public void DivideByNegative()
        {
            Assert.AreEqual("Fizz", fizzNegativeDivisors.getString(3));
            Assert.AreEqual("Buzz", fizzNegativeDivisors.getString(5));
            Assert.AreEqual("FizzBuzz", fizzNegativeDivisors.getString(15));
        }

        [Test]
        public void UpperBoundsZero()
        {
            Assert.AreEqual("1", fizzDefault.Run(0).Trim());
            
        }

        [Test]
        public void UpperBoundsNegative()
        {
            Assert.AreEqual("1", fizzDefault.Run(-1).Trim());
        }

        [Test]
        public void UpperBoundsOne()
        {
            Assert.AreEqual("1", fizzDefault.Run(1).Trim());
        }

        [Test]
        public void RunTest()
        {
            Assert.AreEqual("1\nFoo\nBar\nFoo\n5\nFooBar\n", fizzRun.Run(6));
        }
    }
}