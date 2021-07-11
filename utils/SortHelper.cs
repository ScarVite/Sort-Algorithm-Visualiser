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
        /// <param name="min_value">The Minimal Value for a Value</param>
        /// <param name="max_value">The Maximum Value for a Value</param>
        /// <returns>Array containing random numbers</returns>
        public int[] getRandArray(int length, int min_value, int max_value)
        {
            int[] toSort = new int[length];
            for (int i = 0; i < length; i++)
            {
                toSort[i] = rand.Next(min_value, max_value);
            }
            //Console.WriteLine("Unsorted: [{0}]", string.Join(", ", toSort));
            return toSort;
        }

        /// <summary>
        /// Generates an Already Sorted Array
        /// </summary>
        /// <param name="length">The length of the Array</param>
        /// <returns>A Already Sorted Array</returns>
        public int[] getSortedArray(int length)
        {
            int[] toSort = new int[length];
            for (int i = 0; i < length; i++)
            {
                toSort[i] = i;
            }
            //Console.WriteLine("Unsorted: [{0}]", string.Join(", ", toSort));
            return toSort;
        }

        /// <summary>
        /// Generates an Reverse Sorted Array (Highest First, Smallest Last)
        /// </summary>
        /// <param name="length">The length of the Array</param>
        /// <returns>The Reverse Sorted Array</returns>
        public int[] getReverseSortedArray(int length)
        {
            int[] toSort = new int[length];
            for (int i = 0; i < length; i++)
            {
                toSort[i] = length-i;
            }
            //Console.WriteLine("Unsorted: [{0}]", string.Join(", ", toSort));
            return toSort;
        }
    }
}
