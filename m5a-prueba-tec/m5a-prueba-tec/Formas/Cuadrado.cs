using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m5a_prueba_tec.Formas
{
    public class Cuadrado : IForma
    {
        public double Lado { get; }

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public double CalcularArea()
        {
            return Lado * Lado;
        }
    }
}
