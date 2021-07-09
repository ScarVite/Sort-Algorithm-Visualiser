using System;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using Sort_Algorithm_Visualiser.algorithms;
using Sort_Algorithm_Visualiser.utils;

namespace Sort_Algorithm_Visualiser
{
    public partial class gui : Form
    {
        private SortHelper helper = new SortHelper();
        private Stopwatch watch = new Stopwatch();
        Sortalgorithm sort;

        public gui()
        {
            InitializeComponent(); 
        }

        private void gui_Load(object sender, System.EventArgs e)
        {
            int[] arr = helper.getArray(this.ArraySlider.Value);
            this.chart1.Series[0].Points.DataBindY(arr);
        }

        public void update(int[] arr, int sorts)
        {
            this.chart1.Invoke(new Action(() => this.chart1.Series[0].Points.DataBindY(arr)));
            this.SortCounterLabel.Invoke(new Action(() => this.SortCounterLabel.Text = sorts.ToString()));
        }

        private async void StartBtn_Click(object sender, EventArgs e)
        {
            int[] arrToSort = helper.getArray(this.ArraySlider.Value);
            sort = new Shellsort(arrToSort, this);
            this.AlgorithmBox.Enabled = false;
            this.SettingsBox.Enabled = false;
            watch.Start();
            int[] sorted = await sort.startSort();
            this.AlgorithmBox.Enabled = true;
            this.SettingsBox.Enabled = true;
            watch.Stop(); // watch.Elapsed.TotalMilliseconds
            this.chart1.Series[0].Points.DataBindY(sorted);

        }

        private void ArraySlider_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = sender as TrackBar;
            Console.WriteLine(bar.Value.ToString());
            this.ArrayLengthInt.Text = bar.Value.ToString();
            int[] arr = helper.getArray(this.ArraySlider.Value);
            this.chart1.Series[0].Points.DataBindY(arr);
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            sort.killTask();
            this.AlgorithmBox.Enabled = true;
            this.SettingsBox.Enabled = true;
        }
    }
}
