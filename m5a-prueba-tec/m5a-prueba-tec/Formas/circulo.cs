using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m5a_prueba_tec.Formas
{
    public class Circulo : IForma
    {
        public double Radio { get; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio,2);
        }
    }   
}
