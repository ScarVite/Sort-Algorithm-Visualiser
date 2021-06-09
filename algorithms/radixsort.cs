using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.algorithms
{
    class Radixsort : Sortalgorithm
    {
        private int[][] split;
        int maxLength;

        /// <summary>
        /// The Constructor for the Radixsort Algorithm
        /// </summary>
        /// <param name="arr">The Array to sort</param>
        public Radixsort(int[] arr)
        {
            if (arr.Length < 5)
            {
                throw new Exception("Array has too few Entries");
            }
            toSort = arr;
            split = new int[toSort.Length][];
        }

        protected override int sort()
        {
            maxLength = getMax();
            //split each key of the array into an seperate array
            for (int i = 0; i < toSort.Length; i++)
            {
                split[i] = new int[maxLength];
                splitArray(i);
                //Console.WriteLine("[{0}]", string.Join(", ", split[i]));
            }
            //Compare each key of the new array
            for (int i = maxLength-1; i >= 0; i--) // Go through every subarray
            { //Buggy
                sorted = false;
                while (!sorted)
                {
                    int sorts = 0;
                    Console.WriteLine("i: {0}", i);
                    for (int a = 1; a < toSort.Length; a++) // go thorugh the main array
                    {
                        Console.WriteLine("a: {0}", a);
                        if (split[a][i] > split[a][i])
                        {
                            swap(a - 1, a);
                            sorts++;
                        }
                    }
                    if (sorts == 0) sorted = true;
                }
            }
            //[[0,1,0],[0,0,8],[0,9,9],[1,0,5],[0,7,5]]
            //[[0,1,0],[0,0,8],[1,0,5],[0,7,5],[0,9,9]]
            //[[0,1,0],[1,0,5],[0,0,8],[0,7,5],[0,9,9]]
            //[[0,1,0],[0,0,8],[0,7,5],[0,9,9],[1,0,5]]
            return 1;
        }

        private int getMax()
        {
            int max = 0;
            foreach (int value in toSort)
            {
                if (value.ToString().Length > max) max = value.ToString().Length;
            }
            //Console.WriteLine("max: {0}", max);
            return max;
        }

        private void splitArray(int index)
        {
            //Select Simmilar to .map (js)
            //Console.WriteLine("split before: [{0}]", string.Join(", ", split[index]));
            int[] intarr = toSort[index].ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
            //Console.WriteLine("intarr: [{0}]", string.Join(", ", intarr));
            for (int i = 0; i < maxLength; i++)
            {
                try
                {
                    int len = intarr.Length;
                    // The problem was i needed to check if the length was a multiple of the maxLength and if it was exactly maxLength else we took the modulo value
                    int off = maxLength % len == 0 ? maxLength == len ? 0 : len == 1 ? maxLength-1 : (int) Math.Ceiling((double) (maxLength / len)) : maxLength % len;
                    split[index][i + off] = intarr[i];
                }
                catch (IndexOutOfRangeException e)
                {
                    //Console.WriteLine(e);
                }

            }
            Console.WriteLine("split after: [{0}]", string.Join(", ", split[index]));
        }
    }
}
