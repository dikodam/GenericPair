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

        private Human human = new Human("hooman");
        private Cat cat = new Cat("gadse");
        private Dog dog = new Dog("doge");
        private Spider spider = new Spider("i think i spider");


        [Test]
        public void CreatureTest()
        {
            SmallCreature tested = new SmallCreature("Horst");
            Assert.AreEqual("Horst", tested.Name);
        }

        public void HumanNameTest()
        {
            Human tested = new Human("Fritz");
            Assert.AreEqual(tested.Name, "Fritz");
        }

        public void HumanLikeTest()
        {
            Assert.IsTrue(human.Check(human));
            Assert.IsTrue(human.Check(cat));
            Assert.IsFalse(human.Check(dog));
            Assert.IsFalse(human.Check(spider));
        }

        public void CatLikeTest()
        {
            Assert.IsTrue(cat.Check(cat));
            Assert.IsFalse(cat.Check(human));
            Assert.IsFalse(cat.Check(dog));
            Assert.IsFalse(cat.Check(spider));
        }

        public void DogLikeTest()
        {
            Assert.IsTrue(dog.Check(dog));
            Assert.IsTrue(dog.Check(human));
            Assert.IsTrue(dog.Check(cat));
            Assert.IsTrue(dog.Check(spider));
        }

        public void SpiderLikeTest()
        {
            Assert.IsFalse(spider.Check(spider));
            Assert.IsFalse(spider.Check(human));
            Assert.IsFalse(spider.Check(cat));
            Assert.IsFalse(spider.Check(dog));
        }

    }
}