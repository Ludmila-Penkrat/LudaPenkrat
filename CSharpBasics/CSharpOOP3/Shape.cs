using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    public abstract class Shape
    {
        private string _name;

        public Shape(string name)
        {
            Name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public abstract double GetVolume();

        public virtual void ShapeInfo()
        {
            Console.WriteLine($"The {GetType().Name} has name {Name}.");
        }
    }
}
