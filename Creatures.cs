using GenericPair;

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

    public class Human : Creature
    {
        public Human(string name) : base(name)
        {
        }

        public override bool Check(ILike you)
        {
            return you is Human || you is Cat;
        }
    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override bool Check(ILike you)
        {
            return you is Cat;
        }
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override bool Check(ILike you)
        {
            return true;
        }
    }

    public class Spider : Animal
    {
        public Spider(string name) : base(name)
        {
        }

        public override bool Check(ILike you)
        {
            return false;
        }
    }
}