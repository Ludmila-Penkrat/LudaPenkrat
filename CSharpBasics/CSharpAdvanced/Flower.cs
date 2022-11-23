
namespace CSharpAdvanced
{
    public class Flower
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public decimal PricePerItem { get; set; }
        
        public Flower(string name, string color, decimal pricePerItem)
        {
            Name = name;
            Color = color;
            PricePerItem = pricePerItem;
        }

        public override string ToString()
        {
            return $"\n{GetType().Name}" + 
                $"\nSort: {Name}" +
                $"\nColor: {Color}" +
                $"\nPrice per item: {PricePerItem}";
        }
    }
}
