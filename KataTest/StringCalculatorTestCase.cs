using KataStringCalculator;
using System;
using System.Globalization;

namespace KataTest
{
    public class StringCalculatorTestCase
    {
        [Fact]
        public void AddEmptyString()
        {
            var numbers = string.Empty;
            var expected = 0;
            int result = StringCalculator.Add(numbers);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void AddSingleNumber()
        {
            var numbers = "1";
            var expected = 1;
            int result = StringCalculator.Add(numbers);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void AddTwoNumbers()
        {
            var numbers = "2,6";
            var expected = 8;
            int result = StringCalculator.Add(numbers);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void AddUnknownAmountOfNumbers()
        {
            string numbers = "2,3,5,7,11";
            int expected = 28;
            int result = StringCalculator.Add(numbers);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void AddNumbersWithLines()
        {
            var numbers = "1\n2,3";
            var expected = 6;
            int result = StringCalculator.Add(numbers);
            Console.WriteLine(result);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void AddNumbersWithCustomDelimiter()
        {
            string numbers = "//;\n1;2";
            int expected = 3;
            int result = StringCalculator.Add(numbers);
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