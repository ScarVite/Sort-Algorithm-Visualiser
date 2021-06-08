using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.algorithms
{
    abstract class sortalgorithm
    {

        protected Stopwatch watch = new Stopwatch();
        protected int[] toSort;
        protected bool sorted = false;
        protected int totalSorts = 0;

        public async void startSort()
        {
            watch.Start();
            await Task.Run(() => sort());
            Console.WriteLine(watch.Elapsed.TotalMilliseconds);
            Console.WriteLine("[{0}]", string.Join(", ", toSort));
            watch.Stop();
        }

        public abstract int sort();
    }
}
