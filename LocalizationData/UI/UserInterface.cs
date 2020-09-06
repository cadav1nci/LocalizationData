using System;
using System.Windows.Forms;
using System.IO;
using GMap.NET.MapProviders;
using GMap.NET;
using System.Data;
using System.Collections.Generic;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using LocalizationData.UI;

namespace LocalizationData
{
    public partial class UserInterface : Form
    {
        private List<PointLatLng> puntos;
        GMapOverlay markers = new GMapOverlay("markers");
        DataTable dt;

        public UserInterface()
        {
            dt = new DataTable();
            puntos = new List<PointLatLng>();

            GoFullscreen();
            InitializeComponent();
            loadDataGridView();
            

        }

        private void GoFullscreen()
        {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        }

        private void setMarkers()
        {            
            foreach (PointLatLng p in puntos)
            {
                GMapMarker m = new GMarkerGoogle(p, GMarkerGoogleType.green_dot);
                markers.Markers.Add(m);
            }
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
                    this.dt.Columns.Add(aux[i]);
                    
                }
              
                for (int i = 1; i < lines.Length; i++)
                {
                    //split the line by ","
                    string[] aux = lines[i].Split(',');
                 
                    if (aux.Length<11) {
                        continue;
                    }
                    else {

                        double lat = double.Parse(aux[9]);
                        double lon = double.Parse(aux[8]);


                        PointLatLng p = new PointLatLng(lat, lon);
                        puntos.Add(p);
                        dt.Rows.Add(aux);
                    }

                }
            }
            dataGridView1.DataSource = dt;
            setMarkers();
        }

        private void map_Load(object sender, EventArgs e)
        {
            map.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            map.Position = new PointLatLng(4.60971, -74.08175);
            map.Overlays.Add(markers);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void choose(object sender, EventArgs e)
        {
            Console.Write(OptionsBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphs gr = new Graphs(dt);
            gr.Show();
        }
    }
}
