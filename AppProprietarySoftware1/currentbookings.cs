using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProprietarySoftware1
{
    public partial class currentbookings : Form
    {
        private Hotel hotel;
        private List<Cliente> clientes;
        private Dictionary<int, Reservacion> reservaciones;
        public currentbookings(Hotel hotel, List<Cliente> clientes, Dictionary<int, Reservacion> reservaciones)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.clientes = clientes;
            this.reservaciones = reservaciones;
            cargarReservaciones();
        }

        //funcion que llama al diccionario a un datagrid
        public void cargarReservaciones()
        {
            currentReservations.Columns.Add("habNum", "Numero de habitacion");
            currentReservations.Columns.Add("nNum", "Numero de noches");
            currentReservations.Columns.Add("monTotal", "Monto a pagar");
            currentReservations.RowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
            currentReservations.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;

            DataGridViewButtonColumn btnReservar = new DataGridViewButtonColumn();
            btnReservar.Name = "cancelar";
            btnReservar.HeaderText = "Acción";
            btnReservar.Text = "Cancelar";
            btnReservar.UseColumnTextForButtonValue = true;
            currentReservations.Columns.Add(btnReservar);


            foreach (var reservacion in reservaciones.Values)
            {
                currentReservations.Rows.Add(reservacion.Habitacion.Numero, reservacion.Dias, reservacion.MontoTotal);
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

        private void currentbookings_Load(object sender, EventArgs e)
        {

        }

        //funcion para cancelar reservaciones
        private void currentReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == currentReservations.Columns["cancelar"].Index && e.RowIndex >= 0)
            {
                //obtener numero de habitacion
                int numeroHabitacion = Convert.ToInt32(currentReservations.Rows[e.RowIndex].Cells["habNum"].Value);
                if (reservaciones.ContainsKey(numeroHabitacion)) { 
                    reservaciones.Remove(numeroHabitacion);
                    int piso = (numeroHabitacion / 100) - 1; 
                    int num = (numeroHabitacion % 100) - 1;
                    hotel.Habitaciones[piso,num].Disponible = true;
                    
                    MessageBox.Show("Reservacion borrada correctamente");
                }
            }
           

        }
    }
}
