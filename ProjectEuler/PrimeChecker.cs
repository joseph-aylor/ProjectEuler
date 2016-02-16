using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class PrimeChecker
    {
        private List<ulong> Primes { get; }

        private Dictionary<ulong, List<ulong>> Factorized { get; }

        public PrimeChecker()
        {
            Primes = new List<ulong>();
            Factorized = new Dictionary<ulong, List<ulong>>();
        }

        public List<ulong> GetFactors(ulong number)
        {
            if (Factorized.Keys.Contains(number))
            {
                return Factorized[number];
            }

            List<ulong> factors = new List<ulong>();
            ulong maximum = number;
            for( ulong i = 1; i < maximum; i++)
            {
                if( number % i == 0)
                {
                    factors.Add(i);
                    factors.Add(number / i);
                }
                maximum = number / i;
            }

            Factorized.Add(number, factors);

            return factors;
        }

        bool isPrime(ulong number)
        {
            return GetFactors(number).Count() == 2;
        }
    }
}
