using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataStringCalculator
{
    public static class StringCalculator
    {
         public static int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            string[] numberArray = numbers.Split(',');

            int sum = 0;
            foreach (string num in numberArray)
            {
                if (int.TryParse(num, out int parsedNum))
                {
                    sum += parsedNum;
                }
                else
                {
                    continue;
                }
                
            }

            return sum;
        }
    }
}
