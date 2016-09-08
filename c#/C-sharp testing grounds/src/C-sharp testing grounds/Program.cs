using C_sharp_testing_grounds.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace C_sharp_testing_grounds
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Person p = new Person("Lisa",new DateTime(1993,07,27));

			print(p);

			p.Age = 5;

			print(p);

			p.name = "Lisa";

			print(p);


			p.calculateAge();

			print(p);

			p.addFiveToAge();

			print(p);

			p.ChangeName();

			print(p);

			hold();
		}

		public static void print(Person p)
		{
			Console.WriteLine(p.Name + " is " + p.Age + " years old");
		}

		public static void hold()
		{
			Console.ReadKey();
		}
	}
}
