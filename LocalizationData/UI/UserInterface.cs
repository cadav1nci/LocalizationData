using System;
using System.Windows.Forms;
using System.IO;
using GMap.NET.MapProviders;
using GMap.NET;

namespace LocalizationData
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
            loadDataGridView();
        }

        private void loadDataGridView()
        {
            string dir = "../../data/data.csv";
            //string dir = "C:/Users/samue/Desktop/a.csv";
            if (File.Exists(dir))
            {
                
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(dir);
                string[] columns = lines[0].Split(',');

                for (int i = 0; i < columns.Length; i++)
                {
                    string[] aux = lines[0].Split(',');
                    this.dataGridView1.Columns.Add("column" + i, aux[i]);
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    //going per line

                    //split the line by ","
                    string[] aux = lines[i].Split(',');
                    string[] rowData = new string[aux.Length];


                    for (int j = 0; j < aux.Length; j++)
                    {
                        this.dataGridView1.Rows.Add(aux);
                    }

                }
            }
        }

        private void map_Load(object sender, EventArgs e)
        {
            map.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            map.Position = new PointLatLng(39.47649, -6.37224);
        }
    }
}
