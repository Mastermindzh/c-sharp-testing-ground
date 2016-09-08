using Generics.Generics;
using System;

namespace Generics
{
	class Program
	{
		static void Main()
		{

			var p = new Program();

		}

		public Program()
		{
			var test = new DataType<string>();
			test.write("hello");

			Console.WriteLine(test.read());

			var secondTest = new DataType<double>();
			secondTest.write(5.5);

			Console.WriteLine(secondTest.read() * secondTest.read());

			Console.ReadKey();
		}
	}
}
