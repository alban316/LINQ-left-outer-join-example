using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iLeft = { 1, 2, 3 };
            int[] iRight = { 3, 4, 5 };

            List<int> left = iLeft.ToList();
            List<int> right = iRight.ToList();

            var q = (
                from l in left
                join r in right on l equals r into leftright
                from lr in leftright.DefaultIfEmpty()
                where lr == 0
                select l).ToList();

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}

/*



*/