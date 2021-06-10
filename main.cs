using Sort_Algorithm_Visualiser.algorithms;
using Sort_Algorithm_Visualiser.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort_Algorithm_Visualiser
{
    static class main
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new gui());
        }

        /// <summary>
        /// Initialises the Sortalgorithms
        /// </summary>
        public static void init()
        {
            SortHelper helper = new SortHelper();
            int[] arrToSort = helper.getArray(5);
            //Radixsort sort = new Radixsort(arrToSort);
            //sort.startSort();
            test();
        }

        private async static void test()
        {
            SortHelper helper = new SortHelper();
            for (int i = 5; i > 0 ; i--)
            {
                int[] arrToSort = helper.getArray(5);
                Radixsort sort = new Radixsort(arrToSort);
                int[] sorted = await sort.startSort();
                bool sortedB = true;
                for(int a = 1; a < sorted.Length;a++)
                {
                    if (sorted[a - 1] > sorted[a]) sortedB = false;
                }
                Console.WriteLine(sortedB);
            }
        }
    }
}
