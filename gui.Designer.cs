namespace Sort_Algorithm_Visualiser
{
    partial class gui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AlgorithmBox = new System.Windows.Forms.GroupBox();
            this.ShellBtn = new System.Windows.Forms.RadioButton();
            this.SelectionBtn = new System.Windows.Forms.RadioButton();
            this.RadixBtn = new System.Windows.Forms.RadioButton();
            this.QuickBtn = new System.Windows.Forms.RadioButton();
            this.InsertionBtn = new System.Windows.Forms.RadioButton();
            this.HeapBtn = new System.Windows.Forms.RadioButton();
            this.BubbleBtn = new System.Windows.Forms.RadioButton();
            this.BogoBtn = new System.Windows.Forms.RadioButton();
            this.ActvRandBtn = new System.Windows.Forms.RadioButton();
            this.ActvLastBtn = new System.Windows.Forms.RadioButton();
            this.ActvFirstBtn = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SettingsBox = new System.Windows.Forms.GroupBox();
            this.SoundBox = new System.Windows.Forms.CheckBox();
            this.MaxValInt = new System.Windows.Forms.Label();
            this.DelayLengthInt = new System.Windows.Forms.Label();
            this.ArrayLengthInt = new System.Windows.Forms.Label();
            this.MaxValueLabel = new System.Windows.Forms.Label();
            this.DelayLabel = new System.Windows.Forms.Label();
            this.DelaySlider = new System.Windows.Forms.TrackBar();
            this.MaxValSlider = new System.Windows.Forms.TrackBar();
            this.ArrayLengthLabel = new System.Windows.Forms.Label();
            this.ArraySlider = new System.Windows.Forms.TrackBar();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SortLabel = new System.Windows.Forms.Label();
            this.SortCounterLabel = new System.Windows.Forms.Label();
            this.QuickActvBox = new System.Windows.Forms.GroupBox();
            this.TimeElapsedInt = new System.Windows.Forms.Label();
            this.TimeElapsedLabel = new System.Windows.Forms.Label();
            this.ComparisonInt = new System.Windows.Forms.Label();
            this.ComparisonLabel = new System.Windows.Forms.Label();
            this.SortedBool = new System.Windows.Forms.Label();
            this.SortedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.AlgorithmBox.SuspendLayout();
            this.SettingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelaySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxValSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArraySlider)).BeginInit();
            this.QuickActvBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.chart1.Titles;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 40);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(917, 480);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // AlgorithmBox
            // 
            this.AlgorithmBox.Controls.Add(this.ShellBtn);
            this.AlgorithmBox.Controls.Add(this.SelectionBtn);
            this.AlgorithmBox.Controls.Add(this.RadixBtn);
            this.AlgorithmBox.Controls.Add(this.QuickBtn);
            this.AlgorithmBox.Controls.Add(this.InsertionBtn);
            this.AlgorithmBox.Controls.Add(this.HeapBtn);
            this.AlgorithmBox.Controls.Add(this.BubbleBtn);
            this.AlgorithmBox.Controls.Add(this.BogoBtn);
            this.AlgorithmBox.Location = new System.Drawing.Point(948, 240);
            this.AlgorithmBox.Name = "AlgorithmBox";
            this.AlgorithmBox.Size = new System.Drawing.Size(102, 212);
            this.AlgorithmBox.TabIndex = 1;
            this.AlgorithmBox.TabStop = false;
            this.AlgorithmBox.Text = "Algorithms";
            // 
            // ShellBtn
            // 
            this.ShellBtn.AutoSize = true;
            this.ShellBtn.Location = new System.Drawing.Point(7, 181);
            this.ShellBtn.Name = "ShellBtn";
            this.ShellBtn.Size = new System.Drawing.Size(65, 17);
            this.ShellBtn.TabIndex = 7;
            this.ShellBtn.Text = "Shellsort";
            this.ShellBtn.UseVisualStyleBackColor = true;
            this.ShellBtn.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // SelectionBtn
            // 
            this.SelectionBtn.AutoSize = true;
            this.SelectionBtn.Location = new System.Drawing.Point(7, 158);
            this.SelectionBtn.Name = "SelectionBtn";
            this.SelectionBtn.Size = new System.Drawing.Size(86, 17);
            this.SelectionBtn.TabIndex = 6;
            this.SelectionBtn.Text = "Selectionsort";
            this.SelectionBtn.UseVisualStyleBackColor = true;
            this.SelectionBtn.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // RadixBtn
            // 
            this.RadixBtn.AutoSize = true;
            this.RadixBtn.Location = new System.Drawing.Point(7, 135);
            this.RadixBtn.Name = "RadixBtn";
            this.RadixBtn.Size = new System.Drawing.Size(69, 17);
            this.RadixBtn.TabIndex = 5;
            this.RadixBtn.Text = "Radixsort";
            this.RadixBtn.UseVisualStyleBackColor = true;
            this.RadixBtn.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // QuickBtn
            // 
            this.QuickBtn.AutoSize = true;
            this.QuickBtn.Location = new System.Drawing.Point(7, 112);
            this.QuickBtn.Name = "QuickBtn";
            this.QuickBtn.Size = new System.Drawing.Size(70, 17);
            this.QuickBtn.TabIndex = 4;
            this.QuickBtn.Text = "Quicksort";
            this.QuickBtn.UseVisualStyleBackColor = true;
            this.QuickBtn.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // InsertionBtn
            // 
            this.InsertionBtn.AutoSize = true;
            this.InsertionBtn.Location = new System.Drawing.Point(7, 89);
            this.InsertionBtn.Name = "InsertionBtn";
            this.InsertionBtn.Size = new System.Drawing.Size(82, 17);
            this.InsertionBtn.TabIndex = 3;
            this.InsertionBtn.Text = "Insertionsort";
            this.InsertionBtn.UseVisualStyleBackColor = true;
            this.InsertionBtn.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // HeapBtn
            // 
            this.HeapBtn.AutoSize = true;
            this.HeapBtn.Location = new System.Drawing.Point(7, 66);
            this.HeapBtn.Name = "HeapBtn";
            this.HeapBtn.Size = new System.Drawing.Size(68, 17);
            this.HeapBtn.TabIndex = 2;
            this.HeapBtn.Text = "Heapsort";
            this.HeapBtn.UseVisualStyleBackColor = true;
            this.HeapBtn.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // BubbleBtn
            // 
            this.BubbleBtn.AutoSize = true;
            this.BubbleBtn.Location = new System.Drawing.Point(7, 43);
            this.BubbleBtn.Name = "BubbleBtn";
            this.BubbleBtn.Size = new System.Drawing.Size(75, 17);
            this.BubbleBtn.TabIndex = 1;
            this.BubbleBtn.Text = "Bubblesort";
            this.BubbleBtn.UseVisualStyleBackColor = true;
            this.BubbleBtn.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // BogoBtn
            // 
            this.BogoBtn.AutoSize = true;
            this.BogoBtn.Checked = true;
            this.BogoBtn.Location = new System.Drawing.Point(7, 20);
            this.BogoBtn.Name = "BogoBtn";
            this.BogoBtn.Size = new System.Drawing.Size(67, 17);
            this.BogoBtn.TabIndex = 0;
            this.BogoBtn.TabStop = true;
            this.BogoBtn.Text = "Bogosort";
            this.BogoBtn.UseVisualStyleBackColor = true;
            this.BogoBtn.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // ActvRandBtn
            // 
            this.ActvRandBtn.AutoSize = true;
            this.ActvRandBtn.Location = new System.Drawing.Point(6, 65);
            this.ActvRandBtn.Name = "ActvRandBtn";
            this.ActvRandBtn.Size = new System.Drawing.Size(94, 17);
            this.ActvRandBtn.TabIndex = 10;
            this.ActvRandBtn.Text = "Random Index";
            this.ActvRandBtn.UseVisualStyleBackColor = true;
            this.ActvRandBtn.CheckedChanged += new System.EventHandler(this.QuickAtv_CheckedChanged);
            // 
            // ActvLastBtn
            // 
            this.ActvLastBtn.AutoSize = true;
            this.ActvLastBtn.Location = new System.Drawing.Point(6, 42);
            this.ActvLastBtn.Name = "ActvLastBtn";
            this.ActvLastBtn.Size = new System.Drawing.Size(74, 17);
            this.ActvLastBtn.TabIndex = 9;
            this.ActvLastBtn.Text = "Last Index";
            this.ActvLastBtn.UseVisualStyleBackColor = true;
            this.ActvLastBtn.CheckedChanged += new System.EventHandler(this.QuickAtv_CheckedChanged);
            // 
            // ActvFirstBtn
            // 
            this.ActvFirstBtn.AutoSize = true;
            this.ActvFirstBtn.Checked = true;
            this.ActvFirstBtn.Location = new System.Drawing.Point(6, 19);
            this.ActvFirstBtn.Name = "ActvFirstBtn";
            this.ActvFirstBtn.Size = new System.Drawing.Size(73, 17);
            this.ActvFirstBtn.TabIndex = 8;
            this.ActvFirstBtn.TabStop = true;
            this.ActvFirstBtn.Text = "First Index";
            this.ActvFirstBtn.UseVisualStyleBackColor = true;
            this.ActvFirstBtn.CheckedChanged += new System.EventHandler(this.QuickAtv_CheckedChanged);
            // 
            // SettingsBox
            // 
            this.SettingsBox.Controls.Add(this.SoundBox);
            this.SettingsBox.Controls.Add(this.MaxValInt);
            this.SettingsBox.Controls.Add(this.DelayLengthInt);
            this.SettingsBox.Controls.Add(this.ArrayLengthInt);
            this.SettingsBox.Controls.Add(this.MaxValueLabel);
            this.SettingsBox.Controls.Add(this.DelayLabel);
            this.SettingsBox.Controls.Add(this.DelaySlider);
            this.SettingsBox.Controls.Add(this.MaxValSlider);
            this.SettingsBox.Controls.Add(this.ArrayLengthLabel);
            this.SettingsBox.Controls.Add(this.ArraySlider);
            this.SettingsBox.Location = new System.Drawing.Point(948, 22);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(210, 212);
            this.SettingsBox.TabIndex = 2;
            this.SettingsBox.TabStop = false;
            this.SettingsBox.Text = "Settings";
            // 
            // SoundBox
            // 
            this.SoundBox.AutoSize = true;
            this.SoundBox.Checked = true;
            this.SoundBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SoundBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SoundBox.Location = new System.Drawing.Point(13, 185);
            this.SoundBox.Name = "SoundBox";
            this.SoundBox.Size = new System.Drawing.Size(57, 17);
            this.SoundBox.TabIndex = 9;
            this.SoundBox.Text = "Sound";
            this.SoundBox.UseVisualStyleBackColor = true;
            // 
            // MaxValInt
            // 
            this.MaxValInt.Location = new System.Drawing.Point(169, 88);
            this.MaxValInt.Name = "MaxValInt";
            this.MaxValInt.Size = new System.Drawing.Size(67, 13);
            this.MaxValInt.TabIndex = 8;
            this.MaxValInt.Text = "500";
            // 
            // DelayLengthInt
            // 
            this.DelayLengthInt.Location = new System.Drawing.Point(171, 140);
            this.DelayLengthInt.Name = "DelayLengthInt";
            this.DelayLengthInt.Size = new System.Drawing.Size(67, 13);
            this.DelayLengthInt.TabIndex = 5;
            this.DelayLengthInt.Text = "10";
            // 
            // ArrayLengthInt
            // 
            this.ArrayLengthInt.Location = new System.Drawing.Point(164, 39);
            this.ArrayLengthInt.Name = "ArrayLengthInt";
            this.ArrayLengthInt.Size = new System.Drawing.Size(67, 13);
            this.ArrayLengthInt.TabIndex = 4;
            this.ArrayLengthInt.Text = "100";
            // 
            // MaxValueLabel
            // 
            this.MaxValueLabel.AutoSize = true;
            this.MaxValueLabel.Location = new System.Drawing.Point(13, 67);
            this.MaxValueLabel.Name = "MaxValueLabel";
            this.MaxValueLabel.Size = new System.Drawing.Size(54, 13);
            this.MaxValueLabel.TabIndex = 7;
            this.MaxValueLabel.Text = "MaxValue";
            // 
            // DelayLabel
            // 
            this.DelayLabel.AutoSize = true;
            this.DelayLabel.Location = new System.Drawing.Point(9, 118);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(34, 13);
            this.DelayLabel.TabIndex = 3;
            this.DelayLabel.Text = "Delay";
            // 
            // DelaySlider
            // 
            this.DelaySlider.LargeChange = 100;
            this.DelaySlider.Location = new System.Drawing.Point(9, 134);
            this.DelaySlider.Maximum = 1000;
            this.DelaySlider.Name = "DelaySlider";
            this.DelaySlider.Size = new System.Drawing.Size(161, 45);
            this.DelaySlider.SmallChange = 10;
            this.DelaySlider.TabIndex = 2;
            this.DelaySlider.Value = 10;
            this.DelaySlider.Scroll += new System.EventHandler(this.DelaySlider_Scroll);
            // 
            // MaxValSlider
            // 
            this.MaxValSlider.LargeChange = 1000;
            this.MaxValSlider.Location = new System.Drawing.Point(7, 83);
            this.MaxValSlider.Maximum = 10000;
            this.MaxValSlider.Minimum = 10;
            this.MaxValSlider.Name = "MaxValSlider";
            this.MaxValSlider.Size = new System.Drawing.Size(161, 45);
            this.MaxValSlider.SmallChange = 100;
            this.MaxValSlider.TabIndex = 6;
            this.MaxValSlider.Value = 500;
            this.MaxValSlider.Scroll += new System.EventHandler(this.MaxValSlider_Scroll);
            // 
            // ArrayLengthLabel
            // 
            this.ArrayLengthLabel.AutoSize = true;
            this.ArrayLengthLabel.Location = new System.Drawing.Point(6, 18);
            this.ArrayLengthLabel.Name = "ArrayLengthLabel";
            this.ArrayLengthLabel.Size = new System.Drawing.Size(67, 13);
            this.ArrayLengthLabel.TabIndex = 1;
            this.ArrayLengthLabel.Text = "Array Length";
            // 
            // ArraySlider
            // 
            this.ArraySlider.LargeChange = 100;
            this.ArraySlider.Location = new System.Drawing.Point(6, 34);
            this.ArraySlider.Maximum = 1000;
            this.ArraySlider.Minimum = 10;
            this.ArraySlider.Name = "ArraySlider";
            this.ArraySlider.Size = new System.Drawing.Size(162, 45);
            this.ArraySlider.SmallChange = 10;
            this.ArraySlider.TabIndex = 0;
            this.ArraySlider.Value = 100;
            this.ArraySlider.Scroll += new System.EventHandler(this.ArraySlider_Scroll);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(948, 486);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(89, 23);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(1067, 486);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(85, 23);
            this.ResetBtn.TabIndex = 4;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Location = new System.Drawing.Point(12, 9);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(61, 13);
            this.SortLabel.TabIndex = 5;
            this.SortLabel.Text = "Total Sorts:";
            // 
            // SortCounterLabel
            // 
            this.SortCounterLabel.AutoSize = true;
            this.SortCounterLabel.Location = new System.Drawing.Point(79, 9);
            this.SortCounterLabel.Name = "SortCounterLabel";
            this.SortCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.SortCounterLabel.TabIndex = 6;
            this.SortCounterLabel.Text = "0";
            // 
            // QuickActvBox
            // 
            this.QuickActvBox.Controls.Add(this.ActvRandBtn);
            this.QuickActvBox.Controls.Add(this.ActvFirstBtn);
            this.QuickActvBox.Controls.Add(this.ActvLastBtn);
            this.QuickActvBox.Location = new System.Drawing.Point(1061, 241);
            this.QuickActvBox.Name = "QuickActvBox";
            this.QuickActvBox.Size = new System.Drawing.Size(128, 88);
            this.QuickActvBox.TabIndex = 7;
            this.QuickActvBox.TabStop = false;
            this.QuickActvBox.Text = "QS Activation Method";
            this.QuickActvBox.Visible = false;
            // 
            // TimeElapsedInt
            // 
            this.TimeElapsedInt.AutoSize = true;
            this.TimeElapsedInt.Location = new System.Drawing.Point(188, 9);
            this.TimeElapsedInt.Name = "TimeElapsedInt";
            this.TimeElapsedInt.Size = new System.Drawing.Size(13, 13);
            this.TimeElapsedInt.TabIndex = 9;
            this.TimeElapsedInt.Text = "0";
            // 
            // TimeElapsedLabel
            // 
            this.TimeElapsedLabel.AutoSize = true;
            this.TimeElapsedLabel.Location = new System.Drawing.Point(108, 9);
            this.TimeElapsedLabel.Name = "TimeElapsedLabel";
            this.TimeElapsedLabel.Size = new System.Drawing.Size(74, 13);
            this.TimeElapsedLabel.TabIndex = 8;
            this.TimeElapsedLabel.Text = "Time Elapsed:";
            // 
            // ComparisonInt
            // 
            this.ComparisonInt.AutoSize = true;
            this.ComparisonInt.Location = new System.Drawing.Point(290, 9);
            this.ComparisonInt.Name = "ComparisonInt";
            this.ComparisonInt.Size = new System.Drawing.Size(13, 13);
            this.ComparisonInt.TabIndex = 11;
            this.ComparisonInt.Text = "0";
            // 
            // ComparisonLabel
            // 
            this.ComparisonLabel.AutoSize = true;
            this.ComparisonLabel.Location = new System.Drawing.Point(223, 9);
            this.ComparisonLabel.Name = "ComparisonLabel";
            this.ComparisonLabel.Size = new System.Drawing.Size(70, 13);
            this.ComparisonLabel.TabIndex = 10;
            this.ComparisonLabel.Text = "Comparisons:";
            // 
            // SortedBool
            // 
            this.SortedBool.AutoSize = true;
            this.SortedBool.Location = new System.Drawing.Point(884, 9);
            this.SortedBool.Name = "SortedBool";
            this.SortedBool.Size = new System.Drawing.Size(29, 13);
            this.SortedBool.TabIndex = 13;
            this.SortedBool.Text = "false";
            // 
            // SortedLabel
            // 
            this.SortedLabel.AutoSize = true;
            this.SortedLabel.Location = new System.Drawing.Point(837, 9);
            this.SortedLabel.Name = "SortedLabel";
            this.SortedLabel.Size = new System.Drawing.Size(41, 13);
            this.SortedLabel.TabIndex = 12;
            this.SortedLabel.Text = "Sorted:";
            // 
            // gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 621);
            this.Controls.Add(this.SortedBool);
            this.Controls.Add(this.SortedLabel);
            this.Controls.Add(this.ComparisonInt);
            this.Controls.Add(this.ComparisonLabel);
            this.Controls.Add(this.TimeElapsedInt);
            this.Controls.Add(this.TimeElapsedLabel);
            this.Controls.Add(this.QuickActvBox);
            this.Controls.Add(this.SortCounterLabel);
            this.Controls.Add(this.SortLabel);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.SettingsBox);
            this.Controls.Add(this.AlgorithmBox);
            this.Controls.Add(this.chart1);
            this.Name = "gui";
            this.Text = "Sorting Algorithm Visualizer";
            this.Load += new System.EventHandler(this.gui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.AlgorithmBox.ResumeLayout(false);
            this.AlgorithmBox.PerformLayout();
            this.SettingsBox.ResumeLayout(false);
            this.SettingsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelaySlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxValSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArraySlider)).EndInit();
            this.QuickActvBox.ResumeLayout(false);
            this.QuickActvBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox AlgorithmBox;
        private System.Windows.Forms.RadioButton InsertionBtn;
        private System.Windows.Forms.RadioButton HeapBtn;
        private System.Windows.Forms.RadioButton BubbleBtn;
        private System.Windows.Forms.RadioButton BogoBtn;
        private System.Windows.Forms.RadioButton ShellBtn;
        private System.Windows.Forms.RadioButton SelectionBtn;
        private System.Windows.Forms.RadioButton RadixBtn;
        private System.Windows.Forms.RadioButton QuickBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox SettingsBox;
        private System.Windows.Forms.TrackBar ArraySlider;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label DelayLabel;
        private System.Windows.Forms.TrackBar DelaySlider;
        private System.Windows.Forms.Label ArrayLengthLabel;
        private System.Windows.Forms.Label ArrayLengthInt;
        private System.Windows.Forms.Label SortLabel;
        private System.Windows.Forms.Label SortCounterLabel;
        private System.Windows.Forms.RadioButton ActvFirstBtn;
        private System.Windows.Forms.RadioButton ActvRandBtn;
        private System.Windows.Forms.RadioButton ActvLastBtn;
        private System.Windows.Forms.GroupBox QuickActvBox;
        private System.Windows.Forms.Label DelayLengthInt;
        private System.Windows.Forms.Label MaxValInt;
        private System.Windows.Forms.Label MaxValueLabel;
        private System.Windows.Forms.TrackBar MaxValSlider;
        private System.Windows.Forms.Label TimeElapsedInt;
        private System.Windows.Forms.Label TimeElapsedLabel;
        private System.Windows.Forms.Label ComparisonInt;
        private System.Windows.Forms.Label ComparisonLabel;
        private System.Windows.Forms.Label SortedBool;
        private System.Windows.Forms.Label SortedLabel;
        private System.Windows.Forms.CheckBox SoundBox;
    }
}

