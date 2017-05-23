using GenericPair;
using NUnit.Framework;

namespace GenericPairNUnitTest
{
    [TestFixture]
    public class CreaturesTest
    {

        private class SmallCreature : Creature
        {
            public SmallCreature(string name) : base(name)
            {
            }

            public override bool Check(ILike you)
            {
                throw new System.NotImplementedException();
            }
        }

        [Test]
        public void CreatureTest()
        {
            SmallCreature tested = new SmallCreature("Horst");
            Assert.AreEqual("Horst", tested.Name);
        }
    }
}