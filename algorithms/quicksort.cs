using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.algorithms
{
    class Quicksort : Sortalgorithm
    {
        int ActivationMethod = -1;

        Random rand = new Random();

        /// <summary>
        /// The Constructor for the Quicksort Algorithm
        /// </summary>
        /// <param name="arr">The Array to sort</param>
        /// <param name="Actv">Activation Method: 1=First; 2=Last; 3=Random</param>
        /// <param name="gui">The Instance of the GUI</param>
        public Quicksort(int[] arr, int Actv, gui gui) : base(gui)
        {
            if (arr.Length < 5)
            {
                throw new Exception("Array has too few Entries");
            }
            ActivationMethod = Actv;
            toSort = arr;
        }

        protected override int sort()
        {
            if (token.IsCancellationRequested) return 2; // To Properly Cancel a Sort
            return qsort(getPivot(), toSort.Length);
        }

        /// <summary>
        /// The Quicksort Recursive Logic. Both Params are needed for the "sub-array"
        /// </summary>
        /// <param name="start">StartIndex for the Current Array</param>
        /// <param name="end">EndIndex for the Current Array</param>
        /// <returns></returns>
        private int qsort(int start, int end)
        {
            if (start < end)
            {
                if (token.IsCancellationRequested) return 2; // To Properly Cancel a Sort
                int pivot = partition(start, end); //get the pivot
                qsort(start, pivot); // do the same for the frist part (smaller or equal to pivot)
                qsort(pivot + 1, end); //and now for the second part (the largen than pivot)
            }
            return 1;
        }

        /// <summary>
        /// The Partitioning Logic for The Array. Both Params are needed for the "sub-array"
        /// </summary>
        /// <param name="start">StartIndex for the Current Array</param>
        /// <param name="end">EndIndex for the Current Array</param>
        /// <returns></returns>
        private int partition(int start, int end)
        {
            int pivot = toSort[start]; //Depending on Activiation Method
            int swapIndex = start;
            for (int i = start + 1; i < end; i++)
            {
                if (toSort[i] < pivot) //Sort the Index Accrodingly
                {
                    if (token.IsCancellationRequested) return 2; // To Properly Cancel a Sort
                    swapIndex++;
                    swap(i, swapIndex);
                }
            }
            swap(start, swapIndex);
            return swapIndex;
        }

        /// <summary>
        /// Get The Pivot returning on the Declared Activation Method in the Construcor
        /// </summary>
        /// <returns>PivotIndex</returns>
        private int getPivot()
        {
            switch (ActivationMethod)
            {
                case 1:
                    return 0;
                case 2:
                    return toSort.Length - 1;
                case 3:
                    return rand.Next(0, toSort.Length - 1);
                default:
                    throw new Exception("No Activationmethod Defined");
            };
        }
    }
}
