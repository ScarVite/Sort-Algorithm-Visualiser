using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.algorithms
{
    class Bubblesort: Sortalgorithm
    {

        /// <summary>
        /// The Constructor for the Bubblesort Algorithm
        /// </summary>
        /// <param name="arr">The Array to sort</param>
        /// <param name="gui">The Instance of the GUI</param>
        public Bubblesort(int[] arr, int del, bool sound, gui gui) : base(del, sound, gui)
        {
            if(arr.Length < 5)
            {
                throw new Exception("Array has too few Entries"); 
            }
            toSort = arr;
        }

        protected override int sort()
        {
            while(!sorted) //Check if Array is Sorted
            {
                int sorts = 0; // Count the Sorts
                for(int i = 0; i < toSort.Length-1; i++)
                {
                    if(toSort[i] > toSort[i+1]) 
                    {
                        if (token.IsCancellationRequested) return 2; // To Properly Cancel a Sort
                        swap(i, i + 1); //We always carry the largest key over
                        sorts++;
                    }
                }
                if (sorts == 0) sorted = true; // When we completed without sorting we are done. //Seperate check after running is also run
            }
            return 1;
        }
    }
}
