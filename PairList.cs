using System.Collections;

// ReSharper disable InconsistentNaming
namespace GenericPair
{
    public class PairList<T1, T2> : IEnumerable where T1 : class, ILike where T2 : class, ILike
    {
        class PairWrapper
        {
            public Pair<T1, T2> Data { get; }
            public PairWrapper Next { get; set; }

            public PairWrapper(Pair<T1, T2> pair)
            {
                Data = pair;
            }

            public bool HasNext => Next != null;
        }

        private PairWrapper first;

        public IEnumerator GetEnumerator()
        {
            PairWrapper current = first;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public void Add(Pair<T1, T2> pairToAdd)
        {
            if (first == null)
            {
                first = new PairWrapper(pairToAdd);
            }
            else
            {
                PairWrapper last = first;
                while (last.HasNext)
                {
                    last = last.Next;
                }
                last.Next = new PairWrapper(pairToAdd);
            }
        }

        public PairList<T1, T2> FitTogether()
        {
            PairList<T1, T2> fittingPairs = new PairList<T1, T2>();
            foreach (Pair<T1, T2> pair in this)
                if (pair.FitTogether())
                {
                    fittingPairs.Add(pair);
                }
            return fittingPairs;
        }

        public PairList<T1, T2> FitNotTogether()
        {
            PairList<T1, T2> notFittingPairs = new PairList<T1, T2>();
            foreach (Pair<T1, T2> pair in this)
                if (!pair.FitTogether())
                {
                    notFittingPairs.Add(pair);
                }
            return notFittingPairs;
        }
    }
}