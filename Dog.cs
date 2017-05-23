namespace GenericPair
{
    public class Dog :Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override bool Check(ILike you)
        {
            return true;
        }
    }
}