using FizzBuzz;

namespace Tests.FizzBuzzTest
{
    public class AnalyzeSingleNumberTest
    {
        public readonly FizzBuzzRunner _fizzBuzzRunner;
        public AnalyzeSingleNumberTest()
        {
            _fizzBuzzRunner = new FizzBuzzRunner();
        }

        [Fact]
        public void Should_Return_Fizz()
        {
            var fizz = _fizzBuzzRunner.AnalyzeSingleNumber(3);
            Assert.Equal("Fizz", fizz);
        }

        [Fact]
        public void Should_Return_Buzz()
        {
            var buzz = _fizzBuzzRunner.AnalyzeSingleNumber(5);
            Assert.Equal("Buzz", buzz);
        }


        [Fact]
        public void Should_Return_FizzBuzz()
        {
            var fizzBuzz = _fizzBuzzRunner.AnalyzeSingleNumber(15);
            Assert.Equal("FizzBuzz", fizzBuzz);
        }


        [Fact]
        public void Should_Return_Number_As_String()
        {
            var numberAsString = _fizzBuzzRunner.AnalyzeSingleNumber(1);
            Assert.Equal("1", numberAsString);
        }


    }
}