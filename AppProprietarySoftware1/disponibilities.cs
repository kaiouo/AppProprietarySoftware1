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
        public disponibilities(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
            Cargarhabitaciones();
        }

        private void Cargarhabitaciones()
        {           
            RoomsdataGridView.Columns.Add("Numero", "Numero");
            RoomsdataGridView.Columns.Add("Tipo", "Tipo");
            RoomsdataGridView.Columns.Add("Precio", "Precio");
            RoomsdataGridView.Columns.Add("Disponible", "Disponible");
            RoomsdataGridView.RowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
            RoomsdataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;


            DataGridViewButtonColumn btnReservar = new DataGridViewButtonColumn();
            btnReservar.HeaderText = "Acción";
            btnReservar.Text = "Reservar";
            btnReservar.UseColumnTextForButtonValue = true;
            RoomsdataGridView.Columns.Add(btnReservar);

            for (int piso = 0; piso < 5; piso++)
            {
                for (int habitacion = 0; habitacion < 10; habitacion++)
                {
                    Habitacion hab = hotel.Habitaciones[piso, habitacion];
                    RoomsdataGridView.Rows.Add(hab.Numero, hab.Tipo, hab.Precio, hab.Disponible ? "Sí" : "No");
                }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == RoomsdataGridView.Columns["Acción"].Index && e.RowIndex >= 0)
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
                    newbookings formReserva = new newbookings(hotel, habitacionSeleccionada);
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
