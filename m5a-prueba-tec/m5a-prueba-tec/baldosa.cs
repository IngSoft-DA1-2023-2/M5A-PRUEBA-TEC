using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m5a_prueba_tec
{
    public class Baldosa
    {
        public IForma Forma { get; }
        public IMaterial Material { get; }

        public Baldosa(IForma forma, IMaterial material)
        {
            Forma = forma;
            Material = material;
        }

        public double CalcularPrecio()
        {
            return Forma.CalcularArea() * Material.PrecioPorMetroCuadrado;
        }
    }
}
