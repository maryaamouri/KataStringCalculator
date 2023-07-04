namespace KataStringCalculator
{
    public static class StringCalculator
    {
         public static int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;
            var delimiter = ',';
            var negatives = new List<int>();
            if (numbers.StartsWith("//"))
            {
                delimiter = numbers[2];
                numbers = numbers.Substring(2);
            }
            var numberArray = numbers.Split(delimiter, '\n');
            var sum = 0;
            foreach (string num in numberArray)
            {
                if (int.TryParse(num, out int parsedNum))
                {
                    if(parsedNum < 0)
                    {
                        negatives.Add(parsedNum);
                    }
                    else
                    {
                        if (parsedNum > 1000)
                            continue;
                        sum += parsedNum;
                    }
                }
                else
                {
                    continue;
                }
            }
            if (negatives.Count > 0)
            {
                throw new ArgumentException(
                    $"Negatives not allowed: {string.Join(", ", negatives)}"
                    );
            }
            return sum;
        }
    }
}
