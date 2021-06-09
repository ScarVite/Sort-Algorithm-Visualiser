﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualiser.algorithms
{
    class Bogosort: Sortalgorithm
    {

        private Random rand = new Random();

        /// <summary>
        /// The Constructor for the Bogosort Algorithm
        /// </summary>
        /// <param name="arr">The Array to sort</param>
        public Bogosort(int[] arr)
        {
            if (arr.Length < 5)
            {
                throw new Exception("Array has too few Entries");
            }
            toSort = arr;
        }

        protected override int sort()
        {
            do
            {
                for (int i = 0; i < toSort.Length; i++)
                {
                    swap(i, rand.Next(0, toSort.Length)); //Randomy Shuffle everthing
                }
                isSorted(); //refresh sorted
            } while (!sorted); //while not sorted
            return 1;
        }

        /// <summary>
        /// Checks if the Array is Sorted an Updates sorted
        /// </summary>
        private void isSorted()
        {
            sorted = true;
            for(int i = 0; i < toSort.Length-1;i++)
            {
                if (toSort[i] > toSort[i + 1]) sorted = false;
            }
        }
    }
}
