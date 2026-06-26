using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMensualSegundo
{
    internal class Camioneta : Vehiculo
    {
        private int numeroEjes;

        
        public Camioneta(int ejes, int horas)
        {
            this.numeroEjes = ejes;
            this.HorasEstancia = horas;
        }

        public int GetNumeroEjes()
        {
            return numeroEjes;
        }

        
        public override double CalcularTarifa()
        {
            
            return HorasEstancia * 45.00;
        }
    }
}
