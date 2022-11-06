namespace CSharpOOP3
{
    public class Cylinder : Shape
    {
        private double _height;
        private double _radius;

        public Cylinder(string name, double height, double radius) : base(name)
        {
            _height = height;
            _radius = radius;
        }

        public override double GetVolume()
        {
            double cylinderdArea = Math.Round((Math.PI * Math.Pow(_radius, 2) * _height), 2, MidpointRounding.AwayFromZero);
            return cylinderdArea;
        }

        public override void ShapeInfo()
        {
            Console.WriteLine($"This shape {GetType().Name} with name {Name} has height {_height} cm, cylinder radius {_radius} cm and volume = {GetVolume()} cm3.\n");
        }
    }
}
