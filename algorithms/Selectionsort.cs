using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.algorithms
{
    class Selectionsort : Sortalgorithm
    {

        /// <summary>
        /// The Constructor for the Selectionsort Algorithm
        /// </summary>
        /// <param name="arr">The Array to sort</param>
        /// <param name="gui">The Instance of the GUI</param>
        public Selectionsort(int[] arr, int del, bool sound, gui gui) : base(del, sound, gui)
        {
            if (arr.Length < 5)
            {
                throw new Exception("Array has too few Entries");
            }
            toSort = arr;
        }

        protected override int sort()
        {
            for(int i = 0; i < toSort.Length; i++)
            {
                int minInd = i; // Set the index for the smallest Value
                for (int a = i; a < toSort.Length; a++)
                {
                    if (toSort[minInd] > toSort[a]) minInd = a; // Set The new Index if it's smaller
                }
                if (token.IsCancellationRequested) return 2; // To Properly Cancel a Sort
                if (minInd != i) swap(minInd, i); // Swap if it's not the first index
            }
            return 1;
        }

    }
}
