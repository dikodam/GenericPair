namespace GenericPair
{
    public abstract class Creature : ILike
    {
        public string Name { get; }

        public Creature(string name)
        {
            Name = name;
        }

        public abstract bool Check(ILike you);
    }

    public abstract class Animal : Creature
    {
        public Animal(string name) : base(name)
        {
        }
    }
}