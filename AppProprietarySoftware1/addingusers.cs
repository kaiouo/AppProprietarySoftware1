using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppProprietarySoftware1
{
    public partial class addingusers : Form
    {
        //variable local
        private List<Cliente> usuarios;

        //llamar la lista ()
        public addingusers(List<Cliente> usuarios)
        {
            InitializeComponent();
            this.usuarios = usuarios;

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void adddata_Click(object sender, EventArgs e)
        {
            //se valida primero si los datos estan ingresados
            if (validateData())
            {
                //crear el objeto que se enviara a la lista
                Cliente nuevousuario = new Cliente(name.Text, dui.Text, phonenumber.Text);
                usuarios.Add(nuevousuario);
                MessageBox.Show("Nuevo usuario agregado correctamente");
                name.Text = string.Empty;
                dui.Text = string.Empty;
                phonenumber.Text = string.Empty;
            }


        }

        //validar si el form tiene datos
        private bool validateData()
        {

            bool isValid = true;

            if (string.IsNullOrEmpty(name.Text))
            {
                erpError.SetError(name, "Debe ingresar información");
                isValid = false;
            }
            else
            {
                erpError.SetError(name, "");
            }

            if (string.IsNullOrEmpty(dui.Text))
            {
                erpError.SetError(dui, "Debe ingresar un numero de identidad");
                isValid = false;
            }
            else
            {
                erpError.SetError(dui, "");
            }

            if (string.IsNullOrEmpty(phonenumber.Text))
            {
                erpError.SetError(phonenumber, "Debe ingresar un número de teléfono");
                isValid = false;
            }
            else
            {
                erpError.SetError(phonenumber, "");
            }

            return isValid;
        }

        //funcion para limpiar los txt
        private void clean_Click(object sender, EventArgs e)
        {

            name.Text = string.Empty;
            dui.Text = string.Empty;
            phonenumber.Text = string.Empty;
        }
    }
}
