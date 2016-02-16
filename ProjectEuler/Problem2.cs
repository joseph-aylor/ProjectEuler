using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem2 : IProblem
    {
        public int Run()
        {
            FibonacciGenerator gen = new FibonacciGenerator(4000000);

            IEnumerable<int> evenFibs = gen.Numbers.Where(f => f % 2 == 0);

            return evenFibs.Aggregate(0, (sum, f) => sum + f);
        }
    }
}
