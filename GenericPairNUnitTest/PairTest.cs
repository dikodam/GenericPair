using GenericPair;
using NUnit.Framework;

// ReSharper disable InconsistentNaming
namespace GenericPairNUnitTest
{
    [TestFixture]
    public class PairTest
    {
        private class A : ILike
        {
            public bool Check(ILike you) => you is A;
        }

        private class B : ILike
        {
            public bool Check(ILike you) => true;
        }

        private class C : ILike
        {
            public bool Check(ILike you) => false;
        }

        private class D : ILike
        {
            public bool Check(ILike you) => you is D || you is B;
        }


        [Test]
        public void FitTogetherTest()
        {
            Pair<A, A> testedAA = new Pair<A, A>(new A(), new A());
            Pair<A, B> testedAB = new Pair<A, B>(new A(), new B());
            Pair<A, C> testedAC = new Pair<A, C>(new A(), new C());
            Pair<A, D> testedAD = new Pair<A, D>(new A(), new D());

            Pair<B, B> testedBB = new Pair<B, B>(new B(), new B());
            Pair<B, C> testedBC = new Pair<B, C>(new B(), new C());
            Pair<B, D> testedBD = new Pair<B, D>(new B(), new D());

            Pair<C, C> testedCC = new Pair<C, C>(new C(), new C());
            Pair<C, D> testedCD = new Pair<C, D>(new C(), new D());

            Pair<D, D> testedDD = new Pair<D, D>(new D(), new D());

            Assert.True(testedAA.FitTogether());
            Assert.False(testedAB.FitTogether());
            Assert.False(testedAC.FitTogether());
            Assert.False(testedAD.FitTogether());

            Assert.True(testedBB.FitTogether());
            Assert.False(testedBC.FitTogether());
            Assert.True(testedBD.FitTogether());

            Assert.False(testedCC.FitTogether());
            Assert.False(testedCD.FitTogether());

            Assert.True(testedDD.FitTogether());
        }
    }
}