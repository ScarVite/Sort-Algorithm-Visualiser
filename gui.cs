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
        private String alg = "Bogosort";
        private int[] arrToSort;
        private int qs_activiation = 0;
        private SortHelper helper = new SortHelper();
        private Stopwatch watch = new Stopwatch();
        Sortalgorithm sort;

        public gui()
        {
            InitializeComponent();
        }

        private void gui_Load(object sender, System.EventArgs e)
        {
            arrToSort = helper.getArray(this.ArraySlider.Value, 0, this.MaxValSlider.Value);
            this.chart1.Series[0].Points.DataBindY(arrToSort);
        }

        public void update(int[] arr, int sorts)
        {
            this.chart1.Invoke(new Action(() => this.chart1.Series[0].Points.DataBindY(arr)));
            this.SortCounterLabel.Invoke(new Action(() => this.SortCounterLabel.Text = sorts.ToString()));
            this.TimeElapsedInt.Invoke(new Action(() => this.TimeElapsedInt.Text = Math.Round((watch.Elapsed.TotalMilliseconds / 1000), 2).ToString()));
        }

        private async void StartBtn_Click(object sender, EventArgs e)
        {
            SelectAlgorithm();
            this.AlgorithmBox.Enabled = false;
            this.SettingsBox.Enabled = false;
            this.QuickActvBox.Enabled = false;
            watch.Restart();
            watch.Start();
            int[] sorted = await sort.startSort();
            this.SortedBool.Text = "true";
            for (int a = 1; a < sorted.Length; a++)
            {
                if (sorted[a - 1] > sorted[a]) this.SortedBool.Text = "false";
            }
            this.AlgorithmBox.Enabled = true;
            this.SettingsBox.Enabled = true;
            this.QuickActvBox.Enabled = true;
            watch.Stop(); // watch.Elapsed.TotalMilliseconds
            this.chart1.Series[0].Points.DataBindY(sorted);

        }

        private void SelectAlgorithm()
        {
            switch (alg)
            {
                case "Bogosort":
                    sort = new Bogosort(arrToSort, this.DelaySlider.Value, this);
                    break;
                case "Bubblesort":
                    sort = new Bubblesort(arrToSort, this.DelaySlider.Value, this);
                    break;
                case "Heapsort":
                    sort = new Heapsort(arrToSort, this.DelaySlider.Value, this);
                    break;
                case "Insertionsort":
                    sort = new Insertionsort(arrToSort, this.DelaySlider.Value, this);
                    break;
                case "Quicksort":
                    sort = new Quicksort(arrToSort, qs_activiation, this.DelaySlider.Value, this);
                    break;
                case "Radixsort":
                    sort = new Radixsort(arrToSort, this.DelaySlider.Value, this);
                    break;
                case "Selectionsort":
                    sort = new Selectionsort(arrToSort, this.DelaySlider.Value, this);
                    break;
                case "Shellsort":
                    sort = new Shellsort(arrToSort, this.DelaySlider.Value, this);
                    break;
                default:
                    throw new Exception("No Algorithm Selected");
            }
        }

        private void ArraySlider_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = sender as TrackBar;
            this.ArrayLengthInt.Text = bar.Value.ToString();
            arrToSort = helper.getArray(this.ArraySlider.Value, 0, this.MaxValSlider.Value);
            this.chart1.Series[0].Points.DataBindY(arrToSort);
            this.SortedBool.Text = "false";
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            sort.killTask();
            this.AlgorithmBox.Enabled = true;
            this.SettingsBox.Enabled = true;
            this.QuickActvBox.Enabled = true;
            this.SortedBool.Text = "false";
        }

        private void RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            if (btn.Checked)
            {
                alg = btn.Text;
                if (btn.Text == "Quicksort") this.QuickActvBox.Visible = true;
                else this.QuickActvBox.Visible = false;
            }
            ArraySlider_Scroll(this.ArraySlider, null);
            this.SortedBool.Text = "false";
        }

        private void QuickAtv_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            String tx = btn.Text;
            qs_activiation = tx == "First Index" ? 0 : tx == "Last Index" ? 1 : 2;
            this.SortedBool.Text = "false";
        }

        private void DelaySlider_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = sender as TrackBar;
            this.DelayLengthInt.Text = bar.Value.ToString();
            this.SortedBool.Text = "false";
        }

        private void MaxValSlider_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = sender as TrackBar;
            this.MaxValInt.Text = bar.Value.ToString();
            ArraySlider_Scroll(this.ArraySlider, null);
            this.SortedBool.Text = "false";
        }
    }
}
