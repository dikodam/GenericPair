namespace GenericPair
{
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
}