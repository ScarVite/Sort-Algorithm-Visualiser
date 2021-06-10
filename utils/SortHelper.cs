using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.utils
{
    class SortHelper
    {
         static Random rand = new Random();

        /// <summary>
        /// Generate the Array Containing Random ints
        /// </summary>
        /// <param name="length">The length of the array</param>
        /// <returns>Array containing random numbers</returns>
        public int[] getArray(int length)
        {
            int[] toSort = new int[length];
            for (int i = 0; i < length; i++)
            {
                toSort[i] = rand.Next(0, 1050);
            }
            Console.WriteLine("Unsorted: [{0}]", string.Join(", ", toSort));
            return toSort;
        }
    }
}
