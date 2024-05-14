using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m5a_prueba_tec.Materiales
{
    public class Piedra : IMaterial
    {
        public double PrecioPorMetroCuadrado { get; }

        public Piedra(double precio)
        {
            PrecioPorMetroCuadrado = precio;
        }
    }
}
