using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem1 : IProblem
    {
        public int Below
        {
            get; set;
        }

        public Problem1()
        {
            Below = 1000;
        }

        public int Run()
        {
            IEnumerable<int> multiplesOfThreeOrFive = Enumerable.Range(1, Below - 1).Where(n => n % 3 == 0 || n % 5 == 0);
            return multiplesOfThreeOrFive.Aggregate(0, (sum, n) => sum + n);
        }
    }
}
