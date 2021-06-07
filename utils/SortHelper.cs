using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.utils
{
    class SortHelper
    {
        Random rand = new Random();

        public int[] ArrayHelper(int length)
        {
            int[] toSort = new int[length];
            for (int i = 0; i < length; i++)
            {
                toSort[i] = rand.Next(100);
            }
            return toSort;
        }
    }
}
