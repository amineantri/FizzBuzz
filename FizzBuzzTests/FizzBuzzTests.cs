using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(1,"1")]
        [TestCase(2,"2")]
        [TestCase(3,"Fizz")]
        [TestCase(5,"Buzz")]
        [TestCase(6,"Fizz")]
        [TestCase(10,"Buzz")]
        [TestCase(15,"FizzBuzz")]
        public void FizzBuzzGibenIntExpectString(int input, string expected)
        {
            FizzBuzzer fizzBuzz = new FizzBuzzer();
            string actual = fizzBuzz.Transform(input);
            Assert.AreEqual(actual, expected);
        }
    }
}