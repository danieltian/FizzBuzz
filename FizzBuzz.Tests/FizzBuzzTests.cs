using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void FizzBuzz_GetOutput_Method_Returns_Fizz_When_Number_Is_Divisible_By_Only_3()
        {
            Assert.That(FizzBuzz.GetOutput(3), Is.StringMatching("Fizz"));
            Assert.That(FizzBuzz.GetOutput(6), Is.StringMatching("Fizz"));
            Assert.That(FizzBuzz.GetOutput(9), Is.StringMatching("Fizz"));
        }

        [Test]
        public void FizzBuzz_GetOutput_Method_Returns_Buzz_When_Number_Is_Divisible_By_Only_5()
        {
            Assert.That(FizzBuzz.GetOutput(5), Is.StringMatching("Buzz"));
            Assert.That(FizzBuzz.GetOutput(10), Is.StringMatching("Buzz"));
            Assert.That(FizzBuzz.GetOutput(20), Is.StringMatching("Buzz"));
        }

        [Test]
        public void FizzBuzz_GetOutput_Method_Returns_FizzBuzz_When_Number_Is_Divisible_By_3_And_5()
        {
            Assert.That(FizzBuzz.GetOutput(15), Is.StringMatching("FizzBuzz"));
            Assert.That(FizzBuzz.GetOutput(30), Is.StringMatching("FizzBuzz"));
            Assert.That(FizzBuzz.GetOutput(45), Is.StringMatching("FizzBuzz"));
        }

        [Test]
        public void FizzBuzz_GetOutput_Method_Returns_Number_When_Number_Is_Not_Divisible_By_3_Or_5()
        {
            Assert.That(FizzBuzz.GetOutput(7), Is.StringMatching("7"));
            Assert.That(FizzBuzz.GetOutput(17), Is.StringMatching("17"));
            Assert.That(FizzBuzz.GetOutput(1), Is.StringMatching("1"));
        }
    }
}
