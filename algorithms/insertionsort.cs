using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.algorithms
{
    class Insertionsort : Sortalgorithm
    {

        /// <summary>
        /// The Constructor for the Insertionsort Algorithm
        /// </summary>
        /// <param name="arr">The Array to sort</param>
        /// <param name="gui">The Instance of the GUI</param>
        public Insertionsort(int[] arr, int del, bool sound, gui gui) : base(del, sound, gui)
        {
            if (arr.Length < 5)
            {
                throw new Exception("Array has too few Entries");
            }
            toSort = arr;
        }

        protected override int sort()
        {
            for (int i = 1; i <= toSort.Length - 1; i++) // i is our "Safe space" which means, every index left of i is sorted
            {
                if (toSort[i-1] > toSort[i])
                {
                    int temp = toSort[i]; // Carry over our current key
                    for (int b = i-1;b >= 0; b--)
                    {
                        if (toSort[b] > temp)
                        {
                            toSort[b + 1] = toSort[b]; //carry the largest key with us and set it as the new index
                            if (b == 0) toSort[b] = temp; //if we are at the last index and it larger, write the key there
                        }
                        else
                        {
                            toSort[b+1] = temp; // write the key on the new index
                            b = -1; // end the loop
                        }
                    }
                    if (token.IsCancellationRequested) return 2; // To Properly Cancel a Sort
                    totalSorts++;
                    mainGui.update(toSort, totalSorts);
                    Thread.Sleep(delay);
                }
            }
            return 1;
        }
    }
}
