using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    public class Ball : Shape
    {
        private double _radius;

        public Ball(string name, double radius) : base(name)
        {
            _radius = radius;
        }

        public override double GetVolume()
        {
            double ballVolume = Math.Round(((4 * Math.PI * Math.Pow(_radius, 3)) / 3), 2, MidpointRounding.AwayFromZero);
            return ballVolume;
        }

        public override void ShapeInfo()
        {
            Console.WriteLine($"This shape {GetType().Name} with name {Name} has raduis {_radius} cm and volume = {GetVolume()} cm3.\n");
        }
    }
}