using System;
using Sort_Algorithm_Visualiser;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.algorithms
{
    abstract class Sortalgorithm
    {

        protected CancellationTokenSource tokenSource = new CancellationTokenSource();
        protected CancellationToken token;
        protected int[] toSort;
        protected bool sorted = false;
        protected int totalSorts = 0;
        protected gui mainGui;
        private int result = 0;

        protected Sortalgorithm(gui gui)
        {
            mainGui = gui;
        }

        /// <summary>
        /// Starts The Sort Algorithm.
        /// </summary>
        public async Task<int[]> startSort()
        {
            token = tokenSource.Token;
            await Task.Run(() => result = sort(), token);
            if (result != 1) Console.WriteLine("CERNEL PAGE FAULT, CODE: {0}", result);
            Console.WriteLine("Array: [{0}]; TotalSorts: {1}; ", string.Join(", ", toSort), totalSorts);
            return toSort;
        }

        public void newArray(int[] arr)
        {
            toSort = arr;
        }


        /// <returns>Time it Took to Sort the Array</returns>

        /// <returns>The Array, either Sorted or Unsorted</returns>
        public int[] getArray()
        {
            return toSort;
        }

        public void killTask()
        {
            tokenSource.Cancel();
        }

        /// <returns>Amount of Sorts, it took</returns>
        public int getSorts()
        {
            return totalSorts;
        }

        public int getStatusCode()
        {
            return result;
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
            mainGui.update(toSort, totalSorts);
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Includes the main Sortlogic
        /// </summary>
        /// <returns>Completion Code</returns>
        protected abstract int sort();
    }
}
