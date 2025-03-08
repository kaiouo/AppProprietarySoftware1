using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace AppProprietarySoftware1
{
    public partial class newbookings : Form
    {


        private DateTime fechaInicio; //crear variables
        private DateTime fechaFin;
        private Hotel hotel; //llamando clases
        private Habitacion habitacion;
        private List<Cliente> clientes; //llamar lista de clientes
        private Dictionary<int, Reservacion>reservaciones; //lamar al diccionario

        public newbookings(Hotel hotel, Habitacion habitacion,List<Cliente>clientes ,Dictionary<int, Reservacion> reservaciones)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.habitacion = habitacion;
            this.clientes = clientes;
            this.reservaciones = reservaciones;
            habitacionselecionada.Text = "Numero de Habitación: " + habitacion.Numero.ToString() + "  Tipo: " + habitacion.Tipo + " Precio por noche: $" + habitacion.Precio.ToString();
            this.reservaciones = reservaciones;
            clientsComboBox();
        }

        private void clientsComboBox()
        {
                clientList.Items.Clear();
                foreach (var cliente in clientes)
                {
                    clientList.Items.Add(cliente.Nombre);
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = Application.OpenForms["Form1"] as Form1;
            if (mainForm != null)
            {
                mainForm.Show();
            }
            this.Close();
        }

        private void newbookings_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            fechaFin = dateTimePicker2.Value.Date;

            CalcularMonto();
        }
        public void CalcularMonto()
        {

            fechaInicio = dateTimePicker1.Value.Date;

            if (fechaFin > fechaInicio)
            {

                TimeSpan diferencia = fechaFin - fechaInicio;
                int dias = diferencia.Days;
                numeronoches.Text = dias.ToString();
                decimal montoTotal = dias * habitacion.Precio;
                pagoTotal.Text = montoTotal.ToString();
            }
        }

        private void dias_Click(object sender, EventArgs e)
        {

        }

        private void addreservation_Click(object sender, EventArgs e)
        {   
            //tomando el nombre del comboBox
            String Nombrecliente = clientList.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(Nombrecliente))
            {
                MessageBox.Show("Ingrese un usuario ");
                return;
            }
            Cliente clienteSeleccionado = clientes.FirstOrDefault(c => c.Nombre == Nombrecliente);

            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Cliente no encontrado.");
                return;
            }

            //creando la reservacion
            Reservacion reservacion = new Reservacion (
                clienteSeleccionado,
                habitacion,
                int.Parse(numeronoches.Text),
                decimal.Parse(pagoTotal.Text)
            );
            reservaciones[habitacion.Numero] = reservacion; //agregar datos al diccionario
            habitacion.Disponible = false;
            MessageBox.Show(" Reservacion creada correctamente ");
            }

        private void clientList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
