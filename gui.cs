using System;
using System.Threading;
using System.Windows.Forms;
using Sort_Algorithm_Visualiser.algorithms;
using Sort_Algorithm_Visualiser.utils;

namespace Sort_Algorithm_Visualiser
{
    public partial class gui : Form
    {
        private SortHelper helper = new SortHelper();

        public gui()
        {
            InitializeComponent(); 
        }

        private async void gui_Load(object sender, System.EventArgs e)
        {
            //main.init();
            int[] arrToSort = helper.getArray(10);
            Shellsort sort = new Shellsort(arrToSort);
            test(sort);
            int[] sorted = await sort.startSort();
            this.chart1.Series[0].Points.DataBindY(sorted);
        }

        private void test(Shellsort sort)
        {
            while (sort.getStatusCode() == 0)
            {
                this.chart1.Series[0].Points.DataBindY(sort.getArray());
                Thread.Sleep(1000);
            }
        }
    }
}
