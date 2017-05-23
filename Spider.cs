namespace GenericPair
{
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