using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LocalizationData.UI
{
    public partial class Graphs : Form
    {
        private DataTable dt;
        public Graphs(DataTable data)
        {
            dt = data;
            GoFullscreen();
            InitializeComponent();
            LoadBarChart();
            LoadPieChart();
            LoadRadarChart();
        }

        private void GoFullscreen()
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        }

        public void LoadBarChart()
        {
            List<string> regions = new List<string>();
            List<int> regionCount = new List<int>();
            //Console.WriteLine(dt.Rows[32][0]);
            //Console.WriteLine(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count - 5; i++)
            {
                if (regions.Contains(dt.Rows[i][6]))
                {
                    regionCount[regions.IndexOf(dt.Rows[i][6]+"")]++;
                }
                else
                {
                    regions.Add(dt.Rows[i][6]+"");
                    regionCount.Add(1);
                }
                
            }
            for(int i = 0; i < regions.Count; i++)
            {
                
                Series s = this.barChart.Series.Add(regions[i]);
                s.Points.Add(regionCount[i]);
            }
            
        }

         public void LoadPieChart()
        {
            pieChart.Series.Clear();

            //Add a new chart-series
            string seriesname = "Pie Chart";
            pieChart.Series.Add(seriesname);
            //set the chart-type to "Pie"
            pieChart.Series[seriesname].ChartType = SeriesChartType.Pie;

            List<string> regions = new List<string>();
            List<int> regionCount = new List<int>();
            //Console.WriteLine(dt.Rows[32][0]);
            //Console.WriteLine(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count ; i++)
            {
                if (regions.Contains(dt.Rows[i][6]))
                {
                    regionCount[regions.IndexOf(dt.Rows[i][6] + "")]++;
                }
                else
                {
                    regions.Add(dt.Rows[i][6] + "");
                    regionCount.Add(1);
                }

            }
            for (int i = 0; i < regions.Count; i++)
            {

                pieChart.Series[seriesname].Points.AddXY(regions[i], regionCount[i]);
                pieChart.Series[seriesname].Points[i].Label = " ";
                pieChart.Series[seriesname].Points[i].LegendText = regions[i];
            }
        }

        public void LoadRadarChart()
        {
            List<string> regions = new List<string>();
            List<int> regionCount = new List<int>();
            //Console.WriteLine(dt.Rows[32][0]);
            //Console.WriteLine(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (regions.Contains(dt.Rows[i][6]))
                {
                    regionCount[regions.IndexOf(dt.Rows[i][6] + "")]++;
                }
                else
                {
                    regions.Add(dt.Rows[i][6] + "");
                    regionCount.Add(1);
                }

            }
            for(int i = 0; i < regions.Count; i++)
            {
                //radarChart.Series.Add(regions[i]);
                lineChart.Series["Series1"].Points.AddXY(regions[i], regionCount[i]);
            }
            //lineChart.ChartAreas.
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
