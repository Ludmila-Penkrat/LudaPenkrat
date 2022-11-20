// Defined component that impements common component

namespace Decorator
{
    public class Gigantosaurus : IGigantosaurus
    {
        private string _name;

        public Gigantosaurus(string name)
        {
            _name = name;
        }

        public string Name => _name;

        public string Roar()
        {
            return $"Gigantosaurus {Name} roars: \"Rrrrrrrrr!\"";
        }
    }
}