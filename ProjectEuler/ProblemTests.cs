using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class ProblemTests : IProblem
    {
        public int Run()
        {
            Console.WriteLine("Prime Checker");
            PrimeChecker pc = new PrimeChecker();
            for (ulong v = 1; v < 5000; v++)
            {
                var factorList = pc.GetFactors(v);
                factorList.Sort();
                Console.WriteLine(factorList.Aggregate("", (disp, val) => disp + val.ToString() + ","));
            }

            return 1337;
        }
    }
}
