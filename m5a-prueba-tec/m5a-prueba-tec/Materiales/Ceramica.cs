using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m5a_prueba_tec.Materiales
{
    public class Ceramica : IMaterial
    {
        public double PrecioPorMetroCuadrado { get; }

        public Ceramica(double precio)
        {
            PrecioPorMetroCuadrado = precio;
        }
    }
}
