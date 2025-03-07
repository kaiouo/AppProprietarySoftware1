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
    public partial class newbookings : Form
    {
        private Hotel hotel;
        private Habitacion habitacion;
        public newbookings(Hotel hotel, Habitacion habitacion)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.habitacion = habitacion;

            habitacionselecionada.Text = habitacion.Numero.ToString() + " " + habitacion.Tipo + " " + habitacion.Numero.ToString();

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
    }
}
