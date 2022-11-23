// Decorator implements the interface of decorated components

namespace Decorator
{
    public interface IDenosaurusDecorator : IGigantosaurus
    {
        void SetComponent(IGigantosaurus gigantosaurus);
    }
}