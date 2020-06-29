using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virgin_and_Vilain
{
	interface IHero
	{
		string Id { get; set; }
		string Type { get; set; }
		void Description();
	}

	interface IVillain
	{
		string Id { get; set; }
		string Type { get; set; }
		void Description();

	}

	class Hero : IHero
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

	class Villain : IVillain
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
	class Program
	{
		static void Main(string[] args)
		{
			Hero hero = new Hero("Jim", "Superman");
			Villain villain = new Villain("Mr-Thunder", "Bad Guy");

			hero.Description();
			villain.Description();

			Console.ReadLine();
		}
	}
}