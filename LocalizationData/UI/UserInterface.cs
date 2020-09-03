using System;
using System.Windows.Forms;
using System.IO;
using GMap.NET.MapProviders;
using GMap.NET;
using System.Data;

namespace LocalizationData
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
            loadDataGridView();
        }

        DataTable dt = new DataTable();
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
                    this.dt.Columns.Add(aux[i]);
                    
                }
                //dt.Columns.Add("djhk");
                

                for (int i = 1; i < lines.Length; i++)
                {
                    //going per line

                    //split the line by ","
                    string[] aux = lines[i].Split(',');
                    
                    dt.Rows.Add(aux);

                }
            }
            dataGridView1.DataSource = dt;
        }

        private void map_Load(object sender, EventArgs e)
        {
            map.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            map.Position = new PointLatLng(4.60971, -74.08175);
        }
    }
}
