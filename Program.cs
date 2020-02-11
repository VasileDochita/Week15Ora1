using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        private static int element;

        static void Main(string[] args)
        {
            List<int> number = new List<int>();

            HashSet<int> numbers = new HashSet<int>();

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            for (int i = 0; i < 10000000; i++)
            {
                number.Add(i);
            }

            for (int i = 0; i < number.Count; i++)
            {
                if (i > 100000 && i < 200000)
                {
                    element = i;
                }
            }

            stopwatch.Stop();

            Console.WriteLine("Time elapsed  is {0} ", stopwatch.Elapsed);

        }

    }
}
