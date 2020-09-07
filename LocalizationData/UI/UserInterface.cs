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
        bool horarioSelected = false;
        bool direccionSelected = false;
        bool codigoSelected = false;
        bool telefonoSelected = false;
        bool emailSelected = false;
        bool departamentoSelected = false;
        List<string> Departamentos = new List<string>();
        List<string> Municipios = new List<string>();
        private List<PointLatLng> puntos;
        GMapOverlay markers = new GMapOverlay("markers");
        DataTable dt;
        Boolean hasMarkers = false;

        public UserInterface()
        {
            dt = new DataTable();
            dt.Columns.Add("UBICACION");
            dt.Columns.Add("TELEFONO");
            dt.Columns.Add("EMAIL");
            dt.Columns.Add("DiRECCION");
            dt.Columns.Add("MUNICIPIO");
            dt.Columns.Add("HORARIO");
            dt.Columns.Add("DEPARTAMENTO");
            dt.Columns.Add("CODIGO");
            dt.Columns.Add("LATITUD");
            dt.Columns.Add("LONGITUD");
            dt.Columns.Add("");


            puntos = new List<PointLatLng>();

            GoFullscreen();
            InitializeComponent();
            loadDataGridView();
            categorico.Hide();
            cadena.Hide();


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
               // m.ToolTipText = "\n" + p.Value.Lat + "\n" + pointLatLng1.Value.Lng; // Esta linea es solo apariencia
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

                        string s = aux[6];
                        string m = aux[0];
                        
                        Municipios.Add(m);
                        Departamentos.Add(s);
                        PointLatLng p = new PointLatLng(lat, lon);
                        puntos.Add(p);
                        dt.Rows.Add(aux);
                    }

                }
            }
            dataGridView1.DataSource = dt;
            
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

        private void chooseCategorico(object sender, EventArgs e)
        {

            if (departamentoSelected)
            {
                Console.WriteLine(categorico.Text);
                dt.DefaultView.RowFilter = $"DEPARTAMENTO LIKE '{categorico.Text}%'";
                
            
            }
            else
            {
                string c = "CALI";
                dt.DefaultView.RowFilter = $"MUNICIPIO LIKE '{categorico.Text}%'";
               
            }
           
           
        }

        private void choose(object sender, EventArgs e)
        {
            string cases = OptionsBox.Text;

            switch (cases)
            {
               /*  "telefono",
            "email",
            "direccion",
            "municipio",
            "horario",
            "departamento",
            "codigo postal",
               */
              

                case "Horario":
                     horarioSelected = true;
                     direccionSelected = false;
                     codigoSelected = false;
                    telefonoSelected = false;
                    emailSelected = false;
                    cadena.Show();
                    cadena.Clear();
                    categorico.Hide();
                    break;
                case "Departamento":
                    cadena.Hide();
                    cadena.Clear();
                    categorico.Show();
                    departamentoSelected = true;
               
                    fillCategorico();
                    break;
                case "Municipio":
                    cadena.Hide();
                    cadena.Clear();
                    categorico.Show();
                    categorico.Items.Clear();
                    departamentoSelected = false;
                    fillCategoricoMunicipios();
                    break;
                case "Direccion":
                     horarioSelected = false;
                     direccionSelected = true;
                     codigoSelected = false;
                    telefonoSelected = false;
                    emailSelected = false;
                    cadena.Show();
                    cadena.Clear();
                    categorico.Hide();
                    categorico.Items.Clear();
                    break;
                case "Codigo postal":
                     horarioSelected = false;
                     direccionSelected = false;
                     codigoSelected = true;
                    telefonoSelected = false;
                    emailSelected = false;
                    cadena.Show();
                    cadena.Clear();
                    categorico.Hide();
                    categorico.Items.Clear();
                   
                    break;
                case "Telefono":
                    horarioSelected = false;
                    direccionSelected = false;
                    codigoSelected = false;
                    telefonoSelected = true;
                    emailSelected = false;
                    cadena.Show();
                    cadena.Clear();
                    categorico.Hide();
                    categorico.Items.Clear();
                    break;
                case "Email":
                    horarioSelected = false;
                    direccionSelected = false;
                    codigoSelected = false;
                    telefonoSelected = false;
                    emailSelected = true;
                    cadena.Show();
                    cadena.Clear();
                    categorico.Hide();
                    categorico.Items.Clear();
                    break;
                default:
                    categorico.Hide();
                    categorico.Items.Clear();
                    cadena.Hide();
                    cadena.Clear();
                    break;
            }
        }


        private void fillCategorico() {

            categorico.Items.Clear();
          
                categorico.Items.Add("ANTIOQUIA");
                categorico.Items.Add("ATLANTICO");
                categorico.Items.Add("AMAZONAS");
                categorico.Items.Add("ANCHIPIELAGO DE SAN ANDRES");
                categorico.Items.Add("ARAUCA");
                categorico.Items.Add("BOGOTA D.C.");
                categorico.Items.Add("BOLIVAR");
                categorico.Items.Add("BOYACA");
                categorico.Items.Add("CALDAS");
                categorico.Items.Add("CAQUETA");
                categorico.Items.Add("CASANARE");
                categorico.Items.Add("CAUCA");
                categorico.Items.Add("CESAR");
                categorico.Items.Add("CHOCO");
                categorico.Items.Add("CORDOBA");
                categorico.Items.Add("CUNDINAMARCA");
                categorico.Items.Add("GUAINIA");
                categorico.Items.Add("GUAJIRA");
                categorico.Items.Add("HUILA");
                categorico.Items.Add("MAGDALENA");
                categorico.Items.Add("META");
                categorico.Items.Add("NARIÑO");
                categorico.Items.Add("NORTE DE SANTANDER");
                categorico.Items.Add("PUTUMAYO");
                categorico.Items.Add("QUINDIO");
                categorico.Items.Add("RIOHACHA");
                categorico.Items.Add("RISARALDA");
                categorico.Items.Add("SANTANDER");
                categorico.Items.Add("SUCRE");
                categorico.Items.Add("TOLIMA");
                categorico.Items.Add("VALLE DEL CAUCA");
                categorico.Items.Add("VOCHADA");






            }

        

        private void fillCategoricoMunicipios()
        {
            categorico.Items.Clear();
            foreach (string p in Municipios)
            {
                categorico.Items.Add(p);
            }

        }

        private void cadena_TextChanged(object sender, EventArgs e)
        {
           
            if (horarioSelected)
            {
                dt.DefaultView.RowFilter = $"HORARIO LIKE '{cadena.Text}%'";
                Console.WriteLine(cadena.Text);
            }
            else if (direccionSelected)
            {
                dt.DefaultView.RowFilter = $"DIRECCION LIKE '{cadena.Text}%'";
            }

            else if (codigoSelected)
            {
                dt.DefaultView.RowFilter = $"CODIGO LIKE '{cadena.Text}%'";
            }

            else if (telefonoSelected)
            {
                dt.DefaultView.RowFilter = $"TELEFONO LIKE '{cadena.Text}%'";
            }

            else if (emailSelected)
            {
                dt.DefaultView.RowFilter = $"EMAIL LIKE '{cadena.Text}%'";
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphs gr = new Graphs(dt);
            gr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!hasMarkers)
            {
                setMarkers();
                hasMarkers = true;
                button2.Text = "Esconder Marcadores";
            }
            else
            {
                markers.Clear();
                button2.Text = "Mostrar Marcadores";
                hasMarkers = false;
            }
            
        }
    }
}
