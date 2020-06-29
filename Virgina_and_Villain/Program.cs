using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virgin_and_Vilain
{
    internal class Hero : IHero
    {
        public string Id { get; set; }
        public string Type { get; set; }

        public Hero(string id, string type)
        {
            Id = id;
            Type = type;
        }

        public void Description()
        {
            Console.WriteLine("A person who helps and save lives.");
        }
    }

    public class Spermetas : IHero
    {
        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Description()
        {
            Console.WriteLine("I much wow");
        }
    }

    internal class Villain : IVillain
    {
        public string Id { get; set; }
        public string Type { get; set; }

        public Villain(string id, string type)
        {
            Id = id;
            Type = type;
        }

        public void Description()
        {
            Console.WriteLine("Tries to kill everyone who is in front of his path.");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            IHero hero = new Spermetas("Jim", "Superman");
            IVillain villain = new Villain("Mr-Thunder", "Bad Guy");

            hero.Description();
            villain.Description();

            Console.ReadLine();
        }
    }
}