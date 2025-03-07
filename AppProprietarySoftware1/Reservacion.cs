using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProprietarySoftware1
{
    internal class Reservacion
    {
        public Cliente Cliente { get; set; }
        public Habitacion Habitacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
     

        public Reservacion(Cliente cliente, Habitacion habitacion, DateTime fechaInicio, DateTime fechaFin)
        {
            Cliente = cliente;
            Habitacion = habitacion;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }
    }
}
