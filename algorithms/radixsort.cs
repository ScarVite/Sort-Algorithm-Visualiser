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
        /// <param name="del">The Delay for the Algorithm between each sort</param>
        /// <param name="sound">Wether Sound should be played</param>
        /// <param name="gui">The Instance of the GUI</param> 
        public Radixsort(int[] arr, int del, bool sound, gui gui) : base(del, sound, gui)
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
            }
            //Compare each key of the new array
            for (int i = maxLength-1; i >= 0; i--) // Go through every subarray
            { 
                sorted = false;
                while (!sorted)
                {
                    int sorts = 0;
                    for (int a = 1; a < toSort.Length; a++) // go thorugh the main array
                    {
                        totalCompars++; // Inc Comparisons
                        if (split[a-1][i] > split[a][i])
                        {
                            if (token.IsCancellationRequested) return 2; // To Properly Cancel a Sort
                            swapSplit(a - 1, a);
                            sorts++;
                        }
                    }
                    totalCompars++; // Inc Comparisons
                    if (sorts == 0) sorted = true;
                }
            }
            return 1;
        }

        /// <summary>
        /// Swaps the given Indexes keys in both array
        /// </summary>
        /// <param name="i">first index</param>
        /// <param name="j">second index</param>
        private void swapSplit(int i, int j)
        {
            swap(i, j);

            int[] temp = split[i];
            split[i] = split[j];
            split[j] = temp;
        }

        /// <summary>
        /// Calculates Max Length of the arrays keys
        /// </summary>
        /// <returns>Max Length of the arrays keys</returns>
        private int getMax()
        {
            int max = 0;
            foreach (int value in toSort)
            {
                totalCompars++; // Inc Comparisons
                if (value.ToString().Length > max) max = value.ToString().Length;
            }
            return max;
        }

        /// <summary>
        /// Splits the int at the given index and inserts it into the array
        /// </summary>
        /// <param name="index">index</param>
        private void splitArray(int index)
        {
            //Select Simmilar to .map (js)
            int[] intarr = toSort[index].ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
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
        }
    }
}
