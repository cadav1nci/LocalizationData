using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalizationData.UI
{
    public partial class Graphs : Form
    {
        private DataTable dt;
        public Graphs(DataTable data)
        {
            dt = data;
            InitializeComponent();
            LoadBarChart();
        }

        public void LoadBarChart()
        {
            List<string> regions = new List<string>();
            List<int> regionCount = new List<int>();
            //Console.WriteLine(dt.Rows[32][0]);
            //Console.WriteLine(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count - 5; i++)
            {
                if (regions.Contains(dt.Rows[i][0]))
                {
                    regionCount[i]++;
                    Console.WriteLine("CCCCCCCCCCCCCCCC");
                }
                else
                {
                    regions.Add(dt.Rows[i][0]+"");
                    regionCount.Add(1);
                    Console.WriteLine("RRRRRRRRRRRRRRRRRR");
                }
                
            }
            for(int i = 0; i < regions.Count; i++)
            {
                barChart.Series.Add(regions[i]);
            }
            
        }
    }
}
