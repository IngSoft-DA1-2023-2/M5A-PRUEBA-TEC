using Domain.Enums;

namespace Domain;

public class CostoTamanioCalculator
{

    public static double GetCostoPorTamanio(Material material)
    {
        switch (material)
        {
            case Material.Ceramica:
                return 10;
            case Material.Porcelana:
                return 20;
            case Material.Piedra:
                return 30;
            default:
                return 0;
        }
        // Si se agrega un nuevo tamaño hay que agregar un nuevo case para obtener el costo
    }
}