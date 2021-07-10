using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.algorithms
{
    class Heapsort : Sortalgorithm
    {

        /// <summary>
        /// The Constructor for the Heapsort Algorithm
        /// </summary>
        /// <param name="arr">The Array to sort</param>
        /// <param name="gui">The Instance of the GUI</param>
        public Heapsort(int[] arr, int del, bool sound, gui gui) : base(del, sound, gui)
        {
            if (arr.Length < 5)
            {
                throw new Exception("Array has too few Entries");
            }
            toSort = arr;
        }

        protected override int sort()
        {
            //Build the Initial max-heap (rearranging the array)
            for(int i = toSort.Length/2-1; i >= 0; i--) 
            {
                max_heapyfy(toSort.Length, i);
            }

            //rebuild the max-heap for the non sorted keys
            for (int i = toSort.Length-1; i > 0; i--)
            {
                //if (token.IsCancellationRequested) return 2; // To Properly Cancel a Sort
                swap(0, i);
                max_heapyfy(i, 0);
            }
            return 1;
        }

        /// <summary>
        /// Max-Heapifys the Array
        /// </summary>
        /// <param name="length">The Last Index of the Array to heapify</param>
        /// <param name="large">The Largest Key</param>
        protected void max_heapyfy(int length,int large)
        {
            int largest = large;
            int l = 2 * large + 1; // left = 2*i + 1 //Some Formula i found which seems to find the Left Child
            int r = 2 * large + 2; // right = 2*i + 2 //The Same but with right Node

            if (l < length && toSort[l] > toSort[largest]) largest = l; //Check if Left Child Node's key is Larger and if, set it's Index As Largest // And check if it is larger than the length
            if (r < length && toSort[r] > toSort[largest]) largest = r; // The Same for the Right Child Node

            if(largest != large)
            {
                // if (token.IsCancellationRequested) return; // To Properly Cancel a Sort
                swap(large, largest); //When the Parent isn't the Largest Node Swap them, so the Paren't now is the Largest
                max_heapyfy(large, largest); //Do The Same for the next Nodes
            }
        }
    }
}
