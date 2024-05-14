namespace Baldosas
{
    public class Cuadrado : IForma
    {
        public int Lado { get; set; }

        public Cuadrado(int lado)
        {
            Lado = lado;
        }

        public double Area()
        {
            return Lado * Lado;
        }
    }
}