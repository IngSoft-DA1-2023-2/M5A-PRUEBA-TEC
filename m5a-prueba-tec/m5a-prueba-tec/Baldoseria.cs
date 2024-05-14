using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m5a_prueba_tec
{
    public class Baldoseria
    {
        public static double CalcularAreaTotal(List<Baldosa> baldosas)
        {
            double resultado = 0;
            foreach (Baldosa bal in baldosas)
            {
                resultado += bal.Forma.CalcularArea();
            }
            return resultado;
        }

        public static double CalcularCostoTotal(List<Baldosa> baldosas)
        {
            double resultado = 0;
            foreach (Baldosa bal in baldosas)
            {
                double area = bal.Forma.CalcularArea();
                double costoMaterial = bal.Material.PrecioPorMetroCuadrado;
                resultado += area * costoMaterial;
            }
            return resultado;
        }
    }
}
