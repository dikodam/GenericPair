using static System.Console;

namespace GenericPair
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 1
            Human hooman = new Human("Mensch");
            Cat gadse = new Cat("Katze");
            Dog doge = new Dog("Hund");
            Spider iThinkISpider = new Spider("Spinne");

            // 2
            PairList<Human, Animal> haustiere = new PairList<Human, Animal>();

            // 3
            haustiere.Add(new Pair<Human, Animal>(hooman, gadse));
            haustiere.Add(new Pair<Human, Animal>(hooman, doge));
            haustiere.Add(new Pair<Human, Animal>(hooman, iThinkISpider));

            // 4
            WriteLine("Haustiere:");
            foreach (Pair<Human, Animal> pair in haustiere)
            {
                WriteLine(pair);
            }

            // 5
            WriteLine("gute Paare: ");
            foreach (Pair<Human, Animal> pair in haustiere.FitTogether())
            {
                WriteLine(pair);
            }

            // 6
            WriteLine("schlechte Paare: ");
            foreach (Pair<Human, Animal> pair in haustiere.FitNotTogether())
            {
                WriteLine(pair);
            }
        }
    }
}