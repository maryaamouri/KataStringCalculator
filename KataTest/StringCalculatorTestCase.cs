using KataStringCalculator;
using Xunit;
namespace KataTest
{
    public class StringCalculatorTestCase
    {
        [Fact]
        public void AddEmptyString()
        {
            var numbers = string.Empty;
            var expected = 0;
            var result = StringCalculator.Add(numbers);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void AddSingleNumber()
        {
            var numbers = "1";
            var expected = 1;
            var result = StringCalculator.Add(numbers);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void AddTwoNumbers()
        {
            var numbers = "2,6";
            var expected = 8;
            var result = StringCalculator.Add(numbers);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void AddUnknownAmountOfNumbers()
        {
            var numbers = "2,3,5,7,11";
            var expected = 28;
            var result = StringCalculator.Add(numbers);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void AddNumbersWithLines()
        {
            var numbers = "1\n2,3";
            var expected = 6;
            var result = StringCalculator.Add(numbers);
            Console.WriteLine(result);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void AddNumbersWithCustomDelimiter()
        {
            var numbers = "//;\n1;2";
            var expected = 3;
            var result = StringCalculator.Add(numbers);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void NegativeNumbersNotAllowd()
        {
            var numbers = "1,4,-1";
            var exception =Assert.Throws<ArgumentException>(() => StringCalculator.Add(numbers)); 
            Assert.Equal("Negatives not allowed: -1", exception.Message);
        }
        [Fact]
        public void IgnoreLargNumbers() 
        {
            var numbers = "2,1001";
            var result = StringCalculator.Add(numbers);
            var expected = 2;
            Assert.Equal(expected, result);
        }
    }
}