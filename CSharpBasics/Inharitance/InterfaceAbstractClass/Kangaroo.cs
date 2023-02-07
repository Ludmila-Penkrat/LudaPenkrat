namespace Inharitance.InterfaceAbstractClass
{
    public class Kangaroo : Animal, IMovable, ISoundable
    {
        public Kangaroo(string name) : base(name)
        {
        }
        public override void GetInfo()
        {
            Console.WriteLine($"I'm {GetType().Name} with name {Name}");
        }

        public void Move()
        {
            Console.WriteLine($"I'm {GetType().Name} and I jumps");
        }

        public void MakeSound()
        {
            Console.WriteLine($"I'm {GetType().Name} with name {Name} and when I want to eat I make uf-uf");
        }
    }
}
