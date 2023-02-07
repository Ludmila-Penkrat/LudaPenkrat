namespace Inharitance.InterfaceAbstractClass
{
    public abstract class Animal
    {
        private string _name;

        public Animal(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public abstract void GetInfo();


    }
}
