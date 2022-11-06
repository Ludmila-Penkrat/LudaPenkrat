using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    public class Pyramid : Shape
    {
        private double _height;
        private double _baseArea;

        public Pyramid(string name, double height, double baseArea):base(name)
        {
            _height = height;
            _baseArea = baseArea;
        }

        public override double GetVolume() 
        {
            double piramidArea = Math.Round(((_height * _baseArea) / 3), 2, MidpointRounding.AwayFromZero);
            return piramidArea; 
        }
        
        public override void ShapeInfo()
        {
            Console.WriteLine($"This shape {GetType().Name} with name {Name} has height {_height} m, piramid base area {_baseArea} m2 and volume = {GetVolume()} m3.\n");
        }
    }
}
