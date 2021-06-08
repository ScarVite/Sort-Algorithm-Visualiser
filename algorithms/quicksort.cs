using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.algorithms
{
    class quicksort : sortalgorithm
    {
        int pivotIndex = -1;
        int pivotSwapped = 0;
        int ActivationMethod = -1;
        Random rand = new Random();

        /// <summary>
        /// Actv: 1: First; 2: Last; 3: Random.
        /// </summary>
        public quicksort(int[] arr,int Actv)
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
            return qsort(0, toSort.Length);
        }

        private int qsort(int start, int end)
        {
            if(start < end)
            {
                int pivot = partition(start, end);
                qsort(start, pivot);
                qsort(pivot + 1, end);
            }
            return 1;
        }

        private int partition(int start, int end)
        {
            int pivot = toSort[start];
            int swapIndex = start;
            for(int i = start+1; i < end; i++)
            {
                if(toSort[i] < pivot)
                {
                    swapIndex++;
                    swap(i, swapIndex);
                }
            }
            swap(start, swapIndex);
            return swapIndex;
        }

        private void getPivot()
        {
            switch(ActivationMethod)
            {
                case 1:
                    pivotIndex = 0;
                    break;
                case 2:
                    pivotIndex = toSort.Length - 1;
                    break;
                case 3:
                    pivotIndex = rand.Next(0, toSort.Length - 1);
                    break;
                default:
                    throw new Exception("No Activationmethod Defined");
            };
            //swap(toSort.Length - 1, pivotIndex);
        }
    }
}
