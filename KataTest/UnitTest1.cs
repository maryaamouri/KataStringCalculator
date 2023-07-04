using KataStringCalculator;

namespace KataTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddEmptyString()
        {
            var numbers = string.Empty;
            var expected = 0;
            int result = StringCalculator.Add(numbers);
            Assert.Equal(expected, result);
        }
    }
}