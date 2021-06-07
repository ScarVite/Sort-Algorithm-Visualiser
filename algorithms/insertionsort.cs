using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.algorithms
{
    class insertionsort : sortalgorithm
    {

        public insertionsort(int[] arr)
        {
            if (arr.Length < 5)
            {
                throw new Exception("Array has too few Entries");
            }
            toSort = arr;
        }

        public override int sort()
        {
            watch.Start();
            int totalSorts = 0;
            for (int i = 1; i <= toSort.Length - 1; i++)
            {
                if (toSort[i-1] > toSort[i])
                {
                    int temp = toSort[i];
                    for (int b = i - 1;b > 0; b--)
                    {
                        if (toSort[b] > temp)
                        {
                            toSort[b + 1] = toSort[b];
                        }
                        else
                        {
                            toSort[b] = temp;
                            b = -1;
                        }
                    }
                    totalSorts++;
                }
            }
            watch.Stop();
            Console.WriteLine(watch.Elapsed.TotalMilliseconds);
            return 1;
        }
    }
}
