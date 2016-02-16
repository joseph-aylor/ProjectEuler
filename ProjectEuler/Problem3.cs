using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem3 : IProblem
    {
        public int Run()
        {
            ulong i = 600851475143;

            PrimeChecker pc = new PrimeChecker();
            var factors = pc.GetFactors(i);
            var primeFactors = factors.Where(f => pc.GetFactors(f).Count() == 2).ToList();

            return (int) primeFactors.Max();
        }
    }
}
