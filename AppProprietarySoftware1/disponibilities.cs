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

    public partial class disponibilities : Form
    {
        private Hotel hotel;
        private List<Cliente> clientes;
        private Dictionary<int, Reservacion>reservaciones;
        public disponibilities(Hotel hotel, List<Cliente>clientes, Dictionary<int, Reservacion>reservaciones)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.clientes = clientes;
            this.reservaciones = reservaciones;
            Cargarhabitaciones();
        }

        //funcion que permite obtener todas las habitaciones
        private void Cargarhabitaciones()
        {           
            //creacion del diseno de columnas
            RoomsdataGridView.Columns.Add("Numero", "Numero");
            RoomsdataGridView.Columns.Add("Tipo", "Tipo");
            RoomsdataGridView.Columns.Add("Precio", "Precio");
            RoomsdataGridView.Columns.Add("Disponible", "Disponible");
            RoomsdataGridView.RowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
            RoomsdataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;

            //una linea de botones para hacer la accion de reservar
            DataGridViewButtonColumn btnReservar = new DataGridViewButtonColumn();
            btnReservar.Name = "Accion";
            btnReservar.HeaderText = "Acción";
            btnReservar.Text = "Reservar";
            btnReservar.UseColumnTextForButtonValue = true;
            RoomsdataGridView.Columns.Add(btnReservar);
            
            //las habitaciones
            for (int piso = 0; piso < 5; piso++)
            {
                for (int habitacion = 0; habitacion < 10; habitacion++)
                {
                    Habitacion hab = hotel.Habitaciones[piso, habitacion];
                    RoomsdataGridView.Rows.Add(hab.Numero, hab.Tipo, hab.Precio, hab.Disponible ? "Sí" : "No");
                }
            }

        }

        //volver al form principal

        private void home_Click(object sender, EventArgs e)
        {
            Form1 mainForm = Application.OpenForms["Form1"] as Form1;
            if (mainForm != null)
            {
                mainForm.Show();
            }
            this.Close();
        }

        //funcion para revisar si la habitacion esta disponible y abrir el Form de reserva
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == RoomsdataGridView.Columns["Accion"].Index && e.RowIndex >= 0)
            {   
                //obtener numero
                int numeroHabitacion = Convert.ToInt32(RoomsdataGridView.Rows[e.RowIndex].Cells["Numero"].Value);

                // Buscar la habitación 
                Habitacion habitacionSeleccionada = null;
                for (int piso = 0; piso < 5; piso++)
                {
                    for (int habitacion = 0; habitacion < 10; habitacion++)
                    {
                        if (hotel.Habitaciones[piso, habitacion].Numero == numeroHabitacion)
                        {
                            habitacionSeleccionada = hotel.Habitaciones[piso, habitacion];
                            break;
                        }
                    }
                }

                // Abrir form para hacer la reserva
                if (habitacionSeleccionada != null && habitacionSeleccionada.Disponible)
                {
                    newbookings formReserva = new newbookings(hotel, habitacionSeleccionada, clientes, reservaciones);
                    formReserva.ShowDialog();
                }
                else
                {
                    MessageBox.Show("La habitación ya está reservada.");
                }
            }
        }
        }
}
