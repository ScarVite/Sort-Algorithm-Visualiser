using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.algorithms
{
    class bubblesort: sortalgorithm
    {

        public bubblesort(int[] arr)
        {
            if(arr.Length < 5)
            {
                throw new Exception("Array has too few Entries"); 
            }
            toSort = arr;
        }

        public override int sort()
        {
            watch.Start();
            while(!sorted)
            {
                int sorts = 0;
                for(int i = 0; i < toSort.Length-1; i++)
                {
                    if(toSort[i] > toSort[i+1])
                    {
                        int temp = toSort[i];
                        toSort[i] = toSort[i + 1];
                        toSort[i + 1] = temp;
                        sorts++;
                    }
                }
                totalSorts += sorts;
                if (sorts == 0) sorted = true;
            }
            return 1;
        }
    }
}
