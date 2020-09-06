namespace LocalizationData.UI
{
    partial class Graphs
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stackChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackChart)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 1004);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // pieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pieChart.Legends.Add(legend1);
            this.pieChart.Location = new System.Drawing.Point(1015, 12);
            this.pieChart.Name = "pieChart";
            this.pieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pieChart.Series.Add(series1);
            this.pieChart.Size = new System.Drawing.Size(709, 537);
            this.pieChart.TabIndex = 3;
            this.pieChart.Text = "chart3";
            // 
            // barChart
            // 
            chartArea2.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.barChart.Legends.Add(legend2);
            this.barChart.Location = new System.Drawing.Point(297, 555);
            this.barChart.Name = "barChart";
            this.barChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.barChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Silver,
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Lime,
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Fuchsia,
        System.Drawing.Color.Black,
        System.Drawing.Color.Maroon,
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
        System.Drawing.Color.Purple,
        System.Drawing.Color.Teal};
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.barChart.Series.Add(series2);
            this.barChart.Size = new System.Drawing.Size(1367, 449);
            this.barChart.TabIndex = 2;
            this.barChart.Text = "chart2";
            // 
            // stackChart
            // 
            chartArea3.Name = "ChartArea1";
            this.stackChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.stackChart.Legends.Add(legend3);
            this.stackChart.Location = new System.Drawing.Point(12, 12);
            this.stackChart.Name = "stackChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 4;
            this.stackChart.Series.Add(series3);
            this.stackChart.Size = new System.Drawing.Size(997, 537);
            this.stackChart.TabIndex = 1;
            this.stackChart.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "← Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1724, 1004);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.barChart);
            this.Controls.Add(this.stackChart);
            this.Name = "Graphs";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart stackChart;
        private System.Windows.Forms.Button button1;
    }
}