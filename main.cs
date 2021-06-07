﻿using Sort_Algorithm_Visualiser.algorithms;
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

        public static void init()
        {
            SortHelper helper = new SortHelper();
            int[] arrToSort = helper.ArrayHelper(5);
            bubblesort bubble = new bubblesort(arrToSort);
            bubble.sort();
        }
    }
}
