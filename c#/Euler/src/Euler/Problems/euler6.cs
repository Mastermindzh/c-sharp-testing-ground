using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Euler.Problems
{
	public class euler6 : problem
	{
		/*
			The sum of the squares of the first ten natural numbers is,
			12 + 22 + ... + 102 = 385
			The square of the sum of the first ten natural numbers is,
			(1 + 2 + ... + 10)2 = 552 = 3025
			Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
			Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
		 */

		public euler6() 
		{
			int number = 100;
			Console.WriteLine(SquareOfSum(number) - sumOfSquare(number));
		}


		private double sumOfSquare(int boundary)
		{
			double sum = 0;
			for (int i = 0; i < boundary + 1; i++)
			{
				sum += i * i;
			}

			return sum;
		}

		private int SquareOfSum(int boundary)
		{
			int sum = 0;
			for (int i = 0; i < boundary + 1; i++)
			{
				sum += i;
			}

			return sum * sum;
		}
	}


}
