using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m5a_prueba_tec.Materiales
{
    public class Porcelana : IMaterial
    {
        public double PrecioPorMetroCuadrado { get; }

        public Porcelana(double precio)
        {
            PrecioPorMetroCuadrado = precio;
        }
    }
}
