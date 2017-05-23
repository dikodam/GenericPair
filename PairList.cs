using System;
using System.Collections;

// ReSharper disable InconsistentNaming
namespace GenericPair
{
    /// <summary>
    /// linked list for reference types which implement the <see cref="ILike">ILike</see> interface
    /// </summary>
    /// <typeparam name="T1">first reference type of the pair, implements <see cref="ILike">ILike</see></typeparam>
    /// <typeparam name="T2">second reference type of the pair, implements <see cref="ILike">ILike</see></typeparam>
    public class PairList<T1, T2> : IEnumerable where T1 : class, ILike where T2 : class, ILike
    {
        #region internal wrapper

        /// <summary>
        /// internal wrapper class for list elements
        /// </summary>
        class PairWrapper
        {
            /// <summary>
            /// list element
            /// </summary>
            public Pair<T1, T2> Data { get; }

            /// <summary>
            /// reference to the next list element. may be null.
            /// </summary>
            public PairWrapper Next { get; set; }

            /// <summary>
            /// constructor for the wrapper. puts the given pair object into the wrapper.
            /// </summary>
            /// <param name="pair">a pair object to be hold by the wrapper. may not be null.</param>
            /// <exception cref="ArgumentException">thrown if pair is null</exception>
            public PairWrapper(Pair<T1, T2> pair)
            {
                if (pair == null)
                {
                    throw new ArgumentException("The content of the list may not be null!");
                }
                Data = pair;
            }

            /// <summary>
            /// <returns>if this wrapper object has a reference to a next wrapper object</returns>
            /// </summary>
            public bool HasNext => Next != null;
        }

        #endregion

        private PairWrapper first;

        public IEnumerator GetEnumerator()
        {
            for (PairWrapper current = first; current != null; current = current.Next)
                yield return current.Data;
        }

        /// <summary>
        /// adds the given parameter to the end of the list
        /// </summary>
        /// <param name="pairToAdd">the new pair to be added</param>
        /// <exception cref="ArgumentException">thrown if given pair is null</exception>
        public void Add(Pair<T1, T2> pairToAdd)
        {
            if (pairToAdd == null)
            {
                throw new ArgumentException("pair to be added may not be null");
            }
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