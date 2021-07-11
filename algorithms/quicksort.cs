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
        /// <param name="Actv">Activation Method: 0=First; 1=Last; 2=Random</param>
        /// <param name="del">The Delay for the Algorithm between each sort</param>
        /// <param name="sound">Wether Sound should be played</param>
        /// <param name="gui">The Instance of the GUI</param> 
        public Quicksort(int[] arr, int Actv, int del, bool sound, gui gui) : base(del, sound, gui)
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
            return qsort(getPivot(), toSort.Length-1);
        }

        /// <summary>
        /// The Quicksort Recursive Logic. Both Params are needed for the "sub-array"
        /// </summary>
        /// <param name="start">StartIndex for the Current Array</param>
        /// <param name="end">EndIndex for the Current Array</param>
        /// <returns></returns>
        private int qsort(int start, int end)
        {
            totalCompars++; // Inc Comparisons
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
            for (int i = start + 1; i <= end; i++)
            {
                totalCompars++; // Inc Comparisons
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
                case 0:
                    return 0;
                case 1:
                    return toSort.Length - 1;
                case 2:
                    return rand.Next(0, toSort.Length - 1);
                default:
                    throw new Exception("No Activationmethod Defined");
            };
        }
    }
}
