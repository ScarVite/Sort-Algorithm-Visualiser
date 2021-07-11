using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.algorithms
{
    class Bogosort: Sortalgorithm
    {

        private Random rand = new Random();

        /// <summary>
        /// The Constructor for the Bogosort Algorithm
        /// </summary>
        /// <param name="arr">The Array to sort</param>
        /// <param name="del">The Delay for the Algorithm between each sort</param>
        /// <param name="sound">Wether Sound should be played</param>
        /// <param name="gui">The Instance of the GUI</param> 
        public Bogosort(int[] arr, int del, bool sound, gui gui) : base(del, sound, gui)
        {
            if (arr.Length < 5)
            {
                throw new Exception("Array has too few Entries");
            }
            toSort = arr;
        }

        protected override int sort()
        {
            do
            {
                for (int i = 0; i < toSort.Length; i++)
                {
                    if (token.IsCancellationRequested) return 2; // To Properly Cancel a Sort
                    swap(i, rand.Next(0, toSort.Length)); //Randomly Shuffle everthing
                }
                isSorted(); //refresh sorted
            } while (!sorted); //while not sorted
            return 1;
        }

        /// <summary>
        /// Checks if the Array is Sorted an Updates sorted
        /// </summary>
        private void isSorted()
        {
            sorted = true;
            for(int i = 0; i < toSort.Length-1;i++)
            {
                totalCompars++; // Inc Comparisons
                if (toSort[i] > toSort[i + 1]) sorted = false;
            }
        }
    }
}
