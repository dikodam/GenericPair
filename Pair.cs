namespace GenericPair
{
    public class Pair<TA, TB> where TA : class, ILike where TB : class, ILike
    {
        public TA A { get; set; }
        public TB B { get; set; }

        public Pair()
        {

        }

        public Pair (TA a, TB b)
        {
            A = a;
            B = b;
        }

        public bool FitTogether()
        {
            return A.Check(B) && B.Check(A);
        }
    }
}