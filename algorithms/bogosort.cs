using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.algorithms
{
    class bogosort: sortalgorithm
    {

        private Random rand = new Random();

        public bogosort(int[] arr)
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
                isSorted();
                for (int i = 0; i < toSort.Length - 1; i++)
                {
                    swap(i, rand.Next(0, toSort.Length));
                }
            } while (!sorted);
            return 1;
        }

        private void isSorted()
        {
            sorted = true;
            for(int i = 0; i < toSort.Length-1;i++)
            {
                if (toSort[i] > toSort[i + 1]) sorted = false;
            }
        }
    }
}
