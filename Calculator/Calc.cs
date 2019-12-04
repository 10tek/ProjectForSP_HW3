using System;
using System.Collections.Generic;

namespace Calculator
{
    public class Calc
    {
        public List<int> GetFactorials(List<int> numbers)
        {
            for(var i = 0; i < numbers.Count; i++)
            {
                numbers[i] = CountFactorial(numbers[i]);
            }
            return numbers;
        }

        private int CountFactorial(int number)
        {
            var index = number;
            while (index > 1)
            {
                number *= --index;
            }
            return number;
        }
    }
}
