using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProprietarySoftware1
{
    public class Habitacion
    {
        public int Numero {  get; set; }
        public string Tipo {  get; set; }
        public decimal Precio { get; set; }
        public bool Disponible { get; set; }
        public Habitacion(int numero, string tipo, decimal precio, bool disponible) 
        
        {
            Numero = numero;
            Tipo = tipo;
            Precio = precio;
            Disponible = disponible;
        }
    }
}
