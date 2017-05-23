namespace GenericPair
{
    public class Pair<T1, T2> where T1 : class, ILike where T2 : class, ILike
    {
        public T1 A { get; }
        public T2 B { get; }

        public Pair(T1 a, T2 b)
        {
            A = a;
            B = b;
        }

        public bool FitTogether() => A.Check(B) && B.Check(A);
    }
}