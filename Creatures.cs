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

        public override bool Check(ILike you) => you is Human || you is Cat;
    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override bool Check(ILike you) => you is Cat;
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override bool Check(ILike you) => true;
    }

    public class Spider : Animal
    {
        public Spider(string name) : base(name)
        {
        }

        public override bool Check(ILike you) => false;
    }
}