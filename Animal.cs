using System.ComponentModel.Design;

namespace GenericPair
{
    public abstract class Animal : ILike
    {
        public string Name { get; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract bool Check(ILike you);
        public override string ToString()
        {
            return $"Hallo ich bims, 1 {Name}";
        }
    }
}