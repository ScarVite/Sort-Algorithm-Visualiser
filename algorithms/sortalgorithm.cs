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
        protected bool soundEnabled = true;
        protected int totalSorts = 0;
        protected int totalCompars = 0;
        protected gui mainGui;
        protected int delay = 0;
        private int result = 0;

        protected Sortalgorithm(int del, bool sound, gui gui)
        {
            delay = del;
            soundEnabled = sound;
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

        /// <summary>
        /// Sets a New Array to Sort without reconstructing
        /// </summary>
        /// <param name="arr">The Array to sort</param>
        public void newArray(int[] arr)
        {
            toSort = arr;
        }

        /// <returns>The Array, either Sorted or Unsorted</returns>
        public int[] getArray()
        {
            return toSort;
        }
        /// <summary>
        /// Stops The SOrt
        /// </summary>
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
            if(soundEnabled) makeSound(i);
            mainGui.update(toSort, totalSorts, totalCompars);
            Thread.Sleep(delay);
        }

        /// <summary>
        /// Makes a Beep Sound
        /// </summary>
        /// <param name="i">The Index of which Value as a frequenzy the Sound should be made</param>
        protected void makeSound(int i)
        {
           Console.Beep(toSort[i] +37, 10);
        }

        /// <summary>
        /// Includes the main Sortlogic
        /// </summary>
        /// <returns>Completion Code</returns>
        protected abstract int sort();
    }
}
