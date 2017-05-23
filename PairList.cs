using System.Collections;
using System.ComponentModel;

namespace GenericPair
{
    public class PairList<TA, TB> : IEnumerable where TA : class, ILike where TB : class, ILike
    {
        class PairWrapper<T1, T2> where T1: class, TA where T2 : class, TB
        {
            public Pair<T1, T2> Data { get; set; }
            public PairWrapper<T1, T2> Next { get; set; }
        }

        private PairWrapper<TA, TB> first;


        public IEnumerator GetEnumerator()
        {
            while (first.Next != null)
            {
                yield return first;
            }

        }

        public void Add(Pair<TA, TB> pairToAdd)
        {

        }

        public PairList<TA, TB> FitTogether()
        {
            return new PairList<TA, TB>();
        }

        public PairList<TA, TB> FitNotTogether()
        {
            return new PairList<TA, TB>();
        }
    }
}