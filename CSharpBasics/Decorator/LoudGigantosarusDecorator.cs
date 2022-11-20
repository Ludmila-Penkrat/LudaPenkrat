//Components of decorator that extend additional functionality for concrete components.

using System.Text;

namespace Decorator
{
    public class LoudGigantosarusDecorator : IDenosaurusDecorator
    {
        private string _name;
        private IGigantosaurus _dinosaurus;

        public LoudGigantosarusDecorator(IGigantosaurus dinosaurus)
        {
            _name = "Uknown";
            _dinosaurus = dinosaurus;
        }

        public string Name => _name;

        public string Roar()
        {
            return new StringBuilder().Append(_dinosaurus.Roar()).Append(" \"And Myau!\"").ToString();
        }

        public void SetComponent(IGigantosaurus dinosaurus)
        {
            Console.WriteLine($"Gigantosaurus {dinosaurus.Name} with LOUD roar!");
        }
    }
}


