using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.utils
{
    class SortHelper
    {
        public int[] ArrayHelper(int length)
        {
            Random rand = new Random();
            int[] toSort = new int[length];
            for(int i = 0; i < length;i++)
            {
                toSort[i] = rand.Next(1, 100);
            }
            return toSort;
        } 
    }
}
