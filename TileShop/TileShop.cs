namespace TileShop
{
    public class Material
    {
        private double _cost;
        public string Name { get; set; }

        public double Cost
        {
            get => _cost;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Cost), "Cost must be non-negative");
                }

                _cost = value;
            }
        }

        public Material(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
    }

    public abstract class Tile
    {
        public Material Material { get; set; }

        protected Tile(Material material)
        {
            Material = material;
        }

        public abstract float CalculateAreaInSquareMeters();
        public double CalculateCost() => Material.Cost * CalculateAreaInSquareMeters();
    }

    public class SquareTile : Tile
    {
        private float _sideLengthInMeters;

        public float SideLengthInMeters
        {
            get => _sideLengthInMeters;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(SideLengthInMeters), "Side length must be positive");
                }
                _sideLengthInMeters = value;
            }
        }

        public SquareTile(Material material, float sideLengthInMeters) : base(material)
        {
            SideLengthInMeters = sideLengthInMeters;
        }

        public override float CalculateAreaInSquareMeters() => SideLengthInMeters * SideLengthInMeters;
    }

    public class RectangleTile : Tile
    {
        private float _baseInMeters;
        private float _heightInMeters;

        public float BaseInMeters
        {
            get => _baseInMeters;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(BaseInMeters), "Base must be positive");
                }

                _baseInMeters = value;
            }
        }

        public float HeightInMeters
        {
            get => _heightInMeters;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(HeightInMeters), "Height must be positive");
                }

                _heightInMeters = value;
            }
        }

        public RectangleTile(Material material, float baseInMeters, float heightInMeters) : base(material)
        {
            BaseInMeters = baseInMeters;
            HeightInMeters = heightInMeters;
        }

        public override float CalculateAreaInSquareMeters() => BaseInMeters * HeightInMeters;
    }

    public class CircleTile : Tile
    {
        private float _radiusInMeters;

        public float RadiusInMeters
        {
            get => _radiusInMeters;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(RadiusInMeters), "Radius must be positive");
                }
                _radiusInMeters = value;
            }
        }

        public CircleTile(Material material, float radiusInMeters) : base(material)
        {
            RadiusInMeters = radiusInMeters;
        }

        public override float CalculateAreaInSquareMeters() => MathF.PI * RadiusInMeters * RadiusInMeters;
    }
}