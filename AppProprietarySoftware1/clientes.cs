using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppProprietarySoftware1
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Dui { get; set; }
        public string Telefono { get; set; }

        public Cliente(string nombre, string dui, string telefono)
        {
            Nombre = nombre;
            Dui = dui;
            Telefono = telefono;
        }
    }
}
