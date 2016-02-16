using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class FibonacciGenerator
    {
        public List<int> Numbers { get; }

        public FibonacciGenerator(int maxValue)
        {
            int ordinal = 0;

            Numbers = new List<int>();

            int number = getFibonacciNumber(ordinal);

            while( number < maxValue)
            {
                Numbers.Add(number);
                ordinal += 1;
                number = getFibonacciNumber(ordinal);
            }

        }

        private int getFibonacciNumber(int ordinal)
        {
            if (Numbers.Count < ordinal)
            {
                return Numbers[ordinal];
            }

            if(ordinal == 1)
            {
                return 2;
            }

            if(ordinal == 0)
            {
                return 1;
            }

            return getFibonacciNumber(ordinal - 1) + getFibonacciNumber(ordinal - 2);
        }
    }
}
