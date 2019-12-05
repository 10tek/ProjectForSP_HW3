using System;
using System.Collections.Generic;

namespace Calculator
{
    public class Calc
    {
        public List<long> GetFactorials(List<long> numbers)
        {
            for(var i = 0; i < numbers.Count; i++)
            {
                numbers[i] = CountFactorial(numbers[i]);
            }
            return numbers;
        }

        private long CountFactorial(long number)
        {
            if (number == 0) return 1;
            var index = number;
            while (index > 1)
            {
                number *= --index;
            }
            return number;
        }
    }
}
