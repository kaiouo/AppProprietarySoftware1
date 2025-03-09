using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProprietarySoftware1
{
    public class Hotel
    {
        public Habitacion[,] Habitaciones { get; set; }
        public Dictionary<int, Reservacion> Reservaciones { get; set; }
        public Hotel()
        {
            Reservaciones = new Dictionary<int, Reservacion>();
            InicializeRooms();
        }


        private void InicializeRooms()
        {
            Habitaciones = new Habitacion[5, 10];

            for (int piso = 0; piso < 5; piso++)
            {
                for (int habitacion = 0; habitacion < 10; habitacion++)
                {
                    int nHabitacion = (piso + 1) * 100 + (habitacion + 1);
                    string tipo = getTipoHabitacion(piso, habitacion);
                    decimal precio = getPrecioHabitacion(tipo);
                    bool disponible = true;
                    Habitaciones[piso, habitacion] = new Habitacion(nHabitacion, tipo, precio, disponible);
                }

            }
        }

        public string getTipoHabitacionNumero(int numeroHabitacion)
        {

            for (int piso = 0; piso < 5; piso++)
            {
                for (int habitacion = 0; habitacion < 10; habitacion++)
                {
                    if (Habitaciones[piso, habitacion].Numero == numeroHabitacion)
                    {
                        return Habitaciones[piso, habitacion].Tipo;
                    }
                }
            }
            return "desconocido";
        }


        private string getTipoHabitacion(int piso, int habitacion)
        {
            if (piso == 0) { return "sencilla"; }
            if (habitacion == 1) { return "doble"; }
            return "suite";

        }
        private decimal getPrecioHabitacion(string tipo)
        {
            switch (tipo)
            {
                case "sencilla": return 100.00m;
                case "doble": return 150.00m;
                case "suite": return 250.00m;
                default: return 0m;
            }
        }

        public List<string> getHabitacionesDisponibles()
        {
            var habitacionesDisponibles = new List<string>();
            for (int piso = 0; piso < 5; piso++) {
                for (int habitacion = 0; habitacion < 10; habitacion++) {
                    if (Habitaciones[piso, habitacion].Disponible)
                    {
                        habitacionesDisponibles.Add($"habitación {Habitaciones[piso, habitacion].Numero}:" +
                            $" {Habitaciones[piso, habitacion].Tipo}, ${Habitaciones[piso, habitacion].Precio}");
                    }

                }
            }
            return habitacionesDisponibles;

        }
    }
}
