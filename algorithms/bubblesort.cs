﻿using System;
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

        protected override int sort()
        {
            while(!sorted)
            {
                int sorts = 0;
                for(int i = 0; i < toSort.Length-1; i++)
                {
                    if(toSort[i] > toSort[i+1])
                    {
                        swap(i, i + 1);
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
