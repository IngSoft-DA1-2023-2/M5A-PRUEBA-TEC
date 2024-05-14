namespace PruebaTecnica
{
    public class Rectangular : Tile
    {
        public int Side { get; set; }
        public int Broad { get; set; }
        public override Material material { get; set; }
        Material MaterialTile { get; set; }
        
        public Rectangular(int side, int broad,Material material)
        {
            MaterialTile = material;
            Side = side;
            Broad = broad;
        }



        public override double CalculateArea()
        {
            return Side * Broad * MaterialTile.Price;
        }
        
    }
}