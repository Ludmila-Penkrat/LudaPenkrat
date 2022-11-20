
using System.Text;

namespace Decorator
{
    internal class ExtraLoudGigantosaurusDecorator : IDenosaurusDecorator
    {
        private string _name;
        private IGigantosaurus _gigantosaurus;

        public ExtraLoudGigantosaurusDecorator(IGigantosaurus gigantosaurus)
        {
            _name = "Uknown";
            _gigantosaurus = gigantosaurus;
        }

        public string Name => _name;

        public string Roar()
        {
            return new StringBuilder().Append(_gigantosaurus.Roar()).Append(" \"Extra!\"").ToString();
        }

        public void SetComponent(IGigantosaurus gigantosaurus)
        {
            Console.WriteLine($"Gigantosaurus {gigantosaurus.Name} with EXTRA LOUD roar!");
        }
    }
}
