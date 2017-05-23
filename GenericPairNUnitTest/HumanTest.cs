using System;
using GenericPair;
using NUnit.Framework;


namespace GenericPairNUnitTest
{
    [TestFixture]
    public class HumanTest
    {
        [Test]
        public void TestHumanName()
        {
            Human human = new Human("Peter");
            Assert.True(human.Name == "Peter");
            Assert.AreEqual(human.Name, "Peter");
        }

        [Test]
        public void PAssingTest()
        {
            Assert.AreEqual(4, Add(2, 2));
        }

        [Test]
        public void FailingTest()
        {
            Assert.AreEqual(5, Add(2, 2));
        }

        private int Add(int a, int b)
        {
            return a + b;
        }
    }
}