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

        /// <summary/>
        /// <returns> returns the result of A.Check(B) AND B.Check(A)</returns>
        public bool FitTogether() => A.Check(B) && B.Check(A);

        /// <summary/>
        /// <returns>returns a string representation of the given pair object</returns>
        public override string ToString() => $"{A} + {B}";
    }
}