using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Puzzle Number: ");
            string puzzleNumber = Console.ReadLine();
            Assembly assem = typeof(Program).Assembly;

            try
            {
                IProblem problem = (IProblem)assem.CreateInstance("ProjectEuler.Problem" + puzzleNumber);

                Console.WriteLine(problem.Run());
            }
            catch(System.NullReferenceException ex)
            {
                Console.WriteLine("Could Not Find Puzzle Number " + puzzleNumber);
            }

            Console.ReadKey();
        }
    }
}
