using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProprietarySoftware1
{
    public class Reservacion
    {
        public Cliente Cliente { get; set; }
        public Habitacion Habitacion { get; set; }
        public int Dias { get; set; }
        public decimal MontoTotal { get; set; }


        public Reservacion(Cliente cliente, Habitacion habitacion, int dias, decimal montoTotal)
        {
            Cliente = cliente;
            Habitacion = habitacion;
            Dias = dias;
            MontoTotal = montoTotal;
        }
    }
}
