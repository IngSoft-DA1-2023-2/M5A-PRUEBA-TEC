namespace Baldosas
{
    public class Baldosa
    {
        public IForma Area { get; set; }
        public IMaterial Material { get; set; }
        public List<Baldosa> ListaDeBaldosas { get; set; }

        public Baldosa(IForma area, IMaterial material)
        {
            ListaDeBaldosas = new List<Baldosa>();
            Area = area;
            Material = material;
        }
    }
}