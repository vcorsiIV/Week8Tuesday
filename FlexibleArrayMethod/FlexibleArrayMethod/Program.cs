using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//Writing this as a console as it is not that complex for a GUI
//As a GUI it would be press button and print 3 or more arrays to a label
//as well as the sum of the values.

namespace FlexibleArrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = { 4, 7, 8, 9, 10, 11, 6 };
            FlexibleArrayMethod(arrayA);
            int[] arrayB = { 5, 7, 111, 5, 1 };
            FlexibleArrayMethod(arrayB);
            int[] arrayC = { 100, 1 };
            FlexibleArrayMethod(arrayC);

        }

        private static void FlexibleArrayMethod(int[] vals)
        {
            int x, total;
            total = 0;
            Write("Here is the values for this array:\n");
            for (x = 0; x < vals.Length; ++x)
            {
                total += vals[x];
                Write("\t{0}\t", vals[x]);
            }
            WriteLine("\nThe sum of this array is:\t{0}", total);
        }
    }
}
