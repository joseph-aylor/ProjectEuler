using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem4 : IProblem
    {

        public int Run()
        {
            List<int> firstThreeDigits = Enumerable.Range(100, 900).ToList();

            List<int> secondThreeDigits = Enumerable.Range(100, 900).ToList();

            firstThreeDigits.Reverse();
            secondThreeDigits.Reverse();

            int maxPalindrome = 0;

            // Too many loops, learn to LINQ
            while(firstThreeDigits.Count >= 1)
            {
                foreach(int secondNumber in secondThreeDigits)
                {
                    int product = firstThreeDigits[0] * secondNumber;

                    //EW! Refactor this.
                    if(product.ToString() == new string(product.ToString().ToCharArray().Reverse().ToArray())
                        && product > maxPalindrome)
                    {
                        maxPalindrome = product;
                    }
                }
                firstThreeDigits.RemoveAt(0);
                secondThreeDigits.RemoveAt(0);
            }

            return maxPalindrome;
        }
    }
}
