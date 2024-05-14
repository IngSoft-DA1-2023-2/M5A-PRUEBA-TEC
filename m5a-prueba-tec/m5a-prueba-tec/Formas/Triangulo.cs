using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m5a_prueba_tec.Formas
{
    public class Triangulo : IForma
    {
        public double Base { get; }
        public double Altura { get; }

        public Triangulo(double basee,double altura)
        {
            Base = basee;
            Altura = altura;
        }

        public double CalcularArea()
        {
            return (Base*Altura)/2;
        }
    }
}
