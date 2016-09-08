using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Euler.Problems
{
	public class euler9 : problem
	{

		public euler9()
		{
			int a = 0, b = 0, c = 0;
			int boundary = 1000;
			bool found = false;

			for (a = 1; a < boundary / 3; a++)
			{
				for (b = a; b < boundary / 2; b++)
				{
					//formula
					c = boundary - a - b;

					if (a * a + b * b == c * c)
					{
						found = true;
						break;
					}
				}

				if (found)
				{
					break;
				}
			}
			Console.WriteLine(String.Format("a = {0}  b= {1} c={2}", a,b,c));
			Console.WriteLine(String.Format("Sum = {0}",a+b+c));
			Console.WriteLine(String.Format("Product = {0}", a*b*c));
		}
	}
}
