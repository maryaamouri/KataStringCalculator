using KataStringCalculator;

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
    }
}