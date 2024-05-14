using m5a_prueba_tec;
using m5a_prueba_tec.Formas;
using m5a_prueba_tec.Materiales;

Console.WriteLine("Baldoseria");

Baldosa baldosa1 = new(new Cuadrado(2.0),new Ceramica(3.0));
Baldosa baldosa2 = new(new Triangulo(2.0,3.0), new Porcelana(3.0));
Baldosa baldosa3 = new(new Circulo(2.0), new Piedra(3.0));
List<Baldosa> baldosas = new()
            {
                baldosa1,
                baldosa2,
                baldosa3
            };

double area = Baldoseria.CalcularAreaTotal(baldosas);
double costo = Baldoseria.CalcularCostoTotal(baldosas);

Console.WriteLine("Area baldosas: "+ area);
Console.WriteLine("Costo baldosas: " + costo);

