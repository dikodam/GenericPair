using System;
using System.Text;

namespace GenericPair
{
    public class Human : Animal
    {
        public Human(string name) : base(name)
        {
        }

        public override bool Check(ILike you)
        {
            return (you is Cat) || (you is Human);
        }
    }
}