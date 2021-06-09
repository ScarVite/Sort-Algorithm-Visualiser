using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.algorithms
{
    class Radixsort : Sortalgorithm
    {

        /// <summary>
        /// The Constructor for the Radixsort Algorithm
        /// </summary>
        /// <param name="arr">The Array to sort</param>
        public Radixsort(int[] arr)
        {
            if (arr.Length < 5)
            {
                throw new Exception("Array has too few Entries");
            }
            toSort = arr;
        }

        protected override int sort()
        {
            return 1;
        }
    }
}
