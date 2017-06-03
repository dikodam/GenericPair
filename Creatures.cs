namespace GenericPair
{
    /// <summary>
    /// this abstract class is a SICK HACK of the presented problem, since a <see cref="Human"/> isn't allowed to extend 
    /// the <see cref="Animal"/> class but is supposed to exactly act like one (programming wise at least). 
    /// Therefore in order to maintain SUPERIOR design, there exists this SUPERclass Creature which is extended by 
    /// <see cref="Human"/> and <see cref="Animal"/>.
    /// MAKE SOFTWARE DESIGN GREAT AGAIN!
    /// </summary>
    public abstract class Creature : ILike
    {
        /// <summary>
        /// the name of the creature that was given to it by its creator
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// a constructor that can be used to create an instance of Creature whilst giving it its <see cref="Name"/>.<br/>
        /// Except, it can not, since this class is abstract. #hacked
        /// </summary>
        public Creature(string name)
        {
            Name = name;
        }

        /// <summary>
        /// this class doesn't implement the methode prescribed by the <see cref="ILike"/> interface, 
        /// instead, it declares that an implementation is needed in the extending classes. sick design, right?
        /// </summary>
        public abstract bool Check(ILike you);

        /// <summary/>
        /// <returns> returns a string respresentation of the creature (its <see cref="Creature.Name"/>!)</returns>
        public override string ToString() => Name;
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