namespace PruebaTecnica
{
    public abstract class Tile
    {
        public abstract Material material { get; set; }
        
        public abstract double CalculateArea();
    }
}