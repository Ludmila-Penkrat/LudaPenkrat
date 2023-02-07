namespace Inharitance.InterfaceAbstractClass
{
    public class Cat : Animal, IMovable, ISoundable
    {
        public Cat(string name) : base(name)
        {
        }
        public override void GetInfo()
        {
            Console.WriteLine($"I'm {GetType().Name} with name {Name}");
        }

        public void Move()
        {
            Console.WriteLine($"I'm {GetType().Name} and I runs, playes, sleeps");
        }

        public void MakeSound()
        {
            Console.WriteLine($"I'm {GetType().Name} with name {Name} and when I want to eat I make may-may");
        }
    }
}
