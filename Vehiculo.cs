using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMensualSegundo
{
    public abstract class Vehiculo
    {
        public int HorasEstancia { get; set; }

        public Vehiculo(int horas)
        {
            HorasEstancia = horas;
        }

        public abstract double Calcular();
    }
}
