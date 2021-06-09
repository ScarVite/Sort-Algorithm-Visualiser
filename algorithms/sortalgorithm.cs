using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.algorithms
{
    abstract class Sortalgorithm
    {

        protected Stopwatch watch = new Stopwatch();
        protected int[] toSort;
        protected bool sorted = false;
        protected int totalSorts = 0;

        /// <summary>
        /// Starts The Sort Algorithm.
        /// </summary>
        public async void startSort()
        {
            int result = 0;
            watch.Start();
            await Task.Run(() => result = sort());
            if (result != 1) Console.WriteLine("CERNEL PAGE FAULT, CODE: {0}", result); 
            watch.Stop();
            Console.WriteLine("Array: [{0}]; TotalSorts: {1}; Time: {2}", string.Join(", ", toSort), totalSorts, watch.Elapsed.TotalMilliseconds);
        }

        /// <summary>
        /// Swaps two given index keys
        /// </summary>
        /// <param name="i">The First Index</param>
        /// <param name="j">The Second Index</param>
        protected void swap(int i, int j)
        {
            totalSorts++;
            int temp = toSort[i];
            toSort[i] = toSort[j];
            toSort[j] = temp;
        }

        /// <summary>
        /// Includes the main Sortlogic
        /// </summary>
        /// <returns>Completion Code</returns>
        protected abstract int sort();
    }
}
