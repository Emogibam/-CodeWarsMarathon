using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kata6
{
    public class RomanDecode
    {
        //        Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer.You don't need to validate the form of the Roman numeral.

        //Modern Roman numerals are written by expressing each decimal digit of the number to be encoded separately, starting with the leftmost digit and skipping any 0s.So 1990 is rendered "MCMXC" (1000 = M, 900 = CM, 90 = XC) and 2008 is rendered "MMVIII" (2000 = MM, 8 = VIII). The Roman numeral for 1666, "MDCLXVI", uses each letter in descending order.

        //Example:

        //RomanDecode.Solution("XXI") -- should return 21

        //https://www.codewars.com/kata/51b6249c4612257ac0000005/train/csharp
        public static int Solution(string roman)
        {
            Dictionary<char, int> romanValues = new Dictionary<char, int>()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

            int decimalValue = 0;

            for (int i = roman.Length - 1; i >= 0; i--)
            {
                int currentValue = romanValues[roman[i]];

                if (i < roman.Length - 1 && romanValues[roman[i + 1]] > currentValue)
                {
                    decimalValue -= currentValue;
                }
                else
                {
                    decimalValue += currentValue;
                }
            }

            return decimalValue;
        }
    }
}
