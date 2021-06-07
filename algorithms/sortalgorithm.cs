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

        public abstract int sort();
    }
}
