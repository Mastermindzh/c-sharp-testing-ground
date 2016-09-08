using Euler.Shared;
using System;

namespace Euler.Problems
{
    public class euler5 : problem
	{
		/*
			2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
			What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
		*/
		public euler5() {
			String smallestDivisible = "";

			int counter = 1;

			while (smallestDivisible.Equals("")) {
				if (MathMethods.isDivisibleByRange(counter, 20))
				{
					smallestDivisible = Convert.ToString(counter);
				}
				else {
					counter++;
				}
			}
			Console.WriteLine(smallestDivisible);
		}

	
	}

}
