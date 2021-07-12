using System;
using System.Threading;
using System.Threading.Tasks;
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
        private bool startedSort = false;
        private SortHelper helper = new SortHelper();
        private Stopwatch watch = new Stopwatch();
        Sortalgorithm sort;

        public gui()
        {
            InitializeComponent();
        }

        private void gui_Load(object sender, System.EventArgs e)
        {
            genArray();
        }

        public void update(int[] arr, int sorts, int totalCompars)
        {
            this.chart1.Invoke(new Action(() => this.chart1.Series[0].Points.DataBindY(arr)));
            this.SortCounterLabel.Invoke(new Action(() => this.SortCounterLabel.Text = sorts.ToString()));
            this.ComparisonInt.Invoke(new Action(() => this.ComparisonInt.Text = totalCompars.ToString()));
        }

        private async void StartBtn_Click(object sender, EventArgs e)
        {
            SelectAlgorithm();
            changeBox(false);
            watch.Restart();
            watch.Start();
            Task task = Task.Run(() => updateTime());
            startedSort = true;
            int[] sorted = await sort.startSort();
            this.SortedBool.Text = "true";
            for (int a = 1; a < sorted.Length; a++)
            {
                if (sorted[a - 1] > sorted[a]) this.SortedBool.Text = "false";
            }
            changeBox(true);
            watch.Stop();
            this.chart1.Series[0].Points.DataBindY(sorted);
        }

        private void SelectAlgorithm()
        {
            switch (alg)
            {
                case "Bogosort":
                    sort = new Bogosort(arrToSort, this.DelaySlider.Value, this.SoundBox.Checked, this);
                    break;
                case "Bubblesort":
                    sort = new Bubblesort(arrToSort, this.DelaySlider.Value, this.SoundBox.Checked, this);
                    break;
                case "Heapsort":
                    sort = new Heapsort(arrToSort, this.DelaySlider.Value, this.SoundBox.Checked, this);
                    break;
                case "Insertionsort":
                    sort = new Insertionsort(arrToSort, this.DelaySlider.Value, this.SoundBox.Checked, this);
                    break;
                case "Quicksort":
                    sort = new Quicksort(arrToSort, qs_activiation, this.DelaySlider.Value, this.SoundBox.Checked, this);
                    break;
                case "Radixsort":
                    sort = new Radixsort(arrToSort, this.DelaySlider.Value, this.SoundBox.Checked, this);
                    break;
                case "Selectionsort":
                    sort = new Selectionsort(arrToSort, this.DelaySlider.Value, this.SoundBox.Checked, this);
                    break;
                case "Shellsort":
                    sort = new Shellsort(arrToSort, this.DelaySlider.Value, this.SoundBox.Checked, this);
                    break;
                default:
                    throw new Exception("No Algorithm Selected");
            }
        }

        private void ArraySlider_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = sender as TrackBar;
            this.ArrayLengthInt.Text = bar.Value.ToString();
            genArray();
            this.SortedBool.Text = "false";
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            if (sort != null)
            {
                sort.killTask();
                changeBox(true);
                this.SortedBool.Text = "false";
            }
            if(!watch.IsRunning)
            {
                genArray();
            }

        }

        private void RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            if (btn.Checked)
            {
                alg = btn.Text;
                /*if (btn.Text == "Quicksort") this.QuickActvBox.Visible = true; //Disabled as only One Activation Method Works Rn.
                else this.QuickActvBox.Visible = false;*/
            }
            if (startedSort)
            {
                genArray();
                startedSort = false;
                this.TimeElapsedInt.Text = "0s";
                this.SortedBool.Text = "false";
                this.SortCounterLabel.Text = "0";
            }
        }

        private void QuickAtv_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            String tx = btn.Text;
            qs_activiation = tx == "First Index" ? 0 : tx == "Last Index" ? 1 : 2;
            if (startedSort)
            {
                genArray();
                startedSort = false;
                this.SortedBool.Text = "false";
                this.TimeElapsedInt.Text = "0s";
                this.SortCounterLabel.Text = "0";
            }
        }

        private void DelaySlider_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = sender as TrackBar;
            this.DelayLengthInt.Text = bar.Value.ToString();
            this.SortedBool.Text = "false";
            if (startedSort)
            {
                genArray();
                startedSort = false;
            }
        }

        private void MaxValSlider_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = sender as TrackBar;
            this.MaxValInt.Text = bar.Value.ToString();
            genArray();
            this.SortedBool.Text = "false";
        }

        private void SortedBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            if (box.Text == "Sorted" && box.Checked) this.ReverseSortedBox.Checked = false;
            else if (box.Text == "Inverse Sorted" && box.Checked) this.SortedBox.Checked = false;
            if (box.Checked) this.MaxValSlider.Enabled = false;
            else this.MaxValSlider.Enabled = true;
            genArray();
        }

        private void updateTime()
        {
            while (watch.IsRunning)
            {
                this.TimeElapsedInt.Invoke(new Action(() => this.TimeElapsedInt.Text = Math.Round((watch.Elapsed.TotalMilliseconds / 1000), 2).ToString() + "s"));
            }
        }

        private void changeBox(bool state)
        {
            this.AlgorithmBox.Enabled = state;
            this.SettingsBox.Enabled = state;
            this.QuickActvBox.Enabled = state;
            this.SpecialBox.Enabled = state;
            this.StartBtn.Enabled = state;
        }

        private void genArray()
        {

            if (this.SortedBox.Checked) arrToSort = helper.getSortedArray(this.ArraySlider.Value);
            else if (this.ReverseSortedBox.Checked) arrToSort = helper.getReverseSortedArray(this.ArraySlider.Value);
            else arrToSort = helper.getRandArray(this.ArraySlider.Value, 0, this.MaxValSlider.Value);
            this.chart1.Series[0].Points.DataBindY(arrToSort);
        }

        private void DelaySlider_MouseHover(object sender, EventArgs e)
        {
            this.DelayToolTip.Show("This Adds a Delay Between each sort,\n so algorithms which sort less are faster. \n Set this to 0 for an true comparison", this.DelaySlider);
        }
    }
}
