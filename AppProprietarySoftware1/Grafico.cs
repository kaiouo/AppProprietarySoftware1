using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppProprietarySoftware1
{
    public partial class Grafico : Form
    {
        private Hotel hotel;
        private List<Cliente> clientes;
        //private Habitacion habitacion;
        private Dictionary<int, Reservacion> reservaciones;
        public Grafico(Hotel hotel, List<Cliente> clientes, Dictionary<int, Reservacion> reservaciones)
        {
            InitializeComponent();
            this.hotel = hotel;
            //this.habitacion = habitacion;
            this.clientes = clientes;
            this.reservaciones = reservaciones;
           
            comboTipos();
        }
        private void comboTipos()
        {
            typesComboBox.Items.Clear();
            typesComboBox.Items.AddRange(new object[] { "sencilla", "doble", "suite" });
        }

        private void home_Click(object sender, EventArgs e)
        {
            Form1 mainForm = Application.OpenForms["Form1"] as Form1;
            if (mainForm != null)
            {
                mainForm.Show();
            }
            this.Close();
        }

        

        //Funcion que revisa el contenido de el comboBox y muestra los graficos dependiendo de el tipo de habitacion
        private void graficView_Click(object sender, EventArgs e)
        {
            //no se crea el grafico sin tener el dato
            String roomType = typesComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(roomType))
            {
                MessageBox.Show("Ingrese un dato");
            }
            else
            {
               
                grafico1.Series.Clear();
         
                string tipoaBuscar = roomType;
                Series serieR = new Series("Reservacion")
                {
                    ChartType = SeriesChartType.Column, Color = Color.LightBlue,
                    ["PointWidth"] = "0.8"
                };
              
             
                for (int piso = 1; piso <= 5; piso++)
                {
                    /*esta seccion se dividio en variables, porque al ser una declaracion de una linea daba errores que no se 
                        pudieron solucionar, para hacer mas compresible el codigo y evitar errores use variables para cada accion */
                    var todasLasReservas = reservaciones.Values;

                    var reservasFiltradas = todasLasReservas.Where(r => hotel.getTipoHabitacionNumero(r.Habitacion.Numero) == tipoaBuscar);

                    var reservasEnPiso = reservasFiltradas.Where(r => (r.Habitacion.Numero / 100) == piso);

                    int reser = reservasEnPiso.Count();

                    serieR.Points.AddXY($"Piso {piso}", reser);


                }

                //se agregan los datos en la serie, se utiliza un intervalo agradable para la vista y se usa un update y refresh para no tener datos inesperados

                grafico1.Series.Add(serieR);
                grafico1.ChartAreas[0].AxisY.Minimum = 0;
                grafico1.ChartAreas[0].AxisY.Interval = 1;
                grafico1.Update();
                grafico1.Refresh();
            }


        }


    }
}



