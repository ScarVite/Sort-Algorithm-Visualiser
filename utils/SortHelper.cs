using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.utils
{
    class SortHelper
    {
         static Random rand = new Random();

        public int[] ArrayHelper(int length)
        {
            int[] toSort = new int[length];
            for (int i = 0; i < length; i++)
            {
                toSort[i] = rand.Next(0, 100);
            }
            Console.WriteLine("[{0}]", string.Join(", ", toSort));
            return toSort;
        }
    }
}
