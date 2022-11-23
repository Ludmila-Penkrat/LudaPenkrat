
namespace CSharpAdvanced
{
    public class Horse : ICloneable
    {
        public string? NickName { get; set; }
        public string? Color { get; set; }
        public double Age { get; set; }
        public string? Breed { get; set; }
        public double TailLength { get; set; }

        public Horse(string? nickName, string? color, double age, string? breed, double tailLength)
        {
            NickName = nickName;
            Color = color;
            Age = age;
            Breed = breed;
            TailLength = tailLength;
        }

        public object Clone()
        {
            return new Horse(NickName, Color, Age, Breed, TailLength);
        } 
     }
}
